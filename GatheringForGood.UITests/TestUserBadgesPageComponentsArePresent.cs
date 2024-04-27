using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using UITestStringsLibrary;
using System.Drawing;

namespace GatheringForGood.UITests
{
    public class TestUserBadgesPageComponentsArePresent
    {
        readonly CrossPageSharedUITestStrings UITestStrings = new UITestStringsLibrary.CrossPageSharedUITestStrings();

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
            var filename = "TestUserBadgesPageComponentsArePresent_CheckImagesAreDisplayed";

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

                string UserBadgesUrl = UrlRefLibrary.GetUserBadgesPageLocalHostUrl();
                driver.Navigate().GoToUrl(UserBadgesUrl);
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("UserBadgesPageBanner")));
                IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));
                IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_UserBadgesPageLogoImg"));
                IWebElement HelpfulBadgeImageIconImage = driver.FindElement(By.Id("HelpfulBadgeImageIconImage"));
                IWebElement LeaderBadgeImageIconImage = driver.FindElement(By.Id("LeaderBadgeImageIconImage"));
                IWebElement VisionaryBadgeImageIconImage = driver.FindElement(By.Id("VisionaryBadgeImageIconImage"));
                IWebElement ThankyouBadgeImageIconImage = driver.FindElement(By.Id("ThankyouBadgeImageIconImage"));
                IWebElement FirstStepBadgeImageIconImage = driver.FindElement(By.Id("FirstStepBadgeImageIconImage"));
                IWebElement GathererForGoodBadgeImageIconImage = driver.FindElement(By.Id("GathererForGoodBadgeImageIconImage"));
                IWebElement BuildingBackBetterBadgeImageIconImage = driver.FindElement(By.Id("BuildingBackBetterBadgeImageIconImage"));
                IWebElement KeyDriverOfChangeBadgeImageIconImage = driver.FindElement(By.Id("KeyDriverOfChangeBadgeImageIconImage"));
                IWebElement DefeatGlobalWarmingBadgeImageIconImage = driver.FindElement(By.Id("DefeatGlobalWarmingBadgeImageIconImage"));
                IWebElement DefeatAnimalExtinctionBadgeImageIconImage = driver.FindElement(By.Id("DefeatAnimalExtinctionBadgeImageIconImage"));
                IWebElement DefeatDeforestationBadgeImageIconImage = driver.FindElement(By.Id("DefeatDeforestationBadgeImageIconImage"));
                IWebElement DeeplyCareBadgeImageIconImage = driver.FindElement(By.Id("DeeplyCareBadgeImageIconImage"));
                IWebElement CommunicatingForDifferenceBadgeImageIconImage = driver.FindElement(By.Id("CommunicatingForDifferenceBadgeImageIconImage"));
                IWebElement ContributorForGoodBadgeImageIconImage = driver.FindElement(By.Id("ContributorForGoodBadgeImageIconImage"));
                IWebElement FeedbackHeroBadgeImageIconImage = driver.FindElement(By.Id("FeedbackHeroBadgeImageIconImage"));
                IWebElement LearningForGoodBadgeImageIconImage = driver.FindElement(By.Id("LearningForGoodBadgeImageIconImage"));
                IWebElement MakingADifferenceBadgeImageIconImage = driver.FindElement(By.Id("MakingADifferenceBadgeImageIconImage"));

                Assert.True(BannerImageElement.Displayed);
                Assert.True(BodyBackground.Displayed);
                Assert.True(_LayoutPageLogoElement.Displayed);
                Assert.True(HelpfulBadgeImageIconImage.Displayed);
                Assert.True(LeaderBadgeImageIconImage.Displayed);
                Assert.True(VisionaryBadgeImageIconImage.Displayed);
                Assert.True(ThankyouBadgeImageIconImage.Displayed);
                Assert.True(FirstStepBadgeImageIconImage.Displayed);
                Assert.True(GathererForGoodBadgeImageIconImage.Displayed);
                Assert.True(BuildingBackBetterBadgeImageIconImage.Displayed);
                Assert.True(KeyDriverOfChangeBadgeImageIconImage.Displayed);
                Assert.True(DefeatGlobalWarmingBadgeImageIconImage.Displayed);
                Assert.True(DefeatAnimalExtinctionBadgeImageIconImage.Displayed);
                Assert.True(DefeatDeforestationBadgeImageIconImage.Displayed);
                Assert.True(DeeplyCareBadgeImageIconImage.Displayed);
                Assert.True(CommunicatingForDifferenceBadgeImageIconImage.Displayed);
                Assert.True(ContributorForGoodBadgeImageIconImage.Displayed);
                Assert.True(FeedbackHeroBadgeImageIconImage.Displayed);
                Assert.True(LearningForGoodBadgeImageIconImage.Displayed);
                Assert.True(MakingADifferenceBadgeImageIconImage.Displayed);


                driver.Manage().Window.Size = new Size(240, 600);

                Assert.True(BannerImageElement.Displayed);
                Assert.True(BodyBackground.Displayed);
                Assert.True(_LayoutPageLogoElement.Displayed);
                Assert.True(HelpfulBadgeImageIconImage.Displayed);
                Assert.True(LeaderBadgeImageIconImage.Displayed);
                Assert.True(VisionaryBadgeImageIconImage.Displayed);
                Assert.True(ThankyouBadgeImageIconImage.Displayed);
                Assert.True(FirstStepBadgeImageIconImage.Displayed);
                Assert.True(GathererForGoodBadgeImageIconImage.Displayed);
                Assert.True(BuildingBackBetterBadgeImageIconImage.Displayed);
                Assert.True(KeyDriverOfChangeBadgeImageIconImage.Displayed);
                Assert.True(DefeatGlobalWarmingBadgeImageIconImage.Displayed);
                Assert.True(DefeatAnimalExtinctionBadgeImageIconImage.Displayed);
                Assert.True(DefeatDeforestationBadgeImageIconImage.Displayed);
                Assert.True(DeeplyCareBadgeImageIconImage.Displayed);
                Assert.True(CommunicatingForDifferenceBadgeImageIconImage.Displayed);
                Assert.True(ContributorForGoodBadgeImageIconImage.Displayed);
                Assert.True(FeedbackHeroBadgeImageIconImage.Displayed);
                Assert.True(LearningForGoodBadgeImageIconImage.Displayed);
                Assert.True(MakingADifferenceBadgeImageIconImage.Displayed);


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
            var filename = "TestUserBadgesPageComponentsArePresent_CheckNavBarIsDisplayed";

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

                string UserBadgesUrl = UrlRefLibrary.GetUserBadgesPageLocalHostUrl();
                driver.Navigate().GoToUrl(UserBadgesUrl);

                driver.Manage().Window.Maximize();
                Thread.Sleep(1000);
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-userbadges-page")));
                IWebElement NavBarHomeLinkElement = driver.FindElement(By.Id("_UserBadgesPageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement = driver.FindElement(By.Id("_UserBadgesPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_UserBadgesPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_UserBadgesPageHelpNavLink"));

                Assert.True(NavBarElement.Displayed);
                Assert.True(NavBarHomeLinkElement.Displayed);
                Assert.True(NavBarArticlesLinkElement.Displayed);
                Assert.True(NavBarAboutLinkElement.Displayed);
                Assert.True(NavBarHelpLinkElement.Displayed);

                Assert.Equal("HOME", NavBarHomeLinkElement.Text);
                Assert.Equal("ARTICLES", NavBarArticlesLinkElement.Text);
                Assert.Equal("ABOUT", NavBarAboutLinkElement.Text);
                Assert.Equal("HELP CENTER", NavBarHelpLinkElement.Text);
            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Long")]
        [Trait("TestEnvironment", "Local")]
        public void CheckTextSectionsAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestUserBadgesPageComponentsArePresent_CheckTextSectionsAreDisplayed";

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

                string UserBadgesUrl = UrlRefLibrary.GetUserBadgesPageLocalHostUrl();
                driver.Navigate().GoToUrl(UserBadgesUrl);

                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-userbadges-page")));
                IWebElement TitleElement = driver.FindElement(By.Id("UserBadgesPageTitle"));
                IWebElement SubTitleElement = driver.FindElement(By.Id("UserBadgesPageSubtitle"));
                IWebElement MyAwardsAndBadgesTitle = driver.FindElement(By.Id("MyAwardsAndBadgesTitle"));
                IWebElement HelpfulBadgeImageIconText = driver.FindElement(By.Id("HelpfulBadgeImageIconText"));
                IWebElement HelpfulBadgeInfo = driver.FindElement(By.Id("HelpfulBadgeInfo"));
                IWebElement LeaderBadgeImageIconText = driver.FindElement(By.Id("LeaderBadgeImageIconText"));
                IWebElement LeaderBadgeInfo = driver.FindElement(By.Id("LeaderBadgeInfo"));
                IWebElement VisionaryBadgeImageIconText = driver.FindElement(By.Id("VisionaryBadgeImageIconText"));
                IWebElement VisionaryBadgeInfo = driver.FindElement(By.Id("VisionaryBadgeInfo"));
                IWebElement ThankyouBadgeImageIconText = driver.FindElement(By.Id("ThankyouBadgeImageIconText"));
                IWebElement ThankyouBadgeInfo = driver.FindElement(By.Id("ThankyouBadgeInfo"));
                IWebElement FirstStepBadgeImageIconText = driver.FindElement(By.Id("FirstStepBadgeImageIconText"));
                IWebElement FirstStepBadgeInfo = driver.FindElement(By.Id("FirstStepBadgeInfo"));
                IWebElement GathererForGoodBadgeImageIconText = driver.FindElement(By.Id("GathererForGoodBadgeImageIconText"));
                IWebElement GathererForGoodBadgeInfo = driver.FindElement(By.Id("GathererForGoodBadgeInfo"));
                IWebElement BuildingBackBetterBadgeImageIconText = driver.FindElement(By.Id("BuildingBackBetterBadgeImageIconText"));
                IWebElement BuildingBackBetterBadgeInfo = driver.FindElement(By.Id("BuildingBackBetterBadgeInfo"));
                IWebElement KeyDriverOfChangeBadgeImageIconText = driver.FindElement(By.Id("KeyDriverOfChangeBadgeImageIconText"));
                IWebElement KeyDriverOfChangeBadgeInfo = driver.FindElement(By.Id("KeyDriverOfChangeBadgeInfo"));
                IWebElement DefeatGlobalWarmingBadgeImageIconText = driver.FindElement(By.Id("DefeatGlobalWarmingBadgeImageIconText"));
                IWebElement DefeatGlobalWarmingBadgeInfo = driver.FindElement(By.Id("DefeatGlobalWarmingBadgeInfo"));
                IWebElement DefeatAnimalExtinctionBadgeImageIconText = driver.FindElement(By.Id("DefeatAnimalExtinctionBadgeImageIconText"));
                IWebElement DefeatAnimalExtinctionBadgeInfo = driver.FindElement(By.Id("DefeatAnimalExtinctionBadgeInfo"));
                IWebElement DefeatDeforestationBadgeImageIconText = driver.FindElement(By.Id("DefeatDeforestationBadgeImageIconText"));
                IWebElement DefeatDeforestationBadgeInfo = driver.FindElement(By.Id("DefeatDeforestationBadgeInfo"));
                IWebElement DeeplyCareBadgeImageIconText = driver.FindElement(By.Id("DeeplyCareBadgeImageIconText"));
                IWebElement DeeplyCareBadgeInfo = driver.FindElement(By.Id("DeeplyCareBadgeInfo"));
                IWebElement CommunicatingForDifferenceBadgeImageIconText = driver.FindElement(By.Id("CommunicatingForDifferenceBadgeImageIconText"));
                IWebElement CommunicatingForDifferenceBadgeInfo = driver.FindElement(By.Id("CommunicatingForDifferenceBadgeInfo"));
                IWebElement ContributorForGoodBadgeImageIconText = driver.FindElement(By.Id("ContributorForGoodBadgeImageIconText"));
                IWebElement ContributorForGoodBadgeInfo = driver.FindElement(By.Id("ContributorForGoodBadgeInfo"));
                IWebElement FeedbackHeroBadgeImageIconText = driver.FindElement(By.Id("FeedbackHeroBadgeImageIconText"));
                IWebElement FeedbackHeroBadgeInfo = driver.FindElement(By.Id("FeedbackHeroBadgeInfo"));
                IWebElement LearningForGoodBadgeImageIconText = driver.FindElement(By.Id("LearningForGoodBadgeImageIconText"));
                IWebElement LearningForGoodBadgeInfo = driver.FindElement(By.Id("LearningForGoodBadgeInfo"));
                IWebElement MakingADifferenceBadgeImageIconText = driver.FindElement(By.Id("MakingADifferenceBadgeImageIconText"));
                IWebElement MakingADifferenceBadgeInfo = driver.FindElement(By.Id("MakingADifferenceBadgeInfo"));

                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(MyAwardsAndBadgesTitle.Displayed);
                Assert.True(HelpfulBadgeImageIconText.Displayed);
                Assert.True(HelpfulBadgeInfo.Displayed);
                Assert.True(LeaderBadgeImageIconText.Displayed);
                Assert.True(LeaderBadgeInfo.Displayed);
                Assert.True(VisionaryBadgeImageIconText.Displayed);
                Assert.True(VisionaryBadgeInfo.Displayed);
                Assert.True(ThankyouBadgeImageIconText.Displayed);
                Assert.True(ThankyouBadgeInfo.Displayed);
                Assert.True(FirstStepBadgeImageIconText.Displayed);
                Assert.True(FirstStepBadgeInfo.Displayed);
                Assert.True(GathererForGoodBadgeImageIconText.Displayed);
                Assert.True(GathererForGoodBadgeInfo.Displayed);
                Assert.True(BuildingBackBetterBadgeImageIconText.Displayed);
                Assert.True(BuildingBackBetterBadgeInfo.Displayed);
                Assert.True(KeyDriverOfChangeBadgeImageIconText.Displayed);
                Assert.True(KeyDriverOfChangeBadgeInfo.Displayed);
                Assert.True(DefeatGlobalWarmingBadgeImageIconText.Displayed);
                Assert.True(DefeatGlobalWarmingBadgeInfo.Displayed);
                Assert.True(DefeatAnimalExtinctionBadgeImageIconText.Displayed);
                Assert.True(DefeatAnimalExtinctionBadgeInfo.Displayed);
                Assert.True(DefeatDeforestationBadgeImageIconText.Displayed);
                Assert.True(DefeatDeforestationBadgeInfo.Displayed);
                Assert.True(DeeplyCareBadgeImageIconText.Displayed);
                Assert.True(DeeplyCareBadgeInfo.Displayed);
                Assert.True(CommunicatingForDifferenceBadgeImageIconText.Displayed);
                Assert.True(CommunicatingForDifferenceBadgeInfo.Displayed);
                Assert.True(ContributorForGoodBadgeImageIconText.Displayed);
                Assert.True(ContributorForGoodBadgeInfo.Displayed);
                Assert.True(FeedbackHeroBadgeImageIconText.Displayed);
                Assert.True(FeedbackHeroBadgeInfo.Displayed);
                Assert.True(LearningForGoodBadgeImageIconText.Displayed);
                Assert.True(LearningForGoodBadgeInfo.Displayed);
                Assert.True(MakingADifferenceBadgeImageIconText.Displayed);
                Assert.True(MakingADifferenceBadgeInfo.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);

                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(MyAwardsAndBadgesTitle.Displayed);
                Assert.True(HelpfulBadgeImageIconText.Displayed);
                Assert.True(HelpfulBadgeInfo.Displayed);
                Assert.True(LeaderBadgeImageIconText.Displayed);
                Assert.True(LeaderBadgeInfo.Displayed);
                Assert.True(VisionaryBadgeImageIconText.Displayed);
                Assert.True(VisionaryBadgeInfo.Displayed);
                Assert.True(ThankyouBadgeImageIconText.Displayed);
                Assert.True(ThankyouBadgeInfo.Displayed);
                Assert.True(FirstStepBadgeImageIconText.Displayed);
                Assert.True(FirstStepBadgeInfo.Displayed);
                Assert.True(GathererForGoodBadgeImageIconText.Displayed);
                Assert.True(GathererForGoodBadgeInfo.Displayed);
                Assert.True(BuildingBackBetterBadgeImageIconText.Displayed);
                Assert.True(BuildingBackBetterBadgeInfo.Displayed);
                Assert.True(KeyDriverOfChangeBadgeImageIconText.Displayed);
                Assert.True(KeyDriverOfChangeBadgeInfo.Displayed);
                Assert.True(DefeatGlobalWarmingBadgeImageIconText.Displayed);
                Assert.True(DefeatGlobalWarmingBadgeInfo.Displayed);
                Assert.True(DefeatAnimalExtinctionBadgeImageIconText.Displayed);
                Assert.True(DefeatAnimalExtinctionBadgeInfo.Displayed);
                Assert.True(DefeatDeforestationBadgeImageIconText.Displayed);
                Assert.True(DefeatDeforestationBadgeInfo.Displayed);
                Assert.True(DeeplyCareBadgeImageIconText.Displayed);
                Assert.True(DeeplyCareBadgeInfo.Displayed);
                Assert.True(CommunicatingForDifferenceBadgeImageIconText.Displayed);
                Assert.True(CommunicatingForDifferenceBadgeInfo.Displayed);
                Assert.True(ContributorForGoodBadgeImageIconText.Displayed);
                Assert.True(ContributorForGoodBadgeInfo.Displayed);
                Assert.True(FeedbackHeroBadgeImageIconText.Displayed);
                Assert.True(FeedbackHeroBadgeInfo.Displayed);
                Assert.True(LearningForGoodBadgeImageIconText.Displayed);
                Assert.True(LearningForGoodBadgeInfo.Displayed);
                Assert.True(MakingADifferenceBadgeImageIconText.Displayed);
                Assert.True(MakingADifferenceBadgeInfo.Displayed);

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
            var filename = "TestAboutPageComponentsArePresent_CheckFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string AboutUrl = UrlRefLibrary.GetAboutPageLocalHostUrl();

                driver.Navigate().GoToUrl(AboutUrl);
                driver.Manage().Window.Maximize();
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