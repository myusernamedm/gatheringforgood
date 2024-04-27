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
    public class TestArticlePageLocSourceNames
    {

        private readonly ISharedCultureLocalizer _loc;

        public TestArticlePageLocSourceNames()
        {
            var ci = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.LCID);
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = ci;
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = ci;
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
            string PageTabTitle = _loc.GetLocalizedString("en", "Articles for Good", null);
            var ArticlePageLocSourceNamesLibrary = new ArticlesPageLocSourceNames();
            string ReturnedNameKeyValue = ArticlePageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForArticlesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForArticlePageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "What's happening to help save the world", null);
            var ArticlePageLocSourceNamesLibrary = new ArticlesPageLocSourceNames();
            string ReturnedNameKeyValue = ArticlePageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForArticlesPage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubtitleNameReferenceForArticlePageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Articles for Good", null);
            var ArticlePageLocSourceNamesLibrary = new ArticlesPageLocSourceNames();
            string ReturnedNameKeyValue = ArticlePageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForArticlesPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAuthorNameReferenceForArticlePageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Author", null);
            var ArticlePageLocSourceNamesLibrary = new ArticlesPageLocSourceNames();
            string ReturnedNameKeyValue = ArticlePageLocSourceNamesLibrary.GetLocSourceNewsfeedCardAuthorNameReferenceForArticlesPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCreateAnArticleNameReferenceForArticlePageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Create An Article", null);
            var ArticlePageLocSourceNamesLibrary = new ArticlesPageLocSourceNames();
            string ReturnedNameKeyValue = ArticlePageLocSourceNamesLibrary.GetLocSourceCreateArticleButtonNameReferenceForArticlesPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceViewsNameReferenceForArticlePageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Views", null);
            var ArticlePageLocSourceNamesLibrary = new ArticlesPageLocSourceNames();
            string ReturnedNameKeyValue = ArticlePageLocSourceNamesLibrary.GetLocSourceViewsNameReferenceForArticlesPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSearchByTitleNameReferenceForArticlePageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Article Title", null);
            var ArticlePageLocSourceNamesLibrary = new ArticlesPageLocSourceNames();
            string ReturnedNameKeyValue = ArticlePageLocSourceNamesLibrary.GetLocSourceSearchByTitleNameReferenceForArticlesPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSearchButtonTextNameReferenceForArticlePageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Search", null);
            var ArticlePageLocSourceNamesLibrary = new ArticlesPageLocSourceNames();
            string ReturnedNameKeyValue = ArticlePageLocSourceNamesLibrary.GetLocSourceSearchButtonTextNameReferenceForArticlesPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSearchByAuthorFNNameReferenceForArticlePageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Author First Name", null);
            var ArticlePageLocSourceNamesLibrary = new ArticlesPageLocSourceNames();
            string ReturnedNameKeyValue = ArticlePageLocSourceNamesLibrary.GetLocSourceSearchByAuthorFNNameReferenceForArticlesPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSearchByAuthorLNNameReferenceForArticlePageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Author Last Name", null);
            var ArticlePageLocSourceNamesLibrary = new ArticlesPageLocSourceNames();
            string ReturnedNameKeyValue = ArticlePageLocSourceNamesLibrary.GetLocSourceSearchByAuthorLNNameReferenceForArticlesPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSearchArticlesHeadingNameReferenceForArticlePageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Search Articles", null);
            var ArticlePageLocSourceNamesLibrary = new ArticlesPageLocSourceNames();
            string ReturnedNameKeyValue = ArticlePageLocSourceNamesLibrary.GetLocSourceSearchArticlesHeadingNameReferenceForArticlesPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }
    }
}