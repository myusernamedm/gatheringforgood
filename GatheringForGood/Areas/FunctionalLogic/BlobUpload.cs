using Azure.Storage;
using Azure.Storage.Blobs;
using GatheringForGood.Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class BlobUpload
    {
        private readonly DBConnectionStringFactory _DBConnectionStringFactory = new();
        private readonly BlobActions _BlobActions = new();

        public async Task<List<string>> uploadBlobToAzure(string UserIDValue, List<IFormFile> images, string uniqueReferenceValue, string AccessType)
        {
            List<string> ImageUrls = new();
            ImageUrls.Clear();

            int i = 0;

            foreach (var image in images)
            {
                string Image_UploadFileName;
                if (image != null)
                {
                    if(i == 0)
                    {
                        Image_UploadFileName = uniqueReferenceValue + "/" + image.ContentType.ToString().Replace("/", "title.");

                    } else
                    {
                        var imageFileNumber = i + 1;
                        Image_UploadFileName = uniqueReferenceValue + "/" + image.ContentType.ToString().Replace("/", imageFileNumber + ".");
                    }
                    var filePath = Path.GetTempFileName();
                    using (var stream = File.Create(filePath))
                    {
                        Debug.WriteLine("************** Trigger BlobActions getBlobUri");
                        Uri blobUri = _BlobActions.getBlobUri(UserIDValue, Image_UploadFileName);
                        Debug.WriteLine("************** BlobActions getBlobUri Completed");

                        ImageUrls.Add(blobUri.ToString());

                        Debug.WriteLine("************** Trigger BlobActions createContainerClient");
                        await _BlobActions.createContainerClient(_BlobActions.getConnectionString(), UserIDValue, AccessType);
                        Debug.WriteLine("************** BlobActions createContainerClient Completed");

                        Debug.WriteLine("************** Trigger uploadBlob");
                        await uploadBlob(blobUri, stream, image);
                        Debug.WriteLine("************** uploadBlob Completed");
                    }
                }
                else
                {
                    ImageUrls.Add(null);
                }
                i++;
            }

            return ImageUrls;
        }

        public async Task uploadBlob(Uri blobUri, FileStream stream, IFormFile ImageUrl)
        {
            string gfgImagesConnectionString = _DBConnectionStringFactory.gfgImagesConnectionString();

            StorageSharedKeyCredential storageCredentials = new StorageSharedKeyCredential("gatheringforgoodimages", gfgImagesConnectionString);
            BlobClient blobClient = new BlobClient(blobUri, storageCredentials);
            await ImageUrl.CopyToAsync(stream);
            stream.Position = 0;
            await blobClient.UploadAsync(stream);
        }

    }
}
