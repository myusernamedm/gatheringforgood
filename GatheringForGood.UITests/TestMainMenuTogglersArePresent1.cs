using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using UITestStringsLibrary;
using OpenQA.Selenium.Support.UI;
using System.Drawing;
using System.Threading;
using OpenQA.Selenium.Support.Extensions;
using Microsoft.AspNetCore.Identity;

namespace GatheringForGood.UITests
{
    public class TestMainMenuTogglersArePresent
    {
        [Fact]
        [Trait("Category", "Smoke Logged In")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("Runtime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckMainMenuTogglerForHomePage()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestMainMenuTogglersArePresent_CheckMainMenuTogglerForHomePage";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                var CrossPageSharedUITestStrings = new CrossPageSharedUITestStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();
                string NewsfeedUrl = UrlRefLibrary.GetNewsfeedPageLocalHostUrl();
                string AboutUrl = UrlRefLibrary.GetAboutPageLocalHostUrl();
                string HelpUrl = UrlRefLibrary.GetHelpPageLocalHostUrl();
                string ReduceGlobalWarmingUrl = UrlRefLibrary.GetReduceGlobalWarmingPageLocalHostUrl();
                string RegisterUrl = UrlRefLibrary.GetRegisterPageLocalHostUrl();
                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                string ArticlesUrl = UrlRefLibrary.GetArticlesPageLocalHostUrl();
                string PrivacyUrl = UrlRefLibrary.GetPrivacyPageLocalHostUrl();
                string CookiesUrl = UrlRefLibrary.GetCookiesPageLocalHostUrl();
                var js = (IJavaScriptExecutor)driver;

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();
                Thread.Sleep(1000);
                IWebElement _HomePageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_HomePageHomeNavLink")));
                //Re-enable below when using Newsfeed page again
                //driver.Navigate().GoToUrl(NewsfeedUrl);
                //IWebElement _NewsfeedPageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_NewsfeedPageHomeNavLink")));
                driver.Navigate().GoToUrl(AboutUrl);
                IWebElement _AboutPageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_AboutPageHomeNavLink")));
                driver.Navigate().GoToUrl(PrivacyUrl);
                IWebElement _PrivacyPageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_PrivacyPageHomeNavLink")));
                driver.Navigate().GoToUrl(CookiesUrl);
                IWebElement _CookiesPageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_CookiesPageHomeNavLink")));
                driver.Navigate().GoToUrl(RegisterUrl);
                IWebElement _RegisterPageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_RegisterPageHomeNavLink")));
                driver.Navigate().GoToUrl(LoginUrl);
                IWebElement _LoginPageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPageHomeNavLink")));

                IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
                IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
                IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));
                string UserEmail = CrossPageSharedUITestStrings.Test2UserEmail();
                string UserPassword = CrossPageSharedUITestStrings.Test2UserPassword();

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
                IWebElement _HelpPageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_HelpPageHomeNavLink")));
                driver.Navigate().GoToUrl(ArticlesUrl);
                IWebElement _ArticlesPageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_ArticlesPageHomeNavLink")));
                driver.Navigate().GoToUrl(ReduceGlobalWarmingUrl);
                IWebElement _RGWPageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_RGWPageHomeNavLink")));

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Size = new Size(240, 600);

                Thread.Sleep(1000);
                IWebElement NavBarToggler = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_HomePageNavBarToggler")));
                IWebElement _HomePageHomeNavLink1 = driver.FindElement(By.Id("_HomePageHomeNavLink"));
                Assert.False(_HomePageHomeNavLink1.Displayed);
                Assert.True(NavBarToggler.Displayed);
                NavBarToggler.Click();
                Thread.Sleep(1000);
                NavBarToggler.Click();
                Thread.Sleep(1000);
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);
                Assert.True(_HomePageHomeNavLink1.Displayed);

            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "Smoke Logged In")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("Runtime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckMainMenuTogglerForNewsfeedPage()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestMainMenuTogglersArePresent_CheckMainMenuTogglerForNewsfeedPage";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                var CrossPageSharedUITestStrings = new CrossPageSharedUITestStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();
                string NewsfeedUrl = UrlRefLibrary.GetNewsfeedPageLocalHostUrl();
                string AboutUrl = UrlRefLibrary.GetAboutPageLocalHostUrl();
                string HelpUrl = UrlRefLibrary.GetHelpPageLocalHostUrl();
                string ReduceGlobalWarmingUrl = UrlRefLibrary.GetReduceGlobalWarmingPageLocalHostUrl();
                string RegisterUrl = UrlRefLibrary.GetRegisterPageLocalHostUrl();
                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                string ArticlesUrl = UrlRefLibrary.GetArticlesPageLocalHostUrl();
                string PrivacyUrl = UrlRefLibrary.GetPrivacyPageLocalHostUrl();
                string CookiesUrl = UrlRefLibrary.GetCookiesPageLocalHostUrl();
                var js = (IJavaScriptExecutor)driver;

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();
                Thread.Sleep(1000);
                IWebElement _HomePageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_HomePageHomeNavLink")));
                driver.Navigate().GoToUrl(LoginUrl);
                IWebElement _LoginPageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPageHomeNavLink")));

                IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
                IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
                IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));
                string UserEmail = CrossPageSharedUITestStrings.Test2UserEmail();
                string UserPassword = CrossPageSharedUITestStrings.Test2UserPassword();

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Keys.Tab);
                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Keys.Tab);
                LoginEmailInputField.SendKeys(UserEmail);
                LoginPasswordInputField.SendKeys(UserPassword);

                LoginButton.Click();

                IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                //Re-enable below when using Newsfeed page again
                //driver.Navigate().GoToUrl(NewsfeedUrl);
                //driver.Manage().Window.Size = new Size(240, 600);
                //Thread.Sleep(1000);
                //IWebElement _NewsfeedPageNavBarToggler = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_NewsfeedPageNavBarToggler")));
                //IWebElement _NewsfeedPageHomeNavLink1 = driver.FindElement(By.Id("_NewsfeedPageHomeNavLink"));
                //Assert.False(_NewsfeedPageHomeNavLink1.Displayed);
                //Assert.True(_NewsfeedPageNavBarToggler.Displayed);
                //_NewsfeedPageNavBarToggler.Click();
                //Thread.Sleep(1000);
                //_NewsfeedPageNavBarToggler.Click();
                //Thread.Sleep(1000);
                //driver.Manage().Window.Maximize();
                //Thread.Sleep(2000);
                //Assert.True(_NewsfeedPageHomeNavLink1.Displayed);


            }, filename, driver);
        }


        [Fact]
        [Trait("Category", "Smoke Logged In")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("Runtime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckMainMenuTogglerForAboutPage()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestMainMenuTogglersArePresent_CheckMainMenuTogglerForAboutPage";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                var CrossPageSharedUITestStrings = new CrossPageSharedUITestStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();
                string NewsfeedUrl = UrlRefLibrary.GetNewsfeedPageLocalHostUrl();
                string AboutUrl = UrlRefLibrary.GetAboutPageLocalHostUrl();
                string HelpUrl = UrlRefLibrary.GetHelpPageLocalHostUrl();
                string ReduceGlobalWarmingUrl = UrlRefLibrary.GetReduceGlobalWarmingPageLocalHostUrl();
                string RegisterUrl = UrlRefLibrary.GetRegisterPageLocalHostUrl();
                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                string ArticlesUrl = UrlRefLibrary.GetArticlesPageLocalHostUrl();
                string PrivacyUrl = UrlRefLibrary.GetPrivacyPageLocalHostUrl();
                string CookiesUrl = UrlRefLibrary.GetCookiesPageLocalHostUrl();
                var js = (IJavaScriptExecutor)driver;

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();
                Thread.Sleep(1000);
                IWebElement _HomePageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_HomePageHomeNavLink")));
                driver.Navigate().GoToUrl(LoginUrl);
                IWebElement _LoginPageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPageHomeNavLink")));

                IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
                IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
                IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));
                string UserEmail = CrossPageSharedUITestStrings.Test2UserEmail();
                string UserPassword = CrossPageSharedUITestStrings.Test2UserPassword();

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Keys.Tab);
                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Keys.Tab);
                LoginEmailInputField.SendKeys(UserEmail);
                LoginPasswordInputField.SendKeys(UserPassword);

                LoginButton.Click();

                IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                driver.Navigate().GoToUrl(AboutUrl);
                driver.Manage().Window.Size = new Size(240, 600);

                Thread.Sleep(1000);
                IWebElement _AboutPageNavBarToggler = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_AboutPageNavBarToggler")));
                IWebElement _AboutPageHomeNavLink1 = driver.FindElement(By.Id("_AboutPageHomeNavLink"));
                Assert.False(_AboutPageHomeNavLink1.Displayed);
                Assert.True(_AboutPageNavBarToggler.Displayed);
                _AboutPageNavBarToggler.Click();
                Thread.Sleep(1000);
                _AboutPageNavBarToggler.Click();
                Thread.Sleep(1000);
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);
                Assert.True(_AboutPageHomeNavLink1.Displayed);

            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "Smoke Logged In")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("Runtime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckMainMenuTogglerForPrivacyPage()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestMainMenuTogglersArePresent_CheckMainMenuTogglerForPrivacyPage";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                var CrossPageSharedUITestStrings = new CrossPageSharedUITestStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();
                string NewsfeedUrl = UrlRefLibrary.GetNewsfeedPageLocalHostUrl();
                string AboutUrl = UrlRefLibrary.GetAboutPageLocalHostUrl();
                string HelpUrl = UrlRefLibrary.GetHelpPageLocalHostUrl();
                string ReduceGlobalWarmingUrl = UrlRefLibrary.GetReduceGlobalWarmingPageLocalHostUrl();
                string RegisterUrl = UrlRefLibrary.GetRegisterPageLocalHostUrl();
                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                string ArticlesUrl = UrlRefLibrary.GetArticlesPageLocalHostUrl();
                string PrivacyUrl = UrlRefLibrary.GetPrivacyPageLocalHostUrl();
                string CookiesUrl = UrlRefLibrary.GetCookiesPageLocalHostUrl();
                var js = (IJavaScriptExecutor)driver;

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();
                Thread.Sleep(1000);
                IWebElement _HomePageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_HomePageHomeNavLink")));
                driver.Navigate().GoToUrl(LoginUrl);
                IWebElement _LoginPageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPageHomeNavLink")));

                IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
                IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
                IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));
                string UserEmail = CrossPageSharedUITestStrings.Test2UserEmail();
                string UserPassword = CrossPageSharedUITestStrings.Test2UserPassword();

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Keys.Tab);
                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Keys.Tab);
                LoginEmailInputField.SendKeys(UserEmail);
                LoginPasswordInputField.SendKeys(UserPassword);

                LoginButton.Click();

                IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                driver.Navigate().GoToUrl(PrivacyUrl);
                driver.Manage().Window.Size = new Size(240, 600);

                Thread.Sleep(1000);
                IWebElement _PrivacyPageNavBarToggler = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_PrivacyPageNavBarToggler")));
                IWebElement _PrivacyPageHomeNavLink1 = driver.FindElement(By.Id("_PrivacyPageHomeNavLink"));
                Assert.False(_PrivacyPageHomeNavLink1.Displayed);
                Assert.True(_PrivacyPageNavBarToggler.Displayed);
                _PrivacyPageNavBarToggler.Click();
                Thread.Sleep(1000);
                _PrivacyPageNavBarToggler.Click();
                Thread.Sleep(1000);
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);
                Assert.True(_PrivacyPageHomeNavLink1.Displayed);

            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "Smoke Logged In")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("Runtime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckMainMenuTogglerForRegisterPage()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestMainMenuTogglersArePresent_CheckMainMenuTogglerForRegisterPage";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                var CrossPageSharedUITestStrings = new CrossPageSharedUITestStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();
                string NewsfeedUrl = UrlRefLibrary.GetNewsfeedPageLocalHostUrl();
                string AboutUrl = UrlRefLibrary.GetAboutPageLocalHostUrl();
                string HelpUrl = UrlRefLibrary.GetHelpPageLocalHostUrl();
                string ReduceGlobalWarmingUrl = UrlRefLibrary.GetReduceGlobalWarmingPageLocalHostUrl();
                string RegisterUrl = UrlRefLibrary.GetRegisterPageLocalHostUrl();
                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                string ArticlesUrl = UrlRefLibrary.GetArticlesPageLocalHostUrl();
                string PrivacyUrl = UrlRefLibrary.GetPrivacyPageLocalHostUrl();
                string CookiesUrl = UrlRefLibrary.GetCookiesPageLocalHostUrl();
                var js = (IJavaScriptExecutor)driver;

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();
                Thread.Sleep(1000);
                IWebElement _HomePageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_HomePageHomeNavLink")));
                driver.Navigate().GoToUrl(LoginUrl);
                IWebElement _LoginPageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPageHomeNavLink")));

                IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
                IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
                IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));
                string UserEmail = CrossPageSharedUITestStrings.Test2UserEmail();
                string UserPassword = CrossPageSharedUITestStrings.Test2UserPassword();

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Keys.Tab);
                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Keys.Tab);
                LoginEmailInputField.SendKeys(UserEmail);
                LoginPasswordInputField.SendKeys(UserPassword);

                LoginButton.Click();

                IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                driver.Navigate().GoToUrl(RegisterUrl);
                driver.Manage().Window.Size = new Size(240, 600);

                Thread.Sleep(1000);
                IWebElement _RegisterPageNavBarToggler = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_RegisterPageNavBarToggler")));
                IWebElement _RegisterPageHomeNavLink1 = driver.FindElement(By.Id("_RegisterPageHomeNavLink"));
                Assert.False(_RegisterPageHomeNavLink1.Displayed);
                Assert.True(_RegisterPageNavBarToggler.Displayed);
                _RegisterPageNavBarToggler.Click();
                Thread.Sleep(1000);
                _RegisterPageNavBarToggler.Click();
                Thread.Sleep(1000);
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);
                Assert.True(_RegisterPageHomeNavLink1.Displayed);

            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "Smoke Logged In")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("Runtime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckMainMenuTogglerForHelpPage()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestMainMenuTogglersArePresent_CheckMainMenuTogglerForHelpPage";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                var CrossPageSharedUITestStrings = new CrossPageSharedUITestStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();
                string NewsfeedUrl = UrlRefLibrary.GetNewsfeedPageLocalHostUrl();
                string AboutUrl = UrlRefLibrary.GetAboutPageLocalHostUrl();
                string HelpUrl = UrlRefLibrary.GetHelpPageLocalHostUrl();
                string ReduceGlobalWarmingUrl = UrlRefLibrary.GetReduceGlobalWarmingPageLocalHostUrl();
                string RegisterUrl = UrlRefLibrary.GetRegisterPageLocalHostUrl();
                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                string ArticlesUrl = UrlRefLibrary.GetArticlesPageLocalHostUrl();
                string PrivacyUrl = UrlRefLibrary.GetPrivacyPageLocalHostUrl();
                string CookiesUrl = UrlRefLibrary.GetCookiesPageLocalHostUrl();
                var js = (IJavaScriptExecutor)driver;

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();
                Thread.Sleep(1000);
                IWebElement _HomePageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_HomePageHomeNavLink")));
                driver.Navigate().GoToUrl(LoginUrl);
                IWebElement _LoginPageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPageHomeNavLink")));

                IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
                IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
                IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));
                string UserEmail = CrossPageSharedUITestStrings.Test2UserEmail();
                string UserPassword = CrossPageSharedUITestStrings.Test2UserPassword();

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
                driver.Manage().Window.Size = new Size(240, 600);

                Thread.Sleep(1000);
                IWebElement _HelpPageNavBarToggler = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_HelpPageNavBarToggler")));
                IWebElement _HelpPageHomeNavLink1 = driver.FindElement(By.Id("_HelpPageHomeNavLink"));
                Assert.False(_HelpPageHomeNavLink1.Displayed);
                Assert.True(_HelpPageNavBarToggler.Displayed);
                _HelpPageNavBarToggler.Click();
                Thread.Sleep(1000);
                _HelpPageNavBarToggler.Click();
                Thread.Sleep(1000);
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);
                Assert.True(_HelpPageHomeNavLink1.Displayed);

            }, filename, driver);
        }


        [Fact]
        [Trait("Category", "Smoke Logged In")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("Runtime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckMainMenuTogglerForRGWPage()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestMainMenuTogglersArePresent_CheckMainMenuTogglerForRGWPage";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                var CrossPageSharedUITestStrings = new CrossPageSharedUITestStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();
                string NewsfeedUrl = UrlRefLibrary.GetNewsfeedPageLocalHostUrl();
                string AboutUrl = UrlRefLibrary.GetAboutPageLocalHostUrl();
                string HelpUrl = UrlRefLibrary.GetHelpPageLocalHostUrl();
                string ReduceGlobalWarmingUrl = UrlRefLibrary.GetReduceGlobalWarmingPageLocalHostUrl();
                string RegisterUrl = UrlRefLibrary.GetRegisterPageLocalHostUrl();
                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                string ArticlesUrl = UrlRefLibrary.GetArticlesPageLocalHostUrl();
                string PrivacyUrl = UrlRefLibrary.GetPrivacyPageLocalHostUrl();
                string CookiesUrl = UrlRefLibrary.GetCookiesPageLocalHostUrl();
                var js = (IJavaScriptExecutor)driver;

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();
                Thread.Sleep(1000);
                IWebElement _HomePageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_HomePageHomeNavLink")));
                driver.Navigate().GoToUrl(LoginUrl);
                IWebElement _LoginPageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPageHomeNavLink")));

                IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
                IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
                IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));
                string UserEmail = CrossPageSharedUITestStrings.Test2UserEmail();
                string UserPassword = CrossPageSharedUITestStrings.Test2UserPassword();

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Keys.Tab);
                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Keys.Tab);
                LoginEmailInputField.SendKeys(UserEmail);
                LoginPasswordInputField.SendKeys(UserPassword);

                LoginButton.Click();

                IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                driver.Navigate().GoToUrl(ReduceGlobalWarmingUrl);
                driver.Manage().Window.Size = new Size(240, 600);

                Thread.Sleep(1000);
                IWebElement _RGWPageNavBarToggler = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_RGWPageNavBarToggler")));
                IWebElement _RGWPageHomeNavLink1 = driver.FindElement(By.Id("_RGWPageHomeNavLink"));
                Assert.False(_RGWPageHomeNavLink1.Displayed);
                Assert.True(_RGWPageNavBarToggler.Displayed);
                _RGWPageNavBarToggler.Click();
                Thread.Sleep(1000);
                _RGWPageNavBarToggler.Click();
                Thread.Sleep(1000);
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);
                Assert.True(_RGWPageHomeNavLink1.Displayed);

            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "Smoke Logged In")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("Runtime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckMainMenuTogglerForCookiesPage()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestMainMenuTogglersArePresent_CheckMainMenuTogglerForCookiesPage";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                var CrossPageSharedUITestStrings = new CrossPageSharedUITestStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();
                string NewsfeedUrl = UrlRefLibrary.GetNewsfeedPageLocalHostUrl();
                string AboutUrl = UrlRefLibrary.GetAboutPageLocalHostUrl();
                string HelpUrl = UrlRefLibrary.GetHelpPageLocalHostUrl();
                string ReduceGlobalWarmingUrl = UrlRefLibrary.GetReduceGlobalWarmingPageLocalHostUrl();
                string RegisterUrl = UrlRefLibrary.GetRegisterPageLocalHostUrl();
                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                string ArticlesUrl = UrlRefLibrary.GetArticlesPageLocalHostUrl();
                string PrivacyUrl = UrlRefLibrary.GetPrivacyPageLocalHostUrl();
                string CookiesUrl = UrlRefLibrary.GetCookiesPageLocalHostUrl();
                var js = (IJavaScriptExecutor)driver;

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();
                Thread.Sleep(1000);
                IWebElement _HomePageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_HomePageHomeNavLink")));
                driver.Navigate().GoToUrl(LoginUrl);
                IWebElement _LoginPageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPageHomeNavLink")));

                IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
                IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
                IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));
                string UserEmail = CrossPageSharedUITestStrings.Test2UserEmail();
                string UserPassword = CrossPageSharedUITestStrings.Test2UserPassword();

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Keys.Tab);
                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Keys.Tab);
                LoginEmailInputField.SendKeys(UserEmail);
                LoginPasswordInputField.SendKeys(UserPassword);

                LoginButton.Click();

                IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                driver.Navigate().GoToUrl(CookiesUrl);
                driver.Manage().Window.Size = new Size(240, 600);

                Thread.Sleep(1000);
                IWebElement _CookiesPageNavBarToggler = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_CookiesPageNavBarToggler")));
                IWebElement _CookiesPageHomeNavLink1 = driver.FindElement(By.Id("_CookiesPageHomeNavLink"));
                Assert.False(_CookiesPageHomeNavLink1.Displayed);
                Assert.True(_CookiesPageNavBarToggler.Displayed);
                _CookiesPageNavBarToggler.Click();
                Thread.Sleep(1000);
                _CookiesPageNavBarToggler.Click();
                Thread.Sleep(1000);
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);
                Assert.True(_CookiesPageHomeNavLink1.Displayed);

            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "Smoke Logged In")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("Runtime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckMainMenuTogglerForBlogPage()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestMainMenuTogglersArePresent_CheckMainMenuTogglerForBlogPage";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                var CrossPageSharedUITestStrings = new CrossPageSharedUITestStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();
                string NewsfeedUrl = UrlRefLibrary.GetNewsfeedPageLocalHostUrl();
                string AboutUrl = UrlRefLibrary.GetAboutPageLocalHostUrl();
                string HelpUrl = UrlRefLibrary.GetHelpPageLocalHostUrl();
                string ReduceGlobalWarmingUrl = UrlRefLibrary.GetReduceGlobalWarmingPageLocalHostUrl();
                string RegisterUrl = UrlRefLibrary.GetRegisterPageLocalHostUrl();
                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                string ArticlesUrl = UrlRefLibrary.GetArticlesPageLocalHostUrl();
                string PrivacyUrl = UrlRefLibrary.GetPrivacyPageLocalHostUrl();
                string CookiesUrl = UrlRefLibrary.GetCookiesPageLocalHostUrl();
                var js = (IJavaScriptExecutor)driver;

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();

                IWebElement _HomePageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_HomePageHomeNavLink")));
                driver.Navigate().GoToUrl(LoginUrl);
                IWebElement _LoginPageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPageHomeNavLink")));

                IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
                IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
                IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));
                string UserEmail = CrossPageSharedUITestStrings.Test2UserEmail();
                string UserPassword = CrossPageSharedUITestStrings.Test2UserPassword();

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Keys.Tab);
                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Keys.Tab);
                LoginEmailInputField.SendKeys(UserEmail);
                LoginPasswordInputField.SendKeys(UserPassword);

                LoginButton.Click();

                IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                driver.Navigate().GoToUrl(ArticlesUrl);
                driver.Manage().Window.Size = new Size(240, 600);

                Thread.Sleep(1000);
                IWebElement _ArticlesPageNavBarToggler = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_ArticlesPageNavBarToggler")));
                IWebElement _ArticlesPageHomeNavLink1 = driver.FindElement(By.Id("_ArticlesPageHomeNavLink"));
                Assert.False(_ArticlesPageHomeNavLink1.Displayed);
                Assert.True(_ArticlesPageNavBarToggler.Displayed);
                _ArticlesPageNavBarToggler.Click();
                Thread.Sleep(1000);
                _ArticlesPageNavBarToggler.Click();
                Thread.Sleep(1000);
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);
                Assert.True(_ArticlesPageHomeNavLink1.Displayed);

            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "Smoke Logged In")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("Runtime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckMainMenuTogglerForAccountManagePage()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestMainMenuTogglersArePresent_CheckMainMenuTogglerForAccountManagePage";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                var CrossPageSharedUITestStrings = new CrossPageSharedUITestStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();
                string NewsfeedUrl = UrlRefLibrary.GetNewsfeedPageLocalHostUrl();
                string AboutUrl = UrlRefLibrary.GetAboutPageLocalHostUrl();
                string HelpUrl = UrlRefLibrary.GetHelpPageLocalHostUrl();
                string AccountManageUrl = UrlRefLibrary.GetAccountManagePageLocalHostUrl();
                string RegisterUrl = UrlRefLibrary.GetRegisterPageLocalHostUrl();
                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                string ArticlesUrl = UrlRefLibrary.GetArticlesPageLocalHostUrl();
                string PrivacyUrl = UrlRefLibrary.GetPrivacyPageLocalHostUrl();
                string CookiesUrl = UrlRefLibrary.GetCookiesPageLocalHostUrl();
                var js = (IJavaScriptExecutor)driver;

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();
                Thread.Sleep(1000);
                IWebElement _HomePageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_HomePageHomeNavLink")));
                driver.Navigate().GoToUrl(LoginUrl);
                IWebElement _LoginPageHomeNavLink = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPageHomeNavLink")));

                IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
                IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
                IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));
                string UserEmail = CrossPageSharedUITestStrings.Test2UserEmail();
                string UserPassword = CrossPageSharedUITestStrings.Test2UserPassword();

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Keys.Tab);
                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Keys.Tab);
                LoginEmailInputField.SendKeys(UserEmail);
                LoginPasswordInputField.SendKeys(UserPassword);

                LoginButton.Click();

                IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                driver.Navigate().GoToUrl(AccountManageUrl);
                driver.Manage().Window.Size = new Size(240, 600);

                Thread.Sleep(1000);
                IWebElement _RGWPageNavBarToggler = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_AccountManagePageNavBarToggler")));
                IWebElement _RGWPageHomeNavLink1 = driver.FindElement(By.Id("_AccountManagePageHomeNavLink"));
                Assert.False(_RGWPageHomeNavLink1.Displayed);
                Assert.True(_RGWPageNavBarToggler.Displayed);
                _RGWPageNavBarToggler.Click();
                Thread.Sleep(1000);
                _RGWPageNavBarToggler.Click();
                Thread.Sleep(1000);
                driver.Manage().Window.Maximize();
                Thread.Sleep(2000);
                Assert.True(_RGWPageHomeNavLink1.Displayed);

            }, filename, driver);
        }
    }
}

