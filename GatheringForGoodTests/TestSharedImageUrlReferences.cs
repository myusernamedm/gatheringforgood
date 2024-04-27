using System;
using Xunit;
using ImageUrlReferenceLibrary;

namespace GatheringForGood.UnitTests
{
    public class TestSharedImageUrlReferences
    { 
    [Fact]
    [Trait("Category", "Unit")]
    [Trait("Owner", "DM")]
    [Trait("RunTime", "Short")]
    [Trait("TestEnvironment", "Local")]
    public void RGWImpactIconUrlForHomePageIsCorrect()
    {
        string TestUrl = "/images/impact.png";
        var SharedUrlLibrary = new SharedCrossPageImageUrls();
        string ReturnedUrl = SharedUrlLibrary.GetRGWImpactIconUrlForPages();
        Assert.Equal(TestUrl, ReturnedUrl);
    }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void AllUserActionsIconUrlForHomePageIsCorrect()
        {
            string TestUrl = "/images/alluserimpacts.png";
            var SharedUrlLibrary = new SharedCrossPageImageUrls();
            string ReturnedUrl = SharedUrlLibrary.GetAllUserActionsIconUrlForPage();
            Assert.Equal(TestUrl, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void MyTotalActionsIconUrlForHomePageIsCorrect()
        {
            string TestUrl = "/images/mytotalimpact.png";
            var SharedUrlLibrary = new SharedCrossPageImageUrls();
            string ReturnedUrl = SharedUrlLibrary.GetMyTotalActionsIconUrlForPage();
            Assert.Equal(TestUrl, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void MyCo2ReductionIconUrlForHomePageIsCorrect()
        {
            string TestUrl = "/images/myco2reduction.png";
            var SharedUrlLibrary = new SharedCrossPageImageUrls();
            string ReturnedUrl = SharedUrlLibrary.GetMyCo2ReductionIconUrlForPage();
            Assert.Equal(TestUrl, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void TwitterIconUrlForHomePageIsCorrect()
        {
            string TestUrl = "/images/icontwitter.png";
            var SharedUrlLibrary = new SharedCrossPageImageUrls();
            string ReturnedUrl = SharedUrlLibrary.GetTwitterIconUrlForPage();
            Assert.Equal(TestUrl, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LinkedinIconUrlForHomePageIsCorrect()
        {
            string TestUrl = "/images/iconlinkedin.png";
            var SharedUrlLibrary = new SharedCrossPageImageUrls();
            string ReturnedUrl = SharedUrlLibrary.GetLinkedinIconUrlForPage();
            Assert.Equal(TestUrl, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void FacebookIconUrlForHomePageIsCorrect()
        {
            string TestUrl = "/images/iconfb.png";
            var SharedUrlLibrary = new SharedCrossPageImageUrls();
            string ReturnedUrl = SharedUrlLibrary.GetFacebookIconUrlForPage();
            Assert.Equal(TestUrl, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void RedditIconUrlForHomePageIsCorrect()
        {
            string TestUrl = "/images/iconreddit.png";
            var SharedUrlLibrary = new SharedCrossPageImageUrls();
            string ReturnedUrl = SharedUrlLibrary.GetRedditIconUrlForPage();
            Assert.Equal(TestUrl, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void OffsetIconImageUrlForHomePageIsCorrect()
        {
            string TestUrl = "/images/offsetCarbon.webp";
            var SharedUrlLibrary = new SharedCrossPageImageUrls();
            string ReturnedUrl = SharedUrlLibrary.GetOffsetIconImageUrlReferenceForHomePage();
            Assert.Equal(TestUrl, ReturnedUrl);
        }
    }
}
