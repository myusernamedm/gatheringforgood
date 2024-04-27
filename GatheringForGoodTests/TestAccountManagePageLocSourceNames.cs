using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestAccountManagePageLocSourceNames
    {
        private readonly ISharedCultureLocalizer _loc;

        public TestAccountManagePageLocSourceNames()
        {
            var ci = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.LCID);
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = ci;
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = ci;
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePageTabTitleNameReferenceForAboutPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "My Account", null);
            var AccountManagePageLocSourceNamesLibrary = new AccountManagePageLocSourceNames();
            string ReturnedNameKeyValue = AccountManagePageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForAccountManagePage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForAboutPageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "Manage Your GatheringForGood Account", null);
            var AccountManagePageLocSourceNamesLibrary = new AccountManagePageLocSourceNames();
            string ReturnedNameKeyValue = AccountManagePageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForAccountManagePage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubtitleNameReferenceForAboutPageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "My Account", null);
            var AccountManagePageLocSourceNamesLibrary = new AccountManagePageLocSourceNames();
            string ReturnedNameKeyValue = AccountManagePageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForAccountManagePage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHeadingNameReferenceForAboutPageIsCorrect()
        {
            string WhereDoesNameComeFromTitle = _loc.GetLocalizedString("en", "Change your account settings", null);
            var AccountManagePageLocSourceNamesLibrary = new AccountManagePageLocSourceNames();
            string ReturnedNameKeyValue = AccountManagePageLocSourceNamesLibrary.GetLocSourceHeadingNameReferenceForAccountManagePage();
            Assert.Equal(WhereDoesNameComeFromTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceUsernameHeadingNameReferenceForAboutPageIsCorrect()
        {
            string WhereDoesNameComeFromPara = _loc.GetLocalizedString("en", "Username", null);
            var AccountManagePageLocSourceNamesLibrary = new AccountManagePageLocSourceNames();
            string ReturnedNameKeyValue = AccountManagePageLocSourceNamesLibrary.GetLocSourceUsernameHeadingNameReferenceForAccountManagePage();
            Assert.Equal(WhereDoesNameComeFromPara, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePhoneNumberHeadingNameReferenceForAboutPage()
        {
            string OurMissionTitle = _loc.GetLocalizedString("en", "Phone number", null);
            var AccountManagePageLocSourceNamesLibrary = new AccountManagePageLocSourceNames();
            string ReturnedNameKeyValue = AccountManagePageLocSourceNamesLibrary.GetLocSourcePhoneNumberHeadingNameReferenceForAccountManagePage();
            Assert.Equal(OurMissionTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSaveButtonTextNameReferenceForAboutPage()
        {
            string OurMissionPara = _loc.GetLocalizedString("en", "Save", null);
            var AccountManagePageLocSourceNamesLibrary = new AccountManagePageLocSourceNames();
            string ReturnedNameKeyValue = AccountManagePageLocSourceNamesLibrary.GetLocSourceSaveButtonTextNameReferenceForAccountManagePage();
            Assert.Equal(OurMissionPara, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceProfileNavButtonNameReferenceForAboutPage()
        {
            string OurPromiseTitle = _loc.GetLocalizedString("en", "Profile", null);
            var AccountManagePageLocSourceNamesLibrary = new AccountManagePageLocSourceNames();
            string ReturnedNameKeyValue = AccountManagePageLocSourceNamesLibrary.GetLocSourceProfileNavButtonNameReferenceForAccountManagePage();
            Assert.Equal(OurPromiseTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceEmailNavButtonNameReferenceForAboutPage()
        {
            string OurPromisePara = _loc.GetLocalizedString("en", "Email", null);
            var AccountManagePageLocSourceNamesLibrary = new AccountManagePageLocSourceNames();
            string ReturnedNameKeyValue = AccountManagePageLocSourceNamesLibrary.GetLocSourceEmailNavButtonNameReferenceForAccountManagePage();
            Assert.Equal(OurPromisePara, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceExternalLoginsNavButtonNameReferenceForAboutPage()
        {
            string OurEssenceTitle = _loc.GetLocalizedString("en", "External Logins", null);
            var AccountManagePageLocSourceNamesLibrary = new AccountManagePageLocSourceNames();
            string ReturnedNameKeyValue = AccountManagePageLocSourceNamesLibrary.GetLocSourceExternalLoginsNavButtonNameReferenceForAccountManagePage();
            Assert.Equal(OurEssenceTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePasswordNavButtonNameReferenceForAboutPage()
        {
            string OurEssencePara = _loc.GetLocalizedString("en", "Password", null);
            var AccountManagePageLocSourceNamesLibrary = new AccountManagePageLocSourceNames();
            string ReturnedNameKeyValue = AccountManagePageLocSourceNamesLibrary.GetLocSourcePasswordNavButtonNameReferenceForAccountManagePage();
            Assert.Equal(OurEssencePara, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTwoFANavButtonNameReferenceForAboutPage()
        {
            string OurEssencePara = _loc.GetLocalizedString("en", "Two-factor Authentication", null);
            var AccountManagePageLocSourceNamesLibrary = new AccountManagePageLocSourceNames();
            string ReturnedNameKeyValue = AccountManagePageLocSourceNamesLibrary.GetLocSourceTwoFANavButtonNameReferenceForAccountManagePage();
            Assert.Equal(OurEssencePara, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePersonalDataNavButtonNameReferenceForAboutPage()
        {
            string OurEssencePara = _loc.GetLocalizedString("en", "Personal Data", null);
            var AccountManagePageLocSourceNamesLibrary = new AccountManagePageLocSourceNames();
            string ReturnedNameKeyValue = AccountManagePageLocSourceNamesLibrary.GetLocSourcePersonalDataNavButtonNameReferenceForAccountManagePage();
            Assert.Equal(OurEssencePara, ReturnedNameKeyValue);
        }
    }
}
