using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace GatheringForGood.UITests
{
    public class TestResetPasswordPageComponentsArePresent
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
            var filename = "TestResetPasswordPageComponentsArePresent_CheckImagesAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ResetPasswordUrl = UrlRefLibrary.GetResetPasswordPageLocalHostUrl();

                driver.Navigate().GoToUrl(ResetPasswordUrl);
                driver.Manage().Window.Maximize();
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ResetPasswordPageBanner")));
                IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_ResetPasswordPageLogoImg"));
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
            var filename = "TestResetPasswordPageComponentsArePresent_CheckNavBarIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ResetPasswordUrl = UrlRefLibrary.GetResetPasswordPageLocalHostUrl();

                driver.Navigate().GoToUrl(ResetPasswordUrl);
                driver.Manage().Window.Maximize();
                Thread.Sleep(1000);
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-resetpassword-page")));
                IWebElement NavBarHomeLinkElement = driver.FindElement(By.Id("_ResetPasswordPageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement = driver.FindElement(By.Id("_ResetPasswordPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_ResetPasswordPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_ResetPasswordPageHelpNavLink"));
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
            var filename = "TestResetPasswordPageComponentsArePresent_CheckButtonsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ResetPasswordUrl = UrlRefLibrary.GetResetPasswordPageLocalHostUrl();

                driver.Navigate().GoToUrl(ResetPasswordUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-resetpassword-page")));
                IWebElement ResetPasswordButton = driver.FindElement(By.Id("ResetPasswordButton"));

                Assert.True(ResetPasswordButton.Displayed);
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
            var filename = "TestResetPasswordPageComponentsArePresent_CheckTextSectionsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ResetPasswordUrl = UrlRefLibrary.GetResetPasswordPageLocalHostUrl();

                driver.Navigate().GoToUrl(ResetPasswordUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-resetpassword-page")));
                IWebElement TitleElement = driver.FindElement(By.Id("ResetPasswordPageTitle"));
                IWebElement SubTitleElement = driver.FindElement(By.Id("ResetPasswordPageSubtitle"));
                IWebElement ResetPswdHeading = driver.FindElement(By.Id("ResetPswdHeading"));
                IWebElement _ResetPswdPageEmailHeading = driver.FindElement(By.Id("_ResetPswdPageEmailHeading"));
                IWebElement _ResetPswdPagePasswordHeading = driver.FindElement(By.Id("_ResetPswdPagePasswordHeading"));
                IWebElement _ResetPswdPageConfirmPasswordHeading = driver.FindElement(By.Id("_ResetPswdPageConfirmPasswordHeading"));
                IWebElement _ResetPswdPageEmailInputField = driver.FindElement(By.Id("_ResetPswdPageEmailInputField"));
                IWebElement _ResetPswdPagePasswordInputField = driver.FindElement(By.Id("_ResetPswdPagePasswordInputField"));
                IWebElement _ResetPswdPageConfirmPasswordInputField = driver.FindElement(By.Id("_ResetPswdPageConfirmPasswordInputField"));

                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(ResetPswdHeading.Displayed);
                Assert.True(_ResetPswdPageEmailHeading.Displayed);
                Assert.True(_ResetPswdPagePasswordHeading.Displayed);
                Assert.True(_ResetPswdPageConfirmPasswordHeading.Displayed);
                Assert.True(_ResetPswdPageEmailInputField.Displayed);
                Assert.True(_ResetPswdPagePasswordInputField.Displayed);
                Assert.True(_ResetPswdPageConfirmPasswordInputField.Displayed);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckValidationsAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestResetPasswordPageComponentsArePresent_CheckValidationsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ResetPasswordUrl = UrlRefLibrary.GetResetPasswordPageLocalHostUrl();

                driver.Navigate().GoToUrl(ResetPasswordUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-resetpassword-page")));
                IWebElement ResetPasswordButton = driver.FindElement(By.Id("ResetPasswordButton"));
                IWebElement _ResetPswdPageEmailValidation = driver.FindElement(By.Id("_ResetPswdPageEmailValidation"));
                IWebElement _ResetPswdPagePasswordValidation = driver.FindElement(By.Id("_ResetPswdPagePasswordValidation"));
                IWebElement _ResetPswdPageConfirmPasswordValidation = driver.FindElement(By.Id("_ResetPswdPageConfirmPasswordValidation"));
                IWebElement _ResetPswdPageEmailInputField = driver.FindElement(By.Id("_ResetPswdPageEmailInputField"));
                IWebElement _ResetPswdPagePasswordInputField = driver.FindElement(By.Id("_ResetPswdPagePasswordInputField"));
                IWebElement _ResetPswdPageConfirmPasswordInputField = driver.FindElement(By.Id("_ResetPswdPageConfirmPasswordInputField"));

                ResetPasswordButton.Click();
                Assert.True(_ResetPswdPageEmailValidation.Displayed);
                Assert.True(_ResetPswdPagePasswordValidation.Displayed);
                _ResetPswdPageEmailInputField.Clear();
                _ResetPswdPageEmailInputField.SendKeys("test@email.com");
                _ResetPswdPageEmailInputField.SendKeys(Keys.Tab);
                Assert.False(_ResetPswdPageEmailValidation.Displayed);
                _ResetPswdPagePasswordInputField.Clear();
                _ResetPswdPagePasswordInputField.SendKeys("6pHAELTn4sB*SN%");
                _ResetPswdPagePasswordInputField.SendKeys(Keys.Tab);
                Assert.False(_ResetPswdPagePasswordValidation.Displayed);
                Assert.True(_ResetPswdPageConfirmPasswordValidation.Displayed);
                _ResetPswdPageConfirmPasswordInputField.Clear();
                _ResetPswdPageConfirmPasswordInputField.SendKeys("6pHAELTn4sB*SN%");
                _ResetPswdPageConfirmPasswordInputField.SendKeys(Keys.Tab);
                Assert.False(_ResetPswdPageConfirmPasswordValidation.Displayed);
                _ResetPswdPageEmailInputField.Clear();
                _ResetPswdPagePasswordInputField.Clear();
                _ResetPswdPageConfirmPasswordInputField.Clear();

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
            var filename = "TestResetPasswordPageComponentsArePresent_CheckFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ResetPasswordUrl = UrlRefLibrary.GetResetPasswordPageLocalHostUrl();

                driver.Navigate().GoToUrl(ResetPasswordUrl);
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
