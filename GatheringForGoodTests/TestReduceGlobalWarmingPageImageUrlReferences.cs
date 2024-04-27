using System;
using Xunit;
using ImageUrlReferenceLibrary;

namespace GatheringForGood.UnitTests
{
    public class TestReduceGlobalWarmingPageImageUrlReferences
    {
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void Co2icon1UrlForReduceGlobalWarmingPageIsCorrect()
        {
            string Co2icon1 = "/images/co2icon1.png";
            var ReduceGlobalWarmingPageUrlLibrary = new ReduceGlobalWarmingPageImageUrls();
            string ReturnedUrl = ReduceGlobalWarmingPageUrlLibrary.GetCo2icon1ThumbnailUrlForReduceGlobalWarmingPage();
            Assert.Equal(Co2icon1, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void Co2icon2UrlForReduceGlobalWarmingPageIsCorrect()
        {
            string Co2icon2 = "/images/co2icon2.png";
            var ReduceGlobalWarmingPageUrlLibrary = new ReduceGlobalWarmingPageImageUrls();
            string ReturnedUrl = ReduceGlobalWarmingPageUrlLibrary.GetCo2icon2ThumbnailUrlForReduceGlobalWarmingPage();
            Assert.Equal(Co2icon2, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void Co2icon3UrlForReduceGlobalWarmingPageIsCorrect()
        {
            string Co2icon3 = "/images/co2icon3.png";
            var ReduceGlobalWarmingPageUrlLibrary = new ReduceGlobalWarmingPageImageUrls();
            string ReturnedUrl = ReduceGlobalWarmingPageUrlLibrary.GetCo2icon3ThumbnailUrlForReduceGlobalWarmingPage();
            Assert.Equal(Co2icon3, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void Co2icon4UrlForReduceGlobalWarmingPageIsCorrect()
        {
            string Co2icon4 = "/images/co2icon4.png";
            var ReduceGlobalWarmingPageUrlLibrary = new ReduceGlobalWarmingPageImageUrls();
            string ReturnedUrl = ReduceGlobalWarmingPageUrlLibrary.GetCo2icon4ThumbnailUrlForReduceGlobalWarmingPage();
            Assert.Equal(Co2icon4, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void Co2icon5UrlForReduceGlobalWarmingPageIsCorrect()
        {
            string Co2icon5 = "/images/co2icon5.png";
            var ReduceGlobalWarmingPageUrlLibrary = new ReduceGlobalWarmingPageImageUrls();
            string ReturnedUrl = ReduceGlobalWarmingPageUrlLibrary.GetCo2icon5ThumbnailUrlForReduceGlobalWarmingPage();
            Assert.Equal(Co2icon5, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void MouseClickIconThumbnailUrlForReduceGlobalWarmingPageIsCorrect()
        {
            string MouseClickIconThumbnailUrl = "/images/mousetap.png";
            var ReduceGlobalWarmingPageUrlLibrary = new ReduceGlobalWarmingPageImageUrls();
            string ReturnedUrl = ReduceGlobalWarmingPageUrlLibrary.GetMouseClickIconThumbnailUrlForReduceGlobalWarmingPage();
            Assert.Equal(MouseClickIconThumbnailUrl, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void HandTapIconThumbnailUrlForReduceGlobalWarmingPageIsCorrect()
        {
            string HandTapIconThumbnailUrl = "/images/handtap.png";
            var ReduceGlobalWarmingPageUrlLibrary = new ReduceGlobalWarmingPageImageUrls();
            string ReturnedUrl = ReduceGlobalWarmingPageUrlLibrary.GetHandTapIconThumbnailUrlForReduceGlobalWarmingPage();
            Assert.Equal(HandTapIconThumbnailUrl, ReturnedUrl);
        }
    }
}
