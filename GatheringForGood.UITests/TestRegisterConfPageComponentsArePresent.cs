using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using OpenQA.Selenium.Support.UI;
using GatheringForGood.Data;
using Microsoft.AspNetCore.Identity;
using GatheringForGood.Areas.FunctionalLogic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace GatheringForGood.UITests
{
    public class TestRegisterConfPageComponentsArePresent
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
            var filename = "TestRegisterConfPageComponentsArePresent_CheckImagesAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string RegisterConfUrl = UrlRefLibrary.GetRegisterConfPageLocalHostUrl();

                driver.Navigate().GoToUrl(RegisterConfUrl);
                driver.Manage().Window.Maximize();
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("RegisterConfPageBanner")));
                IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_RegisterConfPageLogoImg"));
                IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));

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
        public void CheckSubmissionFieldsAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestRegisterConfPageComponentsArePresent_CheckSubmissionFieldsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string RegisterConfUrl = UrlRefLibrary.GetRegisterConfPageLocalHostUrl();

                driver.Navigate().GoToUrl(RegisterConfUrl);
                driver.Manage().Window.Maximize();
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("RegisterConfPageBanner")));
                IWebElement FirstNameInputField = driver.FindElement(By.Id("FirstNameInputField"));
                IWebElement SurNameInputField = driver.FindElement(By.Id("SurNameInputField"));
                IWebElement AgeInputField = driver.FindElement(By.Id("AgeInputField"));
                IWebElement countryMatchHeading = driver.FindElement(By.Id("countryMatchHeading"));
                IWebElement inputGroupCountrySelect = driver.FindElement(By.Id("inputGroupCountrySelect"));
                IWebElement CountryHiddenInputField = driver.FindElement(By.Id("CountryHiddenInputField"));
                IWebElement regionMatchHeading = driver.FindElement(By.Id("regionMatchHeading"));
                IWebElement inputGroupRegionSelect = driver.FindElement(By.Id("inputGroupRegionSelect"));
                IWebElement RegionHiddenInputField = driver.FindElement(By.Id("RegionHiddenInputField"));
                IWebElement CompanyNameInputField = driver.FindElement(By.Id("CompanyNameInputField"));
                IWebElement skillsMatchHeading = driver.FindElement(By.Id("skillsMatchHeading"));
                IWebElement inputGroupSkillSelect = driver.FindElement(By.Id("inputGroupSkillSelect"));
                IWebElement SkillInputField = driver.FindElement(By.Id("SkillInputField"));
                IWebElement interestsMatchHeading = driver.FindElement(By.Id("interestsMatchHeading"));
                IWebElement inputGroupInterestsSelect = driver.FindElement(By.Id("inputGroupInterestsSelect"));
                IWebElement AreaOfInterestInputField = driver.FindElement(By.Id("AreaOfInterestInputField"));

                Assert.True(BannerImageElement.Displayed);
                Assert.True(FirstNameInputField.Displayed);
                Assert.True(SurNameInputField.Displayed);
                Assert.True(AgeInputField.Displayed);
                Assert.True(countryMatchHeading.Displayed);
                Assert.True(inputGroupCountrySelect.Displayed);
                Assert.False(CountryHiddenInputField.Displayed);
                Assert.True(regionMatchHeading.Displayed);
                Assert.True(inputGroupRegionSelect.Displayed);
                Assert.False(RegionHiddenInputField.Displayed);
                Assert.True(CompanyNameInputField.Displayed);
                Assert.True(skillsMatchHeading.Displayed);
                Assert.True(inputGroupSkillSelect.Displayed);
                Assert.True(SkillInputField.Displayed);
                Assert.True(interestsMatchHeading.Displayed);
                Assert.True(inputGroupInterestsSelect.Displayed);
                Assert.True(AreaOfInterestInputField.Displayed);

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
            var filename = "TestRegisterConfPageComponentsArePresent_CheckNavBarIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string RegisterConfUrl = UrlRefLibrary.GetRegisterConfPageLocalHostUrl();

                driver.Navigate().GoToUrl(RegisterConfUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-registerconf-page")));
                IWebElement NavBarHomeLinkElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_RegisterConfPageHomeNavLink")));
                IWebElement NavBarArticlesLinkElement = driver.FindElement(By.Id("_RegisterConfPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_RegisterConfPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_RegisterConfPageHelpNavLink"));
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
            var filename = "TestRegisterConfPageComponentsArePresent_CheckTextSectionsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string RegisterConfUrl = UrlRefLibrary.GetRegisterConfPageLocalHostUrl();

                driver.Navigate().GoToUrl(RegisterConfUrl);
                driver.Manage().Window.Maximize();
                IWebElement TitleElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("RegisterConfPageTitle")));
                IWebElement SubTitleElement = driver.FindElement(By.Id("RegisterConfPageSubtitle"));
                IWebElement RegisterConfHeadingElement = driver.FindElement(By.Id("RegisterConfHeading"));
                IWebElement FirstNameHeading = driver.FindElement(By.Id("FirstNameHeading"));
                IWebElement SurNameHeading = driver.FindElement(By.Id("SurNameHeading"));
                IWebElement AgeHeading = driver.FindElement(By.Id("AgeHeading"));
                IWebElement CountryHeading = driver.FindElement(By.Id("CountryHeading"));
                IWebElement RegionHeading = driver.FindElement(By.Id("RegionHeading"));
                IWebElement CompanyNameHeading = driver.FindElement(By.Id("CompanyNameHeading"));
                IWebElement SkillHeading = driver.FindElement(By.Id("SkillHeading"));
                IWebElement SkillCommaInfo = driver.FindElement(By.Id("SkillCommaInfo"));
                IWebElement AreaOfInterestHeading = driver.FindElement(By.Id("AreaOfInterestHeading"));
                IWebElement AreaOfInterestCommaInfo = driver.FindElement(By.Id("AreaOfInterestCommaInfo"));

                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(RegisterConfHeadingElement.Displayed);
                Assert.True(FirstNameHeading.Displayed);
                Assert.True(SurNameHeading.Displayed);
                Assert.True(AgeHeading.Displayed);
                Assert.True(CountryHeading.Displayed);
                Assert.True(RegionHeading.Displayed);
                Assert.True(CompanyNameHeading.Displayed);
                Assert.True(SkillHeading.Displayed);
                Assert.True(SkillCommaInfo.Displayed);
                Assert.True(AreaOfInterestHeading.Displayed);
                Assert.True(AreaOfInterestCommaInfo.Displayed);

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
            var filename = "TestRegisterConfPageComponentsArePresent_CheckFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string RegisterConfUrl = UrlRefLibrary.GetRegisterConfPageLocalHostUrl();

                driver.Navigate().GoToUrl(RegisterConfUrl);
                driver.Manage().Window.Maximize();
                IWebElement FooterElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("nav-footer")));
                IWebElement CopyrightListItemElement = driver.FindElement(By.Id("_LayoutCopyrightFooterLabel"));
                IWebElement RegisterFooterLink = driver.FindElement(By.Id("_LayoutRegisterFooterLink"));
                IWebElement AboutFooterLink = driver.FindElement(By.Id("_LayoutAboutFooterLink"));
                IWebElement ArticlesFooterLink = driver.FindElement(By.Id("_LayoutArticlesFooterLink"));
                IWebElement PrivacyFooterLink = driver.FindElement(By.Id("_LayoutPrivacyFooterLink"));
                IWebElement CookiesFooterLink = driver.FindElement(By.Id("_LayoutCookiesFooterLink"));

                Assert.True(FooterElement.Displayed);
                Assert.True(CopyrightListItemElement.Displayed);
                Assert.True(RegisterFooterLink.Displayed);
                Assert.True(AboutFooterLink.Displayed);
                Assert.True(ArticlesFooterLink.Displayed);
                Assert.True(PrivacyFooterLink.Displayed);
                Assert.True(CookiesFooterLink.Displayed);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckButtonsAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestRegisterPageComponentsArePresent_CheckButtonsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string RegisterConfUrl = UrlRefLibrary.GetRegisterConfPageLocalHostUrl();

                driver.Navigate().GoToUrl(RegisterConfUrl);
                driver.Manage().Window.Maximize();

                IWebElement RegisterConfButton = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("RegisterConfButton")));

                Assert.True(RegisterConfButton.Displayed);

            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckSubmissionFieldsAreWorking()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestRegisterConfPageComponentsArePresent_CheckSubmissionFieldsAreWorking";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string RegisterConfUrl = UrlRefLibrary.GetRegisterConfPageLocalHostUrl();

                driver.Navigate().GoToUrl(RegisterConfUrl);
                driver.Manage().Window.Maximize();

                IWebElement RegisterConfPageBanner = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("RegisterConfPageBanner")));
                IWebElement FirstNameInputField = driver.FindElement(By.Id("FirstNameInputField"));
                IWebElement SurNameInputField = driver.FindElement(By.Id("SurNameInputField"));
                IWebElement AgeInputField = driver.FindElement(By.Id("AgeInputField"));
                IWebElement inputGroupCountrySelect = driver.FindElement(By.Id("inputGroupCountrySelect"));
                IWebElement inputGroupRegionSelect = driver.FindElement(By.Id("inputGroupRegionSelect"));
                IWebElement RegionHiddenInputField = driver.FindElement(By.Id("RegionHiddenInputField"));
                IWebElement CompanyNameInputField = driver.FindElement(By.Id("CompanyNameInputField"));
                IWebElement inputGroupSkillSelect = driver.FindElement(By.Id("inputGroupSkillSelect"));
                IWebElement SkillInputField = driver.FindElement(By.Id("SkillInputField"));
                IWebElement inputGroupInterestsSelect = driver.FindElement(By.Id("inputGroupInterestsSelect"));
                IWebElement AreaOfInterestInputField = driver.FindElement(By.Id("AreaOfInterestInputField"));

                FirstNameInputField.Clear();
                FirstNameInputField.SendKeys("John");
                FirstNameInputField.SendKeys(Keys.Tab);

                SurNameInputField.Clear();
                SurNameInputField.SendKeys("Smith");
                SurNameInputField.SendKeys(Keys.Tab);

                AgeInputField.Clear();
                AgeInputField.SendKeys("20");
                AgeInputField.SendKeys(Keys.Tab);

                Assert.True(inputGroupCountrySelect.Enabled);
                Assert.False(inputGroupRegionSelect.Enabled);
                Assert.True(inputGroupSkillSelect.Enabled);
                Assert.True(inputGroupInterestsSelect.Enabled);

                inputGroupCountrySelect.Click();
                new SelectElement(driver.FindElement(By.Id("inputGroupCountrySelect"))).SelectByText("Ireland");
                Assert.True(inputGroupRegionSelect.Enabled);
                inputGroupRegionSelect.Click();
                new SelectElement(driver.FindElement(By.Id("inputGroupRegionSelect"))).SelectByText("Kildare");
                inputGroupCountrySelect.Click();
                new SelectElement(driver.FindElement(By.Id("inputGroupCountrySelect"))).SelectByText("Australia");
                Assert.True(inputGroupRegionSelect.Enabled);
                inputGroupRegionSelect.Click();
                new SelectElement(driver.FindElement(By.Id("inputGroupRegionSelect"))).SelectByText("Tasmania");
                inputGroupCountrySelect.Click();
                new SelectElement(driver.FindElement(By.Id("inputGroupCountrySelect"))).SelectByText("Albania");
                Assert.False(inputGroupRegionSelect.Enabled);

                inputGroupSkillSelect.Click();
                new SelectElement(driver.FindElement(By.Id("inputGroupSkillSelect"))).SelectByText("Accounting");
                new SelectElement(driver.FindElement(By.Id("inputGroupSkillSelect"))).SelectByText("Agile");

                inputGroupInterestsSelect.Click();
                new SelectElement(driver.FindElement(By.Id("inputGroupInterestsSelect"))).SelectByText("All");
                new SelectElement(driver.FindElement(By.Id("inputGroupInterestsSelect"))).SelectByText("Deforestation");

            }, filename, driver);
        }
    }
}
