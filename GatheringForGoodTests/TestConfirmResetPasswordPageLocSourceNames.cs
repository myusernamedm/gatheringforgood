using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestConfirmResetPasswordPageLocSourceNames
    {
        private readonly ISharedCultureLocalizer _loc;

        public TestConfirmResetPasswordPageLocSourceNames()
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
        public void GetLocSourcePageTabTitleNameReferenceForConfirmResetPasswordPage()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Password Confirmation", null);
            var ConfirmResetPasswordPageLocSourceNames = new ConfirmResetPasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ConfirmResetPasswordPageLocSourceNames.GetLocSourcePageTabTitleNameReferenceForConfirmResetPasswordPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void GetLocSourceTitleNameReferenceForConfirmResetPasswordPage()
        {
            string Title = _loc.GetLocalizedString("en", "New Password Confirmed", null);
            var ConfirmResetPasswordPageLocSourceNames = new ConfirmResetPasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ConfirmResetPasswordPageLocSourceNames.GetLocSourceTitleNameReferenceForConfirmResetPasswordPage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void GetLocSourceSubtitleNameReferenceForConfirmResetPasswordPage()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Your New Password Has Been Confirmed", null);
            var ConfirmResetPasswordPageLocSourceNames = new ConfirmResetPasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ConfirmResetPasswordPageLocSourceNames.GetLocSourceSubtitleNameReferenceForConfirmResetPasswordPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void GetLocSourceHeadingNameReferenceForConfirmResetPasswordPage()
        {
            string Heading = _loc.GetLocalizedString("en", "Thank you for confirming your new password.", null);
            var ConfirmResetPasswordPageLocSourceNames = new ConfirmResetPasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ConfirmResetPasswordPageLocSourceNames.GetLocSourceHeadingNameReferenceForConfirmResetPasswordPage();
            Assert.Equal(Heading, ReturnedNameKeyValue);
        }
    }
}