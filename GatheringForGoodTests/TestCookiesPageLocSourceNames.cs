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
    public class TestCookiesPageLocSourceNames
    {

        private readonly ISharedCultureLocalizer _loc;

        public TestCookiesPageLocSourceNames()
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
        public void LocSourcePageTabTitleNameReferenceForFeaturePageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Cookies Notice", null);
            var CookiesPageLocSourceNamesLibrary = new CookiesPageLocSourceNames();
            string ReturnedNameKeyValue = CookiesPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForCookiesPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForFeaturePageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "Cookie policy and preferences", null);
            var CookiesPageLocSourceNamesLibrary = new CookiesPageLocSourceNames();
            string ReturnedNameKeyValue = CookiesPageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForCookiesPage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubtitleNameReferenceForFeaturePageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Cookies Notice", null);
            var CookiesPageLocSourceNamesLibrary = new CookiesPageLocSourceNames();
            string ReturnedNameKeyValue = CookiesPageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForCookiesPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }
    }
}
