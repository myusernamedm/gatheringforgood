using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace GatheringForGood.UITests
{
    public class TestResetPasswordFlow
    {
        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckResetPasswordPageFlowWorks()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestResetPasswordFlow_CheckResetPasswordPageFlowWorks";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string LoginPageUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();

                driver.Navigate().GoToUrl(LoginPageUrl);
                driver.Manage().Window.Maximize();
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginPageBanner")));
                IWebElement LoginForgotPasswordLink = driver.FindElement(By.Id("LoginForgotPasswordLink"));

                LoginForgotPasswordLink.Click();

                IWebElement _ForgotPasswordPageEmailInput = driver.FindElement(By.Id("_ForgotPasswordPageEmailInput"));
                IWebElement _ForgotPasswordPageSubmitButton = driver.FindElement(By.Id("_ForgotPasswordPageSubmitButton"));
                _ForgotPasswordPageEmailInput.Clear();
                _ForgotPasswordPageEmailInput.SendKeys("test@email.com");
                _ForgotPasswordPageSubmitButton.Click();
                IWebElement ForgotPswdConfirmationEmailHeading = driver.FindElement(By.Id("ForgotPswdConfirmationEmailHeading"));
                Assert.True(ForgotPswdConfirmationEmailHeading.Displayed);
                string ResetPasswordPageUrl = UrlRefLibrary.GetResetPasswordPageLocalHostUrl();
                driver.Navigate().GoToUrl(ResetPasswordPageUrl);
                IWebElement _ResetPswdPageEmailInputField = driver.FindElement(By.Id("_ResetPswdPageEmailInputField"));
                IWebElement _ResetPswdPagePasswordInputField = driver.FindElement(By.Id("_ResetPswdPagePasswordInputField"));
                IWebElement _ResetPswdPageConfirmPasswordInputField = driver.FindElement(By.Id("_ResetPswdPageConfirmPasswordInputField"));
                _ResetPswdPageEmailInputField.Clear();
                _ResetPswdPageEmailInputField.SendKeys("test@email.com");
                _ResetPswdPagePasswordInputField.Clear();
                _ResetPswdPagePasswordInputField.SendKeys("Test1234#");
                _ResetPswdPageConfirmPasswordInputField.Clear();
                _ResetPswdPageConfirmPasswordInputField.SendKeys("Test1234#");
                _ResetPswdPageEmailInputField.Clear();
                _ResetPswdPagePasswordInputField.Clear();
                _ResetPswdPageConfirmPasswordInputField.Clear();

            }, filename, driver);
        }
    }
}
