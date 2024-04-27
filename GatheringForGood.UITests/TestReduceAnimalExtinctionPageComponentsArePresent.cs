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
    public class TestReduceAnimalExtinctionPageComponentsArePresent
    {
        readonly CrossPageSharedUITestStrings UITestStrings = new();

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
            var filename = "TestReduceAnimalExtinctionPageComponentsArePresent_CheckCorrectImpactIconIsDisplayedForEachRow";

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

                string raeUrl = UrlRefLibrary.GetReduceAnimalExtinctionPageLocalHostUrl();
                string rhinoicon1String = CrossPageSharedUITestStrings.rhinoicon1String();
                string rhinoicon2String = CrossPageSharedUITestStrings.rhinoicon2String();
                string rhinoicon3String = CrossPageSharedUITestStrings.rhinoicon3String();
                string rhinoicon4String = CrossPageSharedUITestStrings.rhinoicon4String();
                string rhinoicon5String = CrossPageSharedUITestStrings.rhinoicon5String();
                driver.Navigate().GoToUrl(raeUrl);

                IWebElement ImpactIconRow1 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raeImpactIconRow1")));
                String ImpactIconRow1SRC = ImpactIconRow1.GetAttribute("src");
                String ImpactIconRow1SRCParsed = ImpactIconRow1SRC.Substring(ImpactIconRow1SRC.LastIndexOf('/') + 1);
                System.Diagnostics.Debug.WriteLine("**************** Src attribute is: " + ImpactIconRow1SRCParsed);
                IWebElement ImpactIconRow2 = driver.FindElement(By.Id("raeImpactIconRow2"));
                String ImpactIconRow2SRC = ImpactIconRow2.GetAttribute("src");
                String ImpactIconRow2SRCParsed = ImpactIconRow1SRC.Substring(ImpactIconRow2SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow3 = driver.FindElement(By.Id("raeImpactIconRow3"));
                String ImpactIconRow3SRC = ImpactIconRow3.GetAttribute("src");
                String ImpactIconRow3SRCParsed = ImpactIconRow3SRC.Substring(ImpactIconRow3SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow4 = driver.FindElement(By.Id("raeImpactIconRow4"));
                String ImpactIconRow4SRC = ImpactIconRow4.GetAttribute("src");
                String ImpactIconRow4SRCParsed = ImpactIconRow4SRC.Substring(ImpactIconRow4SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow5 = driver.FindElement(By.Id("raeImpactIconRow5"));
                String ImpactIconRow5SRC = ImpactIconRow5.GetAttribute("src");
                String ImpactIconRow5SRCParsed = ImpactIconRow5SRC.Substring(ImpactIconRow5SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow6 = driver.FindElement(By.Id("raeImpactIconRow6"));
                String ImpactIconRow6SRC = ImpactIconRow6.GetAttribute("src");
                String ImpactIconRow6SRCParsed = ImpactIconRow6SRC.Substring(ImpactIconRow6SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow7 = driver.FindElement(By.Id("raeImpactIconRow7"));
                String ImpactIconRow7SRC = ImpactIconRow7.GetAttribute("src");
                String ImpactIconRow7SRCParsed = ImpactIconRow7SRC.Substring(ImpactIconRow7SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow8 = driver.FindElement(By.Id("raeImpactIconRow8"));
                String ImpactIconRow8SRC = ImpactIconRow8.GetAttribute("src");
                String ImpactIconRow8SRCParsed = ImpactIconRow8SRC.Substring(ImpactIconRow8SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow9 = driver.FindElement(By.Id("raeImpactIconRow9"));
                String ImpactIconRow9SRC = ImpactIconRow9.GetAttribute("src");
                String ImpactIconRow9SRCParsed = ImpactIconRow9SRC.Substring(ImpactIconRow9SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow10 = driver.FindElement(By.Id("raeImpactIconRow10"));
                String ImpactIconRow10SRC = ImpactIconRow10.GetAttribute("src");
                String ImpactIconRow10SRCParsed = ImpactIconRow10SRC.Substring(ImpactIconRow10SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow11 = driver.FindElement(By.Id("raeImpactIconRow11"));
                String ImpactIconRow11SRC = ImpactIconRow11.GetAttribute("src");
                String ImpactIconRow11SRCParsed = ImpactIconRow11SRC.Substring(ImpactIconRow11SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow12 = driver.FindElement(By.Id("raeImpactIconRow12"));
                String ImpactIconRow12SRC = ImpactIconRow12.GetAttribute("src");
                String ImpactIconRow12SRCParsed = ImpactIconRow12SRC.Substring(ImpactIconRow12SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow13 = driver.FindElement(By.Id("raeImpactIconRow13"));
                String ImpactIconRow13SRC = ImpactIconRow13.GetAttribute("src");
                String ImpactIconRow13SRCParsed = ImpactIconRow13SRC.Substring(ImpactIconRow13SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow14 = driver.FindElement(By.Id("raeImpactIconRow14"));
                String ImpactIconRow14SRC = ImpactIconRow14.GetAttribute("src");
                String ImpactIconRow14SRCParsed = ImpactIconRow14SRC.Substring(ImpactIconRow14SRC.LastIndexOf('/') + 1);
                IWebElement ImpactIconRow15 = driver.FindElement(By.Id("raeImpactIconRow15"));
                String ImpactIconRow15SRC = ImpactIconRow15.GetAttribute("src");
                String ImpactIconRow15SRCParsed = ImpactIconRow15SRC.Substring(ImpactIconRow15SRC.LastIndexOf('/') + 1);

                Assert.Equal(ImpactIconRow1SRCParsed, rhinoicon5String);
                Assert.Equal(ImpactIconRow2SRCParsed, rhinoicon5String);
                Assert.Equal(ImpactIconRow3SRCParsed, rhinoicon5String);
                Assert.Equal(ImpactIconRow4SRCParsed, rhinoicon5String);
                Assert.Equal(ImpactIconRow5SRCParsed, rhinoicon5String);
                Assert.Equal(ImpactIconRow6SRCParsed, rhinoicon4String);
                Assert.Equal(ImpactIconRow7SRCParsed, rhinoicon3String);
                Assert.Equal(ImpactIconRow8SRCParsed, rhinoicon3String);
                Assert.Equal(ImpactIconRow9SRCParsed, rhinoicon3String);
                Assert.Equal(ImpactIconRow10SRCParsed, rhinoicon2String);
                Assert.Equal(ImpactIconRow11SRCParsed, rhinoicon2String);
                Assert.Equal(ImpactIconRow12SRCParsed, rhinoicon2String);
                Assert.Equal(ImpactIconRow13SRCParsed, rhinoicon2String);
                Assert.Equal(ImpactIconRow14SRCParsed, rhinoicon2String);
                Assert.Equal(ImpactIconRow15SRCParsed, rhinoicon1String);
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
            var filename = "TestReduceAnimalExtinctionPageComponentsArePresent_CheckImagesAreDisplayed";

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

                string raeUrl = UrlRefLibrary.GetReduceAnimalExtinctionPageLocalHostUrl();
                driver.Navigate().GoToUrl(raeUrl);
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ReduceAnimalExtinctionPageBanner")));
                IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));
                IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_raePageLogoImg"));
                IWebElement RAEPageAllUserActionsIconImage = driver.FindElement(By.Id("RAEPageAllUserActionsIconImage"));
                IWebElement RAEPageRAEUserActionsIconImage = driver.FindElement(By.Id("RAEPageRAEUserActionsIconImage"));
                IWebElement RAEPageMyTotalActionsIconImage = driver.FindElement(By.Id("RAEPageMyTotalActionsIconImage"));
                IWebElement RAEPageMyCO2ImpactIconImage = driver.FindElement(By.Id("RAEPageMyCO2ImpactIconImage"));
                IWebElement raeImpactIconRow1 = driver.FindElement(By.Id("raeImpactIconRow1"));
                IWebElement raeImpactIconRow2 = driver.FindElement(By.Id("raeImpactIconRow2"));
                IWebElement raeImpactIconRow3 = driver.FindElement(By.Id("raeImpactIconRow3"));
                IWebElement raeImpactIconRow4 = driver.FindElement(By.Id("raeImpactIconRow4"));
                IWebElement raeImpactIconRow5 = driver.FindElement(By.Id("raeImpactIconRow5"));
                IWebElement raeImpactIconRow6 = driver.FindElement(By.Id("raeImpactIconRow6"));
                IWebElement raeImpactIconRow7 = driver.FindElement(By.Id("raeImpactIconRow7"));
                IWebElement raeImpactIconRow8 = driver.FindElement(By.Id("raeImpactIconRow8"));
                IWebElement raeImpactIconRow9 = driver.FindElement(By.Id("raeImpactIconRow9"));
                IWebElement raeImpactIconRow10 = driver.FindElement(By.Id("raeImpactIconRow10"));
                IWebElement raeImpactIconRow11 = driver.FindElement(By.Id("raeImpactIconRow11"));
                IWebElement raeImpactIconRow12 = driver.FindElement(By.Id("raeImpactIconRow12"));
                IWebElement raeImpactIconRow13 = driver.FindElement(By.Id("raeImpactIconRow13"));
                IWebElement raeImpactIconRow14 = driver.FindElement(By.Id("raeImpactIconRow14"));
                IWebElement raeImpactIconRow15 = driver.FindElement(By.Id("raeImpactIconRow15"));
                IWebElement raeMouseClickIconRow1 = driver.FindElement(By.Id("raeMouseClickIconRow1"));
                IWebElement raeMouseClickIconRow2 = driver.FindElement(By.Id("raeMouseClickIconRow2"));
                IWebElement raeMouseClickIconRow3 = driver.FindElement(By.Id("raeMouseClickIconRow3"));
                IWebElement raeMouseClickIconRow4 = driver.FindElement(By.Id("raeMouseClickIconRow4"));
                IWebElement raeMouseClickIconRow5 = driver.FindElement(By.Id("raeMouseClickIconRow5"));
                IWebElement raeMouseClickIconRow6 = driver.FindElement(By.Id("raeMouseClickIconRow6"));
                IWebElement raeMouseClickIconRow7 = driver.FindElement(By.Id("raeMouseClickIconRow7"));
                IWebElement raeMouseClickIconRow8 = driver.FindElement(By.Id("raeMouseClickIconRow8"));
                IWebElement raeMouseClickIconRow9 = driver.FindElement(By.Id("raeMouseClickIconRow9"));
                IWebElement raeMouseClickIconRow10 = driver.FindElement(By.Id("raeMouseClickIconRow10"));
                IWebElement raeMouseClickIconRow11 = driver.FindElement(By.Id("raeMouseClickIconRow11"));
                IWebElement raeMouseClickIconRow12 = driver.FindElement(By.Id("raeMouseClickIconRow12"));
                IWebElement raeMouseClickIconRow13 = driver.FindElement(By.Id("raeMouseClickIconRow13"));
                IWebElement raeMouseClickIconRow14 = driver.FindElement(By.Id("raeMouseClickIconRow14"));
                IWebElement raeMouseClickIconRow15 = driver.FindElement(By.Id("raeMouseClickIconRow15"));
                IWebElement raeHandTapIconRow1 = driver.FindElement(By.Id("raeHandTapIconRow1"));
                IWebElement raeHandTapIconRow2 = driver.FindElement(By.Id("raeHandTapIconRow2"));
                IWebElement raeHandTapIconRow3 = driver.FindElement(By.Id("raeHandTapIconRow3"));
                IWebElement raeHandTapIconRow4 = driver.FindElement(By.Id("raeHandTapIconRow4"));
                IWebElement raeHandTapIconRow5 = driver.FindElement(By.Id("raeHandTapIconRow5"));
                IWebElement raeHandTapIconRow6 = driver.FindElement(By.Id("raeHandTapIconRow6"));
                IWebElement raeHandTapIconRow7 = driver.FindElement(By.Id("raeHandTapIconRow7"));
                IWebElement raeHandTapIconRow8 = driver.FindElement(By.Id("raeHandTapIconRow8"));
                IWebElement raeHandTapIconRow9 = driver.FindElement(By.Id("raeHandTapIconRow9"));
                IWebElement raeHandTapIconRow10 = driver.FindElement(By.Id("raeHandTapIconRow10"));
                IWebElement raeHandTapIconRow11 = driver.FindElement(By.Id("raeHandTapIconRow11"));
                IWebElement raeHandTapIconRow12 = driver.FindElement(By.Id("raeHandTapIconRow12"));
                IWebElement raeHandTapIconRow13 = driver.FindElement(By.Id("raeHandTapIconRow13"));
                IWebElement raeHandTapIconRow14 = driver.FindElement(By.Id("raeHandTapIconRow14"));
                IWebElement raeHandTapIconRow15 = driver.FindElement(By.Id("raeHandTapIconRow15"));
                IWebElement RAEPageTwitterShareIconImage1 = driver.FindElement(By.Id("RAEPageTwitterShareIconImage1"));
                IWebElement RAEPageFBShareIconImage1 = driver.FindElement(By.Id("RAEPageFBShareIconImage2"));
                IWebElement RAEPageLinkedinShareIconImage1 = driver.FindElement(By.Id("RAEPageLinkedinShareIconImage2"));
                IWebElement RAEPageTwitterShareIconImage2 = driver.FindElement(By.Id("RAEPageTwitterShareIconImage2"));
                IWebElement RAEPageFBShareIconImage2 = driver.FindElement(By.Id("RAEPageFBShareIconImage3"));
                IWebElement RAEPageLinkedinShareIconImage2 = driver.FindElement(By.Id("RAEPageLinkedinShareIconImage3"));
                IWebElement RAEPageTwitterShareIconImage3 = driver.FindElement(By.Id("RAEPageTwitterShareIconImage3"));
                IWebElement RAEPageFBShareIconImage3 = driver.FindElement(By.Id("RAEPageFBShareIconImage4"));
                IWebElement RAEPageLinkedinShareIconImage3 = driver.FindElement(By.Id("RAEPageLinkedinShareIconImage4"));
                IWebElement RAEPageTwitterShareIconImage4 = driver.FindElement(By.Id("RAEPageTwitterShareIconImage4"));
                IWebElement RAEPageFBShareIconImage4 = driver.FindElement(By.Id("RAEPageFBShareIconImage5"));
                IWebElement RAEPageLinkedinShareIconImage4 = driver.FindElement(By.Id("RAEPageLinkedinShareIconImage5"));

                Assert.True(BannerImageElement.Displayed);
                Assert.True(_LayoutPageLogoElement.Displayed);
                Assert.True(BodyBackground.Displayed);
                Assert.True(RAEPageAllUserActionsIconImage.Displayed);
                Assert.True(RAEPageRAEUserActionsIconImage.Displayed);
                Assert.True(RAEPageMyTotalActionsIconImage.Displayed);
                Assert.True(RAEPageMyCO2ImpactIconImage.Displayed);
                Assert.True(raeImpactIconRow1.Displayed);
                Assert.True(raeImpactIconRow2.Displayed);
                Assert.True(raeImpactIconRow3.Displayed);
                Assert.True(raeImpactIconRow4.Displayed);
                Assert.True(raeImpactIconRow5.Displayed);
                Assert.True(raeImpactIconRow6.Displayed);
                Assert.True(raeImpactIconRow7.Displayed);
                Assert.True(raeImpactIconRow8.Displayed);
                Assert.True(raeImpactIconRow9.Displayed);
                Assert.True(raeImpactIconRow10.Displayed);
                Assert.True(raeImpactIconRow11.Displayed);
                Assert.True(raeImpactIconRow12.Displayed);
                Assert.True(raeImpactIconRow13.Displayed);
                Assert.True(raeImpactIconRow14.Displayed);
                Assert.True(raeImpactIconRow15.Displayed);
                Assert.True(raeMouseClickIconRow1.Displayed);
                Assert.True(raeMouseClickIconRow2.Displayed);
                Assert.True(raeMouseClickIconRow3.Displayed);
                Assert.True(raeMouseClickIconRow4.Displayed);
                Assert.True(raeMouseClickIconRow5.Displayed);
                Assert.True(raeMouseClickIconRow6.Displayed);
                Assert.True(raeMouseClickIconRow7.Displayed);
                Assert.True(raeMouseClickIconRow8.Displayed);
                Assert.True(raeMouseClickIconRow9.Displayed);
                Assert.True(raeMouseClickIconRow10.Displayed);
                Assert.True(raeMouseClickIconRow11.Displayed);
                Assert.True(raeMouseClickIconRow12.Displayed);
                Assert.True(raeMouseClickIconRow13.Displayed);
                Assert.True(raeMouseClickIconRow14.Displayed);
                Assert.True(raeMouseClickIconRow15.Displayed);
                Assert.False(raeHandTapIconRow1.Displayed);
                Assert.False(raeHandTapIconRow2.Displayed);
                Assert.False(raeHandTapIconRow3.Displayed);
                Assert.False(raeHandTapIconRow4.Displayed);
                Assert.False(raeHandTapIconRow5.Displayed);
                Assert.False(raeHandTapIconRow6.Displayed);
                Assert.False(raeHandTapIconRow7.Displayed);
                Assert.False(raeHandTapIconRow8.Displayed);
                Assert.False(raeHandTapIconRow9.Displayed);
                Assert.False(raeHandTapIconRow10.Displayed);
                Assert.False(raeHandTapIconRow11.Displayed);
                Assert.False(raeHandTapIconRow12.Displayed);
                Assert.False(raeHandTapIconRow13.Displayed);
                Assert.False(raeHandTapIconRow14.Displayed);
                Assert.False(raeHandTapIconRow15.Displayed);
                Assert.True(RAEPageTwitterShareIconImage1.Displayed);
                Assert.True(RAEPageFBShareIconImage1.Displayed);
                Assert.True(RAEPageLinkedinShareIconImage1.Displayed);
                Assert.True(RAEPageTwitterShareIconImage2.Displayed);
                Assert.True(RAEPageFBShareIconImage2.Displayed);
                Assert.True(RAEPageLinkedinShareIconImage2.Displayed);
                Assert.True(RAEPageTwitterShareIconImage3.Displayed);
                Assert.True(RAEPageFBShareIconImage3.Displayed);
                Assert.True(RAEPageLinkedinShareIconImage3.Displayed);
                Assert.True(RAEPageTwitterShareIconImage4.Displayed);
                Assert.True(RAEPageFBShareIconImage4.Displayed);
                Assert.True(RAEPageLinkedinShareIconImage4.Displayed);

                driver.Manage().Window.Size = new Size(240, 600);
                var js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", raeHandTapIconRow1);
                IWebElement raeHandTapIconRow1b = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raeHandTapIconRow1")));
                Assert.True(RAEPageAllUserActionsIconImage.Displayed);
                Assert.True(RAEPageRAEUserActionsIconImage.Displayed);
                Assert.True(RAEPageMyTotalActionsIconImage.Displayed);
                Assert.True(RAEPageMyCO2ImpactIconImage.Displayed);
                Assert.True(raeHandTapIconRow1b.Displayed);
                Assert.True(raeHandTapIconRow2.Displayed);
                Assert.True(raeHandTapIconRow3.Displayed);
                Assert.True(raeHandTapIconRow4.Displayed);
                Assert.True(raeHandTapIconRow5.Displayed);
                Assert.True(raeHandTapIconRow6.Displayed);
                Assert.True(raeHandTapIconRow7.Displayed);
                Assert.True(raeHandTapIconRow8.Displayed);
                Assert.True(raeHandTapIconRow9.Displayed);
                Assert.True(raeHandTapIconRow10.Displayed);
                Assert.True(raeHandTapIconRow11.Displayed);
                Assert.True(raeHandTapIconRow12.Displayed);
                Assert.True(raeHandTapIconRow13.Displayed);
                Assert.True(raeHandTapIconRow14.Displayed);
                Assert.True(raeHandTapIconRow15.Displayed);
                Assert.False(raeMouseClickIconRow1.Displayed);
                Assert.False(raeMouseClickIconRow2.Displayed);
                Assert.False(raeMouseClickIconRow3.Displayed);
                Assert.False(raeMouseClickIconRow4.Displayed);
                Assert.False(raeMouseClickIconRow5.Displayed);
                Assert.False(raeMouseClickIconRow6.Displayed);
                Assert.False(raeMouseClickIconRow7.Displayed);
                Assert.False(raeMouseClickIconRow8.Displayed);
                Assert.False(raeMouseClickIconRow9.Displayed);
                Assert.False(raeMouseClickIconRow10.Displayed);
                Assert.False(raeMouseClickIconRow11.Displayed);
                Assert.False(raeMouseClickIconRow12.Displayed);
                Assert.False(raeMouseClickIconRow13.Displayed);
                Assert.False(raeMouseClickIconRow14.Displayed);
                Assert.False(raeMouseClickIconRow15.Displayed);
                Assert.True(RAEPageTwitterShareIconImage1.Displayed);
                Assert.True(RAEPageFBShareIconImage1.Displayed);
                Assert.True(RAEPageLinkedinShareIconImage1.Displayed);
                Assert.True(RAEPageTwitterShareIconImage2.Displayed);
                Assert.True(RAEPageFBShareIconImage2.Displayed);
                Assert.True(RAEPageLinkedinShareIconImage2.Displayed);
                Assert.True(RAEPageTwitterShareIconImage3.Displayed);
                Assert.True(RAEPageFBShareIconImage3.Displayed);
                Assert.True(RAEPageLinkedinShareIconImage3.Displayed);
                Assert.True(RAEPageTwitterShareIconImage4.Displayed);
                Assert.True(RAEPageFBShareIconImage4.Displayed);
                Assert.True(RAEPageLinkedinShareIconImage4.Displayed);

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
            var filename = "TestReduceAnimalExtinctionPageComponentsArePresent_CheckNavBarIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();

                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                driver.Navigate().GoToUrl(LoginUrl);
                IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(180)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
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
                IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(180)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                string raeUrl = UrlRefLibrary.GetReduceAnimalExtinctionPageLocalHostUrl();
                driver.Navigate().GoToUrl(raeUrl);
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(180)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-rae-page")));
                IWebElement NavBarHomeLinkElement = driver.FindElement(By.Id("_raePageHomeNavLink"));
                IWebElement NavBarArticlesLinkElement = driver.FindElement(By.Id("_raePageArticlesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_raePageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_raePageHelpNavLink"));
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
            var filename = "TestReduceAnimalExtinctionPageComponentsArePresent_CheckButtonsAreDisplayedAndFunction";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

                driver.Navigate().GoToUrl(HomeUrl);
                driver.Manage().Window.Maximize();

                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                driver.Navigate().GoToUrl(LoginUrl);
                IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(180)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
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
                IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(180)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                string raeUrl = UrlRefLibrary.GetReduceAnimalExtinctionPageLocalHostUrl();
                driver.Navigate().GoToUrl(raeUrl);
                IWebElement RAEPageRAEIconImage = new WebDriverWait(driver, TimeSpan.FromSeconds(180)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("RAEPageRAEIconImage")));
                IWebElement RAEPageRGWIconImage = driver.FindElement(By.Id("RAEPageRGWIconImage"));
                IWebElement RAEPageRDFIconImage = driver.FindElement(By.Id("RAEPageRDFIconImage"));

                Assert.True(RAEPageRAEIconImage.Displayed);
                Assert.True(RAEPageRGWIconImage.Displayed);
                Assert.True(RAEPageRDFIconImage.Displayed);

                RAEPageRAEIconImage.Click();
                IWebElement SubTitleElement = driver.FindElement(By.Id("raePageSubtitle"));
                Assert.True(SubTitleElement.Displayed);

                RAEPageRGWIconImage.Click();
                IWebElement ReduceGlobalWarmingPageSubtitle = new WebDriverWait(driver, TimeSpan.FromSeconds(180)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ReduceGlobalWarmingPageSubtitle")));
                Assert.True(ReduceGlobalWarmingPageSubtitle.Displayed);

                driver.Navigate().GoToUrl(raeUrl);
                IWebElement RAEPageRDFIconImage1 = driver.FindElement(By.Id("RAEPageRDFIconImage"));
                RAEPageRDFIconImage1.Click();
                IWebElement rdfPageSubtitle = new WebDriverWait(driver, TimeSpan.FromSeconds(180)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("rdfPageSubtitle")));
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
            var filename = "TestReduceAnimalExtinctionPageComponentsArePresent_CheckTextSectionsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string HomeUrl = UrlRefLibrary.GetHomePageLocalHostUrl();

                driver1.Navigate().GoToUrl(HomeUrl);
                driver1.Manage().Window.Maximize();

                string LoginUrl = UrlRefLibrary.GetLoginPageLocalHostUrl();
                driver1.Navigate().GoToUrl(LoginUrl);
                IWebElement LoginEmailInputField = new WebDriverWait(driver1, TimeSpan.FromSeconds(180)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
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
                IWebElement LoggedInUserLabel = new WebDriverWait(driver1, TimeSpan.FromSeconds(180)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
                Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);

                string raeUrl = UrlRefLibrary.GetReduceAnimalExtinctionPageLocalHostUrl();
                driver1.Navigate().GoToUrl(raeUrl);
                driver1.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver1, TimeSpan.FromSeconds(180)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar-rae-page")));
                IWebElement TitleElement = driver1.FindElement(By.Id("raePageTitle"));
                IWebElement SubTitleElement = driver1.FindElement(By.Id("raePageSubtitle"));
                IWebElement raeDoSomethingTodayTitle = driver1.FindElement(By.Id("raeDoSomethingTodayTitle"));
                IWebElement raeDoSomethingTodayPara = driver1.FindElement(By.Id("raeDoSomethingTodayPara"));
                IWebElement RAEPageAllUserActionsIconText = driver1.FindElement(By.Id("RAEPageAllUserActionsIconText"));
                IWebElement RAEPageAllUserActionsTotalText = driver1.FindElement(By.Id("RAEPageAllUserActionsTotalText"));
                IWebElement RAEPageRAEUserActionsIconText = driver1.FindElement(By.Id("RAEPageRAEUserActionsIconText"));
                IWebElement RAEPageRAEUserActionsTotalText = driver1.FindElement(By.Id("RAEPageRAEUserActionsTotalText"));
                IWebElement RAEPageMyTotalActionsIconText = driver1.FindElement(By.Id("RAEPageMyTotalActionsIconText"));
                IWebElement RAEPageMyTotalActionsTotalText = driver1.FindElement(By.Id("RAEPageMyTotalActionsTotalText"));
                IWebElement RAEPageMyCO2ImpactIconText = driver1.FindElement(By.Id("RAEPageMyCO2ImpactIconText"));
                IWebElement RAEPageMyCO2ImpactTotalText = driver1.FindElement(By.Id("RAEPageMyCO2ImpactTotalText"));
                IWebElement raeWhatCanIDoTitle = driver1.FindElement(By.Id("raeWhatCanIDoTitle"));
                IWebElement raeInformationTitle = driver1.FindElement(By.Id("raeInformationTitle"));
                IWebElement raeImpactTitle = driver1.FindElement(By.Id("raeImpactTitle"));
                IWebElement raeIDidThisTodayTitle = driver1.FindElement(By.Id("raeIDidThisTodayTitle"));
                IWebElement raeMyImpactTitle = driver1.FindElement(By.Id("raeMyImpactTitle"));
                IWebElement raeReduceMeatIntakeTitle = driver1.FindElement(By.Id("raeReduceMeatIntakeTitle"));
                IWebElement raeReduceMeatIntakeTitleMobile = driver1.FindElement(By.Id("raeReduceMeatIntakeTitleMobile"));
                IWebElement raeReduceMeatIntakePara = driver1.FindElement(By.Id("raeReduceMeatIntakePara"));
                IWebElement ReducedFamilySizesTitle = driver1.FindElement(By.Id("raeReducedFamilySizesTitle"));
                IWebElement ReducedFamilySizesTitleMobile = driver1.FindElement(By.Id("raeReducedFamilySizesTitleMobile"));
                IWebElement ReducedFamilySizesPara = driver1.FindElement(By.Id("ReducedFamilySizesPara"));
                IWebElement raeMinimisePlasticTitle = driver1.FindElement(By.Id("raeMinimisePlasticTitle"));
                IWebElement raeMinimisePlasticTitleMobile = driver1.FindElement(By.Id("raeMinimisePlasticTitleMobile"));
                IWebElement raeMinimisePlasticPara1 = driver1.FindElement(By.Id("raeMinimisePlasticPara1"));
                IWebElement raeGoVegetarianTitle = driver1.FindElement(By.Id("raeGoVegetarianTitle"));
                IWebElement raeGoVegetarianTitleMobile = driver1.FindElement(By.Id("raeGoVegetarianTitleMobile"));
                IWebElement raeGoVegetarianPara1 = driver1.FindElement(By.Id("raeGoVegetarianPara1"));
                IWebElement raeGoVeganTitle = driver1.FindElement(By.Id("raeGoVeganTitle"));
                IWebElement raeGoVeganTitleMobile = driver1.FindElement(By.Id("raeGoVeganTitleMobile"));
                IWebElement raeGoVeganPara1 = driver1.FindElement(By.Id("raeGoVeganPara1"));
                IWebElement SupportHabitatRestorationTitle = driver1.FindElement(By.Id("raeSupportHabitatRestorationTitle"));
                IWebElement SupportHabitatRestorationTitleMobile = driver1.FindElement(By.Id("raeSupportHabitatRestorationTitleMobile"));
                IWebElement SupportHabitatRestorationPara1 = driver1.FindElement(By.Id("SupportHabitatRestorationPara1"));
                IWebElement WildlifeRefugeTitle = driver1.FindElement(By.Id("raeWildlifeRefugeTitle"));
                IWebElement WildlifeRefugeTitleMobile = driver1.FindElement(By.Id("raeWildlifeRefugeTitleMobile"));
                IWebElement WildlifeRefugePara = driver1.FindElement(By.Id("WildlifeRefugePara"));
                IWebElement raeStandUp = driver1.FindElement(By.Id("raeStandUp"));
                IWebElement raeStandUpMobile = driver1.FindElement(By.Id("raeStandUpMobile"));
                IWebElement raeStandUpPara1 = driver1.FindElement(By.Id("raeStandUpPara1"));
                IWebElement HerbsAndPesticidesTitle = driver1.FindElement(By.Id("raeHerbsAndPesticidesTitle"));
                IWebElement HerbsAndPesticidesTitleMobile = driver1.FindElement(By.Id("raeHerbsAndPesticidesTitleMobile"));
                IWebElement HerbsAndPesticidesPara1 = driver1.FindElement(By.Id("HerbsAndPesticidesPara1"));
                IWebElement SlowDownTitle = driver1.FindElement(By.Id("raeSlowDownTitle"));
                IWebElement SlowDownTitleMobile = driver1.FindElement(By.Id("raeSlowDownTitleMobile"));
                IWebElement SlowDownPara1 = driver1.FindElement(By.Id("SlowDownPara1"));
                IWebElement PlantNativePlantsTitle = driver1.FindElement(By.Id("raePlantNativePlantsTitle"));
                IWebElement PlantNativePlantsTitleMobile = driver1.FindElement(By.Id("raePlantNativePlantsTitleMobile"));
                IWebElement PlantNativePlants = driver1.FindElement(By.Id("PlantNativePlants"));
                IWebElement raeGreenRecoveryTitle = driver1.FindElement(By.Id("raeGreenRecoveryTitle"));
                IWebElement raeGreenRecoveryTitleMobile = driver1.FindElement(By.Id("raeGreenRecoveryTitleMobile"));
                IWebElement raeGreenRecoveryPara1 = driver1.FindElement(By.Id("raeGreenRecoveryPara1"));
                IWebElement raeBuyRecycledTitle = driver1.FindElement(By.Id("raeBuyRecycledTitle"));
                IWebElement raeBuyRecycledTitleMobile = driver1.FindElement(By.Id("raeBuyRecycledTitleMobile"));
                IWebElement raeBuyRecycledPara1 = driver1.FindElement(By.Id("raeBuyRecycledPara1"));
                IWebElement raeUseABlueRecyclingBinTitle = driver1.FindElement(By.Id("raeUseABlueRecyclingBinTitle"));
                IWebElement raeUseABlueRecyclingBinTitleMobile = driver1.FindElement(By.Id("raeUseABlueRecyclingBinTitleMobile"));
                IWebElement raeUseABlueRecyclingBinPara1 = driver1.FindElement(By.Id("raeUseABlueRecyclingBinPara1"));
                IWebElement raeSignAPetitionTitle = driver1.FindElement(By.Id("raeSignAPetitionTitle"));
                IWebElement raeSignAPetitionTitleMobile = driver1.FindElement(By.Id("raeSignAPetitionTitleMobile"));
                IWebElement raeSignAPetitionPara1 = driver1.FindElement(By.Id("raeSignAPetitionPara1"));
                IWebElement raeMyImpactReduceMeat = driver1.FindElement(By.Id("raeMyImpactReduceMeat"));
                IWebElement raeMyImpactFamilySizes = driver1.FindElement(By.Id("raeMyImpactFamilySizes"));
                IWebElement raeMyImpactMinimisePlastic = driver1.FindElement(By.Id("raeMyImpactMinimisePlastic"));
                IWebElement raeMyImpactGoVegetarian = driver1.FindElement(By.Id("raeMyImpactGoVegetarian"));
                IWebElement raeMyImpactGoVegan = driver1.FindElement(By.Id("raeMyImpactGoVegan"));
                IWebElement raeMyImpactHabitatRestoration = driver1.FindElement(By.Id("raeMyImpactHabitatRestoration"));
                IWebElement raeMyImpactWildlifeRefuge = driver1.FindElement(By.Id("raeMyImpactWildlifeRefuge"));
                IWebElement raeMyImpactStandUp = driver1.FindElement(By.Id("raeMyImpactStandUp"));
                IWebElement raeMyImpactHerbsAndPesticides = driver1.FindElement(By.Id("raeMyImpactHerbsAndPesticides"));
                IWebElement raeMyImpactSlowDown = driver1.FindElement(By.Id("raeMyImpactSlowDown"));
                IWebElement raeMyImpactPlantNativePlants = driver1.FindElement(By.Id("raeMyImpactPlantNativePlants"));
                IWebElement raeMyImpactGreenRecovery = driver1.FindElement(By.Id("raeMyImpactGreenRecovery"));
                IWebElement raeMyImpactBuyRecycled = driver1.FindElement(By.Id("raeMyImpactBuyRecycled"));
                IWebElement raeMyImpactRecyclingBin = driver1.FindElement(By.Id("raeMyImpactRecyclingBin"));
                IWebElement raeMyImpactSignPetition = driver1.FindElement(By.Id("raeMyImpactSignPetition"));

                IWebElement raeReduceMeatIntakeParaB = driver1.FindElement(By.Id("raeReduceMeatIntakeParaB"));
                IWebElement ReducedFamilySizesParaB = driver1.FindElement(By.Id("ReducedFamilySizesParaB"));
                IWebElement raeMinimisePlasticPara1B = driver1.FindElement(By.Id("raeMinimisePlasticPara1B"));
                IWebElement raeGoVegetarianPara1B = driver1.FindElement(By.Id("raeGoVegetarianPara1B"));
                IWebElement raeGoVeganPara1B = driver1.FindElement(By.Id("raeGoVeganPara1B"));
                IWebElement SupportHabitatRestorationPara1B = driver1.FindElement(By.Id("SupportHabitatRestorationPara1B"));
                IWebElement WildlifeRefugePara1B = driver1.FindElement(By.Id("WildlifeRefugePara1B"));
                IWebElement raeStandUpPara1B = driver1.FindElement(By.Id("raeStandUpPara1B"));
                IWebElement HerbsAndPesticidesPara1B = driver1.FindElement(By.Id("HerbsAndPesticidesPara1B"));
                IWebElement SlowDownPara1B = driver1.FindElement(By.Id("SlowDownPara1B"));
                IWebElement PlantNativePlantsB = driver1.FindElement(By.Id("PlantNativePlantsB"));
                IWebElement raeGreenRecoveryPara1B = driver1.FindElement(By.Id("raeGreenRecoveryPara1B"));
                IWebElement raeBuyRecycledPara1B = driver1.FindElement(By.Id("raeBuyRecycledPara1B"));
                IWebElement raeUseABlueRecyclingBinPara1B = driver1.FindElement(By.Id("raeUseABlueRecyclingBinPara1B"));
                IWebElement raeSignAPetitionPara1B = driver1.FindElement(By.Id("raeSignAPetitionPara1B"));

                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(raeDoSomethingTodayTitle.Displayed);
                Assert.True(raeDoSomethingTodayPara.Displayed);
                Assert.True(RAEPageAllUserActionsIconText.Displayed);
                Assert.True(RAEPageAllUserActionsTotalText.Displayed);
                Assert.True(RAEPageRAEUserActionsIconText.Displayed);
                Assert.True(RAEPageRAEUserActionsTotalText.Displayed);
                Assert.True(RAEPageMyTotalActionsIconText.Displayed);
                Assert.True(RAEPageMyTotalActionsTotalText.Displayed);
                Assert.True(RAEPageMyCO2ImpactIconText.Displayed);
                Assert.True(RAEPageMyCO2ImpactTotalText.Displayed);
                Assert.True(raeWhatCanIDoTitle.Displayed);
                Assert.True(raeInformationTitle.Displayed);
                Assert.True(raeImpactTitle.Displayed);
                Assert.True(raeIDidThisTodayTitle.Displayed);
                Assert.True(raeMyImpactTitle.Displayed);
                Assert.True(raeReduceMeatIntakeTitle.Displayed);
                Assert.False(raeReduceMeatIntakeTitleMobile.Displayed);
                Assert.True(raeReduceMeatIntakePara.Displayed);
                Assert.True(ReducedFamilySizesTitle.Displayed);
                Assert.False(ReducedFamilySizesTitleMobile.Displayed);
                Assert.True(ReducedFamilySizesPara.Displayed);
                Assert.True(raeMinimisePlasticTitle.Displayed);
                Assert.False(raeMinimisePlasticTitleMobile.Displayed);
                Assert.True(raeMinimisePlasticPara1.Displayed);
                Assert.True(raeGoVegetarianTitle.Displayed);
                Assert.False(raeGoVegetarianTitleMobile.Displayed);
                Assert.True(raeGoVegetarianPara1.Displayed);
                Assert.True(raeGoVeganTitle.Displayed);
                Assert.False(raeGoVeganTitleMobile.Displayed);
                Assert.True(raeGoVeganPara1.Displayed);
                Assert.True(SupportHabitatRestorationTitle.Displayed);
                Assert.False(SupportHabitatRestorationTitleMobile.Displayed);
                Assert.True(SupportHabitatRestorationPara1.Displayed);
                Assert.True(WildlifeRefugeTitle.Displayed);
                Assert.False(WildlifeRefugeTitleMobile.Displayed);
                Assert.True(WildlifeRefugePara.Displayed);
                Assert.True(raeStandUp.Displayed);
                Assert.False(raeStandUpMobile.Displayed);
                Assert.True(raeStandUpPara1.Displayed);
                Assert.True(HerbsAndPesticidesTitle.Displayed);
                Assert.False(HerbsAndPesticidesTitleMobile.Displayed);
                Assert.True(HerbsAndPesticidesPara1.Displayed);
                Assert.True(SlowDownTitle.Displayed);
                Assert.False(SlowDownTitleMobile.Displayed);
                Assert.True(SlowDownPara1.Displayed);
                Assert.True(PlantNativePlantsTitle.Displayed);
                Assert.False(PlantNativePlantsTitleMobile.Displayed);
                Assert.True(PlantNativePlants.Displayed);
                Assert.True(raeGreenRecoveryTitle.Displayed);
                Assert.False(raeGreenRecoveryTitleMobile.Displayed);
                Assert.True(raeGreenRecoveryPara1.Displayed);
                Assert.True(raeBuyRecycledTitle.Displayed);
                Assert.False(raeBuyRecycledTitleMobile.Displayed);
                Assert.True(raeBuyRecycledPara1.Displayed);
                Assert.True(raeUseABlueRecyclingBinTitle.Displayed);
                Assert.False(raeUseABlueRecyclingBinTitleMobile.Displayed);
                Assert.True(raeUseABlueRecyclingBinPara1.Displayed);
                Assert.True(raeSignAPetitionTitle.Displayed);
                Assert.False(raeSignAPetitionTitleMobile.Displayed);
                Assert.True(raeSignAPetitionPara1.Displayed);
                Assert.True(raeMyImpactReduceMeat.Displayed);
                Assert.True(raeMyImpactFamilySizes.Displayed);
                Assert.True(raeMyImpactMinimisePlastic.Displayed);
                Assert.True(raeMyImpactGoVegetarian.Displayed);
                Assert.True(raeMyImpactGoVegan.Displayed);
                Assert.True(raeMyImpactHabitatRestoration.Displayed);
                Assert.True(raeMyImpactWildlifeRefuge.Displayed);
                Assert.True(raeMyImpactStandUp.Displayed);
                Assert.True(raeMyImpactHerbsAndPesticides.Displayed);
                Assert.True(raeMyImpactSlowDown.Displayed);
                Assert.True(raeMyImpactPlantNativePlants.Displayed);
                Assert.True(raeMyImpactGreenRecovery.Displayed);
                Assert.True(raeMyImpactBuyRecycled.Displayed);
                Assert.True(raeMyImpactRecyclingBin.Displayed);
                Assert.True(raeMyImpactSignPetition.Displayed);
                Assert.False(raeReduceMeatIntakeParaB.Displayed);
                Assert.False(ReducedFamilySizesParaB.Displayed);
                Assert.False(raeMinimisePlasticPara1B.Displayed);
                Assert.False(raeGoVegetarianPara1B.Displayed);
                Assert.False(raeGoVeganPara1B.Displayed);
                Assert.False(SupportHabitatRestorationPara1B.Displayed);
                Assert.False(WildlifeRefugePara1B.Displayed);
                Assert.False(raeStandUpPara1B.Displayed);
                Assert.False(HerbsAndPesticidesPara1B.Displayed);
                Assert.False(SlowDownPara1B.Displayed);
                Assert.False(PlantNativePlantsB.Displayed);
                Assert.False(raeGreenRecoveryPara1B.Displayed);
                Assert.False(raeBuyRecycledPara1B.Displayed);
                Assert.False(raeUseABlueRecyclingBinPara1B.Displayed);
                Assert.False(raeSignAPetitionPara1B.Displayed);

                driver1.Manage().Window.Size = new Size(240, 600);

                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(raeDoSomethingTodayTitle.Displayed);
                Assert.True(raeDoSomethingTodayPara.Displayed);
                Assert.True(RAEPageAllUserActionsIconText.Displayed);
                Assert.True(RAEPageAllUserActionsTotalText.Displayed);
                Assert.True(RAEPageRAEUserActionsIconText.Displayed);
                Assert.True(RAEPageRAEUserActionsTotalText.Displayed);
                Assert.True(RAEPageMyTotalActionsIconText.Displayed);
                Assert.True(RAEPageMyTotalActionsTotalText.Displayed);
                Assert.True(RAEPageMyCO2ImpactIconText.Displayed);
                Assert.True(RAEPageMyCO2ImpactTotalText.Displayed);
                Assert.True(raeWhatCanIDoTitle.Displayed);
                Assert.False(raeInformationTitle.Displayed);
                Assert.True(raeImpactTitle.Displayed);
                Assert.True(raeIDidThisTodayTitle.Displayed);
                Assert.False(raeReduceMeatIntakeTitle.Displayed);
                Assert.True(raeReduceMeatIntakeTitleMobile.Displayed);
                Assert.False(raeReduceMeatIntakePara.Displayed);
                Assert.False(ReducedFamilySizesTitle.Displayed);
                Assert.True(ReducedFamilySizesTitleMobile.Displayed);
                Assert.False(ReducedFamilySizesPara.Displayed);
                Assert.False(raeMinimisePlasticTitle.Displayed);
                Assert.True(raeMinimisePlasticTitleMobile.Displayed);
                Assert.False(raeMinimisePlasticPara1.Displayed);
                Assert.False(raeGoVegetarianTitle.Displayed);
                Assert.True(raeGoVegetarianTitleMobile.Displayed);
                Assert.False(raeGoVegetarianPara1.Displayed);
                Assert.False(raeGoVeganTitle.Displayed);
                Assert.True(raeGoVeganTitleMobile.Displayed);
                Assert.False(raeGoVeganPara1.Displayed);
                Assert.False(SupportHabitatRestorationTitle.Displayed);
                Assert.True(SupportHabitatRestorationTitleMobile.Displayed);
                Assert.False(SupportHabitatRestorationPara1.Displayed);
                Assert.False(WildlifeRefugeTitle.Displayed);
                Assert.True(WildlifeRefugeTitleMobile.Displayed);
                Assert.False(WildlifeRefugePara.Displayed);
                Assert.False(raeStandUp.Displayed);
                Assert.True(raeStandUpMobile.Displayed);
                Assert.False(raeStandUpPara1.Displayed);
                Assert.False(HerbsAndPesticidesTitle.Displayed);
                Assert.True(HerbsAndPesticidesTitleMobile.Displayed);
                Assert.False(HerbsAndPesticidesPara1.Displayed);
                Assert.False(SlowDownTitle.Displayed);
                Assert.True(SlowDownTitleMobile.Displayed);
                Assert.False(SlowDownPara1.Displayed);
                Assert.False(PlantNativePlantsTitle.Displayed);
                Assert.True(PlantNativePlantsTitleMobile.Displayed);
                Assert.False(PlantNativePlants.Displayed);
                Assert.False(raeGreenRecoveryTitle.Displayed);
                Assert.True(raeGreenRecoveryTitleMobile.Displayed);
                Assert.False(raeGreenRecoveryPara1.Displayed);
                Assert.False(raeBuyRecycledTitle.Displayed);
                Assert.True(raeBuyRecycledTitleMobile.Displayed);
                Assert.False(raeBuyRecycledPara1.Displayed);
                Assert.False(raeUseABlueRecyclingBinTitle.Displayed);
                Assert.True(raeUseABlueRecyclingBinTitleMobile.Displayed);
                Assert.False(raeUseABlueRecyclingBinPara1.Displayed);
                Assert.False(raeSignAPetitionTitle.Displayed);
                Assert.True(raeSignAPetitionTitleMobile.Displayed);
                Assert.False(raeSignAPetitionPara1.Displayed);
                Assert.True(raeMyImpactReduceMeat.Displayed);
                Assert.True(raeMyImpactFamilySizes.Displayed);
                Assert.True(raeMyImpactMinimisePlastic.Displayed);
                Assert.True(raeMyImpactGoVegetarian.Displayed);
                Assert.True(raeMyImpactGoVegan.Displayed);
                Assert.True(raeMyImpactHabitatRestoration.Displayed);
                Assert.True(raeMyImpactWildlifeRefuge.Displayed);
                Assert.True(raeMyImpactStandUp.Displayed);
                Assert.True(raeMyImpactHerbsAndPesticides.Displayed);
                Assert.True(raeMyImpactSlowDown.Displayed);
                Assert.True(raeMyImpactPlantNativePlants.Displayed);
                Assert.True(raeMyImpactGreenRecovery.Displayed);
                Assert.True(raeMyImpactBuyRecycled.Displayed);
                Assert.True(raeMyImpactRecyclingBin.Displayed);
                Assert.True(raeMyImpactSignPetition.Displayed);
                Assert.True(raeReduceMeatIntakeParaB.Displayed);
                Assert.True(ReducedFamilySizesParaB.Displayed);
                Assert.True(raeMinimisePlasticPara1B.Displayed);
                Assert.True(raeGoVegetarianPara1B.Displayed);
                Assert.True(raeGoVeganPara1B.Displayed);
                Assert.True(SupportHabitatRestorationPara1B.Displayed);
                Assert.True(WildlifeRefugePara1B.Displayed);
                Assert.True(raeStandUpPara1B.Displayed);
                Assert.True(HerbsAndPesticidesPara1B.Displayed);
                Assert.True(SlowDownPara1B.Displayed);
                Assert.True(PlantNativePlantsB.Displayed);
                Assert.True(raeGreenRecoveryPara1B.Displayed);
                Assert.True(raeBuyRecycledPara1B.Displayed);
                Assert.True(raeUseABlueRecyclingBinPara1B.Displayed);
                Assert.True(raeSignAPetitionPara1B.Displayed);
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
            var filename = "TestReduceAnimalExtinctionPageComponentsArePresent_CheckModalsAreDisplayedOnClick";

            TakeTestFailScreenshot.UITest(() =>
            {
                var ReduceAnimalExtinctionPageLocSourceNamesLibrary = new ReduceAnimalExtinctionPageLocSourceNames();
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

                string raeUrl = UrlRefLibrary.GetReduceAnimalExtinctionPageLocalHostUrl();
                driver.Navigate().GoToUrl(raeUrl);

                IWebElement ReduceMeatIntakeTitle = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raeReduceMeatIntakeTitle")));
                IWebElement LearnMoreRow1 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreRow1")));
                IWebElement LearnMoreRow2 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreRow2")));
                IWebElement LearnMoreRow3 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreRow3")));
                IWebElement LearnMoreRow4 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreRow4")));
                IWebElement LearnMoreRow5 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreRow5")));
                IWebElement LearnMoreRow6 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreRow6")));
                IWebElement LearnMoreRow7 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreRow7")));
                IWebElement LearnMoreRow8 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreRow8")));
                IWebElement LearnMoreRow9 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreRow9")));
                IWebElement LearnMoreRow10 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreRow10")));
                IWebElement LearnMoreRow11 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreRow11")));
                IWebElement LearnMoreRow12 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreRow12")));
                IWebElement LearnMoreRow13 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreRow13")));
                IWebElement LearnMoreRow14 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreRow14")));
                IWebElement LearnMoreRow15 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreRow15")));

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

                var js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow2);

                LearnMoreRow1.Click();
                
                IWebElement raePageLearnMoreModal = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreModal")));
                IWebElement learnMoreModalTitle = driver.FindElement(By.Id("raelearnMoreModalTitle"));
                IWebElement learnMoreModalHeaderCloseButton = driver.FindElement(By.Id("raelearnMoreModalHeaderCloseButton"));
                IWebElement raePageLearnMoreModalPara = driver.FindElement(By.Id("raePageLearnMoreModalPara"));
                IWebElement raePageLearnMoreModalFormLabel = driver.FindElement(By.Id("raePageLearnMoreModalFormLabel"));
                IWebElement raePageModalTextArea = driver.FindElement(By.Id("rae-Page-Learn-More-Modal-message-text"));
                IWebElement learnMoreModalFooterCloseButton = driver.FindElement(By.Id("raelearnMoreModalFooterCloseButton"));
                string learnMoreModalTitleReturned = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceReduceMeatIntakeTitleNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalParaReturned = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalFormLabelReturned = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceAnimalExtinctionPage();
                string learnMoreModalFooterCloseButtonReturned = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(raePageLearnMoreModal.Displayed);
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(raePageLearnMoreModalPara.Displayed);
                Assert.True(raePageLearnMoreModalFormLabel.Displayed);
                Assert.True(raePageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned);
                Assert.Equal(raePageLearnMoreModalPara.Text, raePageLearnMoreModalParaReturned);
                Assert.Equal(raePageLearnMoreModalFormLabel.Text, raePageLearnMoreModalFormLabelReturned);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("raePageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow5);
                LearnMoreRow2.Click();
                
                IWebElement raePageLearnMoreModal2 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreModal")));
                string learnMoreModalTitleReturned2 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceReducedFamilySizesTitleNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalParaReturned2 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalFormLabelReturned2 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceAnimalExtinctionPage();
                string learnMoreModalFooterCloseButtonReturned2 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(raePageLearnMoreModalPara.Displayed);
                Assert.True(raePageLearnMoreModalFormLabel.Displayed);
                Assert.True(raePageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned2);
                Assert.Equal(raePageLearnMoreModalPara.Text, raePageLearnMoreModalParaReturned2);
                Assert.Equal(raePageLearnMoreModalFormLabel.Text, raePageLearnMoreModalFormLabelReturned2);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned2);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("raePageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow6);
                LearnMoreRow3.Click();
                
                IWebElement raePageLearnMoreModal3 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreModal")));
                string learnMoreModalTitleReturned3 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceMinimisePlasticTitleNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalParaReturned3 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalFormLabelReturned3 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceAnimalExtinctionPage();
                string learnMoreModalFooterCloseButtonReturned3 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(raePageLearnMoreModalPara.Displayed);
                Assert.True(raePageLearnMoreModalFormLabel.Displayed);
                Assert.True(raePageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned3);
                Assert.Equal(raePageLearnMoreModalPara.Text, raePageLearnMoreModalParaReturned3);
                Assert.Equal(raePageLearnMoreModalFormLabel.Text, raePageLearnMoreModalFormLabelReturned3);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned3);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("raePageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow7);
                LearnMoreRow4.Click();
                
                IWebElement raePageLearnMoreModal4 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreModal")));
                string learnMoreModalTitleReturned4 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceGoVegetarianTitleNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalParaReturned4 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalFormLabelReturned4 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceAnimalExtinctionPage();
                string learnMoreModalFooterCloseButtonReturned4 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(raePageLearnMoreModalPara.Displayed);
                Assert.True(raePageLearnMoreModalFormLabel.Displayed);
                Assert.True(raePageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned4);
                Assert.Equal(raePageLearnMoreModalPara.Text, raePageLearnMoreModalParaReturned4);
                Assert.Equal(raePageLearnMoreModalFormLabel.Text, raePageLearnMoreModalFormLabelReturned4);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned4);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("raePageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow8);
                LearnMoreRow5.Click();
                
                IWebElement raePageLearnMoreModal5 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreModal")));
                string learnMoreModalTitleReturned5 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceGoVeganTitleNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalParaReturned5 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalFormLabelReturned5 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceAnimalExtinctionPage();
                string learnMoreModalFooterCloseButtonReturned5 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(raePageLearnMoreModalPara.Displayed);
                Assert.True(raePageLearnMoreModalFormLabel.Displayed);
                Assert.True(raePageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned5);
                Assert.Equal(raePageLearnMoreModalPara.Text, raePageLearnMoreModalParaReturned5);
                Assert.Equal(raePageLearnMoreModalFormLabel.Text, raePageLearnMoreModalFormLabelReturned5);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned5);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("raePageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow9);
                LearnMoreRow6.Click();
                
                IWebElement raePageLearnMoreModal6 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreModal")));
                string learnMoreModalTitleReturned6 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceSupportHabitatRestorationTitleNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalParaReturned6 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalFormLabelReturned6 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceAnimalExtinctionPage();
                string learnMoreModalFooterCloseButtonReturned6 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(raePageLearnMoreModalPara.Displayed);
                Assert.True(raePageLearnMoreModalFormLabel.Displayed);
                Assert.True(raePageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned6);
                Assert.Equal(raePageLearnMoreModalPara.Text, raePageLearnMoreModalParaReturned6);
                Assert.Equal(raePageLearnMoreModalFormLabel.Text, raePageLearnMoreModalFormLabelReturned6);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned6);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("raePageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow10);
                LearnMoreRow7.Click();
                
                IWebElement raePageLearnMoreModal7 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreModal")));
                string learnMoreModalTitleReturned7 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWildlifeRefugeTitleNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalParaReturned7 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalFormLabelReturned7 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceAnimalExtinctionPage();
                string learnMoreModalFooterCloseButtonReturned7 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(raePageLearnMoreModalPara.Displayed);
                Assert.True(raePageLearnMoreModalFormLabel.Displayed);
                Assert.True(raePageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned7);
                Assert.Equal(raePageLearnMoreModalPara.Text, raePageLearnMoreModalParaReturned7);
                Assert.Equal(raePageLearnMoreModalFormLabel.Text, raePageLearnMoreModalFormLabelReturned7);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned7);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("raePageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow11);
                LearnMoreRow8.Click();
                
                IWebElement raePageLearnMoreModal8 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreModal")));
                string learnMoreModalTitleReturned8 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceStandUpNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalParaReturned8 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalFormLabelReturned8 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceAnimalExtinctionPage();
                string learnMoreModalFooterCloseButtonReturned8 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(raePageLearnMoreModalPara.Displayed);
                Assert.True(raePageLearnMoreModalFormLabel.Displayed);
                Assert.True(raePageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned8);
                Assert.Equal(raePageLearnMoreModalPara.Text, raePageLearnMoreModalParaReturned8);
                Assert.Equal(raePageLearnMoreModalFormLabel.Text, raePageLearnMoreModalFormLabelReturned8);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned8);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("raePageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow12);
                LearnMoreRow9.Click();
                
                IWebElement raePageLearnMoreModal9 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreModal")));
                string learnMoreModalTitleReturned9 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceHerbsAndPesticidesTitleNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalParaReturned9 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalFormLabelReturned9 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceAnimalExtinctionPage();
                string learnMoreModalFooterCloseButtonReturned9 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(raePageLearnMoreModalPara.Displayed);
                Assert.True(raePageLearnMoreModalFormLabel.Displayed);
                Assert.True(raePageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned9);
                Assert.Equal(raePageLearnMoreModalPara.Text, raePageLearnMoreModalParaReturned9);
                Assert.Equal(raePageLearnMoreModalFormLabel.Text, raePageLearnMoreModalFormLabelReturned9);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned9);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("raePageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow13);
                LearnMoreRow10.Click();
                
                IWebElement raePageLearnMoreModal10 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreModal")));
                string learnMoreModalTitleReturned10 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceSlowDownTitleNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalParaReturned10 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalFormLabelReturned10 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceAnimalExtinctionPage();
                string learnMoreModalFooterCloseButtonReturned10 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(raePageLearnMoreModalPara.Displayed);
                Assert.True(raePageLearnMoreModalFormLabel.Displayed);
                Assert.True(raePageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned10);
                Assert.Equal(raePageLearnMoreModalPara.Text, raePageLearnMoreModalParaReturned10);
                Assert.Equal(raePageLearnMoreModalFormLabel.Text, raePageLearnMoreModalFormLabelReturned10);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned10);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("raePageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow14);
                LearnMoreRow11.Click();
                
                IWebElement raePageLearnMoreModal11 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreModal")));
                string learnMoreModalTitleReturned11 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourcePlantNativePlantsTitleNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalParaReturned11 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalFormLabelReturned11 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceAnimalExtinctionPage();
                string learnMoreModalFooterCloseButtonReturned11 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(raePageLearnMoreModalPara.Displayed);
                Assert.True(raePageLearnMoreModalFormLabel.Displayed);
                Assert.True(raePageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned11);
                Assert.Equal(raePageLearnMoreModalPara.Text, raePageLearnMoreModalParaReturned11);
                Assert.Equal(raePageLearnMoreModalFormLabel.Text, raePageLearnMoreModalFormLabelReturned11);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned11);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("raePageLearnMoreModal")));

                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", LearnMoreRow15);
                LearnMoreRow12.Click();
                
                IWebElement raePageLearnMoreModal12 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreModal")));
                string learnMoreModalTitleReturned12 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceGreenRecoveryTitleNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalParaReturned12 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalFormLabelReturned12 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceAnimalExtinctionPage();
                string learnMoreModalFooterCloseButtonReturned12 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(raePageLearnMoreModalPara.Displayed);
                Assert.True(raePageLearnMoreModalFormLabel.Displayed);
                Assert.True(raePageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned12);
                Assert.Equal(raePageLearnMoreModalPara.Text, raePageLearnMoreModalParaReturned12);
                Assert.Equal(raePageLearnMoreModalFormLabel.Text, raePageLearnMoreModalFormLabelReturned12);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned12);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("raePageLearnMoreModal")));

                LearnMoreRow13.Click();
                
                IWebElement raePageLearnMoreModal13 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreModal")));
                string learnMoreModalTitleReturned13 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceBuyRecycledTitleNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalParaReturned13 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalFormLabelReturned13 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceAnimalExtinctionPage();
                string learnMoreModalFooterCloseButtonReturned13 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(raePageLearnMoreModalPara.Displayed);
                Assert.True(raePageLearnMoreModalFormLabel.Displayed);
                Assert.True(raePageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned13);
                Assert.Equal(raePageLearnMoreModalPara.Text, raePageLearnMoreModalParaReturned13);
                Assert.Equal(raePageLearnMoreModalFormLabel.Text, raePageLearnMoreModalFormLabelReturned13);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned13);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("raePageLearnMoreModal")));

                LearnMoreRow14.Click();
                
                IWebElement raePageLearnMoreModal14 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreModal")));
                string learnMoreModalTitleReturned14 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceUseARecyclingBinTitleNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalParaReturned14 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalFormLabelReturned14 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceAnimalExtinctionPage();
                string learnMoreModalFooterCloseButtonReturned14 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(raePageLearnMoreModalPara.Displayed);
                Assert.True(raePageLearnMoreModalFormLabel.Displayed);
                Assert.True(raePageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned14);
                Assert.Equal(raePageLearnMoreModalPara.Text, raePageLearnMoreModalParaReturned14);
                Assert.Equal(raePageLearnMoreModalFormLabel.Text, raePageLearnMoreModalFormLabelReturned14);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned14);
                learnMoreModalFooterCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("raePageLearnMoreModal")));

                LearnMoreRow15.Click();
                
                IWebElement raePageLearnMoreModal15 = new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("raePageLearnMoreModal")));
                string learnMoreModalTitleReturned15 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceSignAPetitionTitleNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalParaReturned15 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceComingSoonNameReferenceForReduceAnimalExtinctionPage();
                string raePageLearnMoreModalFormLabelReturned15 = ReduceAnimalExtinctionPageLocSourceNamesLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceAnimalExtinctionPage();
                string learnMoreModalFooterCloseButtonReturned15 = SharedCrossPageLocSourceNamesLibrary.GetLocSourceCloseLabelNameReference();
                Assert.True(learnMoreModalTitle.Displayed);
                Assert.True(learnMoreModalHeaderCloseButton.Displayed);
                Assert.True(raePageLearnMoreModalPara.Displayed);
                Assert.True(raePageLearnMoreModalFormLabel.Displayed);
                Assert.True(raePageModalTextArea.Displayed);
                Assert.True(learnMoreModalFooterCloseButton.Displayed);
                Assert.Equal(learnMoreModalTitle.Text, learnMoreModalTitleReturned15);
                Assert.Equal(raePageLearnMoreModalPara.Text, raePageLearnMoreModalParaReturned15);
                Assert.Equal(raePageLearnMoreModalFormLabel.Text, raePageLearnMoreModalFormLabelReturned15);
                Assert.Equal(learnMoreModalFooterCloseButton.Text, learnMoreModalFooterCloseButtonReturned15);
                learnMoreModalHeaderCloseButton.Click();
                
                new WebDriverWait(driver, new TimeSpan(0, 0, 60)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id("raePageLearnMoreModal")));
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
            var filename = "TestReduceAnimalExtinctionPageComponentsArePresent_CheckFooterIsDisplayed";

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

                string RAEUrl = UrlRefLibrary.GetReduceAnimalExtinctionPageLocalHostUrl();
                driver.Navigate().GoToUrl(RAEUrl);

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
