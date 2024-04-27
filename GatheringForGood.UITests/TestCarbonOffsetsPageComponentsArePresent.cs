using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Drawing;

namespace GatheringForGood.UITests
{
    public class TestCarbonOffsetsPageComponentsArePresent
    {
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
            var filename = "TestCarbonOffsetsPageComponentsArePresent_CheckImagesAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string CarbonOffsetUrl = UrlRefLibrary.GetCarbonOffsetsPageLocalHostUrl();

                driver.Navigate().GoToUrl(CarbonOffsetUrl);
                driver.Manage().Window.Maximize();
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("CarbonOffsetsPageBanner")));
                IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_CarbonOffsetsPageLogoImg"));
                IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));
                IWebElement OffsetMyCarbonMiniIconImage = driver.FindElement(By.Id("OffsetMyCarbonMiniIconImage"));
                IWebElement OffsetAJourneyMiniIconImage = driver.FindElement(By.Id("OffsetAJourneyMiniIconImage"));
                IWebElement OffsetByTonneMiniIconImage = driver.FindElement(By.Id("OffsetByTonneMiniIconImage"));
                IWebElement OffsetBusinessMiniIconImage = driver.FindElement(By.Id("OffsetBusinessMiniIconImage"));
                IWebElement PartnerLogoImage = driver.FindElement(By.Id("PartnerLogoImage"));
                IWebElement PieChartImage = driver.FindElement(By.Id("PieChartImage"));
                IWebElement CarbonOffsetsPageOffsetMyCarbonImage = driver.FindElement(By.Id("CarbonOffsetsPageOffsetMyCarbonImage"));
                IWebElement CarbonOffsetsPageOffsetAJourneyImage = driver.FindElement(By.Id("CarbonOffsetsPageOffsetAJourneyImage"));
                IWebElement CarbonOffsetsPageOffsetByTonneImage = driver.FindElement(By.Id("CarbonOffsetsPageOffsetByTonneImage"));
                IWebElement CarbonOffsetsPageOffsetMyBusinessCarbonImage = driver.FindElement(By.Id("CarbonOffsetsPageOffsetMyBusinessCarbonImage"));

                Assert.True(BannerImageElement.Displayed);
                Assert.True(_LayoutPageLogoElement.Displayed);
                Assert.True(BodyBackground.Displayed);
                Assert.True(OffsetMyCarbonMiniIconImage.Displayed);
                Assert.True(OffsetAJourneyMiniIconImage.Displayed);
                Assert.True(OffsetByTonneMiniIconImage.Displayed);
                Assert.True(OffsetBusinessMiniIconImage.Displayed);
                Assert.True(PartnerLogoImage.Displayed);
                Assert.True(PieChartImage.Displayed);
                Assert.True(CarbonOffsetsPageOffsetMyCarbonImage.Displayed);
                Assert.True(CarbonOffsetsPageOffsetAJourneyImage.Displayed);
                Assert.True(CarbonOffsetsPageOffsetByTonneImage.Displayed);
                Assert.True(CarbonOffsetsPageOffsetMyBusinessCarbonImage.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);

                Assert.True(BannerImageElement.Displayed);
                Assert.True(_LayoutPageLogoElement.Displayed);
                Assert.True(BodyBackground.Displayed);
                Assert.True(OffsetMyCarbonMiniIconImage.Displayed);
                Assert.True(OffsetAJourneyMiniIconImage.Displayed);
                Assert.True(OffsetByTonneMiniIconImage.Displayed);
                Assert.True(OffsetBusinessMiniIconImage.Displayed);
                Assert.True(PartnerLogoImage.Displayed);
                Assert.True(PieChartImage.Displayed);
                Assert.True(CarbonOffsetsPageOffsetMyCarbonImage.Displayed);
                Assert.True(CarbonOffsetsPageOffsetAJourneyImage.Displayed);
                Assert.True(CarbonOffsetsPageOffsetByTonneImage.Displayed);
                Assert.True(CarbonOffsetsPageOffsetMyBusinessCarbonImage.Displayed);

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
            var filename = "TestCarbonOffsetsPageComponentsArePresent_CheckNavBarIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string CarbonOffsetUrl = UrlRefLibrary.GetCarbonOffsetsPageLocalHostUrl();

                driver.Navigate().GoToUrl(CarbonOffsetUrl);
                driver.Manage().Window.Maximize();
                Thread.Sleep(1000);
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-carbonoffsets-page")));
                IWebElement NavBarHomeLinkElement = driver.FindElement(By.Id("_CarbonOffsetsPageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement = driver.FindElement(By.Id("_CarbonOffsetsPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_CarbonOffsetsPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_CarbonOffsetsPageHelpNavLink"));
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
            var filename = "TestCarbonOffsetsPageComponentsArePresent_CheckButtonsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string CarbonOffsetUrl = UrlRefLibrary.GetCarbonOffsetsPageLocalHostUrl();

                driver.Navigate().GoToUrl(CarbonOffsetUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-carbonoffsets-page")));
                IWebElement CarbonOffsetsPageOffsetMyCarbonButton = driver.FindElement(By.Id("CarbonOffsetsPageOffsetMyCarbonButton"));
                IWebElement CarbonOffsetsPageOffsetAJourneyButton = driver.FindElement(By.Id("CarbonOffsetsPageOffsetAJourneyButton"));
                IWebElement CarbonOffsetsPageOffsetByTonneButton = driver.FindElement(By.Id("CarbonOffsetsPageOffsetByTonneButton"));
                IWebElement CarbonOffsetsPageOffsetMyBusinessCarbonButton = driver.FindElement(By.Id("CarbonOffsetsPageOffsetMyBusinessCarbonButton"));

                Assert.True(CarbonOffsetsPageOffsetMyCarbonButton.Displayed);
                Assert.True(CarbonOffsetsPageOffsetAJourneyButton.Displayed);
                Assert.True(CarbonOffsetsPageOffsetByTonneButton.Displayed);
                Assert.True(CarbonOffsetsPageOffsetMyBusinessCarbonButton.Displayed);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Long")]
        [Trait("TestEnvironment", "Local")]
        public void CheckTextSectionsAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestCarbonOffsetsPageComponentsArePresent_CheckTextSectionsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string CarbonOffsetUrl = UrlRefLibrary.GetCarbonOffsetsPageLocalHostUrl();

                driver.Navigate().GoToUrl(CarbonOffsetUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-carbonoffsets-page")));
                IWebElement CarbonOffsetsPageTitle = driver.FindElement(By.Id("CarbonOffsetsPageTitle"));
                IWebElement CarbonOffsetsPageSubtitle = driver.FindElement(By.Id("CarbonOffsetsPageSubtitle"));
                IWebElement CarbonOffsetsPageHeading = driver.FindElement(By.Id("CarbonOffsetsPageHeading"));
                IWebElement OffsetMyCarbonMiniIconText = driver.FindElement(By.Id("OffsetMyCarbonMiniIconText"));
                IWebElement OffsetAJourneyMiniIconText = driver.FindElement(By.Id("OffsetAJourneyMiniIconText"));
                IWebElement OffsetByTonneMiniIconText = driver.FindElement(By.Id("OffsetByTonneMiniIconText"));
                IWebElement OffsetBusinessIconText = driver.FindElement(By.Id("OffsetBusinessIconText"));
                IWebElement CarbonOffsetsPageTitlePara1 = driver.FindElement(By.Id("CarbonOffsetsPageTitlePara1"));
                IWebElement PartnerLogoText = driver.FindElement(By.Id("PartnerLogoText"));
                IWebElement PieChartImageText = driver.FindElement(By.Id("PieChartImageText"));
                IWebElement CarbonOffsetsPageTitlePara2 = driver.FindElement(By.Id("CarbonOffsetsPageTitlePara2"));
                IWebElement OffsetMyCarbonTitle = driver.FindElement(By.Id("OffsetMyCarbonTitle"));
                IWebElement OffsetMyCarbonPara = driver.FindElement(By.Id("OffsetMyCarbonPara"));
                IWebElement OffsetMyCarbonParab = driver.FindElement(By.Id("OffsetMyCarbonParab"));
                IWebElement OffsetAJourneyTitle = driver.FindElement(By.Id("OffsetAJourneyTitle"));
                IWebElement OffsetAJourneyPara = driver.FindElement(By.Id("OffsetAJourneyPara"));
                IWebElement OffsetAJourneyParab = driver.FindElement(By.Id("OffsetAJourneyParab"));
                IWebElement OffsetByTonneTitle = driver.FindElement(By.Id("OffsetByTonneTitle"));
                IWebElement OffsetByTonnePara = driver.FindElement(By.Id("OffsetByTonnePara"));
                IWebElement OffsetByTonneParab = driver.FindElement(By.Id("OffsetByTonneParab"));
                IWebElement OffsetMyBusinessCarbonTitle = driver.FindElement(By.Id("OffsetMyBusinessCarbonTitle"));
                IWebElement OffsetMyBusinessPara = driver.FindElement(By.Id("OffsetMyBusinessPara"));
                IWebElement OffsetMyBusinessParab = driver.FindElement(By.Id("OffsetMyBusinessParab"));

                Assert.True(CarbonOffsetsPageTitle.Displayed);
                Assert.True(CarbonOffsetsPageSubtitle.Displayed);
                Assert.True(CarbonOffsetsPageHeading.Displayed);
                Assert.True(OffsetMyCarbonMiniIconText.Displayed);
                Assert.True(OffsetAJourneyMiniIconText.Displayed);
                Assert.True(OffsetByTonneMiniIconText.Displayed);
                Assert.True(OffsetBusinessIconText.Displayed);
                Assert.True(CarbonOffsetsPageTitlePara1.Displayed);
                Assert.True(PartnerLogoText.Displayed);
                Assert.True(PieChartImageText.Displayed);
                Assert.True(CarbonOffsetsPageTitlePara2.Displayed);
                Assert.True(OffsetMyCarbonTitle.Displayed);
                Assert.True(OffsetMyCarbonPara.Displayed);
                Assert.False(OffsetMyCarbonParab.Displayed);
                Assert.True(OffsetAJourneyTitle.Displayed);
                Assert.True(OffsetAJourneyPara.Displayed);
                Assert.False(OffsetAJourneyParab.Displayed);
                Assert.True(OffsetByTonneTitle.Displayed);
                Assert.True(OffsetByTonnePara.Displayed);
                Assert.False(OffsetByTonneParab.Displayed);
                Assert.True(OffsetMyBusinessCarbonTitle.Displayed);
                Assert.True(OffsetMyBusinessPara.Displayed);
                Assert.False(OffsetMyBusinessParab.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);

                Assert.True(CarbonOffsetsPageTitle.Displayed);
                Assert.True(CarbonOffsetsPageSubtitle.Displayed);
                Assert.True(CarbonOffsetsPageHeading.Displayed);
                Assert.True(OffsetMyCarbonMiniIconText.Displayed);
                Assert.True(OffsetAJourneyMiniIconText.Displayed);
                Assert.True(OffsetByTonneMiniIconText.Displayed);
                Assert.True(OffsetBusinessIconText.Displayed);
                Assert.True(CarbonOffsetsPageTitlePara1.Displayed);
                Assert.True(PartnerLogoText.Displayed);
                Assert.True(PieChartImageText.Displayed);
                Assert.True(CarbonOffsetsPageTitlePara2.Displayed);
                Assert.True(OffsetMyCarbonTitle.Displayed);
                Assert.False(OffsetMyCarbonPara.Displayed);
                Assert.True(OffsetMyCarbonParab.Displayed);
                Assert.True(OffsetAJourneyTitle.Displayed);
                Assert.False(OffsetAJourneyPara.Displayed);
                Assert.True(OffsetAJourneyParab.Displayed);
                Assert.True(OffsetByTonneTitle.Displayed);
                Assert.False(OffsetByTonnePara.Displayed);
                Assert.True(OffsetByTonneParab.Displayed);
                Assert.True(OffsetMyBusinessCarbonTitle.Displayed);
                Assert.False(OffsetMyBusinessPara.Displayed);
                Assert.True(OffsetMyBusinessParab.Displayed);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckFooterIsDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestCarbonOffsetsPageComponentsArePresent_CheckFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string CarbonOffsetUrl = UrlRefLibrary.GetCarbonOffsetsPageLocalHostUrl();

                driver.Navigate().GoToUrl(CarbonOffsetUrl);
                driver.Manage().Window.Maximize();
                IWebElement FooterElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("nav-footer")));
                IWebElement CopyrightListItemElement = driver.FindElement(By.Id("_LayoutCopyrightFooterLabel"));
                IWebElement RegisterFooterLink = driver.FindElement(By.Id("_LayoutRegisterFooterLink"));
                IWebElement AboutFooterLink = driver.FindElement(By.Id("_LayoutAboutFooterLink"));
                IWebElement ArticlesFooterLink = driver.FindElement(By.Id("_LayoutArticlesFooterLink"));
                IWebElement PrivacyFooterLink = driver.FindElement(By.Id("_LayoutPrivacyFooterLink"));
                IWebElement CookiesFooterLink = driver.FindElement(By.Id("_LayoutCookiesFooterLink"));

                Assert.True(FooterElement.Displayed);
                Assert.True(CopyrightListItemElement.Displayed);
                Assert.True(RegisterFooterLink.Displayed);
                Assert.True(AboutFooterLink.Displayed);
                Assert.True(ArticlesFooterLink.Displayed);
                Assert.True(PrivacyFooterLink.Displayed);
                Assert.True(CookiesFooterLink.Displayed);
            }, filename, driver);
        }
    }
}
