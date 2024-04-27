using System;
using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestLockoutPageLocSourceNames
    {

        private readonly ISharedCultureLocalizer _loc;

        public TestLockoutPageLocSourceNames()
        {
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePageTabTitleNameReferenceForLockoutPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Account Security", null);
            var LockoutPageLocSourceNamesLibrary = new LockoutPageLocSourceNames();
            string ReturnedNameKeyValue = LockoutPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForLockoutPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForLockoutPageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "Account Locked", null);
            var LockoutPageLocSourceNamesLibrary = new LockoutPageLocSourceNames();
            string ReturnedNameKeyValue = LockoutPageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForLockoutPage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubTitleNameReferenceForLockoutPageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Account locked for your security", null);
            var LockoutPageLocSourceNamesLibrary = new LockoutPageLocSourceNames();
            string ReturnedNameKeyValue = LockoutPageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForLockoutPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHeadingNameReferenceForLockoutPageIsCorrect()
        {
            string Heading = _loc.GetLocalizedString("en", "Locked Out", null);
            var LockoutPageLocSourceNamesLibrary = new LockoutPageLocSourceNames();
            string ReturnedNameKeyValue = LockoutPageLocSourceNamesLibrary.GetLocSourceHeadingNameReferenceForLockoutPage();
            Assert.Equal(Heading, ReturnedNameKeyValue);
        }
    }
}
