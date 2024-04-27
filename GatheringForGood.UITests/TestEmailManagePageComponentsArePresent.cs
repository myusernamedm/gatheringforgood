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
    public class TestEmailManagePageComponentsArePresent
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
            var filename = "TestEmailManagePageComponentsArePresent_CheckImagesAreDisplayed";

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
                IWebElement _ManageNavEmailLink = driver.FindElement(By.Id("_ManageNavEmail"));
                _ManageNavEmailLink.Click();

                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("EmailManagePageBanner")));
                IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));
                IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_EmailManagePageLogoImg"));

                Assert.True(BannerImageElement.Displayed);
                Assert.True(_LayoutPageLogoElement.Displayed);
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
            var filename = "TestEmailManagePageComponentsArePresent_CheckNavBarIsDisplayed";

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
                IWebElement _ManageNavEmailLink = driver.FindElement(By.Id("_ManageNavEmail"));
                _ManageNavEmailLink.Click();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-emailmanage-page")));
                IWebElement NavBarHomeLinkElement = driver.FindElement(By.Id("_EmailManagePageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement = driver.FindElement(By.Id("_EmailManagePageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_EmailManagePageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_EmailManagePageHelpNavLink"));
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
            var filename = "TestEmailManagePageComponentsArePresent_CheckTextSectionsAreDisplayed";

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
                IWebElement _ManageNavEmailLink = driver1.FindElement(By.Id("_ManageNavEmail"));
                _ManageNavEmailLink.Click();
                IWebElement NavBarElement = new WebDriverWait(driver1, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-emailmanage-page")));
                IWebElement TitleElement = driver1.FindElement(By.Id("EmailManagePageTitle"));
                IWebElement SubTitleElement = driver1.FindElement(By.Id("EmailManagePageSubtitle"));
                IWebElement HeadingElement = driver1.FindElement(By.Id("ChangeAccountSettingsTitle"));
                IWebElement EmailHeading = driver1.FindElement(By.Id("_EmailManagePageEmailHeading"));
                IWebElement NewEmailHeading = driver1.FindElement(By.Id("_EmailManagePageNewEmailHeading"));
                IWebElement EmailField = driver1.FindElement(By.Id("_EmailManagePageEmailField"));
                IWebElement NewEmailField = driver1.FindElement(By.Id("_EmailManagePageNewEmailHeading"));
                IWebElement ChangeEmailButton = driver1.FindElement(By.Id("_EmailManagePageChangeEmailButton"));
                IWebElement ProfileLinkElement = driver1.FindElement(By.Id("_ManageNavProfile"));
                IWebElement EmailLinkElement = driver1.FindElement(By.Id("_ManageNavEmail"));
                IWebElement PasswordLinkElement = driver1.FindElement(By.Id("_ManageNavChangePassword"));
                //IWebElement TwoFactorLinkElement = driver1.FindElement(By.Id("_ManageNavTwoFactor"));
                IWebElement PersonalDataLinkElement = driver1.FindElement(By.Id("_ManageNavPersonalData"));

                Assert.True(NavBarElement.Displayed);
                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(HeadingElement.Displayed);
                Assert.True(EmailHeading.Displayed);
                Assert.True(NewEmailHeading.Displayed);
                Assert.True(EmailField.Displayed);
                Assert.True(NewEmailField.Displayed);
                Assert.True(ChangeEmailButton.Displayed);
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
                Assert.True(EmailHeading.Displayed);
                Assert.True(NewEmailHeading.Displayed);
                Assert.True(EmailField.Displayed);
                Assert.True(NewEmailField.Displayed);
                Assert.True(ChangeEmailButton.Displayed);
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
        public void CheckChangeEmailButtonIsDisplayedAndClickable()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestEmailManagePageComponentsArePresent_CheckChangeEmailButtonIsDisplayedAndClickable";

            TakeTestFailScreenshot.UITest(() =>
                         {
                             var UrlRefLibrary = new UrlStrings();

                             string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                             driver.Navigate().GoToUrl(LoginUrl);
                             driver.Manage().Window.Maximize();
                             IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
                             IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
                             IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));
                             string UserEmail = UITestStrings.Test2UserEmail();
                             string UserPassword = UITestStrings.Test2UserPassword();
                             string UserEmail22 = UITestStrings.Test22UserEmail();

                             LoginEmailInputField.Clear();
                             LoginEmailInputField.SendKeys(Keys.Tab);
                             LoginPasswordInputField.Clear();
                             LoginPasswordInputField.SendKeys(Keys.Tab);
                             LoginEmailInputField.SendKeys(UserEmail);
                             LoginPasswordInputField.SendKeys(UserPassword);

                             LoginButton.Click();

                             string AccountManageUrl = UrlRefLibrary.GetAccountManagePageLocalHostUrl();
                             driver.Navigate().GoToUrl(AccountManageUrl);
                             IWebElement _ManageNavEmailLink = driver.FindElement(By.Id("_ManageNavEmail"));
                             _ManageNavEmailLink.Click();

                             IWebElement ChangeEmailButton = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_EmailManagePageChangeEmailButton")));

                             Assert.True(ChangeEmailButton.Displayed);
                             ChangeEmailButton.Click();

                             IWebElement HomepageGreatestChallengeTitle = driver.FindElement(By.Id("GreatestChallengeTitle"));
                             Assert.True(HomepageGreatestChallengeTitle.Displayed);

                             string AccountManageUrl1 = UrlRefLibrary.GetAccountManagePageLocalHostUrl();
                             driver.Navigate().GoToUrl(AccountManageUrl1);

                             IWebElement _ManageNavEmailLink1 = driver.FindElement(By.Id("_ManageNavEmail"));
                             _ManageNavEmailLink1.Click();

                             IWebElement _EmailManagePageNewEmailField = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_EmailManagePageNewEmailField")));
                             _EmailManagePageNewEmailField.Clear();
                             _EmailManagePageNewEmailField.SendKeys(Keys.Tab);
                             _EmailManagePageNewEmailField.SendKeys(UserEmail);

                             IWebElement ChangeEmailButton1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_EmailManagePageChangeEmailButton")));
                             ChangeEmailButton1.Click();

                             string AccountManageUrl2 = UrlRefLibrary.GetAccountManagePageLocalHostUrl();
                             driver.Navigate().GoToUrl(AccountManageUrl2);

                             IWebElement _ManageNavEmailLink2 = driver.FindElement(By.Id("_ManageNavEmail"));
                             _ManageNavEmailLink2.Click();

                             IWebElement _EmailManagePageNewEmailField1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_EmailManagePageNewEmailField")));
                             _EmailManagePageNewEmailField1.Clear();
                             _EmailManagePageNewEmailField1.SendKeys(Keys.Tab);
                             _EmailManagePageNewEmailField1.SendKeys(UserEmail22);

                             IWebElement ChangeEmailButton2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_EmailManagePageChangeEmailButton")));
                             ChangeEmailButton2.Click();
                             IWebElement EmailStatusMessage = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("EmailStatusMessage")));
                             Assert.True(EmailStatusMessage.Displayed);

                         }, filename, driver);

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
            var filename = "TestEmailManagePageComponentsArePresent_CheckFooterIsDisplayed";

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
                IWebElement _ManageNavEmailLink = driver.FindElement(By.Id("_ManageNavEmail"));
                _ManageNavEmailLink.Click();

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
