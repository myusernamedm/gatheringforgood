using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using UITestStringsLibrary;
using OpenQA.Selenium.Support.UI;
using System.Drawing;
using LocSourceNameReferenceLibrary;
using System.Threading;

namespace GatheringForGood.UITests
{
    public class TestChangePasswordPageComponentsArePresent
    {
        readonly CrossPageSharedUITestStrings UITestStrings = new UITestStringsLibrary.CrossPageSharedUITestStrings();

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Long")]
        [Trait("TestEnvironment", "Local")]
        public void CheckImagesAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestChangePasswordPageComponentsArePresent_CheckImagesAreDisplayed";

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

                string AccountManageUrl = UrlRefLibrary.GetAccountManagePageLocalHostUrl();
                driver.Navigate().GoToUrl(AccountManageUrl);
                IWebElement _ManageNavChangePassword = driver.FindElement(By.Id("_ManageNavChangePassword"));
                _ManageNavChangePassword.Click();

                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_ChangePasswordPageBanner")));
                IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));
                IWebElement _ChangePasswordPageLogoImg = driver.FindElement(By.Id("_ChangePasswordPageLogoImg"));

                Assert.True(BannerImageElement.Displayed);
                Assert.True(_ChangePasswordPageLogoImg.Displayed);
                Assert.True(BodyBackground.Displayed);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckNavBarIsDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestChangePasswordPageComponentsArePresent_CheckNavBarIsDisplayed";

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

                string AccountManageUrl = UrlRefLibrary.GetAccountManagePageLocalHostUrl();
                driver.Navigate().GoToUrl(AccountManageUrl);
                IWebElement _ManageNavChangePassword = driver.FindElement(By.Id("_ManageNavChangePassword"));
                _ManageNavChangePassword.Click();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-changepassword-page")));
                IWebElement NavBarHomeLinkElement = driver.FindElement(By.Id("_ChangePasswordPageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement = driver.FindElement(By.Id("_ChangePasswordPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_ChangePasswordPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_ChangePasswordPageHelpNavLink"));
                IWebElement NavBarLoginPartialLoggedInUserEmailLinkElement = driver.FindElement(By.Id("_LoginPartialLoggedInUserEmail"));
                IWebElement NavBarLoginPartialLogoutButtonLinkElement = driver.FindElement(By.Id("_LoginPartialLogoutButton"));

                Assert.True(NavBarElement.Displayed);
                Assert.True(NavBarHomeLinkElement.Displayed);
                Assert.True(NavBarArticlesLinkElement.Displayed);
                Assert.True(NavBarAboutLinkElement.Displayed);
                Assert.True(NavBarHelpLinkElement.Displayed);
                Assert.True(NavBarLoginPartialLoggedInUserEmailLinkElement.Displayed);
                Assert.True(NavBarLoginPartialLogoutButtonLinkElement.Displayed);

                Assert.Equal("HOME", NavBarHomeLinkElement.Text);
                Assert.Equal("ARTICLES", NavBarArticlesLinkElement.Text);
                Assert.Equal("ABOUT", NavBarAboutLinkElement.Text);
                Assert.Equal("HELP CENTER", NavBarHelpLinkElement.Text);
                Assert.Equal("LOGOUT", NavBarLoginPartialLogoutButtonLinkElement.Text);
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
            using IWebDriver driver1 = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestChangePasswordPageComponentsArePresent_CheckTextSectionsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

                driver1.Navigate().GoToUrl(HomeUrl);
                driver1.Manage().Window.Maximize();

                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                driver1.Navigate().GoToUrl(LoginUrl);
                IWebElement LoginEmailInputField = new WebDriverWait(driver1, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
                IWebElement LoginPasswordInputField = driver1.FindElement(By.Id("LoginPasswordInputField"));
                IWebElement LoginButton = driver1.FindElement(By.Id("LoginButton"));
                string UserEmail = UITestStrings.Test2UserEmail();
                string UserPassword = UITestStrings.Test2UserPassword();

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Keys.Tab);
                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Keys.Tab);
                LoginEmailInputField.SendKeys(UserEmail);
                LoginPasswordInputField.SendKeys(UserPassword);

                LoginButton.Click();
                IWebElement LoggedInUserLabel = new WebDriverWait(driver1, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                string AccountManageUrl = UrlRefLibrary.GetAccountManagePageLocalHostUrl();
                driver1.Navigate().GoToUrl(AccountManageUrl);
                driver1.Manage().Window.Maximize();
                IWebElement _ManageNavChangePassword = driver1.FindElement(By.Id("_ManageNavChangePassword"));
                _ManageNavChangePassword.Click();
                IWebElement NavBarElement = new WebDriverWait(driver1, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-changepassword-page")));
                IWebElement TitleElement = driver1.FindElement(By.Id("ChangePasswordPageTitle"));
                IWebElement SubTitleElement = driver1.FindElement(By.Id("ChangePasswordPageSubtitle"));
                IWebElement HeadingElement = driver1.FindElement(By.Id("ChangeAccountSettingsTitle"));
                IWebElement _ChangePasswordPageCurrentPassword = driver1.FindElement(By.Id("_ChangePasswordPageCurrentPassword"));
                IWebElement _ChangePasswordPageNewPassword = driver1.FindElement(By.Id("_ChangePasswordPageNewPassword"));
                IWebElement _ChangePasswordPageConfirmPassword = driver1.FindElement(By.Id("_ChangePasswordPageConfirmPassword"));
                IWebElement _ChangePasswordPageCurrentPasswordField = driver1.FindElement(By.Id("_ChangePasswordPageCurrentPasswordField"));
                IWebElement _ChangePasswordPageNewPasswordField = driver1.FindElement(By.Id("_ChangePasswordPageNewPasswordField"));
                IWebElement _ChangePasswordPageConfirmNewPasswordField = driver1.FindElement(By.Id("_ChangePasswordPageConfirmNewPasswordField"));
                IWebElement _ChangePasswordPageUpdatePasswordButton = driver1.FindElement(By.Id("_ChangePasswordPageUpdatePasswordButton"));
                IWebElement ProfileLinkElement = driver1.FindElement(By.Id("_ManageNavProfile"));
                IWebElement EmailLinkElement = driver1.FindElement(By.Id("_ManageNavEmail"));
                IWebElement PasswordLinkElement = driver1.FindElement(By.Id("_ManageNavChangePassword"));
                //IWebElement TwoFactorLinkElement = driver1.FindElement(By.Id("_ManageNavTwoFactor"));
                IWebElement PersonalDataLinkElement = driver1.FindElement(By.Id("_ManageNavPersonalData"));

                Assert.True(NavBarElement.Displayed);
                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(HeadingElement.Displayed);
                Assert.True(_ChangePasswordPageCurrentPassword.Displayed);
                Assert.True(_ChangePasswordPageNewPassword.Displayed);
                Assert.True(_ChangePasswordPageConfirmPassword.Displayed);
                Assert.True(_ChangePasswordPageCurrentPasswordField.Displayed);
                Assert.True(_ChangePasswordPageNewPasswordField.Displayed);
                Assert.True(_ChangePasswordPageConfirmNewPasswordField.Displayed);
                Assert.True(_ChangePasswordPageUpdatePasswordButton.Displayed);
                Assert.True(ProfileLinkElement.Displayed);
                Assert.True(EmailLinkElement.Displayed);
                Assert.True(PasswordLinkElement.Displayed);
                //Assert.True(TwoFactorLinkElement.Displayed);
                Assert.True(PersonalDataLinkElement.Displayed);

                driver1.Manage().Window.Size = new Size(240, 600);

                Assert.True(NavBarElement.Displayed);
                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(HeadingElement.Displayed);
                Assert.True(_ChangePasswordPageCurrentPassword.Displayed);
                Assert.True(_ChangePasswordPageNewPassword.Displayed);
                Assert.True(_ChangePasswordPageConfirmPassword.Displayed);
                Assert.True(_ChangePasswordPageCurrentPasswordField.Displayed);
                Assert.True(_ChangePasswordPageNewPasswordField.Displayed);
                Assert.True(_ChangePasswordPageConfirmNewPasswordField.Displayed);
                Assert.True(_ChangePasswordPageUpdatePasswordButton.Displayed);
                Assert.True(ProfileLinkElement.Displayed);
                Assert.True(EmailLinkElement.Displayed);
                Assert.True(PasswordLinkElement.Displayed);
                //Assert.True(TwoFactorLinkElement.Displayed);
                Assert.True(PersonalDataLinkElement.Displayed);
            }, filename, driver1);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckFooterIsDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestChangePasswordPageComponentsArePresent_CheckFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();

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

                string AccountManageUrl = UrlRefLibrary.GetAccountManagePageLocalHostUrl();
                driver.Navigate().GoToUrl(AccountManageUrl);
                IWebElement _ManageNavChangePassword = driver.FindElement(By.Id("_ManageNavChangePassword"));
                _ManageNavChangePassword.Click();

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