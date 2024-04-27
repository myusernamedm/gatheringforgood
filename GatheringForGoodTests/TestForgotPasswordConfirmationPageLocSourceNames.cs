using System;
using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.AspNetCore.Mvc.Localization;
using GatheringForGood.LocalizationResources;

namespace GatheringForGood.UnitTests
{
    public class TestForgotPasswordConfirmationPageLocSourceNames
    {
        private readonly ISharedCultureLocalizer _loc;

        public TestForgotPasswordConfirmationPageLocSourceNames()
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
        public void LocSourcePageTabTitleNameReferenceForForgotPasswordPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Forgotten Password", null);
            var ForgotPasswordConfirmationPageLocSourceNames = new ForgotPasswordConfirmationPageLocSourceNames();
            string ReturnedNameKeyValue = ForgotPasswordConfirmationPageLocSourceNames.GetLocSourcePageTabTitleNameReferenceForForgotPasswordConfirmationPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForForgotPasswordPageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "Please Check Your Email Account", null);
            var ForgotPasswordConfirmationPageLocSourceNames = new ForgotPasswordConfirmationPageLocSourceNames();
            string ReturnedNameKeyValue = ForgotPasswordConfirmationPageLocSourceNames.GetLocSourceTitleNameReferenceForForgotPasswordConfirmationPage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubTitleNameReferenceForForgotPasswordPageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Account Security", null);
            var ForgotPasswordConfirmationPageLocSourceNames = new ForgotPasswordConfirmationPageLocSourceNames();
            string ReturnedNameKeyValue = ForgotPasswordConfirmationPageLocSourceNames.GetLocSourceSubtitleNameReferenceForForgotPasswordConfirmationPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHeadingNameReferenceForForgotPasswordPageIsCorrect()
        {
            string Heading = _loc.GetLocalizedString("en", "Reset Your Password", null);
            var ForgotPasswordConfirmationPageLocSourceNames = new ForgotPasswordConfirmationPageLocSourceNames();
            string ReturnedNameKeyValue = ForgotPasswordConfirmationPageLocSourceNames.GetLocSourceHeadingNameReferenceForForgotPasswordConfirmationPage();
            Assert.Equal(Heading, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceEmailHeadingNameReferenceForForgotPasswordPageIsCorrect()
        {
            string EmailHeading = _loc.GetLocalizedString("en", "Please check your email to confirm your account.", null);
            var ForgotPasswordConfirmationPageLocSourceNames = new ForgotPasswordConfirmationPageLocSourceNames();
            string ReturnedNameKeyValue = ForgotPasswordConfirmationPageLocSourceNames.GetLocSourceEmailHeadingNameReferenceForForgotPasswordConfirmationPage();
            Assert.Equal(EmailHeading, ReturnedNameKeyValue);
        }
    }
}
