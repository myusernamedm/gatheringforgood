using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageUrlReferenceLibrary
{
    public class TestingImageUrls
    {
        public string getLocalHostPort()
        {
            string portNo = "44305";
            return portNo;
        }

        public string GetInvalidSizeImageThumbnailUrlForTesting()
        {
            string Url = "C:\\Users\\diarm\\Pictures\\GFG_Test_DO_NOT_DELETE\\invalid_size.jpg";
            return Url;
        }
        public string GetInvalidTypeImageThumbnailUrlForTesting()
        {
            string Url = "C:\\Users\\diarm\\Pictures\\GFG_Test_DO_NOT_DELETE\\invalid_type.cdr";
            return Url;
        }
        public string GetValidJpgImageThumbnailUrlForTesting()
        {
            string Url = "C:\\Users\\diarm\\Pictures\\GFG_Test_DO_NOT_DELETE\\valid_jpg.jpg";
            return Url;
        }
        public string GetValidPngImageThumbnailUrlForTesting()
        {
            string Url = "C:\\Users\\diarm\\Pictures\\GFG_Test_DO_NOT_DELETE\\valid_png.png";
            return Url;
        }
        public string GetCardTitleImageThumbnailUrlForTesting()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/images/cardtitleimage.png";
            return Url;
        }
        public string GetCardImageThumbnailUrlForTesting()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/images/cardimage.png";
            return Url;
        }

    }
}
