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
    public class TestHelpPageLocSourceNames
    {

        private readonly ISharedCultureLocalizer _loc;

        public TestHelpPageLocSourceNames()
        {
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePageTabTitleNameReferenceForHelpPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Help Center", null);
            var HelpPageLocSourceNamesLibrary = new HelpPageLocSourceNames();
            string ReturnedNameKeyValue = HelpPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForHelpPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForHelpPageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "Advice and answers from the GatheringForGood team", null);
            var HelpPageLocSourceNamesLibrary = new HelpPageLocSourceNames();
            string ReturnedNameKeyValue = HelpPageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForHelpPage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubtitleNameReferenceForHelpPageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Help Center", null);
            var HelpPageLocSourceNamesLibrary = new HelpPageLocSourceNames();
            string ReturnedNameKeyValue = HelpPageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForHelpPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }




        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceNewsfeedIconNameReferenceForHelpPageIsCorrect()
        {
            string NewsfeedIcon = _loc.GetLocalizedString("en", "Collaborate on Newsfeed", null);
            var HelpPageLocSourceNamesLibrary = new HelpPageLocSourceNames();
            string ReturnedNameKeyValue = HelpPageLocSourceNamesLibrary.GetLocSourceNewsfeedIconNameReferenceForHelpPage();
            Assert.Equal(NewsfeedIcon, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOffsetIconNameReferenceForHelpPageIsCorrect()
        {
            string OffsetIcon = _loc.GetLocalizedString("en", "Offset My Carbon", null);
            var HelpPageLocSourceNamesLibrary = new HelpPageLocSourceNames();
            string ReturnedNameKeyValue = HelpPageLocSourceNamesLibrary.GetLocSourceOffsetIconNameReferenceForHelpPage();
            Assert.Equal(OffsetIcon, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceContactUsIconNameReferenceForHelpPageIsCorrect()
        {
            string ContactUsIcon = _loc.GetLocalizedString("en", "Contact Us", null);
            var HelpPageLocSourceNamesLibrary = new HelpPageLocSourceNames();
            string ReturnedNameKeyValue = HelpPageLocSourceNamesLibrary.GetLocSourceContactUsIconNameReferenceForHelpPage();
            Assert.Equal(ContactUsIcon, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTrackImpactIconNameReferenceForHelpPageIsCorrect()
        {
            string TrackImpactIcon = _loc.GetLocalizedString("en", "Track My Impacts", null);
            var HelpPageLocSourceNamesLibrary = new HelpPageLocSourceNames();
            string ReturnedNameKeyValue = HelpPageLocSourceNamesLibrary.GetLocSourceTrackImpactIconNameReferenceForHelpPage();
            Assert.Equal(TrackImpactIcon, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAgileInitiativeIconNameReferenceForHelpPageIsCorrect()
        {
            string AgileInitiativeIcon = _loc.GetLocalizedString("en", "Create an Agile Initiative", null);
            var HelpPageLocSourceNamesLibrary = new HelpPageLocSourceNames();
            string ReturnedNameKeyValue = HelpPageLocSourceNamesLibrary.GetLocSourceAgileInitiativeIconNameReferenceForHelpPage();
            Assert.Equal(AgileInitiativeIcon, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHelloNameReferenceForHelpPageIsCorrect()
        {
            string Hello = _loc.GetLocalizedString("en", "Hello", null);
            var HelpPageLocSourceNamesLibrary = new HelpPageLocSourceNames();
            string ReturnedNameKeyValue = HelpPageLocSourceNamesLibrary.GetLocSourceHelloNameReferenceForHelpPage();
            Assert.Equal(Hello, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceLetUsKnowNameReferenceForHelpPageIsCorrect()
        {
            string LetUsKnow = _loc.GetLocalizedString("en", "Let us Know What You Think?", null);
            var HelpPageLocSourceNamesLibrary = new HelpPageLocSourceNames();
            string ReturnedNameKeyValue = HelpPageLocSourceNamesLibrary.GetLocSourceLetUsKnowNameReferenceForHelpPage();
            Assert.Equal(LetUsKnow, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceIdeasOrSayHiNameReferenceForHelpPageIsCorrect()
        {
            string IdeasOrSayHi = _loc.GetLocalizedString("en", "Do you have an idea for our site, want to see a new feature, feel like something important is missing, or you just need support. Please let us know!", null);
            var HelpPageLocSourceNamesLibrary = new HelpPageLocSourceNames();
            string ReturnedNameKeyValue = HelpPageLocSourceNamesLibrary.GetLocSourceIdeasOrSayHiNameReferenceForHelpPage();
            Assert.Equal(IdeasOrSayHi, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceNameHeadingNameReferenceForHelpPageIsCorrect()
        {
            string NameHeading = _loc.GetLocalizedString("en", "Full Name", null);
            var HelpPageLocSourceNamesLibrary = new HelpPageLocSourceNames();
            string ReturnedNameKeyValue = HelpPageLocSourceNamesLibrary.GetLocSourceNameHeadingNameReferenceForHelpPage();
            Assert.Equal(NameHeading, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceEmailHeadingNameReferenceForHelpPageIsCorrect()
        {
            string EmailHeading = _loc.GetLocalizedString("en", "Email", null);
            var HelpPageLocSourceNamesLibrary = new HelpPageLocSourceNames();
            string ReturnedNameKeyValue = HelpPageLocSourceNamesLibrary.GetLocSourceEmailHeadingNameReferenceForHelpPage();
            Assert.Equal(EmailHeading, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubjectHeadingNameReferenceForHelpPageIsCorrect()
        {
            string SubjectHeading = _loc.GetLocalizedString("en", "Subject", null);
            var HelpPageLocSourceNamesLibrary = new HelpPageLocSourceNames();
            string ReturnedNameKeyValue = HelpPageLocSourceNamesLibrary.GetLocSourceSubjectHeadingNameReferenceForHelpPage();
            Assert.Equal(SubjectHeading, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceThoughtsHeadingNameReferenceForHelpPageIsCorrect()
        {
            string ThoughtsHeading = _loc.GetLocalizedString("en", "Share Your Thoughts", null);
            var HelpPageLocSourceNamesLibrary = new HelpPageLocSourceNames();
            string ReturnedNameKeyValue = HelpPageLocSourceNamesLibrary.GetLocSourceThoughtsHeadingNameReferenceForHelpPage();
            Assert.Equal(ThoughtsHeading, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceViewArticleIconNameReferenceForHelpPageIsCorrect()
        {
            string ViewArticleIcon = _loc.GetLocalizedString("en", "View Articles", null);
            var HelpPageLocSourceNamesLibrary = new HelpPageLocSourceNames();
            string ReturnedNameKeyValue = HelpPageLocSourceNamesLibrary.GetLocSourceViewArticlesIconNameReferenceForHelpPage();
            Assert.Equal(ViewArticleIcon, ReturnedNameKeyValue);
        }






    }
}
