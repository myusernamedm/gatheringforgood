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
    public class TestUserArticlePageComponentsArePresent
    {
        readonly UrlStrings _UrlStrings = new ();
        readonly CrossPageSharedUITestStrings UITestStrings = new ();

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckImagesAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestUserArticlesPageComponentsArePresent_CheckImagesAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                string HomeUrl = _UrlStrings.GetHomePageLocalHostUrl();

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();

                string LoginUrl = _UrlStrings.GetLoginPageLocalHostUrl();
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

                string UserArticlesUrl = _UrlStrings.TestUserArticlePageUrl();

                driver.Navigate().GoToUrl(UserArticlesUrl);
                driver.Manage().Window.Maximize();
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("UserArticlesPageBanner")));
                IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));
                IWebElement _UserArticlesPageLogoImg = driver.FindElement(By.Id("_UserArticlesPageLogoImg"));
                IWebElement UserArticlespageTwitterShareIconImage = driver.FindElement(By.Id("UserArticlespageTwitterShareIconImage"));
                IWebElement UserArticlespageFBShareIconImage = driver.FindElement(By.Id("UserArticlespageFBShareIconImage"));
                IWebElement UserArticlespageLinkedinShareIconImage = driver.FindElement(By.Id("UserArticlespageLinkedinShareIconImage"));
                IWebElement UserArticlePageLikeIconImage = driver.FindElement(By.Id("UserArticlePageLikeIconImage"));
                IWebElement UserArticlePageDislikeIconImage = driver.FindElement(By.Id("UserArticlePageDislikeIconImage"));
                IWebElement UserArticlePageSupportIconImage = driver.FindElement(By.Id("UserArticlePageSupportIconImage"));
                IWebElement UserArticlePageQuestionableIconImage = driver.FindElement(By.Id("UserArticlePageQuestionableIconImage"));
                IWebElement UserArticlePageShockedIconImage = driver.FindElement(By.Id("UserArticlePageShockedIconImage"));
                IWebElement _ArticleTitleImage = driver.FindElement(By.Id("_ArticleTitleImage"));


                Assert.True(BannerImageElement.Displayed);
                Assert.True(_UserArticlesPageLogoImg.Displayed);
                Assert.True(BodyBackground.Displayed);
                Assert.True(UserArticlespageTwitterShareIconImage.Displayed);
                Assert.True(UserArticlespageFBShareIconImage.Displayed);
                Assert.True(UserArticlespageLinkedinShareIconImage.Displayed);
                Assert.True(UserArticlePageLikeIconImage.Displayed);
                Assert.True(UserArticlePageDislikeIconImage.Displayed);
                Assert.True(UserArticlePageSupportIconImage.Displayed);
                Assert.True(UserArticlePageQuestionableIconImage.Displayed);
                Assert.True(UserArticlePageShockedIconImage.Displayed);
                Assert.True(_ArticleTitleImage.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);

                Assert.True(BannerImageElement.Displayed);
                Assert.True(_UserArticlesPageLogoImg.Displayed);
                Assert.True(BodyBackground.Displayed);
                Assert.True(UserArticlespageTwitterShareIconImage.Displayed);
                Assert.True(UserArticlespageFBShareIconImage.Displayed);
                Assert.True(UserArticlespageLinkedinShareIconImage.Displayed);
                Assert.True(UserArticlePageLikeIconImage.Displayed);
                Assert.True(UserArticlePageDislikeIconImage.Displayed);
                Assert.True(UserArticlePageSupportIconImage.Displayed);
                Assert.True(UserArticlePageQuestionableIconImage.Displayed);
                Assert.True(UserArticlePageShockedIconImage.Displayed);
                Assert.True(_ArticleTitleImage.Displayed);

            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckButtonsAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestUserArticlesPageComponentsArePresent_CheckButtonsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                string UserArticlesUrl = _UrlStrings.TestUserArticlePageUrl();
                string LoginUrl = _UrlStrings.GetLoginPageLocalHostUrl();
                driver.Navigate().GoToUrl(LoginUrl);
                driver.Manage().Window.Maximize();
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

                driver.Navigate().GoToUrl(UserArticlesUrl);
                driver.Manage().Window.Maximize();
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("UserArticlesPageBanner")));
                IWebElement UserArticleBackBtn = driver.FindElement(By.Id("UserArticleBackBtn"));

                Assert.True(UserArticleBackBtn.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);

                Assert.True(UserArticleBackBtn.Displayed);

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
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestUserArticlesPageComponentsArePresent_CheckTextSectionsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                string LoginUrl = _UrlStrings.GetLoginPageLocalHostUrl();
                driver.Navigate().GoToUrl(LoginUrl);
                driver.Manage().Window.Maximize();
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

                string UserArticlesUrl = _UrlStrings.TestUserArticlePageUrl();

                driver.Navigate().GoToUrl(UserArticlesUrl);
                driver.Manage().Window.Maximize();
                IWebElement UserArticlesPageBanner = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("UserArticlesPageBanner")));
                IWebElement TitleElement = driver.FindElement(By.Id("UserArticlesPageTitle"));
                IWebElement SubTitleElement = driver.FindElement(By.Id("UserArticlesPageSubtitle"));
                IWebElement ArticleTitle = driver.FindElement(By.Id("ArticleTitle"));
                IWebElement ArticleAuthor = driver.FindElement(By.Id("ArticleAuthor"));

                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(ArticleTitle.Displayed);
                Assert.True(ArticleAuthor.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);

                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(ArticleTitle.Displayed);
                Assert.True(ArticleAuthor.Displayed);

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
            var filename = "TestUserArticlesPageComponentsArePresent_CheckFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                string UserArticlesUrl = _UrlStrings.TestUserArticlePageUrl();
                using IWebDriver driver = new ChromeDriver();

                string LoginUrl = _UrlStrings.GetLoginPageLocalHostUrl();
                driver.Navigate().GoToUrl(LoginUrl);
                driver.Manage().Window.Maximize();
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

                driver.Navigate().GoToUrl(UserArticlesUrl);
                driver.Manage().Window.Maximize();
                IWebElement FooterElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("nav-footer")));
                IWebElement CopyrightListItemElement = driver.FindElement(By.Id("_LayoutCopyrightFooterLabel"));
                IWebElement RegisterFooterLink = driver.FindElement(By.Id("_LayoutRegisterFooterLink"));
                IWebElement AboutFooterLink = driver.FindElement(By.Id("_LayoutAboutFooterLink"));
                IWebElement ArticlesFooterLink = driver.FindElement(By.Id("_LayoutArticlesFooterLink"));
                IWebElement PrivacyFooterLink = driver.FindElement(By.Id("_LayoutPrivacyFooterLink"));
                IWebElement CookiesFooterLink = driver.FindElement(By.Id("_LayoutCookiesFooterLink"));
                IWebElement FooterTwitterShareIconImage = driver.FindElement(By.Id("FooterTwitterShareIconImage"));
                IWebElement FooterFBShareIconImage = driver.FindElement(By.Id("FooterFBShareIconImage"));
                IWebElement FooterLinkedinShareIconImage = driver.FindElement(By.Id("FooterLinkedinShareIconImage"));

                Assert.True(FooterElement.Displayed);
                Assert.True(CopyrightListItemElement.Displayed);
                Assert.True(RegisterFooterLink.Displayed);
                Assert.True(AboutFooterLink.Displayed);
                Assert.True(ArticlesFooterLink.Displayed);
                Assert.True(PrivacyFooterLink.Displayed);
                Assert.True(CookiesFooterLink.Displayed);
                Assert.True(FooterTwitterShareIconImage.Displayed);
                Assert.True(FooterFBShareIconImage.Displayed);
                Assert.True(FooterLinkedinShareIconImage.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);

                Assert.True(FooterElement.Displayed);
                Assert.True(CopyrightListItemElement.Displayed);
                Assert.True(RegisterFooterLink.Displayed);
                Assert.True(AboutFooterLink.Displayed);
                Assert.True(ArticlesFooterLink.Displayed);
                Assert.True(PrivacyFooterLink.Displayed);
                Assert.True(CookiesFooterLink.Displayed);
                Assert.True(FooterTwitterShareIconImage.Displayed);
                Assert.True(FooterFBShareIconImage.Displayed);
                Assert.True(FooterLinkedinShareIconImage.Displayed);

            }, filename, driver);
        }

    }
}
