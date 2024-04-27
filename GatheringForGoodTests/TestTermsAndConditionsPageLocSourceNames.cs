using System;
using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestTermsAndConditionsPageLocSourceNames
    {

        private readonly ISharedCultureLocalizer _loc;

        public TestTermsAndConditionsPageLocSourceNames()
        {
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePageTabTitleNameReferenceForTermsAndConditionsPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Terms and Conditions", null);
            var TermsAndConditionsPageLocSourceNamesLibrary = new TermsAndConditionsPageLocSourceNames();
            string ReturnedNameKeyValue = TermsAndConditionsPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForTermsAndConditionsPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForTermsAndConditionsPageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "Terms and Conditions of Use", null);
            var TermsAndConditionsPageLocSourceNamesLibrary = new TermsAndConditionsPageLocSourceNames();
            string ReturnedNameKeyValue = TermsAndConditionsPageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForTermsAndConditionsPage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubtitleNameReferenceForTermsAndConditionsPageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Terms and Conditions", null);
            var TermsAndConditionsPageLocSourceNamesLibrary = new TermsAndConditionsPageLocSourceNames();
            string ReturnedNameKeyValue = TermsAndConditionsPageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForTermsAndConditionsPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHeadingNameReferenceForTermsAndConditionsPageIsCorrect()
        {
            string Heading = _loc.GetLocalizedString("en", "Terms and Conditions of Use", null);
            var TermsAndConditionsPageLocSourceNamesLibrary = new TermsAndConditionsPageLocSourceNames();
            string ReturnedNameKeyValue = TermsAndConditionsPageLocSourceNamesLibrary.GetLocSourceHeadingNameReferenceForTermsAndConditionsPage();
            Assert.Equal(Heading, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTandCEffectiveDateNameReferenceForTermsAndConditionsPageIsCorrect()
        {
            string TandCEffectiveDate = _loc.GetLocalizedString("en", "Effective October 01st 2021", null);
            var TermsAndConditionsPageLocSourceNamesLibrary = new TermsAndConditionsPageLocSourceNames();
            string ReturnedNameKeyValue = TermsAndConditionsPageLocSourceNamesLibrary.GetLocSourceTandCEffectiveDateNameReferenceForTermsAndConditionsPage();
            Assert.Equal(TandCEffectiveDate, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAgreeInFullNameReferenceForTermsAndConditionsPageIsCorrect()
        {
            string AgreeInFull = _loc.GetLocalizedString("en", "By using this website and our services you agree to these terms and conditions in full.", null);
            var TermsAndConditionsPageLocSourceNamesLibrary = new TermsAndConditionsPageLocSourceNames();
            string ReturnedNameKeyValue = TermsAndConditionsPageLocSourceNamesLibrary.GetLocSourceAgreeInFullNameReferenceForTermsAndConditionsPage();
            Assert.Equal(AgreeInFull, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAppropriateUseNameReferenceForTermsAndConditionsPageIsCorrect()
        {
            string AppropriateUse = _loc.GetLocalizedString("en", "You agree that your use of our services will be subject GatheringForGoods judgement of 'Appropriate Use' which may change on an ongoing basis.", null);
            var TermsAndConditionsPageLocSourceNamesLibrary = new TermsAndConditionsPageLocSourceNames();
            string ReturnedNameKeyValue = TermsAndConditionsPageLocSourceNamesLibrary.GetLocSourceAppropriateUseNameReferenceForTermsAndConditionsPage();
            Assert.Equal(AppropriateUse, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAppropriateUseGuideNameReferenceForTermsAndConditionsPageIsCorrect()
        {
            string AppropriateUseGuide = _loc.GetLocalizedString("en", "Notwithstanding the above and as a guideline; 'Appropriate Use' means that you will not use our services to share, post or promote any illegal communication, content or activities. GatheringForGood is a safe space where people can collaborate in an effort to reverse the damage humans have done to our planet, and to try to ensure the planet remains habitable for all life into the distant future. You will not engage in behaviour towards other users which we may deem offensive, or which does not align with liberal western democratic values of tolerance and acceptance or which otherwise does not align with our mission, promise or essence.", null);
            var TermsAndConditionsPageLocSourceNamesLibrary = new TermsAndConditionsPageLocSourceNames();
            string ReturnedNameKeyValue = TermsAndConditionsPageLocSourceNamesLibrary.GetLocSourceAppropriateUseGuideNameReferenceForTermsAndConditionsPage();
            Assert.Equal(AppropriateUseGuide, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRightofAccountClosureNameReferenceForTermsAndConditionsPageIsCorrect()
        {
            string RightofAccountClosure = _loc.GetLocalizedString("en", "GatheringForGood retains the full and unequivocal right to close the accounts of any customers and/or users without prior notice at any time, and retains the right to temporarily or permanently suspend or otherwise prevent such customers or users from further access to our services.", null);
            var TermsAndConditionsPageLocSourceNamesLibrary = new TermsAndConditionsPageLocSourceNames();
            string ReturnedNameKeyValue = TermsAndConditionsPageLocSourceNamesLibrary.GetLocSourceRightofAccountClosureNameReferenceForTermsAndConditionsPage();
            Assert.Equal(RightofAccountClosure, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceNaturalWorldNameReferenceForTermsAndConditionsPageIsCorrect()
        {
            string NaturalWorld = _loc.GetLocalizedString("en", "GatheringForGood's services and products are focused on benefits to the natural world. While there may be many individual interpretations of what is 'Good' and worth gathering for, GatheringForGood retains the right to remove any communication, content or other material which we feel is not aligned with the core purpose, mission, promise or essence of our organisation, community, customers and members.", null);
            var TermsAndConditionsPageLocSourceNamesLibrary = new TermsAndConditionsPageLocSourceNames();
            string ReturnedNameKeyValue = TermsAndConditionsPageLocSourceNamesLibrary.GetLocSourceNaturalWorldClosureNameReferenceForTermsAndConditionsPage();
            Assert.Equal(NaturalWorld, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTandCUpdatesNameReferenceForTermsAndConditionsPageIsCorrect()
        {
            string TandCUpdates = _loc.GetLocalizedString("en", "These terms and conditions will be updated regularly and you agree to check this page periodically to ensure you remain familiar with same.", null);
            var TermsAndConditionsPageLocSourceNamesLibrary = new TermsAndConditionsPageLocSourceNames();
            string ReturnedNameKeyValue = TermsAndConditionsPageLocSourceNamesLibrary.GetLocSourceTandCUpdatesNameReferenceForTermsAndConditionsPage();
            Assert.Equal(TandCUpdates, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTandCObituariesAndViolenceNameReferenceForTermsAndConditionsPageIsCorrect()
        {
            string TandCObituariesAndViolence = _loc.GetLocalizedString("en", "No content promoting terrorism or violence against civilians is permitted on this website. Users also agree that obituaries will not be posted without prior permission from GatheringForGood.", null);
            var TermsAndConditionsPageLocSourceNamesLibrary = new TermsAndConditionsPageLocSourceNames();
            string ReturnedNameKeyValue = TermsAndConditionsPageLocSourceNamesLibrary.GetLocSourceTandCObituariesAndViolenceNameReferenceForTermsAndConditionsPage();
            Assert.Equal(TandCObituariesAndViolence, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTandCDiscriminationNameReferenceForTermsAndConditionsPageIsCorrect()
        {
            string TandCDiscrimination = _loc.GetLocalizedString("en", "You agree that your posts will not promote discrimation, nor discriminate. We do not tolerate discrimation, positive nor negative on the GatheringForGood website.", null);
            var TermsAndConditionsPageLocSourceNamesLibrary = new TermsAndConditionsPageLocSourceNames();
            string ReturnedNameKeyValue = TermsAndConditionsPageLocSourceNamesLibrary.GetLocSourceTandCDiscriminationNameReferenceForTermsAndConditionsPage();
            Assert.Equal(TandCDiscrimination, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTandCAnalyticsNameReferenceForTermsAndConditionsPageIsCorrect()
        {
            string TandCAnalytics = _loc.GetLocalizedString("en", "GatheringForGood gathers analytics data to improve our product offerings and user experience. If you choose to delete your personal data, GatheringForGood will retain anonymised usage statistics and analytics data for our offerings to allow us to continue to improve our services.", null);
            var TermsAndConditionsPageLocSourceNamesLibrary = new TermsAndConditionsPageLocSourceNames();
            string ReturnedNameKeyValue = TermsAndConditionsPageLocSourceNamesLibrary.GetLocSourceTandCAnalyticsNameReferenceForTermsAndConditionsPage();
            Assert.Equal(TandCAnalytics, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSavingDataNameNameReferenceForTermsAndConditionsPageIsCorrect()
        {
            string SavingDataName = _loc.GetLocalizedString("en", "GatheringForGood may retain data submitted via our website, email, and also including data submitted via our contact form so that the data can be used to help us improve our services and support. Retained data may include data which does not allow us to personally identify you.", null);
            var TermsAndConditionsPageLocSourceNamesLibrary = new TermsAndConditionsPageLocSourceNames();
            string ReturnedNameKeyValue = TermsAndConditionsPageLocSourceNamesLibrary.GetLocSourceSavingDataNameReferenceForTermsAndConditionsPage();
            Assert.Equal(SavingDataName, ReturnedNameKeyValue);
        }
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOneAccountPerPersonNameReferenceForTermsAndConditionsPageIsCorrect()
        {
            string OneAccountPerPersonName = _loc.GetLocalizedString("en", "Accounts must only be created and owned by a real person or business. You can own up to two (2) accounts in total: a maximum of one account per person is permitted, plus a maximum of one account per registered business.", null);
            var TermsAndConditionsPageLocSourceNamesLibrary = new TermsAndConditionsPageLocSourceNames();
            string ReturnedNameKeyValue = TermsAndConditionsPageLocSourceNamesLibrary.GetLocSourceOneAccountPerPersonNameReferenceForTermsAndConditionsPage();
            Assert.Equal(OneAccountPerPersonName, ReturnedNameKeyValue);
        }
    }
}
