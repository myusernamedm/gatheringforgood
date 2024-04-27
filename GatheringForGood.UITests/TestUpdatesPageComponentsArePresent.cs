using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Drawing;

namespace GatheringForGood.UITests
{
    public class TestUpdatesPageComponentsArePresent
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
            var filename = "TestUpdatesPageComponentsArePresent_CheckImagesAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string UpdatesUrl = UrlRefLibrary.GetUpdatesPageLocalHostUrl();

                driver.Navigate().GoToUrl(UpdatesUrl);
                driver.Manage().Window.Maximize();
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("UpdatesPageBanner")));
                IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_UpdatesPageLogoImg"));
                IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));
                IWebElement FooterTwitterShareIconImage = driver.FindElement(By.Id("FooterTwitterShareIconImage"));
                IWebElement FooterFBShareIconImage = driver.FindElement(By.Id("FooterFBShareIconImage"));
                IWebElement FooterLinkedinShareIconImage = driver.FindElement(By.Id("FooterLinkedinShareIconImage"));

                Assert.True(BannerImageElement.Displayed);
                Assert.True(_LayoutPageLogoElement.Displayed);
                Assert.True(BodyBackground.Displayed);
                Assert.True(FooterTwitterShareIconImage.Displayed);
                Assert.True(FooterFBShareIconImage.Displayed);
                Assert.True(FooterLinkedinShareIconImage.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);

                Assert.True(_LayoutPageLogoElement.Displayed);
                Assert.True(BodyBackground.Displayed);
                Assert.True(FooterTwitterShareIconImage.Displayed);
                Assert.True(FooterFBShareIconImage.Displayed);
                Assert.True(FooterLinkedinShareIconImage.Displayed);

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
            var filename = "TestUpdatesPageComponentsArePresent_CheckNavBarIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string UpdatesUrl = UrlRefLibrary.GetUpdatesPageLocalHostUrl();

                driver.Navigate().GoToUrl(UpdatesUrl);
                driver.Manage().Window.Maximize();
                Thread.Sleep(1000);
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-updates-page")));
                IWebElement NavBarHomeLinkElement = driver.FindElement(By.Id("_UpdatesPageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement = driver.FindElement(By.Id("_UpdatesPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_UpdatesPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_UpdatesPageHelpNavLink"));
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
        [Trait("RunTime", "Long")]
        [Trait("TestEnvironment", "Local")]
        public void CheckTextSectionsAreDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestUpdatesPageComponentsArePresent_CheckTextSectionsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string UpdatesUrl = UrlRefLibrary.GetUpdatesPageLocalHostUrl();

                driver.Navigate().GoToUrl(UpdatesUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-updates-page")));
                IWebElement TitleElement = driver.FindElement(By.Id("UpdatesPageTitle"));
                IWebElement SubTitleElement = driver.FindElement(By.Id("UpdatesPageSubtitle"));
                IWebElement UpdatesHeading = driver.FindElement(By.Id("UpdatesHeading"));
                IWebElement UpdatesPageHeadingPara = driver.FindElement(By.Id("UpdatesPageHeadingPara"));

                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(UpdatesHeading.Displayed);
                Assert.True(UpdatesPageHeadingPara.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);

                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(UpdatesHeading.Displayed);
                Assert.True(UpdatesPageHeadingPara.Displayed);

            }, filename, driver);
        }

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged Out")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Long")]
        [Trait("TestEnvironment", "Local")]
        public void CheckUpdatesTableIsDisplayed()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestUpdatesPageComponentsArePresent_CheckUpdatesTableIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string UpdatesUrl = UrlRefLibrary.GetUpdatesPageLocalHostUrl();

                driver.Navigate().GoToUrl(UpdatesUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-updates-page")));
                IWebElement UpdatesPageTable = driver.FindElement(By.Id("UpdatesPageTable"));
                IWebElement UpdatesPageTableCheckMarkColumn = driver.FindElement(By.Id("UpdatesPageTableCheckMarkColumn"));
                IWebElement UpdatesPageTableDateColumn = driver.FindElement(By.Id("UpdatesPageTableDateColumn"));
                IWebElement UpdatesPageTableDetailsColumn = driver.FindElement(By.Id("UpdatesPageTableDetailsColumn"));
                IWebElement UpdatesPageTableFeedbackItemColumn = driver.FindElement(By.Id("UpdatesPageTableFeedbackItemColumn"));

                IWebElement UpdatesPageTableRow28Date = driver.FindElement(By.Id("UpdatesPageTableRow28Date"));
                IWebElement UpdatesPageTableRow28Details = driver.FindElement(By.Id("UpdatesPageTableRow28Details"));
                IWebElement UpdatesPageTableRow28Pill = driver.FindElement(By.Id("UpdatesPageTableRow28Pill"));

                IWebElement UpdatesPageTableRow27Date = driver.FindElement(By.Id("UpdatesPageTableRow27Date"));
                IWebElement UpdatesPageTableRow27Details = driver.FindElement(By.Id("UpdatesPageTableRow27Details"));
                IWebElement UpdatesPageTableRow27Pill = driver.FindElement(By.Id("UpdatesPageTableRow27Pill"));

                IWebElement UpdatesPageTableRow26Date = driver.FindElement(By.Id("UpdatesPageTableRow26Date"));
                IWebElement UpdatesPageTableRow26Details = driver.FindElement(By.Id("UpdatesPageTableRow26Details"));
                IWebElement UpdatesPageTableRow26Pill = driver.FindElement(By.Id("UpdatesPageTableRow26Pill"));

                IWebElement UpdatesPageTableRow25Date = driver.FindElement(By.Id("UpdatesPageTableRow25Date"));
                IWebElement UpdatesPageTableRow25Details = driver.FindElement(By.Id("UpdatesPageTableRow25Details"));
                IWebElement UpdatesPageTableRow25Pill = driver.FindElement(By.Id("UpdatesPageTableRow25Pill"));

                IWebElement UpdatesPageTableRow24Checkmark = driver.FindElement(By.Id("UpdatesPageTableRow24Checkmark"));
                IWebElement UpdatesPageTableRow24Date = driver.FindElement(By.Id("UpdatesPageTableRow24Date"));
                IWebElement UpdatesPageTableRow24Details = driver.FindElement(By.Id("UpdatesPageTableRow24Details"));
                IWebElement UpdatesPageTableRow24Pill = driver.FindElement(By.Id("UpdatesPageTableRow24Pill"));

                IWebElement UpdatesPageTableRow23Checkmark = driver.FindElement(By.Id("UpdatesPageTableRow23Checkmark"));
                IWebElement UpdatesPageTableRow23Date = driver.FindElement(By.Id("UpdatesPageTableRow23Date"));
                IWebElement UpdatesPageTableRow23Details = driver.FindElement(By.Id("UpdatesPageTableRow23Details"));
                IWebElement UpdatesPageTableRow23Pill = driver.FindElement(By.Id("UpdatesPageTableRow23Pill"));

                IWebElement UpdatesPageTableRow22Date = driver.FindElement(By.Id("UpdatesPageTableRow22Date"));
                IWebElement UpdatesPageTableRow22Details = driver.FindElement(By.Id("UpdatesPageTableRow22Details"));
                IWebElement UpdatesPageTableRow22Pill = driver.FindElement(By.Id("UpdatesPageTableRow22Pill"));

                IWebElement UpdatesPageTableRow21Checkmark = driver.FindElement(By.Id("UpdatesPageTableRow21Checkmark"));
                IWebElement UpdatesPageTableRow21Date = driver.FindElement(By.Id("UpdatesPageTableRow21Date"));
                IWebElement UpdatesPageTableRow21Details = driver.FindElement(By.Id("UpdatesPageTableRow21Details"));
                IWebElement UpdatesPageTableRow21Pill = driver.FindElement(By.Id("UpdatesPageTableRow21Pill"));

                IWebElement UpdatesPageTableRow20Date = driver.FindElement(By.Id("UpdatesPageTableRow20Date"));
                IWebElement UpdatesPageTableRow20Details = driver.FindElement(By.Id("UpdatesPageTableRow20Details"));
                IWebElement UpdatesPageTableRow20Pill = driver.FindElement(By.Id("UpdatesPageTableRow20Pill"));

                IWebElement UpdatesPageTableRow19Checkmark = driver.FindElement(By.Id("UpdatesPageTableRow19Checkmark"));
                IWebElement UpdatesPageTableRow19Date = driver.FindElement(By.Id("UpdatesPageTableRow19Date"));
                IWebElement UpdatesPageTableRow19Details = driver.FindElement(By.Id("UpdatesPageTableRow19Details"));
                IWebElement UpdatesPageTableRow19Pill = driver.FindElement(By.Id("UpdatesPageTableRow19Pill"));

                IWebElement UpdatesPageTableRow18Date = driver.FindElement(By.Id("UpdatesPageTableRow18Date"));
                IWebElement UpdatesPageTableRow18Details = driver.FindElement(By.Id("UpdatesPageTableRow18Details"));
                IWebElement UpdatesPageTableRow18Pill = driver.FindElement(By.Id("UpdatesPageTableRow18Pill"));

                IWebElement UpdatesPageTableRow17Checkmark = driver.FindElement(By.Id("UpdatesPageTableRow17Checkmark"));
                IWebElement UpdatesPageTableRow17Date = driver.FindElement(By.Id("UpdatesPageTableRow17Date"));
                IWebElement UpdatesPageTableRow17Details = driver.FindElement(By.Id("UpdatesPageTableRow17Details"));
                IWebElement UpdatesPageTableRow17Pill = driver.FindElement(By.Id("UpdatesPageTableRow17Pill"));

                IWebElement UpdatesPageTableRow16Checkmark = driver.FindElement(By.Id("UpdatesPageTableRow16Checkmark"));
                IWebElement UpdatesPageTableRow16Date = driver.FindElement(By.Id("UpdatesPageTableRow16Date"));
                IWebElement UpdatesPageTableRow16Details = driver.FindElement(By.Id("UpdatesPageTableRow16Details"));
                IWebElement UpdatesPageTableRow16Pill = driver.FindElement(By.Id("UpdatesPageTableRow16Pill"));

                IWebElement UpdatesPageTableRow15Date = driver.FindElement(By.Id("UpdatesPageTableRow15Date"));
                IWebElement UpdatesPageTableRow15Details = driver.FindElement(By.Id("UpdatesPageTableRow15Details"));
                IWebElement UpdatesPageTableRow15Pill = driver.FindElement(By.Id("UpdatesPageTableRow15Pill"));

                IWebElement UpdatesPageTableRow14Checkmark = driver.FindElement(By.Id("UpdatesPageTableRow14Checkmark"));
                IWebElement UpdatesPageTableRow14Date = driver.FindElement(By.Id("UpdatesPageTableRow14Date"));
                IWebElement UpdatesPageTableRow14Details = driver.FindElement(By.Id("UpdatesPageTableRow14Details"));
                IWebElement UpdatesPageTableRow14Pill = driver.FindElement(By.Id("UpdatesPageTableRow14Pill"));
                //
                IWebElement UpdatesPageTableRow13Date = driver.FindElement(By.Id("UpdatesPageTableRow13Date"));
                IWebElement UpdatesPageTableRow13Details = driver.FindElement(By.Id("UpdatesPageTableRow13Details"));
                IWebElement UpdatesPageTableRow13Pill = driver.FindElement(By.Id("UpdatesPageTableRow13Pill"));

                IWebElement UpdatesPageTableRow12Checkmark = driver.FindElement(By.Id("UpdatesPageTableRow12Checkmark"));
                IWebElement UpdatesPageTableRow12Date = driver.FindElement(By.Id("UpdatesPageTableRow12Date"));
                IWebElement UpdatesPageTableRow12Details = driver.FindElement(By.Id("UpdatesPageTableRow12Details"));
                IWebElement UpdatesPageTableRow12Pill = driver.FindElement(By.Id("UpdatesPageTableRow12Pill"));

                IWebElement UpdatesPageTableRow11Checkmark = driver.FindElement(By.Id("UpdatesPageTableRow11Checkmark"));
                IWebElement UpdatesPageTableRow11Date = driver.FindElement(By.Id("UpdatesPageTableRow11Date"));
                IWebElement UpdatesPageTableRow11Details = driver.FindElement(By.Id("UpdatesPageTableRow11Details"));
                IWebElement UpdatesPageTableRow11Pill = driver.FindElement(By.Id("UpdatesPageTableRow11Pill"));

                IWebElement UpdatesPageTableRow10Checkmark = driver.FindElement(By.Id("UpdatesPageTableRow10Checkmark"));
                IWebElement UpdatesPageTableRow10Date = driver.FindElement(By.Id("UpdatesPageTableRow10Date"));
                IWebElement UpdatesPageTableRow10Details = driver.FindElement(By.Id("UpdatesPageTableRow10Details"));
                IWebElement UpdatesPageTableRow10Pill = driver.FindElement(By.Id("UpdatesPageTableRow10Pill"));

                IWebElement UpdatesPageTableRow9Date = driver.FindElement(By.Id("UpdatesPageTableRow9Date"));
                IWebElement UpdatesPageTableRow9Details = driver.FindElement(By.Id("UpdatesPageTableRow9Details"));
                IWebElement UpdatesPageTableRow9Pill = driver.FindElement(By.Id("UpdatesPageTableRow9Pill"));

                IWebElement UpdatesPageTableRow8Date = driver.FindElement(By.Id("UpdatesPageTableRow8Date"));
                IWebElement UpdatesPageTableRow8Details = driver.FindElement(By.Id("UpdatesPageTableRow8Details"));
                IWebElement UpdatesPageTableRow8Pill = driver.FindElement(By.Id("UpdatesPageTableRow8Pill"));

                IWebElement UpdatesPageTableRow7Checkmark = driver.FindElement(By.Id("UpdatesPageTableRow7Checkmark"));
                IWebElement UpdatesPageTableRow7Date = driver.FindElement(By.Id("UpdatesPageTableRow7Date"));
                IWebElement UpdatesPageTableRow7Details = driver.FindElement(By.Id("UpdatesPageTableRow7Details"));
                IWebElement UpdatesPageTableRow7Pill = driver.FindElement(By.Id("UpdatesPageTableRow7Pill"));

                IWebElement UpdatesPageTableRow6Checkmark = driver.FindElement(By.Id("UpdatesPageTableRow6Checkmark"));
                IWebElement UpdatesPageTableRow6Date = driver.FindElement(By.Id("UpdatesPageTableRow6Date"));
                IWebElement UpdatesPageTableRow6Details = driver.FindElement(By.Id("UpdatesPageTableRow6Details"));
                IWebElement UpdatesPageTableRow6Pill = driver.FindElement(By.Id("UpdatesPageTableRow6Pill"));

                IWebElement UpdatesPageTableRow5Date = driver.FindElement(By.Id("UpdatesPageTableRow5Date"));
                IWebElement UpdatesPageTableRow5Details = driver.FindElement(By.Id("UpdatesPageTableRow5Details"));
                IWebElement UpdatesPageTableRow5Pill = driver.FindElement(By.Id("UpdatesPageTableRow5Pill"));

                IWebElement UpdatesPageTableRow4Checkmark = driver.FindElement(By.Id("UpdatesPageTableRow4Checkmark"));
                IWebElement UpdatesPageTableRow4Date = driver.FindElement(By.Id("UpdatesPageTableRow4Date"));
                IWebElement UpdatesPageTableRow4Details = driver.FindElement(By.Id("UpdatesPageTableRow4Details"));
                IWebElement UpdatesPageTableRow4Pill = driver.FindElement(By.Id("UpdatesPageTableRow4Pill"));

                IWebElement UpdatesPageTableRow3Date = driver.FindElement(By.Id("UpdatesPageTableRow3Date"));
                IWebElement UpdatesPageTableRow3Details = driver.FindElement(By.Id("UpdatesPageTableRow3Details"));
                IWebElement UpdatesPageTableRow3Pill = driver.FindElement(By.Id("UpdatesPageTableRow3Pill"));

                IWebElement UpdatesPageTableRow2Date = driver.FindElement(By.Id("UpdatesPageTableRow2Date"));
                IWebElement UpdatesPageTableRow2Details = driver.FindElement(By.Id("UpdatesPageTableRow2Details"));
                IWebElement UpdatesPageTableRow2Pill = driver.FindElement(By.Id("UpdatesPageTableRow2Pill"));

                IWebElement UpdatesPageTableRow1Checkmark = driver.FindElement(By.Id("UpdatesPageTableRow1Checkmark"));
                IWebElement UpdatesPageTableRow1Date = driver.FindElement(By.Id("UpdatesPageTableRow1Date"));
                IWebElement UpdatesPageTableRow1Details = driver.FindElement(By.Id("UpdatesPageTableRow1Details"));
                IWebElement UpdatesPageTableRow1Pill = driver.FindElement(By.Id("UpdatesPageTableRow1Pill"));


                Assert.True(UpdatesPageTable.Displayed);
                Assert.True(UpdatesPageTableCheckMarkColumn.Displayed);
                Assert.True(UpdatesPageTableDateColumn.Displayed);
                Assert.True(UpdatesPageTableDetailsColumn.Displayed);
                Assert.True(UpdatesPageTableFeedbackItemColumn.Displayed);

                Assert.True(UpdatesPageTableRow28Date.Displayed);
                Assert.True(UpdatesPageTableRow28Details.Displayed);
                Assert.True(UpdatesPageTableRow28Pill.Displayed);

                Assert.True(UpdatesPageTableRow27Date.Displayed);
                Assert.True(UpdatesPageTableRow27Details.Displayed);
                Assert.True(UpdatesPageTableRow27Pill.Displayed);

                Assert.True(UpdatesPageTableRow26Date.Displayed);
                Assert.True(UpdatesPageTableRow26Details.Displayed);
                Assert.True(UpdatesPageTableRow26Pill.Displayed);

                Assert.True(UpdatesPageTableRow25Date.Displayed);
                Assert.True(UpdatesPageTableRow25Details.Displayed);
                Assert.True(UpdatesPageTableRow25Pill.Displayed);

                Assert.True(UpdatesPageTableRow24Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow24Date.Displayed);
                Assert.True(UpdatesPageTableRow24Details.Displayed);
                Assert.True(UpdatesPageTableRow24Pill.Displayed);

                Assert.True(UpdatesPageTableRow23Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow23Date.Displayed);
                Assert.True(UpdatesPageTableRow23Details.Displayed);
                Assert.True(UpdatesPageTableRow23Pill.Displayed);

                Assert.True(UpdatesPageTableRow22Date.Displayed);
                Assert.True(UpdatesPageTableRow22Details.Displayed);
                Assert.True(UpdatesPageTableRow22Pill.Displayed);

                Assert.True(UpdatesPageTableRow21Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow21Date.Displayed);
                Assert.True(UpdatesPageTableRow21Details.Displayed);
                Assert.True(UpdatesPageTableRow21Pill.Displayed);

                Assert.True(UpdatesPageTableRow20Date.Displayed);
                Assert.True(UpdatesPageTableRow20Details.Displayed);
                Assert.True(UpdatesPageTableRow20Pill.Displayed);

                Assert.True(UpdatesPageTableRow19Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow19Date.Displayed);
                Assert.True(UpdatesPageTableRow19Details.Displayed);
                Assert.True(UpdatesPageTableRow19Pill.Displayed);

                Assert.True(UpdatesPageTableRow18Date.Displayed);
                Assert.True(UpdatesPageTableRow18Details.Displayed);
                Assert.True(UpdatesPageTableRow18Pill.Displayed);

                Assert.True(UpdatesPageTableRow17Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow17Date.Displayed);
                Assert.True(UpdatesPageTableRow17Details.Displayed);
                Assert.True(UpdatesPageTableRow17Pill.Displayed);

                Assert.True(UpdatesPageTableRow16Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow16Date.Displayed);
                Assert.True(UpdatesPageTableRow16Details.Displayed);
                Assert.True(UpdatesPageTableRow16Pill.Displayed);

                Assert.True(UpdatesPageTableRow15Date.Displayed);
                Assert.True(UpdatesPageTableRow15Details.Displayed);
                Assert.True(UpdatesPageTableRow15Pill.Displayed);

                Assert.True(UpdatesPageTableRow14Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow14Date.Displayed);
                Assert.True(UpdatesPageTableRow14Details.Displayed);
                Assert.True(UpdatesPageTableRow14Pill.Displayed);

                Assert.True(UpdatesPageTableRow13Date.Displayed);
                Assert.True(UpdatesPageTableRow13Details.Displayed);
                Assert.True(UpdatesPageTableRow13Pill.Displayed);

                Assert.True(UpdatesPageTableRow12Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow12Date.Displayed);
                Assert.True(UpdatesPageTableRow12Details.Displayed);
                Assert.True(UpdatesPageTableRow12Pill.Displayed);

                Assert.True(UpdatesPageTableRow11Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow11Date.Displayed);
                Assert.True(UpdatesPageTableRow11Details.Displayed);
                Assert.True(UpdatesPageTableRow11Pill.Displayed);

                Assert.True(UpdatesPageTableRow10Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow10Date.Displayed);
                Assert.True(UpdatesPageTableRow10Details.Displayed);
                Assert.True(UpdatesPageTableRow10Pill.Displayed);

                Assert.True(UpdatesPageTableRow9Date.Displayed);
                Assert.True(UpdatesPageTableRow9Details.Displayed);
                Assert.True(UpdatesPageTableRow9Pill.Displayed);

                Assert.True(UpdatesPageTableRow8Date.Displayed);
                Assert.True(UpdatesPageTableRow8Details.Displayed);
                Assert.True(UpdatesPageTableRow8Pill.Displayed);

                Assert.True(UpdatesPageTableRow7Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow7Date.Displayed);
                Assert.True(UpdatesPageTableRow7Details.Displayed);
                Assert.True(UpdatesPageTableRow7Pill.Displayed);

                Assert.True(UpdatesPageTableRow6Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow6Date.Displayed);
                Assert.True(UpdatesPageTableRow6Details.Displayed);
                Assert.True(UpdatesPageTableRow6Pill.Displayed);

                Assert.True(UpdatesPageTableRow5Date.Displayed);
                Assert.True(UpdatesPageTableRow5Details.Displayed);
                Assert.True(UpdatesPageTableRow5Pill.Displayed);

                Assert.True(UpdatesPageTableRow4Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow4Date.Displayed);
                Assert.True(UpdatesPageTableRow4Details.Displayed);
                Assert.True(UpdatesPageTableRow4Pill.Displayed);

                Assert.True(UpdatesPageTableRow3Date.Displayed);
                Assert.True(UpdatesPageTableRow3Details.Displayed);
                Assert.True(UpdatesPageTableRow3Pill.Displayed);

                Assert.True(UpdatesPageTableRow2Date.Displayed);
                Assert.True(UpdatesPageTableRow2Details.Displayed);
                Assert.True(UpdatesPageTableRow2Pill.Displayed);

                Assert.True(UpdatesPageTableRow1Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow1Date.Displayed);
                Assert.True(UpdatesPageTableRow1Details.Displayed);
                Assert.True(UpdatesPageTableRow1Pill.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);

                Assert.True(UpdatesPageTable.Displayed);
                Assert.True(UpdatesPageTableCheckMarkColumn.Displayed);
                Assert.True(UpdatesPageTableDateColumn.Displayed);
                Assert.True(UpdatesPageTableDetailsColumn.Displayed);
                Assert.True(UpdatesPageTableFeedbackItemColumn.Displayed);

                Assert.True(UpdatesPageTableRow13Date.Displayed);
                Assert.True(UpdatesPageTableRow13Details.Displayed);
                Assert.True(UpdatesPageTableRow13Pill.Displayed);

                Assert.True(UpdatesPageTableRow12Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow12Date.Displayed);
                Assert.True(UpdatesPageTableRow12Details.Displayed);
                Assert.True(UpdatesPageTableRow12Pill.Displayed);

                Assert.True(UpdatesPageTableRow11Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow11Date.Displayed);
                Assert.True(UpdatesPageTableRow11Details.Displayed);
                Assert.True(UpdatesPageTableRow11Pill.Displayed);

                Assert.True(UpdatesPageTableRow10Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow10Date.Displayed);
                Assert.True(UpdatesPageTableRow10Details.Displayed);
                Assert.True(UpdatesPageTableRow10Pill.Displayed);

                Assert.True(UpdatesPageTableRow9Date.Displayed);
                Assert.True(UpdatesPageTableRow9Details.Displayed);
                Assert.True(UpdatesPageTableRow9Pill.Displayed);

                Assert.True(UpdatesPageTableRow8Date.Displayed);
                Assert.True(UpdatesPageTableRow8Details.Displayed);
                Assert.True(UpdatesPageTableRow8Pill.Displayed);

                Assert.True(UpdatesPageTableRow7Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow7Date.Displayed);
                Assert.True(UpdatesPageTableRow7Details.Displayed);
                Assert.True(UpdatesPageTableRow7Pill.Displayed);

                Assert.True(UpdatesPageTableRow6Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow6Date.Displayed);
                Assert.True(UpdatesPageTableRow6Details.Displayed);
                Assert.True(UpdatesPageTableRow6Pill.Displayed);

                Assert.True(UpdatesPageTableRow5Date.Displayed);
                Assert.True(UpdatesPageTableRow5Details.Displayed);
                Assert.True(UpdatesPageTableRow5Pill.Displayed);

                Assert.True(UpdatesPageTableRow4Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow4Date.Displayed);
                Assert.True(UpdatesPageTableRow4Details.Displayed);
                Assert.True(UpdatesPageTableRow4Pill.Displayed);

                Assert.True(UpdatesPageTableRow3Date.Displayed);
                Assert.True(UpdatesPageTableRow3Details.Displayed);
                Assert.True(UpdatesPageTableRow3Pill.Displayed);

                Assert.True(UpdatesPageTableRow2Date.Displayed);
                Assert.True(UpdatesPageTableRow2Details.Displayed);
                Assert.True(UpdatesPageTableRow2Pill.Displayed);

                Assert.True(UpdatesPageTableRow1Checkmark.Displayed);
                Assert.True(UpdatesPageTableRow1Date.Displayed);
                Assert.True(UpdatesPageTableRow1Details.Displayed);
                Assert.True(UpdatesPageTableRow1Pill.Displayed);

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
            var filename = "TestUpdatesPageComponentsArePresent_CheckFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string UpdatesUrl = UrlRefLibrary.GetUpdatesPageLocalHostUrl();

                driver.Navigate().GoToUrl(UpdatesUrl);
                driver.Manage().Window.Maximize();
                IWebElement FooterElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("nav-footer")));
                IWebElement CopyrightListItemElement = driver.FindElement(By.Id("_LayoutCopyrightFooterLabel"));
                IWebElement RegisterFooterLink = driver.FindElement(By.Id("_LayoutRegisterFooterLink"));
                IWebElement AboutFooterLink = driver.FindElement(By.Id("_LayoutAboutFooterLink"));
                IWebElement ArticlesFooterLink = driver.FindElement(By.Id("_LayoutArticlesFooterLink"));
                IWebElement PrivacyFooterLink = driver.FindElement(By.Id("_LayoutPrivacyFooterLink"));
                IWebElement CookiesFooterLink = driver.FindElement(By.Id("_LayoutCookiesFooterLink"));
                IWebElement UpdatesFooterLink = driver.FindElement(By.Id("_LayoutUpdatesFooterLink"));

                Assert.True(FooterElement.Displayed);
                Assert.True(CopyrightListItemElement.Displayed);
                Assert.True(RegisterFooterLink.Displayed);
                Assert.True(AboutFooterLink.Displayed);
                Assert.True(ArticlesFooterLink.Displayed);
                Assert.True(PrivacyFooterLink.Displayed);
                Assert.True(CookiesFooterLink.Displayed);
                Assert.True(UpdatesFooterLink.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);

                Assert.True(FooterElement.Displayed);
                Assert.True(CopyrightListItemElement.Displayed);
                Assert.True(RegisterFooterLink.Displayed);
                Assert.True(AboutFooterLink.Displayed);
                Assert.True(ArticlesFooterLink.Displayed);
                Assert.True(PrivacyFooterLink.Displayed);
                Assert.True(CookiesFooterLink.Displayed);
                Assert.True(UpdatesFooterLink.Displayed);

            }, filename, driver);
        }
    }
}
