using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using UITestStringsLibrary;
using OpenQA.Selenium.Support.UI;

namespace GatheringForGood.UITests
{
    public class TestPagesLoadAndTitles
    {
        readonly CrossPageSharedUITestStrings UITestStrings = new UITestStringsLibrary.CrossPageSharedUITestStrings();

        [Fact]
        [Trait("Category", "Smoke Logged Out")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void LoadHomePageCheckTitle()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestPagesLoadAndTitles_LoadHomePageCheckTitle";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

            driver.Navigate().GoToUrl(HomeUrl);
            driver.Manage().Window.Maximize();

            Assert.Equal("Change The World - GatheringForGood", driver.Title);
            Assert.Equal(HomeUrl, driver.Url);
            }, filename, driver);
        }

        //Re-enable when Newsfeed page is implemented
        /*
        [Fact]
        [Trait("Category", "Smoke Logged In")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void LoadFeaturesPageCheckTitle()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestPagesLoadAndTitles_LoadFeaturesPageCheckTitle";

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

            Assert.Equal("NewsFeed - GatheringForGood", driver.Title);
            Assert.Equal(NewsfeedUrl, driver.Url);
            }, filename, driver);
        }
        */

        [Fact]
        [Trait("Category", "Smoke Logged Out")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void LoadAboutPageCheckTitle()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestPagesLoadAndTitles_LoadAboutPageCheckTitle";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string AboutUrl = UrlRefLibrary.GetAboutPageLocalHostUrl();

            driver.Navigate().GoToUrl(AboutUrl);
            driver.Manage().Window.Maximize();

            Assert.Equal("About Us - GatheringForGood", driver.Title);
            Assert.Equal(AboutUrl, driver.Url);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "Smoke Logged In")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void LoadHelpPageCheckTitle()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestPagesLoadAndTitles_LoadHelpPageCheckTitle";

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

            Assert.Equal("Help Center - GatheringForGood", driver.Title);
            Assert.Equal(HelpUrl, driver.Url);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "Smoke Logged Out")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void LoadRegisterPageCheckTitle()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestPagesLoadAndTitles_LoadRegisterPageCheckTitle";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string RegisterUrl = UrlRefLibrary.GetRegisterPageLocalHostUrl();

            driver.Navigate().GoToUrl(RegisterUrl);
            driver.Manage().Window.Maximize();

            Assert.Equal("Register - GatheringForGood", driver.Title);
            Assert.Equal(RegisterUrl, driver.Url);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "Smoke Logged Out")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void LoadLoginPageCheckTitle()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestPagesLoadAndTitles_LoadLoginPageCheckTitle";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();

            driver.Navigate().GoToUrl(LoginUrl);
            driver.Manage().Window.Maximize();

            Assert.Equal("Login - GatheringForGood", driver.Title);
            Assert.Equal(LoginUrl, driver.Url);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "Smoke Logged In")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void LoadArticlesPageCheckTitle()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestPagesLoadAndTitles_LoadArticlesPageCheckTitle";

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

            string ArticlesUrl = UrlRefLibrary.GetArticlesPageLocalHostUrl();
            driver.Navigate().GoToUrl(ArticlesUrl);

            Assert.Equal("Articles for Good - GatheringForGood", driver.Title);
            Assert.Equal(ArticlesUrl, driver.Url);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "Smoke Logged Out")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void LoadPrivacyPageCheckTitle()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestPagesLoadAndTitles_LoadPrivacyPageCheckTitle";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string PrivacyUrl = UrlRefLibrary.GetPrivacyPageLocalHostUrl();

            driver.Navigate().GoToUrl(PrivacyUrl);
            driver.Manage().Window.Maximize();

            Assert.Equal("Privacy Policy - GatheringForGood", driver.Title);
            Assert.Equal(PrivacyUrl, driver.Url);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "Smoke Logged Out")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void LoadCookiesPageCheckTitle()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestPagesLoadAndTitles_LoadCookiesPageCheckTitle";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string CookiesUrl = UrlRefLibrary.GetCookiesPageLocalHostUrl();

            driver.Navigate().GoToUrl(CookiesUrl);
            driver.Manage().Window.Maximize();

            Assert.Equal("Cookies Notice - GatheringForGood", driver.Title);
            Assert.Equal(CookiesUrl, driver.Url);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "Smoke Logged Out")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void LoadLockoutPageCheckTitle()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestPagesLoadAndTitles_LoadLockoutPageCheckTitle";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string LockoutUrl = UrlRefLibrary.GetLockoutPageLocalHostUrl();

            driver.Navigate().GoToUrl(LockoutUrl);
            driver.Manage().Window.Maximize();

            Assert.Equal("Account Security - GatheringForGood", driver.Title);
            Assert.Equal(LockoutUrl, driver.Url);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "Smoke Logged Out")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void LoadRegisterConfPageCheckTitle()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestPagesLoadAndTitles_LoadRegisterConfPageCheckTitle";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string RegisterConfUrl = UrlRefLibrary.GetRegisterConfPageLocalHostUrl();

            driver.Navigate().GoToUrl(RegisterConfUrl);
            driver.Manage().Window.Maximize();

            Assert.Equal("Register Confirmation - GatheringForGood", driver.Title);
            Assert.Equal(RegisterConfUrl, driver.Url);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "Smoke Logged In")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void LoadRGWPageCheckTitle()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestPagesLoadAndTitles_LoadRGWPageCheckTitle";

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

                string RGWUrl = UrlRefLibrary.GetReduceGlobalWarmingPageLocalHostUrl();
                driver.Navigate().GoToUrl(RGWUrl);

                Assert.Equal("Reduce Global Warming - GatheringForGood", driver.Title);
                Assert.Equal(RGWUrl, driver.Url);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "Smoke Logged In")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void LoadAccountManagePageCheckTitle()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestPagesLoadAndTitles_LoadAccountManagePageCheckTitle";

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

                Assert.Equal("My Account - GatheringForGood", driver.Title);
                Assert.Equal(AccountManageUrl, driver.Url);
            }, filename, driver);
        }
    }
}