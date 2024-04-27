using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Drawing;
using UITestStringsLibrary;
using URLStringsReferenceLibrary;
using Xunit;

namespace GatheringForGood.UITests
{
    public class TestArticleReferralUrlAfterLogin
    {

        readonly CrossPageSharedUITestStrings UITestStrings = new UITestStringsLibrary.CrossPageSharedUITestStrings();


        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckRedirectForCreateArticle()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestArticleReferralUrlAfterLogin_CheckRedirectForCreateArticle";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ArticlesUrl = UrlRefLibrary.GetArticlesPageLocalHostUrl();

                driver.Navigate().GoToUrl(ArticlesUrl);
                driver.Manage().Window.Maximize();
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ArticlesPageBanner")));
                IWebElement ArticlesPageCreateArticleBtn = driver.FindElement(By.Id("ArticlesPageCreateArticleBtn"));

                ArticlesPageCreateArticleBtn.Click();
                IWebElement BannerImageElement1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginPageBanner")));

                Assert.True(BannerImageElement1.Displayed);

                IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
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

                IWebElement CreateArticlesPageBanner = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("CreateArticlesPageBanner")));
                Assert.True(CreateArticlesPageBanner.Displayed);

            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckRedirectForExistingArticle()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestArticleReferralUrlAfterLogin_CheckRedirectForExistingArticle";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ArticlesUrl = UrlRefLibrary.GetArticlesPageLocalHostUrl();

                driver.Navigate().GoToUrl(ArticlesUrl);
                driver.Manage().Window.Maximize();
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ArticlesPageBanner")));
                IWebElement CardDynamicLink = driver.FindElement(By.Id("CardDynamicLink"));

                CardDynamicLink.Click();
                IWebElement BannerImageElement1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginPageBanner")));

                Assert.True(BannerImageElement1.Displayed);

                IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
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

                IWebElement UserArticlesPageBanner = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("UserArticlesPageBanner")));
                Assert.True(UserArticlesPageBanner.Displayed);

            }, filename, driver);
        }
    }
}
