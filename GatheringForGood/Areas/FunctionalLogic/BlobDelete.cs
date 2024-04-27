using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class BlobDelete
    {
        private readonly BlobActions _BlobActions = new();

        public async Task<bool> DeleteAzureBlobAsync(string UserIDValue, string uniqueReferenceValue)
        {
            string connectionString = _BlobActions.getConnectionString();
            string AccessType = null;
            BlobContainerClient blobContainer = await _BlobActions.createContainerClient(connectionString, UserIDValue, AccessType);
            try
            {
                var resultSegment = blobContainer.GetBlobsAsync().AsPages();

                await foreach (Page<BlobItem> blobPage in resultSegment)
                {
                    foreach (BlobItem blobItem in blobPage.Values)
                    {
                        string blobName = blobItem.Name;
                        string processedName = blobName.Remove(blobName.LastIndexOf('/'));

                        if(processedName == uniqueReferenceValue)
                        {
                            await blobContainer.DeleteBlobAsync(blobName);
                        }
                    }
                }
                return true;
            }
            catch (RequestFailedException e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
        }
    }
}
