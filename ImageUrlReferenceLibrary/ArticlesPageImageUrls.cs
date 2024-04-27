using System;

namespace ImageUrlReferenceLibrary
{
    public class ArticlesPageImageUrls
    {
        public string GetEmissionsArticleImageThumbnailUrlForArticlesPage()
        {
            string Title = "/images/emissionsarticlesmall.jpg";
            return Title;
        }
        public string GetFeaturedArticleImageThumbnailUrlForArticlesPage()
        {
            string Title = "/images/featured.png";
            return Title;
        }
        public string GetFeaturedNoPaddingArticleImageThumbnailUrlForArticlesPage()
        {
            string Title = "/images/featurednopad.png";
            return Title;
        }
    }
}
