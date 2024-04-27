using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestChangePasswordPageLocSourceNames
    {
        private readonly ISharedCultureLocalizer _loc;

        public TestChangePasswordPageLocSourceNames()
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
        public void LocSourcePageTabTitleNameReferenceForChangePasswordPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "My Account", null);
            var ChangePasswordPageLocSourceNamesLibrary = new ChangePasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ChangePasswordPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForChangePasswordPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForChangePasswordPageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "Manage Your GatheringForGood Account", null);
            var ChangePasswordPageLocSourceNamesLibrary = new ChangePasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ChangePasswordPageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForChangePasswordPage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubtitleNameReferenceForChangePasswordPageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "My Account", null);
            var ChangePasswordPageLocSourceNamesLibrary = new ChangePasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ChangePasswordPageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForChangePasswordPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHeadingNameReferenceForChangePasswordPageIsCorrect()
        {
            string Heading = _loc.GetLocalizedString("en", "Change your account settings", null);
            var ChangePasswordPageLocSourceNamesLibrary = new ChangePasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ChangePasswordPageLocSourceNamesLibrary.GetLocSourceHeadingNameReferenceForChangePasswordPage();
            Assert.Equal(Heading, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCurrentPasswordHeadingNameReferenceForChangePasswordPageIsCorrect()
        {
            string CurrentPasswordHeading = _loc.GetLocalizedString("en", "Current password", null);
            var ChangePasswordPageLocSourceNamesLibrary = new ChangePasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ChangePasswordPageLocSourceNamesLibrary.GetLocSourceCurrentPasswordHeadingNameReferenceForChangePasswordPage();
            Assert.Equal(CurrentPasswordHeading, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceNewPasswordHeadingNameReferenceForChangePasswordPage()
        {
            string NewPasswordHeading = _loc.GetLocalizedString("en", "New password", null);
            var ChangePasswordPageLocSourceNamesLibrary = new ChangePasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ChangePasswordPageLocSourceNamesLibrary.GetLocSourceNewPasswordHeadingNameReferenceForChangePasswordPage();
            Assert.Equal(NewPasswordHeading, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceConfirmNewPasswordHeadingNameReferenceForChangePasswordPage()
        {
            string ConfirmNewPasswordHeading = _loc.GetLocalizedString("en", "Confirm new password", null);
            var ChangePasswordPageLocSourceNamesLibrary = new ChangePasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ChangePasswordPageLocSourceNamesLibrary.GetLocSourceConfirmNewPasswordHeadingNameReferenceForChangePasswordPage();
            Assert.Equal(ConfirmNewPasswordHeading, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceUpdatePasswordButtonTextNameReferenceForChangePasswordPage()
        {
            string UpdatePasswordButtonText = _loc.GetLocalizedString("en", "Update password", null);
            var ChangePasswordPageLocSourceNamesLibrary = new ChangePasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ChangePasswordPageLocSourceNamesLibrary.GetLocSourceUpdatePasswordButtonTextNameReferenceForChangePasswordPage();
            Assert.Equal(UpdatePasswordButtonText, ReturnedNameKeyValue);
        }
    }
}
