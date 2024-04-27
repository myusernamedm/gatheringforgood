using System;
using Xunit;
using ImageUrlReferenceLibrary;

namespace GatheringForGood.UnitTests
{
    public class TestReduceAnimalExtinctionImageUrlReferences
    {
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void Rhinoicon1UrlForReduceAnimalExtinctionPageIsCorrect()
        {
            string Rhinoicon1 = "/images/rhinoicon1.png";
            var ReduceAnimalExtinctionPageUrlLibrary = new ReduceAnimalExtinctionPageImageUrls();
            string ReturnedUrl = ReduceAnimalExtinctionPageUrlLibrary.GetRhinoicon1ThumbnailUrlForReduceAnimalExtinctionPage();
            Assert.Equal(Rhinoicon1, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void Rhinoicon2UrlForReduceAnimalExtinctionPageIsCorrect()
        {
            string Rhinoicon2 = "/images/rhinoicon2.png";
            var ReduceAnimalExtinctionPageUrlLibrary = new ReduceAnimalExtinctionPageImageUrls();
            string ReturnedUrl = ReduceAnimalExtinctionPageUrlLibrary.GetRhinoicon2ThumbnailUrlForReduceAnimalExtinctionPage();
            Assert.Equal(Rhinoicon2, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void Rhinoicon3UrlForReduceAnimalExtinctionPageIsCorrect()
        {
            string Rhinoicon3 = "/images/rhinoicon3.png";
            var ReduceAnimalExtinctionPageUrlLibrary = new ReduceAnimalExtinctionPageImageUrls();
            string ReturnedUrl = ReduceAnimalExtinctionPageUrlLibrary.GetRhinoicon3ThumbnailUrlForReduceAnimalExtinctionPage();
            Assert.Equal(Rhinoicon3, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void Rhinoicon4UrlForReduceAnimalExtinctionPageIsCorrect()
        {
            string Rhinoicon4 = "/images/rhinoicon4.png";
            var ReduceAnimalExtinctionPageUrlLibrary = new ReduceAnimalExtinctionPageImageUrls();
            string ReturnedUrl = ReduceAnimalExtinctionPageUrlLibrary.GetRhinoicon4ThumbnailUrlForReduceAnimalExtinctionPage();
            Assert.Equal(Rhinoicon4, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void Rhinoicon5UrlForReduceAnimalExtinctionPageIsCorrect()
        {
            string Rhinoicon5 = "/images/rhinoicon5.png";
            var ReduceAnimalExtinctionPageUrlLibrary = new ReduceAnimalExtinctionPageImageUrls();
            string ReturnedUrl = ReduceAnimalExtinctionPageUrlLibrary.GetRhinoicon5ThumbnailUrlForReduceAnimalExtinctionPage();
            Assert.Equal(Rhinoicon5, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void MouseClickIconThumbnailUrlForReduceAnimalExtinctionPageIsCorrect()
        {
            string MouseClickIconThumbnailUrl = "/images/mousetap.png";
            var ReduceAnimalExtinctionPageUrlLibrary = new ReduceAnimalExtinctionPageImageUrls();
            string ReturnedUrl = ReduceAnimalExtinctionPageUrlLibrary.GetMouseClickIconThumbnailUrlForReduceAnimalExtinctionPage();
            Assert.Equal(MouseClickIconThumbnailUrl, ReturnedUrl);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void HandTapIconThumbnailUrlForReduceAnimalExtinctionPageIsCorrect()
        {
            string HandTapIconThumbnailUrl = "/images/handtap.png";
            var ReduceAnimalExtinctionPageUrlLibrary = new ReduceAnimalExtinctionPageImageUrls();
            string ReturnedUrl = ReduceAnimalExtinctionPageUrlLibrary.GetHandTapIconThumbnailUrlForReduceAnimalExtinctionPage();
            Assert.Equal(HandTapIconThumbnailUrl, ReturnedUrl);
        }
    }
}
