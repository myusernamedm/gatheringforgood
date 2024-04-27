using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using UITestStringsLibrary;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Drawing;
using ImageUrlReferenceLibrary;

namespace GatheringForGood.UITests
{
    public class TestCreateArticlePartialsArePresent
    {
        CrossPageSharedUITestStrings UITestStrings = new();
        TestingImageUrls _TestingImageUrls = new();

        [Fact]
        [Trait("Category", "System")]
        [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Local")]
        public void CheckTreePurchasePartial()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestCreateArticlePartialsArePresent_CheckTreePurchasePartial";

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

                string CreateArticleUrl = UrlRefLibrary.GetCreateArticlePageLocalHostUrl();

                driver.Navigate().GoToUrl(CreateArticleUrl);
                driver.Manage().Window.Maximize();

                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("CreateArticlesPageBanner")));
                IWebElement PlantATreePartialOneTreeIconLargeLinkSection = driver.FindElement(By.Id("PlantATreePartialOneTreeIconLargeLinkSection"));
                IWebElement PlantATreePartialOneTreeIconLargeLink = driver.FindElement(By.Id("PlantATreePartialOneTreeIconLargeLink"));
                IWebElement OneTreeIconLarge = driver.FindElement(By.Id("OneTreeIconLarge"));
                IWebElement PlantATreePartialTextDiv = driver.FindElement(By.Id("PlantATreePartialTextDiv"));
                IWebElement PlantATreePartialTitle = driver.FindElement(By.Id("PlantATreePartialTitle"));
                IWebElement PlantATreePartialPara1 = driver.FindElement(By.Id("PlantATreePartialPara1"));
                IWebElement PlantATreePartialPara2 = driver.FindElement(By.Id("PlantATreePartialPara2"));
                IWebElement PlantATreePartialPurchaseTandCs1 = driver.FindElement(By.Id("PlantATreePartialPurchaseTandCs1"));
                IWebElement PlantATreePartialCheckedIconGroup = driver.FindElement(By.Id("PlantATreePartialCheckedIconGroup"));
                IWebElement PlantATreePartialIconLink = driver.FindElement(By.Id("PlantATreePartialIconLink"));
                IWebElement PlantATreePartialCheckedIcon = driver.FindElement(By.Id("PlantATreePartialCheckedIcon"));
                IWebElement PlantATreeParticlCheckedTextLink = driver.FindElement(By.Id("PlantATreeParticlCheckedTextLink"));
                IWebElement PlantATreeParticlCheckedText = driver.FindElement(By.Id("PlantATreeParticlCheckedText"));
                IWebElement Purchase1Tree = driver.FindElement(By.Id("Purchase1Tree"));
                IWebElement _TreePurchasePartialTandCsLink = driver.FindElement(By.Id("_TreePurchasePartialTandCsLink"));
                IWebElement TreePurchaseCheckedStatus = driver.FindElement(By.Id("TreePurchaseCheckedStatus"));

                var valueI = TreePurchaseCheckedStatus.GetAttribute("value");
                Assert.Equal("", valueI);

                Assert.True(PlantATreePartialOneTreeIconLargeLinkSection.Displayed);
                Assert.True(PlantATreePartialOneTreeIconLargeLink.Displayed);
                Assert.True(OneTreeIconLarge.Displayed);
                Assert.True(PlantATreePartialTextDiv.Displayed);
                Assert.True(PlantATreePartialTitle.Displayed);
                Assert.True(PlantATreePartialPara1.Displayed);
                Assert.True(PlantATreePartialPara2.Displayed);
                Assert.True(PlantATreePartialPurchaseTandCs1.Displayed);
                Assert.True(PlantATreePartialCheckedIconGroup.Displayed);
                Assert.True(PlantATreePartialIconLink.Displayed);
                Assert.True(PlantATreePartialCheckedIcon.Displayed);
                Assert.True(PlantATreeParticlCheckedTextLink.Displayed);
                Assert.True(PlantATreeParticlCheckedText.Displayed);
                Assert.False(Purchase1Tree.Displayed);

                OneTreeIconLarge.Click();
                Assert.True(Purchase1Tree.Displayed);

                OneTreeIconLarge.Click();
                Assert.False(Purchase1Tree.Displayed);

                PlantATreePartialCheckedIcon.Click();
                Assert.True(Purchase1Tree.Displayed);

                PlantATreePartialCheckedIcon.Click();
                Assert.False(Purchase1Tree.Displayed);

                PlantATreeParticlCheckedText.Click();
                Assert.True(Purchase1Tree.Displayed);

                PlantATreeParticlCheckedText.Click();
                Assert.False(Purchase1Tree.Displayed);

                _TreePurchasePartialTandCsLink.Click();
                IWebElement TermsAndConditionsPageBanner = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("TermsAndConditionsPageBanner")));

                driver.Navigate().GoToUrl(CreateArticleUrl);
                IWebElement OneTreeIconLarge1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("OneTreeIconLarge")));

                OneTreeIconLarge1.Click();
                IWebElement radioPurchase1Tree = driver.FindElement(By.Id("radioPurchase1Tree"));
                IWebElement radioPurchase1TreeLabel = driver.FindElement(By.Id("radioPurchase1TreeLabel"));
                IWebElement radioTreePurchase_1Icon = driver.FindElement(By.Id("radioTreePurchase_1Icon"));
                IWebElement Purchase1TreePrice = driver.FindElement(By.Id("Purchase1TreePrice"));

                IWebElement radioPurchase1TreePM = driver.FindElement(By.Id("radioPurchase1TreePM"));
                IWebElement radioPurchase1TreePMLabel = driver.FindElement(By.Id("radioPurchase1TreePMLabel"));
                IWebElement radioTreePurchase_1PMIcon = driver.FindElement(By.Id("radioTreePurchase_1PMIcon"));
                IWebElement Purchase1PMTreePrice = driver.FindElement(By.Id("Purchase1PMTreePrice"));

                IWebElement radioPurchase2Tree = driver.FindElement(By.Id("radioPurchase2Tree"));
                IWebElement radioPurchase2TreeLabel = driver.FindElement(By.Id("radioPurchase2TreeLabel"));
                IWebElement radioTreePurchase_2Icon = driver.FindElement(By.Id("radioTreePurchase_2Icon"));
                IWebElement Purchase2TreePrice = driver.FindElement(By.Id("Purchase2TreePrice"));

                IWebElement radioPurchase2TreePM = driver.FindElement(By.Id("radioPurchase2TreePM"));
                IWebElement radioPurchase2TreePMLabel = driver.FindElement(By.Id("radioPurchase2TreePMLabel"));
                IWebElement radioTreePurchase_2PMIcon = driver.FindElement(By.Id("radioTreePurchase_2PMIcon"));
                IWebElement Purchase2PMTreePrice = driver.FindElement(By.Id("Purchase2PMTreePrice"));

                IWebElement radioPurchase5Tree = driver.FindElement(By.Id("radioPurchase5Tree"));
                IWebElement radioPurchase5TreeLabel = driver.FindElement(By.Id("radioPurchase5TreeLabel"));
                IWebElement radioTreePurchase_5Icon = driver.FindElement(By.Id("radioTreePurchase_5Icon"));
                IWebElement Purchase5TreePrice = driver.FindElement(By.Id("Purchase5TreePrice"));

                IWebElement radioPurchase5TreePM = driver.FindElement(By.Id("radioPurchase5TreePM"));
                IWebElement radioPurchase5TreePMLabel = driver.FindElement(By.Id("radioPurchase5TreePMLabel"));
                IWebElement radioTreePurchase_5PMIcon = driver.FindElement(By.Id("radioTreePurchase_5PMIcon"));
                IWebElement Purchase5PMTreePrice = driver.FindElement(By.Id("Purchase5PMTreePrice"));

                IWebElement radioPurchase10Tree = driver.FindElement(By.Id("radioPurchase10Tree"));
                IWebElement radioPurchase10TreeLabel = driver.FindElement(By.Id("radioPurchase10TreeLabel"));
                IWebElement radioTreePurchase_10Icon = driver.FindElement(By.Id("radioTreePurchase_10Icon"));
                IWebElement Purchase10TreePrice = driver.FindElement(By.Id("Purchase10TreePrice"));

                IWebElement radioPurchase10TreePM = driver.FindElement(By.Id("radioPurchase10TreePM"));
                IWebElement radioPurchase10TreePMLabel = driver.FindElement(By.Id("radioPurchase10TreePMLabel"));
                IWebElement radioTreePurchase_10PMIcon = driver.FindElement(By.Id("radioTreePurchase_10PMIcon"));
                IWebElement Purchase10PMTreePrice = driver.FindElement(By.Id("Purchase10PMTreePrice"));

                IWebElement radioPurchase20Tree = driver.FindElement(By.Id("radioPurchase20Tree"));
                IWebElement radioPurchase20TreeLabel = driver.FindElement(By.Id("radioPurchase20TreeLabel"));
                IWebElement radioTreePurchase_20Icon = driver.FindElement(By.Id("radioTreePurchase_20Icon"));
                IWebElement Purchase20TreePrice = driver.FindElement(By.Id("Purchase20TreePrice"));

                IWebElement radioPurchase20TreePM = driver.FindElement(By.Id("radioPurchase20TreePM"));
                IWebElement radioPurchase20TreePMLabel = driver.FindElement(By.Id("radioPurchase20TreePMLabel"));
                IWebElement radioTreePurchase_20PMIcon = driver.FindElement(By.Id("radioTreePurchase_20PMIcon"));
                IWebElement Purchase20PMTreePrice = driver.FindElement(By.Id("Purchase20PMTreePrice"));

                IWebElement TreePurchaseCheckedStatus1 = driver.FindElement(By.Id("TreePurchaseCheckedStatus"));

                Assert.True(radioPurchase1Tree.Displayed);
                Assert.True(radioPurchase1TreeLabel.Displayed);
                Assert.True(radioTreePurchase_1Icon.Displayed);
                Assert.True(Purchase1TreePrice.Displayed);
                Assert.True(radioPurchase1TreePM.Displayed);
                Assert.True(radioPurchase1TreePMLabel.Displayed);
                Assert.True(radioTreePurchase_1PMIcon.Displayed);
                Assert.True(Purchase1PMTreePrice.Displayed);

                Assert.True(radioPurchase2Tree.Displayed);
                Assert.True(radioPurchase2TreeLabel.Displayed);
                Assert.True(radioTreePurchase_2Icon.Displayed);
                Assert.True(Purchase2TreePrice.Displayed);
                Assert.True(radioPurchase2TreePM.Displayed);
                Assert.True(radioPurchase2TreePMLabel.Displayed);
                Assert.True(radioTreePurchase_2PMIcon.Displayed);
                Assert.True(Purchase2PMTreePrice.Displayed);

                Assert.True(radioPurchase5Tree.Displayed);
                Assert.True(radioPurchase5TreeLabel.Displayed);
                Assert.True(radioTreePurchase_5Icon.Displayed);
                Assert.True(Purchase5TreePrice.Displayed);
                Assert.True(radioPurchase5TreePM.Displayed);
                Assert.True(radioPurchase5TreePMLabel.Displayed);
                Assert.True(radioTreePurchase_5PMIcon.Displayed);
                Assert.True(Purchase5PMTreePrice.Displayed);

                Assert.True(radioPurchase10Tree.Displayed);
                Assert.True(radioPurchase10TreeLabel.Displayed);
                Assert.True(radioTreePurchase_10Icon.Displayed);
                Assert.True(Purchase10TreePrice.Displayed);
                Assert.True(radioPurchase10TreePM.Displayed);
                Assert.True(radioPurchase10TreePMLabel.Displayed);
                Assert.True(radioTreePurchase_10PMIcon.Displayed);
                Assert.True(Purchase10PMTreePrice.Displayed);

                Assert.True(radioPurchase20Tree.Displayed);
                Assert.True(radioPurchase20TreeLabel.Displayed);
                Assert.True(radioTreePurchase_20Icon.Displayed);
                Assert.True(Purchase20TreePrice.Displayed);
                Assert.True(radioPurchase20TreePM.Displayed);
                Assert.True(radioPurchase20TreePMLabel.Displayed);
                Assert.True(radioTreePurchase_20PMIcon.Displayed);
                Assert.True(Purchase20PMTreePrice.Displayed);

                var js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", TreePurchaseCheckedStatus1);

                Thread.Sleep(2000);

                var value = TreePurchaseCheckedStatus1.GetAttribute("value");
                Assert.Equal("Y", value);
                radioPurchase1TreePM.Click();
                var value1 = TreePurchaseCheckedStatus1.GetAttribute("value");
                Assert.Equal("Y", value1);
                radioPurchase2Tree.Click();
                var value2 = TreePurchaseCheckedStatus1.GetAttribute("value");
                Assert.Equal("Y", value2);
                radioPurchase2TreePM.Click();
                var value3 = TreePurchaseCheckedStatus1.GetAttribute("value");
                Assert.Equal("Y", value3);
                radioPurchase5Tree.Click();
                var value4 = TreePurchaseCheckedStatus1.GetAttribute("value");
                Assert.Equal("Y", value4);
                radioPurchase5TreePM.Click();
                var value5 = TreePurchaseCheckedStatus1.GetAttribute("value");
                Assert.Equal("Y", value5);
                radioPurchase10Tree.Click();
                var value6 = TreePurchaseCheckedStatus1.GetAttribute("value");
                Assert.Equal("Y", value6);
                radioPurchase10TreePM.Click();
                var value7 = TreePurchaseCheckedStatus1.GetAttribute("value");
                Assert.Equal("Y", value7);
                radioPurchase20Tree.Click();
                var value8 = TreePurchaseCheckedStatus1.GetAttribute("value");
                Assert.Equal("Y", value8);
                radioPurchase20TreePM.Click();
                var value9 = TreePurchaseCheckedStatus1.GetAttribute("value");
                Assert.Equal("Y", value9);

                OneTreeIconLarge1.Click();
                var value10 = TreePurchaseCheckedStatus1.GetAttribute("value");
                Assert.Equal("", value10);

            }, filename, driver);
        }
    }
}