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
    public class TestAboutPageComponentsArePresent
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
            var filename = "TestAboutPageComponentsArePresent_CheckImagesAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string AboutUrl = UrlRefLibrary.GetAboutPageLocalHostUrl();

                driver.Navigate().GoToUrl(AboutUrl);
                driver.Manage().Window.Maximize();
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("AboutPageBanner")));
                IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_AboutPageLogoImg"));
                IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));
                IWebElement WhereDoesNameComeFromImage = driver.FindElement(By.Id("WhereDoesNameComeFromImage"));
                IWebElement OurMissionImage = driver.FindElement(By.Id("OurMissionImage"));
                IWebElement OurPromiseImage = driver.FindElement(By.Id("OurPromiseImage"));
                IWebElement OurEssenceImage = driver.FindElement(By.Id("OurEssenceImage"));
                IWebElement OurVisionImage = driver.FindElement(By.Id("OurVisionImage"));

                Assert.True(BannerImageElement.Displayed);
                Assert.True(_LayoutPageLogoElement.Displayed);
                Assert.True(BodyBackground.Displayed);
                Assert.True(WhereDoesNameComeFromImage.Displayed);
                Assert.True(OurMissionImage.Displayed);
                Assert.True(OurPromiseImage.Displayed);
                Assert.True(OurEssenceImage.Displayed);
                Assert.True(OurVisionImage.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);

                Assert.True(BodyBackground.Displayed);
                Assert.True(WhereDoesNameComeFromImage.Displayed);
                Assert.True(OurMissionImage.Displayed);
                Assert.True(OurPromiseImage.Displayed);
                Assert.True(OurEssenceImage.Displayed);
                Assert.True(OurVisionImage.Displayed);
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
            var filename = "TestAboutPageComponentsArePresent_CheckNavBarIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string AboutUrl = UrlRefLibrary.GetAboutPageLocalHostUrl();

                driver.Navigate().GoToUrl(AboutUrl);
                driver.Manage().Window.Maximize();
                Thread.Sleep(1000);
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-about-page")));
                IWebElement NavBarHomeLinkElement = driver.FindElement(By.Id("_AboutPageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement = driver.FindElement(By.Id("_AboutPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_AboutPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_AboutPageHelpNavLink"));
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
            var filename = "TestAboutPageComponentsArePresent_CheckButtonsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string AboutUrl = UrlRefLibrary.GetAboutPageLocalHostUrl();

                driver.Navigate().GoToUrl(AboutUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-about-page")));
                IWebElement MakeADifferenceButtonElement = driver.FindElement(By.Id("AboutPageMakeDiffBtn"));

                Assert.True(MakeADifferenceButtonElement.Displayed);
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
            var filename = "TestAboutPageComponentsArePresent_CheckTextSectionsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string AboutUrl = UrlRefLibrary.GetAboutPageLocalHostUrl();

                driver.Navigate().GoToUrl(AboutUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-about-page")));
                IWebElement TitleElement = driver.FindElement(By.Id("AboutPageTitle"));
                IWebElement SubTitleElement = driver.FindElement(By.Id("AboutPageSubtitle"));
                IWebElement WhereDoesNameComeFromTitleElement = driver.FindElement(By.Id("WhereDoesNameComeFromTitle"));
                IWebElement WhereDoesNameComeFromParaElement = driver.FindElement(By.Id("WhereDoesNameComeFromPara"));
                IWebElement OurMissionTitleElement = driver.FindElement(By.Id("OurMissionTitle"));
                IWebElement OurMissionParaElement = driver.FindElement(By.Id("OurMissionPara"));
                IWebElement OurMissionParabElement = driver.FindElement(By.Id("OurMissionParab"));
                IWebElement OurPromiseTitleElement = driver.FindElement(By.Id("OurPromiseTitle"));
                IWebElement OurPromiseParaElement = driver.FindElement(By.Id("OurPromisePara"));
                IWebElement OurEssenceTitleElement = driver.FindElement(By.Id("OurEssenceTitle"));
                IWebElement OurEssenceParaElement = driver.FindElement(By.Id("OurEssencePara"));
                IWebElement OurEssenceParabElement = driver.FindElement(By.Id("OurEssenceParab"));
                IWebElement OurVisionParaElement = driver.FindElement(By.Id("OurVisionPara"));

                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(WhereDoesNameComeFromTitleElement.Displayed);
                Assert.True(WhereDoesNameComeFromParaElement.Displayed);
                Assert.True(OurMissionTitleElement.Displayed);
                Assert.False(OurMissionParaElement.Displayed);
                Assert.True(OurMissionParabElement.Displayed);
                Assert.True(OurPromiseTitleElement.Displayed);
                Assert.True(OurPromiseParaElement.Displayed);
                Assert.True(OurEssenceTitleElement.Displayed);
                Assert.False(OurEssenceParaElement.Displayed);
                Assert.True(OurEssenceParabElement.Displayed);
                Assert.True(OurVisionParaElement.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);

                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(WhereDoesNameComeFromTitleElement.Displayed);
                Assert.True(WhereDoesNameComeFromParaElement.Displayed);
                Assert.True(OurMissionTitleElement.Displayed);
                Assert.True(OurMissionParaElement.Displayed);
                Assert.False(OurMissionParabElement.Displayed);
                Assert.True(OurPromiseTitleElement.Displayed);
                Assert.True(OurPromiseParaElement.Displayed);
                Assert.True(OurEssenceTitleElement.Displayed);
                Assert.True(OurEssenceParaElement.Displayed);
                Assert.False(OurEssenceParabElement.Displayed);
                Assert.True(OurVisionParaElement.Displayed);
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
            var filename = "TestAboutPageComponentsArePresent_CheckFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string AboutUrl = UrlRefLibrary.GetAboutPageLocalHostUrl();

                driver.Navigate().GoToUrl(AboutUrl);
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
