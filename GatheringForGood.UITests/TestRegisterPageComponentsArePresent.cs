using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using OpenQA.Selenium.Support.UI;

namespace GatheringForGood.UITests
{
    public class TestRegisterPageComponentsArePresent
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
            var filename = "TestRegisterPageComponentsArePresent_CheckImagesAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string RegisterUrl = UrlRefLibrary.GetRegisterPageLocalHostUrl();

                driver.Navigate().GoToUrl(RegisterUrl);
                driver.Manage().Window.Maximize();
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("RegisterPageBanner")));
                IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_RegisterPageLogoImg"));
                IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));
                IWebElement RegistrationPasswordInfoIcon = driver.FindElement(By.Id("RegistrationPasswordInfoIcon"));

                Assert.True(BannerImageElement.Displayed);
                Assert.True(_LayoutPageLogoElement.Displayed);
                Assert.True(BodyBackground.Displayed);
                Assert.True(RegistrationPasswordInfoIcon.Displayed);
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
            var filename = "TestRegisterPageComponentsArePresent_CheckNavBarIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string RegisterUrl = UrlRefLibrary.GetRegisterPageLocalHostUrl();

                driver.Navigate().GoToUrl(RegisterUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-register-page")));
                IWebElement NavBarHomeLinkElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_RegisterPageHomeNavLink")));
                IWebElement NavBarArticlesLinkElement = driver.FindElement(By.Id("_RegisterPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_RegisterPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_RegisterPageHelpNavLink"));
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
            var filename = "TestRegisterPageComponentsArePresent_CheckButtonsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string RegisterUrl = UrlRefLibrary.GetRegisterPageLocalHostUrl();

                driver.Navigate().GoToUrl(RegisterUrl);
                driver.Manage().Window.Maximize();
                IWebElement RegisterButton = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("RegisterButton")));
                IWebElement Input_TOSAgree = driver.FindElement(By.Id("Input_TOSAgree"));
                IWebElement Input_MarketingComms = driver.FindElement(By.Id("Input_MarketingComms"));

                Assert.True(RegisterButton.Displayed);
                Assert.True(Input_TOSAgree.Displayed);
                Assert.True(Input_MarketingComms.Displayed);

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
            var filename = "TestRegisterPageComponentsArePresent_CheckTextSectionsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string RegisterUrl = UrlRefLibrary.GetRegisterPageLocalHostUrl();

                driver.Navigate().GoToUrl(RegisterUrl);
                driver.Manage().Window.Maximize();
                IWebElement TitleElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("RegisterPageTitle")));
                IWebElement SubTitleElement = driver.FindElement(By.Id("RegisterPageSubtitle"));
                IWebElement CreateANewAccountHeadingElement = driver.FindElement(By.Id("CreateNewAccountHeading"));
                IWebElement EmailHeadingElement = driver.FindElement(By.Id("RegistrationEmailHeading"));
                IWebElement PasswordHeadingElement = driver.FindElement(By.Id("RegistrationPasswordHeading"));
                IWebElement ConfirmPasswordHeadingElement = driver.FindElement(By.Id("RegistrationConfirmPasswordHeading"));
                IWebElement RegisterTandCHeading = driver.FindElement(By.Id("RegisterTandCHeading"));
                IWebElement RegisterMarketingHeading = driver.FindElement(By.Id("RegisterMarketingHeading"));

                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(CreateANewAccountHeadingElement.Displayed);
                Assert.True(EmailHeadingElement.Displayed);
                Assert.True(PasswordHeadingElement.Displayed);
                Assert.True(ConfirmPasswordHeadingElement.Displayed);
                Assert.True(RegisterTandCHeading.Displayed);
                Assert.True(RegisterMarketingHeading.Displayed);

            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckFieldValidation()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestRegisterPageComponentsArePresent_CheckFieldValidation";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string RegisterUrl = UrlRefLibrary.GetRegisterPageLocalHostUrl();
                string EmailFieldValidation = ("The Email field is required.").ToUpper();
                string EmailFieldValidation2 = ("The Email field is not a valid e-mail address.").ToUpper();
                string PasswordFieldValidation = ("The Password field is required.").ToUpper();

                driver.Navigate().GoToUrl(RegisterUrl);
                driver.Manage().Window.Maximize();
                IWebElement EmailValidationLabel = driver.FindElement(By.Id("RegistrationEmailValidationLabel"));
                IWebElement EmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("RegistrationEmailInputField")));
                IWebElement PasswordValidationLabel = driver.FindElement(By.Id("RegistrationPasswordValidationLabel"));
                IWebElement PasswordInputField = driver.FindElement(By.Id("RegistrationPasswordInputField"));
                IWebElement ConfirmPasswordValidationLabel = driver.FindElement(By.Id("RegistrationConfirmPasswordValidationLabel"));
                IWebElement ConfirmPasswordInputField = driver.FindElement(By.Id("RegistrationConfirmPasswordInputField"));
                IWebElement RegisterTandCValidation = driver.FindElement(By.Id("RegisterTandCValidation"));
                IWebElement RegisterButton = driver.FindElement(By.Id("RegisterButton"));

                EmailInputField.Clear();
                PasswordInputField.Clear();
                ConfirmPasswordInputField.Clear();

                RegisterButton.Click();

                Assert.True(EmailValidationLabel.Displayed);
                Assert.True(PasswordValidationLabel.Displayed);
                Assert.Equal(EmailValidationLabel.Text, EmailFieldValidation);
                Assert.Equal(PasswordValidationLabel.Text, PasswordFieldValidation);

                EmailInputField.Clear();
                EmailInputField.SendKeys("abcd");
                Assert.Equal(EmailValidationLabel.Text, EmailFieldValidation2);

                ConfirmPasswordInputField.Clear();
                ConfirmPasswordInputField.SendKeys("abcd");
                Assert.False(ConfirmPasswordValidationLabel.Displayed);

                EmailInputField.Clear();
                EmailInputField.SendKeys("diarmaidmurphy1@gmail.com");
                Assert.False(EmailValidationLabel.Displayed);

                PasswordInputField.Clear();
                PasswordInputField.SendKeys("abcd1234");
                PasswordInputField.SendKeys(Keys.Tab);
                Assert.False(PasswordValidationLabel.Displayed);
                Assert.True(ConfirmPasswordValidationLabel.Displayed);

                ConfirmPasswordInputField.Clear();
                ConfirmPasswordInputField.SendKeys("abcd1234");
                ConfirmPasswordInputField.SendKeys(Keys.Tab);
                Assert.False(ConfirmPasswordValidationLabel.Displayed);

                Assert.False(RegisterTandCValidation.Displayed);
                RegisterButton.Click();
                IWebElement RegisterTandCValidation1 = driver.FindElement(By.Id("RegisterTandCValidation"));
                Assert.True(RegisterTandCValidation1.Displayed);

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
            var filename = "TestRegisterPageComponentsArePresent_CheckFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string RegisterUrl = UrlRefLibrary.GetRegisterPageLocalHostUrl();

                driver.Navigate().GoToUrl(RegisterUrl);
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
