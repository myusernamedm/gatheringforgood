using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using GatheringForGood.UnitTests;
using LocSourceNameReferenceLibrary;
using OpenQA.Selenium.Support.UI;
using System.Drawing;
using System.Threading;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UITests
{
    public class TestHomepageComponentsArePresent
    {

        private readonly ISharedCultureLocalizer _loc;

        public TestHomepageComponentsArePresent()
        {
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckImagesAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestHomepageComponentsArePresent_CheckImagesAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("HomePageBanner")));
                IWebElement TitleImageElement = driver.FindElement(By.Id("TitleImage"));
                IWebElement _HomePageLogoImg = driver.FindElement(By.Id("_HomePageLogoImg"));
                IWebElement ChromeLogoImage = driver.FindElement(By.Id("ChromeLogoImage"));
                IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_HomePageLogoImg"));
                IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));
                IWebElement co2Image = driver.FindElement(By.CssSelector("[class='row justify-content-center align-items-center co2-bg-img']"));
                IWebElement rhinoImage = driver.FindElement(By.CssSelector("[class='row justify-content-center align-items-center rhino-bg-img']"));
                IWebElement forestImage = driver.FindElement(By.CssSelector("[class='row justify-content-center align-items-center forestsos-bg-img']"));
                IWebElement HomepageRAEIconImage = driver.FindElement(By.Id("HomepageRAEIconImage"));
                IWebElement HomepageRGWIconImage = driver.FindElement(By.Id("HomepageRGWIconImage"));
                IWebElement HomepageRDFIconImage = driver.FindElement(By.Id("HomepageRDFIconImage"));
                IWebElement HomePageNewsfeedIconImage = driver.FindElement(By.Id("HomePageNewsfeedIconImage"));
                IWebElement HomepageArticlesIconImage = driver.FindElement(By.Id("HomepageArticlesIconImage"));
                IWebElement HomepageOffsetIconImage = driver.FindElement(By.Id("HomepageOffsetIconImageTemp"));
                IWebElement HomepageAgileIconImage = driver.FindElement(By.Id("HomepageAgileIconImage"));
                IWebElement HomePageTwitterShareIconImage = driver.FindElement(By.Id("HomePageTwitterShareIconImage"));
                IWebElement HomePageFBShareIconImage = driver.FindElement(By.Id("HomePageFBShareIconImage"));
                IWebElement HomePageLinkedinShareIconImage = driver.FindElement(By.Id("HomePageLinkedinShareIconImage"));
                IWebElement FooterTwitterShareIconImage = driver.FindElement(By.Id("FooterTwitterShareIconImage"));
                IWebElement FooterFBShareIconImage = driver.FindElement(By.Id("FooterFBShareIconImage"));
                IWebElement FooterLinkedinShareIconImage = driver.FindElement(By.Id("FooterLinkedinShareIconImage"));

                Thread.Sleep(1000);
                Assert.True(BannerImageElement.Displayed);
                Assert.True(TitleImageElement.Displayed);
                Assert.True(_HomePageLogoImg.Displayed);
                Assert.True(ChromeLogoImage.Displayed);
                Assert.True(_LayoutPageLogoElement.Displayed);
                Assert.True(BodyBackground.Displayed);
                Assert.True(co2Image.Displayed);
                Assert.True(rhinoImage.Displayed);
                Assert.True(forestImage.Displayed);
                Assert.True(HomepageRAEIconImage.Displayed);
                Assert.True(HomepageRGWIconImage.Displayed);
                Assert.True(HomepageRDFIconImage.Displayed);
                Assert.True(HomePageNewsfeedIconImage.Displayed);
                Assert.True(HomepageArticlesIconImage.Displayed);
                Assert.True(HomepageOffsetIconImage.Displayed);
                Assert.True(HomepageAgileIconImage.Displayed);
                Assert.True(HomePageTwitterShareIconImage.Displayed);
                Assert.True(HomePageFBShareIconImage.Displayed);
                Assert.True(HomePageLinkedinShareIconImage.Displayed);
                Assert.True(FooterTwitterShareIconImage.Displayed);
                Assert.True(FooterFBShareIconImage.Displayed);
                Assert.True(FooterLinkedinShareIconImage.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);

                Assert.False(ChromeLogoImage.Displayed);
                Assert.True(_HomePageLogoImg.Displayed);
                Assert.True(HomepageRAEIconImage.Displayed);
                Assert.True(HomepageRGWIconImage.Displayed);
                Assert.True(HomepageRDFIconImage.Displayed);
                Assert.True(HomePageNewsfeedIconImage.Displayed);
                Assert.True(HomepageArticlesIconImage.Displayed);
                Assert.True(HomepageOffsetIconImage.Displayed);
                Assert.True(HomepageAgileIconImage.Displayed);
                Assert.True(HomePageTwitterShareIconImage.Displayed);
                Assert.True(HomePageFBShareIconImage.Displayed);
                Assert.True(HomePageLinkedinShareIconImage.Displayed);
                Assert.True(FooterTwitterShareIconImage.Displayed);
                Assert.True(FooterFBShareIconImage.Displayed);
                Assert.True(FooterLinkedinShareIconImage.Displayed);

            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckNavBarIsDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestHomepageComponentsArePresent_CheckNavBarIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-home-page")));
                IWebElement NavBarHomeLinkElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_HomePageHomeNavLink")));
                IWebElement NavBarArticlesLinkElement = driver.FindElement(By.Id("_HomePageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_HomePageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_HomePageHelpNavLink"));
                IWebElement NavBarRegisterLinkElement = driver.FindElement(By.Id("_LoginPartialRegister"));
                IWebElement NavBarLoginLinkElement = driver.FindElement(By.Id("_LoginPartialLogin"));

                Assert.True(NavBarElement.Displayed);
                Assert.True(NavBarHomeLinkElement.Displayed);
                Assert.True(NavBarArticlesLinkElement.Displayed);
                Assert.True(NavBarAboutLinkElement.Displayed);
                Assert.True(NavBarHelpLinkElement.Displayed);
                Assert.True(NavBarRegisterLinkElement.Displayed);
                Assert.True(NavBarLoginLinkElement.Displayed);

                Assert.Equal("HOME", NavBarHomeLinkElement.Text);
                Assert.Equal("ARTICLES", NavBarArticlesLinkElement.Text);
                Assert.Equal("ABOUT", NavBarAboutLinkElement.Text);
                Assert.Equal("HELP CENTER", NavBarHelpLinkElement.Text);
                Assert.Equal("REGISTER", NavBarRegisterLinkElement.Text);
                Assert.Equal("LOGIN", NavBarLoginLinkElement.Text);
            }, filename, driver);
        }

        //Re-enable when language dropdown is re-enabled
        /*
        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Long")]
        [Trait("TestEnvironment", "Local")]
        public void CheckLanguageDropdownIsDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestHomepageComponentsArePresent_CheckLanguageDropdownIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

            driver.Navigate().GoToUrl(HomeUrl);
            driver.Manage().Window.Maximize();
            IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-home-page")));
            IWebElement LanguageDropdownElement = driver.FindElement(By.Id("HomePageLanguageSelect"));

            Assert.True(LanguageDropdownElement.Displayed);
            }, filename, driver);
        }
        */

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckButtonsAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestHomepageComponentsArePresent_CheckButtonsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-home-page")));
                IWebElement MakeADifferenceButtonElement = driver.FindElement(By.Id("HomePageMakeDiffBtn"));
                IWebElement CarbonClockHowCanIHelpButton1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("CarbonClockHowCanIHelpButton1")));
                IWebElement CarbonClockHowCanIHelpButton2 = driver.FindElement(By.Id("CarbonClockHowCanIHelpButton2"));
                IWebElement ExtinctionClockHowCanIHelpButton1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ExtinctionClockHowCanIHelpButton1")));
                IWebElement ExtinctionClockHowCanIHelpButton2 = driver.FindElement(By.Id("ExtinctionClockHowCanIHelpButton2"));
                IWebElement ForestClockHowCanIHelpButton1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ForestClockHowCanIHelpButton1")));
                IWebElement ForestClockHowCanIHelpButton2 = driver.FindElement(By.Id("ForestClockHowCanIHelpButton2"));

                Assert.True(MakeADifferenceButtonElement.Displayed);
                Assert.True(CarbonClockHowCanIHelpButton1.Displayed);
                Assert.False(CarbonClockHowCanIHelpButton2.Displayed);
                Assert.True(ExtinctionClockHowCanIHelpButton1.Displayed);
                Assert.False(ExtinctionClockHowCanIHelpButton2.Displayed);
                Assert.True(ForestClockHowCanIHelpButton1.Displayed);
                Assert.False(ForestClockHowCanIHelpButton2.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);

                Assert.False(CarbonClockHowCanIHelpButton1.Displayed);
                Assert.True(CarbonClockHowCanIHelpButton2.Displayed);
                Assert.False(ExtinctionClockHowCanIHelpButton1.Displayed);
                Assert.True(ExtinctionClockHowCanIHelpButton2.Displayed);
                Assert.False(ForestClockHowCanIHelpButton1.Displayed);
                Assert.True(ForestClockHowCanIHelpButton2.Displayed);

            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckTextSectionsAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestHomepageComponentsArePresent_CheckTextSectionsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                var RegisterConfPageLocSourceNames = new RegisterConfPageLocSourceNames();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();
                string HomeUrlWithStatusMessage = UrlRefLibrary.TestUnverifiedUserHomepageRedirectUrl();
                string CorrectStatusMessage = _loc.GetLocalizedString("en", RegisterConfPageLocSourceNames.GetLocSourceCheckEmail1NameReferenceForRegisterConfPage(), null);

                driver.Navigate().GoToUrl(HomeUrlWithStatusMessage);
                driver.Manage().Window.Maximize();

                IWebElement HomeStatusMessage1 = driver.FindElement(By.Id("HomeStatusMessage"));
                Assert.Contains(CorrectStatusMessage, HomeStatusMessage1.Text);

                driver.Manage().Window.Size = new Size(240, 600);
                Assert.Contains(CorrectStatusMessage, HomeStatusMessage1.Text);

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-home-page")));
                IWebElement BetaNotice = driver.FindElement(By.Id("BetaNotice"));
                IWebElement BetaNoticeLink = driver.FindElement(By.Id("BetaNoticeLink"));
                IWebElement TitleElement = driver.FindElement(By.Id("HomePageTitle"));
                IWebElement SubTitle1Element = driver.FindElement(By.Id("HomePageSubTitle1"));
                IWebElement SubTitle2Element = driver.FindElement(By.Id("HomePageSubTitle2"));
                IWebElement GreatestChallengeTitle = driver.FindElement(By.Id("GreatestChallengeTitle"));
                IWebElement GreatestChallengePara = driver.FindElement(By.Id("GreatestChallengePara"));
                IWebElement CannotDependSolelyPara = driver.FindElement(By.Id("CannotDependSolelyPara"));
                IWebElement HomeStatusMessage = driver.FindElement(By.Id("HomeStatusMessage"));

                IWebElement HomePageRAEIconText = driver.FindElement(By.Id("HomePageRAEIconText"));
                IWebElement HomePageRGWIconText = driver.FindElement(By.Id("HomePageRGWIconText"));
                IWebElement HomePageRDFIconText = driver.FindElement(By.Id("HomePageRDFIconText"));
                IWebElement HomePageNewsfeedIconText = driver.FindElement(By.Id("HomePageNewsfeedIconText"));
                IWebElement HomePageArticlesIconText = driver.FindElement(By.Id("HomePageArticlesIconText"));
                IWebElement HomePageOffsetIconText = driver.FindElement(By.Id("HomePageOffsetIconTextTemp"));
                IWebElement HomePageAgileIconText = driver.FindElement(By.Id("HomePageAgileIconText"));

                IWebElement CarbonClockTitle = driver.FindElement(By.Id("CarbonClockTitle"));
                IWebElement CarbonClockPara1 = driver.FindElement(By.Id("CarbonClockPara1"));
                IWebElement CarbonClockPara2 = driver.FindElement(By.Id("CarbonClockPara2"));
                //IWebElement CarbonClockLearnMore = driver.FindElement(By.Id("CarbonClockLearnMore"));
                IWebElement Onept5DegTimeUntilTitle = driver.FindElement(By.Id("1pt5DegTimeUntilTitle"));
                IWebElement Onept5DegTitle = driver.FindElement(By.Id("1pt5DegTitle"));
                IWebElement CarbonClock15 = driver.FindElement(By.Id("CarbonClock15"));
                IWebElement TwoDegTimeUntilTitle = driver.FindElement(By.Id("2DegTimeUntilTitle"));
                IWebElement TwoDegTitle = driver.FindElement(By.Id("2DegTitle"));
                IWebElement CarbonClock20 = driver.FindElement(By.Id("CarbonClock20"));
                IWebElement ExtinctionClockTitle = driver.FindElement(By.Id("ExtinctionClockTitle"));
                IWebElement ExtinctionClockPara1 = driver.FindElement(By.Id("ExtinctionClockPara1"));
                IWebElement ExtinctionClockPara2 = driver.FindElement(By.Id("ExtinctionClockPara2"));
                //IWebElement ExtinctionClockLearnMore = driver.FindElement(By.Id("ExtinctionClockLearnMore"));
                IWebElement AllSpeciesExtinctTimeUntilTitle = driver.FindElement(By.Id("AllSpeciesExtinctTimeUntilTitle"));
                IWebElement AllSpeciesExtinctTitle = driver.FindElement(By.Id("AllSpeciesExtinctTitle"));
                IWebElement ExtinctionClockMostLost = driver.FindElement(By.Id("ExtinctionClockMostLost"));
                IWebElement ExtinctionsSinceTitle = driver.FindElement(By.Id("ExtinctionsSinceTitle"));
                IWebElement GFGLaunchTitle = driver.FindElement(By.Id("GFGLaunchTitle"));
                IWebElement ExtinctionClockSinceLaunch = driver.FindElement(By.Id("ExtinctionClockSinceLaunch"));
                IWebElement ForestClockTitle = driver.FindElement(By.Id("ForestClockTitle"));
                IWebElement ForestClockPara1 = driver.FindElement(By.Id("ForestClockPara1"));
                IWebElement ForestClockPara2 = driver.FindElement(By.Id("ForestClockPara2"));
                //IWebElement ForestClockLearnMore = driver.FindElement(By.Id("ForestClockLearnMore"));
                IWebElement AllForestLostTimeUntilTitle = driver.FindElement(By.Id("AllForestLostTimeUntilTitle"));
                IWebElement AllForestLostTitle = driver.FindElement(By.Id("AllForestLostTitle"));
                IWebElement ForestClockAllLost = driver.FindElement(By.Id("ForestClockAllLost"));
                IWebElement ForestLostSinceTitle = driver.FindElement(By.Id("ForestLostSinceTitle"));
                IWebElement ForestGFGLaunchTitle = driver.FindElement(By.Id("ForestGFGLaunchTitle"));
                IWebElement ForestClockSinceLaunch = driver.FindElement(By.Id("ForestClockSinceLaunch"));

                Assert.True(BetaNotice.Displayed);
                Assert.True(BetaNoticeLink.Displayed);
                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitle1Element.Displayed);
                Assert.True(SubTitle2Element.Displayed);
                Assert.True(GreatestChallengeTitle.Displayed);
                Assert.True(GreatestChallengePara.Displayed);
                Assert.True(CannotDependSolelyPara.Displayed);
                Assert.Equal("", HomeStatusMessage.Text);
                Assert.True(HomePageRAEIconText.Displayed);
                Assert.True(HomePageRGWIconText.Displayed);
                Assert.True(HomePageRDFIconText.Displayed);
                Assert.True(HomePageNewsfeedIconText.Displayed);
                Assert.True(HomePageArticlesIconText.Displayed);
                Assert.True(HomePageOffsetIconText.Displayed);
                Assert.True(HomePageAgileIconText.Displayed);
                Assert.True(CarbonClockTitle.Displayed);
                Assert.True(CarbonClockPara1.Displayed);
                Assert.True(CarbonClockPara2.Displayed);
                //Assert.True(CarbonClockLearnMore.Displayed);
                Assert.True(Onept5DegTimeUntilTitle.Displayed);
                Assert.True(Onept5DegTitle.Displayed);
                Assert.True(CarbonClock15.Displayed);
                Assert.True(TwoDegTimeUntilTitle.Displayed);
                Assert.True(TwoDegTitle.Displayed);
                Assert.True(CarbonClock20.Displayed);
                Assert.True(ExtinctionClockTitle.Displayed);
                Assert.True(ExtinctionClockPara1.Displayed);
                Assert.True(ExtinctionClockPara2.Displayed);
                //Assert.True(ExtinctionClockLearnMore.Displayed);
                Assert.True(AllSpeciesExtinctTimeUntilTitle.Displayed);
                Assert.True(AllSpeciesExtinctTitle.Displayed);
                Assert.True(ExtinctionClockMostLost.Displayed);
                Assert.True(ExtinctionsSinceTitle.Displayed);
                Assert.True(GFGLaunchTitle.Displayed);
                Assert.True(ExtinctionClockSinceLaunch.Displayed);
                Assert.True(ForestClockTitle.Displayed);
                Assert.True(ForestClockPara1.Displayed);
                Assert.True(ForestClockPara2.Displayed);
                //Assert.True(ForestClockLearnMore.Displayed);
                Assert.True(AllForestLostTimeUntilTitle.Displayed);
                Assert.True(AllForestLostTitle.Displayed);
                Assert.True(ForestClockAllLost.Displayed);
                Assert.True(ForestLostSinceTitle.Displayed);
                Assert.True(ForestGFGLaunchTitle.Displayed);
                Assert.True(ForestClockSinceLaunch.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);

                Assert.True(BetaNotice.Displayed);
                Assert.True(BetaNoticeLink.Displayed);
                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitle1Element.Displayed);
                Assert.True(SubTitle2Element.Displayed);
                Assert.True(GreatestChallengeTitle.Displayed);
                Assert.True(GreatestChallengePara.Displayed);
                Assert.True(CannotDependSolelyPara.Displayed);
                Assert.Equal("", HomeStatusMessage.Text);
                Assert.True(HomePageRAEIconText.Displayed);
                Assert.True(HomePageRGWIconText.Displayed);
                Assert.True(HomePageRDFIconText.Displayed);
                Assert.True(HomePageNewsfeedIconText.Displayed);
                Assert.True(HomePageArticlesIconText.Displayed);
                Assert.True(HomePageOffsetIconText.Displayed);
                Assert.True(HomePageAgileIconText.Displayed);
                Assert.True(CarbonClockTitle.Displayed);
                Assert.True(CarbonClockPara1.Displayed);
                Assert.True(CarbonClockPara2.Displayed);
                //Assert.True(CarbonClockLearnMore.Displayed);
                Assert.True(Onept5DegTimeUntilTitle.Displayed);
                Assert.True(Onept5DegTitle.Displayed);
                Assert.True(CarbonClock15.Displayed);
                Assert.True(TwoDegTimeUntilTitle.Displayed);
                Assert.True(TwoDegTitle.Displayed);
                Assert.True(CarbonClock20.Displayed);
                Assert.True(ExtinctionClockTitle.Displayed);
                Assert.True(ExtinctionClockPara1.Displayed);
                Assert.True(ExtinctionClockPara2.Displayed);
                //Assert.True(ExtinctionClockLearnMore.Displayed);
                Assert.True(AllSpeciesExtinctTimeUntilTitle.Displayed);
                Assert.True(AllSpeciesExtinctTitle.Displayed);
                Assert.True(ExtinctionClockMostLost.Displayed);
                Assert.True(ExtinctionsSinceTitle.Displayed);
                Assert.True(GFGLaunchTitle.Displayed);
                Assert.True(ExtinctionClockSinceLaunch.Displayed);
                Assert.True(ForestClockTitle.Displayed);
                Assert.True(ForestClockPara1.Displayed);
                Assert.True(ForestClockPara2.Displayed);
                //Assert.True(ForestClockLearnMore.Displayed);
                Assert.True(AllForestLostTimeUntilTitle.Displayed);
                Assert.True(AllForestLostTitle.Displayed);
                Assert.True(ForestClockAllLost.Displayed);
                Assert.True(ForestLostSinceTitle.Displayed);
                Assert.True(ForestGFGLaunchTitle.Displayed);
                Assert.True(ForestClockSinceLaunch.Displayed);

            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Long")]
        [Trait("TestEnvironment", "Local")]
        public void CheckFooterIsDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestHomepageComponentsArePresent_CheckFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();
                IWebElement FooterElement = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("nav-footer")));
                IWebElement CopyrightListItemElement = driver.FindElement(By.Id("_LayoutCopyrightFooterLabel"));
                IWebElement RegisterFooterLink = driver.FindElement(By.Id("_LayoutRegisterFooterLink"));
                IWebElement AboutFooterLink = driver.FindElement(By.Id("_LayoutAboutFooterLink"));
                IWebElement ArticlesFooterLink = driver.FindElement(By.Id("_LayoutArticlesFooterLink"));
                IWebElement PrivacyFooterLink = driver.FindElement(By.Id("_LayoutPrivacyFooterLink"));
                IWebElement CookiesFooterLink = driver.FindElement(By.Id("_LayoutCookiesFooterLink"));
                IWebElement UpdatesFooterLink = driver.FindElement(By.Id("_LayoutUpdatesFooterLink"));

                Assert.True(FooterElement.Displayed);
                Assert.True(CopyrightListItemElement.Displayed);
                Assert.True(RegisterFooterLink.Displayed);
                Assert.True(AboutFooterLink.Displayed);
                Assert.True(ArticlesFooterLink.Displayed);
                Assert.True(PrivacyFooterLink.Displayed);
                Assert.True(CookiesFooterLink.Displayed);
                Assert.True(UpdatesFooterLink.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);

                Assert.True(FooterElement.Displayed);
                Assert.True(CopyrightListItemElement.Displayed);
                Assert.True(RegisterFooterLink.Displayed);
                Assert.True(AboutFooterLink.Displayed);
                Assert.True(ArticlesFooterLink.Displayed);
                Assert.True(PrivacyFooterLink.Displayed);
                Assert.True(CookiesFooterLink.Displayed);
                Assert.True(UpdatesFooterLink.Displayed);

            }, filename, driver);
        }
    }
}
