using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using OpenQA.Selenium.Support.UI;
using System.Drawing;

namespace GatheringForGood.UITests
{
    public class TestTermsAndConditionsPageComponentsArePresent
    {
        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckImagesAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestTermsAndConditionsPageComponentsArePresent_CheckImagesAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string TermsAndConditionsUrl = UrlRefLibrary.GetTermsAndConditionsPageLocalHostUrl();

                driver.Navigate().GoToUrl(TermsAndConditionsUrl);
                driver.Manage().Window.Maximize();
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("TermsAndConditionsPageBanner")));
                IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));
                IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_TermsAndConditionsPageLogoImg"));

                Assert.True(BannerImageElement.Displayed);
                Assert.True(_LayoutPageLogoElement.Displayed);
                Assert.True(BodyBackground.Displayed);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckNavBarIsDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestTermsAndConditionsPageComponentsArePresent_CheckNavBarIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string TermsAndConditionsUrl = UrlRefLibrary.GetTermsAndConditionsPageLocalHostUrl();

                driver.Navigate().GoToUrl(TermsAndConditionsUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-tandc-page")));
                IWebElement NavBarHomeLinkElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_TermsAndConditionsPageHomeNavLink")));
                IWebElement NavBarArticlesLinkElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_TermsAndConditionsPageArticlesNavLink")));
                IWebElement NavBarAboutLinkElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_TermsAndConditionsPageAboutNavLink")));
                IWebElement NavBarHelpLinkElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_TermsAndConditionsPageHelpNavLink")));
                IWebElement NavBarRegisterLinkElement = driver.FindElement(By.Id("_LoginPartialRegister"));
                IWebElement NavBarLoginLinkElement = driver.FindElement(By.Id("_LoginPartialLogin"));

                Assert.True(NavBarElement.Displayed);
                Assert.True(NavBarHomeLinkElement.Displayed);
                Assert.True(NavBarArticlesLinkElement.Displayed);
                Assert.True(NavBarAboutLinkElement.Displayed);
                Assert.True(NavBarHelpLinkElement.Displayed);
                Assert.True(NavBarRegisterLinkElement.Displayed);
                Assert.True(NavBarLoginLinkElement.Displayed);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckTextSectionsAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestTermsAndConditionsPageComponentsArePresent_CheckTextSectionsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string PrivacyUrl = UrlRefLibrary.GetTermsAndConditionsPageLocalHostUrl();

                driver.Navigate().GoToUrl(PrivacyUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-tandc-page")));
                IWebElement TitleElement = driver.FindElement(By.Id("TermsAndConditionsPageTitle"));
                IWebElement SubTitleElement = driver.FindElement(By.Id("TermsAndConditionsPageSubtitle"));

                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Long")]
        [Trait("TestEnvironment", "Local")]
        public void CheckMainTextContentIsDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestTermsAndConditionsPageComponentsArePresent_CheckMainTextContentIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string PrivacyUrl = UrlRefLibrary.GetTermsAndConditionsPageLocalHostUrl();

                driver.Navigate().GoToUrl(PrivacyUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-tandc-page")));
                IWebElement TermsAndConditionsHeading = driver.FindElement(By.Id("TermsAndConditionsHeading"));
                IWebElement TandCEffectiveDate = driver.FindElement(By.Id("TandCEffectiveDate"));
                IWebElement AgreeInFull = driver.FindElement(By.Id("_TermsAndConditionsAgreeInFull"));
                IWebElement AppropriateUse = driver.FindElement(By.Id("_TermsAndConditionsAppropriateUse"));
                IWebElement AppropriateUseGuide = driver.FindElement(By.Id("_TermsAndConditionsAppropriateUseGuide"));
                IWebElement RightofAccountClosure = driver.FindElement(By.Id("_TermsAndConditionsRightofAccountClosure"));
                IWebElement NaturalWorldClosure = driver.FindElement(By.Id("_TermsAndConditionsNaturalWorldClosure"));
                IWebElement _TermsAndConditionsSavingData = driver.FindElement(By.Id("_TermsAndConditionsSavingData"));
                IWebElement Analytics = driver.FindElement(By.Id("_TermsAndConditionsAnalytics"));
                IWebElement _TermsAndConditionsObituariesAndViolence = driver.FindElement(By.Id("_TermsAndConditionsObituariesAndViolence"));
                IWebElement _TermsAndConditionsDiscrimination = driver.FindElement(By.Id("_TermsAndConditionsDiscrimination"));
                IWebElement _TermsAndConditionsOneAccountPerPerson = driver.FindElement(By.Id("_TermsAndConditionsOneAccountPerPerson"));
                IWebElement _TermsAndConditionsTreePlantingPara1 = driver.FindElement(By.Id("_TermsAndConditionsTreePlantingPara1"));
                IWebElement _TermsAndConditionsPageAboutVisionLink = driver.FindElement(By.Id("_TermsAndConditionsPageAboutVisionLink"));
                IWebElement _TermsAndConditionsPageOneTreePlantedLink = driver.FindElement(By.Id("_TermsAndConditionsPageOneTreePlantedLink"));
                IWebElement _TermsAndConditionsOneTreePlantedLogo = driver.FindElement(By.Id("_TermsAndConditionsOneTreePlantedLogo"));
                IWebElement _TermsAndConditionsTreePlantingPara5 = driver.FindElement(By.Id("_TermsAndConditionsTreePlantingPara5"));
                IWebElement _TermsAndConditionsPageAboutHelpLink = driver.FindElement(By.Id("_TermsAndConditionsPageAboutHelpLink"));
                IWebElement _TermsAndConditionsPlantingLocationsList = driver.FindElement(By.Id("_TermsAndConditionsPlantingLocationsList"));
                IWebElement _TermsAndConditionsTreePlantingPara7 = driver.FindElement(By.Id("_TermsAndConditionsTreePlantingPara7"));
                IWebElement _TermsAndConditionsPieChartLogo = driver.FindElement(By.Id("_TermsAndConditionsPieChartLogo"));
                IWebElement _TermsAndConditionsNoObituaries = driver.FindElement(By.Id("_TermsAndConditionsNoObituaries"));
                IWebElement _TermsAndConditionsFontAwesomeLicense = driver.FindElement(By.Id("_TermsAndConditionsFontAwesomeLicense"));
                IWebElement _TermsAndConditionsTandCUpdates = driver.FindElement(By.Id("_TermsAndConditionsTandCUpdates"));

                Assert.True(TermsAndConditionsHeading.Displayed);
                Assert.True(TandCEffectiveDate.Displayed);
                Assert.True(AgreeInFull.Displayed);
                Assert.True(AppropriateUse.Displayed);
                Assert.True(AppropriateUseGuide.Displayed);
                Assert.True(RightofAccountClosure.Displayed);
                Assert.True(NaturalWorldClosure.Displayed);
                Assert.True(_TermsAndConditionsSavingData.Displayed);
                Assert.True(Analytics.Displayed);
                Assert.True(_TermsAndConditionsObituariesAndViolence.Displayed);
                Assert.True(_TermsAndConditionsDiscrimination.Displayed);
                Assert.True(_TermsAndConditionsOneAccountPerPerson.Displayed);
                Assert.True(_TermsAndConditionsTreePlantingPara1.Displayed);
                Assert.True(_TermsAndConditionsPageAboutVisionLink.Displayed);
                Assert.True(_TermsAndConditionsPageOneTreePlantedLink.Displayed);
                Assert.True(_TermsAndConditionsOneTreePlantedLogo.Displayed);
                Assert.True(_TermsAndConditionsTreePlantingPara5.Displayed);
                Assert.True(_TermsAndConditionsPageAboutHelpLink.Displayed);
                Assert.True(_TermsAndConditionsPlantingLocationsList.Displayed);
                Assert.True(_TermsAndConditionsTreePlantingPara7.Displayed);
                Assert.True(_TermsAndConditionsPieChartLogo.Displayed);
                Assert.True(_TermsAndConditionsNoObituaries.Displayed);
                Assert.True(_TermsAndConditionsFontAwesomeLicense.Displayed);
                Assert.True(_TermsAndConditionsTandCUpdates.Displayed);

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
            var filename = "TestTermsAndConditionsPageComponentsArePresent_CheckFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string TermsAndConditions = UrlRefLibrary.GetTermsAndConditionsPageLocalHostUrl();

                driver.Navigate().GoToUrl(TermsAndConditions);
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
