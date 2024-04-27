using System;
using Xunit;
using ImageUrlReferenceLibrary;

namespace GatheringForGood.UnitTests
{
    public class TestAboutPageImageUrlReferences
    {
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void AboutNameImageThumbnailUrlIsCorrect()
        {
            string NameImageThumbnailUrl = "/images/light_bulb_paper.png";
            var AboutUrlLibrary = new AboutPageImageUrls();
            string ReturnedUrl = AboutUrlLibrary.GetNameImageThumbnailUrlForAboutPage();
            Assert.Equal(NameImageThumbnailUrl, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void AboutMissionImageThumbnailUrlIsCorrect()
        {
            string MissionImageThumbnailUrl = "/images/smiling_crowd.png";
            var AboutUrlLibrary = new AboutPageImageUrls();
            string ReturnedUrl = AboutUrlLibrary.GetMissionImageThumbnailUrlForAboutPage();
            Assert.Equal(MissionImageThumbnailUrl, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void AboutPromiseImageThumbnailUrlIsCorrect()
        {
            string PromiseImageThumbnailUrl = "/images/sapling_growing.png";
            var AboutUrlLibrary = new AboutPageImageUrls();
            string ReturnedUrl = AboutUrlLibrary.GetPromiseImageThumbnailUrlForAboutPage();
            Assert.Equal(PromiseImageThumbnailUrl, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void AboutEssenceImageThumbnailUrlIsCorrect()
        {
            string EssenceImageThumbnailUrl = "/images/people_standing_smiling.png";
            var AboutUrlLibrary = new AboutPageImageUrls();
            string ReturnedUrl = AboutUrlLibrary.GetEssenceImageThumbnailUrlForAboutPage();
            Assert.Equal(EssenceImageThumbnailUrl, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void AboutVisionImageThumbnailUrlIsCorrect()
        {
            string VisionImageThumbnailUrl = "/images/visionimage.png";
            var AboutUrlLibrary = new AboutPageImageUrls();
            string ReturnedUrl = AboutUrlLibrary.GetVisionImageThumbnailUrlForAboutPage();
            Assert.Equal(VisionImageThumbnailUrl, ReturnedUrl);
        }
    }
}
