using System;
using Xunit;
using ImageUrlReferenceLibrary;

namespace GatheringForGood.UnitTests
{
    public class TestHomePageImageUrlReferences
    {
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void BlockTitleImageUrlForHomePageIsCorrect()
        {
            string BlockTitleImage = "/images/title_image.webp";
            var HomePageUrlLibrary = new HomePageImageUrls();
            string ReturnedUrl = HomePageUrlLibrary.GetBlockTitleImageUrlForHomePage();
            Assert.Equal(BlockTitleImage, ReturnedUrl);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void HowCanIHelpaImageUrlForHomePageIsCorrect()
        {
            string HowCanIHelpaImage = "/images/howcanihelp.png";
            var HomePageUrlLibrary = new HomePageImageUrls();
            string ReturnedUrl = HomePageUrlLibrary.GetHowCanIHelpImageUrlForHomePage();
            Assert.Equal(HowCanIHelpaImage, ReturnedUrl);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void HowCanIHelpbImageUrlForHomePageIsCorrect()
        {
            string HowCanIHelpbImage = "/images/howcanihelpb.webp";
            var HomePageUrlLibrary = new HomePageImageUrls();
            string ReturnedUrl = HomePageUrlLibrary.GetHowCanIHelpbImageUrlForHomePage();
            Assert.Equal(HowCanIHelpbImage, ReturnedUrl);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void ChromeLogoImageUrlForHomePageIsCorrect()
        {
            string ChromeLogoImageUrl = "/images/chromelogo.png";
            var HomePageUrlLibrary = new HomePageImageUrls();
            string ReturnedUrl = HomePageUrlLibrary.GetChromeLogoImageUrlForHomePage();
            Assert.Equal(ChromeLogoImageUrl, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void NewsfeedIconImageUrlForHomePageIsCorrect()
        {
            string NewsfeedIcon = "/images/newsfeedicon1.png";
            var HomePageUrlLibrary = new HomePageImageUrls();
            string ReturnedUrl = HomePageUrlLibrary.GetNewsfeedIconUrlReferenceForHomePage();
            Assert.Equal(NewsfeedIcon, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void ImpactIconImageUrlForHomePageIsCorrect()
        {
            string ImpactIcon = "/images/impact.png";
            var HomePageUrlLibrary = new HomePageImageUrls();
            string ReturnedUrl = HomePageUrlLibrary.GetImpactIconImageUrlReferenceForHomePage();
            Assert.Equal(ImpactIcon, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void AgileIconImageUrlForHomePageIsCorrect()
        {
            string AgileIcon = "/images/agileinitiativeicon.webp";
            var HomePageUrlLibrary = new HomePageImageUrls();
            string ReturnedUrl = HomePageUrlLibrary.GetAgileIconImageUrlReferenceForHomePage();
            Assert.Equal(AgileIcon, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void ArticleIconImageUrlForHomePageIsCorrect()
        {
            string ArticleIcon = "/images/articlesicon1.png";
            var HomePageUrlLibrary = new HomePageImageUrls();
            string ReturnedUrl = HomePageUrlLibrary.GetArticlesIconImageUrlReferenceForHomePage();
            Assert.Equal(ArticleIcon, ReturnedUrl);
        }
    }
}
