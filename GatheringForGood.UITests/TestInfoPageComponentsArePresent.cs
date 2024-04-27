using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using UITestStringsLibrary;
using OpenQA.Selenium.Support.UI;
using System.Drawing;
using System.Threading;

namespace GatheringForGood.UITests
{
    public class TestInfoPageComponentsArePresent
    {
        readonly CrossPageSharedUITestStrings UITestStrings = new CrossPageSharedUITestStrings();

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Long")]
        [Trait("TestEnvironment", "Local")]
        public void CheckImagesAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestInfoPageComponentsArePresent_CheckImagesAreDisplayed";

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
                string UserEmail = UITestStrings.Test3UserEmail();
                string UserPassword = UITestStrings.Test3UserPassword();

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Keys.Tab);
                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Keys.Tab);
                LoginEmailInputField.SendKeys(UserEmail);
                LoginPasswordInputField.SendKeys(UserPassword);

                LoginButton.Click();
                IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                string infoUrl = UrlRefLibrary.GetInfoPageLocalHostUrl();
                driver.Navigate().GoToUrl(infoUrl);
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("InfoPageBanner")));
                IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));
                IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_InfoPageLogoImg"));

                Assert.True(BannerImageElement.Displayed);
                Assert.True(_LayoutPageLogoElement.Displayed);
                Assert.True(BodyBackground.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);
                Assert.True(BannerImageElement.Displayed);
                Assert.True(_LayoutPageLogoElement.Displayed);
                Assert.True(BodyBackground.Displayed);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckNavBarIsDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestInfoPageComponentsArePresent_CheckNavBarIsDisplayed";

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
                string UserEmail = UITestStrings.Test3UserEmail();
                string UserPassword = UITestStrings.Test3UserPassword();

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Keys.Tab);
                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Keys.Tab);
                LoginEmailInputField.SendKeys(UserEmail);
                LoginPasswordInputField.SendKeys(UserPassword);

                LoginButton.Click();
                IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                string infoUrl = UrlRefLibrary.GetInfoPageLocalHostUrl();
                driver.Navigate().GoToUrl(infoUrl);
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-info-page")));
                IWebElement NavBarHomeLinkElement = driver.FindElement(By.Id("_InfoPageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement = driver.FindElement(By.Id("_InfoPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_InfoPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_InfoPageHelpNavLink"));
                IWebElement NavBarLoginPartialLoggedInUserEmailLinkElement = driver.FindElement(By.Id("_LoginPartialLoggedInUserEmail"));
                IWebElement NavBarLoginPartialLogoutButtonLinkElement = driver.FindElement(By.Id("_LoginPartialLogoutButton"));

                Assert.True(NavBarElement.Displayed);
                Assert.True(NavBarHomeLinkElement.Displayed);
                Assert.True(NavBarArticlesLinkElement.Displayed);
                Assert.True(NavBarAboutLinkElement.Displayed);
                Assert.True(NavBarHelpLinkElement.Displayed);
                Assert.True(NavBarLoginPartialLoggedInUserEmailLinkElement.Displayed);
                Assert.True(NavBarLoginPartialLogoutButtonLinkElement.Displayed);

                Assert.Equal("HOME", NavBarHomeLinkElement.Text);
                Assert.Equal("ARTICLES", NavBarArticlesLinkElement.Text);
                Assert.Equal("ABOUT", NavBarAboutLinkElement.Text);
                Assert.Equal("HELP CENTER", NavBarHelpLinkElement.Text);
                Assert.Equal("LOGOUT", NavBarLoginPartialLogoutButtonLinkElement.Text);
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
            var filename = "TestInfoPageComponentsArePresent_CheckButtonsAreDisplayed";

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
                string UserEmail = UITestStrings.Test3UserEmail();
                string UserPassword = UITestStrings.Test3UserPassword();

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Keys.Tab);
                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Keys.Tab);
                LoginEmailInputField.SendKeys(UserEmail);
                LoginPasswordInputField.SendKeys(UserPassword);

                LoginButton.Click();
                IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                string infoUrl = UrlRefLibrary.GetInfoPageLocalHostUrl();
                driver.Navigate().GoToUrl(infoUrl);
                IWebElement InfoPageButton = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("InfoPageButton")));

                Assert.True(InfoPageButton.Displayed);
                Assert.True(InfoPageButton.Enabled);

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
            using IWebDriver driver1 = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestInfoPageComponentsArePresent_CheckTextSectionsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

                driver1.Navigate().GoToUrl(HomeUrl);
                driver1.Manage().Window.Maximize();

                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                driver1.Navigate().GoToUrl(LoginUrl);
                IWebElement LoginEmailInputField = new WebDriverWait(driver1, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
                IWebElement LoginPasswordInputField = driver1.FindElement(By.Id("LoginPasswordInputField"));
                IWebElement LoginButton = driver1.FindElement(By.Id("LoginButton"));
                string UserEmail = UITestStrings.Test3UserEmail();
                string UserPassword = UITestStrings.Test3UserPassword();

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Keys.Tab);
                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Keys.Tab);
                LoginEmailInputField.SendKeys(UserEmail);
                LoginPasswordInputField.SendKeys(UserPassword);

                LoginButton.Click();
                IWebElement LoggedInUserLabel = new WebDriverWait(driver1, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                string infoUrl = UrlRefLibrary.GetInfoPageLocalHostUrl();
                driver1.Navigate().GoToUrl(infoUrl);
                driver1.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver1, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-info-page")));
                IWebElement InfoPageFirstNameHeading = driver1.FindElement(By.Id("InfoPageFirstNameHeading"));
                IWebElement InfoPageExistingFirstNameInputField = driver1.FindElement(By.Id("InfoPageExistingFirstNameInputField"));
                IWebElement InfoPageReplaceFirstNameInputFieldNewLabel = driver1.FindElement(By.Id("InfoPageReplaceFirstNameInputFieldNewLabel"));
                IWebElement InfoPageReplaceFirstNameInputField = driver1.FindElement(By.Id("InfoPageReplaceFirstNameInputField"));

                IWebElement InfoPageSurNameHeading = driver1.FindElement(By.Id("InfoPageSurNameHeading"));
                IWebElement InfoPageExistingSurNameInputField = driver1.FindElement(By.Id("InfoPageExistingSurNameInputField"));
                IWebElement InfoPageReplaceSurnameInputFieldNewLabel = driver1.FindElement(By.Id("InfoPageReplaceSurnameInputFieldNewLabel"));
                IWebElement InfoPageReplaceSurNameInputField = driver1.FindElement(By.Id("InfoPageReplaceSurNameInputField"));

                IWebElement InfoPageAgeHeading = driver1.FindElement(By.Id("InfoPageAgeHeading"));
                IWebElement InfoPageExistingAgeInputField = driver1.FindElement(By.Id("InfoPageExistingAgeInputField"));
                IWebElement InfoPageReplaceAgeInputFieldNewLabel = driver1.FindElement(By.Id("InfoPageReplaceAgeInputFieldNewLabel"));
                IWebElement InfoPageReplaceAgeInputField = driver1.FindElement(By.Id("InfoPageReplaceAgeInputField"));

                IWebElement InfoPageCountryHeading = driver1.FindElement(By.Id("InfoPageCountryHeading"));
                IWebElement InfoPageExistingCountryInputField = driver1.FindElement(By.Id("InfoPageExistingCountryInputField"));
                IWebElement InfoPageReplaceCountryInputFieldNewLabel = driver1.FindElement(By.Id("InfoPageReplaceCountryInputFieldNewLabel"));
                IWebElement InfoPagecountryMatchHeading = driver1.FindElement(By.Id("InfoPagecountryMatchHeading"));

                IWebElement InfoPageRegionHeading = driver1.FindElement(By.Id("InfoPageRegionHeading"));
                IWebElement InfoPageExistingRegionInputField = driver1.FindElement(By.Id("InfoPageExistingRegionInputField"));
                IWebElement InfoPageReplaceRegionInputFieldNewLabel = driver1.FindElement(By.Id("InfoPageReplaceRegionInputFieldNewLabel"));
                IWebElement InfoPageregionMatchHeading = driver1.FindElement(By.Id("InfoPageregionMatchHeading"));

                IWebElement InfoPageCompanyNameHeading = driver1.FindElement(By.Id("InfoPageCompanyNameHeading"));
                IWebElement InfoPageExistingCompanyInputField = driver1.FindElement(By.Id("InfoPageExistingCompanyInputField"));
                IWebElement InfoPageReplaceCompanyInputFieldNewLabel = driver1.FindElement(By.Id("InfoPageReplaceCompanyInputFieldNewLabel"));
                IWebElement InfoPageReplaceCompanyNameInputField = driver1.FindElement(By.Id("InfoPageReplaceCompanyNameInputField"));

                IWebElement InfoPageSkillHeading = driver1.FindElement(By.Id("InfoPageSkillHeading"));
                IWebElement InfoPageExistingSkillInputField = driver1.FindElement(By.Id("InfoPageExistingSkillInputField"));
                IWebElement InfoPageskillsMatchHeading = driver1.FindElement(By.Id("InfoPageskillsMatchHeading"));
                IWebElement InfoPageinputGroupSkillSelect = driver1.FindElement(By.Id("InfoPageinputGroupSkillSelect"));
                IWebElement InfoPageSkillCommaInfo = driver1.FindElement(By.Id("InfoPageSkillCommaInfo"));
                IWebElement InfoPageReplaceSkillInputField = driver1.FindElement(By.Id("InfoPageReplaceSkillInputField"));

                IWebElement InfoPageAreaOfInterestHeading = driver1.FindElement(By.Id("InfoPageAreaOfInterestHeading"));
                IWebElement InfoPageExistingAreaOfInterestInputField = driver1.FindElement(By.Id("InfoPageExistingAreaOfInterestInputField"));
                IWebElement InfoPageinterestsMatchHeading = driver1.FindElement(By.Id("InfoPageinterestsMatchHeading"));
                IWebElement InfoPageinputGroupInterestsSelect = driver1.FindElement(By.Id("InfoPageinputGroupInterestsSelect"));
                IWebElement AreaOfInterestCommaInfo = driver1.FindElement(By.Id("AreaOfInterestCommaInfo"));
                IWebElement InfoPageReplaceAreaOfInterestInputField = driver1.FindElement(By.Id("InfoPageReplaceAreaOfInterestInputField"));

                IWebElement InfoPageMarketingHeading = driver1.FindElement(By.Id("InfoPageMarketingHeading"));
                IWebElement InfoPageInput_MarketingComms = driver1.FindElement(By.Id("InfoPageInput_MarketingComms"));
                IWebElement InfoPageNewMarketingCheckboxHiddenInputField = driver1.FindElement(By.Id("InfoPageNewMarketingCheckboxHiddenInputField"));
                IWebElement InfoPageMarketingExistingCheckboxField = driver1.FindElement(By.Id("InfoPageMarketingExistingCheckboxField"));

                Assert.True(InfoPageFirstNameHeading.Displayed);
                Assert.True(InfoPageExistingFirstNameInputField.Displayed);
                Assert.True(InfoPageReplaceFirstNameInputFieldNewLabel.Displayed);
                Assert.True(InfoPageReplaceFirstNameInputField.Displayed);

                Assert.True(InfoPageSurNameHeading.Displayed);
                Assert.True(InfoPageExistingSurNameInputField.Displayed);
                Assert.True(InfoPageReplaceSurnameInputFieldNewLabel.Displayed);
                Assert.True(InfoPageReplaceSurNameInputField.Displayed);

                Assert.True(InfoPageAgeHeading.Displayed);
                Assert.True(InfoPageExistingAgeInputField.Displayed);
                Assert.True(InfoPageReplaceAgeInputFieldNewLabel.Displayed);
                Assert.True(InfoPageReplaceAgeInputField.Displayed);

                Assert.True(InfoPageCountryHeading.Displayed);
                Assert.True(InfoPageExistingCountryInputField.Displayed);
                Assert.True(InfoPageReplaceCountryInputFieldNewLabel.Displayed);
                Assert.True(InfoPagecountryMatchHeading.Displayed);

                Assert.True(InfoPageRegionHeading.Displayed);
                Assert.True(InfoPageExistingRegionInputField.Displayed);
                Assert.True(InfoPageReplaceRegionInputFieldNewLabel.Displayed);
                Assert.True(InfoPageregionMatchHeading.Displayed);

                Assert.True(InfoPageCompanyNameHeading.Displayed);
                Assert.True(InfoPageExistingCompanyInputField.Displayed);
                Assert.True(InfoPageReplaceCompanyInputFieldNewLabel.Displayed);
                Assert.True(InfoPageReplaceCompanyNameInputField.Displayed);

                Assert.True(InfoPageSkillHeading.Displayed);
                Assert.True(InfoPageExistingSkillInputField.Displayed);
                Assert.True(InfoPageskillsMatchHeading.Displayed);
                Assert.True(InfoPageinputGroupSkillSelect.Displayed);
                Assert.True(InfoPageSkillCommaInfo.Displayed);
                Assert.True(InfoPageReplaceSkillInputField.Displayed);

                Assert.True(InfoPageAreaOfInterestHeading.Displayed);
                Assert.True(InfoPageExistingAreaOfInterestInputField.Displayed);
                Assert.True(InfoPageinterestsMatchHeading.Displayed);
                Assert.True(InfoPageinputGroupInterestsSelect.Displayed);
                Assert.True(AreaOfInterestCommaInfo.Displayed);
                Assert.True(InfoPageReplaceAreaOfInterestInputField.Displayed);

                Assert.True(InfoPageMarketingHeading.Displayed);
                Assert.True(InfoPageInput_MarketingComms.Displayed);
                Assert.False(InfoPageNewMarketingCheckboxHiddenInputField.Displayed);
                Assert.False(InfoPageMarketingExistingCheckboxField.Displayed);

                driver1.Manage().Window.Size = new Size(240, 600);

                Assert.True(InfoPageFirstNameHeading.Displayed);
                Assert.True(InfoPageExistingFirstNameInputField.Displayed);
                Assert.True(InfoPageReplaceFirstNameInputFieldNewLabel.Displayed);
                Assert.True(InfoPageReplaceFirstNameInputField.Displayed);

                Assert.True(InfoPageSurNameHeading.Displayed);
                Assert.True(InfoPageExistingSurNameInputField.Displayed);
                Assert.True(InfoPageReplaceSurnameInputFieldNewLabel.Displayed);
                Assert.True(InfoPageReplaceSurNameInputField.Displayed);

                Assert.True(InfoPageAgeHeading.Displayed);
                Assert.True(InfoPageExistingAgeInputField.Displayed);
                Assert.True(InfoPageReplaceAgeInputFieldNewLabel.Displayed);
                Assert.True(InfoPageReplaceAgeInputField.Displayed);

                Assert.True(InfoPageCountryHeading.Displayed);
                Assert.True(InfoPageExistingCountryInputField.Displayed);
                Assert.True(InfoPageReplaceCountryInputFieldNewLabel.Displayed);
                Assert.True(InfoPagecountryMatchHeading.Displayed);

                Assert.True(InfoPageCompanyNameHeading.Displayed);
                Assert.True(InfoPageExistingCompanyInputField.Displayed);
                Assert.True(InfoPageReplaceCompanyInputFieldNewLabel.Displayed);
                Assert.True(InfoPageReplaceCompanyNameInputField.Displayed);

                Assert.True(InfoPageSkillHeading.Displayed);
                Assert.True(InfoPageExistingSkillInputField.Displayed);
                Assert.True(InfoPageskillsMatchHeading.Displayed);
                Assert.True(InfoPageinputGroupSkillSelect.Displayed);
                Assert.True(InfoPageSkillCommaInfo.Displayed);
                Assert.True(InfoPageReplaceSkillInputField.Displayed);

                Assert.True(InfoPageAreaOfInterestHeading.Displayed);
                Assert.True(InfoPageExistingAreaOfInterestInputField.Displayed);
                Assert.True(InfoPageinterestsMatchHeading.Displayed);
                Assert.True(InfoPageinputGroupInterestsSelect.Displayed);
                Assert.True(AreaOfInterestCommaInfo.Displayed);
                Assert.True(InfoPageReplaceAreaOfInterestInputField.Displayed);

                Assert.True(InfoPageMarketingHeading.Displayed);
                Assert.True(InfoPageInput_MarketingComms.Displayed);
                Assert.False(InfoPageNewMarketingCheckboxHiddenInputField.Displayed);
                Assert.False(InfoPageMarketingExistingCheckboxField.Displayed);

            }, filename, driver1);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckFormIsWorking()
        {
            using IWebDriver driver1 = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestInfoPageComponentsArePresent_CheckFormIsWorking";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

                driver1.Navigate().GoToUrl(HomeUrl);
                driver1.Manage().Window.Maximize();

                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                driver1.Navigate().GoToUrl(LoginUrl);
                IWebElement LoginEmailInputField = new WebDriverWait(driver1, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
                IWebElement LoginPasswordInputField = driver1.FindElement(By.Id("LoginPasswordInputField"));
                IWebElement LoginButton = driver1.FindElement(By.Id("LoginButton"));
                string UserEmail = UITestStrings.Test3UserEmail();
                string UserPassword = UITestStrings.Test3UserPassword();

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Keys.Tab);
                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Keys.Tab);
                LoginEmailInputField.SendKeys(UserEmail);
                LoginPasswordInputField.SendKeys(UserPassword);

                LoginButton.Click();
                IWebElement LoggedInUserLabel = new WebDriverWait(driver1, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                string infoUrl = UrlRefLibrary.GetInfoPageLocalHostUrl();
                driver1.Navigate().GoToUrl(infoUrl);
                driver1.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver1, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-info-page")));
                IWebElement InfoPageExistingFirstNameInputField = driver1.FindElement(By.Id("InfoPageExistingFirstNameInputField"));
                IWebElement InfoPageReplaceFirstNameInputField = driver1.FindElement(By.Id("InfoPageReplaceFirstNameInputField"));
                IWebElement InfoPageExistingSurNameInputField = driver1.FindElement(By.Id("InfoPageExistingSurNameInputField"));
                IWebElement InfoPageReplaceSurNameInputField = driver1.FindElement(By.Id("InfoPageReplaceSurNameInputField"));
                IWebElement InfoPageExistingAgeInputField = driver1.FindElement(By.Id("InfoPageExistingAgeInputField"));
                IWebElement InfoPageReplaceAgeInputField = driver1.FindElement(By.Id("InfoPageReplaceAgeInputField"));
                IWebElement InfoPageExistingCountryInputField = driver1.FindElement(By.Id("InfoPageExistingCountryInputField"));
                IWebElement InfoPageExistingCountryDropdown = driver1.FindElement(By.Id("InfoPageinputGroupCountrySelect"));
                IWebElement InfoPageExistingRegionInputField = driver1.FindElement(By.Id("InfoPageExistingRegionInputField"));
                IWebElement InfoPageExistingRegionDropdown = driver1.FindElement(By.Id("InfoPageinputGroupRegionSelect"));
                IWebElement InfoPageExistingCompanyInputField = driver1.FindElement(By.Id("InfoPageExistingCompanyInputField"));
                IWebElement InfoPageReplaceCompanyNameInputField = driver1.FindElement(By.Id("InfoPageReplaceCompanyNameInputField"));
                IWebElement InfoPageExistingSkillInputField = driver1.FindElement(By.Id("InfoPageExistingSkillInputField"));
                IWebElement InfoPageReplaceSkillInputField = driver1.FindElement(By.Id("InfoPageReplaceSkillInputField"));
                IWebElement InfoPageinputGroupSkillSelect = driver1.FindElement(By.Id("InfoPageinputGroupSkillSelect"));
                IWebElement InfoPageExistingAreaOfInterestInputField = driver1.FindElement(By.Id("InfoPageExistingAreaOfInterestInputField"));
                IWebElement InfoPageinputGroupInterestsSelect = driver1.FindElement(By.Id("InfoPageinputGroupInterestsSelect"));
                IWebElement InfoPageReplaceAreaOfInterestInputField = driver1.FindElement(By.Id("InfoPageReplaceAreaOfInterestInputField"));
                IWebElement InfoPageInput_MarketingComms = driver1.FindElement(By.Id("InfoPageInput_MarketingComms"));
                IWebElement InfoPageButton = driver1.FindElement(By.Id("InfoPageButton"));

                string InfoPageExistingFirstNameInputField_string = InfoPageExistingFirstNameInputField.GetAttribute("value");
                string InfoPageReplaceFirstNameInputField_string = InfoPageReplaceFirstNameInputField.GetAttribute("value");
                string InfoPageExistingSurNameInputField_string = InfoPageExistingSurNameInputField.GetAttribute("value");
                string InfoPageReplaceSurNameInputField_string = InfoPageReplaceSurNameInputField.GetAttribute("value");
                string InfoPageExistingAgeInputField_string = InfoPageExistingAgeInputField.GetAttribute("value");
                string InfoPageReplaceAgeInputField_string = InfoPageReplaceAgeInputField.GetAttribute("value");
                string InfoPageExistingCountryInputField_string = InfoPageExistingCountryInputField.GetAttribute("value");
                string InfoPageExistingRegionInputField_string = InfoPageExistingRegionInputField.GetAttribute("value");
                string InfoPageExistingCompanyInputField_string = InfoPageExistingCompanyInputField.GetAttribute("value");
                string InfoPageReplaceCompanyNameInputField_string = InfoPageReplaceCompanyNameInputField.GetAttribute("value");
                string InfoPageExistingSkillInputField_string = InfoPageExistingSkillInputField.GetAttribute("value");
                string InfoPageReplaceSkillInputField_string = InfoPageReplaceSkillInputField.GetAttribute("value");
                string InfoPageExistingAreaOfInterestInputField_string = InfoPageExistingAreaOfInterestInputField.GetAttribute("value");
                string InfoPageReplaceAreaOfInterestInputField_string = InfoPageReplaceAreaOfInterestInputField.GetAttribute("value");

                Assert.Equal("123456", InfoPageExistingFirstNameInputField_string);
                Assert.False(InfoPageExistingFirstNameInputField.Enabled);
                Assert.Equal("123456", InfoPageReplaceFirstNameInputField_string);
                Assert.Equal("123456", InfoPageExistingSurNameInputField_string);
                Assert.False(InfoPageExistingSurNameInputField.Enabled);
                Assert.Equal("123456", InfoPageReplaceSurNameInputField_string);
                Assert.Equal("99", InfoPageExistingAgeInputField_string);
                Assert.False(InfoPageExistingAgeInputField.Enabled);
                Assert.Equal("99", InfoPageReplaceAgeInputField_string);
                Assert.Equal("Ireland", InfoPageExistingCountryInputField_string);
                Assert.False(InfoPageExistingCountryInputField.Enabled);
                Assert.Equal("Kildare", InfoPageExistingRegionInputField_string);
                Assert.False(InfoPageExistingRegionInputField.Enabled);
                Assert.Equal("123456", InfoPageExistingCompanyInputField_string);
                Assert.False(InfoPageExistingCompanyInputField.Enabled);
                Assert.Equal("123456", InfoPageReplaceCompanyNameInputField_string);
                Assert.Equal("Agile,Professional Scrum", InfoPageExistingSkillInputField_string);
                Assert.False(InfoPageExistingSkillInputField.Enabled);
                Assert.Equal("Agile,Professional Scrum", InfoPageReplaceSkillInputField_string);
                Assert.Equal("All,Deforestation", InfoPageExistingAreaOfInterestInputField_string);
                Assert.False(InfoPageExistingAreaOfInterestInputField.Enabled);
                Assert.Equal("All,Deforestation", InfoPageReplaceAreaOfInterestInputField_string);
                Assert.False(InfoPageExistingRegionDropdown.Enabled);
                Assert.True(InfoPageInput_MarketingComms.Displayed);
                Assert.True(InfoPageInput_MarketingComms.Selected);

                InfoPageReplaceFirstNameInputField.Clear();
                InfoPageReplaceFirstNameInputField.SendKeys("test");
                InfoPageReplaceSurNameInputField.Clear();
                InfoPageReplaceSurNameInputField.SendKeys("test");
                InfoPageReplaceAgeInputField.Clear();
                InfoPageReplaceAgeInputField.SendKeys("11");
                InfoPageExistingCountryDropdown.Click();
                new SelectElement(driver1.FindElement(By.Id("InfoPageinputGroupCountrySelect"))).SelectByText("Australia");
                Assert.True(InfoPageExistingRegionDropdown.Enabled);
                new SelectElement(driver1.FindElement(By.Id("InfoPageinputGroupRegionSelect"))).SelectByText("Victoria");
                InfoPageReplaceCompanyNameInputField.Clear();
                InfoPageReplaceCompanyNameInputField.SendKeys("test");
                InfoPageReplaceSkillInputField.Clear();
                InfoPageReplaceSkillInputField.SendKeys("test,");
                InfoPageinputGroupSkillSelect.Click();
                new SelectElement(driver1.FindElement(By.Id("InfoPageinputGroupSkillSelect"))).SelectByText("Biologist");
                string InfoPageReplaceSkillInputField_string1 = InfoPageReplaceSkillInputField.GetAttribute("value");
                Assert.Equal("test,Biologist", InfoPageReplaceSkillInputField_string1);
                InfoPageReplaceAreaOfInterestInputField.Clear();
                InfoPageReplaceAreaOfInterestInputField.SendKeys("test,");
                InfoPageinputGroupInterestsSelect.Click();
                new SelectElement(driver1.FindElement(By.Id("InfoPageinputGroupInterestsSelect"))).SelectByText("All");
                string InfoPageReplaceAreaOfInterestInputField_string1 = InfoPageReplaceAreaOfInterestInputField.GetAttribute("value");
                Assert.Equal("test,All", InfoPageReplaceAreaOfInterestInputField_string1);
                InfoPageInput_MarketingComms.Click();
                Assert.False(InfoPageInput_MarketingComms.Selected);
                InfoPageButton.Click();

                IWebElement InfoPageExistingFirstNameInputField1 = new WebDriverWait(driver1, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("InfoPageExistingFirstNameInputField")));
                IWebElement InfoPageReplaceFirstNameInputField1 = driver1.FindElement(By.Id("InfoPageReplaceFirstNameInputField"));
                IWebElement InfoPageExistingSurNameInputField1 = driver1.FindElement(By.Id("InfoPageExistingSurNameInputField"));
                IWebElement InfoPageReplaceSurNameInputField1 = driver1.FindElement(By.Id("InfoPageReplaceSurNameInputField"));
                IWebElement InfoPageExistingAgeInputField1 = driver1.FindElement(By.Id("InfoPageExistingAgeInputField"));
                IWebElement InfoPageReplaceAgeInputField1 = driver1.FindElement(By.Id("InfoPageReplaceAgeInputField"));
                IWebElement InfoPageExistingCountryInputField1 = driver1.FindElement(By.Id("InfoPageExistingCountryInputField"));
                IWebElement InfoPageExistingCountryDropdown1 = driver1.FindElement(By.Id("InfoPageinputGroupCountrySelect"));
                IWebElement InfoPageExistingRegionInputField1 = driver1.FindElement(By.Id("InfoPageExistingRegionInputField"));
                IWebElement InfoPageExistingRegionDropdown1 = driver1.FindElement(By.Id("InfoPageinputGroupRegionSelect"));
                IWebElement InfoPageExistingCompanyInputField1 = driver1.FindElement(By.Id("InfoPageExistingCompanyInputField"));
                IWebElement InfoPageReplaceCompanyNameInputField1 = driver1.FindElement(By.Id("InfoPageReplaceCompanyNameInputField"));
                IWebElement InfoPageExistingSkillInputField1 = driver1.FindElement(By.Id("InfoPageExistingSkillInputField"));
                IWebElement InfoPageReplaceSkillInputField1 = driver1.FindElement(By.Id("InfoPageReplaceSkillInputField"));
                IWebElement InfoPageinputGroupSkillSelect1 = driver1.FindElement(By.Id("InfoPageinputGroupSkillSelect"));
                IWebElement InfoPageExistingAreaOfInterestInputField1 = driver1.FindElement(By.Id("InfoPageExistingAreaOfInterestInputField"));
                IWebElement InfoPageinputGroupInterestsSelect1 = driver1.FindElement(By.Id("InfoPageinputGroupInterestsSelect"));
                IWebElement InfoPageReplaceAreaOfInterestInputField1 = driver1.FindElement(By.Id("InfoPageReplaceAreaOfInterestInputField"));
                IWebElement InfoPageInput_MarketingComms1 = driver1.FindElement(By.Id("InfoPageInput_MarketingComms"));
                IWebElement InfoPageButton1 = driver1.FindElement(By.Id("InfoPageButton"));

                string InfoPageExistingFirstNameInputField_string1 = InfoPageExistingFirstNameInputField1.GetAttribute("value");
                string InfoPageReplaceFirstNameInputField_string1 = InfoPageReplaceFirstNameInputField1.GetAttribute("value");
                string InfoPageExistingSurNameInputField_string1 = InfoPageExistingSurNameInputField1.GetAttribute("value");
                string InfoPageReplaceSurNameInputField_string1 = InfoPageReplaceSurNameInputField1.GetAttribute("value");
                string InfoPageExistingAgeInputField_string1 = InfoPageExistingAgeInputField1.GetAttribute("value");
                string InfoPageReplaceAgeInputField_string1 = InfoPageReplaceAgeInputField1.GetAttribute("value");
                string InfoPageExistingCountryInputField_string1 = InfoPageExistingCountryInputField1.GetAttribute("value");
                string InfoPageExistingRegionInputField_string1 = InfoPageExistingRegionInputField1.GetAttribute("value");
                string InfoPageExistingCompanyInputField_string1 = InfoPageExistingCompanyInputField1.GetAttribute("value");
                string InfoPageReplaceCompanyNameInputField_string1 = InfoPageReplaceCompanyNameInputField1.GetAttribute("value");
                string InfoPageExistingSkillInputField_string1 = InfoPageExistingSkillInputField1.GetAttribute("value");
                string InfoPageReplaceSkillInputField_string2 = InfoPageReplaceSkillInputField1.GetAttribute("value");
                string InfoPageExistingAreaOfInterestInputField_string1 = InfoPageExistingAreaOfInterestInputField1.GetAttribute("value");
                string InfoPageReplaceAreaOfInterestInputField_string2 = InfoPageReplaceAreaOfInterestInputField1.GetAttribute("value");

                Assert.Equal("test", InfoPageExistingFirstNameInputField_string1);
                Assert.False(InfoPageExistingFirstNameInputField1.Enabled);
                Assert.Equal("test", InfoPageReplaceFirstNameInputField_string1);
                Assert.Equal("test", InfoPageExistingSurNameInputField_string1);
                Assert.False(InfoPageExistingSurNameInputField1.Enabled);
                Assert.Equal("test", InfoPageReplaceSurNameInputField_string1);
                Assert.Equal("11", InfoPageExistingAgeInputField_string1);
                Assert.False(InfoPageExistingAgeInputField1.Enabled);
                Assert.Equal("11", InfoPageReplaceAgeInputField_string1);
                Assert.Equal("Australia", InfoPageExistingCountryInputField_string1);
                Assert.False(InfoPageExistingCountryInputField1.Enabled);
                Assert.Equal("Victoria", InfoPageExistingRegionInputField_string1);
                Assert.False(InfoPageExistingRegionInputField1.Enabled);
                Assert.Equal("test", InfoPageExistingCompanyInputField_string1);
                Assert.False(InfoPageExistingCompanyInputField1.Enabled);
                Assert.Equal("test", InfoPageReplaceCompanyNameInputField_string1);
                Assert.Equal("test,Biologist", InfoPageExistingSkillInputField_string1);
                Assert.False(InfoPageExistingSkillInputField1.Enabled);
                Assert.Equal("test,Biologist", InfoPageReplaceSkillInputField_string1);
                Assert.Equal("test,All", InfoPageExistingAreaOfInterestInputField_string1);
                Assert.False(InfoPageExistingAreaOfInterestInputField1.Enabled);
                Assert.Equal("test,All", InfoPageReplaceAreaOfInterestInputField_string2);
                Assert.False(InfoPageExistingRegionDropdown1.Enabled);
                Assert.True(InfoPageInput_MarketingComms1.Displayed);
                Assert.False(InfoPageInput_MarketingComms1.Selected);

                InfoPageReplaceFirstNameInputField1.Clear();
                InfoPageReplaceFirstNameInputField1.SendKeys("123456");
                InfoPageReplaceSurNameInputField1.Clear();
                InfoPageReplaceSurNameInputField1.SendKeys("123456");
                InfoPageReplaceAgeInputField1.Clear();
                InfoPageReplaceAgeInputField1.SendKeys("99");
                InfoPageExistingCountryDropdown1.Click();
                new SelectElement(driver1.FindElement(By.Id("InfoPageinputGroupCountrySelect"))).SelectByText("Ireland");
                Assert.True(InfoPageExistingRegionDropdown1.Enabled);
                new SelectElement(driver1.FindElement(By.Id("InfoPageinputGroupRegionSelect"))).SelectByText("Kildare");
                InfoPageReplaceCompanyNameInputField1.Clear();
                InfoPageReplaceCompanyNameInputField1.SendKeys("123456");
                InfoPageReplaceSkillInputField1.Clear();
                InfoPageReplaceSkillInputField1.SendKeys("Agile,");
                InfoPageinputGroupSkillSelect1.Click();
                new SelectElement(driver1.FindElement(By.Id("InfoPageinputGroupSkillSelect"))).SelectByText("Professional Scrum");
                string InfoPageReplaceSkillInputField_string3 = InfoPageReplaceSkillInputField1.GetAttribute("value");
                Assert.Equal("Agile,Professional Scrum", InfoPageReplaceSkillInputField_string3);
                InfoPageReplaceAreaOfInterestInputField1.Clear();
                InfoPageReplaceAreaOfInterestInputField1.SendKeys("All,");
                InfoPageinputGroupInterestsSelect1.Click();
                new SelectElement(driver1.FindElement(By.Id("InfoPageinputGroupInterestsSelect"))).SelectByText("Deforestation");
                string InfoPageReplaceAreaOfInterestInputField_string3 = InfoPageReplaceAreaOfInterestInputField1.GetAttribute("value");
                Assert.Equal("All,Deforestation", InfoPageReplaceAreaOfInterestInputField_string3);
                InfoPageInput_MarketingComms1.Click();
                Assert.True(InfoPageInput_MarketingComms1.Selected);
                InfoPageButton1.Click();

            }, filename, driver1);
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
            var filename = "TestInfoPageComponentsArePresent_CheckFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();

                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                driver.Navigate().GoToUrl(LoginUrl);
                IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
                IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
                IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));
                string UserEmail = UITestStrings.Test3UserEmail();
                string UserPassword = UITestStrings.Test3UserPassword();

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Keys.Tab);
                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Keys.Tab);
                LoginEmailInputField.SendKeys(UserEmail);
                LoginPasswordInputField.SendKeys(UserPassword);

                LoginButton.Click();

                string infoUrl = UrlRefLibrary.GetInfoPageLocalHostUrl();
                driver.Navigate().GoToUrl(infoUrl);

                IWebElement FooterElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("nav-footer")));
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
    }
}
