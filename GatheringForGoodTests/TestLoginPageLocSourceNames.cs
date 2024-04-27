using System;
using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestLoginPageLocSourceNames
    {

        private readonly ISharedCultureLocalizer _loc;

        public TestLoginPageLocSourceNames()
        {
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePageTabTitleNameReferenceForLoginPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Login", null);
            var LoginPageLocSourceNamesLibrary = new LoginPageLocSourceNames();
            string ReturnedNameKeyValue = LoginPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForLoginPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForLoginPageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "Welcome Back", null);
            var LoginPageLocSourceNamesLibrary = new LoginPageLocSourceNames();
            string ReturnedNameKeyValue = LoginPageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForLoginPage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubTitleNameReferenceForLoginPageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Login", null);
            var LoginPageLocSourceNamesLibrary = new LoginPageLocSourceNames();
            string ReturnedNameKeyValue = LoginPageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForLoginPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHeadingNameReferenceForLoginPageIsCorrect()
        {
            string Heading = _loc.GetLocalizedString("en", "Log In To Your Account", null);
            var LoginPageLocSourceNamesLibrary = new LoginPageLocSourceNames();
            string ReturnedNameKeyValue = LoginPageLocSourceNamesLibrary.GetLocSourceHeadingNameReferenceForLoginPage();
            Assert.Equal(Heading, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceServiceHeadingNameReferenceForLoginPageIsCorrect()
        {
            string ServiceHeading = _loc.GetLocalizedString("en", "Use Another Service To Login", null);
            var LoginPageLocSourceNamesLibrary = new LoginPageLocSourceNames();
            string ReturnedNameKeyValue = LoginPageLocSourceNamesLibrary.GetLocSourceServiceHeadingNameReferenceForLoginPage();
            Assert.Equal(ServiceHeading, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceEmailHeadingNameReferenceForLoginPageIsCorrect()
        {
            string EmailHeading = _loc.GetLocalizedString("en", "Email", null);
            var LoginPageLocSourceNamesLibrary = new LoginPageLocSourceNames();
            string ReturnedNameKeyValue = LoginPageLocSourceNamesLibrary.GetLocSourceEmailHeadingNameReferenceForLoginPage();
            Assert.Equal(EmailHeading, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePasswordHeadingNameReferenceForLoginPageIsCorrect()
        {
            string PasswordHeading = _loc.GetLocalizedString("en", "Password", null);
            var LoginPageLocSourceNamesLibrary = new LoginPageLocSourceNames();
            string ReturnedNameKeyValue = LoginPageLocSourceNamesLibrary.GetLocSourcePasswordHeadingNameReferenceForLoginPage();
            Assert.Equal(PasswordHeading, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceButtonNameReferenceForLoginPageIsCorrect()
        {
            string LoginButtonText = _loc.GetLocalizedString("en", "Login", null);
            var LoginPageLocSourceNamesLibrary = new LoginPageLocSourceNames();
            string ReturnedNameKeyValue = LoginPageLocSourceNamesLibrary.GetLocSourceLoginButtonNameReferenceForLoginPage();
            Assert.Equal(LoginButtonText, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceResendEmailNameReferenceForLoginPageIsCorrect()
        {
            string ResendEmailButton = _loc.GetLocalizedString("en", "Resend email confirmation", null);
            var LoginPageLocSourceNamesLibrary = new LoginPageLocSourceNames();
            string ReturnedNameKeyValue = LoginPageLocSourceNamesLibrary.GetLocSourceResendEmailConfirmationNameReferenceForLoginPage();
            Assert.Equal(ResendEmailButton, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceForgotPasswordNameReferenceForLoginPageIsCorrect()
        {
            string ForgotPasswordLink = _loc.GetLocalizedString("en", "Forgot your password?", null);
            var LoginPageLocSourceNamesLibrary = new LoginPageLocSourceNames();
            string ReturnedNameKeyValue = LoginPageLocSourceNamesLibrary.GetLocSourceForgotPasswordNameReferenceForLoginPage();
            Assert.Equal(ForgotPasswordLink, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceLoginNewUserNameReferenceForLoginPageIsCorrect()
        {
            string RegisterLink = _loc.GetLocalizedString("en", "Register as a new user", null);
            var LoginPageLocSourceNamesLibrary = new LoginPageLocSourceNames();
            string ReturnedNameKeyValue = LoginPageLocSourceNamesLibrary.GetLocSourceRegisterAsNewUserNameReferenceForLoginPage();
            Assert.Equal(RegisterLink, ReturnedNameKeyValue);
        }
    }
}
