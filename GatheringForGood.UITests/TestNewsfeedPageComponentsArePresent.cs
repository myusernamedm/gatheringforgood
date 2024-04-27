using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using UITestStringsLibrary;
using OpenQA.Selenium.Support.UI;

namespace GatheringForGood.UITests
{
    public class TestNewsfeedPageComponentsArePresent
    {
        //Re-enable below when using Newsfeed page again

        /*
        readonly CrossPageSharedUITestStrings UITestStrings = new UITestStringsLibrary.CrossPageSharedUITestStrings();

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckImagesAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestNewsfeedPageComponentsArePresent_CheckImagesAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

            driver.Navigate().GoToUrl(HomeUrl);
            driver.Manage().Window.Maximize();

            string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
            driver.Navigate().GoToUrl(LoginUrl);
            IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
            IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
            IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));
            string UserEmail = UITestStrings.Test2UserEmail();
            string UserPassword = UITestStrings.Test2UserPassword();

            LoginEmailInputField.Clear();
            LoginEmailInputField.SendKeys(Keys.Tab);
            LoginPasswordInputField.Clear();
            LoginPasswordInputField.SendKeys(Keys.Tab);
            LoginEmailInputField.SendKeys(UserEmail);
            LoginPasswordInputField.SendKeys(UserPassword);

            LoginButton.Click();
            IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
            Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

            string NewsfeedUrl = UrlRefLibrary.GetNewsfeedPageLocalHostUrl();
            driver.Navigate().GoToUrl(NewsfeedUrl);
            IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("NewsfeedPageBanner")));
            IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));
            IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_NewsfeedPageLogoImg"));

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
            var filename = "TestNewsfeedPageComponentsArePresent_CheckNavBarIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string NewsfeedUrl = UrlRefLibrary.GetNewsfeedPageLocalHostUrl();

            driver.Navigate().GoToUrl(NewsfeedUrl);
            driver.Manage().Window.Maximize();
            IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-newsfeed-page")));
            IWebElement NavBarHomeLinkElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_NewsfeedPageHomeNavLink")));
            IWebElement NavBarNewsfeedLinkElement = driver.FindElement(By.Id("_NewsfeedPageNewsfeedNavLink"));
            IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_NewsfeedPageAboutNavLink"));
            IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_NewsfeedPageHelpNavLink"));
            IWebElement NavBarRegisterLinkElement = driver.FindElement(By.Id("_LoginPartialRegister"));
            IWebElement NavBarLoginLinkElement = driver.FindElement(By.Id("_LoginPartialLogin"));

            Assert.True(NavBarElement.Displayed);
            Assert.True(NavBarHomeLinkElement.Displayed);
            Assert.True(NavBarNewsfeedLinkElement.Displayed);
            Assert.True(NavBarAboutLinkElement.Displayed);
            Assert.True(NavBarHelpLinkElement.Displayed);
            Assert.True(NavBarRegisterLinkElement.Displayed);
            Assert.True(NavBarLoginLinkElement.Displayed);

            Assert.Equal("HOME", NavBarHomeLinkElement.Text);
            Assert.Equal("NEWSFEED", NavBarNewsfeedLinkElement.Text);
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
            var filename = "TestNewsfeedPageComponentsArePresent_CheckButtonsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();
            string NewsfeedUrl = UrlRefLibrary.GetNewsfeedPageLocalHostUrl();
            string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
            string UserEmail = UITestStrings.Test2UserEmail();
            string UserPassword = UITestStrings.Test2UserPassword();

            driver.Navigate().GoToUrl(HomeUrl);
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl(NewsfeedUrl);
            IWebElement MakeADifferenceButtonElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("NewsfeedPageMakeDiffBtn")));
            Assert.True(MakeADifferenceButtonElement.Displayed);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckTextSectionsAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestNewsfeedPageComponentsArePresent_CheckTextSectionsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

            driver.Navigate().GoToUrl(HomeUrl);
            driver.Manage().Window.Maximize();

            string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
            driver.Navigate().GoToUrl(LoginUrl);
            IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
            IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
            IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));
            string UserEmail = UITestStrings.Test2UserEmail();
            string UserPassword = UITestStrings.Test2UserPassword();

            LoginEmailInputField.Clear();
            LoginEmailInputField.SendKeys(Keys.Tab);
            LoginPasswordInputField.Clear();
            LoginPasswordInputField.SendKeys(Keys.Tab);
            LoginEmailInputField.SendKeys(UserEmail);
            LoginPasswordInputField.SendKeys(UserPassword);

            LoginButton.Click();
            IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
            Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

            string NewsfeedUrl = UrlRefLibrary.GetNewsfeedPageLocalHostUrl();
            driver.Navigate().GoToUrl(NewsfeedUrl);
            IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-newsfeed-page")));
            IWebElement TitleElement = driver.FindElement(By.Id("NewsfeedPageTitle"));
            IWebElement SubTitleElement = driver.FindElement(By.Id("NewsfeedPageSubtitle"));

            Assert.True(TitleElement.Displayed);
            Assert.True(SubTitleElement.Displayed);
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
            var filename = "TestNewsfeedPageComponentsArePresent_CheckFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string NewsfeedUrl = UrlRefLibrary.GetNewsfeedPageLocalHostUrl();

            driver.Navigate().GoToUrl(NewsfeedUrl);
            driver.Manage().Window.Maximize();
            IWebElement FooterElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("nav-footer")));
            IWebElement CopyrightListItemElement = driver.FindElement(By.Id("_LayoutCopyrightFooterLabel"));
            IWebElement RegisterFooterLink = driver.FindElement(By.Id("_LayoutRegisterFooterLink"));
            IWebElement AboutFooterLink = driver.FindElement(By.Id("_LayoutAboutFooterLink"));
            IWebElement BlogFooterLink = driver.FindElement(By.Id("_LayoutBlogFooterLink"));
            IWebElement PrivacyFooterLink = driver.FindElement(By.Id("_LayoutPrivacyFooterLink"));
            IWebElement CookiesFooterLink = driver.FindElement(By.Id("_LayoutCookiesFooterLink"));

            Assert.True(FooterElement.Displayed);
            Assert.True(CopyrightListItemElement.Displayed);
            Assert.True(RegisterFooterLink.Displayed);
            Assert.True(AboutFooterLink.Displayed);
            Assert.True(BlogFooterLink.Displayed);
            Assert.True(PrivacyFooterLink.Displayed);
            Assert.True(CookiesFooterLink.Displayed);
            }, filename, driver);
        }
        */
    }
}
