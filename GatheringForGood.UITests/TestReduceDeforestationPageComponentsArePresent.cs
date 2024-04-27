using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using UITestStringsLibrary;
using OpenQA.Selenium.Support.UI;
using System.Drawing;
using LocSourceNameReferenceLibrary;
using System.Threading;

namespace GatheringForGood.UITests
{
    public class TestReduceDeforestationPageComponentsArePresent
    {
        readonly CrossPageSharedUITestStrings UITestStrings = new UITestStringsLibrary.CrossPageSharedUITestStrings();

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckCorrectImpactIconIsDisplayedForEachRow()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestReduceDeforestationPageComponentsArePresent_CheckCorrectImpactIconIsDisplayedForEachRow";

            TakeTestFailScreenshot.UITest(() =>
            {
                var CrossPageSharedUITestStrings = new CrossPageSharedUITestStrings();
                var UrlRefLibrary = new UrlStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();

                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                driver.Navigate().GoToUrl(LoginUrl);
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
                IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                string rdfUrl = UrlRefLibrary.GetReduceDeforestationPageLocalHostUrl();
                string treeicon1String = CrossPageSharedUITestStrings.treeicon1String();
                string treeicon2String = CrossPageSharedUITestStrings.treeicon2String();
                string treeicon3String = CrossPageSharedUITestStrings.treeicon3String();
                string treeicon4String = CrossPageSharedUITestStrings.treeicon4String();
                string treeicon5String = CrossPageSharedUITestStrings.treeicon5String();
                driver.Navigate().GoToUrl(rdfUrl);

                IWebElement ImpactIconRow1 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfImpactIconRow1")));
                String ImpactIconRow1SRC = ImpactIconRow1.GetAttribute("src");
                String ImpactIconRow1SRCParsed = ImpactIconRow1SRC.Substring(ImpactIconRow1SRC.LastIndexOf('/') + 1);
                System.Diagnostics.Debug.WriteLine("**************** Src attribute is: " + ImpactIconRow1SRCParsed);
                IWebElement ImpactIconRow2 = driver.FindElement(By.Id("rdfImpactIconRow2"));
                String ImpactIconRow2SRC = ImpactIconRow2.GetAttribute("src");
                String ImpactIconRow2SRCParsed = ImpactIconRow1SRC.Substring(ImpactIconRow2SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow3 = driver.FindElement(By.Id("rdfImpactIconRow3"));
                String ImpactIconRow3SRC = ImpactIconRow3.GetAttribute("src");
                String ImpactIconRow3SRCParsed = ImpactIconRow3SRC.Substring(ImpactIconRow3SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow4 = driver.FindElement(By.Id("rdfImpactIconRow4"));
                String ImpactIconRow4SRC = ImpactIconRow4.GetAttribute("src");
                String ImpactIconRow4SRCParsed = ImpactIconRow4SRC.Substring(ImpactIconRow4SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow5 = driver.FindElement(By.Id("rdfImpactIconRow5"));
                String ImpactIconRow5SRC = ImpactIconRow5.GetAttribute("src");
                String ImpactIconRow5SRCParsed = ImpactIconRow5SRC.Substring(ImpactIconRow5SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow6 = driver.FindElement(By.Id("rdfImpactIconRow6"));
                String ImpactIconRow6SRC = ImpactIconRow6.GetAttribute("src");
                String ImpactIconRow6SRCParsed = ImpactIconRow6SRC.Substring(ImpactIconRow6SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow7 = driver.FindElement(By.Id("rdfImpactIconRow7"));
                String ImpactIconRow7SRC = ImpactIconRow7.GetAttribute("src");
                String ImpactIconRow7SRCParsed = ImpactIconRow7SRC.Substring(ImpactIconRow7SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow8 = driver.FindElement(By.Id("rdfImpactIconRow8"));
                String ImpactIconRow8SRC = ImpactIconRow8.GetAttribute("src");
                String ImpactIconRow8SRCParsed = ImpactIconRow8SRC.Substring(ImpactIconRow8SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow9 = driver.FindElement(By.Id("rdfImpactIconRow9"));
                String ImpactIconRow9SRC = ImpactIconRow9.GetAttribute("src");
                String ImpactIconRow9SRCParsed = ImpactIconRow9SRC.Substring(ImpactIconRow9SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow10 = driver.FindElement(By.Id("rdfImpactIconRow10"));
                String ImpactIconRow10SRC = ImpactIconRow10.GetAttribute("src");
                String ImpactIconRow10SRCParsed = ImpactIconRow10SRC.Substring(ImpactIconRow10SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow11 = driver.FindElement(By.Id("rdfImpactIconRow11"));
                String ImpactIconRow11SRC = ImpactIconRow11.GetAttribute("src");
                String ImpactIconRow11SRCParsed = ImpactIconRow11SRC.Substring(ImpactIconRow11SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow12 = driver.FindElement(By.Id("rdfImpactIconRow12"));
                String ImpactIconRow12SRC = ImpactIconRow12.GetAttribute("src");
                String ImpactIconRow12SRCParsed = ImpactIconRow12SRC.Substring(ImpactIconRow12SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow13 = driver.FindElement(By.Id("rdfImpactIconRow13"));
                String ImpactIconRow13SRC = ImpactIconRow13.GetAttribute("src");
                String ImpactIconRow13SRCParsed = ImpactIconRow13SRC.Substring(ImpactIconRow13SRC.LastIndexOf('/') + 1);

                Assert.Equal(ImpactIconRow1SRCParsed, treeicon5String);
                Assert.Equal(ImpactIconRow2SRCParsed, treeicon5String);
                Assert.Equal(ImpactIconRow3SRCParsed, treeicon5String);
                Assert.Equal(ImpactIconRow4SRCParsed, treeicon4String);
                Assert.Equal(ImpactIconRow5SRCParsed, treeicon4String);
                Assert.Equal(ImpactIconRow6SRCParsed, treeicon3String);
                Assert.Equal(ImpactIconRow7SRCParsed, treeicon3String);
                Assert.Equal(ImpactIconRow8SRCParsed, treeicon3String);
                Assert.Equal(ImpactIconRow9SRCParsed, treeicon2String);
                Assert.Equal(ImpactIconRow10SRCParsed, treeicon2String);
                Assert.Equal(ImpactIconRow11SRCParsed, treeicon2String);
                Assert.Equal(ImpactIconRow12SRCParsed, treeicon1String);
                Assert.Equal(ImpactIconRow13SRCParsed, treeicon1String);
            }, filename, driver);
        }

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
            var filename = "TestReduceDeforestationPageComponentsArePresent_CheckImagesAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();

                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                driver.Navigate().GoToUrl(LoginUrl);
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
                IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                string rdfUrl = UrlRefLibrary.GetReduceDeforestationPageLocalHostUrl();
                driver.Navigate().GoToUrl(rdfUrl);
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ReduceDeforestationPageBanner")));
                IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));
                IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_rdfPageLogoImg"));
                IWebElement RDFPageAllUserActionsIconImage = driver.FindElement(By.Id("RDFPageAllUserActionsIconImage"));
                IWebElement RDFPageRDFUserActionsIconImage = driver.FindElement(By.Id("RDFPageRDFUserActionsIconImage"));
                IWebElement RDFPageMyTotalActionsIconImage = driver.FindElement(By.Id("RDFPageMyTotalActionsIconImage"));
                IWebElement RDFPageMyCO2ImpactIconImage = driver.FindElement(By.Id("RDFPageMyCO2ImpactIconImage"));
                IWebElement rdfImpactIconRow1 = driver.FindElement(By.Id("rdfImpactIconRow1"));
                IWebElement rdfImpactIconRow2 = driver.FindElement(By.Id("rdfImpactIconRow2"));
                IWebElement rdfImpactIconRow3 = driver.FindElement(By.Id("rdfImpactIconRow3"));
                IWebElement rdfImpactIconRow4 = driver.FindElement(By.Id("rdfImpactIconRow4"));
                IWebElement rdfImpactIconRow5 = driver.FindElement(By.Id("rdfImpactIconRow5"));
                IWebElement rdfImpactIconRow6 = driver.FindElement(By.Id("rdfImpactIconRow6"));
                IWebElement rdfImpactIconRow7 = driver.FindElement(By.Id("rdfImpactIconRow7"));
                IWebElement rdfImpactIconRow8 = driver.FindElement(By.Id("rdfImpactIconRow8"));
                IWebElement rdfImpactIconRow9 = driver.FindElement(By.Id("rdfImpactIconRow9"));
                IWebElement rdfImpactIconRow10 = driver.FindElement(By.Id("rdfImpactIconRow10"));
                IWebElement rdfImpactIconRow11 = driver.FindElement(By.Id("rdfImpactIconRow11"));
                IWebElement rdfImpactIconRow12 = driver.FindElement(By.Id("rdfImpactIconRow12"));
                IWebElement rdfImpactIconRow13 = driver.FindElement(By.Id("rdfImpactIconRow13"));
                IWebElement rdfMouseClickIconRow1 = driver.FindElement(By.Id("rdfMouseClickIconRow1"));
                IWebElement rdfMouseClickIconRow2 = driver.FindElement(By.Id("rdfMouseClickIconRow2"));
                IWebElement rdfMouseClickIconRow3 = driver.FindElement(By.Id("rdfMouseClickIconRow3"));
                IWebElement rdfMouseClickIconRow4 = driver.FindElement(By.Id("rdfMouseClickIconRow4"));
                IWebElement rdfMouseClickIconRow5 = driver.FindElement(By.Id("rdfMouseClickIconRow5"));
                IWebElement rdfMouseClickIconRow6 = driver.FindElement(By.Id("rdfMouseClickIconRow6"));
                IWebElement rdfMouseClickIconRow7 = driver.FindElement(By.Id("rdfMouseClickIconRow7"));
                IWebElement rdfMouseClickIconRow8 = driver.FindElement(By.Id("rdfMouseClickIconRow8"));
                IWebElement rdfMouseClickIconRow9 = driver.FindElement(By.Id("rdfMouseClickIconRow9"));
                IWebElement rdfMouseClickIconRow10 = driver.FindElement(By.Id("rdfMouseClickIconRow10"));
                IWebElement rdfMouseClickIconRow11 = driver.FindElement(By.Id("rdfMouseClickIconRow11"));
                IWebElement rdfMouseClickIconRow12 = driver.FindElement(By.Id("rdfMouseClickIconRow12"));
                IWebElement rdfMouseClickIconRow13 = driver.FindElement(By.Id("rdfMouseClickIconRow13"));
                IWebElement rdfHandTapIconRow1 = driver.FindElement(By.Id("rdfHandTapIconRow1"));
                IWebElement rdfHandTapIconRow2 = driver.FindElement(By.Id("rdfHandTapIconRow2"));
                IWebElement rdfHandTapIconRow3 = driver.FindElement(By.Id("rdfHandTapIconRow3"));
                IWebElement rdfHandTapIconRow4 = driver.FindElement(By.Id("rdfHandTapIconRow4"));
                IWebElement rdfHandTapIconRow5 = driver.FindElement(By.Id("rdfHandTapIconRow5"));
                IWebElement rdfHandTapIconRow6 = driver.FindElement(By.Id("rdfHandTapIconRow6"));
                IWebElement rdfHandTapIconRow7 = driver.FindElement(By.Id("rdfHandTapIconRow7"));
                IWebElement rdfHandTapIconRow8 = driver.FindElement(By.Id("rdfHandTapIconRow8"));
                IWebElement rdfHandTapIconRow9 = driver.FindElement(By.Id("rdfHandTapIconRow9"));
                IWebElement rdfHandTapIconRow10 = driver.FindElement(By.Id("rdfHandTapIconRow10"));
                IWebElement rdfHandTapIconRow11 = driver.FindElement(By.Id("rdfHandTapIconRow11"));
                IWebElement rdfHandTapIconRow12 = driver.FindElement(By.Id("rdfHandTapIconRow12"));
                IWebElement rdfHandTapIconRow13 = driver.FindElement(By.Id("rdfHandTapIconRow13"));
                IWebElement RDFPageTwitterShareIconImage1 = driver.FindElement(By.Id("RDFPageTwitterShareIconImage1"));
                IWebElement RDFPageFBShareIconImage1 = driver.FindElement(By.Id("RDFPageFBShareIconImage2"));
                IWebElement RDFPageLinkedinShareIconImage1 = driver.FindElement(By.Id("RDFPageLinkedinShareIconImage2"));
                IWebElement RDFPageTwitterShareIconImage2 = driver.FindElement(By.Id("RDFPageTwitterShareIconImage2"));
                IWebElement RDFPageFBShareIconImage2 = driver.FindElement(By.Id("RDFPageFBShareIconImage3"));
                IWebElement RDFPageLinkedinShareIconImage2 = driver.FindElement(By.Id("RDFPageLinkedinShareIconImage3"));
                IWebElement RDFPageTwitterShareIconImage3 = driver.FindElement(By.Id("RDFPageTwitterShareIconImage3"));
                IWebElement RDFPageFBShareIconImage3 = driver.FindElement(By.Id("RDFPageFBShareIconImage4"));
                IWebElement RDFPageLinkedinShareIconImage3 = driver.FindElement(By.Id("RDFPageLinkedinShareIconImage4"));
                IWebElement RDFPageTwitterShareIconImage4 = driver.FindElement(By.Id("RDFPageTwitterShareIconImage4"));
                IWebElement RDFPageFBShareIconImage4 = driver.FindElement(By.Id("RDFPageFBShareIconImage5"));
                IWebElement RDFPageLinkedinShareIconImage4 = driver.FindElement(By.Id("RDFPageLinkedinShareIconImage5"));

                Assert.True(BannerImageElement.Displayed);
                Assert.True(_LayoutPageLogoElement.Displayed);
                Assert.True(BodyBackground.Displayed);
                Assert.True(RDFPageAllUserActionsIconImage.Displayed);
                Assert.True(RDFPageRDFUserActionsIconImage.Displayed);
                Assert.True(RDFPageMyTotalActionsIconImage.Displayed);
                Assert.True(RDFPageMyCO2ImpactIconImage.Displayed);
                Assert.True(rdfImpactIconRow1.Displayed);
                Assert.True(rdfImpactIconRow2.Displayed);
                Assert.True(rdfImpactIconRow3.Displayed);
                Assert.True(rdfImpactIconRow4.Displayed);
                Assert.True(rdfImpactIconRow5.Displayed);
                Assert.True(rdfImpactIconRow6.Displayed);
                Assert.True(rdfImpactIconRow7.Displayed);
                Assert.True(rdfImpactIconRow8.Displayed);
                Assert.True(rdfImpactIconRow9.Displayed);
                Assert.True(rdfImpactIconRow10.Displayed);
                Assert.True(rdfImpactIconRow11.Displayed);
                Assert.True(rdfImpactIconRow12.Displayed);
                Assert.True(rdfImpactIconRow13.Displayed);
                Assert.True(rdfMouseClickIconRow1.Displayed);
                Assert.True(rdfMouseClickIconRow2.Displayed);
                Assert.True(rdfMouseClickIconRow3.Displayed);
                Assert.True(rdfMouseClickIconRow4.Displayed);
                Assert.True(rdfMouseClickIconRow5.Displayed);
                Assert.True(rdfMouseClickIconRow6.Displayed);
                Assert.True(rdfMouseClickIconRow7.Displayed);
                Assert.True(rdfMouseClickIconRow8.Displayed);
                Assert.True(rdfMouseClickIconRow9.Displayed);
                Assert.True(rdfMouseClickIconRow10.Displayed);
                Assert.True(rdfMouseClickIconRow11.Displayed);
                Assert.True(rdfMouseClickIconRow12.Displayed);
                Assert.True(rdfMouseClickIconRow13.Displayed);
                Assert.False(rdfHandTapIconRow1.Displayed);
                Assert.False(rdfHandTapIconRow2.Displayed);
                Assert.False(rdfHandTapIconRow3.Displayed);
                Assert.False(rdfHandTapIconRow4.Displayed);
                Assert.False(rdfHandTapIconRow5.Displayed);
                Assert.False(rdfHandTapIconRow6.Displayed);
                Assert.False(rdfHandTapIconRow7.Displayed);
                Assert.False(rdfHandTapIconRow8.Displayed);
                Assert.False(rdfHandTapIconRow9.Displayed);
                Assert.False(rdfHandTapIconRow10.Displayed);
                Assert.False(rdfHandTapIconRow11.Displayed);
                Assert.False(rdfHandTapIconRow12.Displayed);
                Assert.False(rdfHandTapIconRow13.Displayed);
                Assert.True(RDFPageTwitterShareIconImage1.Displayed);
                Assert.True(RDFPageFBShareIconImage1.Displayed);
                Assert.True(RDFPageLinkedinShareIconImage1.Displayed);
                Assert.True(RDFPageTwitterShareIconImage2.Displayed);
                Assert.True(RDFPageFBShareIconImage2.Displayed);
                Assert.True(RDFPageLinkedinShareIconImage2.Displayed);
                Assert.True(RDFPageTwitterShareIconImage3.Displayed);
                Assert.True(RDFPageFBShareIconImage3.Displayed);
                Assert.True(RDFPageLinkedinShareIconImage3.Displayed);
                Assert.True(RDFPageTwitterShareIconImage4.Displayed);
                Assert.True(RDFPageFBShareIconImage4.Displayed);
                Assert.True(RDFPageLinkedinShareIconImage4.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);
                var js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", rdfHandTapIconRow1);
                IWebElement rdfHandTapIconRow1b = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfHandTapIconRow1")));
                Assert.True(RDFPageAllUserActionsIconImage.Displayed);
                Assert.True(RDFPageRDFUserActionsIconImage.Displayed);
                Assert.True(RDFPageMyTotalActionsIconImage.Displayed);
                Assert.True(RDFPageMyCO2ImpactIconImage.Displayed);
                Assert.True(rdfHandTapIconRow1b.Displayed);
                Assert.True(rdfHandTapIconRow2.Displayed);
                Assert.True(rdfHandTapIconRow3.Displayed);
                Assert.True(rdfHandTapIconRow4.Displayed);
                Assert.True(rdfHandTapIconRow5.Displayed);
                Assert.True(rdfHandTapIconRow6.Displayed);
                Assert.True(rdfHandTapIconRow7.Displayed);
                Assert.True(rdfHandTapIconRow8.Displayed);
                Assert.True(rdfHandTapIconRow9.Displayed);
                Assert.True(rdfHandTapIconRow10.Displayed);
                Assert.True(rdfHandTapIconRow11.Displayed);
                Assert.True(rdfHandTapIconRow12.Displayed);
                Assert.True(rdfHandTapIconRow13.Displayed);
                Assert.False(rdfMouseClickIconRow1.Displayed);
                Assert.False(rdfMouseClickIconRow2.Displayed);
                Assert.False(rdfMouseClickIconRow3.Displayed);
                Assert.False(rdfMouseClickIconRow4.Displayed);
                Assert.False(rdfMouseClickIconRow5.Displayed);
                Assert.False(rdfMouseClickIconRow6.Displayed);
                Assert.False(rdfMouseClickIconRow7.Displayed);
                Assert.False(rdfMouseClickIconRow8.Displayed);
                Assert.False(rdfMouseClickIconRow9.Displayed);
                Assert.False(rdfMouseClickIconRow10.Displayed);
                Assert.False(rdfMouseClickIconRow11.Displayed);
                Assert.False(rdfMouseClickIconRow12.Displayed);
                Assert.False(rdfMouseClickIconRow13.Displayed);
                Assert.True(RDFPageTwitterShareIconImage1.Displayed);
                Assert.True(RDFPageFBShareIconImage1.Displayed);
                Assert.True(RDFPageLinkedinShareIconImage1.Displayed);
                Assert.True(RDFPageTwitterShareIconImage2.Displayed);
                Assert.True(RDFPageFBShareIconImage2.Displayed);
                Assert.True(RDFPageLinkedinShareIconImage2.Displayed);
                Assert.True(RDFPageTwitterShareIconImage3.Displayed);
                Assert.True(RDFPageFBShareIconImage3.Displayed);
                Assert.True(RDFPageLinkedinShareIconImage3.Displayed);
                Assert.True(RDFPageTwitterShareIconImage4.Displayed);
                Assert.True(RDFPageFBShareIconImage4.Displayed);
                Assert.True(RDFPageLinkedinShareIconImage4.Displayed);

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
            var filename = "TestReduceDeforestationPageComponentsArePresent_CheckNavBarIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();

                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                driver.Navigate().GoToUrl(LoginUrl);
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
                IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                string rdfUrl = UrlRefLibrary.GetReduceDeforestationPageLocalHostUrl();
                driver.Navigate().GoToUrl(rdfUrl);
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-rdf-page")));
                IWebElement NavBarHomeLinkElement = driver.FindElement(By.Id("_rdfPageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement = driver.FindElement(By.Id("_rdfPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_rdfPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_rdfPageHelpNavLink"));
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
        public void CheckButtonsAreDisplayedAndFunction()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestReduceDeforestationPageComponentsArePresent_CheckButtonsAreDisplayedAndFunction";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();

                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                driver.Navigate().GoToUrl(LoginUrl);
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
                IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                string rdfUrl = UrlRefLibrary.GetReduceDeforestationPageLocalHostUrl();
                driver.Navigate().GoToUrl(rdfUrl);
                IWebElement RDFPageRDFIconImage = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("RDFPageRDFIconImage")));
                IWebElement RDFPageRAEIconImage = driver.FindElement(By.Id("RDFPageRAEIconImage"));
                IWebElement RDFPageRGWIconImage = driver.FindElement(By.Id("RDFPageRGWIconImage"));

                Assert.True(RDFPageRDFIconImage.Displayed);
                Assert.True(RDFPageRAEIconImage.Displayed);
                Assert.True(RDFPageRGWIconImage.Displayed);

                RDFPageRDFIconImage.Click();
                IWebElement SubTitleElement = driver.FindElement(By.Id("rdfPageSubtitle"));
                Assert.True(SubTitleElement.Displayed);

                RDFPageRGWIconImage.Click();
                IWebElement ReduceGlobalWarmingPageSubtitle = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ReduceGlobalWarmingPageSubtitle")));
                Assert.True(ReduceGlobalWarmingPageSubtitle.Displayed);

                driver.Navigate().GoToUrl(rdfUrl);
                IWebElement RDFPageRAEIconImage1 = driver.FindElement(By.Id("RDFPageRAEIconImage"));
                RDFPageRAEIconImage1.Click();
                IWebElement raePageSubtitle = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageSubtitle")));
                Assert.True(raePageSubtitle.Displayed);

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
            var filename = "TestReduceDeforestationPageComponentsArePresent_CheckTextSectionsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

                driver1.Navigate().GoToUrl(HomeUrl);
                driver1.Manage().Window.Maximize();

                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                driver1.Navigate().GoToUrl(LoginUrl);
                IWebElement LoginEmailInputField = new WebDriverWait(driver1, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
                IWebElement LoginPasswordInputField = driver1.FindElement(By.Id("LoginPasswordInputField"));
                IWebElement LoginButton = driver1.FindElement(By.Id("LoginButton"));
                string UserEmail = UITestStrings.Test2UserEmail();
                string UserPassword = UITestStrings.Test2UserPassword();

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Keys.Tab);
                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Keys.Tab);
                LoginEmailInputField.SendKeys(UserEmail);
                LoginPasswordInputField.SendKeys(UserPassword);

                LoginButton.Click();
                IWebElement LoggedInUserLabel = new WebDriverWait(driver1, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                string rdfUrl = UrlRefLibrary.GetReduceDeforestationPageLocalHostUrl();
                driver1.Navigate().GoToUrl(rdfUrl);
                driver1.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver1, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-rdf-page")));
                IWebElement TitleElement = driver1.FindElement(By.Id("rdfPageTitle"));
                IWebElement SubTitleElement = driver1.FindElement(By.Id("rdfPageSubtitle"));
                IWebElement rdfDoSomethingTodayTitle = driver1.FindElement(By.Id("rdfDoSomethingTodayTitle"));
                IWebElement rdfDoSomethingTodayPara = driver1.FindElement(By.Id("rdfDoSomethingTodayPara"));
                IWebElement RDFPageAllUserActionsIconText = driver1.FindElement(By.Id("RDFPageAllUserActionsIconText"));
                IWebElement RDFPageAllUserActionsTotalText = driver1.FindElement(By.Id("RDFPageAllUserActionsTotalText"));
                IWebElement RDFPageRDFUserActionsIconText = driver1.FindElement(By.Id("RDFPageRDFUserActionsIconText"));
                IWebElement RDFPageRDFUserActionsTotalText = driver1.FindElement(By.Id("RDFPageRDFUserActionsTotalText"));
                IWebElement RDFPageMyTotalActionsIconText = driver1.FindElement(By.Id("RDFPageMyTotalActionsIconText"));
                IWebElement RDFPageMyTotalActionsTotalText = driver1.FindElement(By.Id("RDFPageMyTotalActionsTotalText"));
                IWebElement RDFPageMyCO2ImpactIconText = driver1.FindElement(By.Id("RDFPageMyCO2ImpactIconText"));
                IWebElement RDFPageMyCO2ImpactTotalText = driver1.FindElement(By.Id("RDFPageMyCO2ImpactTotalText"));
                IWebElement rdfWhatCanIDoTitle = driver1.FindElement(By.Id("rdfWhatCanIDoTitle"));
                IWebElement rdfInformationTitle = driver1.FindElement(By.Id("rdfInformationTitle"));
                IWebElement rdfImpactTitle = driver1.FindElement(By.Id("rdfImpactTitle"));
                IWebElement rdfIDidThisTodayTitle = driver1.FindElement(By.Id("rdfIDidThisTodayTitle"));
                IWebElement rdfMyImpactTitle = driver1.FindElement(By.Id("rdfMyImpactTitle"));
                IWebElement rdfReduceMeatIntakeTitle = driver1.FindElement(By.Id("rdfReduceMeatIntakeTitle"));
                IWebElement rdfReduceMeatIntakeTitleMobile = driver1.FindElement(By.Id("rdfReduceMeatIntakeTitleMobile"));
                IWebElement rdfReduceMeatIntakePara = driver1.FindElement(By.Id("rdfReduceMeatIntakePara"));
                IWebElement rdfGoVegetarianTitle = driver1.FindElement(By.Id("rdfGoVegetarianTitle"));
                IWebElement rdfGoVegetarianTitleMobile = driver1.FindElement(By.Id("rdfGoVegetarianTitleMobile"));
                IWebElement rdfGoVegetarianPara1 = driver1.FindElement(By.Id("rdfGoVegetarianPara1"));
                IWebElement rdfGoVeganTitle = driver1.FindElement(By.Id("rdfGoVeganTitle"));
                IWebElement rdfGoVeganTitleMobile = driver1.FindElement(By.Id("rdfGoVeganTitleMobile"));
                IWebElement rdfGoVeganPara1 = driver1.FindElement(By.Id("rdfGoVeganPara1"));
                IWebElement rdfEatOrganicTitle = driver1.FindElement(By.Id("rdfEatOrganicTitle"));
                IWebElement rdfEatOrganicTitleMobile = driver1.FindElement(By.Id("rdfEatOrganicTitleMobile"));
                IWebElement rdfEatOrganicPara1 = driver1.FindElement(By.Id("rdfEatOrganicPara1"));
                IWebElement rdfSupportHabitatRestorationTitle = driver1.FindElement(By.Id("rdfSupportHabitatRestorationTitle"));
                IWebElement rdfSupportHabitatRestorationTitleMobile = driver1.FindElement(By.Id("rdfSupportHabitatRestorationTitleMobile"));
                IWebElement rdfSupportHabitatRestorationPara1 = driver1.FindElement(By.Id("rdfSupportHabitatRestorationPara1"));
                IWebElement rdfZeroDeforestationTitle = driver1.FindElement(By.Id("rdfZeroDeforestationTitle"));
                IWebElement rdfZeroDeforestationTitleMobile = driver1.FindElement(By.Id("rdfZeroDeforestationTitleMobile"));
                IWebElement rdfZeroDeforestationPara1 = driver1.FindElement(By.Id("rdfZeroDeforestationPara1"));
                IWebElement rdfGoPaperlessTitle = driver1.FindElement(By.Id("rdfGoPaperlessTitle"));
                IWebElement rdfGoPaperlessTitleMobile = driver1.FindElement(By.Id("rdfGoPaperlessTitleMobile"));
                IWebElement rdfGoPaperlessPara1 = driver1.FindElement(By.Id("rdfGoPaperlessPara1"));
                IWebElement rdfDonateTitle = driver1.FindElement(By.Id("rdfDonateTitle"));
                IWebElement rdfDonateTitleMobile = driver1.FindElement(By.Id("rdfDonateTitleMobile"));
                IWebElement rdfDonatePara = driver1.FindElement(By.Id("rdfDonatePara"));
                IWebElement rdfPlantSomeTreesTitle = driver1.FindElement(By.Id("rdfPlantSomeTreesTitle"));
                IWebElement rdfPlantSomeTreesTitleMobile = driver1.FindElement(By.Id("rdfPlantSomeTreesTitleMobile"));
                IWebElement rdfPlantSomeTreesPara1 = driver1.FindElement(By.Id("rdfPlantSomeTreesPara1"));
                IWebElement rdfBuyRecycledTitle = driver1.FindElement(By.Id("rdfBuyRecycledTitle"));
                IWebElement rdfBuyRecycledTitleMobile = driver1.FindElement(By.Id("rdfBuyRecycledTitleMobile"));
                IWebElement rdfBuyRecycledPara1 = driver1.FindElement(By.Id("rdfBuyRecycledPara1"));
                IWebElement rdfStandUpTitle = driver1.FindElement(By.Id("rdfStandUpTitle"));
                IWebElement rdfStandUpTitleMobile = driver1.FindElement(By.Id("rdfStandUpTitleMobile"));
                IWebElement rdfStandUpPara1 = driver1.FindElement(By.Id("rdfStandUpPara1"));
                IWebElement rdfSignAPetitionTitle = driver1.FindElement(By.Id("rdfSignAPetitionTitle"));
                IWebElement rdfSignAPetitionTitleMobile = driver1.FindElement(By.Id("rdfSignAPetitionTitleMobile"));
                IWebElement rdfSignAPetitionPara1 = driver1.FindElement(By.Id("rdfSignAPetitionPara1"));
                IWebElement rdfSocialMediaTitle = driver1.FindElement(By.Id("rdfSocialMediaTitle"));
                IWebElement rdfSocialMediaTitleMobile = driver1.FindElement(By.Id("rdfSocialMediaTitleMobile"));
                IWebElement rdfSocialMediaPara1 = driver1.FindElement(By.Id("rdfSocialMediaPara1"));
                IWebElement rdfMyImpactReduceMeat = driver1.FindElement(By.Id("rdfMyImpactReduceMeat"));
                IWebElement rdfMyImpactGoVegetarian = driver1.FindElement(By.Id("rdfMyImpactGoVegetarian"));
                IWebElement rdfMyImpactGoVegan = driver1.FindElement(By.Id("rdfMyImpactGoVegan"));
                IWebElement rdfMyImpactEatOrganic = driver1.FindElement(By.Id("rdfMyImpactEatOrganic"));
                IWebElement rdfMyImpactHabitatRestoration = driver1.FindElement(By.Id("rdfMyImpactHabitatRestoration"));
                IWebElement rdfMyImpactZeroDeforestation = driver1.FindElement(By.Id("rdfMyImpactZeroDeforestation"));
                IWebElement rdfMyImpactGoPaperless = driver1.FindElement(By.Id("rdfMyImpactGoPaperless"));
                IWebElement rdfMyImpactDonate = driver1.FindElement(By.Id("rdfMyImpactDonate"));
                IWebElement rdfMyImpactPlantTrees = driver1.FindElement(By.Id("rdfMyImpactPlantTrees"));
                IWebElement rdfMyImpactBuyRecycled = driver1.FindElement(By.Id("rdfMyImpactBuyRecycled"));
                IWebElement rdfMyImpactStandUp = driver1.FindElement(By.Id("rdfMyImpactStandUp"));
                IWebElement rdfMyImpactSignAPetition = driver1.FindElement(By.Id("rdfMyImpactSignAPetition"));
                IWebElement rdfMyImpactSocialMedia = driver1.FindElement(By.Id("rdfMyImpactSocialMedia"));
                IWebElement rdfReduceMeatIntakeParaB = driver1.FindElement(By.Id("rdfReduceMeatIntakeParaB"));
                IWebElement rdfGoVegetarianPara1B = driver1.FindElement(By.Id("rdfGoVegetarianPara1B"));
                IWebElement rdfGoVeganPara1B = driver1.FindElement(By.Id("rdfGoVeganPara1B"));
                IWebElement rdfEatOrganicPara1B = driver1.FindElement(By.Id("rdfEatOrganicPara1B"));
                IWebElement rdfSupportHabitatRestorationPara1B = driver1.FindElement(By.Id("rdfSupportHabitatRestorationPara1B"));
                IWebElement rdfZeroDeforestationPara1B = driver1.FindElement(By.Id("rdfZeroDeforestationPara1B"));
                IWebElement rdfGoPaperlessPara1B = driver1.FindElement(By.Id("rdfGoPaperlessPara1B"));
                IWebElement rdfDonateParaB = driver1.FindElement(By.Id("rdfDonateParaB"));
                IWebElement rdfPlantSomeTreesPara1B = driver1.FindElement(By.Id("rdfPlantSomeTreesPara1B"));
                IWebElement rdfBuyRecycledPara1B = driver1.FindElement(By.Id("rdfBuyRecycledPara1B"));
                IWebElement rdfStandUpPara1B = driver1.FindElement(By.Id("rdfStandUpPara1B"));
                IWebElement rdfSignAPetitionPara1B = driver1.FindElement(By.Id("rdfSignAPetitionPara1B"));
                IWebElement rdfSocialMediaPara1B = driver1.FindElement(By.Id("rdfSocialMediaPara1B"));

                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(rdfDoSomethingTodayTitle.Displayed);
                Assert.True(rdfDoSomethingTodayPara.Displayed);
                Assert.True(RDFPageAllUserActionsIconText.Displayed);
                Assert.True(RDFPageAllUserActionsTotalText.Displayed);
                Assert.True(RDFPageRDFUserActionsIconText.Displayed);
                Assert.True(RDFPageRDFUserActionsTotalText.Displayed);
                Assert.True(RDFPageMyTotalActionsIconText.Displayed);
                Assert.True(RDFPageMyTotalActionsTotalText.Displayed);
                Assert.True(RDFPageMyCO2ImpactIconText.Displayed);
                Assert.True(RDFPageMyCO2ImpactTotalText.Displayed);
                Assert.True(rdfWhatCanIDoTitle.Displayed);
                Assert.True(rdfInformationTitle.Displayed);
                Assert.True(rdfImpactTitle.Displayed);
                Assert.True(rdfIDidThisTodayTitle.Displayed);
                Assert.True(rdfMyImpactTitle.Displayed);
                Assert.True(rdfReduceMeatIntakeTitle.Displayed);
                Assert.False(rdfReduceMeatIntakeTitleMobile.Displayed);
                Assert.True(rdfReduceMeatIntakePara.Displayed);
                Assert.True(rdfGoVegetarianTitle.Displayed);
                Assert.False(rdfGoVegetarianTitleMobile.Displayed);
                Assert.True(rdfGoVegetarianPara1.Displayed);
                Assert.True(rdfGoVeganTitle.Displayed);
                Assert.False(rdfGoVeganTitleMobile.Displayed);
                Assert.True(rdfGoVeganPara1.Displayed);
                Assert.True(rdfEatOrganicTitle.Displayed);
                Assert.False(rdfEatOrganicTitleMobile.Displayed);
                Assert.True(rdfEatOrganicPara1.Displayed);
                Assert.True(rdfSupportHabitatRestorationTitle.Displayed);
                Assert.False(rdfSupportHabitatRestorationTitleMobile.Displayed);
                Assert.True(rdfSupportHabitatRestorationPara1.Displayed);
                Assert.True(rdfZeroDeforestationTitle.Displayed);
                Assert.False(rdfZeroDeforestationTitleMobile.Displayed);
                Assert.True(rdfZeroDeforestationPara1.Displayed);
                Assert.True(rdfGoPaperlessTitle.Displayed);
                Assert.False(rdfGoPaperlessTitleMobile.Displayed);
                Assert.True(rdfGoPaperlessPara1.Displayed);
                Assert.True(rdfDonateTitle.Displayed);
                Assert.False(rdfDonateTitleMobile.Displayed);
                Assert.True(rdfDonatePara.Displayed);
                Assert.True(rdfPlantSomeTreesTitle.Displayed);
                Assert.False(rdfPlantSomeTreesTitleMobile.Displayed);
                Assert.True(rdfPlantSomeTreesPara1.Displayed);
                Assert.True(rdfBuyRecycledTitle.Displayed);
                Assert.False(rdfBuyRecycledTitleMobile.Displayed);
                Assert.True(rdfBuyRecycledPara1.Displayed);
                Assert.True(rdfStandUpTitle.Displayed);
                Assert.False(rdfStandUpTitleMobile.Displayed);
                Assert.True(rdfStandUpPara1.Displayed);
                Assert.True(rdfSignAPetitionTitle.Displayed);
                Assert.False(rdfSignAPetitionTitleMobile.Displayed);
                Assert.True(rdfSignAPetitionPara1.Displayed);
                Assert.True(rdfSocialMediaTitle.Displayed);
                Assert.False(rdfSocialMediaTitleMobile.Displayed);
                Assert.True(rdfSocialMediaPara1.Displayed);
                Assert.True(rdfMyImpactReduceMeat.Displayed);
                Assert.True(rdfMyImpactGoVegetarian.Displayed);
                Assert.True(rdfMyImpactGoVegan.Displayed);
                Assert.True(rdfMyImpactEatOrganic.Displayed);
                Assert.True(rdfMyImpactHabitatRestoration.Displayed);
                Assert.True(rdfMyImpactZeroDeforestation.Displayed);
                Assert.True(rdfMyImpactGoPaperless.Displayed);
                Assert.True(rdfMyImpactDonate.Displayed);
                Assert.True(rdfMyImpactPlantTrees.Displayed);
                Assert.True(rdfMyImpactBuyRecycled.Displayed);
                Assert.True(rdfMyImpactStandUp.Displayed);
                Assert.True(rdfMyImpactSignAPetition.Displayed);
                Assert.True(rdfMyImpactSocialMedia.Displayed);
                Assert.False(rdfReduceMeatIntakeParaB.Displayed);
                Assert.False(rdfGoVegetarianPara1B.Displayed);
                Assert.False(rdfGoVeganPara1B.Displayed);
                Assert.False(rdfEatOrganicPara1B.Displayed);
                Assert.False(rdfSupportHabitatRestorationPara1B.Displayed);
                Assert.False(rdfZeroDeforestationPara1B.Displayed);
                Assert.False(rdfGoPaperlessPara1B.Displayed);
                Assert.False(rdfDonateParaB.Displayed);
                Assert.False(rdfPlantSomeTreesPara1B.Displayed);
                Assert.False(rdfBuyRecycledPara1B.Displayed);
                Assert.False(rdfStandUpPara1B.Displayed);
                Assert.False(rdfSignAPetitionPara1B.Displayed);
                Assert.False(rdfSocialMediaPara1B.Displayed);

                driver1.Manage().Window.Size = new Size(240, 600);

                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(rdfDoSomethingTodayTitle.Displayed);
                Assert.True(rdfDoSomethingTodayPara.Displayed);
                Assert.True(RDFPageAllUserActionsIconText.Displayed);
                Assert.True(RDFPageAllUserActionsTotalText.Displayed);
                Assert.True(RDFPageRDFUserActionsIconText.Displayed);
                Assert.True(RDFPageRDFUserActionsTotalText.Displayed);
                Assert.True(RDFPageMyTotalActionsIconText.Displayed);
                Assert.True(RDFPageMyTotalActionsTotalText.Displayed);
                Assert.True(RDFPageMyCO2ImpactIconText.Displayed);
                Assert.True(RDFPageMyCO2ImpactTotalText.Displayed);
                Assert.True(rdfWhatCanIDoTitle.Displayed);
                Assert.False(rdfInformationTitle.Displayed);
                Assert.True(rdfImpactTitle.Displayed);
                Assert.True(rdfIDidThisTodayTitle.Displayed);
                Assert.True(rdfReduceMeatIntakeTitleMobile.Displayed);
                Assert.False(rdfReduceMeatIntakeTitle.Displayed);
                Assert.False(rdfReduceMeatIntakePara.Displayed);
                Assert.True(rdfGoVegetarianTitleMobile.Displayed);
                Assert.False(rdfGoVegetarianTitle.Displayed);
                Assert.False(rdfGoVegetarianPara1.Displayed);
                Assert.True(rdfGoVeganTitleMobile.Displayed);
                Assert.False(rdfGoVeganTitle.Displayed);
                Assert.False(rdfGoVeganPara1.Displayed);
                Assert.True(rdfEatOrganicTitleMobile.Displayed);
                Assert.False(rdfEatOrganicTitle.Displayed);
                Assert.False(rdfEatOrganicPara1.Displayed);
                Assert.True(rdfSupportHabitatRestorationTitleMobile.Displayed);
                Assert.False(rdfSupportHabitatRestorationTitle.Displayed);
                Assert.False(rdfSupportHabitatRestorationPara1.Displayed);
                Assert.True(rdfZeroDeforestationTitleMobile.Displayed);
                Assert.False(rdfZeroDeforestationTitle.Displayed);
                Assert.False(rdfZeroDeforestationPara1.Displayed);
                Assert.True(rdfGoPaperlessTitleMobile.Displayed);
                Assert.False(rdfGoPaperlessTitle.Displayed);
                Assert.False(rdfGoPaperlessPara1.Displayed);
                Assert.True(rdfDonateTitleMobile.Displayed);
                Assert.False(rdfDonateTitle.Displayed);
                Assert.False(rdfDonatePara.Displayed);
                Assert.True(rdfPlantSomeTreesTitleMobile.Displayed);
                Assert.False(rdfPlantSomeTreesTitle.Displayed);
                Assert.False(rdfPlantSomeTreesPara1.Displayed);
                Assert.True(rdfBuyRecycledTitleMobile.Displayed);
                Assert.False(rdfBuyRecycledTitle.Displayed);
                Assert.False(rdfBuyRecycledPara1.Displayed);
                Assert.True(rdfStandUpTitleMobile.Displayed);
                Assert.False(rdfStandUpTitle.Displayed);
                Assert.False(rdfStandUpPara1.Displayed);
                Assert.True(rdfSignAPetitionTitleMobile.Displayed);
                Assert.False(rdfSignAPetitionTitle.Displayed);
                Assert.False(rdfSignAPetitionPara1.Displayed);
                Assert.True(rdfSocialMediaTitleMobile.Displayed);
                Assert.False(rdfSocialMediaTitle.Displayed);
                Assert.False(rdfSocialMediaPara1.Displayed);
                Assert.True(rdfMyImpactReduceMeat.Displayed);
                Assert.True(rdfMyImpactGoVegetarian.Displayed);
                Assert.True(rdfMyImpactGoVegan.Displayed);
                Assert.True(rdfMyImpactEatOrganic.Displayed);
                Assert.True(rdfMyImpactHabitatRestoration.Displayed);
                Assert.True(rdfMyImpactZeroDeforestation.Displayed);
                Assert.True(rdfMyImpactGoPaperless.Displayed);
                Assert.True(rdfMyImpactDonate.Displayed);
                Assert.True(rdfMyImpactPlantTrees.Displayed);
                Assert.True(rdfMyImpactBuyRecycled.Displayed);
                Assert.True(rdfMyImpactStandUp.Displayed);
                Assert.True(rdfMyImpactSignAPetition.Displayed);
                Assert.True(rdfMyImpactSocialMedia.Displayed);
                Assert.True(rdfReduceMeatIntakeParaB.Displayed);
                Assert.True(rdfGoVegetarianPara1B.Displayed);
                Assert.True(rdfGoVeganPara1B.Displayed);
                Assert.True(rdfEatOrganicPara1B.Displayed);
                Assert.True(rdfSupportHabitatRestorationPara1B.Displayed);
                Assert.True(rdfZeroDeforestationPara1B.Displayed);
                Assert.True(rdfGoPaperlessPara1B.Displayed);
                Assert.True(rdfDonateParaB.Displayed);
                Assert.True(rdfPlantSomeTreesPara1B.Displayed);
                Assert.True(rdfBuyRecycledPara1B.Displayed);
                Assert.True(rdfStandUpPara1B.Displayed);
                Assert.True(rdfSignAPetitionPara1B.Displayed);
                Assert.True(rdfSocialMediaPara1B.Displayed);
            }, filename, driver1);
        }


        //Re-enable when LearnMore onclick is re-enabled
        /*
        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Long")]
        [Trait("TestEnvironment", "Local")]
        public void CheckModalsAreDisplayedOnClick()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestReduceDeforestationPageComponentsArePresent_CheckModalsAreDisplayedOnClick";

            TakeTestFailScreenshot.UITest(() =>
            {
                var ReduceDeforestationPageLocSourceNamesLibrary = new ReduceDeforestationPageLocSourceNames();
                var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
                var UrlRefLibrary = new UrlStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();

                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                driver.Navigate().GoToUrl(LoginUrl);
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
                IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                string rdfUrl = UrlRefLibrary.GetReduceDeforestationPageLocalHostUrl();
                driver.Navigate().GoToUrl(rdfUrl);

                IWebElement ReduceMeatIntakeTitle = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfReduceMeatIntakeTitle")));
                IWebElement LearnMoreRow1 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreRow1")));
                IWebElement LearnMoreRow2 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreRow2")));
                IWebElement LearnMoreRow3 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreRow3")));
                IWebElement LearnMoreRow4 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreRow4")));
                IWebElement LearnMoreRow5 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreRow5")));
                IWebElement LearnMoreRow6 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreRow6")));
                IWebElement LearnMoreRow7 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreRow7")));
                IWebElement LearnMoreRow8 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreRow8")));
                IWebElement LearnMoreRow9 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreRow9")));
                IWebElement LearnMoreRow10 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreRow10")));
                IWebElement LearnMoreRow11 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreRow11")));
                IWebElement LearnMoreRow12 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreRow12")));
                IWebElement LearnMoreRow13 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreRow13")));

                Assert.True(LearnMoreRow1.Displayed);
                Assert.True(LearnMoreRow2.Displayed);
                Assert.True(LearnMoreRow3.Displayed);
                Assert.True(LearnMoreRow4.Displayed);
                Assert.True(LearnMoreRow5.Displayed);
                Assert.True(LearnMoreRow6.Displayed);
                Assert.True(LearnMoreRow7.Displayed);
                Assert.True(LearnMoreRow8.Displayed);
                Assert.True(LearnMoreRow9.Displayed);
                Assert.True(LearnMoreRow10.Displayed);
                Assert.True(LearnMoreRow11.Displayed);
                Assert.True(LearnMoreRow12.Displayed);
                Assert.True(LearnMoreRow13.Displayed);

                var js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow2);

                LearnMoreRow1.Click();
                
                IWebElement rdfPageLearnMoreModal = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreModal")));
                IWebElement learnMoreModalTitle = driver.FindElement(By.Id("rdflearnMoreModalTitle"));
                IWebElement learnMoreModalHeaderCloseButton = driver.FindElement(By.Id("rdflearnMoreModalHeaderCloseButton"));
                IWebElement rdfPageLearnMoreModalPara = driver.FindElement(By.Id("rdfPageLearnMoreModalPara"));
                IWebElement rdfPageLearnMoreModalFormLabel = driver.FindElement(By.Id("rdfPageLearnMoreModalFormLabel"));
                IWebElement rdfPageModalTextArea = driver.FindElement(By.Id("rdf-Page-Learn-More-Modal-message-text"));
                IWebElement learnMoreModalFooterCloseButton = driver.FindElement(By.Id("rdflearnMoreModalFooterCloseButton"));
                string learnMoreModalTitleReturned = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceReduceMeatIntakeTitleNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalParaReturned = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalFormLabelReturned = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceDeforestationPage();
                string learnMoreModalFooterCloseButtonReturned = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(rdfPageLearnMoreModal.Displayed);
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rdfPageLearnMoreModalPara.Displayed);
                Assert.True(rdfPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rdfPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned);
                Assert.Equal(rdfPageLearnMoreModalPara.Text, rdfPageLearnMoreModalParaReturned);
                Assert.Equal(rdfPageLearnMoreModalFormLabel.Text, rdfPageLearnMoreModalFormLabelReturned);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rdfPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow5);
                LearnMoreRow2.Click();
                
                IWebElement rdfPageLearnMoreModal2 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreModal")));
                string learnMoreModalTitleReturned2 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceGoVegetarianTitleNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalParaReturned2 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalFormLabelReturned2 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceDeforestationPage();
                string learnMoreModalFooterCloseButtonReturned2 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rdfPageLearnMoreModalPara.Displayed);
                Assert.True(rdfPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rdfPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned2);
                Assert.Equal(rdfPageLearnMoreModalPara.Text, rdfPageLearnMoreModalParaReturned2);
                Assert.Equal(rdfPageLearnMoreModalFormLabel.Text, rdfPageLearnMoreModalFormLabelReturned2);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned2);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rdfPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow6);
                LearnMoreRow3.Click();
                
                IWebElement rdfPageLearnMoreModal3 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreModal")));
                string learnMoreModalTitleReturned3 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceGoVeganTitleNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalParaReturned3 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalFormLabelReturned3 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceDeforestationPage();
                string learnMoreModalFooterCloseButtonReturned3 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rdfPageLearnMoreModalPara.Displayed);
                Assert.True(rdfPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rdfPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned3);
                Assert.Equal(rdfPageLearnMoreModalPara.Text, rdfPageLearnMoreModalParaReturned3);
                Assert.Equal(rdfPageLearnMoreModalFormLabel.Text, rdfPageLearnMoreModalFormLabelReturned3);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned3);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rdfPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow7);
                LearnMoreRow4.Click();
                
                IWebElement rdfPageLearnMoreModal4 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreModal")));
                string learnMoreModalTitleReturned4 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceEatOrganicTitleNameReferenceForReduceGlobalWarmingPage();
                string rdfPageLearnMoreModalParaReturned4 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalFormLabelReturned4 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceDeforestationPage();
                string learnMoreModalFooterCloseButtonReturned4 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rdfPageLearnMoreModalPara.Displayed);
                Assert.True(rdfPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rdfPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned4);
                Assert.Equal(rdfPageLearnMoreModalPara.Text, rdfPageLearnMoreModalParaReturned4);
                Assert.Equal(rdfPageLearnMoreModalFormLabel.Text, rdfPageLearnMoreModalFormLabelReturned4);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned4);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rdfPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow8);
                LearnMoreRow5.Click();
                
                IWebElement rdfPageLearnMoreModal5 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreModal")));
                string learnMoreModalTitleReturned5 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceSupportHabitatRestorationTitleNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalParaReturned5 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalFormLabelReturned5 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceDeforestationPage();
                string learnMoreModalFooterCloseButtonReturned5 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rdfPageLearnMoreModalPara.Displayed);
                Assert.True(rdfPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rdfPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned5);
                Assert.Equal(rdfPageLearnMoreModalPara.Text, rdfPageLearnMoreModalParaReturned5);
                Assert.Equal(rdfPageLearnMoreModalFormLabel.Text, rdfPageLearnMoreModalFormLabelReturned5);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned5);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rdfPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow9);
                LearnMoreRow6.Click();
                
                IWebElement rdfPageLearnMoreModal6 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreModal")));
                string learnMoreModalTitleReturned6 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceZeroDeforestationTitleNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalParaReturned6 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalFormLabelReturned6 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceDeforestationPage();
                string learnMoreModalFooterCloseButtonReturned6 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rdfPageLearnMoreModalPara.Displayed);
                Assert.True(rdfPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rdfPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned6);
                Assert.Equal(rdfPageLearnMoreModalPara.Text, rdfPageLearnMoreModalParaReturned6);
                Assert.Equal(rdfPageLearnMoreModalFormLabel.Text, rdfPageLearnMoreModalFormLabelReturned6);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned6);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rdfPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow10);
                LearnMoreRow7.Click();
                
                IWebElement rdfPageLearnMoreModal7 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreModal")));
                string learnMoreModalTitleReturned7 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceGoPaperlessTitleNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalParaReturned7 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalFormLabelReturned7 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceDeforestationPage();
                string learnMoreModalFooterCloseButtonReturned7 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rdfPageLearnMoreModalPara.Displayed);
                Assert.True(rdfPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rdfPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned7);
                Assert.Equal(rdfPageLearnMoreModalPara.Text, rdfPageLearnMoreModalParaReturned7);
                Assert.Equal(rdfPageLearnMoreModalFormLabel.Text, rdfPageLearnMoreModalFormLabelReturned7);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned7);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rdfPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow11);
                LearnMoreRow8.Click();
                
                IWebElement rdfPageLearnMoreModal8 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreModal")));
                string learnMoreModalTitleReturned8 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceDonateTitleNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalParaReturned8 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalFormLabelReturned8 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceDeforestationPage();
                string learnMoreModalFooterCloseButtonReturned8 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rdfPageLearnMoreModalPara.Displayed);
                Assert.True(rdfPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rdfPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned8);
                Assert.Equal(rdfPageLearnMoreModalPara.Text, rdfPageLearnMoreModalParaReturned8);
                Assert.Equal(rdfPageLearnMoreModalFormLabel.Text, rdfPageLearnMoreModalFormLabelReturned8);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned8);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rdfPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow12);
                LearnMoreRow9.Click();
                
                IWebElement rdfPageLearnMoreModal9 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreModal")));
                string learnMoreModalTitleReturned9 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourcePlantSomeTreesTitleNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalParaReturned9 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalFormLabelReturned9 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceDeforestationPage();
                string learnMoreModalFooterCloseButtonReturned9 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rdfPageLearnMoreModalPara.Displayed);
                Assert.True(rdfPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rdfPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned9);
                Assert.Equal(rdfPageLearnMoreModalPara.Text, rdfPageLearnMoreModalParaReturned9);
                Assert.Equal(rdfPageLearnMoreModalFormLabel.Text, rdfPageLearnMoreModalFormLabelReturned9);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned9);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rdfPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow13);
                LearnMoreRow10.Click();
                
                IWebElement rdfPageLearnMoreModal10 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreModal")));
                string learnMoreModalTitleReturned10 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceBuyRecycledTitleNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalParaReturned10 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalFormLabelReturned10 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceDeforestationPage();
                string learnMoreModalFooterCloseButtonReturned10 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rdfPageLearnMoreModalPara.Displayed);
                Assert.True(rdfPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rdfPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned10);
                Assert.Equal(rdfPageLearnMoreModalPara.Text, rdfPageLearnMoreModalParaReturned10);
                Assert.Equal(rdfPageLearnMoreModalFormLabel.Text, rdfPageLearnMoreModalFormLabelReturned10);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned10);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rdfPageLearnMoreModal")));

                LearnMoreRow11.Click();
                
                IWebElement rdfPageLearnMoreModal11 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreModal")));
                string learnMoreModalTitleReturned11 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceStandUpTitleNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalParaReturned11 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalFormLabelReturned11 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceDeforestationPage();
                string learnMoreModalFooterCloseButtonReturned11 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rdfPageLearnMoreModalPara.Displayed);
                Assert.True(rdfPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rdfPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned11);
                Assert.Equal(rdfPageLearnMoreModalPara.Text, rdfPageLearnMoreModalParaReturned11);
                Assert.Equal(rdfPageLearnMoreModalFormLabel.Text, rdfPageLearnMoreModalFormLabelReturned11);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned11);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rdfPageLearnMoreModal")));

                LearnMoreRow12.Click();
                
                IWebElement rdfPageLearnMoreModal12 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreModal")));
                string learnMoreModalTitleReturned12 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceSignAPetitionTitleNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalParaReturned12 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalFormLabelReturned12 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceDeforestationPage();
                string learnMoreModalFooterCloseButtonReturned12 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rdfPageLearnMoreModalPara.Displayed);
                Assert.True(rdfPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rdfPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned12);
                Assert.Equal(rdfPageLearnMoreModalPara.Text, rdfPageLearnMoreModalParaReturned12);
                Assert.Equal(rdfPageLearnMoreModalFormLabel.Text, rdfPageLearnMoreModalFormLabelReturned12);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned12);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rdfPageLearnMoreModal")));

                LearnMoreRow13.Click();
                
                IWebElement rdfPageLearnMoreModal13 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageLearnMoreModal")));
                string learnMoreModalTitleReturned13 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceSocialMediaTitleNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalParaReturned13 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceDeforestationPage();
                string rdfPageLearnMoreModalFormLabelReturned13 = ReduceDeforestationPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceDeforestationPage();
                string learnMoreModalFooterCloseButtonReturned13 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rdfPageLearnMoreModalPara.Displayed);
                Assert.True(rdfPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rdfPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned13);
                Assert.Equal(rdfPageLearnMoreModalPara.Text, rdfPageLearnMoreModalParaReturned13);
                Assert.Equal(rdfPageLearnMoreModalFormLabel.Text, rdfPageLearnMoreModalFormLabelReturned13);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned13);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rdfPageLearnMoreModal")));
            }, filename, driver);
        }
        */

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
            var filename = "TestReduceDeforestationPageComponentsArePresent_CheckFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();

                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                driver.Navigate().GoToUrl(LoginUrl);
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

                string rdfUrl = UrlRefLibrary.GetReduceDeforestationPageLocalHostUrl();
                driver.Navigate().GoToUrl(rdfUrl);

                IWebElement FooterElement = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("nav-footer")));
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
