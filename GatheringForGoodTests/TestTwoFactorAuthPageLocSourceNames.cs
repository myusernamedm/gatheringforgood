using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestTwoFactorAuthPageLocSourceNames
    {

        private readonly ISharedCultureLocalizer _loc;

        public TestTwoFactorAuthPageLocSourceNames()
        {
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePageTabTitleNameReferenceForTwoFactorAuthPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "My Account", null);
            var TwoFactorAuthPageLocSourceNamesLibrary = new TwoFactorAuthenticationManagePageLocSourceNames();
            string ReturnedNameKeyValue = TwoFactorAuthPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForTwoFactorAuthPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForTwoFactorAuthPageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "Manage Your GatheringForGood Account", null);
            var TwoFactorAuthPageLocSourceNamesLibrary = new TwoFactorAuthenticationManagePageLocSourceNames();
            string ReturnedNameKeyValue = TwoFactorAuthPageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForTwoFactorAuthPage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubtitleNameReferenceForTwoFactorAuthPageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "My Account", null);
            var TwoFactorAuthPageLocSourceNamesLibrary = new TwoFactorAuthenticationManagePageLocSourceNames();
            string ReturnedNameKeyValue = TwoFactorAuthPageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForTwoFactorAuthPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHeadingNameReferenceForTwoFactorAuthPageIsCorrect()
        {
            string Heading = _loc.GetLocalizedString("en", "Change your account settings", null);
            var TwoFactorAuthPageLocSourceNamesLibrary = new TwoFactorAuthenticationManagePageLocSourceNames();
            string ReturnedNameKeyValue = TwoFactorAuthPageLocSourceNamesLibrary.GetLocSourceHeadingNameReferenceForTwoFactorAuthPage();
            Assert.Equal(Heading, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAuthAppHeadingNameReferenceForTwoFactorAuthPageIsCorrect()
        {
            string AuthAppHeading = _loc.GetLocalizedString("en", "Authenticator app", null);
            var TwoFactorAuthPageLocSourceNamesLibrary = new TwoFactorAuthenticationManagePageLocSourceNames();
            string ReturnedNameKeyValue = TwoFactorAuthPageLocSourceNamesLibrary.GetLocSourceAuthAppHeadingNameReferenceForTwoFactorAuthPage();
            Assert.Equal(AuthAppHeading, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSetupAuthAppButtonTextNameReferenceForTwoFactorAuthPage()
        {
            string SetupAuthAppButtonText = _loc.GetLocalizedString("en", "Setup authenticator app", null);
            var TwoFactorAuthPageLocSourceNamesLibrary = new TwoFactorAuthenticationManagePageLocSourceNames();
            string ReturnedNameKeyValue = TwoFactorAuthPageLocSourceNamesLibrary.GetLocSourceSetupAuthAppButtonTextNameReferenceForTwoFactorAuthPage();
            Assert.Equal(SetupAuthAppButtonText, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceResetAuthAppButtonTextNameReferenceForTwoFactorAuthPage()
        {
            string ResetAuthAppButtonText = _loc.GetLocalizedString("en", "Reset authenticator app", null);
            var TwoFactorAuthPageLocSourceNamesLibrary = new TwoFactorAuthenticationManagePageLocSourceNames();
            string ReturnedNameKeyValue = TwoFactorAuthPageLocSourceNamesLibrary.GetLocSourceResetAuthAppButtonTextNameReferenceForTwoFactorAuthPage();
            Assert.Equal(ResetAuthAppButtonText, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAddAuthAppButtonTextNameReferenceForTwoFactorAuthPage()
        {
            string AddAuthAppButtonText = _loc.GetLocalizedString("en", "Add authenticator app", null);
            var TwoFactorAuthPageLocSourceNamesLibrary = new TwoFactorAuthenticationManagePageLocSourceNames();
            string ReturnedNameKeyValue = TwoFactorAuthPageLocSourceNamesLibrary.GetLocSourceAddAuthAppButtonTextNameReferenceForTwoFactorAuthPage();
            Assert.Equal(AddAuthAppButtonText, ReturnedNameKeyValue);
        }
    }
}