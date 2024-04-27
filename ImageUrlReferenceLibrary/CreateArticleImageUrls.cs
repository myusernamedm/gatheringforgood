using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageUrlReferenceLibrary
{
    public class CreateArticleImageUrls
    {
        public string GetCardTitleImageUrlReferenceForCreateArticlePage()
        {
            string Url = "/images/cardtitleimage.png";
            return Url;
        }
        public string GetCardImageUrlReferenceForCreateArticlePage()
        {
            string Url = "/images/cardimage.png";
            return Url;
        }
        public string GetCheckedImageUrlReferenceForCreateArticlePage()
        {
            string Url = "/images/checked.png";
            return Url;
        }
        public string GetUncheckedImageUrlReferenceForCreateArticlePage()
        {
            string Url = "/images/unchecked.png";
            return Url;
        }
    }
}
