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
    public class TestReduceGlobalWarmingPageComponentsArePresent
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
            var filename = "TestReduceGlobalWarmingPageComponentsArePresent_CheckCorrectImpactIconIsDisplayedForEachRow";

            TakeTestFailScreenshot.UITest(() =>
            {
                var CrossPageSharedUITestStrings = new CrossPageSharedUITestStrings();
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

                string RGWUrl = UrlRefLibrary.GetReduceGlobalWarmingPageLocalHostUrl();
                string co2icon1String = CrossPageSharedUITestStrings.Co2icon1String();
                string co2icon2String = CrossPageSharedUITestStrings.Co2icon2String();
                string co2icon3String = CrossPageSharedUITestStrings.Co2icon3String();
                string co2icon4String = CrossPageSharedUITestStrings.Co2icon4String();
                string co2icon5String = CrossPageSharedUITestStrings.Co2icon5String();
                driver.Navigate().GoToUrl(RGWUrl);

                IWebElement ImpactIconRow1 = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ImpactIconRow1")));
                String ImpactIconRow1SRC = ImpactIconRow1.GetAttribute("src");
                String ImpactIconRow1SRCParsed = ImpactIconRow1SRC.Substring(ImpactIconRow1SRC.LastIndexOf('/') + 1);
                System.Diagnostics.Debug.WriteLine("**************** Src attribute is: " + ImpactIconRow1SRCParsed);
                IWebElement ImpactIconRow2 = driver.FindElement(By.Id("ImpactIconRow2"));
                String ImpactIconRow2SRC = ImpactIconRow2.GetAttribute("src");
                String ImpactIconRow2SRCParsed = ImpactIconRow1SRC.Substring(ImpactIconRow2SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow3 = driver.FindElement(By.Id("ImpactIconRow3"));
                String ImpactIconRow3SRC = ImpactIconRow3.GetAttribute("src");
                String ImpactIconRow3SRCParsed = ImpactIconRow3SRC.Substring(ImpactIconRow3SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow4 = driver.FindElement(By.Id("ImpactIconRow4"));
                String ImpactIconRow4SRC = ImpactIconRow4.GetAttribute("src");
                String ImpactIconRow4SRCParsed = ImpactIconRow4SRC.Substring(ImpactIconRow4SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow5 = driver.FindElement(By.Id("ImpactIconRow5"));
                String ImpactIconRow5SRC = ImpactIconRow5.GetAttribute("src");
                String ImpactIconRow5SRCParsed = ImpactIconRow5SRC.Substring(ImpactIconRow5SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow6 = driver.FindElement(By.Id("ImpactIconRow6"));
                String ImpactIconRow6SRC = ImpactIconRow6.GetAttribute("src");
                String ImpactIconRow6SRCParsed = ImpactIconRow6SRC.Substring(ImpactIconRow6SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow7 = driver.FindElement(By.Id("ImpactIconRow7"));
                String ImpactIconRow7SRC = ImpactIconRow7.GetAttribute("src");
                String ImpactIconRow7SRCParsed = ImpactIconRow7SRC.Substring(ImpactIconRow7SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow8 = driver.FindElement(By.Id("ImpactIconRow8"));
                String ImpactIconRow8SRC = ImpactIconRow8.GetAttribute("src");
                String ImpactIconRow8SRCParsed = ImpactIconRow8SRC.Substring(ImpactIconRow8SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow9 = driver.FindElement(By.Id("ImpactIconRow9"));
                String ImpactIconRow9SRC = ImpactIconRow9.GetAttribute("src");
                String ImpactIconRow9SRCParsed = ImpactIconRow9SRC.Substring(ImpactIconRow9SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow10 = driver.FindElement(By.Id("ImpactIconRow10"));
                String ImpactIconRow10SRC = ImpactIconRow10.GetAttribute("src");
                String ImpactIconRow10SRCParsed = ImpactIconRow10SRC.Substring(ImpactIconRow10SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow11 = driver.FindElement(By.Id("ImpactIconRow11"));
                String ImpactIconRow11SRC = ImpactIconRow11.GetAttribute("src");
                String ImpactIconRow11SRCParsed = ImpactIconRow11SRC.Substring(ImpactIconRow11SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow12 = driver.FindElement(By.Id("ImpactIconRow12"));
                String ImpactIconRow12SRC = ImpactIconRow12.GetAttribute("src");
                String ImpactIconRow12SRCParsed = ImpactIconRow12SRC.Substring(ImpactIconRow12SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow13 = driver.FindElement(By.Id("ImpactIconRow13"));
                String ImpactIconRow13SRC = ImpactIconRow13.GetAttribute("src");
                String ImpactIconRow13SRCParsed = ImpactIconRow13SRC.Substring(ImpactIconRow13SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow14 = driver.FindElement(By.Id("ImpactIconRow14"));
                String ImpactIconRow14SRC = ImpactIconRow14.GetAttribute("src");
                String ImpactIconRow14SRCParsed = ImpactIconRow14SRC.Substring(ImpactIconRow14SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow15 = driver.FindElement(By.Id("ImpactIconRow15"));
                String ImpactIconRow15SRC = ImpactIconRow15.GetAttribute("src");
                String ImpactIconRow15SRCParsed = ImpactIconRow15SRC.Substring(ImpactIconRow15SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow16 = driver.FindElement(By.Id("ImpactIconRow16"));
                String ImpactIconRow16SRC = ImpactIconRow16.GetAttribute("src");
                String ImpactIconRow16SRCParsed = ImpactIconRow16SRC.Substring(ImpactIconRow16SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow17 = driver.FindElement(By.Id("ImpactIconRow17"));
                String ImpactIconRow17SRC = ImpactIconRow17.GetAttribute("src");
                String ImpactIconRow17SRCParsed = ImpactIconRow17SRC.Substring(ImpactIconRow17SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow18 = driver.FindElement(By.Id("ImpactIconRow18"));
                String ImpactIconRow18SRC = ImpactIconRow18.GetAttribute("src");
                String ImpactIconRow18SRCParsed = ImpactIconRow18SRC.Substring(ImpactIconRow18SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow19 = driver.FindElement(By.Id("ImpactIconRow19"));
                String ImpactIconRow19SRC = ImpactIconRow19.GetAttribute("src");
                String ImpactIconRow19SRCParsed = ImpactIconRow19SRC.Substring(ImpactIconRow19SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow20 = driver.FindElement(By.Id("ImpactIconRow20"));
                String ImpactIconRow20SRC = ImpactIconRow20.GetAttribute("src");
                String ImpactIconRow20SRCParsed = ImpactIconRow20SRC.Substring(ImpactIconRow20SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow21 = driver.FindElement(By.Id("ImpactIconRow21"));
                String ImpactIconRow21SRC = ImpactIconRow21.GetAttribute("src");
                String ImpactIconRow21SRCParsed = ImpactIconRow21SRC.Substring(ImpactIconRow21SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow22 = driver.FindElement(By.Id("ImpactIconRow22"));
                String ImpactIconRow22SRC = ImpactIconRow22.GetAttribute("src");
                String ImpactIconRow22SRCParsed = ImpactIconRow22SRC.Substring(ImpactIconRow22SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow23 = driver.FindElement(By.Id("ImpactIconRow23"));
                String ImpactIconRow23SRC = ImpactIconRow23.GetAttribute("src");
                String ImpactIconRow23SRCParsed = ImpactIconRow23SRC.Substring(ImpactIconRow23SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow24 = driver.FindElement(By.Id("ImpactIconRow24"));
                String ImpactIconRow24SRC = ImpactIconRow24.GetAttribute("src");
                String ImpactIconRow24SRCParsed = ImpactIconRow24SRC.Substring(ImpactIconRow24SRC.LastIndexOf('/') + 1);

                Assert.Equal(ImpactIconRow1SRCParsed, co2icon5String);
                Assert.Equal(ImpactIconRow2SRCParsed, co2icon5String);
                Assert.Equal(ImpactIconRow3SRCParsed, co2icon5String);
                Assert.Equal(ImpactIconRow4SRCParsed, co2icon5String);
                Assert.Equal(ImpactIconRow5SRCParsed, co2icon5String);
                Assert.Equal(ImpactIconRow6SRCParsed, co2icon5String);
                Assert.Equal(ImpactIconRow7SRCParsed, co2icon4String);
                Assert.Equal(ImpactIconRow8SRCParsed, co2icon4String);
                Assert.Equal(ImpactIconRow9SRCParsed, co2icon4String);
                Assert.Equal(ImpactIconRow10SRCParsed, co2icon4String);
                Assert.Equal(ImpactIconRow11SRCParsed, co2icon3String);
                Assert.Equal(ImpactIconRow12SRCParsed, co2icon3String);
                Assert.Equal(ImpactIconRow13SRCParsed, co2icon3String);
                Assert.Equal(ImpactIconRow14SRCParsed, co2icon2String);
                Assert.Equal(ImpactIconRow15SRCParsed, co2icon2String);
                Assert.Equal(ImpactIconRow16SRCParsed, co2icon2String);
                Assert.Equal(ImpactIconRow17SRCParsed, co2icon2String);
                Assert.Equal(ImpactIconRow18SRCParsed, co2icon2String);
                Assert.Equal(ImpactIconRow19SRCParsed, co2icon2String);
                Assert.Equal(ImpactIconRow20SRCParsed, co2icon2String);
                Assert.Equal(ImpactIconRow21SRCParsed, co2icon2String);
                Assert.Equal(ImpactIconRow22SRCParsed, co2icon1String);
                Assert.Equal(ImpactIconRow23SRCParsed, co2icon1String);
                Assert.Equal(ImpactIconRow24SRCParsed, co2icon1String);
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
            var filename = "TestReduceGlobalWarmingPageComponentsArePresent_CheckImagesAreDisplayed";

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

                string RGWUrl = UrlRefLibrary.GetReduceGlobalWarmingPageLocalHostUrl();
                driver.Navigate().GoToUrl(RGWUrl);
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ReduceGlobalWarmingPageBanner")));
                IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));
                IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_RGWPageLogoImg"));
                IWebElement RGWPageAllUserActionsIconImage = driver.FindElement(By.Id("RGWPageAllUserActionsIconImage"));
                IWebElement RGWPageRGWUserActionsIconImage = driver.FindElement(By.Id("RGWPageRGWUserActionsIconImage"));
                IWebElement RGWPageMyTotalActionsIconImage = driver.FindElement(By.Id("RGWPageMyTotalActionsIconImage"));
                IWebElement RGWPageMyCO2ImpactIconImage = driver.FindElement(By.Id("RGWPageMyCO2ImpactIconImage"));
                IWebElement ImpactIconRow1 = driver.FindElement(By.Id("ImpactIconRow1"));
                IWebElement ImpactIconRow2 = driver.FindElement(By.Id("ImpactIconRow2"));
                IWebElement ImpactIconRow3 = driver.FindElement(By.Id("ImpactIconRow3"));
                IWebElement ImpactIconRow4 = driver.FindElement(By.Id("ImpactIconRow4"));
                IWebElement ImpactIconRow5 = driver.FindElement(By.Id("ImpactIconRow5"));
                IWebElement ImpactIconRow6 = driver.FindElement(By.Id("ImpactIconRow6"));
                IWebElement ImpactIconRow7 = driver.FindElement(By.Id("ImpactIconRow7"));
                IWebElement ImpactIconRow8 = driver.FindElement(By.Id("ImpactIconRow8"));
                IWebElement ImpactIconRow9 = driver.FindElement(By.Id("ImpactIconRow9"));
                IWebElement ImpactIconRow10 = driver.FindElement(By.Id("ImpactIconRow10"));
                IWebElement ImpactIconRow11 = driver.FindElement(By.Id("ImpactIconRow11"));
                IWebElement ImpactIconRow12 = driver.FindElement(By.Id("ImpactIconRow12"));
                IWebElement ImpactIconRow13 = driver.FindElement(By.Id("ImpactIconRow13"));
                IWebElement ImpactIconRow14 = driver.FindElement(By.Id("ImpactIconRow14"));
                IWebElement ImpactIconRow15 = driver.FindElement(By.Id("ImpactIconRow15"));
                IWebElement ImpactIconRow16 = driver.FindElement(By.Id("ImpactIconRow16"));
                IWebElement ImpactIconRow17 = driver.FindElement(By.Id("ImpactIconRow17"));
                IWebElement ImpactIconRow18 = driver.FindElement(By.Id("ImpactIconRow18"));
                IWebElement ImpactIconRow19 = driver.FindElement(By.Id("ImpactIconRow19"));
                IWebElement ImpactIconRow20 = driver.FindElement(By.Id("ImpactIconRow20"));
                IWebElement ImpactIconRow21 = driver.FindElement(By.Id("ImpactIconRow21"));
                IWebElement ImpactIconRow22 = driver.FindElement(By.Id("ImpactIconRow22"));
                IWebElement ImpactIconRow23 = driver.FindElement(By.Id("ImpactIconRow23"));
                IWebElement ImpactIconRow24 = driver.FindElement(By.Id("ImpactIconRow24"));
                IWebElement MouseClickIconRow1 = driver.FindElement(By.Id("MouseClickIconRow1"));
                IWebElement MouseClickIconRow2 = driver.FindElement(By.Id("MouseClickIconRow2"));
                IWebElement MouseClickIconRow3 = driver.FindElement(By.Id("MouseClickIconRow3"));
                IWebElement MouseClickIconRow4 = driver.FindElement(By.Id("MouseClickIconRow4"));
                IWebElement MouseClickIconRow5 = driver.FindElement(By.Id("MouseClickIconRow5"));
                IWebElement MouseClickIconRow6 = driver.FindElement(By.Id("MouseClickIconRow6"));
                IWebElement MouseClickIconRow7 = driver.FindElement(By.Id("MouseClickIconRow7"));
                IWebElement MouseClickIconRow8 = driver.FindElement(By.Id("MouseClickIconRow8"));
                IWebElement MouseClickIconRow9 = driver.FindElement(By.Id("MouseClickIconRow9"));
                IWebElement MouseClickIconRow10 = driver.FindElement(By.Id("MouseClickIconRow10"));
                IWebElement MouseClickIconRow11 = driver.FindElement(By.Id("MouseClickIconRow11"));
                IWebElement MouseClickIconRow12 = driver.FindElement(By.Id("MouseClickIconRow12"));
                IWebElement MouseClickIconRow13 = driver.FindElement(By.Id("MouseClickIconRow13"));
                IWebElement MouseClickIconRow14 = driver.FindElement(By.Id("MouseClickIconRow14"));
                IWebElement MouseClickIconRow15 = driver.FindElement(By.Id("MouseClickIconRow15"));
                IWebElement MouseClickIconRow16 = driver.FindElement(By.Id("MouseClickIconRow16"));
                IWebElement MouseClickIconRow17 = driver.FindElement(By.Id("MouseClickIconRow17"));
                IWebElement MouseClickIconRow18 = driver.FindElement(By.Id("MouseClickIconRow18"));
                IWebElement MouseClickIconRow19 = driver.FindElement(By.Id("MouseClickIconRow19"));
                IWebElement MouseClickIconRow20 = driver.FindElement(By.Id("MouseClickIconRow20"));
                IWebElement MouseClickIconRow21 = driver.FindElement(By.Id("MouseClickIconRow21"));
                IWebElement MouseClickIconRow22 = driver.FindElement(By.Id("MouseClickIconRow22"));
                IWebElement MouseClickIconRow23 = driver.FindElement(By.Id("MouseClickIconRow23"));
                IWebElement MouseClickIconRow24 = driver.FindElement(By.Id("MouseClickIconRow24"));
                IWebElement HandTapIconRow1 = driver.FindElement(By.Id("HandTapIconRow1"));
                IWebElement HandTapIconRow2 = driver.FindElement(By.Id("HandTapIconRow2"));
                IWebElement HandTapIconRow3 = driver.FindElement(By.Id("HandTapIconRow3"));
                IWebElement HandTapIconRow4 = driver.FindElement(By.Id("HandTapIconRow4"));
                IWebElement HandTapIconRow5 = driver.FindElement(By.Id("HandTapIconRow5"));
                IWebElement HandTapIconRow6 = driver.FindElement(By.Id("HandTapIconRow6"));
                IWebElement HandTapIconRow7 = driver.FindElement(By.Id("HandTapIconRow7"));
                IWebElement HandTapIconRow8 = driver.FindElement(By.Id("HandTapIconRow8"));
                IWebElement HandTapIconRow9 = driver.FindElement(By.Id("HandTapIconRow9"));
                IWebElement HandTapIconRow10 = driver.FindElement(By.Id("HandTapIconRow10"));
                IWebElement HandTapIconRow11 = driver.FindElement(By.Id("HandTapIconRow11"));
                IWebElement HandTapIconRow12 = driver.FindElement(By.Id("HandTapIconRow12"));
                IWebElement HandTapIconRow13 = driver.FindElement(By.Id("HandTapIconRow13"));
                IWebElement HandTapIconRow14 = driver.FindElement(By.Id("HandTapIconRow14"));
                IWebElement HandTapIconRow15 = driver.FindElement(By.Id("HandTapIconRow15"));
                IWebElement HandTapIconRow16 = driver.FindElement(By.Id("HandTapIconRow16"));
                IWebElement HandTapIconRow17 = driver.FindElement(By.Id("HandTapIconRow17"));
                IWebElement HandTapIconRow18 = driver.FindElement(By.Id("HandTapIconRow18"));
                IWebElement HandTapIconRow19 = driver.FindElement(By.Id("HandTapIconRow19"));
                IWebElement HandTapIconRow20 = driver.FindElement(By.Id("HandTapIconRow20"));
                IWebElement HandTapIconRow21 = driver.FindElement(By.Id("HandTapIconRow21"));
                IWebElement HandTapIconRow22 = driver.FindElement(By.Id("HandTapIconRow22"));
                IWebElement HandTapIconRow23 = driver.FindElement(By.Id("HandTapIconRow23"));
                IWebElement HandTapIconRow24 = driver.FindElement(By.Id("HandTapIconRow24"));
                IWebElement RGWPageTwitterShareIconImage1 = driver.FindElement(By.Id("RGWPageTwitterShareIconImage1"));
                IWebElement RGWPageFBShareIconImage1 = driver.FindElement(By.Id("RGWPageFBShareIconImage2"));
                IWebElement RGWPageLinkedinShareIconImage1 = driver.FindElement(By.Id("RGWPageLinkedinShareIconImage2"));
                IWebElement RGWPageTwitterShareIconImage2 = driver.FindElement(By.Id("RGWPageTwitterShareIconImage2"));
                IWebElement RGWPageFBShareIconImage2 = driver.FindElement(By.Id("RGWPageFBShareIconImage3"));
                IWebElement RGWPageLinkedinShareIconImage2 = driver.FindElement(By.Id("RGWPageLinkedinShareIconImage3"));
                IWebElement RGWPageTwitterShareIconImage3 = driver.FindElement(By.Id("RGWPageTwitterShareIconImage3"));
                IWebElement RGWPageFBShareIconImage3 = driver.FindElement(By.Id("RGWPageFBShareIconImage4"));
                IWebElement RGWPageLinkedinShareIconImage3 = driver.FindElement(By.Id("RGWPageLinkedinShareIconImage4"));
                IWebElement RGWPageTwitterShareIconImage4 = driver.FindElement(By.Id("RGWPageTwitterShareIconImage4"));
                IWebElement RGWPageFBShareIconImage4 = driver.FindElement(By.Id("RGWPageFBShareIconImage5"));
                IWebElement RGWPageLinkedinShareIconImage4 = driver.FindElement(By.Id("RGWPageLinkedinShareIconImage5"));

                Assert.True(BannerImageElement.Displayed);
                Assert.True(_LayoutPageLogoElement.Displayed);
                Assert.True(BodyBackground.Displayed);
                Assert.True(RGWPageAllUserActionsIconImage.Displayed);
                Assert.True(RGWPageRGWUserActionsIconImage.Displayed);
                Assert.True(RGWPageMyTotalActionsIconImage.Displayed);
                Assert.True(RGWPageMyCO2ImpactIconImage.Displayed);
                Assert.True(ImpactIconRow1.Displayed);
                Assert.True(ImpactIconRow2.Displayed);
                Assert.True(ImpactIconRow3.Displayed);
                Assert.True(ImpactIconRow4.Displayed);
                Assert.True(ImpactIconRow5.Displayed);
                Assert.True(ImpactIconRow6.Displayed);
                Assert.True(ImpactIconRow7.Displayed);
                Assert.True(ImpactIconRow8.Displayed);
                Assert.True(ImpactIconRow9.Displayed);
                Assert.True(ImpactIconRow10.Displayed);
                Assert.True(ImpactIconRow11.Displayed);
                Assert.True(ImpactIconRow12.Displayed);
                Assert.True(ImpactIconRow13.Displayed);
                Assert.True(ImpactIconRow14.Displayed);
                Assert.True(ImpactIconRow15.Displayed);
                Assert.True(ImpactIconRow16.Displayed);
                Assert.True(ImpactIconRow17.Displayed);
                Assert.True(ImpactIconRow18.Displayed);
                Assert.True(ImpactIconRow19.Displayed);
                Assert.True(ImpactIconRow20.Displayed);
                Assert.True(ImpactIconRow21.Displayed);
                Assert.True(ImpactIconRow22.Displayed);
                Assert.True(ImpactIconRow23.Displayed);
                Assert.True(ImpactIconRow24.Displayed);
                Assert.True(MouseClickIconRow1.Displayed);
                Assert.True(MouseClickIconRow2.Displayed);
                Assert.True(MouseClickIconRow3.Displayed);
                Assert.True(MouseClickIconRow4.Displayed);
                Assert.True(MouseClickIconRow5.Displayed);
                Assert.True(MouseClickIconRow6.Displayed);
                Assert.True(MouseClickIconRow7.Displayed);
                Assert.True(MouseClickIconRow8.Displayed);
                Assert.True(MouseClickIconRow9.Displayed);
                Assert.True(MouseClickIconRow10.Displayed);
                Assert.True(MouseClickIconRow11.Displayed);
                Assert.True(MouseClickIconRow12.Displayed);
                Assert.True(MouseClickIconRow13.Displayed);
                Assert.True(MouseClickIconRow14.Displayed);
                Assert.True(MouseClickIconRow15.Displayed);
                Assert.True(MouseClickIconRow16.Displayed);
                Assert.True(MouseClickIconRow17.Displayed);
                Assert.True(MouseClickIconRow18.Displayed);
                Assert.True(MouseClickIconRow19.Displayed);
                Assert.True(MouseClickIconRow20.Displayed);
                Assert.True(MouseClickIconRow21.Displayed);
                Assert.True(MouseClickIconRow22.Displayed);
                Assert.True(MouseClickIconRow23.Displayed);
                Assert.True(MouseClickIconRow24.Displayed);
                Assert.False(HandTapIconRow1.Displayed);
                Assert.False(HandTapIconRow2.Displayed);
                Assert.False(HandTapIconRow3.Displayed);
                Assert.False(HandTapIconRow4.Displayed);
                Assert.False(HandTapIconRow5.Displayed);
                Assert.False(HandTapIconRow6.Displayed);
                Assert.False(HandTapIconRow7.Displayed);
                Assert.False(HandTapIconRow8.Displayed);
                Assert.False(HandTapIconRow9.Displayed);
                Assert.False(HandTapIconRow10.Displayed);
                Assert.False(HandTapIconRow11.Displayed);
                Assert.False(HandTapIconRow12.Displayed);
                Assert.False(HandTapIconRow13.Displayed);
                Assert.False(HandTapIconRow14.Displayed);
                Assert.False(HandTapIconRow15.Displayed);
                Assert.False(HandTapIconRow16.Displayed);
                Assert.False(HandTapIconRow17.Displayed);
                Assert.False(HandTapIconRow18.Displayed);
                Assert.False(HandTapIconRow19.Displayed);
                Assert.False(HandTapIconRow20.Displayed);
                Assert.False(HandTapIconRow21.Displayed);
                Assert.False(HandTapIconRow22.Displayed);
                Assert.False(HandTapIconRow23.Displayed);
                Assert.False(HandTapIconRow24.Displayed);
                
                Assert.True(RGWPageTwitterShareIconImage1.Displayed);
                Assert.True(RGWPageFBShareIconImage1.Displayed);
                Assert.True(RGWPageLinkedinShareIconImage1.Displayed);
                Assert.True(RGWPageTwitterShareIconImage2.Displayed);
                Assert.True(RGWPageFBShareIconImage2.Displayed);
                Assert.True(RGWPageLinkedinShareIconImage2.Displayed);
                Assert.True(RGWPageTwitterShareIconImage3.Displayed);
                Assert.True(RGWPageFBShareIconImage3.Displayed);
                Assert.True(RGWPageLinkedinShareIconImage3.Displayed);
                Assert.True(RGWPageTwitterShareIconImage4.Displayed);
                Assert.True(RGWPageFBShareIconImage4.Displayed);
                Assert.True(RGWPageLinkedinShareIconImage4.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);
                var js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", HandTapIconRow1);
                IWebElement HandTapIconRow1b = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("HandTapIconRow1")));
                Assert.True(RGWPageAllUserActionsIconImage.Displayed);
                Assert.True(RGWPageRGWUserActionsIconImage.Displayed);
                Assert.True(RGWPageMyTotalActionsIconImage.Displayed);
                Assert.True(RGWPageMyCO2ImpactIconImage.Displayed);
                Assert.True(HandTapIconRow1b.Displayed);
                Assert.True(HandTapIconRow2.Displayed);
                Assert.True(HandTapIconRow3.Displayed);
                Assert.True(HandTapIconRow4.Displayed);
                Assert.True(HandTapIconRow5.Displayed);
                Assert.True(HandTapIconRow6.Displayed);
                Assert.True(HandTapIconRow7.Displayed);
                Assert.True(HandTapIconRow8.Displayed);
                Assert.True(HandTapIconRow9.Displayed);
                Assert.True(HandTapIconRow10.Displayed);
                Assert.True(HandTapIconRow11.Displayed);
                Assert.True(HandTapIconRow12.Displayed);
                Assert.True(HandTapIconRow13.Displayed);
                Assert.True(HandTapIconRow14.Displayed);
                Assert.True(HandTapIconRow15.Displayed);
                Assert.True(HandTapIconRow16.Displayed);
                Assert.True(HandTapIconRow17.Displayed);
                Assert.True(HandTapIconRow18.Displayed);
                Assert.True(HandTapIconRow19.Displayed);
                Assert.True(HandTapIconRow20.Displayed);
                Assert.True(HandTapIconRow21.Displayed);
                Assert.True(HandTapIconRow22.Displayed);
                Assert.True(HandTapIconRow23.Displayed);
                Assert.True(HandTapIconRow24.Displayed);
                Assert.False(MouseClickIconRow1.Displayed);
                Assert.False(MouseClickIconRow2.Displayed);
                Assert.False(MouseClickIconRow3.Displayed);
                Assert.False(MouseClickIconRow4.Displayed);
                Assert.False(MouseClickIconRow5.Displayed);
                Assert.False(MouseClickIconRow6.Displayed);
                Assert.False(MouseClickIconRow7.Displayed);
                Assert.False(MouseClickIconRow8.Displayed);
                Assert.False(MouseClickIconRow9.Displayed);
                Assert.False(MouseClickIconRow10.Displayed);
                Assert.False(MouseClickIconRow11.Displayed);
                Assert.False(MouseClickIconRow12.Displayed);
                Assert.False(MouseClickIconRow13.Displayed);
                Assert.False(MouseClickIconRow14.Displayed);
                Assert.False(MouseClickIconRow15.Displayed);
                Assert.False(MouseClickIconRow16.Displayed);
                Assert.False(MouseClickIconRow17.Displayed);
                Assert.False(MouseClickIconRow18.Displayed);
                Assert.False(MouseClickIconRow19.Displayed);
                Assert.False(MouseClickIconRow20.Displayed);
                Assert.False(MouseClickIconRow21.Displayed);
                Assert.False(MouseClickIconRow22.Displayed);
                Assert.False(MouseClickIconRow23.Displayed);
                Assert.False(MouseClickIconRow24.Displayed);
                Assert.True(RGWPageTwitterShareIconImage1.Displayed);
                Assert.True(RGWPageFBShareIconImage1.Displayed);
                Assert.True(RGWPageLinkedinShareIconImage1.Displayed);
                Assert.True(RGWPageTwitterShareIconImage2.Displayed);
                Assert.True(RGWPageFBShareIconImage2.Displayed);
                Assert.True(RGWPageLinkedinShareIconImage2.Displayed);
                Assert.True(RGWPageTwitterShareIconImage3.Displayed);
                Assert.True(RGWPageFBShareIconImage3.Displayed);
                Assert.True(RGWPageLinkedinShareIconImage3.Displayed);
                Assert.True(RGWPageTwitterShareIconImage4.Displayed);
                Assert.True(RGWPageFBShareIconImage4.Displayed);
                Assert.True(RGWPageLinkedinShareIconImage4.Displayed);

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
            var filename = "TestReduceGlobalWarmingPageComponentsArePresent_CheckNavBarIsDisplayed";

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

                string RGWUrl = UrlRefLibrary.GetReduceGlobalWarmingPageLocalHostUrl();
                driver.Navigate().GoToUrl(RGWUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-rgw-page")));
                IWebElement NavBarHomeLinkElement = driver.FindElement(By.Id("_RGWPageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement = driver.FindElement(By.Id("_RGWPageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_RGWPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_RGWPageHelpNavLink"));
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
            var filename = "TestReduceGlobalWarmingPageComponentsArePresent_CheckButtonsAreDisplayedAndFunction";

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

                string rgwUrl = UrlRefLibrary.GetReduceGlobalWarmingPageLocalHostUrl();
                driver.Navigate().GoToUrl(rgwUrl);
                IWebElement RGWPageRAEIconImage = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("RGWPageRAEIconImage")));
                IWebElement RGWPageRGWIconImage = driver.FindElement(By.Id("RGWPageRGWIconImage"));
                IWebElement RGWPageRDFIconImage = driver.FindElement(By.Id("RGWPageRDFIconImage"));

                Assert.True(RGWPageRAEIconImage.Displayed);
                Assert.True(RGWPageRGWIconImage.Displayed);
                Assert.True(RGWPageRDFIconImage.Displayed);

                RGWPageRGWIconImage.Click();
                IWebElement ReduceGlobalWarmingPageSubtitle = driver.FindElement(By.Id("ReduceGlobalWarmingPageSubtitle"));
                Assert.True(ReduceGlobalWarmingPageSubtitle.Displayed);

                RGWPageRAEIconImage.Click();
                IWebElement raePageSubtitle = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageSubtitle")));
                Assert.True(raePageSubtitle.Displayed);

                driver.Navigate().GoToUrl(rgwUrl);
                IWebElement RGWPageRDFIconImage1 = driver.FindElement(By.Id("RGWPageRDFIconImage"));
                RGWPageRDFIconImage1.Click();
                IWebElement rdfPageSubtitle = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageSubtitle")));
                Assert.True(rdfPageSubtitle.Displayed);

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
            var filename = "TestReduceGlobalWarmingPageComponentsArePresent_CheckTextSectionsAreDisplayed";

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
                string UserEmail = UITestStrings.Test2UserEmail();
                string UserPassword = UITestStrings.Test2UserPassword();

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Keys.Tab);
                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Keys.Tab);
                LoginEmailInputField.SendKeys(UserEmail);
                LoginPasswordInputField.SendKeys(UserPassword);

                LoginButton.Click();
                IWebElement LoggedInUserLabel = new WebDriverWait(driver1, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                string RGWUrl = UrlRefLibrary.GetReduceGlobalWarmingPageLocalHostUrl();
                driver1.Navigate().GoToUrl(RGWUrl);
                driver1.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver1, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-rgw-page")));
                IWebElement TitleElement = driver1.FindElement(By.Id("ReduceGlobalWarmingPageTitle"));
                IWebElement SubTitleElement = driver1.FindElement(By.Id("ReduceGlobalWarmingPageSubtitle"));
                IWebElement DoSomethingTodayTitle = driver1.FindElement(By.Id("DoSomethingTodayTitle"));
                IWebElement DoSomethingTodayPara = driver1.FindElement(By.Id("DoSomethingTodayPara"));
                IWebElement RGWPageAllUserActionsIconText = driver1.FindElement(By.Id("RGWPageAllUserActionsIconText"));
                IWebElement RGWPageAllUserActionsTotalText = driver1.FindElement(By.Id("RGWPageAllUserActionsTotalText"));
                IWebElement RGWPageRGWUserActionsIconText = driver1.FindElement(By.Id("RGWPageRGWUserActionsIconText"));
                IWebElement RGWPageRGWUserActionsTotalText = driver1.FindElement(By.Id("RGWPageRGWUserActionsTotalText"));
                IWebElement RGWPageMyTotalActionsIconText = driver1.FindElement(By.Id("RGWPageMyTotalActionsIconText"));
                IWebElement RGWPageMyTotalActionsTotalText = driver1.FindElement(By.Id("RGWPageMyTotalActionsTotalText"));
                IWebElement RGWPageMyCO2ImpactIconText = driver1.FindElement(By.Id("RGWPageMyCO2ImpactIconText"));
                IWebElement RGWPageMyCO2ImpactTotalText = driver1.FindElement(By.Id("RGWPageMyCO2ImpactTotalText"));
                IWebElement RGWWhatCanIDoTitle = driver1.FindElement(By.Id("RGWWhatCanIDoTitle"));
                IWebElement RGWInformationTitle = driver1.FindElement(By.Id("RGWInformationTitle"));
                IWebElement RGWImpactTitle = driver1.FindElement(By.Id("RGWImpactTitle"));
                IWebElement RGWIDidThisTodayTitle = driver1.FindElement(By.Id("RGWIDidThisTodayTitle"));
                IWebElement RGWMyImpactTitle = driver1.FindElement(By.Id("RGWMyImpactTitle"));
                IWebElement ReduceMeatIntakeTitle = driver1.FindElement(By.Id("ReduceMeatIntakeTitle"));
                IWebElement ReduceMeatIntakeTitleMobile = driver1.FindElement(By.Id("ReduceMeatIntakeTitleMobile"));
                IWebElement ReduceMeatIntakePara = driver1.FindElement(By.Id("ReduceMeatIntakePara"));
                IWebElement PlantSomeTreesTitle = driver1.FindElement(By.Id("PlantSomeTreesTitle"));
                IWebElement PlantSomeTreesTitleMobile = driver1.FindElement(By.Id("PlantSomeTreesTitleMobile"));
                IWebElement PlantSomeTreesPara = driver1.FindElement(By.Id("PlantSomeTreesPara"));
                IWebElement EatOrganicTitle = driver1.FindElement(By.Id("EatOrganicTitle"));
                IWebElement EatOrganicTitleMobile = driver1.FindElement(By.Id("EatOrganicTitleMobile"));
                IWebElement EatOrganicPara1 = driver1.FindElement(By.Id("EatOrganicPara1"));
                IWebElement GoVegetarianTitle = driver1.FindElement(By.Id("GoVegetarianTitle"));
                IWebElement GoVegetarianTitleMobile = driver1.FindElement(By.Id("GoVegetarianTitleMobile"));
                IWebElement GoVegetarianPara1 = driver1.FindElement(By.Id("GoVegetarianPara1"));
                IWebElement GoVeganTitle = driver1.FindElement(By.Id("GoVeganTitle"));
                IWebElement GoVeganTitleMobile = driver1.FindElement(By.Id("GoVeganTitleMobile"));
                IWebElement GoVeganPara1 = driver1.FindElement(By.Id("GoVeganPara1"));
                IWebElement LiveCarFreeTitle = driver1.FindElement(By.Id("LiveCarFreeTitle"));
                IWebElement LiveCarFreeTitleMobile = driver1.FindElement(By.Id("LiveCarFreeTitleMobile"));
                IWebElement LiveCarFree = driver1.FindElement(By.Id("LiveCarFree"));
                IWebElement GreenRecoveryTitle = driver1.FindElement(By.Id("GreenRecoveryTitle"));
                IWebElement GreenRecoveryTitleMobile = driver1.FindElement(By.Id("GreenRecoveryTitleMobile"));
                IWebElement GreenRecoveryPara1 = driver1.FindElement(By.Id("GreenRecoveryPara1"));
                IWebElement MinimisePlasticTitle = driver1.FindElement(By.Id("MinimisePlasticTitle"));
                IWebElement MinimisePlasticTitleMobile = driver1.FindElement(By.Id("MinimisePlasticTitleMobile"));
                IWebElement MinimisePlasticPara1 = driver1.FindElement(By.Id("MinimisePlasticPara1"));
                IWebElement BuyLocalTitle = driver1.FindElement(By.Id("BuyLocalTitle"));
                IWebElement BuyLocalTitleMobile = driver1.FindElement(By.Id("BuyLocalTitleMobile"));
                IWebElement BuyLocal = driver1.FindElement(By.Id("BuyLocal"));
                IWebElement CycleTitle = driver1.FindElement(By.Id("CycleTitle"));
                IWebElement CycleTitleMobile = driver1.FindElement(By.Id("CycleTitleMobile"));
                IWebElement IncreaseCycling = driver1.FindElement(By.Id("IncreaseCycling"));
                IWebElement DriveElectricTitle = driver1.FindElement(By.Id("DriveElectricTitle"));
                IWebElement DriveElectricTitleMobile = driver1.FindElement(By.Id("DriveElectricTitleMobile"));
                IWebElement DriveElectricPara1 = driver1.FindElement(By.Id("DriveElectricPara1"));
                IWebElement PlantYourOwnVegTitle = driver1.FindElement(By.Id("PlantYourOwnVegTitle"));
                IWebElement PlantYourOwnVegTitleMobile = driver1.FindElement(By.Id("PlantYourOwnVegTitleMobile"));
                IWebElement PlantYourOwnVegPara1 = driver1.FindElement(By.Id("PlantYourOwnVegPara1"));
                IWebElement SwitchToRenewableTitle = driver1.FindElement(By.Id("SwitchToRenewableTitle"));
                IWebElement SwitchToRenewableTitleMobile = driver1.FindElement(By.Id("SwitchToRenewableTitleMobile"));
                IWebElement SwitchToRenewablePara1 = driver1.FindElement(By.Id("SwitchToRenewablePara1"));
                IWebElement UsePublicTransportTitle = driver1.FindElement(By.Id("UsePublicTransportTitle"));
                IWebElement UsePublicTransportTitleMobile = driver1.FindElement(By.Id("UsePublicTransportTitleMobile"));
                IWebElement IncreasePublicTransport1 = driver1.FindElement(By.Id("IncreasePublicTransport1"));
                IWebElement CarPoolTitle = driver1.FindElement(By.Id("CarPoolTitle"));
                IWebElement CarPoolTitleMobile = driver1.FindElement(By.Id("CarPoolTitleMobile"));
                IWebElement IncreaseCarpooling = driver1.FindElement(By.Id("IncreaseCarpooling"));
                IWebElement FlyLessOftenTitle = driver1.FindElement(By.Id("FlyLessOftenTitle"));
                IWebElement FlyLessOftenTitleMobile = driver1.FindElement(By.Id("FlyLessOftenTitleMobile"));
                IWebElement FlyLessOftenPara1 = driver1.FindElement(By.Id("FlyLessOftenPara1"));
                IWebElement StandUp = driver1.FindElement(By.Id("StandUp"));
                IWebElement StandUpMobile = driver1.FindElement(By.Id("StandUpMobile"));
                IWebElement StandUpPara1 = driver1.FindElement(By.Id("StandUpPara1"));
                IWebElement UseABlueRecyclingBinTitle = driver1.FindElement(By.Id("UseABlueRecyclingBinTitle"));
                IWebElement UseABlueRecyclingBinTitleMobile = driver1.FindElement(By.Id("UseABlueRecyclingBinTitleMobile"));
                IWebElement UseABlueRecyclingBinPara1 = driver1.FindElement(By.Id("UseABlueRecyclingBinPara1"));
                IWebElement UseABrownCompostBinTitle = driver1.FindElement(By.Id("UseABrownCompostBinTitle"));
                IWebElement UseABrownCompostBinTitleMobile = driver1.FindElement(By.Id("UseABrownCompostBinTitleMobile"));
                IWebElement UseABrownCompostBinPara1 = driver1.FindElement(By.Id("UseABrownCompostBinPara1"));
                IWebElement InsulateYourHouseTitle = driver1.FindElement(By.Id("InsulateYourHouseTitle"));
                IWebElement InsulateYourHouseTitleMobile = driver1.FindElement(By.Id("InsulateYourHouseTitleMobile"));
                IWebElement InsulateYourHousePara1 = driver1.FindElement(By.Id("InsulateYourHousePara1"));
                IWebElement ShorterShowers = driver1.FindElement(By.Id("ShorterShowers"));
                IWebElement ShorterShowersMobile = driver1.FindElement(By.Id("ShorterShowersMobile"));
                IWebElement ShorterShowersPara1 = driver1.FindElement(By.Id("ShorterShowersPara1"));
                IWebElement FluorescentLightbulbs = driver1.FindElement(By.Id("FluorescentLightbulbs"));
                IWebElement FluorescentLightbulbsMobile = driver1.FindElement(By.Id("FluorescentLightbulbsMobile"));
                IWebElement FluorescentLightbulbsPara1 = driver1.FindElement(By.Id("FluorescentLightbulbsPara1"));
                IWebElement TurnOffLights = driver1.FindElement(By.Id("TurnOffLights"));
                IWebElement TurnOffLightsMobile = driver1.FindElement(By.Id("TurnOffLightsMobile"));
                IWebElement TurnOffLightsPara1 = driver1.FindElement(By.Id("TurnOffLightsPara1"));
                IWebElement SignAPetitionTitle = driver1.FindElement(By.Id("SignAPetitionTitle"));
                IWebElement SignAPetitionTitleMobile = driver1.FindElement(By.Id("SignAPetitionTitleMobile"));
                IWebElement SignAPetitionPara1 = driver1.FindElement(By.Id("SignAPetitionPara1"));
                IWebElement ReduceMeatIntakeParaB = driver1.FindElement(By.Id("ReduceMeatIntakeParaB"));
                IWebElement PlantSomeTreesParaB = driver1.FindElement(By.Id("PlantSomeTreesParaB"));
                IWebElement EatOrganicPara1B = driver1.FindElement(By.Id("EatOrganicPara1B"));
                IWebElement GoVegetarianPara1B = driver1.FindElement(By.Id("GoVegetarianPara1B"));
                IWebElement GoVeganPara1B = driver1.FindElement(By.Id("GoVeganPara1B"));
                IWebElement LiveCarFreeB = driver1.FindElement(By.Id("LiveCarFreeB"));
                IWebElement GreenRecoveryPara1B = driver1.FindElement(By.Id("GreenRecoveryPara1B"));
                IWebElement MinimisePlasticPara1B = driver1.FindElement(By.Id("MinimisePlasticPara1B"));
                IWebElement BuyLocalB = driver1.FindElement(By.Id("BuyLocalB"));
                IWebElement IncreaseCyclingB = driver1.FindElement(By.Id("IncreaseCyclingB"));
                IWebElement DriveElectricPara1B = driver1.FindElement(By.Id("DriveElectricPara1B"));
                IWebElement PlantYourOwnVegPara1B = driver1.FindElement(By.Id("PlantYourOwnVegPara1B"));
                IWebElement SwitchToRenewablePara1B = driver1.FindElement(By.Id("SwitchToRenewablePara1B"));
                IWebElement IncreasePublicTransport1B = driver1.FindElement(By.Id("IncreasePublicTransport1B"));
                IWebElement IncreaseCarpoolingB = driver1.FindElement(By.Id("IncreaseCarpoolingB"));
                IWebElement FlyLessOftenPara1B = driver1.FindElement(By.Id("FlyLessOftenPara1B"));
                IWebElement StandUpPara1B = driver1.FindElement(By.Id("StandUpPara1B"));
                IWebElement UseABlueRecyclingBinPara1B = driver1.FindElement(By.Id("UseABlueRecyclingBinPara1B"));
                IWebElement UseABrownCompostBinPara1B = driver1.FindElement(By.Id("UseABrownCompostBinPara1B"));
                IWebElement InsulateYourHousePara1B = driver1.FindElement(By.Id("InsulateYourHousePara1B"));
                IWebElement ShorterShowersPara1B = driver1.FindElement(By.Id("ShorterShowersPara1B"));
                IWebElement FluorescentLightbulbsPara1B = driver1.FindElement(By.Id("FluorescentLightbulbsPara1B"));
                IWebElement TurnOffLightsPara1B = driver1.FindElement(By.Id("TurnOffLightsPara1B"));
                IWebElement SignAPetitionPara1B = driver1.FindElement(By.Id("SignAPetitionPara1B"));
                IWebElement MyImpactReduceMeat = driver1.FindElement(By.Id("MyImpactReduceMeat"));
                IWebElement MyImpactPlantTrees = driver1.FindElement(By.Id("MyImpactPlantTrees"));
                IWebElement MyImpactEatOrganic = driver1.FindElement(By.Id("MyImpactEatOrganic"));
                IWebElement MyImpactGoVegetarian = driver1.FindElement(By.Id("MyImpactGoVegetarian"));
                IWebElement MyImpactGoVegan = driver1.FindElement(By.Id("MyImpactGoVegan"));
                IWebElement MyImpactLiveCarFree = driver1.FindElement(By.Id("MyImpactLiveCarFree"));
                IWebElement MyImpactGreenRecovery = driver1.FindElement(By.Id("MyImpactGreenRecovery"));
                IWebElement MyImpactMinimisePlastic = driver1.FindElement(By.Id("MyImpactMinimisePlastic"));
                IWebElement MyImpactBuyLocal = driver1.FindElement(By.Id("MyImpactBuyLocal"));
                IWebElement MyImpactCycle = driver1.FindElement(By.Id("MyImpactCycle"));
                IWebElement MyImpactDriveElectric = driver1.FindElement(By.Id("MyImpactDriveElectric"));
                IWebElement MyImpactPlantOwnVeg = driver1.FindElement(By.Id("MyImpactPlantOwnVeg"));
                IWebElement MyImpactSwitchRenewable = driver1.FindElement(By.Id("MyImpactSwitchRenewable"));
                IWebElement MyImpactPublicTransport = driver1.FindElement(By.Id("MyImpactPublicTransport"));
                IWebElement MyImpactCarPool = driver1.FindElement(By.Id("MyImpactCarPool"));
                IWebElement MyImpactFlyLess = driver1.FindElement(By.Id("MyImpactFlyLess"));
                IWebElement MyImpactStandUp = driver1.FindElement(By.Id("MyImpactStandUp"));
                IWebElement MyImpactRecyclingBin = driver1.FindElement(By.Id("MyImpactRecyclingBin"));
                IWebElement MyImpactCompostBin = driver1.FindElement(By.Id("MyImpactCompostBin"));
                IWebElement MyImpactInsulateHouse = driver1.FindElement(By.Id("MyImpactInsulateHouse"));
                IWebElement MyImpactShorterShowers = driver1.FindElement(By.Id("MyImpactShorterShowers"));
                IWebElement MyImpactFluorescent = driver1.FindElement(By.Id("MyImpactFluorescent"));
                IWebElement MyImpactTurnOffLights = driver1.FindElement(By.Id("MyImpactTurnOffLights"));
                IWebElement MyImpactSignPetition = driver1.FindElement(By.Id("MyImpactSignPetition"));

                IWebElement RGWClickDetailsTitle = driver1.FindElement(By.Id("RGWClickDetailsTitle"));
                IWebElement rgwReduceMeatIntakeClickDetails = driver1.FindElement(By.Id("rgwReduceMeatIntakeClickDetails"));
                IWebElement rgwPlantSomeTreesClickDetails = driver1.FindElement(By.Id("rgwPlantSomeTreesClickDetails"));
                IWebElement rgwEatOrganicClickDetails = driver1.FindElement(By.Id("rgwEatOrganicClickDetails"));
                IWebElement rgwGoVegetarianClickDetails = driver1.FindElement(By.Id("rgwGoVegetarianClickDetails"));
                IWebElement rgwGoVeganClickDetails = driver1.FindElement(By.Id("rgwGoVeganClickDetails"));
                IWebElement rgwLiveCarFreeClickDetails = driver1.FindElement(By.Id("rgwLiveCarFreeClickDetails"));
                IWebElement rgwGreenRecoveryClickDetails = driver1.FindElement(By.Id("rgwGreenRecoveryClickDetails"));
                IWebElement rgwMinimisePlasticClickDetails = driver1.FindElement(By.Id("rgwMinimisePlasticClickDetails"));
                IWebElement rgwBuyLocalClickDetails = driver1.FindElement(By.Id("rgwBuyLocalClickDetails"));
                IWebElement rgwCycleClickDetails = driver1.FindElement(By.Id("rgwCycleClickDetails"));
                IWebElement rgwDriveElectricClickDetails = driver1.FindElement(By.Id("rgwDriveElectricClickDetails"));
                IWebElement rgwPlantYourOwnVegClickDetails = driver1.FindElement(By.Id("rgwPlantYourOwnVegClickDetails"));
                IWebElement rgwSwitchToRenewableClickDetails = driver1.FindElement(By.Id("rgwSwitchToRenewableClickDetails"));
                IWebElement rgwUsePublicTransportClickDetails = driver1.FindElement(By.Id("rgwUsePublicTransportClickDetails"));
                IWebElement rgwCarpoolClickDetails = driver1.FindElement(By.Id("rgwCarpoolClickDetails"));
                IWebElement rgwFlyLessOftenClickDetails = driver1.FindElement(By.Id("rgwFlyLessOftenClickDetails"));
                IWebElement rgwStandUpClickDetails = driver1.FindElement(By.Id("rgwStandUpClickDetails"));
                IWebElement rgwRecyclingBinClickDetails = driver1.FindElement(By.Id("rgwRecyclingBinClickDetails"));
                IWebElement rgwCompostBinClickDetails = driver1.FindElement(By.Id("rgwCompostBinClickDetails"));
                IWebElement rgwInsulateYourHouseClickDetails = driver1.FindElement(By.Id("rgwInsulateYourHouseClickDetails"));
                IWebElement rgwShorterShowersClickDetails = driver1.FindElement(By.Id("rgwShorterShowersClickDetails"));
                IWebElement rgwFluorescentLightbulbsClickDetails = driver1.FindElement(By.Id("rgwFluorescentLightbulbsClickDetails"));
                IWebElement rgwTurnOffLightsClickDetails = driver1.FindElement(By.Id("rgwTurnOffLightsClickDetails"));
                IWebElement rgwSignAPetitionClickDetails = driver1.FindElement(By.Id("rgwSignAPetitionClickDetails"));

                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(DoSomethingTodayTitle.Displayed);
                Assert.True(DoSomethingTodayPara.Displayed);
                Assert.True(RGWPageAllUserActionsIconText.Displayed);
                Assert.True(RGWPageAllUserActionsTotalText.Displayed);
                Assert.True(RGWPageRGWUserActionsIconText.Displayed);
                Assert.True(RGWPageRGWUserActionsTotalText.Displayed);
                Assert.True(RGWPageMyTotalActionsIconText.Displayed);
                Assert.True(RGWPageMyTotalActionsTotalText.Displayed);
                Assert.True(RGWPageMyCO2ImpactIconText.Displayed);
                Assert.True(RGWPageMyCO2ImpactTotalText.Displayed);
                Assert.True(RGWWhatCanIDoTitle.Displayed);
                Assert.True(RGWInformationTitle.Displayed);
                Assert.True(RGWImpactTitle.Displayed);
                Assert.True(RGWIDidThisTodayTitle.Displayed);
                Assert.True(RGWMyImpactTitle.Displayed);
                Assert.True(ReduceMeatIntakeTitle.Displayed);
                Assert.False(ReduceMeatIntakeTitleMobile.Displayed);
                Assert.True(ReduceMeatIntakePara.Displayed);
                Assert.True(PlantSomeTreesTitle.Displayed);
                Assert.False(PlantSomeTreesTitleMobile.Displayed);
                Assert.True(PlantSomeTreesPara.Displayed);
                Assert.True(EatOrganicTitle.Displayed);
                Assert.False(EatOrganicTitleMobile.Displayed);
                Assert.True(EatOrganicPara1.Displayed);
                Assert.True(GoVegetarianTitle.Displayed);
                Assert.False(GoVegetarianTitleMobile.Displayed);
                Assert.True(GoVegetarianPara1.Displayed);
                Assert.True(GoVeganTitle.Displayed);
                Assert.False(GoVeganTitleMobile.Displayed);
                Assert.True(GoVeganPara1.Displayed);
                Assert.True(LiveCarFreeTitle.Displayed);
                Assert.False(LiveCarFreeTitleMobile.Displayed);
                Assert.True(LiveCarFree.Displayed);
                Assert.True(GreenRecoveryTitle.Displayed);
                Assert.False(GreenRecoveryTitleMobile.Displayed);
                Assert.True(GreenRecoveryPara1.Displayed);
                Assert.True(MinimisePlasticTitle.Displayed);
                Assert.False(MinimisePlasticTitleMobile.Displayed);
                Assert.True(MinimisePlasticPara1.Displayed);
                Assert.True(BuyLocalTitle.Displayed);
                Assert.False(BuyLocalTitleMobile.Displayed);
                Assert.True(BuyLocal.Displayed);
                Assert.True(CycleTitle.Displayed);
                Assert.False(CycleTitleMobile.Displayed);
                Assert.True(IncreaseCycling.Displayed);
                Assert.True(DriveElectricTitle.Displayed);
                Assert.False(DriveElectricTitleMobile.Displayed);
                Assert.True(DriveElectricPara1.Displayed);
                Assert.True(PlantYourOwnVegTitle.Displayed);
                Assert.False(PlantYourOwnVegTitleMobile.Displayed);
                Assert.True(PlantYourOwnVegPara1.Displayed);
                Assert.True(SwitchToRenewableTitle.Displayed);
                Assert.False(SwitchToRenewableTitleMobile.Displayed);
                Assert.True(SwitchToRenewablePara1.Displayed);
                Assert.True(UsePublicTransportTitle.Displayed);
                Assert.False(UsePublicTransportTitleMobile.Displayed);
                Assert.True(IncreasePublicTransport1.Displayed);
                Assert.True(CarPoolTitle.Displayed);
                Assert.False(CarPoolTitleMobile.Displayed);
                Assert.True(IncreaseCarpooling.Displayed);
                Assert.True(FlyLessOftenTitle.Displayed);
                Assert.False(FlyLessOftenTitleMobile.Displayed);
                Assert.True(FlyLessOftenPara1.Displayed);
                Assert.True(StandUp.Displayed);
                Assert.False(StandUpMobile.Displayed);
                Assert.True(StandUpPara1.Displayed);
                Assert.True(UseABlueRecyclingBinTitle.Displayed);
                Assert.False(UseABlueRecyclingBinTitleMobile.Displayed);
                Assert.True(UseABlueRecyclingBinPara1.Displayed);
                Assert.True(UseABrownCompostBinTitle.Displayed);
                Assert.False(UseABrownCompostBinTitleMobile.Displayed);
                Assert.True(UseABrownCompostBinPara1.Displayed);
                Assert.True(InsulateYourHouseTitle.Displayed);
                Assert.False(InsulateYourHouseTitleMobile.Displayed);
                Assert.True(InsulateYourHousePara1.Displayed);
                Assert.True(ShorterShowers.Displayed);
                Assert.False(ShorterShowersMobile.Displayed);
                Assert.True(ShorterShowersPara1.Displayed);
                Assert.True(FluorescentLightbulbs.Displayed);
                Assert.False(FluorescentLightbulbsMobile.Displayed);
                Assert.True(FluorescentLightbulbsPara1.Displayed);
                Assert.True(TurnOffLights.Displayed);
                Assert.False(TurnOffLightsMobile.Displayed);
                Assert.True(TurnOffLightsPara1.Displayed);
                Assert.True(SignAPetitionTitle.Displayed);
                Assert.False(SignAPetitionTitleMobile.Displayed);
                Assert.True(SignAPetitionPara1.Displayed);
                Assert.True(MyImpactReduceMeat.Displayed);
                Assert.True(MyImpactPlantTrees.Displayed);
                Assert.True(MyImpactEatOrganic.Displayed);
                Assert.True(MyImpactGoVegetarian.Displayed);
                Assert.True(MyImpactGoVegan.Displayed);
                Assert.True(MyImpactLiveCarFree.Displayed);
                Assert.True(MyImpactGreenRecovery.Displayed);
                Assert.True(MyImpactMinimisePlastic.Displayed);
                Assert.True(MyImpactBuyLocal.Displayed);
                Assert.True(MyImpactCycle.Displayed);
                Assert.True(MyImpactDriveElectric.Displayed);
                Assert.True(MyImpactPlantOwnVeg.Displayed);
                Assert.True(MyImpactSwitchRenewable.Displayed);
                Assert.True(MyImpactPublicTransport.Displayed);
                Assert.True(MyImpactCarPool.Displayed);
                Assert.True(MyImpactFlyLess.Displayed);
                Assert.True(MyImpactStandUp.Displayed);
                Assert.True(MyImpactRecyclingBin.Displayed);
                Assert.True(MyImpactCompostBin.Displayed);
                Assert.True(MyImpactInsulateHouse.Displayed);
                Assert.True(MyImpactShorterShowers.Displayed);
                Assert.True(MyImpactFluorescent.Displayed);
                Assert.True(MyImpactTurnOffLights.Displayed);
                Assert.True(MyImpactSignPetition.Displayed);
                Assert.False(ReduceMeatIntakeParaB.Displayed);
                Assert.False(PlantSomeTreesParaB.Displayed);
                Assert.False(EatOrganicPara1B.Displayed);
                Assert.False(GoVegetarianPara1B.Displayed);
                Assert.False(GoVeganPara1B.Displayed);
                Assert.False(LiveCarFreeB.Displayed);
                Assert.False(GreenRecoveryPara1B.Displayed);
                Assert.False(MinimisePlasticPara1B.Displayed);
                Assert.False(BuyLocalB.Displayed);
                Assert.False(IncreaseCyclingB.Displayed);
                Assert.False(DriveElectricPara1B.Displayed);
                Assert.False(PlantYourOwnVegPara1B.Displayed);
                Assert.False(SwitchToRenewablePara1B.Displayed);
                Assert.False(IncreasePublicTransport1B.Displayed);
                Assert.False(IncreaseCarpoolingB.Displayed);
                Assert.False(FlyLessOftenPara1B.Displayed);
                Assert.False(StandUpPara1B.Displayed);
                Assert.False(UseABlueRecyclingBinPara1B.Displayed);
                Assert.False(UseABrownCompostBinPara1B.Displayed);
                Assert.False(InsulateYourHousePara1B.Displayed);
                Assert.False(ShorterShowersPara1B.Displayed);
                Assert.False(FluorescentLightbulbsPara1B.Displayed);
                Assert.False(TurnOffLightsPara1B.Displayed);
                Assert.False(SignAPetitionPara1B.Displayed);
                Assert.True(RGWClickDetailsTitle.Displayed);
                Assert.True(rgwReduceMeatIntakeClickDetails.Displayed);
                Assert.True(rgwPlantSomeTreesClickDetails.Displayed);
                Assert.True(rgwEatOrganicClickDetails.Displayed);
                Assert.True(rgwGoVegetarianClickDetails.Displayed);
                Assert.True(rgwGoVeganClickDetails.Displayed);
                Assert.True(rgwLiveCarFreeClickDetails.Displayed);
                Assert.True(rgwGreenRecoveryClickDetails.Displayed);
                Assert.True(rgwMinimisePlasticClickDetails.Displayed);
                Assert.True(rgwCycleClickDetails.Displayed);
                Assert.True(rgwDriveElectricClickDetails.Displayed);
                Assert.True(rgwPlantYourOwnVegClickDetails.Displayed);
                Assert.True(rgwSwitchToRenewableClickDetails.Displayed);
                Assert.True(rgwUsePublicTransportClickDetails.Displayed);
                Assert.True(rgwCarpoolClickDetails.Displayed);
                Assert.True(rgwFlyLessOftenClickDetails.Displayed);
                Assert.True(rgwStandUpClickDetails.Displayed);
                Assert.True(rgwRecyclingBinClickDetails.Displayed);
                Assert.True(rgwCompostBinClickDetails.Displayed);
                Assert.True(rgwInsulateYourHouseClickDetails.Displayed);
                Assert.True(rgwShorterShowersClickDetails.Displayed);
                Assert.True(rgwFluorescentLightbulbsClickDetails.Displayed);
                Assert.True(rgwTurnOffLightsClickDetails.Displayed);
                Assert.True(rgwSignAPetitionClickDetails.Displayed);

                driver1.Manage().Window.Size = new Size(240, 600);

                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(DoSomethingTodayTitle.Displayed);
                Assert.True(DoSomethingTodayPara.Displayed);
                Assert.True(RGWPageAllUserActionsIconText.Displayed);
                Assert.True(RGWPageAllUserActionsTotalText.Displayed);
                Assert.True(RGWPageRGWUserActionsIconText.Displayed);
                Assert.True(RGWPageRGWUserActionsTotalText.Displayed);
                Assert.True(RGWPageMyTotalActionsIconText.Displayed);
                Assert.True(RGWPageMyTotalActionsTotalText.Displayed);
                Assert.True(RGWPageMyCO2ImpactIconText.Displayed);
                Assert.True(RGWPageMyCO2ImpactTotalText.Displayed);
                Assert.True(RGWWhatCanIDoTitle.Displayed);
                Assert.False(RGWInformationTitle.Displayed);
                Assert.True(RGWImpactTitle.Displayed);
                Assert.True(RGWIDidThisTodayTitle.Displayed);
                Assert.True(RGWMyImpactTitle.Displayed);
                Assert.False(ReduceMeatIntakeTitle.Displayed);
                Assert.True(ReduceMeatIntakeTitleMobile.Displayed);
                Assert.False(ReduceMeatIntakePara.Displayed);
                Assert.False(PlantSomeTreesTitle.Displayed);
                Assert.True(PlantSomeTreesTitleMobile.Displayed);
                Assert.False(PlantSomeTreesPara.Displayed);
                Assert.False(EatOrganicTitle.Displayed);
                Assert.True(EatOrganicTitleMobile.Displayed);
                Assert.False(EatOrganicPara1.Displayed);
                Assert.False(GoVegetarianTitle.Displayed);
                Assert.True(GoVegetarianTitleMobile.Displayed);
                Assert.False(GoVegetarianPara1.Displayed);
                Assert.False(GoVeganTitle.Displayed);
                Assert.True(GoVeganTitleMobile.Displayed);
                Assert.False(GoVeganPara1.Displayed);
                Assert.False(LiveCarFreeTitle.Displayed);
                Assert.True(LiveCarFreeTitleMobile.Displayed);
                Assert.False(LiveCarFree.Displayed);
                Assert.False(GreenRecoveryTitle.Displayed);
                Assert.True(GreenRecoveryTitleMobile.Displayed);
                Assert.False(GreenRecoveryPara1.Displayed);
                Assert.False(MinimisePlasticTitle.Displayed);
                Assert.True(MinimisePlasticTitleMobile.Displayed);
                Assert.False(MinimisePlasticPara1.Displayed);
                Assert.False(BuyLocalTitle.Displayed);
                Assert.True(BuyLocalTitleMobile.Displayed);
                Assert.False(BuyLocal.Displayed);
                Assert.False(CycleTitle.Displayed);
                Assert.True(CycleTitleMobile.Displayed);
                Assert.False(IncreaseCycling.Displayed);
                Assert.False(DriveElectricTitle.Displayed);
                Assert.True(DriveElectricTitleMobile.Displayed);
                Assert.False(DriveElectricPara1.Displayed);
                Assert.False(PlantYourOwnVegTitle.Displayed);
                Assert.True(PlantYourOwnVegTitleMobile.Displayed);
                Assert.False(PlantYourOwnVegPara1.Displayed);
                Assert.False(SwitchToRenewableTitle.Displayed);
                Assert.True(SwitchToRenewableTitleMobile.Displayed);
                Assert.False(SwitchToRenewablePara1.Displayed);
                Assert.False(UsePublicTransportTitle.Displayed);
                Assert.True(UsePublicTransportTitleMobile.Displayed);
                Assert.False(IncreasePublicTransport1.Displayed);
                Assert.False(CarPoolTitle.Displayed);
                Assert.True(CarPoolTitleMobile.Displayed);
                Assert.False(IncreaseCarpooling.Displayed);
                Assert.False(FlyLessOftenTitle.Displayed);
                Assert.True(FlyLessOftenTitleMobile.Displayed);
                Assert.False(FlyLessOftenPara1.Displayed);
                Assert.False(StandUp.Displayed);
                Assert.True(StandUpMobile.Displayed);
                Assert.False(StandUpPara1.Displayed);
                Assert.False(UseABlueRecyclingBinTitle.Displayed);
                Assert.True(UseABlueRecyclingBinTitleMobile.Displayed);
                Assert.False(UseABlueRecyclingBinPara1.Displayed);
                Assert.False(UseABrownCompostBinTitle.Displayed);
                Assert.True(UseABrownCompostBinTitleMobile.Displayed);
                Assert.False(UseABrownCompostBinPara1.Displayed);
                Assert.False(InsulateYourHouseTitle.Displayed);
                Assert.True(InsulateYourHouseTitleMobile.Displayed);
                Assert.False(InsulateYourHousePara1.Displayed);
                Assert.False(ShorterShowers.Displayed);
                Assert.True(ShorterShowersMobile.Displayed);
                Assert.False(ShorterShowersPara1.Displayed);
                Assert.False(FluorescentLightbulbs.Displayed);
                Assert.True(FluorescentLightbulbsMobile.Displayed);
                Assert.False(FluorescentLightbulbsPara1.Displayed);
                Assert.False(TurnOffLights.Displayed);
                Assert.True(TurnOffLightsMobile.Displayed);
                Assert.False(TurnOffLightsPara1.Displayed);
                Assert.False(SignAPetitionTitle.Displayed);
                Assert.True(SignAPetitionTitleMobile.Displayed);
                Assert.False(SignAPetitionPara1.Displayed);
                Assert.True(MyImpactReduceMeat.Displayed);
                Assert.True(MyImpactPlantTrees.Displayed);
                Assert.True(MyImpactEatOrganic.Displayed);
                Assert.True(MyImpactGoVegetarian.Displayed);
                Assert.True(MyImpactGoVegan.Displayed);
                Assert.True(MyImpactLiveCarFree.Displayed);
                Assert.True(MyImpactGreenRecovery.Displayed);
                Assert.True(MyImpactMinimisePlastic.Displayed);
                Assert.True(MyImpactBuyLocal.Displayed);
                Assert.True(MyImpactCycle.Displayed);
                Assert.True(MyImpactDriveElectric.Displayed);
                Assert.True(MyImpactPlantOwnVeg.Displayed);
                Assert.True(MyImpactSwitchRenewable.Displayed);
                Assert.True(MyImpactPublicTransport.Displayed);
                Assert.True(MyImpactCarPool.Displayed);
                Assert.True(MyImpactFlyLess.Displayed);
                Assert.True(MyImpactStandUp.Displayed);
                Assert.True(MyImpactRecyclingBin.Displayed);
                Assert.True(MyImpactCompostBin.Displayed);
                Assert.True(MyImpactInsulateHouse.Displayed);
                Assert.True(MyImpactShorterShowers.Displayed);
                Assert.True(MyImpactFluorescent.Displayed);
                Assert.True(MyImpactTurnOffLights.Displayed);
                Assert.True(MyImpactSignPetition.Displayed);
                Assert.True(ReduceMeatIntakeParaB.Displayed);
                Assert.True(PlantSomeTreesParaB.Displayed);
                Assert.True(EatOrganicPara1B.Displayed);
                Assert.True(GoVegetarianPara1B.Displayed);
                Assert.True(GoVeganPara1B.Displayed);
                Assert.True(LiveCarFreeB.Displayed);
                Assert.True(GreenRecoveryPara1B.Displayed);
                Assert.True(MinimisePlasticPara1B.Displayed);
                Assert.True(BuyLocalB.Displayed);
                Assert.True(IncreaseCyclingB.Displayed);
                Assert.True(DriveElectricPara1B.Displayed);
                Assert.True(PlantYourOwnVegPara1B.Displayed);
                Assert.True(SwitchToRenewablePara1B.Displayed);
                Assert.True(IncreasePublicTransport1B.Displayed);
                Assert.True(IncreaseCarpoolingB.Displayed);
                Assert.True(FlyLessOftenPara1B.Displayed);
                Assert.True(StandUpPara1B.Displayed);
                Assert.True(UseABlueRecyclingBinPara1B.Displayed);
                Assert.True(UseABrownCompostBinPara1B.Displayed);
                Assert.True(InsulateYourHousePara1B.Displayed);
                Assert.True(ShorterShowersPara1B.Displayed);
                Assert.True(FluorescentLightbulbsPara1B.Displayed);
                Assert.True(TurnOffLightsPara1B.Displayed);
                Assert.True(SignAPetitionPara1B.Displayed);
                Assert.True(RGWClickDetailsTitle.Displayed);
                Assert.True(rgwReduceMeatIntakeClickDetails.Displayed);
                Assert.True(rgwPlantSomeTreesClickDetails.Displayed);
                Assert.True(rgwEatOrganicClickDetails.Displayed);
                Assert.True(rgwGoVegetarianClickDetails.Displayed);
                Assert.True(rgwGoVeganClickDetails.Displayed);
                Assert.True(rgwLiveCarFreeClickDetails.Displayed);
                Assert.True(rgwGreenRecoveryClickDetails.Displayed);
                Assert.True(rgwMinimisePlasticClickDetails.Displayed);
                Assert.True(rgwCycleClickDetails.Displayed);
                Assert.True(rgwDriveElectricClickDetails.Displayed);
                Assert.True(rgwPlantYourOwnVegClickDetails.Displayed);
                Assert.True(rgwSwitchToRenewableClickDetails.Displayed);
                Assert.True(rgwUsePublicTransportClickDetails.Displayed);
                Assert.True(rgwCarpoolClickDetails.Displayed);
                Assert.True(rgwFlyLessOftenClickDetails.Displayed);
                Assert.True(rgwStandUpClickDetails.Displayed);
                Assert.True(rgwRecyclingBinClickDetails.Displayed);
                Assert.True(rgwCompostBinClickDetails.Displayed);
                Assert.True(rgwInsulateYourHouseClickDetails.Displayed);
                Assert.True(rgwShorterShowersClickDetails.Displayed);
                Assert.True(rgwFluorescentLightbulbsClickDetails.Displayed);
                Assert.True(rgwTurnOffLightsClickDetails.Displayed);
                Assert.True(rgwSignAPetitionClickDetails.Displayed);
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
            var filename = "TestReduceGlobalWarmingPageComponentsArePresent_CheckModalsAreDisplayedOnClick";

            TakeTestFailScreenshot.UITest(() =>
            {
                var ReduceGlobalWarmingPageLocSourceNamesLibrary = new ReduceGlobalWarmingPageLocSourceNames();
                var SharedCrossPageLocSourceNamesLibrary = new SharedCrossPageLocSourceNames();
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

                string RGWUrl = UrlRefLibrary.GetReduceGlobalWarmingPageLocalHostUrl();
                driver.Navigate().GoToUrl(RGWUrl);

                IWebElement ReduceMeatIntakeTitle = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ReduceMeatIntakeTitle")));
                IWebElement LearnMoreRow1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow1")));
                IWebElement LearnMoreRow2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow2")));
                IWebElement LearnMoreRow3 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow3")));
                IWebElement LearnMoreRow4 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow4")));
                IWebElement LearnMoreRow5 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow5")));
                IWebElement LearnMoreRow6 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow6")));
                IWebElement LearnMoreRow7 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow7")));
                IWebElement LearnMoreRow8 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow8")));
                IWebElement LearnMoreRow9 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow9")));
                IWebElement LearnMoreRow10 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow10")));
                IWebElement LearnMoreRow11 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow11")));
                IWebElement LearnMoreRow12 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow12")));
                IWebElement LearnMoreRow13 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow13")));
                IWebElement LearnMoreRow14 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow14")));
                IWebElement LearnMoreRow15 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow15")));
                IWebElement LearnMoreRow16 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow16")));
                IWebElement LearnMoreRow17 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow17")));
                IWebElement LearnMoreRow18 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow18")));
                IWebElement LearnMoreRow19 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow19")));
                IWebElement LearnMoreRow20 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow20")));
                IWebElement LearnMoreRow21 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow21")));
                IWebElement LearnMoreRow22 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow22")));
                IWebElement LearnMoreRow23 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow23")));
                IWebElement LearnMoreRow24 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreRow24")));

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
                Assert.True(LearnMoreRow14.Displayed);
                Assert.True(LearnMoreRow15.Displayed);
                Assert.True(LearnMoreRow16.Displayed);
                Assert.True(LearnMoreRow17.Displayed);
                Assert.True(LearnMoreRow18.Displayed);
                Assert.True(LearnMoreRow19.Displayed);
                Assert.True(LearnMoreRow21.Displayed);
                Assert.True(LearnMoreRow22.Displayed);
                Assert.True(LearnMoreRow23.Displayed);
                Assert.True(LearnMoreRow24.Displayed);

                var js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow2);

                LearnMoreRow1.Click();
                
                IWebElement rgwPageLearnMoreModal = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                IWebElement learnMoreModalTitle = driver.FindElement(By.Id("learnMoreModalTitle"));
                IWebElement learnMoreModalHeaderCloseButton = driver.FindElement(By.Id("learnMoreModalHeaderCloseButton"));
                IWebElement rgwPageLearnMoreModalPara = driver.FindElement(By.Id("rgwPageLearnMoreModalPara"));
                IWebElement rgwPageLearnMoreModalFormLabel = driver.FindElement(By.Id("rgwPageLearnMoreModalFormLabel"));
                IWebElement rgwPageModalTextArea = driver.FindElement(By.Id("rgw-Page-Learn-More-Modal-message-text"));
                IWebElement learnMoreModalFooterCloseButton = driver.FindElement(By.Id("learnMoreModalFooterCloseButton"));
                string learnMoreModalTitleReturned = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceReduceMeatIntakeTitleNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(rgwPageLearnMoreModal.Displayed);
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow5);
                LearnMoreRow2.Click();
                
                IWebElement rgwPageLearnMoreModal2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned2 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourcePlantSomeTreesTitleNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned2 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned2 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned2 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned2);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned2);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned2);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned2);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow6);
                LearnMoreRow3.Click();
                
                IWebElement rgwPageLearnMoreModal3 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned3 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceEatOrganicTitleNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned3 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned3 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned3 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned3);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned3);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned3);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned3);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow7);
                LearnMoreRow4.Click();
                
                IWebElement rgwPageLearnMoreModal4 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned4 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceGoVegetarianTitleNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned4 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned4 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned4 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned4);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned4);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned4);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned4);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow8);
                LearnMoreRow5.Click();
                
                IWebElement rgwPageLearnMoreModal5 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned5 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceGoVeganTitleNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned5 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned5 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned5 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned5);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned5);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned5);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned5);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow9);
                LearnMoreRow6.Click();
                
                IWebElement rgwPageLearnMoreModal6 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned6 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceLiveCarFreeTitleNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned6 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned6 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned6 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned6);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned6);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned6);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned6);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow10);
                LearnMoreRow7.Click();
                
                IWebElement rgwPageLearnMoreModal7 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned7 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceGreenRecoveryTitleNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned7 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned7 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned7 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned7);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned7);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned7);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned7);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow11);
                LearnMoreRow8.Click();
                
                IWebElement rgwPageLearnMoreModal8 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned8 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceMinimisePlasticTitleNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned8 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned8 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned8 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned8);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned8);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned8);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned8);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow12);
                LearnMoreRow9.Click();
                
                IWebElement rgwPageLearnMoreModal9 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned9 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceBuyLocalTitleNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned9 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned9 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned9 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned9);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned9);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned9);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned9);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow13);
                LearnMoreRow10.Click();
                
                IWebElement rgwPageLearnMoreModal10 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned10 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceCycleTitleNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned10 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned10 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned10 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned10);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned10);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned10);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned10);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow14);
                LearnMoreRow11.Click();
                
                IWebElement rgwPageLearnMoreModal11 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned11 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceDriveElectricTitleNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned11 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned11 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned11 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned11);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned11);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned11);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned11);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow15);
                LearnMoreRow12.Click();
                
                IWebElement rgwPageLearnMoreModal12 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned12 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourcePlantYourOwnVegTitleNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned12 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned12 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned12 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned12);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned12);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned12);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned12);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow16);
                LearnMoreRow13.Click();
                
                IWebElement rgwPageLearnMoreModal13 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned13 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceSwitchToRenewableTitleNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned13 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned13 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned13 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned13);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned13);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned13);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned13);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow17);
                LearnMoreRow14.Click();
                
                IWebElement rgwPageLearnMoreModal14 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned14 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceUsePublicTransportTitleNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned14 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned14 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned14 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned14);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned14);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned14);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned14);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow18);
                LearnMoreRow15.Click();
                
                IWebElement rgwPageLearnMoreModal15 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned15 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceCarpoolTitleNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned15 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned15 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned15 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned15);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned15);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned15);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned15);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow19);
                LearnMoreRow16.Click();
                
                IWebElement rgwPageLearnMoreModal16 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned16 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceFlyLessOftenTitleNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned16 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned16 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned16 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned16);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned16);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned16);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned16);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow20);
                LearnMoreRow17.Click();
                
                IWebElement rgwPageLearnMoreModal17 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned17 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceStandUpNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned17 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned17 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned17 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned17);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned17);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned17);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned17);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow21);
                LearnMoreRow18.Click();
                
                IWebElement rgwPageLearnMoreModal18 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned18 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceUseABlueRecyclingBinTitleNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned18 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned18 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned18 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned18);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned18);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned18);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned18);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow22);
                LearnMoreRow19.Click();
                
                IWebElement rgwPageLearnMoreModal19 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned19 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceUseABrownCompostBinTitleNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned19 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned19 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned19 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned19);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned19);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned19);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned19);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow23);
                LearnMoreRow20.Click();
                
                IWebElement rgwPageLearnMoreModal20 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned20 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceInsulateYourHouseTitleNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned20 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned20 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned20 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned20);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned20);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned20);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned20);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow24);
                LearnMoreRow21.Click();
                
                IWebElement rgwPageLearnMoreModal21 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned21 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceShorterShowersNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned21 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned21 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned21 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned21);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned21);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned21);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned21);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow24);
                LearnMoreRow22.Click();
                
                IWebElement rgwPageLearnMoreModal22 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned22 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceFluorescentLightbulbsNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned22 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned22 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned22 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned22);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned22);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned22);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned22);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow24);
                LearnMoreRow23.Click();
                
                IWebElement rgwPageLearnMoreModal23 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned23 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceTurnOffLightsNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned23 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned23 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned23 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned23);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned23);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned23);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned23);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow24);
                LearnMoreRow24.Click();
                
                IWebElement rgwPageLearnMoreModal24 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rgwPageLearnMoreModal")));
                string learnMoreModalTitleReturned24 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceSignAPetitionTitleNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalParaReturned24 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceGlobalWarmingPage();
                string rgwPageLearnMoreModalFormLabelReturned24 = ReduceGlobalWarmingPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage();
                string learnMoreModalFooterCloseButtonReturned24 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(rgwPageLearnMoreModalPara.Displayed);
                Assert.True(rgwPageLearnMoreModalFormLabel.Displayed);
                Assert.True(rgwPageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned24);
                Assert.Equal(rgwPageLearnMoreModalPara.Text, rgwPageLearnMoreModalParaReturned24);
                Assert.Equal(rgwPageLearnMoreModalFormLabel.Text, rgwPageLearnMoreModalFormLabelReturned24);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned24);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("rgwPageLearnMoreModal")));
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
            var filename = "TestReduceGlobalWarmingPageComponentsArePresent_CheckFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();

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

                string RGWUrl = UrlRefLibrary.GetReduceGlobalWarmingPageLocalHostUrl();
                driver.Navigate().GoToUrl(RGWUrl);

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
