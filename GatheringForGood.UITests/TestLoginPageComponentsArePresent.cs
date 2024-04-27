using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using UITestStringsLibrary;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace GatheringForGood.UITests
{
    public class TestLoginPageComponentsArePresent
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
            var filename = "TestLoginPageComponentsArePresent_CheckImagesAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();

                driver.Navigate().GoToUrl(LoginUrl);
                driver.Manage().Window.Maximize();
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginPageBanner")));
                IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_LoginPageLogoImg"));
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
            var filename = "TestLoginPageComponentsArePresent_CheckNavBarIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();

                driver.Navigate().GoToUrl(LoginUrl);
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-login-page")));
                IWebElement NavBarHomeLinkElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPageHomeNavLink")));
                IWebElement NavBarArticlesLinkElement = driver.FindElement(By.Id("_LoginPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_LoginPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_LoginPageHelpNavLink"));
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
        public void CheckButtonsAreDisplayedAndResendIsClickable()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestLoginPageComponentsArePresent_CheckButtonsAreDisplayedAndResendIsClickable";

            TakeTestFailScreenshot.UITest(() =>
             {
                 var CrossPageSharedUITestStrings = new CrossPageSharedUITestStrings();
                 var UrlRefLibrary = new UrlStrings();
                 string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                 string Test2UserEmail = CrossPageSharedUITestStrings.Test2UserEmail();
                 string Test2UserPassword = CrossPageSharedUITestStrings.Test2UserPassword();

                 driver.Navigate().GoToUrl(LoginUrl);
                 driver.Manage().Window.Maximize();

                 IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
                 IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));

                 LoginEmailInputField.Clear();
                 LoginEmailInputField.SendKeys(Keys.Tab);
                 LoginPasswordInputField.Clear();
                 LoginPasswordInputField.SendKeys(Keys.Tab);
                 LoginEmailInputField.SendKeys(Test2UserEmail);
                 LoginEmailInputField.SendKeys(Keys.Tab);
                 LoginPasswordInputField.SendKeys(Test2UserPassword);
                 LoginPasswordInputField.SendKeys(Keys.Tab);

                 IWebElement LoginButton = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginButton")));
                 IWebElement ResendEmailButton = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ResendEmailButton")));

                 Assert.True(LoginButton.Displayed);
                 Assert.True(ResendEmailButton.Displayed);

                 ResendEmailButton.Click();

                 IWebElement LoginStatusMessage = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginStatusMessage")));
                 Assert.True(LoginStatusMessage.Displayed);

             }, filename, driver);
        }





        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckLinksAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestLoginPageComponentsArePresent_CheckLinksAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();

                driver.Navigate().GoToUrl(LoginUrl);
                driver.Manage().Window.Maximize();
                IWebElement LoginForgotPasswordLink = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginForgotPasswordLink")));
                IWebElement RegisterAsNewUserLink = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("RegisterAsNewUserLink")));

                Assert.True(LoginForgotPasswordLink.Displayed);
                Assert.True(RegisterAsNewUserLink.Displayed);
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
            var filename = "TestLoginPageComponentsArePresent_CheckTextSectionsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();

                driver.Navigate().GoToUrl(LoginUrl);
                driver.Manage().Window.Maximize();
                IWebElement LoginPageTitle = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginPageTitle")));
                IWebElement LoginPageSubtitle = driver.FindElement(By.Id("LoginPageSubtitle"));
                IWebElement LoginHeading = driver.FindElement(By.Id("LoginHeading"));
                IWebElement LoginEmailHeading = driver.FindElement(By.Id("LoginEmailHeading"));
                IWebElement LoginPasswordHeading = driver.FindElement(By.Id("LoginPasswordHeading"));
                IWebElement LoginRememberMeCheckbox = driver.FindElement(By.Id("LoginRememberMe"));
                //IWebElement LoginUseAnotherServiceHeading = driver.FindElement(By.Id("LoginUseAnotherService"));

                Assert.True(LoginPageTitle.Displayed);
                Assert.True(LoginPageSubtitle.Displayed);
                Assert.True(LoginHeading.Displayed);
                Assert.True(LoginEmailHeading.Displayed);
                Assert.True(LoginPasswordHeading.Displayed);
                Assert.True(LoginRememberMeCheckbox.Displayed);
                //Assert.True(LoginUseAnotherServiceHeading.Displayed);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckFieldValidation()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestLoginPageComponentsArePresent_CheckFieldValidation";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                string EmailFieldValidation = ("The Email field is required.").ToUpper();
                string EmailFieldValidation2 = ("The Email field is not a valid e-mail address.").ToUpper();
                string PasswordFieldValidation = ("The Password field is required.").ToUpper();
                var CrossPageSharedUITestStrings = new CrossPageSharedUITestStrings();
                string Test2UserEmail = CrossPageSharedUITestStrings.Test2UserEmail();
                string Test2UserPassword = CrossPageSharedUITestStrings.Test2UserPassword();
                using IWebDriver driver = new ChromeDriver();

                driver.Navigate().GoToUrl(LoginUrl);
                driver.Manage().Window.Maximize();
                IWebElement LoginEmailValidationLabel = driver.FindElement(By.Id("LoginEmailValidationLabel"));
                IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
                IWebElement LoginPasswordValidationLabel = driver.FindElement(By.Id("LoginPasswordValidationLabel"));
                IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
                IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Keys.Tab);
                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Keys.Tab);

                LoginButton.Click();

                Assert.True(LoginEmailValidationLabel.Displayed);
                Assert.True(LoginPasswordValidationLabel.Displayed);
                Assert.Equal(LoginEmailValidationLabel.Text, EmailFieldValidation);
                Assert.Equal(LoginPasswordValidationLabel.Text, PasswordFieldValidation);

                LoginEmailInputField.SendKeys("abcd");
                Assert.Equal(LoginEmailValidationLabel.Text, EmailFieldValidation2);

                LoginPasswordInputField.SendKeys("abcd");
                LoginPasswordInputField.SendKeys(Keys.Tab);
                Assert.False(LoginPasswordValidationLabel.Displayed);

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Test2UserEmail);
                LoginEmailInputField.SendKeys(Keys.Tab);
                Assert.False(LoginEmailValidationLabel.Displayed);

                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Test2UserPassword);
                LoginPasswordInputField.SendKeys(Keys.Tab);
                Assert.False(LoginPasswordValidationLabel.Displayed);
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
            var filename = "TestLoginPageComponentsArePresent_CheckFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();

                driver.Navigate().GoToUrl(LoginUrl);
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
