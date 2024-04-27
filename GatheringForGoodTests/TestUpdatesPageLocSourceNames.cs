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
    public class TestUpdatesPageLocSourceNames
    {

        private readonly ISharedCultureLocalizer _loc;

        public TestUpdatesPageLocSourceNames()
        {
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePageTabTitleNameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Update History", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Improvements & Updates", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubtitleNameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Your Feedback Creates a Bigger Impact", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHeadingNameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "We Value Your Feeback", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceHeadingNameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceUpdatesHeadingParaNameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "To create the greatest possible benefit for the world, we need to provide great services. We recognise that the one thing which can make us better is your feedback. Thats why we not only want to receive your feedback (We really do!), but we believe in transparency. This page is here to show you that your feedback matters and has a real impact on our services.", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceUpdatesHeadingParaNameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDateNameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Date", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceDateNameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDetailsNameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Details", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceDetailsNameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceUserFeedbackNameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Feedback Item", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceUserFeedbackNameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceYesNameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Yes", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceYesNameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceNoNameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "No", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceNoNameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow1NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Create improvements and updates page to share progress with users", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow1NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow2NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Improved measurement of user engagement to provide insights for a better user experience", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow2NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow3NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Quality Audit", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow3NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow4NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Enhanced button visibility for a better user experience", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow4NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow5NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Security Improvements", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow5NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow6NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Social sharing improvements across site", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow6NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow7NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Improved status message for email confirmation error on login", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow7NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow8NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Security Improvements", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow8NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow9NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Improved responsive design of table on updates page", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow9NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow10NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Re-styled links for standardisation across full site", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow10NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow11NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Re-styled buttons for standardisation across full site", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow11NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow12NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Added Articles page link to main menu for easier user access", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow12NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow13NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Changed styling of homepage para's for impact and clarity", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow13NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow14NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Improved articles page scalability for 'weekly articles' functionality implementation", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow14NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow15NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Improved link navigation for articles page", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow15NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow16NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Improved dynamic population of articles page as a step towards the ability for users to post their own articles", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow16NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow17NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Added 'Author' display to articles cards", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow17NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow18NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Selection of minor defect fixes", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow18NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow19NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Further improvements to dynamic population of articles page", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow19NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow20NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Selection of minor defect fixes", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow20NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow21NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Further improvements to dynamic population of articles page and added author name with posted date and time to top of article", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow21NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow22NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Enhanced responsive text sizing for user articles to improve cross-device readability", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow22NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRow23NameReferenceForArticlePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Ability for users to create their own articles", null);
            var UpdatesPageLocSourceNamesLibrary = new UpdatesPageLocSourceNames();
            string ReturnedNameKeyValue = UpdatesPageLocSourceNamesLibrary.GetLocSourceRow23NameReferenceForUpdatesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
    }
}
