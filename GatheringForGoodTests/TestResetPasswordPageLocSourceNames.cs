using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestResetPasswordPageLocSourceNames
    {
        private readonly ISharedCultureLocalizer _loc;

        public TestResetPasswordPageLocSourceNames()
        {
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePageTabTitleNameReferenceForResetPasswordPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Reset Password", null);
            var ResetPasswordPageLocSourceNames = new ResetPasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ResetPasswordPageLocSourceNames.GetLocSourcePageTabTitleNameReferenceForResetPasswordPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForResetPasswordPageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "Please Enter A New Password", null);
            var ResetPasswordPageLocSourceNames = new ResetPasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ResetPasswordPageLocSourceNames.GetLocSourceTitleNameReferenceForResetPasswordPage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubTitleNameReferenceForResetPasswordPageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Enter A New Password", null);
            var ResetPasswordPageLocSourceNames = new ResetPasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ResetPasswordPageLocSourceNames.GetLocSourceHeadingNameReferenceForResetPasswordPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHeadingNameReferenceForResetPasswordPageIsCorrect()
        {
            string Heading = _loc.GetLocalizedString("en", "Account Security", null);
            var ResetPasswordPageLocSourceNames = new ResetPasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ResetPasswordPageLocSourceNames.GetLocSourceSubHeadingNameReferenceForResetPasswordPage();
            Assert.Equal(Heading, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceResetButtonNameReferenceForResetPasswordPageIsCorrect()
        {
            string ResetButton = _loc.GetLocalizedString("en", "Reset", null);
            var ResetPasswordPageLocSourceNames = new ResetPasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ResetPasswordPageLocSourceNames.GetLocSourceResetButtonNameReferenceForResetPasswordPage();
            Assert.Equal(ResetButton, ReturnedNameKeyValue);
        }
    }
}
