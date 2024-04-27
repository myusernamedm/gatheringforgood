using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class CheckImageTypeAndSize
    {
        public bool checkImageType(List<string> imageExtensionsList)
        {
            foreach (string extension in imageExtensionsList)
            {
                if (extension.Contains(".jpg") || extension.Contains(".jpeg") || extension.Contains(".png"))
                {

                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public bool checkImageSize(List<IFormFile> imageListForSizeCheck)
        {
            foreach (IFormFile imageFile in imageListForSizeCheck)
            {
                if (imageFile.Length >= 2097152)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
