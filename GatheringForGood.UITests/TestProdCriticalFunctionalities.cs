using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using URLStringsReferenceLibrary;
using UITestStringsLibrary;
using OpenQA.Selenium.Support.UI;
using System.Drawing;
using LocSourceNameReferenceLibrary;

namespace GatheringForGood.UITests
{
    public class TestProdCriticalFunctionalities
    {
        /*
        readonly CrossPageSharedUITestStrings UITestStrings = new UITestStringsLibrary.CrossPageSharedUITestStrings();
        readonly SharedCrossPageLocSourceNames SharedLocSourceNames = new LocSourceNameReferenceLibrary.SharedCrossPageLocSourceNames();
        readonly LoginPageLocSourceNames LoginPageLocSourceNames = new LocSourceNameReferenceLibrary.LoginPageLocSourceNames();

        [Fact]
            [Trait("Category", "Smoke Logged Out")]
                [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdLoadHomePageCheckTitle()
            {
                    using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdLoadHomePageCheckTitle";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdHomeUrl = UrlRefLibrary.GetHomePageProdHostUrl();

                driver.Navigate().GoToUrl(ProdHomeUrl);
                driver.Manage().Window.Maximize();

                Assert.Equal("Change The World - GatheringForGood", driver.Title);
                Assert.Equal(ProdHomeUrl, driver.Url);
                    }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
                [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdLoadFeaturesPageCheckTitle()
            {
                            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdLoadFeaturesPageCheckTitle";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdFeaturesUrl = UrlRefLibrary.GetFeaturesPageProdHostUrl();

                driver.Navigate().GoToUrl(ProdFeaturesUrl);
                driver.Manage().Window.Maximize();

                Assert.Equal("Features - GatheringForGood", driver.Title);
                Assert.Equal(ProdFeaturesUrl, driver.Url);
                            }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
                [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdLoadAboutPageCheckTitle()
            {
                                    using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdLoadAboutPageCheckTitle";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdAboutUrl = UrlRefLibrary.GetAboutPageProdHostUrl();

                driver.Navigate().GoToUrl(ProdAboutUrl);
                driver.Manage().Window.Maximize();

                Assert.Equal("About Us - GatheringForGood", driver.Title);
                Assert.Equal(ProdAboutUrl, driver.Url);
                                    }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
                [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdLoadHelpPageCheckTitle()
            {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdLoadHelpPageCheckTitle";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdHelpUrl = UrlRefLibrary.GetHelpPageProdHostUrl();

                driver.Navigate().GoToUrl(ProdHelpUrl);
                driver.Manage().Window.Maximize();

                Assert.Equal("Help Center - GatheringForGood", driver.Title);
                Assert.Equal(ProdHelpUrl, driver.Url);
            }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
                [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdLoadRegisterPageCheckTitle()
            {
                    using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdLoadRegisterPageCheckTitle";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdRegisterUrl = UrlRefLibrary.GetRegisterPageProdHostUrl();

                driver.Navigate().GoToUrl(ProdRegisterUrl);
                driver.Manage().Window.Maximize();

                Assert.Equal("Register - GatheringForGood", driver.Title);
                Assert.Equal(ProdRegisterUrl, driver.Url);
                    }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
                [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdLoadLoginPageCheckTitle()
            {
                            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdLoadLoginPageCheckTitle";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdLoginUrl = UrlRefLibrary.GetLoginPageProdHostUrl();

                driver.Navigate().GoToUrl(ProdLoginUrl);
                driver.Manage().Window.Maximize();

                Assert.Equal("Login - GatheringForGood", driver.Title);
                Assert.Equal(ProdLoginUrl, driver.Url);
                            }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
                [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdLoadBlogPageCheckTitle()
            {
                                    using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdLoadBlogPageCheckTitle";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdBlogUrl = UrlRefLibrary.GetBlogPageProdHostUrl();

                driver.Navigate().GoToUrl(ProdBlogUrl);
                driver.Manage().Window.Maximize();

                Assert.Equal("Good News Blog - GatheringForGood", driver.Title);
                Assert.Equal(ProdBlogUrl, driver.Url);
                                    }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
                [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdLoadPrivacyPageCheckTitle()
            {
                                            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdLoadPrivacyPageCheckTitle";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdPrivacyUrl = UrlRefLibrary.GetPrivacyPageProdHostUrl();

                driver.Navigate().GoToUrl(ProdPrivacyUrl);
                driver.Manage().Window.Maximize();

                Assert.Equal("Privacy Policy - GatheringForGood", driver.Title);
                Assert.Equal(ProdPrivacyUrl, driver.Url);
            }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
                [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdLoadCookiesPageCheckTitle()
            {
                                                    using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdLoadCookiesPageCheckTitle";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdCookiesUrl = UrlRefLibrary.GetCookiesPageProdHostUrl();

                driver.Navigate().GoToUrl(ProdCookiesUrl);
                driver.Manage().Window.Maximize();

                Assert.Equal("Cookies Notice - GatheringForGood", driver.Title);
                Assert.Equal(ProdCookiesUrl, driver.Url);
                    }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
                [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("Runtime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdCheckHomePageMainMenuToggler()
            {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdCheckHomePageMainMenuToggler";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdHomeUrl = UrlRefLibrary.GetHomePageProdHostUrl();

                driver.Navigate().GoToUrl(ProdHomeUrl);
                driver.Manage().Window.Size = new Size(240, 600);

                IWebElement NavBarToggler = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("SharedPageNavBarToggler")));
                IWebElement _LayoutPageHomeNavLink = driver.FindElement(By.Id("_LayoutPageHomeNavLink"));

                Assert.False(_LayoutPageHomeNavLink.Displayed);

                NavBarToggler.Click();

                Assert.True(NavBarToggler.Displayed);
                            }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
                [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void CheckTextForNavBarLinksIsCorrect()
            {
                    using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_CheckTextForNavBarLinksIsCorrect";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdHomeUrl = UrlRefLibrary.GetHomePageProdHostUrl();

                driver.Navigate().GoToUrl(ProdHomeUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar")));
                IWebElement NavBarHomeLinkElement = driver.FindElement(By.Id("_LayoutPageHomeNavLink"));
                IWebElement NavBarFeaturesLinkElement = driver.FindElement(By.Id("_LayoutPageFeaturesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_LayoutPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_LayoutPageHelpNavLink"));
                IWebElement NavBarRegisterLinkElement = driver.FindElement(By.Id("_LoginPartialRegister"));
                IWebElement NavBarLoginLinkElement = driver.FindElement(By.Id("_LoginPartialLogin"));

                Assert.True(NavBarElement.Displayed);
                Assert.True(NavBarHomeLinkElement.Displayed);
                Assert.True(NavBarFeaturesLinkElement.Displayed);
                Assert.True(NavBarAboutLinkElement.Displayed);
                Assert.True(NavBarHelpLinkElement.Displayed);
                Assert.True(NavBarRegisterLinkElement.Displayed);
                Assert.True(NavBarLoginLinkElement.Displayed);

                Assert.Equal("HOME", NavBarHomeLinkElement.Text);
                Assert.Equal("FEATURES", NavBarFeaturesLinkElement.Text);
                Assert.Equal("ABOUT", NavBarAboutLinkElement.Text);
                Assert.Equal("HELP CENTER", NavBarHelpLinkElement.Text);
                Assert.Equal("REGISTER", NavBarRegisterLinkElement.Text);
                Assert.Equal("LOGIN", NavBarLoginLinkElement.Text);
                                    }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
                [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdCheckLoginImagesAreDisplayed()
            {
                            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdCheckLoginImagesAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdLoginUrl = UrlRefLibrary.GetLoginPageProdHostUrl();

                driver.Navigate().GoToUrl(ProdLoginUrl);
                driver.Manage().Window.Maximize();
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginPageBanner")));
                IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_LayoutPageLogoImg"));
                IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));

                Assert.True(BannerImageElement.Displayed);
                Assert.True(_LayoutPageLogoElement.Displayed);
                Assert.True(BodyBackground.Displayed);
                                            }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
            [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdCheckLoginNavBarIsDisplayed()
            {
                                    using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdCheckLoginNavBarIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdLoginUrl = UrlRefLibrary.GetLoginPageProdHostUrl();

                driver.Navigate().GoToUrl(ProdLoginUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar")));
                IWebElement NavBarHomeLinkElement = driver.FindElement(By.Id("_LayoutPageHomeNavLink"));
                IWebElement NavBarFeaturesLinkElement = driver.FindElement(By.Id("_LayoutPageFeaturesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_LayoutPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_LayoutPageHelpNavLink"));
                IWebElement NavBarRegisterLinkElement = driver.FindElement(By.Id("_LoginPartialRegister"));
                IWebElement NavBarLoginLinkElement = driver.FindElement(By.Id("_LoginPartialLogin"));

                Assert.True(NavBarElement.Displayed);
                Assert.True(NavBarHomeLinkElement.Displayed);
                Assert.True(NavBarFeaturesLinkElement.Displayed);
                Assert.True(NavBarAboutLinkElement.Displayed);
                Assert.True(NavBarHelpLinkElement.Displayed);
                Assert.True(NavBarRegisterLinkElement.Displayed);
                Assert.True(NavBarLoginLinkElement.Displayed);
                                                    }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
            [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdCheckLoginButtonsAreDisplayed()
            {
                                            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdCheckLoginButtonsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdLoginUrl = UrlRefLibrary.GetLoginPageProdHostUrl();

                driver.Navigate().GoToUrl(ProdLoginUrl);
                driver.Manage().Window.Maximize();
                IWebElement LoginButton = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginButton")));
                IWebElement ResendEmailButton = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ResendEmailButton")));

                Assert.True(LoginButton.Displayed);
                Assert.True(ResendEmailButton.Displayed);
                                                            }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
            [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdCheckLinksAreDisplayed()
            {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdCheckLinksAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdLoginUrl = UrlRefLibrary.GetLoginPageProdHostUrl();

                driver.Navigate().GoToUrl(ProdLoginUrl);
                driver.Manage().Window.Maximize();
                IWebElement LoginForgotPasswordLink = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginForgotPasswordLink")));
                IWebElement RegisterAsNewUserLink = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("RegisterAsNewUserLink")));

                Assert.True(LoginForgotPasswordLink.Displayed);
                Assert.True(RegisterAsNewUserLink.Displayed);
            }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
            [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdCheckLoginTextSectionsAreDisplayed()
            {
                    using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdCheckLoginTextSectionsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdLoginUrl = UrlRefLibrary.GetLoginPageProdHostUrl();

                driver.Navigate().GoToUrl(ProdLoginUrl);
                driver.Manage().Window.Maximize();
                IWebElement LoginPageTitle = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginPageTitle")));
                IWebElement LoginPageSubtitle = driver.FindElement(By.Id("LoginPageSubtitle"));
                IWebElement LoginHeading = driver.FindElement(By.Id("LoginHeading"));
                IWebElement LoginEmailHeading = driver.FindElement(By.Id("LoginEmailHeading"));
                IWebElement LoginPasswordHeading = driver.FindElement(By.Id("LoginPasswordHeading"));
                IWebElement LoginRememberMeCheckbox = driver.FindElement(By.Id("LoginRememberMe"));
                IWebElement LoginUseAnotherServiceHeading = driver.FindElement(By.Id("LoginUseAnotherService"));

                Assert.True(LoginPageTitle.Displayed);
                Assert.True(LoginPageSubtitle.Displayed);
                Assert.True(LoginHeading.Displayed);
                Assert.True(LoginEmailHeading.Displayed);
                Assert.True(LoginPasswordHeading.Displayed);
                Assert.True(LoginRememberMeCheckbox.Displayed);
                Assert.True(LoginUseAnotherServiceHeading.Displayed);
                    }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged In")]
            [Trait("AuthState", "Logged In")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdCheckLoginFieldValidation()
            {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdCheckLoginFieldValidation";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdLoginUrl = UrlRefLibrary.GetLoginPageProdHostUrl();
                string EmailFieldValidation = "The Email field is required.";
                string EmailFieldValidation2 = "The Email field is not a valid e-mail address.";
                string PasswordFieldValidation = "The Password field is required.";
                var CrossPageSharedUITestStrings = new CrossPageSharedUITestStrings();
                string Test2UserEmail = CrossPageSharedUITestStrings.Test2UserEmail();
                string Test2UserPassword = CrossPageSharedUITestStrings.Test2UserPassword();

                driver.Navigate().GoToUrl(ProdLoginUrl);
                driver.Manage().Window.Maximize();
                IWebElement LoginEmailValidationLabel = driver.FindElement(By.Id("LoginEmailValidationLabel"));
                IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
                IWebElement LoginPasswordValidationLabel = driver.FindElement(By.Id("LoginPasswordValidationLabel"));
                IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
                IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Keys.Tab);
                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Keys.Tab);

                LoginButton.Click();

                Assert.True(LoginEmailValidationLabel.Displayed);
                Assert.True(LoginPasswordValidationLabel.Displayed);
                Assert.Equal(LoginEmailValidationLabel.Text, EmailFieldValidation);
                Assert.Equal(LoginPasswordValidationLabel.Text, PasswordFieldValidation);

                LoginEmailInputField.SendKeys("abcd");
                Assert.Equal(LoginEmailValidationLabel.Text, EmailFieldValidation2);

                LoginPasswordInputField.SendKeys("abcd");
                LoginPasswordInputField.SendKeys(Keys.Tab);
                Assert.False(LoginPasswordValidationLabel.Displayed);

                LoginEmailInputField.Clear();
                LoginEmailInputField.SendKeys(Test2UserEmail);
                LoginEmailInputField.SendKeys(Keys.Tab);
                Assert.False(LoginEmailValidationLabel.Displayed);

                LoginPasswordInputField.Clear();
                LoginPasswordInputField.SendKeys(Test2UserPassword);
                LoginPasswordInputField.SendKeys(Keys.Tab);
                Assert.False(LoginPasswordValidationLabel.Displayed);
                            }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
            [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdCheckLoginFooterIsDisplayed()
            {
                    using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdCheckLoginFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdLoginUrl = UrlRefLibrary.GetLoginPageProdHostUrl();

                driver.Navigate().GoToUrl(ProdLoginUrl);
                driver.Manage().Window.Maximize();
                IWebElement FooterElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("nav-footer")));
                IWebElement CopyrightListItemElement = driver.FindElement(By.Id("_LayoutCopyrightFooterLabel"));
                IWebElement RegisterFooterLink = driver.FindElement(By.Id("_LayoutRegisterFooterLink"));
                IWebElement AboutFooterLink = driver.FindElement(By.Id("_LayoutAboutFooterLink"));
                IWebElement BlogFooterLink = driver.FindElement(By.Id("_LayoutBlogFooterLink"));
                IWebElement PrivacyFooterLink = driver.FindElement(By.Id("_LayoutPrivacyFooterLink"));
                IWebElement CookiesFooterLink = driver.FindElement(By.Id("_LayoutCookiesFooterLink"));

                Assert.True(FooterElement.Displayed);
                Assert.True(CopyrightListItemElement.Displayed);
                Assert.True(RegisterFooterLink.Displayed);
                Assert.True(AboutFooterLink.Displayed);
                Assert.True(BlogFooterLink.Displayed);
                Assert.True(PrivacyFooterLink.Displayed);
                Assert.True(CookiesFooterLink.Displayed);
                                    }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
            [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdCheckRegisterImagesAreDisplayed()
            {
                            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdCheckRegisterImagesAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdRegisterUrl = UrlRefLibrary.GetRegisterPageProdHostUrl();

                driver.Navigate().GoToUrl(ProdRegisterUrl);
                driver.Manage().Window.Maximize();
                IWebElement BannerImageElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("RegisterPageBanner")));
                IWebElement _LayoutPageLogoElement = driver.FindElement(By.Id("_LayoutPageLogoImg"));
                IWebElement BodyBackground = driver.FindElement(By.CssSelector("[class='body-bg-img']"));

                Assert.True(BannerImageElement.Displayed);
                Assert.True(_LayoutPageLogoElement.Displayed);
                Assert.True(BodyBackground.Displayed);
                                            }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
            [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdCheckRegisterNavBarIsDisplayed()
            {
                                    using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdCheckRegisterNavBarIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdRegisterUrl = UrlRefLibrary.GetRegisterPageProdHostUrl();

                driver.Navigate().GoToUrl(ProdRegisterUrl);
                driver.Manage().Window.Maximize();
                IWebElement NavBarElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("main-navbar")));
                IWebElement NavBarHomeLinkElement = driver.FindElement(By.Id("_LayoutPageHomeNavLink"));
                IWebElement NavBarFeaturesLinkElement = driver.FindElement(By.Id("_LayoutPageFeaturesNavLink"));
                IWebElement NavBarAboutLinkElement = driver.FindElement(By.Id("_LayoutPageAboutNavLink"));
                IWebElement NavBarHelpLinkElement = driver.FindElement(By.Id("_LayoutPageHelpNavLink"));
                IWebElement NavBarRegisterLinkElement = driver.FindElement(By.Id("_LoginPartialRegister"));
                IWebElement NavBarLoginLinkElement = driver.FindElement(By.Id("_LoginPartialLogin"));

                Assert.True(NavBarElement.Displayed);
                Assert.True(NavBarHomeLinkElement.Displayed);
                Assert.True(NavBarFeaturesLinkElement.Displayed);
                Assert.True(NavBarAboutLinkElement.Displayed);
                Assert.True(NavBarHelpLinkElement.Displayed);
                Assert.True(NavBarRegisterLinkElement.Displayed);
                Assert.True(NavBarLoginLinkElement.Displayed);
                                                    }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
            [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdCheckRegisterButtonsAreDisplayed()
            {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdCheckRegisterButtonsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdRegisterUrl = UrlRefLibrary.GetRegisterPageProdHostUrl();

                driver.Navigate().GoToUrl(ProdRegisterUrl);
                driver.Manage().Window.Maximize();
                IWebElement RegisterButton = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("RegisterButton")));

                Assert.True(RegisterButton.Displayed);
            }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
            [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdCheckRegisterTextSectionsAreDisplayed()
            {
                    using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdCheckRegisterTextSectionsAreDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdRegisterUrl = UrlRefLibrary.GetRegisterPageProdHostUrl();

                driver.Navigate().GoToUrl(ProdRegisterUrl);
                driver.Manage().Window.Maximize();
                IWebElement TitleElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("RegisterPageTitle")));
                IWebElement SubTitleElement = driver.FindElement(By.Id("RegisterPageSubtitle"));
                IWebElement CreateANewAccountHeadingElement = driver.FindElement(By.Id("CreateNewAccountHeading"));
                IWebElement EmailHeadingElement = driver.FindElement(By.Id("RegistrationEmailHeading"));
                IWebElement PasswordHeadingElement = driver.FindElement(By.Id("RegistrationPasswordHeading"));
                IWebElement ConfirmPasswordHeadingElement = driver.FindElement(By.Id("RegistrationConfirmPasswordHeading"));
                IWebElement RegisterUseAnotherServiceHeading = driver.FindElement(By.Id("RegisterUseAnotherService"));

                Assert.True(TitleElement.Displayed);
                Assert.True(SubTitleElement.Displayed);
                Assert.True(CreateANewAccountHeadingElement.Displayed);
                Assert.True(EmailHeadingElement.Displayed);
                Assert.True(PasswordHeadingElement.Displayed);
                Assert.True(ConfirmPasswordHeadingElement.Displayed);
                Assert.True(RegisterUseAnotherServiceHeading.Displayed);
                    }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
            [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdCheckRegisterFieldValidation()
            {
                            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdCheckRegisterFieldValidation";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdRegisterUrl = UrlRefLibrary.GetRegisterPageProdHostUrl();
                string EmailFieldValidation = "The Email field is required.";
                string EmailFieldValidation2 = "The Email field is not a valid e-mail address.";
                string PasswordFieldValidation = "The Password field is required.";

                driver.Navigate().GoToUrl(ProdRegisterUrl);
                driver.Manage().Window.Maximize();
                IWebElement EmailValidationLabel = driver.FindElement(By.Id("RegistrationEmailValidationLabel"));
                IWebElement EmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("RegistrationEmailInputField")));
                IWebElement PasswordValidationLabel = driver.FindElement(By.Id("RegistrationPasswordValidationLabel"));
                IWebElement PasswordInputField = driver.FindElement(By.Id("RegistrationPasswordInputField"));
                IWebElement ConfirmPasswordValidationLabel = driver.FindElement(By.Id("RegistrationConfirmPasswordValidationLabel"));
                IWebElement ConfirmPasswordInputField = driver.FindElement(By.Id("RegistrationConfirmPasswordInputField"));
                IWebElement RegisterButton = driver.FindElement(By.Id("RegisterButton"));

                RegisterButton.Click();

                Assert.True(EmailValidationLabel.Displayed);
                Assert.True(PasswordValidationLabel.Displayed);
                Assert.Equal(EmailValidationLabel.Text, EmailFieldValidation);
                Assert.Equal(PasswordValidationLabel.Text, PasswordFieldValidation);

                EmailInputField.SendKeys("abcd");
                Assert.Equal(EmailValidationLabel.Text, EmailFieldValidation2);

                ConfirmPasswordInputField.SendKeys("abcd");
                Assert.False(ConfirmPasswordValidationLabel.Displayed);

                EmailInputField.SendKeys("diarmaidmurphy1@gmail.com");
                Assert.False(EmailValidationLabel.Displayed);

                PasswordInputField.Clear();
                PasswordInputField.SendKeys("abcd1234");
                PasswordInputField.SendKeys(Keys.Tab);
                Assert.False(PasswordValidationLabel.Displayed);
                Assert.True(ConfirmPasswordValidationLabel.Displayed);

                ConfirmPasswordInputField.SendKeys("abcd1234");
                ConfirmPasswordInputField.SendKeys(Keys.Tab);
                Assert.False(ConfirmPasswordValidationLabel.Displayed);
                            }, filename, driver);
            }

            [Fact]
            [Trait("Category", "Smoke Logged Out")]
            [Trait("AuthState", "Logged Out")]
            [Trait("Owner", "DM")]
            [Trait("RunTime", "Medium")]
            [Trait("TestEnvironment", "Prod")]
            public void ProdCheckRegisterFooterIsDisplayed()
            {
                                    using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdCheckRegisterFooterIsDisplayed";

            TakeTestFailScreenshot.UITest(() =>
            {
                var UrlRefLibrary = new UrlStrings();
                string ProdRegisterUrl = UrlRefLibrary.GetRegisterPageProdHostUrl();

                driver.Navigate().GoToUrl(ProdRegisterUrl);
                driver.Manage().Window.Maximize();
                IWebElement FooterElement = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("nav-footer")));
                IWebElement CopyrightListItemElement = driver.FindElement(By.Id("_LayoutCopyrightFooterLabel"));
                IWebElement RegisterFooterLink = driver.FindElement(By.Id("_LayoutRegisterFooterLink"));
                IWebElement AboutFooterLink = driver.FindElement(By.Id("_LayoutAboutFooterLink"));
                IWebElement BlogFooterLink = driver.FindElement(By.Id("_LayoutBlogFooterLink"));
                IWebElement PrivacyFooterLink = driver.FindElement(By.Id("_LayoutPrivacyFooterLink"));
                IWebElement CookiesFooterLink = driver.FindElement(By.Id("_LayoutCookiesFooterLink"));

                Assert.True(FooterElement.Displayed);
                Assert.True(CopyrightListItemElement.Displayed);
                Assert.True(RegisterFooterLink.Displayed);
                Assert.True(AboutFooterLink.Displayed);
                Assert.True(BlogFooterLink.Displayed);
                Assert.True(PrivacyFooterLink.Displayed);
                Assert.True(CookiesFooterLink.Displayed);
                                    }, filename, driver);
            }

        [Fact]
            [Trait("Category", "Smoke Logged In")]
            [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Prod")]
        public void ProdSuccessfulUserLoginLogout()
        {
            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdSuccessfulUserLoginLogout";

            TakeTestFailScreenshot.UITest(() =>
            {
            var UrlRefLibrary = new UrlStrings();
            string ProdLoginUrl = UrlRefLibrary.GetLoginPageProdHostUrl();
            string UserEmail = UITestStrings.Test2UserEmail();
            string UserPassword = UITestStrings.Test2UserPassword();
            string Logout = SharedLocSourceNames.GetLocSourceLogoutLabelNameReference();
            string Register = SharedLocSourceNames.GetLocSourceRegisterLabelNameReference();
            string Login = SharedLocSourceNames.GetLocSourceLoginLabelNameReference();
            string ProdHomepageUrl = UrlRefLibrary.GetHomePageProdHostUrl();

            driver.Navigate().GoToUrl(ProdLoginUrl);
            driver.Manage().Window.Maximize();
            IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
            IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
            IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));

            LoginEmailInputField.Clear();
            LoginEmailInputField.SendKeys(Keys.Tab);
            LoginPasswordInputField.Clear();
            LoginPasswordInputField.SendKeys(Keys.Tab);

            LoginEmailInputField.SendKeys(UserEmail);
            LoginPasswordInputField.SendKeys(UserPassword);

            LoginButton.Click();
            IWebElement LoggedInUserLabel = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialLoggedInUserEmail")));
            IWebElement _LoginPartialLogoutButton = driver.FindElement(By.Id("_LoginPartialLogoutButton"));
            String currentUrl = driver.Url;

            Assert.Equal(ProdHomepageUrl, currentUrl);
            Assert.Equal(UserEmail.ToUpper(), LoggedInUserLabel.Text);
            Assert.True(LoggedInUserLabel.Displayed);
            Assert.Equal(Logout.ToUpper(), _LoginPartialLogoutButton.Text);
            Assert.True(_LoginPartialLogoutButton.Displayed);

            _LoginPartialLogoutButton.Click();
            IWebElement _LoginPartialRegister = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("_LoginPartialRegister")));
            IWebElement _LoginPartialLogin = driver.FindElement(By.Id("_LoginPartialLogin"));

            Assert.Equal(ProdHomepageUrl, currentUrl);
            Assert.Equal(Register.ToUpper(), _LoginPartialRegister.Text);
            Assert.True(_LoginPartialRegister.Displayed);
            Assert.Equal(Login.ToUpper(), _LoginPartialLogin.Text);
            Assert.True(_LoginPartialLogin.Displayed);
                                            }, filename, driver);
        }

        [Fact]
            [Trait("Category", "Smoke Logged In")]
            [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Prod")]
        public void ProdUnSuccessfulUserLoginEmailStructure()
        {
                    using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_ProdUnSuccessfulUserLoginEmailStructure";

            TakeTestFailScreenshot.UITest(() =>
            {
            var UrlRefLibrary = new UrlStrings();
            string ProdLoginUrl = UrlRefLibrary.GetLoginPageProdHostUrl();
            string UserEmail = "test2@email";
            string UserEmail1 = "test2";
            string UserPassword = UITestStrings.Test2UserPassword();
            string HeadingText = LoginPageLocSourceNames.GetLocSourceHeadingNameReferenceForLoginPage();

            driver.Navigate().GoToUrl(ProdLoginUrl);
            driver.Manage().Window.Maximize();
            IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
            IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
            IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));

            LoginEmailInputField.Clear();
            LoginEmailInputField.SendKeys(Keys.Tab);
            LoginPasswordInputField.Clear();
            LoginPasswordInputField.SendKeys(Keys.Tab);

            LoginEmailInputField.SendKeys(UserEmail);
            LoginPasswordInputField.SendKeys(UserPassword);

            LoginButton.Click();
            IWebElement LoginHeading = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginHeading")));
            String currentUrl = driver.Url;

            Assert.True(LoginHeading.Displayed);
            Assert.Equal(ProdLoginUrl, currentUrl);

            IWebElement LoginEmailInputField1 = driver.FindElement(By.Id("LoginEmailInputField"));
            IWebElement LoginPasswordInputField1 = driver.FindElement(By.Id("LoginEmailInputField"));
            IWebElement LoginButton1 = driver.FindElement(By.Id("LoginButton"));
            LoginEmailInputField1.Clear();
            LoginEmailInputField1.SendKeys(UserEmail1);
            LoginEmailInputField1.SendKeys(Keys.Tab);
            LoginPasswordInputField1.SendKeys(UserPassword);

            LoginButton1.Click();
            IWebElement LoginHeading1 = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginHeading")));
            String currentUrl1 = driver.Url;

            Assert.Equal(ProdLoginUrl, currentUrl1);
            Assert.Equal(LoginHeading1.Text, HeadingText);
                                                    }, filename, driver);
        }

        [Fact]
            [Trait("Category", "Smoke Logged In")]
            [Trait("AuthState", "Logged In")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Medium")]
        [Trait("TestEnvironment", "Prod")]
        public void UnSuccessfulUserLoginIncorrectPassword()
        {
                            using IWebDriver driver = new ChromeDriver();
            var TakeTestFailScreenshot = new TakeTestFailScreenshot();
            var filename = "TestProdCriticalFunctionalities_UnSuccessfulUserLoginIncorrectPassword";

            TakeTestFailScreenshot.UITest(() =>
            {
            var UrlRefLibrary = new UrlStrings();
            string ProdLoginUrl = UrlRefLibrary.GetLoginPageProdHostUrl();
            string UserEmail = UITestStrings.Test2UserEmail();
            string UserPassword = "Test";
            string HeadingText = LoginPageLocSourceNames.GetLocSourceHeadingNameReferenceForLoginPage();

            driver.Navigate().GoToUrl(ProdLoginUrl);
            driver.Manage().Window.Maximize();
            IWebElement LoginEmailInputField = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginEmailInputField")));
            IWebElement LoginPasswordInputField = driver.FindElement(By.Id("LoginPasswordInputField"));
            IWebElement LoginButton = driver.FindElement(By.Id("LoginButton"));

            LoginEmailInputField.Clear();
            LoginEmailInputField.SendKeys(Keys.Tab);
            LoginPasswordInputField.Clear();
            LoginPasswordInputField.SendKeys(Keys.Tab);

            LoginEmailInputField.SendKeys(UserEmail);
            LoginPasswordInputField.SendKeys(UserPassword);

            LoginButton.Click();
            IWebElement LoginHeading = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("LoginHeading")));
            String currentUrl = driver.Url;

            Assert.Equal(ProdLoginUrl, currentUrl);
            Assert.Equal(LoginHeading.Text, HeadingText);
            }, filename, driver);
        }

        */
    }
}
