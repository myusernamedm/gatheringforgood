using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using OpenQA.Selenium.Support.UI;

namespace GatheringForGood.UITests
{
    public class TestPrivacyPageComponentsArePresent
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
            var filename = "TestPrivacyPageComponentsArePresent_CheckImagesAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string PrivacyUrl = UrlRefLibrary.GetPrivacyPageLocalHostUrl();

            driver.Navigate().GoToUrl(PrivacyUrl);
            driver.Manage().Window.Maximize();
            IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("PrivacyPageBanner")));
            IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));
            IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_PrivacyPageLogoImg"));

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
            var filename = "TestPrivacyPageComponentsArePresent_CheckNavBarIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string PrivacyUrl = UrlRefLibrary.GetPrivacyPageLocalHostUrl();

            driver.Navigate().GoToUrl(PrivacyUrl);
            driver.Manage().Window.Maximize();
            IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-privacy-page")));
            IWebElement NavBarHomeLinkElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_PrivacyPageHomeNavLink")));
            IWebElement NavBarArticlesLinkElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_PrivacyPageArticlesNavLink")));
            IWebElement NavBarAboutLinkElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_PrivacyPageAboutNavLink")));
            IWebElement NavBarHelpLinkElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_PrivacyPageHelpNavLink")));
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
        public void CheckButtonsAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestPrivacyPageComponentsArePresent_CheckButtonsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string PrivacyUrl = UrlRefLibrary.GetPrivacyPageLocalHostUrl();

            driver.Navigate().GoToUrl(PrivacyUrl);
            driver.Manage().Window.Maximize();
            IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-privacy-page")));
            IWebElement MakeADifferenceButtonElement = driver.FindElement(By.Id("PrivacyPageMakeDiffBtn"));

            Assert.True(MakeADifferenceButtonElement.Displayed);
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
            var filename = "TestPrivacyPageComponentsArePresent_CheckTextSectionsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string PrivacyUrl = UrlRefLibrary.GetPrivacyPageLocalHostUrl();

            driver.Navigate().GoToUrl(PrivacyUrl);
            driver.Manage().Window.Maximize();
            IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-privacy-page")));
            IWebElement TitleElement = driver.FindElement(By.Id("PrivacyPageTitle"));
            IWebElement SubTitleElement = driver.FindElement(By.Id("PrivacyPageSubtitle"));

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
            var filename = "TestPrivacyPageComponentsArePresent_CheckMainTextContentIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string PrivacyUrl = UrlRefLibrary.GetPrivacyPageLocalHostUrl();

            driver.Navigate().GoToUrl(PrivacyUrl);
            driver.Manage().Window.Maximize();
            IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-privacy-page")));
            IWebElement YourPrivacyMattersTitle = driver.FindElement(By.Id("YourPrivacyMattersTitle"));
            IWebElement PrivacyEffectiveDate = driver.FindElement(By.Id("PrivacyEffectiveDate"));
            IWebElement PrivacyTableOfContentsTitle = driver.FindElement(By.Id("PrivacyTableOfContentsTitle"));
            IWebElement PrivacyIntroductionLink = driver.FindElement(By.Id("PrivacyIntroductionLink"));
            IWebElement PrivacyDataWeCollectLink = driver.FindElement(By.Id("PrivacyDataWeCollectLink"));
            IWebElement PrivacyHowWeUseYourDataLink = driver.FindElement(By.Id("PrivacyHowWeUseYourDataLink"));
            IWebElement PrivacyHowWeShareInformationLink = driver.FindElement(By.Id("PrivacyHowWeShareInformationLink"));
            IWebElement PrivacyChoicesAndObligationsLink = driver.FindElement(By.Id("PrivacyChoicesAndObligationsLink"));
            IWebElement PrivacyOtherInformationLink = driver.FindElement(By.Id("PrivacyOtherInformationLink"));
            IWebElement YourPrivacyMattersPara1 = driver.FindElement(By.Id("YourPrivacyMattersPara1"));
            IWebElement YourPrivacyMattersPara2 = driver.FindElement(By.Id("YourPrivacyMattersPara2"));
            IWebElement PrivacyIntroductionTitle = driver.FindElement(By.Id("PrivacyIntroductionTitle"));
            IWebElement IntroductionShortPara = driver.FindElement(By.Id("IntroductionShortPara"));
            IWebElement IntroductionPara1 = driver.FindElement(By.Id("IntroductionPara1"));
            IWebElement ServicesTitle = driver.FindElement(By.Id("ServicesTitle"));
            IWebElement ServicesPara1 = driver.FindElement(By.Id("ServicesPara1"));
            IWebElement ServicesShortPara = driver.FindElement(By.Id("ServicesShortPara"));
            IWebElement DataControllersTitle = driver.FindElement(By.Id("DataControllersTitle"));
            IWebElement DataControllersPara1 = driver.FindElement(By.Id("DataControllersPara1"));
            IWebElement DataControllersPara2 = driver.FindElement(By.Id("DataControllersPara2"));
            IWebElement DataControllersShortPara = driver.FindElement(By.Id("DataControllersShortPara"));
            IWebElement PolicyChangesTitle = driver.FindElement(By.Id("PolicyChangesTitle"));
            IWebElement PolicyChangesPara1 = driver.FindElement(By.Id("PolicyChangesPara1"));
            IWebElement PolicyChangesPara2 = driver.FindElement(By.Id("PolicyChangesPara2"));
            IWebElement PolicyChangesShortPara = driver.FindElement(By.Id("PolicyChangesShortPara"));
            IWebElement DataWeCollectTitle = driver.FindElement(By.Id("DataWeCollectTitle"));
            IWebElement RegistrationTitle = driver.FindElement(By.Id("RegistrationTitle"));
            IWebElement RegistrationPara1 = driver.FindElement(By.Id("RegistrationPara1"));
            IWebElement RegistrationShortPara = driver.FindElement(By.Id("RegistrationShortPara"));
            IWebElement ProfileTitle = driver.FindElement(By.Id("ProfileTitle"));
            IWebElement ProfilePara1 = driver.FindElement(By.Id("ProfilePara1"));
            IWebElement ProfilePara2 = driver.FindElement(By.Id("ProfilePara2"));
            IWebElement ProfileShortPara = driver.FindElement(By.Id("ProfileShortPara"));
            IWebElement PostingTitle = driver.FindElement(By.Id("PostingTitle"));
            IWebElement PostingPara1 = driver.FindElement(By.Id("PostingPara1"));
            IWebElement PostingPara2 = driver.FindElement(By.Id("PostingPara2"));
            IWebElement PostingPara3 = driver.FindElement(By.Id("PostingPara3"));
            IWebElement PostingShortPara = driver.FindElement(By.Id("PostingShortPara"));
            IWebElement ContentTitle = driver.FindElement(By.Id("ContentTitle"));
            IWebElement ContentPara1 = driver.FindElement(By.Id("ContentPara1"));
            IWebElement ContentShortPara = driver.FindElement(By.Id("ContentShortPara"));
            IWebElement ContactsAndCalendarTitle = driver.FindElement(By.Id("ContactsAndCalendarTitle"));
            IWebElement ContactsAndCalendarPara1 = driver.FindElement(By.Id("ContactsAndCalendarPara1"));
            IWebElement ContactsAndCalendarShortPara = driver.FindElement(By.Id("ContactsAndCalendarShortPara"));
            IWebElement CustomersAndPartnersTitle = driver.FindElement(By.Id("CustomersAndPartnersTitle"));
            IWebElement CustomersAndPartnersPara1 = driver.FindElement(By.Id("CustomersAndPartnersPara1"));
            IWebElement CustomersAndPartnersShortPara = driver.FindElement(By.Id("CustomersAndPartnersShortPara"));
            IWebElement ServiceUsageTitle = driver.FindElement(By.Id("ServiceUsageTitle"));
            IWebElement ServiceUsagePara1 = driver.FindElement(By.Id("ServiceUsagePara1"));
            IWebElement ServiceUsageShortPara = driver.FindElement(By.Id("ServiceUsageShortPara"));
            IWebElement CookiesTitle = driver.FindElement(By.Id("CookiesTitle"));
            IWebElement CookiesPara1 = driver.FindElement(By.Id("CookiesPara1"));
            IWebElement CookiesPara2 = driver.FindElement(By.Id("CookiesPara2"));
            IWebElement CookiesShortPara = driver.FindElement(By.Id("CookiesShortPara"));
            IWebElement DevicesAndLocationTitle = driver.FindElement(By.Id("DevicesAndLocationTitle"));
            IWebElement DevicesAndLocationPara1 = driver.FindElement(By.Id("DevicesAndLocationPara1"));
            IWebElement DevicesAndLocationShortPara = driver.FindElement(By.Id("DevicesAndLocationShortPara"));
            IWebElement MessagesTitle = driver.FindElement(By.Id("MessagesTitle"));
            IWebElement MessagesPara1 = driver.FindElement(By.Id("MessagesPara1"));
            IWebElement MessagesShortPara = driver.FindElement(By.Id("MessagesShortPara"));
            IWebElement SchoolAndOthersInfoTitle = driver.FindElement(By.Id("SchoolAndOthersInfoTitle"));
            IWebElement SchoolAndOthersInfoPara1 = driver.FindElement(By.Id("SchoolAndOthersInfoPara1"));
            IWebElement SchoolAndOthersInfoPara2 = driver.FindElement(By.Id("SchoolAndOthersInfoPara2"));
            IWebElement SchoolAndOthersInfoShortPara = driver.FindElement(By.Id("SchoolAndOthersInfoShortPara"));
            IWebElement OtherSitesAndServicesTitle = driver.FindElement(By.Id("OtherSitesAndServicesTitle"));
            IWebElement OtherSitesAndServicesPara1 = driver.FindElement(By.Id("OtherSitesAndServicesPara1"));
            IWebElement OtherSitesAndServicesShortPara = driver.FindElement(By.Id("OtherSitesAndServicesShortPara"));
            IWebElement OtherDataWeCollectTitle = driver.FindElement(By.Id("OtherDataWeCollectTitle"));
            IWebElement OtherDataWeCollectPara1 = driver.FindElement(By.Id("OtherDataWeCollectPara1"));
            IWebElement OtherDataWeCollectShortPara = driver.FindElement(By.Id("OtherDataWeCollectShortPara"));
            IWebElement HowWeUseYourDataTitle = driver.FindElement(By.Id("HowWeUseYourDataTitle"));
            IWebElement HowWeUseYourDataPara1 = driver.FindElement(By.Id("HowWeUseYourDataPara1"));
            IWebElement HowWeUseYourDataShortPara = driver.FindElement(By.Id("HowWeUseYourDataShortPara"));
            IWebElement ConnectAndStayConnectedTitle = driver.FindElement(By.Id("ConnectAndStayConnectedTitle"));
            IWebElement ConnectAndStayConnectedPara1 = driver.FindElement(By.Id("ConnectAndStayConnectedPara1"));
            IWebElement ConnectAndStayConnectedPara2 = driver.FindElement(By.Id("ConnectAndStayConnectedPara2"));
            IWebElement ConnectAndStayConnectedPara3 = driver.FindElement(By.Id("ConnectAndStayConnectedPara3"));
            IWebElement ConnectAndStayConnectedShortPara = driver.FindElement(By.Id("ConnectAndStayConnectedShortPara"));
            IWebElement StayInformedTitle = driver.FindElement(By.Id("StayInformedTitle"));
            IWebElement StayInformedPara1 = driver.FindElement(By.Id("StayInformedPara1"));
            IWebElement StayInformedPara2 = driver.FindElement(By.Id("StayInformedPara2"));
            IWebElement StayInformedShortPara = driver.FindElement(By.Id("StayInformedShortPara"));
            IWebElement ProductivityTitle = driver.FindElement(By.Id("ProductivityTitle"));
            IWebElement ProductivityPara1 = driver.FindElement(By.Id("ProductivityPara1"));
            IWebElement ProductivityShortPara = driver.FindElement(By.Id("ProductivityShortPara"));
            IWebElement PaidPremiumServicesTitle = driver.FindElement(By.Id("PaidPremiumServicesTitle"));
            IWebElement PaidPremiumServicesPara1 = driver.FindElement(By.Id("PaidPremiumServicesPara1"));
            IWebElement PaidPremiumServicesPara2 = driver.FindElement(By.Id("PaidPremiumServicesPara2"));
            IWebElement PaidPremiumServicesShortPara = driver.FindElement(By.Id("PaidPremiumServicesShortPara"));
            IWebElement CommunicationsTitle = driver.FindElement(By.Id("CommunicationsTitle"));
            IWebElement CommunicationsPara1 = driver.FindElement(By.Id("CommunicationsPara1"));
            IWebElement CommunicationsPara2 = driver.FindElement(By.Id("CommunicationsPara2"));
            IWebElement CommunicationsShortPara = driver.FindElement(By.Id("CommunicationsShortPara"));
            IWebElement AdvertisingTitle = driver.FindElement(By.Id("AdvertisingTitle"));
            IWebElement AdvertisingPara1 = driver.FindElement(By.Id("AdvertisingPara1"));
            IWebElement AdvertisingPara2 = driver.FindElement(By.Id("AdvertisingPara2"));
            IWebElement AdvertisingPara3 = driver.FindElement(By.Id("AdvertisingPara3"));
            IWebElement AdvertisingPara4 = driver.FindElement(By.Id("AdvertisingPara4"));
            IWebElement AdvertisingPara5 = driver.FindElement(By.Id("AdvertisingPara5"));
            IWebElement AdvertisingPara6 = driver.FindElement(By.Id("AdvertisingPara6"));
            IWebElement AdvertisingPara7 = driver.FindElement(By.Id("AdvertisingPara7"));
            IWebElement AdvertisingShortPara = driver.FindElement(By.Id("AdvertisingShortPara"));
            IWebElement AdChoicesTitle = driver.FindElement(By.Id("AdChoicesTitle"));
            IWebElement AdChoicesPara1 = driver.FindElement(By.Id("AdChoicesPara1"));
            IWebElement AdChoicesShortPara = driver.FindElement(By.Id("AdChoicesShortPara"));
            IWebElement InfoToAdProvidersTitle = driver.FindElement(By.Id("InfoToAdProvidersTitle"));
            IWebElement InfoToAdProvidersPara1 = driver.FindElement(By.Id("InfoToAdProvidersPara1"));
            IWebElement InfoToAdProvidersShortPara = driver.FindElement(By.Id("InfoToAdProvidersShortPara"));
            IWebElement MarketingTitle = driver.FindElement(By.Id("MarketingTitle"));
            IWebElement MarketingPara1 = driver.FindElement(By.Id("MarketingPara1"));
            IWebElement MarketingShortPara = driver.FindElement(By.Id("MarketingShortPara"));
            IWebElement ServiceDevelopmentTitle = driver.FindElement(By.Id("ServiceDevelopmentTitle"));
            IWebElement ServiceDevelopmentPara1 = driver.FindElement(By.Id("ServiceDevelopmentPara1"));
            IWebElement ServiceDevelopmentShortPara = driver.FindElement(By.Id("ServiceDevelopmentShortPara"));
            IWebElement OtherResearchTitle = driver.FindElement(By.Id("OtherResearchTitle"));
            IWebElement OtherResearchPara1 = driver.FindElement(By.Id("OtherResearchPara1"));
            IWebElement OtherResearchPara2 = driver.FindElement(By.Id("OtherResearchPara2"));
            IWebElement OtherResearchShortPara = driver.FindElement(By.Id("OtherResearchShortPara"));
            IWebElement PollsAndSurveysTitle = driver.FindElement(By.Id("PollsAndSurveysTitle"));
            IWebElement PollsAndSurveysPara1 = driver.FindElement(By.Id("PollsAndSurveysPara1"));
            IWebElement PollsAndSurveysShortPara = driver.FindElement(By.Id("PollsAndSurveysShortPara"));
            IWebElement CustomerSupportTitle = driver.FindElement(By.Id("CustomerSupportTitle"));
            IWebElement CustomerSupportPara1 = driver.FindElement(By.Id("CustomerSupportPara1"));
            IWebElement CustomerSupportShortPara = driver.FindElement(By.Id("CustomerSupportShortPara"));
            IWebElement NonIdentifyingInsightsTitle = driver.FindElement(By.Id("NonIdentifyingInsightsTitle"));
            IWebElement NonIdentifyingInsightsPara1 = driver.FindElement(By.Id("NonIdentifyingInsightsPara1"));
            IWebElement NonIdentifyingInsightsShortPara = driver.FindElement(By.Id("NonIdentifyingInsightsShortPara"));
            IWebElement SecurityInvestigationsTitle = driver.FindElement(By.Id("SecurityInvestigationsTitle"));
            IWebElement SecurityInvestigationsPara1 = driver.FindElement(By.Id("SecurityInvestigationsPara1"));
            IWebElement SecurityInvestigationsShortPara = driver.FindElement(By.Id("SecurityInvestigationsShortPara"));
            IWebElement HowWeShareInformationTitle = driver.FindElement(By.Id("HowWeShareInformationTitle"));
            IWebElement YourProfileTitle = driver.FindElement(By.Id("YourProfileTitle"));
            IWebElement YourProfilePara1 = driver.FindElement(By.Id("YourProfilePara1"));
            IWebElement YourProfileShortPara = driver.FindElement(By.Id("YourProfileShortPara"));
            IWebElement PostsLikesTitle = driver.FindElement(By.Id("PostsLikesTitle"));
            IWebElement PostsLikesPara1 = driver.FindElement(By.Id("PostsLikesPara1"));
            IWebElement PostsLikesPara2 = driver.FindElement(By.Id("PostsLikesPara2"));
            IWebElement PostsLikesPara3 = driver.FindElement(By.Id("PostsLikesPara3"));
            IWebElement PostsLikesPara4 = driver.FindElement(By.Id("PostsLikesPara4"));
            IWebElement PostsLikesPara5 = driver.FindElement(By.Id("PostsLikesPara5"));
            IWebElement PostsLikesPara6 = driver.FindElement(By.Id("PostsLikesPara6"));
            IWebElement PostsLikesPara7 = driver.FindElement(By.Id("PostsLikesPara7"));
            IWebElement PostsLikesShortPara = driver.FindElement(By.Id("PostsLikesShortPara"));
            IWebElement EnterpriseAccountsTitle = driver.FindElement(By.Id("EnterpriseAccountsTitle"));
            IWebElement EnterpriseAccountsPara1 = driver.FindElement(By.Id("EnterpriseAccountsPara1"));
            IWebElement EnterpriseAccountsShortPara = driver.FindElement(By.Id("EnterpriseAccountsShortPara"));
            IWebElement OthersServicesTitle = driver.FindElement(By.Id("OthersServicesTitle"));
            IWebElement OthersServicesPara1 = driver.FindElement(By.Id("OthersServicesPara1"));
            IWebElement OthersServicesPara2 = driver.FindElement(By.Id("OthersServicesPara2"));
            IWebElement OthersServicesShortPara = driver.FindElement(By.Id("OthersServicesShortPara"));
            IWebElement RelatedServicesTitle = driver.FindElement(By.Id("RelatedServicesTitle"));
            IWebElement RelatedServicesPara1 = driver.FindElement(By.Id("RelatedServicesPara1"));
            IWebElement RelatedServicesShortPara = driver.FindElement(By.Id("RelatedServicesShortPara"));
            IWebElement ServiceProvidersTitle = driver.FindElement(By.Id("ServiceProvidersTitle"));
            IWebElement ServiceProvidersPara1 = driver.FindElement(By.Id("ServiceProvidersPara1"));
            IWebElement ServiceProvidersShortPara = driver.FindElement(By.Id("ServiceProvidersShortPara"));
            IWebElement LegalDisclosuresTitle = driver.FindElement(By.Id("LegalDisclosuresTitle"));
            IWebElement LegalDisclosuresPara1 = driver.FindElement(By.Id("LegalDisclosuresPara1"));
            IWebElement LegalDisclosuresPara2 = driver.FindElement(By.Id("LegalDisclosuresPara2"));
            IWebElement LegalDisclosuresShortPara = driver.FindElement(By.Id("LegalDisclosuresShortPara"));
            IWebElement ChangeInControlTitle = driver.FindElement(By.Id("ChangeInControlTitle"));
            IWebElement ChangeInControlPara1 = driver.FindElement(By.Id("ChangeInControlPara1"));
            IWebElement ChangeInControlShortPara = driver.FindElement(By.Id("ChangeInControlShortPara"));
            IWebElement ChoicesAndObligationsTitle = driver.FindElement(By.Id("ChoicesAndObligationsTitle"));
            IWebElement DataRetentionTitle = driver.FindElement(By.Id("DataRetentionTitle"));
            IWebElement DataRetentionPara1 = driver.FindElement(By.Id("DataRetentionPara1"));
            IWebElement DataRetentionShortPara = driver.FindElement(By.Id("DataRetentionShortPara"));
            IWebElement DataAccessControlTitle = driver.FindElement(By.Id("DataAccessControlTitle"));
            IWebElement DataAccessControlPara1 = driver.FindElement(By.Id("DataAccessControlPara1"));
            IWebElement DataAccessControlPara2 = driver.FindElement(By.Id("DataAccessControlPara2"));
            IWebElement DataAccessControlPara3 = driver.FindElement(By.Id("DataAccessControlPara3"));
            IWebElement DataAccessControlPara4 = driver.FindElement(By.Id("DataAccessControlPara4"));
            IWebElement DataAccessControlShortPara = driver.FindElement(By.Id("DataAccessControlShortPara"));
            IWebElement DeleteAccountTitle = driver.FindElement(By.Id("DeleteAccountTitle"));
            IWebElement DeleteAccountPara1 = driver.FindElement(By.Id("DeleteAccountPara1"));
            IWebElement DeleteAccountPara2 = driver.FindElement(By.Id("DeleteAccountPara2"));
            IWebElement DeleteAccountPara3 = driver.FindElement(By.Id("DeleteAccountPara3"));
            IWebElement DeleteAccountShortPara = driver.FindElement(By.Id("DeleteAccountShortPara"));
            IWebElement OtherInformationTitle = driver.FindElement(By.Id("OtherInformationTitle"));
            IWebElement SecurityTitle = driver.FindElement(By.Id("SecurityTitle"));
            IWebElement SecurityPara1 = driver.FindElement(By.Id("SecurityPara1"));
            IWebElement SecurityPara2 = driver.FindElement(By.Id("SecurityPara2"));
            IWebElement SecurityShortPara = driver.FindElement(By.Id("SecurityShortPara"));
            IWebElement CrossBorderDataTitle = driver.FindElement(By.Id("CrossBorderDataTitle"));
            IWebElement CrossBorderDataPara1 = driver.FindElement(By.Id("CrossBorderDataPara1"));
            IWebElement CrossBorderDataShortPara = driver.FindElement(By.Id("CrossBorderDataShortPara"));
            IWebElement ProcessingLawfulBasisTitle = driver.FindElement(By.Id("ProcessingLawfulBasisTitle"));
            IWebElement ProcessingLawfulBasisPara1 = driver.FindElement(By.Id("ProcessingLawfulBasisPara1"));
            IWebElement ProcessingLawfulBasisShortPara = driver.FindElement(By.Id("ProcessingLawfulBasisShortPara"));
            IWebElement ContactUsTitle = driver.FindElement(By.Id("ContactUsTitle"));
            IWebElement ContactUsPara1 = driver.FindElement(By.Id("ContactUsPara1"));
            IWebElement ContactUsShortPara = driver.FindElement(By.Id("ContactUsShortPara"));

            Assert.True(YourPrivacyMattersTitle.Displayed);
            Assert.True(PrivacyEffectiveDate.Displayed);
            Assert.True(PrivacyTableOfContentsTitle.Displayed);
            Assert.True(PrivacyIntroductionLink.Displayed);
            Assert.True(PrivacyDataWeCollectLink.Displayed);
            Assert.True(PrivacyHowWeUseYourDataLink.Displayed);
            Assert.True(PrivacyHowWeShareInformationLink.Displayed);
            Assert.True(PrivacyChoicesAndObligationsLink.Displayed);
            Assert.True(PrivacyOtherInformationLink.Displayed);
            Assert.True(YourPrivacyMattersPara1.Displayed);
            Assert.True(YourPrivacyMattersPara2.Displayed);
            Assert.True(PrivacyIntroductionTitle.Displayed);
            Assert.True(IntroductionShortPara.Displayed);
            Assert.True(IntroductionPara1.Displayed);
            Assert.True(ServicesTitle.Displayed);
            Assert.True(ServicesPara1.Displayed);
            Assert.True(ServicesShortPara.Displayed);
            Assert.True(DataControllersTitle.Displayed);
            Assert.True(DataControllersPara1.Displayed);
            Assert.True(DataControllersPara2.Displayed);
            Assert.True(DataControllersShortPara.Displayed);
            Assert.True(PolicyChangesTitle.Displayed);
            Assert.True(PolicyChangesPara1.Displayed);
            Assert.True(PolicyChangesPara2.Displayed);
            Assert.True(PolicyChangesShortPara.Displayed);
            Assert.True(DataWeCollectTitle.Displayed);
            Assert.True(RegistrationTitle.Displayed);
            Assert.True(RegistrationPara1.Displayed);
            Assert.True(RegistrationShortPara.Displayed);
            Assert.True(ProfileTitle.Displayed);
            Assert.True(ProfilePara1.Displayed);
            Assert.True(ProfilePara2.Displayed);
            Assert.True(ProfileShortPara.Displayed);
            Assert.True(PostingTitle.Displayed);
            Assert.True(PostingPara1.Displayed);
            Assert.True(PostingPara2.Displayed);
            Assert.True(PostingPara3.Displayed);
            Assert.True(PostingShortPara.Displayed);
            Assert.True(ContentTitle.Displayed);
            Assert.True(ContentPara1.Displayed);
            Assert.True(ContentShortPara.Displayed);
            Assert.True(ContactsAndCalendarTitle.Displayed);
            Assert.True(ContactsAndCalendarPara1.Displayed);
            Assert.True(ContactsAndCalendarShortPara.Displayed);
            Assert.True(CustomersAndPartnersTitle.Displayed);
            Assert.True(CustomersAndPartnersPara1.Displayed);
            Assert.True(CustomersAndPartnersShortPara.Displayed);
            Assert.True(ServiceUsageTitle.Displayed);
            Assert.True(ServiceUsagePara1.Displayed);
            Assert.True(ServiceUsageShortPara.Displayed);
            Assert.True(CookiesTitle.Displayed);
            Assert.True(CookiesPara1.Displayed);
            Assert.True(CookiesPara2.Displayed);
            Assert.True(CookiesShortPara.Displayed);
            Assert.True(DevicesAndLocationTitle.Displayed);
            Assert.True(DevicesAndLocationPara1.Displayed);
            Assert.True(DevicesAndLocationShortPara.Displayed);
            Assert.True(MessagesTitle.Displayed);
            Assert.True(MessagesPara1.Displayed);
            Assert.True(MessagesShortPara.Displayed);
            Assert.True(SchoolAndOthersInfoTitle.Displayed);
            Assert.True(SchoolAndOthersInfoPara1.Displayed);
            Assert.True(SchoolAndOthersInfoPara2.Displayed);
            Assert.True(SchoolAndOthersInfoShortPara.Displayed);
            Assert.True(OtherSitesAndServicesTitle.Displayed);
            Assert.True(OtherSitesAndServicesPara1.Displayed);
            Assert.True(OtherSitesAndServicesShortPara.Displayed);
            Assert.True(OtherDataWeCollectTitle.Displayed);
            Assert.True(OtherDataWeCollectPara1.Displayed);
            Assert.True(OtherDataWeCollectShortPara.Displayed);
            Assert.True(HowWeUseYourDataTitle.Displayed);
            Assert.True(HowWeUseYourDataPara1.Displayed);
            Assert.True(HowWeUseYourDataShortPara.Displayed);
            Assert.True(ConnectAndStayConnectedTitle.Displayed);
            Assert.True(ConnectAndStayConnectedPara1.Displayed);
            Assert.True(ConnectAndStayConnectedPara2.Displayed);
            Assert.True(ConnectAndStayConnectedPara3.Displayed);
            Assert.True(ConnectAndStayConnectedShortPara.Displayed);
            Assert.True(StayInformedTitle.Displayed);
            Assert.True(StayInformedPara1.Displayed);
            Assert.True(StayInformedPara2.Displayed);
            Assert.True(StayInformedShortPara.Displayed);
            Assert.True(ProductivityTitle.Displayed);
            Assert.True(ProductivityPara1.Displayed);
            Assert.True(ProductivityShortPara.Displayed);
            Assert.True(PaidPremiumServicesTitle.Displayed);
            Assert.True(PaidPremiumServicesPara1.Displayed);
            Assert.True(PaidPremiumServicesPara2.Displayed);
            Assert.True(PaidPremiumServicesShortPara.Displayed);
            Assert.True(CommunicationsTitle.Displayed);
            Assert.True(CommunicationsPara1.Displayed);
            Assert.True(CommunicationsPara2.Displayed);
            Assert.True(CommunicationsShortPara.Displayed);
            Assert.True(AdvertisingTitle.Displayed);
            Assert.True(AdvertisingPara1.Displayed);
            Assert.True(AdvertisingPara2.Displayed);
            Assert.True(AdvertisingPara3.Displayed);
            Assert.True(AdvertisingPara4.Displayed);
            Assert.True(AdvertisingPara5.Displayed);
            Assert.True(AdvertisingPara6.Displayed);
            Assert.True(AdvertisingPara7.Displayed);
            Assert.True(AdvertisingShortPara.Displayed);
            Assert.True(AdChoicesTitle.Displayed);
            Assert.True(AdChoicesPara1.Displayed);
            Assert.True(AdChoicesShortPara.Displayed);
            Assert.True(InfoToAdProvidersTitle.Displayed);
            Assert.True(InfoToAdProvidersPara1.Displayed);
            Assert.True(InfoToAdProvidersShortPara.Displayed);
            Assert.True(MarketingTitle.Displayed);
            Assert.True(MarketingPara1.Displayed);
            Assert.True(MarketingShortPara.Displayed);
            Assert.True(ServiceDevelopmentTitle.Displayed);
            Assert.True(ServiceDevelopmentPara1.Displayed);
            Assert.True(ServiceDevelopmentShortPara.Displayed);
            Assert.True(OtherResearchTitle.Displayed);
            Assert.True(OtherResearchPara1.Displayed);
            Assert.True(OtherResearchPara2.Displayed);
            Assert.True(OtherResearchShortPara.Displayed);
            Assert.True(PollsAndSurveysTitle.Displayed);
            Assert.True(PollsAndSurveysPara1.Displayed);
            Assert.True(PollsAndSurveysShortPara.Displayed);
            Assert.True(CustomerSupportTitle.Displayed);
            Assert.True(CustomerSupportPara1.Displayed);
            Assert.True(CustomerSupportShortPara.Displayed);
            Assert.True(NonIdentifyingInsightsTitle.Displayed);
            Assert.True(NonIdentifyingInsightsPara1.Displayed);
            Assert.True(NonIdentifyingInsightsShortPara.Displayed);
            Assert.True(SecurityInvestigationsTitle.Displayed);
            Assert.True(SecurityInvestigationsPara1.Displayed);
            Assert.True(SecurityInvestigationsShortPara.Displayed);
            Assert.True(HowWeShareInformationTitle.Displayed);
            Assert.True(YourProfileTitle.Displayed);
            Assert.True(YourProfilePara1.Displayed);
            Assert.True(YourProfileShortPara.Displayed);
            Assert.True(PostsLikesTitle.Displayed);
            Assert.True(PostsLikesPara1.Displayed);
            Assert.True(PostsLikesPara2.Displayed);
            Assert.True(PostsLikesPara3.Displayed);
            Assert.True(PostsLikesPara4.Displayed);
            Assert.True(PostsLikesPara5.Displayed);
            Assert.True(PostsLikesPara6.Displayed);
            Assert.True(PostsLikesPara7.Displayed);
            Assert.True(PostsLikesShortPara.Displayed);
            Assert.True(EnterpriseAccountsTitle.Displayed);
            Assert.True(EnterpriseAccountsPara1.Displayed);
            Assert.True(EnterpriseAccountsShortPara.Displayed);
            Assert.True(OthersServicesTitle.Displayed);
            Assert.True(OthersServicesPara1.Displayed);
            Assert.True(OthersServicesPara2.Displayed);
            Assert.True(OthersServicesShortPara.Displayed);
            Assert.True(RelatedServicesTitle.Displayed);
            Assert.True(RelatedServicesPara1.Displayed);
            Assert.True(RelatedServicesShortPara.Displayed);
            Assert.True(ServiceProvidersTitle.Displayed);
            Assert.True(ServiceProvidersPara1.Displayed);
            Assert.True(ServiceProvidersShortPara.Displayed);
            Assert.True(LegalDisclosuresTitle.Displayed);
            Assert.True(LegalDisclosuresPara1.Displayed);
            Assert.True(LegalDisclosuresPara2.Displayed);
            Assert.True(LegalDisclosuresShortPara.Displayed);
            Assert.True(ChangeInControlTitle.Displayed);
            Assert.True(ChangeInControlPara1.Displayed);
            Assert.True(ChangeInControlShortPara.Displayed);
            Assert.True(ChoicesAndObligationsTitle.Displayed);
            Assert.True(DataRetentionTitle.Displayed);
            Assert.True(DataRetentionPara1.Displayed);
            Assert.True(DataRetentionShortPara.Displayed);
            Assert.True(DataAccessControlTitle.Displayed);
            Assert.True(DataAccessControlPara1.Displayed);
            Assert.True(DataAccessControlPara2.Displayed);
            Assert.True(DataAccessControlPara3.Displayed);
            Assert.True(DataAccessControlPara4.Displayed);
            Assert.True(DataAccessControlShortPara.Displayed);
            Assert.True(DeleteAccountTitle.Displayed);
            Assert.True(DeleteAccountPara1.Displayed);
            Assert.True(DeleteAccountPara2.Displayed);
            Assert.True(DeleteAccountPara3.Displayed);
            Assert.True(DeleteAccountShortPara.Displayed);
            Assert.True(OtherInformationTitle.Displayed);
            Assert.True(SecurityTitle.Displayed);
            Assert.True(SecurityPara1.Displayed);
            Assert.True(SecurityPara2.Displayed);
            Assert.True(SecurityShortPara.Displayed);
            Assert.True(CrossBorderDataTitle.Displayed);
            Assert.True(CrossBorderDataPara1.Displayed);
            Assert.True(CrossBorderDataShortPara.Displayed);
            Assert.True(ProcessingLawfulBasisTitle.Displayed);
            Assert.True(ProcessingLawfulBasisPara1.Displayed);
            Assert.True(ProcessingLawfulBasisShortPara.Displayed);
            Assert.True(ContactUsTitle.Displayed);
            Assert.True(ContactUsPara1.Displayed);
            Assert.True(ContactUsShortPara.Displayed);
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
            var filename = "TestPrivacyPageComponentsArePresent_CheckFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
            string PrivacyUrl = UrlRefLibrary.GetPrivacyPageLocalHostUrl();

            driver.Navigate().GoToUrl(PrivacyUrl);
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

    }
}
