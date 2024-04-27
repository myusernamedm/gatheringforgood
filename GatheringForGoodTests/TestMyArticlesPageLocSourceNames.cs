using Xunit;
using LazZiya.ExpressLocalization;
using LocSourceNameReferenceLibrary;

namespace GatheringForGood.UnitTests
{
    public class TestMyArticlesPageLocSourceNames
    {
        private readonly ISharedCultureLocalizer _loc;

        public TestMyArticlesPageLocSourceNames()
        {
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePageTabTitleNameReferenceForMyArticlesPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "My Articles", null);
            var MyArticlesPageLocSourceNamesLibrary = new MyArticlesLocSourceNames();
            string ReturnedNameKeyValue = MyArticlesPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForMyArticlesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForMyArticlesPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Manage Your Existing Articles", null);
            var MyArticlesPageLocSourceNamesLibrary = new MyArticlesLocSourceNames();
            string ReturnedNameKeyValue = MyArticlesPageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForMyArticlesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubtitleNameReferenceForMyArticlesPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "My Articles", null);
            var MyArticlesPageLocSourceNamesLibrary = new MyArticlesLocSourceNames();
            string ReturnedNameKeyValue = MyArticlesPageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForMyArticlesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHeadingNameReferenceForMyArticlesPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Manage your articles", null);
            var MyArticlesPageLocSourceNamesLibrary = new MyArticlesLocSourceNames();
            string ReturnedNameKeyValue = MyArticlesPageLocSourceNamesLibrary.GetLocSourceHeadingNameReferenceForMyArticlesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTableColImageNameReferenceForMyArticlesPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Title Image", null);
            var MyArticlesPageLocSourceNamesLibrary = new MyArticlesLocSourceNames();
            string ReturnedNameKeyValue = MyArticlesPageLocSourceNamesLibrary.GetLocSourceTableColImageNameReferenceForMyArticlesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTableColTitleNameReferenceForMyArticlesPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Article Title", null);
            var MyArticlesPageLocSourceNamesLibrary = new MyArticlesLocSourceNames();
            string ReturnedNameKeyValue = MyArticlesPageLocSourceNamesLibrary.GetLocSourceTableColTitleNameReferenceForMyArticlesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTableColPostedNameReferenceForMyArticlesPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Posted Date", null);
            var MyArticlesPageLocSourceNamesLibrary = new MyArticlesLocSourceNames();
            string ReturnedNameKeyValue = MyArticlesPageLocSourceNamesLibrary.GetLocSourceTableColPostedNameReferenceForMyArticlesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTableColDeleteNameReferenceForMyArticlesPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Delete Article", null);
            var MyArticlesPageLocSourceNamesLibrary = new MyArticlesLocSourceNames();
            string ReturnedNameKeyValue = MyArticlesPageLocSourceNamesLibrary.GetLocSourceTableColDeleteNameReferenceForMyArticlesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTableColShowNameReferenceForMyArticlesPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Show Article", null);
            var MyArticlesPageLocSourceNamesLibrary = new MyArticlesLocSourceNames();
            string ReturnedNameKeyValue = MyArticlesPageLocSourceNamesLibrary.GetLocSourceTableColShowNameReferenceForMyArticlesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
    }
}
