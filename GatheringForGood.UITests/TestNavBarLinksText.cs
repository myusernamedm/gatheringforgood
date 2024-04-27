using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using UITestStringsLibrary;
using OpenQA.Selenium.Support.UI;

namespace GatheringForGood.UITests
{
    public class TestNavBarLinksText
    {

        readonly CrossPageSharedUITestStrings UITestStrings = new UITestStringsLibrary.CrossPageSharedUITestStrings();

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckTextForNavBarLinksIsCorrect()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestNavBarLinksText_CheckTextForNavBarLinksIsCorrect";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();
                string NewsfeedUrl = UrlRefLibrary.GetNewsfeedPageLocalHostUrl();
                string AboutUrl = UrlRefLibrary.GetAboutPageLocalHostUrl();
                string HelpUrl = UrlRefLibrary.GetHelpPageLocalHostUrl();
                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                string RegisterUrl = UrlRefLibrary.GetRegisterPageLocalHostUrl();
                string ArticlesUrl = UrlRefLibrary.GetArticlesPageLocalHostUrl();
                string PrivacyUrl = UrlRefLibrary.GetPrivacyPageLocalHostUrl();
                string CookiesUrl = UrlRefLibrary.GetCookiesPageLocalHostUrl();
                string RGWUrl = UrlRefLibrary.GetReduceGlobalWarmingPageLocalHostUrl();
                string AccountManageUrl = UrlRefLibrary.GetAccountManagePageLocalHostUrl();

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-home-page")));
                IWebElement NavBarHomeLinkElement = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_HomePageHomeNavLink")));
                IWebElement NavBarArticlesLinkElement = driver.FindElement(By.Id("_HomePageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_HomePageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_HomePageHelpNavLink"));
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

                //Re-enable below when using Newsfeed page again
                /*
                driver.Navigate().GoToUrl(NewsfeedUrl);
                IWebElement NavBarElement1 = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-newsfeed-page")));
                IWebElement NavBarHomeLinkElement1 = driver.FindElement(By.Id("_NewsfeedPageHomeNavLink"));
                IWebElement NavBarNewsfeedLinkElement1 = driver.FindElement(By.Id("_NewsfeedPageNewsfeedNavLink"));
                IWebElement NavBarAboutLinkElement1 = driver.FindElement(By.Id("_NewsfeedPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement1 = driver.FindElement(By.Id("_NewsfeedPageHelpNavLink"));
                IWebElement NavBarRegisterLinkElement1 = driver.FindElement(By.Id("_LoginPartialRegister"));
                IWebElement NavBarLoginLinkElement1 = driver.FindElement(By.Id("_LoginPartialLogin"));

                Assert.True(NavBarElement1.Displayed);
                Assert.True(NavBarHomeLinkElement1.Displayed);
                Assert.True(NavBarNewsfeedLinkElement1.Displayed);
                Assert.True(NavBarAboutLinkElement1.Displayed);
                Assert.True(NavBarHelpLinkElement1.Displayed);
                Assert.True(NavBarRegisterLinkElement1.Displayed);
                Assert.True(NavBarLoginLinkElement1.Displayed);

                Assert.Equal("HOME", NavBarHomeLinkElement1.Text);
                Assert.Equal("NEWSFEED", NavBarNewsfeedLinkElement1.Text);
                Assert.Equal("ABOUT", NavBarAboutLinkElement1.Text);
                Assert.Equal("HELP CENTER", NavBarHelpLinkElement1.Text);
                Assert.Equal("REGISTER", NavBarRegisterLinkElement1.Text);
                Assert.Equal("LOGIN", NavBarLoginLinkElement1.Text);
                */

                driver.Navigate().GoToUrl(AboutUrl);
                IWebElement NavBarElement2 = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-about-page")));
                IWebElement NavBarHomeLinkElement2 = driver.FindElement(By.Id("_AboutPageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement2 = driver.FindElement(By.Id("_AboutPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement2 = driver.FindElement(By.Id("_AboutPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement2 = driver.FindElement(By.Id("_AboutPageHelpNavLink"));
                IWebElement NavBarRegisterLinkElement2 = driver.FindElement(By.Id("_LoginPartialRegister"));
                IWebElement NavBarLoginLinkElement2 = driver.FindElement(By.Id("_LoginPartialLogin"));

                Assert.True(NavBarElement2.Displayed);
                Assert.True(NavBarHomeLinkElement2.Displayed);
                Assert.True(NavBarArticlesLinkElement2.Displayed);
                Assert.True(NavBarAboutLinkElement2.Displayed);
                Assert.True(NavBarHelpLinkElement2.Displayed);
                Assert.True(NavBarRegisterLinkElement2.Displayed);
                Assert.True(NavBarLoginLinkElement2.Displayed);

                Assert.Equal("HOME", NavBarHomeLinkElement2.Text);
                Assert.Equal("ARTICLES", NavBarArticlesLinkElement2.Text);
                Assert.Equal("ABOUT", NavBarAboutLinkElement2.Text);
                Assert.Equal("HELP CENTER", NavBarHelpLinkElement2.Text);
                Assert.Equal("REGISTER", NavBarRegisterLinkElement2.Text);
                Assert.Equal("LOGIN", NavBarLoginLinkElement2.Text);

                driver.Navigate().GoToUrl(RegisterUrl);
                IWebElement NavBarElement3 = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-register-page")));
                IWebElement NavBarHomeLinkElement3 = driver.FindElement(By.Id("_RegisterPageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement3 = driver.FindElement(By.Id("_RegisterPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement3 = driver.FindElement(By.Id("_RegisterPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement3 = driver.FindElement(By.Id("_RegisterPageHelpNavLink"));
                IWebElement NavBarRegisterLinkElement3 = driver.FindElement(By.Id("_LoginPartialRegister"));
                IWebElement NavBarLoginLinkElement3 = driver.FindElement(By.Id("_LoginPartialLogin"));

                Assert.True(NavBarElement3.Displayed);
                Assert.True(NavBarHomeLinkElement3.Displayed);
                Assert.True(NavBarArticlesLinkElement3.Displayed);
                Assert.True(NavBarAboutLinkElement3.Displayed);
                Assert.True(NavBarHelpLinkElement3.Displayed);
                Assert.True(NavBarRegisterLinkElement3.Displayed);
                Assert.True(NavBarLoginLinkElement3.Displayed);

                Assert.Equal("HOME", NavBarHomeLinkElement3.Text);
                Assert.Equal("ARTICLES", NavBarArticlesLinkElement3.Text);
                Assert.Equal("ABOUT", NavBarAboutLinkElement3.Text);
                Assert.Equal("HELP CENTER", NavBarHelpLinkElement3.Text);
                Assert.Equal("REGISTER", NavBarRegisterLinkElement3.Text);
                Assert.Equal("LOGIN", NavBarLoginLinkElement3.Text);

                driver.Navigate().GoToUrl(LoginUrl);
                IWebElement NavBarElement4 = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-login-page")));
                IWebElement NavBarHomeLinkElement4 = driver.FindElement(By.Id("_LoginPageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement4 = driver.FindElement(By.Id("_LoginPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement4 = driver.FindElement(By.Id("_LoginPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement4 = driver.FindElement(By.Id("_LoginPageHelpNavLink"));
                IWebElement NavBarRegisterLinkElement4 = driver.FindElement(By.Id("_LoginPartialRegister"));
                IWebElement NavBarLoginLinkElement4 = driver.FindElement(By.Id("_LoginPartialLogin"));

                Assert.True(NavBarElement4.Displayed);
                Assert.True(NavBarHomeLinkElement4.Displayed);
                Assert.True(NavBarArticlesLinkElement4.Displayed);
                Assert.True(NavBarAboutLinkElement4.Displayed);
                Assert.True(NavBarHelpLinkElement4.Displayed);
                Assert.True(NavBarRegisterLinkElement4.Displayed);
                Assert.True(NavBarLoginLinkElement4.Displayed);

                Assert.Equal("HOME", NavBarHomeLinkElement4.Text);
                Assert.Equal("ARTICLES", NavBarArticlesLinkElement4.Text);
                Assert.Equal("ABOUT", NavBarAboutLinkElement4.Text);
                Assert.Equal("HELP CENTER", NavBarHelpLinkElement4.Text);
                Assert.Equal("REGISTER", NavBarRegisterLinkElement4.Text);
                Assert.Equal("LOGIN", NavBarLoginLinkElement4.Text);

                driver.Navigate().GoToUrl(PrivacyUrl);
                IWebElement NavBarElement5 = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-privacy-page")));
                IWebElement NavBarHomeLinkElement5 = driver.FindElement(By.Id("_PrivacyPageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement5 = driver.FindElement(By.Id("_PrivacyPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement5 = driver.FindElement(By.Id("_PrivacyPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement5 = driver.FindElement(By.Id("_PrivacyPageHelpNavLink"));
                IWebElement NavBarRegisterLinkElement5 = driver.FindElement(By.Id("_LoginPartialRegister"));
                IWebElement NavBarLoginLinkElement5 = driver.FindElement(By.Id("_LoginPartialLogin"));

                Assert.True(NavBarElement5.Displayed);
                Assert.True(NavBarHomeLinkElement5.Displayed);
                Assert.True(NavBarArticlesLinkElement5.Displayed);
                Assert.True(NavBarAboutLinkElement5.Displayed);
                Assert.True(NavBarHelpLinkElement5.Displayed);
                Assert.True(NavBarRegisterLinkElement5.Displayed);
                Assert.True(NavBarLoginLinkElement5.Displayed);

                Assert.Equal("HOME", NavBarHomeLinkElement5.Text);
                Assert.Equal("ARTICLES", NavBarArticlesLinkElement5.Text);
                Assert.Equal("ABOUT", NavBarAboutLinkElement5.Text);
                Assert.Equal("HELP CENTER", NavBarHelpLinkElement5.Text);
                Assert.Equal("REGISTER", NavBarRegisterLinkElement5.Text);
                Assert.Equal("LOGIN", NavBarLoginLinkElement5.Text);

                driver.Navigate().GoToUrl(CookiesUrl);
                IWebElement NavBarElement6 = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-cookies-page")));
                IWebElement NavBarHomeLinkElement6 = driver.FindElement(By.Id("_CookiesPageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement6 = driver.FindElement(By.Id("_CookiesPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement6 = driver.FindElement(By.Id("_CookiesPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement6 = driver.FindElement(By.Id("_CookiesPageHelpNavLink"));
                IWebElement NavBarRegisterLinkElement6 = driver.FindElement(By.Id("_LoginPartialRegister"));
                IWebElement NavBarLoginLinkElement6 = driver.FindElement(By.Id("_LoginPartialLogin"));

                Assert.True(NavBarElement6.Displayed);
                Assert.True(NavBarHomeLinkElement6.Displayed);
                Assert.True(NavBarArticlesLinkElement6.Displayed);
                Assert.True(NavBarAboutLinkElement6.Displayed);
                Assert.True(NavBarHelpLinkElement6.Displayed);
                Assert.True(NavBarRegisterLinkElement6.Displayed);
                Assert.True(NavBarLoginLinkElement6.Displayed);

                Assert.Equal("HOME", NavBarHomeLinkElement6.Text);
                Assert.Equal("ARTICLES", NavBarArticlesLinkElement6.Text);
                Assert.Equal("ABOUT", NavBarAboutLinkElement6.Text);
                Assert.Equal("HELP CENTER", NavBarHelpLinkElement6.Text);
                Assert.Equal("REGISTER", NavBarRegisterLinkElement6.Text);
                Assert.Equal("LOGIN", NavBarLoginLinkElement6.Text);

                driver.Navigate().GoToUrl(LoginUrl);
                IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
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
                IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                driver.Navigate().GoToUrl(HelpUrl);
                IWebElement NavBarElement7 = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-help-page")));
                IWebElement NavBarHomeLinkElement7 = driver.FindElement(By.Id("_HelpPageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement7 = driver.FindElement(By.Id("_HelpPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement7 = driver.FindElement(By.Id("_HelpPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement7 = driver.FindElement(By.Id("_HelpPageHelpNavLink"));
                IWebElement NavBarRegisterLinkElement7 = driver.FindElement(By.Id("_LoginPartialLoggedInUserEmail"));
                IWebElement NavBarLogoutLinkElement7 = driver.FindElement(By.Id("_LoginPartialLogoutButton"));

                Assert.True(NavBarElement7.Displayed);
                Assert.True(NavBarHomeLinkElement7.Displayed);
                Assert.True(NavBarArticlesLinkElement7.Displayed);
                Assert.True(NavBarAboutLinkElement7.Displayed);
                Assert.True(NavBarHelpLinkElement7.Displayed);
                Assert.True(NavBarRegisterLinkElement7.Displayed);
                Assert.True(NavBarLogoutLinkElement7.Displayed);

                Assert.Equal("HOME", NavBarHomeLinkElement7.Text);
                Assert.Equal("ARTICLES", NavBarArticlesLinkElement7.Text);
                Assert.Equal("ABOUT", NavBarAboutLinkElement7.Text);
                Assert.Equal("HELP CENTER", NavBarHelpLinkElement7.Text);
                Assert.Equal(UserEmail.ToString().ToUpper(), NavBarRegisterLinkElement7.Text);
                Assert.Equal("LOGOUT", NavBarLogoutLinkElement7.Text);

                driver.Navigate().GoToUrl(ArticlesUrl);
                IWebElement NavBarElement8 = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-articles-page")));
                IWebElement NavBarHomeLinkElement8 = driver.FindElement(By.Id("_ArticlesPageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement8 = driver.FindElement(By.Id("_ArticlesPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement8 = driver.FindElement(By.Id("_ArticlesPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement8 = driver.FindElement(By.Id("_ArticlesPageHelpNavLink"));
                IWebElement NavBarRegisterLinkElement8 = driver.FindElement(By.Id("_LoginPartialLoggedInUserEmail"));
                IWebElement NavBarLogoutLinkElement8 = driver.FindElement(By.Id("_LoginPartialLogoutButton"));

                Assert.True(NavBarElement8.Displayed);
                Assert.True(NavBarHomeLinkElement8.Displayed);
                Assert.True(NavBarArticlesLinkElement8.Displayed);
                Assert.True(NavBarAboutLinkElement8.Displayed);
                Assert.True(NavBarHelpLinkElement8.Displayed);
                Assert.True(NavBarRegisterLinkElement8.Displayed);
                Assert.True(NavBarLogoutLinkElement8.Displayed);

                Assert.Equal("HOME", NavBarHomeLinkElement8.Text);
                Assert.Equal("ARTICLES", NavBarArticlesLinkElement8.Text);
                Assert.Equal("ABOUT", NavBarAboutLinkElement8.Text);
                Assert.Equal("HELP CENTER", NavBarHelpLinkElement8.Text);
                Assert.Equal(UserEmail.ToString().ToUpper(), NavBarRegisterLinkElement8.Text);
                Assert.Equal("LOGOUT", NavBarLogoutLinkElement8.Text);

                driver.Navigate().GoToUrl(RGWUrl);
                IWebElement NavBarElement9 = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-rgw-page")));
                IWebElement NavBarHomeLinkElement9 = driver.FindElement(By.Id("_RGWPageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement9 = driver.FindElement(By.Id("_RGWPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement9 = driver.FindElement(By.Id("_RGWPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement9 = driver.FindElement(By.Id("_RGWPageHelpNavLink"));
                IWebElement NavBarRegisterLinkElement9 = driver.FindElement(By.Id("_LoginPartialLoggedInUserEmail"));
                IWebElement NavBarLogoutLinkElement9 = driver.FindElement(By.Id("_LoginPartialLogoutButton"));

                Assert.True(NavBarElement9.Displayed);
                Assert.True(NavBarHomeLinkElement9.Displayed);
                Assert.True(NavBarArticlesLinkElement9.Displayed);
                Assert.True(NavBarAboutLinkElement9.Displayed);
                Assert.True(NavBarHelpLinkElement9.Displayed);
                Assert.True(NavBarRegisterLinkElement9.Displayed);
                Assert.True(NavBarLogoutLinkElement9.Displayed);

                Assert.Equal("HOME", NavBarHomeLinkElement9.Text);
                Assert.Equal("ARTICLES", NavBarArticlesLinkElement9.Text);
                Assert.Equal("ABOUT", NavBarAboutLinkElement9.Text);
                Assert.Equal("HELP CENTER", NavBarHelpLinkElement9.Text);
                Assert.Equal(UserEmail.ToString().ToUpper(), NavBarRegisterLinkElement9.Text);
                Assert.Equal("LOGOUT", NavBarLogoutLinkElement9.Text);

                driver.Navigate().GoToUrl(RGWUrl);
                IWebElement NavBarElement10 = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-rgw-page")));
                IWebElement NavBarHomeLinkElement10 = driver.FindElement(By.Id("_RGWPageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement10 = driver.FindElement(By.Id("_RGWPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement10 = driver.FindElement(By.Id("_RGWPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement10 = driver.FindElement(By.Id("_RGWPageHelpNavLink"));
                IWebElement NavBarRegisterLinkElement10 = driver.FindElement(By.Id("_LoginPartialLoggedInUserEmail"));
                IWebElement NavBarLogoutLinkElement10 = driver.FindElement(By.Id("_LoginPartialLogoutButton"));

                Assert.True(NavBarElement10.Displayed);
                Assert.True(NavBarHomeLinkElement10.Displayed);
                Assert.True(NavBarArticlesLinkElement10.Displayed);
                Assert.True(NavBarAboutLinkElement10.Displayed);
                Assert.True(NavBarHelpLinkElement10.Displayed);
                Assert.True(NavBarRegisterLinkElement10.Displayed);
                Assert.True(NavBarLogoutLinkElement10.Displayed);

                Assert.Equal("HOME", NavBarHomeLinkElement10.Text);
                Assert.Equal("ARTICLES", NavBarArticlesLinkElement10.Text);
                Assert.Equal("ABOUT", NavBarAboutLinkElement10.Text);
                Assert.Equal("HELP CENTER", NavBarHelpLinkElement10.Text);
                Assert.Equal(UserEmail.ToString().ToUpper(), NavBarRegisterLinkElement10.Text);
                Assert.Equal("LOGOUT", NavBarLogoutLinkElement10.Text);
            }, filename, driver);
        }
    }
}
