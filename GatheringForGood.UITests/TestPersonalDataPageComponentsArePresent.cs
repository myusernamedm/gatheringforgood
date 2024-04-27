using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using UITestStringsLibrary;
using OpenQA.Selenium.Support.UI;
using System.Drawing;

namespace GatheringForGood.UITests
{
    public class TestPersonalDataPageComponentsArePresent
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
            var filename = "TestDeletePersonalDataPageComponentsArePresent_CheckImagesAreDisplayed";

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
                IWebElement _ManageNavPersonalData = driver.FindElement(By.Id("_ManageNavPersonalData"));
                _ManageNavPersonalData.Click();

                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_DeletePersonalDataPageBanner")));
                IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));
                IWebElement _DeletePersonalDataPageLogoImg = driver.FindElement(By.Id("_DeletePersonalDataPageLogoImg"));

                Assert.True(BannerImageElement.Displayed);
                Assert.True(_DeletePersonalDataPageLogoImg.Displayed);
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
            var filename = "TestDeletePersonalDataPageComponentsArePresent_CheckNavBarIsDisplayed";

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
                IWebElement _ManageNavPersonalData = driver.FindElement(By.Id("_ManageNavPersonalData"));
                _ManageNavPersonalData.Click();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-deletepersonaldata-page")));
                IWebElement NavBarHomeLinkElement = driver.FindElement(By.Id("_DeletePersonalDataPageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement = driver.FindElement(By.Id("_DeletePersonalDataPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_DeletePersonalDataPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_DeletePersonalDataPageHelpNavLink"));
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
            var filename = "TestDeletePersonalDataPageComponentsArePresent_CheckTextSectionsAreDisplayed";

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

                IWebElement _ManageNavPersonalData = driver1.FindElement(By.Id("_ManageNavPersonalData"));
                _ManageNavPersonalData.Click();

                IWebElement NavBarElement = new WebDriverWait(driver1, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-deletepersonaldata-page")));
                IWebElement TitleElement = driver1.FindElement(By.Id("DeletePersonalDataPageTitle"));
                IWebElement SubTitleElement = driver1.FindElement(By.Id("DeletePersonalDataPageSubtitle"));
                IWebElement HeadingElement = driver1.FindElement(By.Id("ChangeAccountSettingsTitle"));
                IWebElement DeletePersonalDataPagePara1 = driver1.FindElement(By.Id("DeletePersonalDataPagePara1"));
                IWebElement DeletePersonalDataPagePara2 = driver1.FindElement(By.Id("DeletePersonalDataPagePara2"));
                IWebElement DeletePersonalDataPageDeletePara1and2 = driver1.FindElement(By.Id("DeletePersonalDataPageDeletePara1and2"));
                IWebElement DeletePersonalDataPageDeletePara3 = driver1.FindElement(By.Id("DeletePersonalDataPageDeletePara3"));
                IWebElement downloadData = driver1.FindElement(By.Id("download-data"));
                IWebElement delete = driver1.FindElement(By.Id("delete"));
                IWebElement ProfileLinkElement = driver1.FindElement(By.Id("_ManageNavProfile"));
                IWebElement EmailLinkElement = driver1.FindElement(By.Id("_ManageNavEmail"));
                IWebElement PasswordLinkElement = driver1.FindElement(By.Id("_ManageNavChangePassword"));
                //IWebElement TwoFactorLinkElement = driver1.FindElement(By.Id("_ManageNavTwoFactor"));
                IWebElement PersonalDataLinkElement = driver1.FindElement(By.Id("_ManageNavPersonalData"));

                Assert.True(NavBarElement.Displayed);
                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(HeadingElement.Displayed);
                Assert.True(DeletePersonalDataPagePara1.Displayed);
                Assert.True(DeletePersonalDataPagePara2.Displayed);
                Assert.True(DeletePersonalDataPageDeletePara1and2.Displayed);
                Assert.True(DeletePersonalDataPageDeletePara3.Displayed);
                Assert.True(downloadData.Displayed);
                Assert.True(delete.Displayed);
                Assert.True(ProfileLinkElement.Displayed);
                Assert.True(EmailLinkElement.Displayed);
                Assert.True(PasswordLinkElement.Displayed);
                //Assert.True(TwoFactorLinkElement.Displayed);
                Assert.True(PersonalDataLinkElement.Displayed);

                delete.Click();

                IWebElement DeleteDataPara1 = driver1.FindElement(By.Id("DeleteDataPara1"));
                IWebElement DeleteDataPara2 = driver1.FindElement(By.Id("DeleteDataPara2"));
                IWebElement DeleteDataPara3 = driver1.FindElement(By.Id("DeleteDataPara3"));
                IWebElement DeleteDataPasswordHeading = driver1.FindElement(By.Id("DeleteDataPasswordHeading"));
                IWebElement DeleteDataPasswordField = driver1.FindElement(By.Id("DeleteDataPasswordField"));
                IWebElement deleteAccountButton = driver1.FindElement(By.Id("delete-account-button"));

                Assert.True(DeleteDataPara1.Displayed);
                Assert.True(DeleteDataPara2.Displayed);
                Assert.True(DeleteDataPara3.Displayed);
                Assert.True(DeleteDataPasswordHeading.Displayed);
                Assert.True(DeleteDataPasswordField.Displayed);
                Assert.True(deleteAccountButton.Displayed);

                IWebElement _ManageNavPersonalData1 = driver1.FindElement(By.Id("_ManageNavPersonalData"));
                _ManageNavPersonalData1.Click();

                driver1.Manage().Window.Size = new Size(240, 600);

                IWebElement NavBarElementb = new WebDriverWait(driver1, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-deletepersonaldata-page")));
                IWebElement TitleElementb = driver1.FindElement(By.Id("DeletePersonalDataPageTitle"));
                IWebElement SubTitleElementb = driver1.FindElement(By.Id("DeletePersonalDataPageSubtitle"));
                IWebElement HeadingElementb = driver1.FindElement(By.Id("ChangeAccountSettingsTitle"));
                IWebElement DeletePersonalDataPagePara1b = driver1.FindElement(By.Id("DeletePersonalDataPagePara1"));
                IWebElement DeletePersonalDataPagePara2b = driver1.FindElement(By.Id("DeletePersonalDataPagePara2"));
                IWebElement DeletePersonalDataPageDeletePara1and2b = driver1.FindElement(By.Id("DeletePersonalDataPageDeletePara1and2"));
                IWebElement DeletePersonalDataPageDeletePara3b = driver1.FindElement(By.Id("DeletePersonalDataPageDeletePara3"));
                IWebElement downloadDatab = driver1.FindElement(By.Id("download-data"));
                IWebElement deleteb = driver1.FindElement(By.Id("delete"));
                IWebElement ProfileLinkElementb = driver1.FindElement(By.Id("_ManageNavProfile"));
                IWebElement EmailLinkElementb = driver1.FindElement(By.Id("_ManageNavEmail"));
                IWebElement PasswordLinkElementb = driver1.FindElement(By.Id("_ManageNavChangePassword"));
                //IWebElement TwoFactorLinkElementb = driver1.FindElement(By.Id("_ManageNavTwoFactor"));
                IWebElement PersonalDataLinkElementb = driver1.FindElement(By.Id("_ManageNavPersonalData"));

                Assert.True(NavBarElementb.Displayed);
                Assert.True(TitleElementb.Displayed);
                Assert.True(SubTitleElementb.Displayed);
                Assert.True(HeadingElementb.Displayed);
                Assert.True(DeletePersonalDataPagePara1b.Displayed);
                Assert.True(DeletePersonalDataPagePara2b.Displayed);
                Assert.True(DeletePersonalDataPageDeletePara1and2b.Displayed);
                Assert.True(DeletePersonalDataPageDeletePara3b.Displayed);
                Assert.True(downloadDatab.Displayed);
                Assert.True(deleteb.Displayed);
                Assert.True(ProfileLinkElementb.Displayed);
                Assert.True(EmailLinkElementb.Displayed);
                Assert.True(PasswordLinkElementb.Displayed);
                //Assert.True(TwoFactorLinkElementb.Displayed);
                Assert.True(PersonalDataLinkElementb.Displayed);

                IWebElement deletec = driver1.FindElement(By.Id("delete"));
                deletec.Click();

                IWebElement DeleteDataPara1b = driver1.FindElement(By.Id("DeleteDataPara1"));
                IWebElement DeleteDataPara2b = driver1.FindElement(By.Id("DeleteDataPara2"));
                IWebElement DeleteDataPara3b = driver1.FindElement(By.Id("DeleteDataPara3"));
                IWebElement DeleteDataPasswordHeadingb = driver1.FindElement(By.Id("DeleteDataPasswordHeading"));
                IWebElement DeleteDataPasswordFieldb = driver1.FindElement(By.Id("DeleteDataPasswordField"));
                IWebElement deleteAccountButtonb = driver1.FindElement(By.Id("delete-account-button"));

                Assert.True(DeleteDataPara1b.Displayed);
                Assert.True(DeleteDataPara2b.Displayed);
                Assert.True(DeleteDataPara3b.Displayed);
                Assert.True(DeleteDataPasswordHeadingb.Displayed);
                Assert.True(DeleteDataPasswordFieldb.Displayed);
                Assert.True(deleteAccountButtonb.Displayed);

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
            var filename = "TestDeletePersonalDataPageComponentsArePresent_CheckFooterIsDisplayed";

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
                IWebElement _ManageNavPersonalData = driver.FindElement(By.Id("_ManageNavPersonalData"));
                _ManageNavPersonalData.Click();

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