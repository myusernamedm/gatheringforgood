using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using UITestStringsLibrary;
using OpenQA.Selenium.Support.UI;

namespace GatheringForGood.UITests
{
    public class TestHelpPageComponentsArePresent
    {
        readonly CrossPageSharedUITestStrings UITestStrings = new UITestStringsLibrary.CrossPageSharedUITestStrings();

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckImagesAndButtonsAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestHelpPageComponentsArePresent_CheckImagesAreDisplayed";

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

                string HelpUrl = UrlRefLibrary.GetHelpPageLocalHostUrl();
                driver.Navigate().GoToUrl(HelpUrl);
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("HelpPageBanner")));
                IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));
                IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_HelpPageLogoImg"));
                IWebElement HelpPageContactIconImage = driver.FindElement(By.Id("HelpPageContactIconImage"));
                IWebElement ContactUsSubmitButton = driver.FindElement(By.Id("ContactUsSubmitButton"));

                Assert.True(BannerImageElement.Displayed);
                Assert.True(_LayoutPageLogoElement.Displayed);
                Assert.True(BodyBackground.Displayed);
                Assert.True(HelpPageContactIconImage.Displayed);
                Assert.True(ContactUsSubmitButton.Displayed);
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
            var filename = "TestHelpPageComponentsArePresent_CheckNavBarIsDisplayed";

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

                string HelpUrl = UrlRefLibrary.GetHelpPageLocalHostUrl();
                driver.Navigate().GoToUrl(HelpUrl);
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-help-page")));
                IWebElement NavBarHomeLinkElement = driver.FindElement(By.Id("_HelpPageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement = driver.FindElement(By.Id("_HelpPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_HelpPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_HelpPageHelpNavLink"));
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
        [Trait("RunTime", "Long")]
        [Trait("TestEnvironment", "Local")]
        public void CheckTextSectionsAndFieldsAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestHelpPageComponentsArePresent_CheckTextSectionsAreDisplayed";

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

                string HelpUrl = UrlRefLibrary.GetHelpPageLocalHostUrl();
                driver.Navigate().GoToUrl(HelpUrl);
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-help-page")));
                IWebElement TitleElement = driver.FindElement(By.Id("HelpPageTitle"));
                IWebElement SubTitleElement = driver.FindElement(By.Id("HelpPageSubtitle"));
                IWebElement HelloTitleElement = driver.FindElement(By.Id("HelloTitle"));
                IWebElement HelpPageContactIconText = driver.FindElement(By.Id("HelpPageContactIconText"));
                IWebElement HelpPageLetUsKnowTitle = driver.FindElement(By.Id("HelpPageLetUsKnowTitle"));
                IWebElement HelpPageIdeasOrSayHi = driver.FindElement(By.Id("HelpPageIdeasOrSayHi"));
                IWebElement ContactUsNameHeading = driver.FindElement(By.Id("ContactUsNameHeading"));
                IWebElement ContactUsEmailHeading = driver.FindElement(By.Id("ContactUsEmailHeading"));
                IWebElement ContactUsSubjectHeading = driver.FindElement(By.Id("ContactUsSubjectHeading"));
                IWebElement ContactUsMessageHeading = driver.FindElement(By.Id("ContactUsMessageHeading"));
                IWebElement ContactUsTandCHeading = driver.FindElement(By.Id("ContactUsTandCHeading"));
                IWebElement ContactUsNameField = driver.FindElement(By.Id("ContactUsNameField"));
                IWebElement ContactUsEmailField = driver.FindElement(By.Id("ContactUsEmailField"));
                IWebElement ContactUsSubjectField = driver.FindElement(By.Id("ContactUsSubjectField"));
                IWebElement ContactUsMessageField = driver.FindElement(By.Id("ContactUsMessageField"));
                IWebElement ContactUsTandCCheckbox = driver.FindElement(By.Id("ContactUsTandCCheckbox"));
                IWebElement ContactUsNameValidation = driver.FindElement(By.Id("ContactUsNameValidation"));
                IWebElement ContactUsEmailValidation = driver.FindElement(By.Id("ContactUsEmailValidation"));
                IWebElement ContactUsMessageHeadingValidation = driver.FindElement(By.Id("ContactUsMessageHeadingValidation"));
                IWebElement ContactUsTandCHeadingValidation = driver.FindElement(By.Id("ContactUsTandCHeadingValidation"));

                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(HelloTitleElement.Displayed);
                Assert.True(HelpPageContactIconText.Displayed);
                Assert.True(HelpPageLetUsKnowTitle.Displayed);
                Assert.True(HelpPageIdeasOrSayHi.Displayed);
                Assert.True(ContactUsNameHeading.Displayed);
                Assert.True(ContactUsEmailHeading.Displayed);
                Assert.True(ContactUsSubjectHeading.Displayed);
                Assert.True(ContactUsMessageHeading.Displayed);
                Assert.True(ContactUsTandCHeading.Displayed);
                Assert.True(ContactUsNameField.Displayed);
                Assert.True(ContactUsEmailField.Displayed);
                Assert.True(ContactUsSubjectField.Displayed);
                Assert.True(ContactUsMessageField.Displayed);
                Assert.True(ContactUsTandCCheckbox.Displayed);
                Assert.False(ContactUsNameValidation.Displayed);
                Assert.False(ContactUsEmailValidation.Displayed);
                Assert.False(ContactUsMessageHeadingValidation.Displayed);
                Assert.False(ContactUsTandCHeadingValidation.Displayed);

                IWebElement ContactUsSubmitButton = driver.FindElement(By.Id("ContactUsSubmitButton"));
                ContactUsSubmitButton.Click();
                IWebElement ContactUsNameValidation2 = driver.FindElement(By.Id("ContactUsNameValidation"));
                IWebElement ContactUsEmailValidation2 = driver.FindElement(By.Id("ContactUsEmailValidation"));
                IWebElement ContactUsMessageHeadingValidation2 = driver.FindElement(By.Id("ContactUsMessageHeadingValidation"));
                IWebElement ContactUsTandCHeadingValidation2 = driver.FindElement(By.Id("ContactUsTandCHeadingValidation"));
                
                Assert.True(ContactUsNameValidation2.Displayed);
                Assert.True(ContactUsEmailValidation2.Displayed);
                Assert.True(ContactUsMessageHeadingValidation2.Displayed);
                Assert.True(ContactUsTandCHeadingValidation2.Displayed);

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
            var filename = "TestHelpPageComponentsArePresent_CheckFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string HelpUrl = UrlRefLibrary.GetHelpPageLocalHostUrl();

                driver.Navigate().GoToUrl(HelpUrl);
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

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckHelpPageContactTandCLinkIsCorrect()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestHelpPageComponentsArePresent_CheckFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string HelpUrl = UrlRefLibrary.GetHelpPageLocalHostUrl();

                driver.Navigate().GoToUrl(HelpUrl);
                driver.Manage().Window.Maximize();
                IWebElement FooterElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("nav-footer")));
                IWebElement ContactUsTandCHeading = driver.FindElement(By.Id("ContactUsTandCHeading"));
                ContactUsTandCHeading.Click();
                IWebElement TermsAndConditionsPageSubtitle = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("TermsAndConditionsPageSubtitle")));
                Assert.True(TermsAndConditionsPageSubtitle.Displayed);

            }, filename, driver);
        }

    }
}
