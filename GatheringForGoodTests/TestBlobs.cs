using System;
using Xunit;
using UITestStringsLibrary;
using GatheringForGood.Areas.FunctionalLogic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Azure.Storage.Blobs;
using Azure;
using System.Diagnostics;
using System.Threading;
using ImageUrlReferenceLibrary;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;
using System.Linq;

namespace GatheringForGood.UnitTests
{

    public class TestBlobs
    {
        CrossPageSharedUITestStrings _CrossPageSharedUITestStrings = new();
        readonly GenerateUniqueReferenceValue _GenerateUniqueReferenceValue = new();
        private BlobUpload _uploadBlobs = new();
        private BlobDelete _DeleteBlobs = new();
        private BlobActions _BlobActions = new();

        public async Task<IFormFile> GetFile()
        {
            TestingImageUrls _TestingImageUrls = new();
            var stream = File.OpenRead(_TestingImageUrls.GetValidJpgImageThumbnailUrlForTesting());
            var file = new FormFile(stream, 0, stream.Length, null, Path.GetFileName(stream.Name))
            {
                Headers = new HeaderDictionary(),
                ContentType = "application/jpg"
            };

            return file;
        }


        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public async Task TestUpload_and_Delete_Blobs_and_UniqueReferenceValue_ForCreateArticlePageIsCorrect()
        {
            var UserIDValue = _CrossPageSharedUITestStrings.Test5UserId();
            var uniqueReferenceValue = _GenerateUniqueReferenceValue.GetGUIDValue().ToString();
            List<string> ImageUrls = new();
            int countRefValue = uniqueReferenceValue.Length;
            string character = "-";
            int countCharacterInstances = uniqueReferenceValue.Split(character).Length - 1;
            IFormFile TitleImageUrl = await GetFile();
            IFormFile Image2Url = null;
            IFormFile Image3Url = null;
            IFormFile Image4Url = null;
            IFormFile Image5Url = null;
            IFormFile Image6Url = null;
            IFormFile Image7Url = null;
            IFormFile Image8Url = null;
            IFormFile Image9Url = null;
            IFormFile Image10Url = null;
            IFormFile Image11Url = null;
            IFormFile Image12Url = null;
            IFormFile Image13Url = null;
            IFormFile Image14Url = null;
            IFormFile Image15Url = null;
            IFormFile Image16Url = null;
            IFormFile Image17Url = null;
            IFormFile Image18Url = null;
            IFormFile Image19Url = null;
            IFormFile Image20Url = null;
            IFormFile Image21Url = null;
            IFormFile Image22Url = null;
            IFormFile Image23Url = null;
            IFormFile Image24Url = null;
            IFormFile Image25Url = null;
            IFormFile Image26Url = null;
            IFormFile Image27Url = null;
            IFormFile Image28Url = null;
            IFormFile Image29Url = null;
            IFormFile Image30Url = null;
            IFormFile Image31Url = null;
            IFormFile Image32Url = null;
            IFormFile Image33Url = null;
            IFormFile Image34Url = null;
            IFormFile Image35Url = null;
            IFormFile Image36Url = null;
            IFormFile Image37Url = null;
            IFormFile Image38Url = null;
            IFormFile Image39Url = null;
            IFormFile Image40Url = null;
            IFormFile Image41Url = null;
            IFormFile Image42Url = null;
            IFormFile Image43Url = null;
            IFormFile Image44Url = null;
            IFormFile Image45Url = null;
            IFormFile Image46Url = null;
            IFormFile Image47Url = null;
            IFormFile Image48Url = null;
            IFormFile Image49Url = null;
            IFormFile Image50Url = null;


            List<IFormFile> images = new List<IFormFile> {
                            TitleImageUrl,
                            Image2Url,
                            Image3Url,
                            Image4Url,
                            Image5Url,
                            Image6Url,
                            Image7Url,
                            Image8Url,
                            Image9Url,
                            Image10Url,
                            Image11Url,
                            Image12Url,
                            Image13Url,
                            Image14Url,
                            Image15Url,
                            Image16Url,
                            Image17Url,
                            Image18Url,
                            Image19Url,
                            Image20Url,
                            Image21Url,
                            Image22Url,
                            Image23Url,
                            Image24Url,
                            Image25Url,
                            Image26Url,
                            Image27Url,
                            Image28Url,
                            Image29Url,
                            Image30Url,
                            Image31Url,
                            Image32Url,
                            Image33Url,
                            Image34Url,
                            Image35Url,
                            Image36Url,
                            Image37Url,
                            Image38Url,
                            Image39Url,
                            Image40Url,
                            Image41Url,
                            Image42Url,
                            Image43Url,
                            Image44Url,
                            Image45Url,
                            Image46Url,
                            Image47Url,
                            Image48Url,
                            Image49Url,
                            Image50Url };


            Assert.Equal(36, countRefValue);
            Assert.Equal(4, countCharacterInstances);

            int numberOfIFormFileValues = images.Count;
            Assert.Equal(50, numberOfIFormFileValues);

            ImageUrls = await _uploadBlobs.uploadBlobToAzure(UserIDValue, images, uniqueReferenceValue, "Blob");
            int numberOfListEntries = ImageUrls.Count;

            Assert.IsType<List<string>>(ImageUrls);
            Assert.Equal(50, numberOfListEntries);

            bool deleteSuccess = await _DeleteBlobs.DeleteAzureBlobAsync(UserIDValue, uniqueReferenceValue);

            Assert.True(deleteSuccess);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void TestUploadBlobs_getConnectionString_ForCreateArticlePage()
        {

            var connectionString = _BlobActions.getConnectionString();

            Assert.Equal("DefaultEndpointsProtocol=https;AccountName=gatheringforgoodimages;AccountKey=B3HpUmXU3c30x0RtQ918ZF3lUqtt79XT0BLHr6nbnyH3T0K/d9sjo+sE00GWMgYh5i1COo7A8S0M+4TjCKfU5A==;EndpointSuffix=core.windows.net", connectionString);
            Assert.IsType<string>(connectionString);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Long")]
        [Trait("TestEnvironment", "Local")]
        public async Task TestUploadBlobs_createContainerClient_ForCreateArticlePage()
        {

            var connectionString = _BlobActions.getConnectionString();
            var UserIDValue = _CrossPageSharedUITestStrings.Test5UserId();
            var containerClient = await _BlobActions.createContainerClient(connectionString, UserIDValue, "Blob");

            Assert.IsType<BlobContainerClient>(containerClient);

            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
            BlobContainerClient container = blobServiceClient.GetBlobContainerClient(UserIDValue);
            bool isExist = container.Exists();

            Assert.True(isExist);

            try
            {
                await container.DeleteIfExistsAsync();
                Thread.Sleep(180000);
            }
            catch (RequestFailedException e)
            {
                Debug.WriteLine("HTTP error code {0}: {1}", e.Status, e.ErrorCode);
                Debug.WriteLine(e.Message);
                throw new Exception();
            }
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void TestUploadBlobs_getBlobUri_ForCreateArticlePage()
        {
            var UserIDValue = _CrossPageSharedUITestStrings.Test5UserId();

            Uri blobUri = _BlobActions.getBlobUri(UserIDValue, "Test");
            Assert.IsType<Uri>(blobUri);
            Assert.Equal(blobUri.ToString(), "https://gatheringforgoodimages.blob.core.windows.net/" + UserIDValue + "/" + "Test");
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void TestUploadBlobs_getAccessType_ForCreateArticlePage()
        {
            string BlobType = "Blob";
            string PublicType = "Public";
            string DefaultBlobType = "NoCaseValue";
            string doNotUseSwitch = null;

            var returnedValueBlob = _BlobActions.getAccessType(BlobType);
            Assert.IsType<Azure.Storage.Blobs.Models.PublicAccessType>(returnedValueBlob);

            var returnedValuePublic = _BlobActions.getAccessType(PublicType);
            Assert.IsType<Azure.Storage.Blobs.Models.PublicAccessType>(returnedValuePublic);

            var returnedValueDefault = _BlobActions.getAccessType(DefaultBlobType);
            Assert.IsType<Azure.Storage.Blobs.Models.PublicAccessType>(returnedValueDefault);

            var returnedValueBlobWithoutSwitchStatement = _BlobActions.getAccessType(doNotUseSwitch);
            Assert.IsType<Azure.Storage.Blobs.Models.PublicAccessType>(returnedValueBlobWithoutSwitchStatement);

            Assert.Equal(Azure.Storage.Blobs.Models.PublicAccessType.Blob, returnedValueBlob);
            Assert.Equal(Azure.Storage.Blobs.Models.PublicAccessType.None, returnedValuePublic);
            Assert.Equal(Azure.Storage.Blobs.Models.PublicAccessType.Blob, returnedValueDefault);
            Assert.Equal(Azure.Storage.Blobs.Models.PublicAccessType.Blob, returnedValueBlobWithoutSwitchStatement);
        }
    }
}
