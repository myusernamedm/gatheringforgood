using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestEmailManagePageLocSourceNames
    {
        private readonly ISharedCultureLocalizer _loc;

        public TestEmailManagePageLocSourceNames()
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
        public void LocSourcePageTabTitleNameReferenceForEmailManagePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "My Account", null);
            var EmailManagePageLocSourceNamesLibrary = new EmailManagePageLocSourceNames();
            string ReturnedNameKeyValue = EmailManagePageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForEmailManagePage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForEmailManagePageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "Manage Your GatheringForGood Account", null);
            var EmailManagePageLocSourceNamesLibrary = new EmailManagePageLocSourceNames();
            string ReturnedNameKeyValue = EmailManagePageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForEmailManagePage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubtitleNameReferenceForEmailManagePageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "My Account", null);
            var EmailManagePageLocSourceNamesLibrary = new EmailManagePageLocSourceNames();
            string ReturnedNameKeyValue = EmailManagePageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForEmailManagePage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHeadingNameReferenceForEmailManagePageIsCorrect()
        {
            string Heading = _loc.GetLocalizedString("en", "Change your account settings", null);
            var EmailManagePageLocSourceNamesLibrary = new EmailManagePageLocSourceNames();
            string ReturnedNameKeyValue = EmailManagePageLocSourceNamesLibrary.GetLocSourceHeadingNameReferenceForEmailManagePage();
            Assert.Equal(Heading, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceUsernameHeadingNameReferenceForEmailManagePageIsCorrect()
        {
            string EmailHeading = _loc.GetLocalizedString("en", "Email", null);
            var EmailManagePageLocSourceNamesLibrary = new EmailManagePageLocSourceNames();
            string ReturnedNameKeyValue = EmailManagePageLocSourceNamesLibrary.GetLocSourceEmailHeadingNameReferenceForEmailManagePage();
            Assert.Equal(EmailHeading, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePhoneNumberHeadingNameReferenceForEmailManagePage()
        {
            string NewEmail = _loc.GetLocalizedString("en", "New email", null);
            var EmailManagePageLocSourceNamesLibrary = new EmailManagePageLocSourceNames();
            string ReturnedNameKeyValue = EmailManagePageLocSourceNamesLibrary.GetLocSourceNewEmailHeadingNameReferenceForEmailManagePage();
            Assert.Equal(NewEmail, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSaveButtonTextNameReferenceForEmailManagePage()
        {
            string ChangeEmail = _loc.GetLocalizedString("en", "Change email", null);
            var EmailManagePageLocSourceNamesLibrary = new EmailManagePageLocSourceNames();
            string ReturnedNameKeyValue = EmailManagePageLocSourceNamesLibrary.GetLocSourceChangeEmailButtonTextNameReferenceForEmailManagePage();
            Assert.Equal(ChangeEmail, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceProfileNavButtonNameReferenceForEmailManagePage()
        {
            string SendVerificationEmail = _loc.GetLocalizedString("en", "Send verification email", null);
            var EmailManagePageLocSourceNamesLibrary = new EmailManagePageLocSourceNames();
            string ReturnedNameKeyValue = EmailManagePageLocSourceNamesLibrary.GetLocSourceSendVerificationEmailButtonTextNameReferenceForEmailManagePage();
            Assert.Equal(SendVerificationEmail, ReturnedNameKeyValue);
        }
    }
}
