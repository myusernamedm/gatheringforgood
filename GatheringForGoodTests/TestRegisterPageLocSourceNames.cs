using System;
using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestRegisterPageLocSourceNames
    {

        private readonly ISharedCultureLocalizer _loc;

        public TestRegisterPageLocSourceNames()
        {
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePageTabTitleNameReferenceForRegisterPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Register", null);
            var RegisterPageLocSourceNamesLibrary = new RegisterPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForRegisterPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForRegisterPageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "Grow Solutions That Change The World", null);
            var RegisterPageLocSourceNamesLibrary = new RegisterPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterPageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForRegisterPage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubTitleNameReferenceForRegisterPageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Register", null);
            var RegisterPageLocSourceNamesLibrary = new RegisterPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterPageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForRegisterPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHeadingNameReferenceForRegisterPageIsCorrect()
        {
            string Heading = _loc.GetLocalizedString("en", "Create A New Account", null);
            var RegisterPageLocSourceNamesLibrary = new RegisterPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterPageLocSourceNamesLibrary.GetLocSourceHeadingNameReferenceForRegisterPage();
            Assert.Equal(Heading, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceServiceHeadingNameReferenceForRegisterPageIsCorrect()
        {
            string ServiceHeading = _loc.GetLocalizedString("en", "Use Another Service To Register", null);
            var RegisterPageLocSourceNamesLibrary = new RegisterPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterPageLocSourceNamesLibrary.GetLocSourceServiceHeadingNameReferenceForRegisterPage();
            Assert.Equal(ServiceHeading, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRegisterButtonNameReferenceForRegisterPageIsCorrect()
        {
            string RegisterButton = _loc.GetLocalizedString("en", "Register", null);
            var RegisterPageLocSourceNamesLibrary = new RegisterPageLocSourceNames();
            string ReturnedNameKeyValue = RegisterPageLocSourceNamesLibrary.GetLocSourceRegisterButtonNameReferenceForRegisterPage();
            Assert.Equal(RegisterButton, ReturnedNameKeyValue);
        }
    }

}
