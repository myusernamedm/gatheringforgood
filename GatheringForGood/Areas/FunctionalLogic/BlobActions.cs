using Azure.Storage;
using Azure.Storage.Blobs;
using GatheringForGood.Data;
using ImageUrlReferenceLibrary;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class BlobActions
    {

        public string getConnectionString()
        {
            string connecString = Environment.GetEnvironmentVariable("AZURE_STORAGE_CONNECTION_STRING");

            return connecString;
        }

        public async Task<BlobContainerClient> createContainerClient(string connectionString, string containerName, string AccessType)
        {
            var containerClient = new BlobContainerClient(connectionString, containerName);

            if(AccessType != null)
            {
                var accessType = getAccessType(AccessType);
                await containerClient.CreateIfNotExistsAsync(accessType);
                return containerClient;
            } 
            else
            {
                return containerClient;
            }
        }

        public Uri getBlobUri(string containerName, string subFolderAndFilename)
        {
            Uri blobUri = new Uri("https://" + "gatheringforgoodimages.blob.core.windows.net/" + containerName + "/" + subFolderAndFilename);

            return blobUri;
        }

        public Azure.Storage.Blobs.Models.PublicAccessType getAccessType(string type)
        {
            switch (type)
            {
                case "Blob":
                    var accessTypeBlob = Azure.Storage.Blobs.Models.PublicAccessType.Blob;
                    return accessTypeBlob;

                case "Public":
                    var accessTypePublic = Azure.Storage.Blobs.Models.PublicAccessType.None;
                    return accessTypePublic;

                default:
                    var accessTypeBlob1 = Azure.Storage.Blobs.Models.PublicAccessType.Blob;
                    return accessTypeBlob1;
            }
        }
    }
}
