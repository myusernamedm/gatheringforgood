using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestPersonalDataPageLocSourceNames
    {

        private readonly ISharedCultureLocalizer _loc;

        public TestPersonalDataPageLocSourceNames()
        {
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePageTabTitleNameReferenceForPersonalDataPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "My Account", null);
            var DeletePersonalDataPageLocSourceNamesLibrary = new DeletePersonalDataPageLocSourceNames();
            string ReturnedNameKeyValue = DeletePersonalDataPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForDeletePersonalDataPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForPersonalDataPageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "Manage Your GatheringForGood Account", null);
            var DeletePersonalDataPageLocSourceNamesLibrary = new DeletePersonalDataPageLocSourceNames();
            string ReturnedNameKeyValue = DeletePersonalDataPageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForDeletePersonalDataPage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubtitleNameReferenceForPersonalDataPageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "My Account", null);
            var DeletePersonalDataPageLocSourceNamesLibrary = new DeletePersonalDataPageLocSourceNames();
            string ReturnedNameKeyValue = DeletePersonalDataPageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForDeletePersonalDataPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHeadingNameReferenceForPersonalDataPageIsCorrect()
        {
            string Heading = _loc.GetLocalizedString("en", "Change your account settings", null);
            var DeletePersonalDataPageLocSourceNamesLibrary = new DeletePersonalDataPageLocSourceNames();
            string ReturnedNameKeyValue = DeletePersonalDataPageLocSourceNamesLibrary.GetLocSourceHeadingNameReferenceForDeletePersonalDataPage();
            Assert.Equal(Heading, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePersonalDataPara1NameReferenceForPersonalDataPageIsCorrect()
        {
            string PersonalDataPara1 = _loc.GetLocalizedString("en", "Your account contains personal data that you have given us.", null);
            var DeletePersonalDataPageLocSourceNamesLibrary = new DeletePersonalDataPageLocSourceNames();
            string ReturnedNameKeyValue = DeletePersonalDataPageLocSourceNamesLibrary.GetLocSourcePersonalDataPara1NameReferenceForDeletePersonalDataPage();
            Assert.Equal(PersonalDataPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSetupPersonalDataPara2NameReferenceForPersonalDataPage()
        {
            string PersonalDataPara2 = _loc.GetLocalizedString("en", "This page allows you to download or delete that data.", null);
            var DeletePersonalDataPageLocSourceNamesLibrary = new DeletePersonalDataPageLocSourceNames();
            string ReturnedNameKeyValue = DeletePersonalDataPageLocSourceNamesLibrary.GetLocSourcePersonalDataPara2NameReferenceForDeletePersonalDataPage();
            Assert.Equal(PersonalDataPara2, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDeleteDataPara1NameReferenceForPersonalDataPage()
        {
            string DeleteDataPara1 = _loc.GetLocalizedString("en", "Deleting this data will permanently", null);
            var DeletePersonalDataPageLocSourceNamesLibrary = new DeletePersonalDataPageLocSourceNames();
            string ReturnedNameKeyValue = DeletePersonalDataPageLocSourceNamesLibrary.GetLocSourceDeleteDataPara1NameReferenceForDeletePersonalDataPage();
            Assert.Equal(DeleteDataPara1, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDeleteDataPara2NameReferenceForPersonalDataPage()
        {
            string DeleteDataPara2 = _loc.GetLocalizedString("en", "remove your account.", null);
            var DeletePersonalDataPageLocSourceNamesLibrary = new DeletePersonalDataPageLocSourceNames();
            string ReturnedNameKeyValue = DeletePersonalDataPageLocSourceNamesLibrary.GetLocSourceDeleteDataPara2NameReferenceForDeletePersonalDataPage();
            Assert.Equal(DeleteDataPara2, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDeleteDataPara3NameReferenceForPersonalDataPage()
        {
            string DeleteDataPara3 = _loc.GetLocalizedString("en", "This cannot be recovered.", null);
            var DeletePersonalDataPageLocSourceNamesLibrary = new DeletePersonalDataPageLocSourceNames();
            string ReturnedNameKeyValue = DeletePersonalDataPageLocSourceNamesLibrary.GetLocSourceDeleteDataPara3NameReferenceForDeletePersonalDataPage();
            Assert.Equal(DeleteDataPara3, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDownloadButtonTextNameReferenceForPersonalDataPage()
        {
            string DownloadButtonText = _loc.GetLocalizedString("en", "Download", null);
            var DeletePersonalDataPageLocSourceNamesLibrary = new DeletePersonalDataPageLocSourceNames();
            string ReturnedNameKeyValue = DeletePersonalDataPageLocSourceNamesLibrary.GetLocSourceDownloadButtonTextNameReferenceForDeletePersonalDataPage();
            Assert.Equal(DownloadButtonText, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDeleteAccountButtonTextNameReferenceForPersonalDataPage()
        {
            string DeleteAccountButtonText = _loc.GetLocalizedString("en", "Delete data and close my account", null);
            var DeletePersonalDataPageLocSourceNamesLibrary = new DeletePersonalDataPageLocSourceNames();
            string ReturnedNameKeyValue = DeletePersonalDataPageLocSourceNamesLibrary.GetLocSourceDeleteAccountButtonTextNameReferenceForDeletePersonalDataPage();
            Assert.Equal(DeleteAccountButtonText, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDeleteButtonTextNameReferenceForPersonalDataPage()
        {
            string DeleteButtonText = _loc.GetLocalizedString("en", "Delete", null);
            var DeletePersonalDataPageLocSourceNamesLibrary = new DeletePersonalDataPageLocSourceNames();
            string ReturnedNameKeyValue = DeletePersonalDataPageLocSourceNamesLibrary.GetLocSourceDeleteButtonTextNameReferenceForDeletePersonalDataPage();
            Assert.Equal(DeleteButtonText, ReturnedNameKeyValue);
        }
    }
}