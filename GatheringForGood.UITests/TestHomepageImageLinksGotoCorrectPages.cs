using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using OpenQA.Selenium.Support.UI;
using System.Drawing;
using System.Threading;
using UITestStringsLibrary;
using System.Linq;

namespace GatheringForGood.UITests
{
    public class TestHomepageImageLinksGotoCorrectPages
    {
        readonly CrossPageSharedUITestStrings UITestStrings = new UITestStringsLibrary.CrossPageSharedUITestStrings();
        readonly UrlStrings UrlStrings = new URLStringsReferenceLibrary.UrlStrings();

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckImageLinkLandingPages()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "﻿TestHomepageImageLinksGotoCorrectPages_CheckImageLinkLandingPages";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();
                string ReduceGlobalWarmingPageLocalHostUrl = UrlRefLibrary.GetReduceGlobalWarmingPageLocalHostUrl();
                string ReduceAnimalExtinctionPageLocalHostUrl = UrlRefLibrary.GetReduceAnimalExtinctionPageLocalHostUrl();
                string ReduceDeforestationPageLocalHostUrl = UrlRefLibrary.GetReduceDeforestationPageLocalHostUrl();
                string CarbonOffsetPageLocalHostUrl = UrlRefLibrary.GetCarbonOffsetsPageLocalHostUrl();
                string DownloadChromeUrl = UrlStrings.GetDownloadChromeUrl();
                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                string ArticlesUrl = UrlRefLibrary.GetArticlesPageLocalHostUrl();
                string TrackUrlUrl = UrlRefLibrary.GetReduceGlobalWarmingPageLocalHostUrl();
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

                driver.Navigate().GoToUrl(HomeUrl);

                IWebElement CarbonClockHowCanIHelpButton1 = driver.FindElement(By.Id("CarbonClockHowCanIHelpButton1"));
                CarbonClockHowCanIHelpButton1.Click();
                IWebElement ReduceGlobalWarmingPageSubtitle2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ReduceGlobalWarmingPageSubtitle")));
                Assert.True(ReduceGlobalWarmingPageSubtitle2.Displayed);
                driver.Navigate().GoToUrl(HomeUrl);
                IWebElement ExtinctionClockHowCanIHelpButton1 = driver.FindElement(By.Id("ExtinctionClockHowCanIHelpButton1"));
                ExtinctionClockHowCanIHelpButton1.Click();
                IWebElement raePageSubtitle1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageSubtitle")));
                Assert.True(raePageSubtitle1.Displayed);
                driver.Navigate().GoToUrl(HomeUrl);
                IWebElement ForestClockHowCanIHelpButton1 = driver.FindElement(By.Id("ForestClockHowCanIHelpButton1"));
                ForestClockHowCanIHelpButton1.Click();
                IWebElement rdfPageSubtitle1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageSubtitle")));
                Assert.True(rdfPageSubtitle1.Displayed);
                driver.Navigate().GoToUrl(HomeUrl);
                IWebElement _TrackRAEImpactsIconLink = driver.FindElement(By.Id("_TrackRAEImpactsIconLink"));
                _TrackRAEImpactsIconLink.Click();
                IWebElement RAEPageSubtitle = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageSubtitle")));
                Assert.True(RAEPageSubtitle.Displayed);
                driver.Navigate().GoToUrl(HomeUrl);
                IWebElement _TrackRGWImpactsIconLink = driver.FindElement(By.Id("_TrackRGWImpactsIconLink"));
                _TrackRGWImpactsIconLink.Click();
                IWebElement RGWPageSubtitle = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ReduceGlobalWarmingPageSubtitle")));
                Assert.True(RGWPageSubtitle.Displayed);
                driver.Navigate().GoToUrl(HomeUrl);
                IWebElement _TrackRDFImpactsIconLink = driver.FindElement(By.Id("_TrackRDFImpactsIconLink"));
                _TrackRDFImpactsIconLink.Click();
                IWebElement RDFPageSubtitle = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageSubtitle")));
                Assert.True(RDFPageSubtitle.Displayed);
                driver.Navigate().GoToUrl(HomeUrl);
                IWebElement HomepageArticlesIconImage = driver.FindElement(By.Id("HomepageArticlesIconImage"));
                HomepageArticlesIconImage.Click();
                IWebElement ArticlesPageSubtitle = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ArticlesPageSubtitle")));
                Assert.True(ArticlesPageSubtitle.Displayed);
                driver.Navigate().GoToUrl(HomeUrl);
                IWebElement ChromeLogoImage = driver.FindElement(By.Id("ChromeLogoImage"));
                ChromeLogoImage.Click();
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                String currentURL = driver.Url;
                Assert.Equal(DownloadChromeUrl, currentURL);
                driver.SwitchTo().Window(driver.WindowHandles.First());
                driver.Navigate().GoToUrl(HomeUrl);

                driver.Manage().Window.Size = new Size(240, 600);

                IWebElement CarbonClockHowCanIHelpButton2 = driver.FindElement(By.Id("CarbonClockHowCanIHelpButton2"));
                CarbonClockHowCanIHelpButton2.Click();
                IWebElement ReduceGlobalWarmingPageSubtitle5 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ReduceGlobalWarmingPageSubtitle")));
                Assert.True(ReduceGlobalWarmingPageSubtitle5.Displayed);
                driver.Navigate().GoToUrl(HomeUrl);
                IWebElement ExtinctionClockHowCanIHelpButton2 = driver.FindElement(By.Id("ExtinctionClockHowCanIHelpButton2"));
                ExtinctionClockHowCanIHelpButton2.Click();
                IWebElement raePageSubtitle3 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageSubtitle")));
                Assert.True(raePageSubtitle3.Displayed);
                driver.Navigate().GoToUrl(HomeUrl);
                IWebElement ForestClockHowCanIHelpButton2 = driver.FindElement(By.Id("ForestClockHowCanIHelpButton2"));
                ForestClockHowCanIHelpButton2.Click();
                IWebElement rdfPageSubtitle3 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageSubtitle")));
                Assert.True(rdfPageSubtitle3.Displayed);
                driver.Navigate().GoToUrl(HomeUrl);
                IWebElement HomepageArticlesIconImage1 = driver.FindElement(By.Id("HomepageArticlesIconImage"));
                HomepageArticlesIconImage1.Click();
                IWebElement ArticlesPageSubtitle1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ArticlesPageSubtitle")));
                Assert.True(ArticlesPageSubtitle1.Displayed);
                driver.Navigate().GoToUrl(HomeUrl);

            }, filename, driver);
        }
    }
}
