using System;
using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.AspNetCore.Mvc.Localization;
using GatheringForGood.LocalizationResources;

namespace GatheringForGood.UnitTests
{
    public class TestNewsfeedPageLocSourceNames
    {

        private readonly ISharedCultureLocalizer _loc;

        public TestNewsfeedPageLocSourceNames()
        {
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePageTabTitleNameReferenceForNewsfeedPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Features", null);
            var NewsfeedPageLocSourceNamesLibrary = new NewsfeedPageLocSourceNames();
            string ReturnedNameKeyValue = NewsfeedPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForNewsfeedPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForNewsfeedPageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "Dive into ways we can help you change the world", null);
            var NewsfeedPageLocSourceNamesLibrary = new NewsfeedPageLocSourceNames();
            string ReturnedNameKeyValue = NewsfeedPageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForNewsfeedPage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubtitleNameReferenceForFeaturePageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Features", null);
            var NewsfeedPageLocSourceNamesLibrary = new NewsfeedPageLocSourceNames();
            string ReturnedNameKeyValue = NewsfeedPageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForNewsfeedPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }
    }
}
