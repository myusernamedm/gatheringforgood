using System;
using Xunit;
using ImageUrlReferenceLibrary;

namespace GatheringForGood.UnitTests
{
    public class TestReduceDeforestationPageImageUrlReferences
    {
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void Treeicon1UrlForReduceDeforestationPageIsCorrect()
        {
            string Treeicon1 = "/images/treeicon1.png";
            var ReduceDeforestationPageUrlLibrary = new ReduceDeforestationPageImageUrls();
            string ReturnedUrl = ReduceDeforestationPageUrlLibrary.GetTreeicon1ThumbnailUrlForReduceDeforestationPage();
            Assert.Equal(Treeicon1, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void Treeicon2UrlForReduceDeforestationPageIsCorrect()
        {
            string Treeicon2 = "/images/treeicon2.png";
            var ReduceDeforestationPageUrlLibrary = new ReduceDeforestationPageImageUrls();
            string ReturnedUrl = ReduceDeforestationPageUrlLibrary.GetTreeicon2ThumbnailUrlForReduceDeforestationPage();
            Assert.Equal(Treeicon2, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void Treeicon3UrlForReduceDeforestationPageIsCorrect()
        {
            string Treeicon3 = "/images/treeicon3.png";
            var ReduceDeforestationPageUrlLibrary = new ReduceDeforestationPageImageUrls();
            string ReturnedUrl = ReduceDeforestationPageUrlLibrary.GetTreeicon3ThumbnailUrlForReduceDeforestationPage();
            Assert.Equal(Treeicon3, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void Treeicon4UrlForReduceDeforestationPageIsCorrect()
        {
            string Treeicon4 = "/images/treeicon4.png";
            var ReduceDeforestationPageUrlLibrary = new ReduceDeforestationPageImageUrls();
            string ReturnedUrl = ReduceDeforestationPageUrlLibrary.GetTreeicon4ThumbnailUrlForReduceDeforestationPage();
            Assert.Equal(Treeicon4, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void Treeicon5UrlForReduceDeforestationPageIsCorrect()
        {
            string Treeicon5 = "/images/treeicon5.png";
            var ReduceDeforestationPageUrlLibrary = new ReduceDeforestationPageImageUrls();
            string ReturnedUrl = ReduceDeforestationPageUrlLibrary.GetTreeicon5ThumbnailUrlForReduceDeforestationPage();
            Assert.Equal(Treeicon5, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void MouseClickIconThumbnailUrlForReduceDeforestationPageIsCorrect()
        {
            string MouseClickIconThumbnailUrl = "/images/mousetap.png";
            var ReduceDeforestationPageUrlLibrary = new ReduceDeforestationPageImageUrls();
            string ReturnedUrl = ReduceDeforestationPageUrlLibrary.GetMouseClickIconThumbnailUrlForReduceDeforestationPage();
            Assert.Equal(MouseClickIconThumbnailUrl, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void HandTapIconThumbnailUrlForReduceDeforestationPageIsCorrect()
        {
            string HandTapIconThumbnailUrl = "/images/handtap.png";
            var ReduceDeforestationPageUrlLibrary = new ReduceDeforestationPageImageUrls();
            string ReturnedUrl = ReduceDeforestationPageUrlLibrary.GetHandTapIconThumbnailUrlForReduceDeforestationPage();
            Assert.Equal(HandTapIconThumbnailUrl, ReturnedUrl);
        }
    }
}