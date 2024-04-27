using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using OpenQA.Selenium.Support.UI;

namespace GatheringForGood.UITests
{
    public class TestLockoutPageComponentsArePresent
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
            var filename = "TestLockoutPageComponentsArePresent_CheckImagesAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string LockoutUrl = UrlRefLibrary.GetLockoutPageLocalHostUrl();

            driver.Navigate().GoToUrl(LockoutUrl);
            driver.Manage().Window.Maximize();
            IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LockoutPageBanner")));
            IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_LockoutPageLogoImg"));
            IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));

            Assert.True(BannerImageElement.Displayed);
            Assert.True(_LayoutPageLogoElement.Displayed);
            Assert.True(BodyBackground.Displayed);
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
            var filename = "TestLockoutPageComponentsArePresent_CheckNavBarIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string LockoutUrl = UrlRefLibrary.GetLockoutPageLocalHostUrl();

            driver.Navigate().GoToUrl(LockoutUrl);
            driver.Manage().Window.Maximize();
            IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-lockout-page")));
            IWebElement NavBarHomeLinkElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LockoutPageHomeNavLink")));
            IWebElement NavBarArticlesLinkElement = driver.FindElement(By.Id("_LockoutPageArticlesNavLink"));
            IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_LockoutPageAboutNavLink"));
            IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_LockoutPageHelpNavLink"));
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
        public void CheckTextSectionsAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestLockoutPageComponentsArePresent_CheckTextSectionsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string LockoutUrl = UrlRefLibrary.GetLockoutPageLocalHostUrl();

            driver.Navigate().GoToUrl(LockoutUrl);
            driver.Manage().Window.Maximize();
            IWebElement TitleElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LockoutPageTitle")));
            IWebElement SubTitleElement = driver.FindElement(By.Id("LockoutPageSubtitle"));
            IWebElement LockoutHeadingElement = driver.FindElement(By.Id("LockoutHeading"));

            Assert.True(TitleElement.Displayed);
            Assert.True(SubTitleElement.Displayed);
            Assert.True(LockoutHeadingElement.Displayed);
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
            var filename = "TestLockoutPageComponentsArePresent_CheckFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string LockoutUrl = UrlRefLibrary.GetLockoutPageLocalHostUrl();

            driver.Navigate().GoToUrl(LockoutUrl);
            driver.Manage().Window.Maximize();
            IWebElement FooterElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("nav-footer")));
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
