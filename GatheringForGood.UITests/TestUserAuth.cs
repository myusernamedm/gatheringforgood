using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using OpenQA.Selenium.Support.UI;
using UITestStringsLibrary;
using LocSourceNameReferenceLibrary;
using System.Threading;

namespace GatheringForGood.UITests
{
    public class TestUserAuth
    {
        readonly CrossPageSharedUITestStrings UITestStrings = new UITestStringsLibrary.CrossPageSharedUITestStrings();
        readonly SharedCrossPageLocSourceNames SharedLocSourceNames = new LocSourceNameReferenceLibrary.SharedCrossPageLocSourceNames();
        readonly LoginPageLocSourceNames LoginPageLocSourceNames = new LocSourceNameReferenceLibrary.LoginPageLocSourceNames();

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void SuccessfulUserLoginLogout()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestRegisterPageComponentsArePresent_SuccessfulUserLoginLogout";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
            string UserEmail = UITestStrings.Test2UserEmail();
            string UserPassword = UITestStrings.Test2UserPassword();
            string Logout = SharedLocSourceNames.GetLocSourceLogoutLabelNameReference();
            string Register = SharedLocSourceNames.GetLocSourceRegisterLabelNameReference();
            string Login = SharedLocSourceNames.GetLocSourceLoginLabelNameReference();
            string HomepageUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

            driver.Navigate().GoToUrl(LoginUrl);
            driver.Manage().Window.Maximize();
            IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
            IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
            IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));

            LoginEmailInputField.Clear();
            LoginEmailInputField.SendKeys(Keys.Tab);
            LoginPasswordInputField.Clear();
            LoginPasswordInputField.SendKeys(Keys.Tab);

            LoginEmailInputField.SendKeys(UserEmail);
            LoginPasswordInputField.SendKeys(UserPassword);

            LoginButton.Click();
            IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
            IWebElement _LoginPartialLogoutButton = driver.FindElement(By.Id("_LoginPartialLogoutButton"));
            String currentUrl = driver.Url;

            Assert.Equal(HomepageUrl, currentUrl);
            Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);
            Assert.True(LoggedInUserLabel.Displayed);
            Assert.Equal(Logout.ToUpper(), _LoginPartialLogoutButton.Text);
            Assert.True(_LoginPartialLogoutButton.Displayed);

            _LoginPartialLogoutButton.Click();

            IWebElement _LoginPartialRegister = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialRegister")));
            IWebElement _LoginPartialLogin = driver.FindElement(By.Id("_LoginPartialLogin"));

            Assert.Equal(HomepageUrl, currentUrl);
            Assert.Equal(Register.ToUpper(), _LoginPartialRegister.Text);
            Assert.True(_LoginPartialRegister.Displayed);
            Assert.Equal(Login.ToUpper(), _LoginPartialLogin.Text);
            Assert.True(_LoginPartialLogin.Displayed);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "Security")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void UnSuccessfulUserLoginEmailStructure()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestRegisterPageComponentsArePresent_UnSuccessfulUserLoginEmailStructure";

            TakeTestFailScreenshot.UITest(() =>
            {
            var UrlRefLibrary = new UrlStrings();
            string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
            string LoginFailedUrl = UrlRefLibrary.GetLoginPageFailedLocalHostUrl();
            string UserEmail = "test2@email";
            string UserEmail1 = "test2";
            string UserPassword = UITestStrings.Test2UserPassword();
            string HeadingText = LoginPageLocSourceNames.GetLocSourceHeadingNameReferenceForLoginPage();

            driver.Navigate().GoToUrl(LoginUrl);
            driver.Manage().Window.Maximize();
            IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
            IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
            IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));

            LoginEmailInputField.Clear();
            LoginEmailInputField.SendKeys(Keys.Tab);
            LoginPasswordInputField.Clear();
            LoginPasswordInputField.SendKeys(Keys.Tab);

            LoginEmailInputField.SendKeys(UserEmail);
            LoginPasswordInputField.SendKeys(UserPassword);

            LoginButton.Click();
            IWebElement LoginHeading = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginHeading")));
            String currentUrl = driver.Url;

            Assert.True(LoginHeading.Displayed);
            Assert.Equal(LoginFailedUrl, currentUrl);

            IWebElement LoginEmailInputField1 = driver.FindElement(By.Id("LoginEmailInputField"));
            IWebElement LoginPasswordInputField1 = driver.FindElement(By.Id("LoginEmailInputField"));
            IWebElement LoginButton1 = driver.FindElement(By.Id("LoginButton"));
            LoginEmailInputField1.Clear();
            LoginEmailInputField1.SendKeys(UserEmail1);
            LoginEmailInputField1.SendKeys(Keys.Tab);
            LoginPasswordInputField1.SendKeys(UserPassword);

            LoginButton1.Click();
            IWebElement LoginHeading1 = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginHeading")));
            String currentUrl1 = driver.Url;

            Assert.Equal(LoginFailedUrl, currentUrl1);
            Assert.Equal(LoginHeading1.Text, HeadingText);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "Security")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void UnSuccessfulUserLoginIncorrectPassword()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestRegisterPageComponentsArePresent_UnSuccessfulUserLoginIncorrectPassword";

            TakeTestFailScreenshot.UITest(() =>
            {
            var UrlRefLibrary = new UrlStrings();
            string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
            string LoginFailedUrl = UrlRefLibrary.GetLoginPageFailedLocalHostUrl();
            string UserEmail = UITestStrings.Test2UserEmail();
            string UserPassword = "Test";
            string HeadingText = LoginPageLocSourceNames.GetLocSourceHeadingNameReferenceForLoginPage();

            driver.Navigate().GoToUrl(LoginUrl);
            driver.Manage().Window.Maximize();
            IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
            IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
            IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));

            LoginEmailInputField.Clear();
            LoginEmailInputField.SendKeys(Keys.Tab);
            LoginPasswordInputField.Clear();
            LoginPasswordInputField.SendKeys(Keys.Tab);

            LoginEmailInputField.SendKeys(UserEmail);
            LoginPasswordInputField.SendKeys(UserPassword);

            LoginButton.Click();
            IWebElement LoginHeading = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginHeading")));
            String currentUrl = driver.Url;

            Assert.Equal(LoginFailedUrl, currentUrl);
            Assert.Equal(LoginHeading.Text, HeadingText);
            }, filename, driver);
        }


    }
}
