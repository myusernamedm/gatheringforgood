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
    public class TestForgotPasswordPageLocSourceNames
    {
        private readonly ISharedCultureLocalizer _loc;

        public TestForgotPasswordPageLocSourceNames()
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
            string PageTabTitle = _loc.GetLocalizedString("en", "Forgot Password", null);
            var ForgotPasswordPageLocSourceNamesLibrary = new ForgotPasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ForgotPasswordPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForForgotPasswordPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForForgotPasswordPageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "Forgotten Your Password? Dont worry!", null);
            var ForgotPasswordPageLocSourceNamesLibrary = new ForgotPasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ForgotPasswordPageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForForgotPasswordPage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHeadingNameReferenceForForgotPasswordPageIsCorrect()
        {
            string Heading = _loc.GetLocalizedString("en", "Account Security", null);
            var ForgotPasswordPageLocSourceNamesLibrary = new ForgotPasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ForgotPasswordPageLocSourceNamesLibrary.GetLocSourceHeadingNameReferenceForForgotPasswordPage();
            Assert.Equal(Heading, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubHeadingNameReferenceForForgotPasswordPageIsCorrect()
        {
            string SubHeading = _loc.GetLocalizedString("en", "Enter Your Email", null);
            var ForgotPasswordPageLocSourceNamesLibrary = new ForgotPasswordPageLocSourceNames();
            string ReturnedNameKeyValue = ForgotPasswordPageLocSourceNamesLibrary.GetLocSourceSubHeadingNameReferenceForForgotPasswordPage();
            Assert.Equal(SubHeading, ReturnedNameKeyValue);
        }
    }
}
