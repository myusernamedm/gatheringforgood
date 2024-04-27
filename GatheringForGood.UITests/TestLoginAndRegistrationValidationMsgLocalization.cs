using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using UITestStringsLibrary;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading;

namespace GatheringForGood.UITests
{
    public class TestLoginAndRegistrationValidationMsgLocalization
    {
        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckLoginPageLocalizedValidations()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestLoginAndRegistrationValidationMsgLocalization_CheckLoginPageLocalizedValidations";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            var TestStringsLibrary = new CrossPageSharedUITestStrings();
            string LoginUrl = UrlRefLibrary.GetDeutschLoginPageLocalHostUrl();
            var EmailFieldRequired = TestStringsLibrary.EmailFieldRequiredValidationDeutsch().ToUpper();
            var EmailFieldNotValid = TestStringsLibrary.EmailFieldNotValidValidationDeutsch().ToUpper();

            driver.Navigate().GoToUrl(LoginUrl);
            driver.Manage().Window.Maximize();
            IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
            IWebElement LoginEmailValidationLabel = driver.FindElement(By.Id("LoginEmailValidationLabel"));
            IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
            IWebElement LoginPasswordValidationLabel = driver.FindElement(By.Id("LoginPasswordValidationLabel"));

            LoginEmailInputField.Clear();
            LoginEmailInputField.SendKeys("1234");
            LoginEmailInputField.SendKeys(Keys.Tab);
            Assert.Equal(LoginEmailValidationLabel.Text, EmailFieldNotValid);
            LoginEmailInputField.Clear();   
            LoginEmailInputField.SendKeys(Keys.Tab);
            Assert.Equal(LoginEmailValidationLabel.Text, EmailFieldRequired);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckRegistrationPageLocalizationValidations()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestLoginAndRegistrationValidationMsgLocalization_CheckRegistrationPageLocalizationValidations";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            var TestStringsLibrary = new CrossPageSharedUITestStrings();
            string RegistrationUrl = UrlRefLibrary.GetDeutschRegisterPageLocalHostUrl();
            var EmailFieldRequired = TestStringsLibrary.EmailFieldRequiredValidationDeutsch().ToUpper();
            var EmailFieldNotValid = TestStringsLibrary.EmailFieldNotValidValidationDeutsch().ToUpper();
            var PasswordFieldRequired = TestStringsLibrary.PasswordFieldRequiredValidationDeutsch().ToUpper();
            var PasswordFieldMustBe = TestStringsLibrary.PasswordFieldMustBeValidationDeutsch().ToUpper();
            var PasswordFieldsMustMatch = TestStringsLibrary.PasswordFieldsMustMatchValidationDeutsch().ToUpper();

            driver.Navigate().GoToUrl(RegistrationUrl);
            driver.Manage().Window.Maximize();
            IWebElement RegistrationEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("RegistrationEmailInputField")));
            IWebElement RegistrationEmailValidationLabel = driver.FindElement(By.Id("RegistrationEmailValidationLabel"));
            IWebElement RegistrationPasswordInputField = driver.FindElement(By.Id("RegistrationPasswordInputField"));
            IWebElement RegistrationPasswordValidationLabel = driver.FindElement(By.Id("RegistrationPasswordValidationLabel"));
            IWebElement RegistrationConfirmPasswordInputField = driver.FindElement(By.Id("RegistrationConfirmPasswordInputField"));
            IWebElement RegistrationConfirmPasswordValidationLabel = driver.FindElement(By.Id("RegistrationConfirmPasswordValidationLabel"));

            Assert.False(RegistrationEmailValidationLabel.Displayed);
            Assert.False(RegistrationPasswordValidationLabel.Displayed);
            Assert.False(RegistrationConfirmPasswordValidationLabel.Displayed);

            RegistrationEmailInputField.Clear();
            RegistrationEmailInputField.SendKeys("1234");
            RegistrationEmailInputField.SendKeys(Keys.Tab);
            Assert.Equal(RegistrationEmailValidationLabel.Text, EmailFieldNotValid);

            RegistrationEmailInputField.Clear();
            RegistrationEmailInputField.SendKeys(Keys.Tab);
            Assert.Equal(RegistrationEmailValidationLabel.Text, EmailFieldRequired);

            RegistrationConfirmPasswordInputField.Clear();
            RegistrationConfirmPasswordInputField.SendKeys("1234");
            RegistrationConfirmPasswordInputField.SendKeys(Keys.Tab);
            Assert.Equal(RegistrationConfirmPasswordValidationLabel.Text, PasswordFieldsMustMatch);
            }, filename, driver);
        }
    }
}
