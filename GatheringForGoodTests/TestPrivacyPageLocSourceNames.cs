using System;
using Xunit;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.UnitTests
{
    public class TestPrivacyPageLocSourceNames
    {

        private readonly ISharedCultureLocalizer _loc;

        public TestPrivacyPageLocSourceNames()
        {
            var LocalizerFactoryForTests = new LocalizerFactoryForTests();
            _loc = LocalizerFactoryForTests.InjectLocalizedParameterFromLocSourceFile();
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePageTabTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string PageTabTitle = _loc.GetLocalizedString("en", "Privacy Policy", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePageTabTitleNameReferenceForPrivacyPage();
            Assert.Equal(PageTabTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string Title = _loc.GetLocalizedString("en", "Your Privacy Matters", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceTitleNameReferenceForPrivacyPage();
            Assert.Equal(Title, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSubtitleNameReferenceForPrivacyPageIsCorrect()
        {
            string SubTitle = _loc.GetLocalizedString("en", "Privacy Policy", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceSubtitleNameReferenceForPrivacyPage();
            Assert.Equal(SubTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceYourPrivacyMattersNameReferenceForPrivacyPageIsCorrect()
        {
            string YourPrivacyMatters = _loc.GetLocalizedString("en", "Your Privacy Matters", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceYourPrivacyMattersTitleNameReferenceForPrivacyPage();
            Assert.Equal(YourPrivacyMatters, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePrivacyEffectiveDateNameReferenceForPrivacyPageIsCorrect()
        {
            string PrivacyEffectiveDate = _loc.GetLocalizedString("en", "Effective August 01st 2020", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePrivacyEffectiveDateNameReferenceForPrivacyPage();
            Assert.Equal(PrivacyEffectiveDate, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePrivacyTableOfContentsTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string PrivacyTableOfContentsTitle = _loc.GetLocalizedString("en", "Table of Contents", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePrivacyTableOfContentsTitleNameReferenceForPrivacyPage();
            Assert.Equal(PrivacyTableOfContentsTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePrivacyIntroductionLinkNameReferenceForPrivacyPageIsCorrect()
        {
            string PrivacyIntroductionLink = _loc.GetLocalizedString("en", "Introduction", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePrivacyIntroductionLinkNameReferenceForPrivacyPage();
            Assert.Equal(PrivacyIntroductionLink, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePrivacyDataWeCollectLinkNameReferenceForPrivacyPageIsCorrect()
        {
            string PrivacyDataWeCollectLink = _loc.GetLocalizedString("en", "What Data Do We Collect?", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePrivacyDataWeCollectLinkNameReferenceForPrivacyPage();
            Assert.Equal(PrivacyDataWeCollectLink, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePrivacyHowWeUseYourDataLinkNameReferenceForPrivacyPageIsCorrect()
        {
            string PrivacyHowWeUseYourDataLink = _loc.GetLocalizedString("en", "How Do We Use Your Data?", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePrivacyHowWeUseYourDataLinkNameReferenceForPrivacyPage();
            Assert.Equal(PrivacyHowWeUseYourDataLink, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePrivacyHowWeShareInformationLinkNameReferenceForPrivacyPageIsCorrect()
        {
            string PrivacyHowWeShareInformationLink = _loc.GetLocalizedString("en", "How Do We Share Information?", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePrivacyHowWeShareInformationLinkNameReferenceForPrivacyPage();
            Assert.Equal(PrivacyHowWeShareInformationLink, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePrivacyChoicesAndObligationsLinkNameReferenceForPrivacyPageIsCorrect()
        {
            string PrivacyChoicesAndObligationsLink = _loc.GetLocalizedString("en", "Your Choices And Obligations", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePrivacyChoicesAndObligationsLinkNameReferenceForPrivacyPage();
            Assert.Equal(PrivacyChoicesAndObligationsLink, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePrivacyOtherInformationLinkNameReferenceForPrivacyPageIsCorrect()
        {
            string PrivacyOtherInformationLink = _loc.GetLocalizedString("en", "Other Information", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePrivacyOtherInformationLinkNameReferenceForPrivacyPage();
            Assert.Equal(PrivacyOtherInformationLink, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceYourPrivacyMattersPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string YourPrivacyMattersPara1 = _loc.GetLocalizedString("en", "Our mission at GatheringForGood is to create a better world. In order for us to help our users find solutions to the worlds most pressing problems, and to make a positive difference in the world, we are fully committed to being transparent about the data we collect about you; how it is used; and with whom it is shared.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceYourPrivacyMattersPara1NameReferenceForPrivacyPage();
            Assert.Equal(YourPrivacyMattersPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceYourPrivacyMattersPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string YourPrivacyMattersPara2 = _loc.GetLocalizedString("en", "This Privacy Policy applies when you use our 'Services' (described below). We offer our users choices about the data we collect, use and share as described in this Privacy Policy, our Cookie Policy and your user Settings.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceYourPrivacyMattersPara2NameReferenceForPrivacyPage();
            Assert.Equal(YourPrivacyMattersPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceIntroductionShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string IntroductionShortPara = _loc.GetLocalizedString("en", "We are a social network and online platform for good. People use our Services to find and be found for opportunities to do good in the world, to connect with others, to learn and to find information or expertise. Our Privacy Policy applies to any Member or Visitor to our Services.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceIntroductionShortParaNameReferenceForPrivacyPage();
            Assert.Equal(IntroductionShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceIntroductionPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string IntroductionPara1 = _loc.GetLocalizedString("en", "Our registered users (", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceIntroductionPara1NameReferenceForPrivacyPage();
            Assert.Equal(IntroductionPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceIntroductionPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string IntroductionPara2 = _loc.GetLocalizedString("en", ") share their identities, engage with their network, build and participate in communities around their cause, exchange knowledge and insights, post and view relevant content, learn and collaborate on ideas, and find opportunities to change the world. Content and data on some of our Services is viewable to non - members (", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceIntroductionPara2NameReferenceForPrivacyPage();
            Assert.Equal(IntroductionPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceIntroductionPara3NameReferenceForPrivacyPageIsCorrect()
        {
            string IntroductionPara3 = _loc.GetLocalizedString("en", ").", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceIntroductionPara3NameReferenceForPrivacyPage();
            Assert.Equal(IntroductionPara3, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceMembersNameReferenceForPrivacyPageIsCorrect()
        {
            string Members = _loc.GetLocalizedString("en", "Members", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceMembersNameReferenceForPrivacyPage();
            Assert.Equal(Members, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceVisitorsNameReferenceForPrivacyPageIsCorrect()
        {
            string Visitors = _loc.GetLocalizedString("en", "Visitors", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceVisitorsNameReferenceForPrivacyPage();
            Assert.Equal(Visitors, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceServicesTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string ServicesTitle = _loc.GetLocalizedString("en", "Services", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceServicesTitleNameReferenceForPrivacyPage();
            Assert.Equal(ServicesTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceServicesShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string ServicesShortPara = _loc.GetLocalizedString("en", "This Privacy Policy, including our Cookie Policy applies to your use of our", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceServicesShortParaNameReferenceForPrivacyPage();
            Assert.Equal(ServicesShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceServicesPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string ServicesPara1 = _loc.GetLocalizedString("en", "This Privacy Policy applies to gatheringforgood.com, GatheringForGood apps, and other GatheringForGood-related sites, apps, communications and services (", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceServicesPara1NameReferenceForPrivacyPage();
            Assert.Equal(ServicesPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceServicesPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string ServicesPara2 = _loc.GetLocalizedString("en", "), including off-site Services, such as our ad services and the “Apply with GatheringForGood” and “Share with GatheringForGood” plugins, but excluding services that state that they are offered under a different privacy policy.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceServicesPara2NameReferenceForPrivacyPage();
            Assert.Equal(ServicesPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDataControllersTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string DataControllersTitle = _loc.GetLocalizedString("en", "Data Controllers and Contracting Parties", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDataControllersTitleNameReferenceForPrivacyPage();
            Assert.Equal(DataControllersTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDataControllersShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string DataControllersShortPara = _loc.GetLocalizedString("en", "PromoPads Ltd - CRO No. 580203 - is the controller of your personal data.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDataControllersShortParaNameReferenceForPrivacyPage();
            Assert.Equal(DataControllersShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDataControllersPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string DataControllersPara1 = _loc.GetLocalizedString("en", "If you are in the EU, PromoPads Ltd will be the controller of your personal data provided to, or collected by or for, or processed in connection with our Services. If you are outside of the EU, Promo Pads Ltd is also the controller of your personal data provided to, or collected by or for, or processed in connection with, our Services.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDataControllersPara1NameReferenceForPrivacyPage();
            Assert.Equal(DataControllersPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDataControllersPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string DataControllersPara2 = _loc.GetLocalizedString("en", "If you choose to use our services as a Visitor or Member, the collection, use and sharing of your personal data is subject to this Privacy Policy and other documents referenced in this Privacy Policy, as well as updates.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDataControllersPara2NameReferenceForPrivacyPage();
            Assert.Equal(DataControllersPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePolicyChangesTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string PolicyChangesTitle = _loc.GetLocalizedString("en", "Policy Changes", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePolicyChangesTitleNameReferenceForPrivacyPage();
            Assert.Equal(PolicyChangesTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePolicyChangesShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string PolicyChangesShortPara = _loc.GetLocalizedString("en", "You are advised to review this page periodically for any changes. We will notify you of any changes by posting the new Privacy Policy on this page.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePolicyChangesShortParaNameReferenceForPrivacyPage();
            Assert.Equal(PolicyChangesShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePolicyChangesPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string PolicyChangesPara1 = _loc.GetLocalizedString("en", "PromoPads Ltd can modify this Privacy Policy at any time, and if we make material changes to it, we will provide notice by posting the changes on this page, by communication through our services, or by other means, to provide you the opportunity to review the changes. If you object to any changes, you may close your account.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePolicyChangesPara1NameReferenceForPrivacyPage();
            Assert.Equal(PolicyChangesPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePolicyChangesPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string PolicyChangesPara2 = _loc.GetLocalizedString("en", "You acknowledge that your continued use of our Services after we publish or send a notice about our changes to this Privacy Policy means that the collection, use and sharing of your personal data is subject to the updated Privacy Policy, as of its effective date.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePolicyChangesPara2NameReferenceForPrivacyPage();
            Assert.Equal(PolicyChangesPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRegistrationTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string RegistrationTitle = _loc.GetLocalizedString("en", "Registration", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceRegistrationTitleNameReferenceForPrivacyPage();
            Assert.Equal(RegistrationTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRegistrationShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string RegistrationShortPara = _loc.GetLocalizedString("en", "You provide data to create an account with us.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceRegistrationShortParaNameReferenceForPrivacyPage();
            Assert.Equal(RegistrationShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRegistrationPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string RegistrationPara1 = _loc.GetLocalizedString("en", "To create an account you need to provide data including your name, email address, and a password. If you register for or use our paid services, including making or receiving donations, you will need to provide payment (e.g., credit card) and billing information.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceRegistrationPara1NameReferenceForPrivacyPage();
            Assert.Equal(RegistrationPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceProfileTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string ProfileTitle = _loc.GetLocalizedString("en", "Your Profile", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceProfileTitleNameReferenceForPrivacyPage();
            Assert.Equal(ProfileTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceProfileShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string ProfileShortPara = _loc.GetLocalizedString("en", "You create your GatheringForGood profile (a complete profile helps you get the most from our Services).", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceProfileShortParaNameReferenceForPrivacyPage();
            Assert.Equal(ProfileShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceProfilePara1NameReferenceForPrivacyPageIsCorrect()
        {
            string ProfilePara1 = _loc.GetLocalizedString("en", "You have choices about the information you include on your profile, such as your education, company name, skills, areas of interest, photo, country or region. You don’t have to provide additional information on your profile; however, profile information helps you to get more from our Services; including helping to be identified by opportunities where your knowledge, skills, experience and ideas can help make a real difference in the world.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceProfilePara1NameReferenceForPrivacyPage();
            Assert.Equal(ProfilePara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceProfilePara2NameReferenceForPrivacyPageIsCorrect()
        {
            string ProfilePara2 = _loc.GetLocalizedString("en", "You choose whether to include sensitive information on your profile and whether or not to make that sensitive information public. Please do not post or add personal data to your profile that you would not want to be publicly available.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceProfilePara2NameReferenceForPrivacyPage();
            Assert.Equal(ProfilePara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePostingTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string PostingTitle = _loc.GetLocalizedString("en", "Posting or Uploading Data", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePostingTitleNameReferenceForPrivacyPage();
            Assert.Equal(PostingTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePostingShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string PostingShortPara = _loc.GetLocalizedString("en", "You may provide other data to us while using our Services, such as by syncing your address book or calendar.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePostingShortParaNameReferenceForPrivacyPage();
            Assert.Equal(PostingShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePostingPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string PostingPara1 = _loc.GetLocalizedString("en", "We collect personal data from you when you provide, post or upload it to our Services, such as when you fill out a form, (e.g., with demographic data), respond to a survey, or register for an event. If you choose to import your address book, we receive your contacts (including contact information your service provider(s) or app automatically added to your address book when you communicated with addresses or numbers not already in your list).", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePostingPara1NameReferenceForPrivacyPage();
            Assert.Equal(PostingPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePostingPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string PostingPara2 = _loc.GetLocalizedString("en", "If you sync your contacts or calendars with our Services, we will collect your address book and calendar meeting information to help grow your communities by suggesting connections for you and others, and by providing information about online and in-person events.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePostingPara2NameReferenceForPrivacyPage();
            Assert.Equal(PostingPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePostingPara3NameReferenceForPrivacyPageIsCorrect()
        {
            string PostingPara3 = _loc.GetLocalizedString("en", "You are not required to post or upload personal data; though if you don’t, it may limit your ability to grow and engage with your communities via our Services.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePostingPara3NameReferenceForPrivacyPage();
            Assert.Equal(PostingPara3, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceContentTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string ContentTitle = _loc.GetLocalizedString("en", "Content & Information", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceContentTitleNameReferenceForPrivacyPage();
            Assert.Equal(ContentTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceContentShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string ContentShortPara = _loc.GetLocalizedString("en", "Others may post or write about you through our Services.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceContentShortParaNameReferenceForPrivacyPage();
            Assert.Equal(ContentShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceContentPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string ContentPara1 = _loc.GetLocalizedString("en", "You and others may post content that includes information about you (as part of articles, posts, comments, videos etc.) on our Services. We collect public information about you, such as news and accomplishments (e.g. patents granted, recognition achieved, conference speakers, projects, ideas etc.) and make it available as part of our Services (e.g. suggestions for your profile, notifications to others of mentions in the news, notifications to others of your ideas, communities or projects etc.).", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceContentPara1NameReferenceForPrivacyPage();
            Assert.Equal(ContentPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceContactsAndCalendarTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string ContactsAndCalendarTitle = _loc.GetLocalizedString("en", "Contacts And Calendar Information", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceContactsAndCalendarTitleNameReferenceForPrivacyPage();
            Assert.Equal(ContactsAndCalendarTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceContactsAndCalendarShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string ContactsAndCalendarShortPara = _loc.GetLocalizedString("en", "Others may sync their contacts or calendars with our Services.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceContactsAndCalendarShortParaNameReferenceForPrivacyPage();
            Assert.Equal(ContactsAndCalendarShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceContactsAndCalendarPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string ContactsAndCalendarPara1 = _loc.GetLocalizedString("en", "We may receive personal data (including contact information) about you when others import or sync their contacts or calendar with our Services, associate their contacts with Member profiles, or send messages using our Services (including invites or connection requests). If you or others opt-in to sync email accounts with our Services, we will also collect “email header” information that we can associate with Member profiles.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceContactsAndCalendarPara1NameReferenceForPrivacyPage();
            Assert.Equal(ContactsAndCalendarPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCustomersAndPartnersTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string CustomersAndPartnersTitle = _loc.GetLocalizedString("en", "Customers And Partners", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceCustomersAndPartnersTitleNameReferenceForPrivacyPage();
            Assert.Equal(CustomersAndPartnersTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCustomersAndPartnersShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string CustomersAndPartnersShortPara = _loc.GetLocalizedString("en", "Customers and partners may provide data to us, or us to them.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceCustomersAndPartnersShortParaNameReferenceForPrivacyPage();
            Assert.Equal(CustomersAndPartnersShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCustomersAndPartnersPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string CustomersAndPartnersPara1 = _loc.GetLocalizedString("en", "We may receive personal data (e.g. your job title and work email address) about you when you use the services of our customers and partners, such as charitable organisations, event participant and association membership tracking systems, or planning and productivity services. We may also provide your data to our partners in order to facilitate your use of such partner services where they are embedded or integrated into our Services. In such cases the amount of data we provide to partners will always be necessary and proportionate.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceCustomersAndPartnersPara1NameReferenceForPrivacyPage();
            Assert.Equal(CustomersAndPartnersPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceServiceUsageTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string ContactsAndCalendarShortPara = _loc.GetLocalizedString("en", "Your Use of Our Services", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceServiceUsageTitleNameReferenceForPrivacyPage();
            Assert.Equal(ContactsAndCalendarShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceServiceUsageShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string ServiceUsageShortPara = _loc.GetLocalizedString("en", "We log your visits and use of our Services, including mobile apps to help us improve our services.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceServiceUsageShortParaNameReferenceForPrivacyPage();
            Assert.Equal(ServiceUsageShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceServiceUsagePara1NameReferenceForPrivacyPageIsCorrect()
        {
            string ServiceUsagePara1 = _loc.GetLocalizedString("en", "When you visit or otherwise use our Services we log usage data, including our sites, app and platform technology, such as when you view or click on content (e.g. blog posts, videos, internal and external links) or ads (on or off our sites and apps), perform a search, share articles, create or register for events, and create or manage communities or causes. We use log-ins, cookies, device information and internet protocol (“IP”) addresses to identify you and log your use of our services.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceServiceUsagePara1NameReferenceForPrivacyPage();
            Assert.Equal(ServiceUsagePara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCookiesTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string CookiesTitle = _loc.GetLocalizedString("en", "Data Collection Via Cookies And Similar Technologies", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceCookiesTitleNameReferenceForPrivacyPage();
            Assert.Equal(CookiesTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCookiesShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string CookiesShortPara = _loc.GetLocalizedString("en", "We collect data through cookies and similar technologies.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceCookiesShortParaNameReferenceForPrivacyPage();
            Assert.Equal(CookiesShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCookiesPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string CookiesPara1 = _loc.GetLocalizedString("en", "As further described in our", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceCookiesPara1NameReferenceForPrivacyPage();
            Assert.Equal(CookiesPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCookiesPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string CookiesPara2 = _loc.GetLocalizedString("en", "we use cookies and similar technologies (e.g. pixels and ad tags) to collect data (e.g. device IDs) to recognize you and your device(s) on, off and across different services and devices where you have engaged with our Services. We also allow some partners and others to use cookies as described in our Cookie Policy.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceCookiesPara2NameReferenceForPrivacyPage();
            Assert.Equal(CookiesPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCookiesPara3NameReferenceForPrivacyPageIsCorrect()
        {
            string CookiesPara3 = _loc.GetLocalizedString("en", "We also collect (or rely on others who collect) information about your device where you have not engaged with our Services (e.g. ad ID, IP address, operating system and browser information) so we can provide our Members with relevant ads and better understand their effectiveness. You can opt out from our use of data from cookies and similar technologies that track your behavior on the sites of others, for ad targeting and other ad-related purposes, in your member settings.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceCookiesPara3NameReferenceForPrivacyPage();
            Assert.Equal(CookiesPara3, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCookiePolicyNameReferenceForPrivacyPageIsCorrect()
        {
            string CookiePolicy = _loc.GetLocalizedString("en", "Cookie Policy", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceCookiePolicyNameReferenceForPrivacyPage();
            Assert.Equal(CookiePolicy, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDevicesAndLocationTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string DevicesAndLocationTitle = _loc.GetLocalizedString("en", "Your Devices and Location", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDevicesAndLocationTitleNameReferenceForPrivacyPage();
            Assert.Equal(DevicesAndLocationTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDevicesAndLocationShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string DevicesAndLocationShortPara = _loc.GetLocalizedString("en", "We receive data from your devices and/or networks, which may include location data.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDevicesAndLocationShortParaNameReferenceForPrivacyPage();
            Assert.Equal(DevicesAndLocationShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDevicesAndLocationPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string DevicesAndLocationPara1 = _loc.GetLocalizedString("en", "When you visit or leave our Services, we may receive the URL of both the site you came from and the one you go to. We may also receive the time of your visit. We also get information about your network and device (e.g., IP address, proxy server, operating system, web browser and add-ons, device identifier and features, cookie IDs and/or ISP, or your mobile carrier). If you use our Services from a mobile device, depending upon your phone settings, that device may send us data about your location. We will ask you to opt-in before we use GPS or other tools to identify your precise location.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDevicesAndLocationPara1NameReferenceForPrivacyPage();
            Assert.Equal(DevicesAndLocationPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceMessagesTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string MessagesTitle = _loc.GetLocalizedString("en", "Messages", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceMessagesTitleNameReferenceForPrivacyPage();
            Assert.Equal(MessagesTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceMessagesShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string MessagesShortPara = _loc.GetLocalizedString("en", "We collect data if you communicate with other members or visitors through our Services.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceMessagesShortParaNameReferenceForPrivacyPage();
            Assert.Equal(MessagesShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceMessagesPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string MessagesPara1 = _loc.GetLocalizedString("en", "We collect information about you when you send, receive, or engage with messages in connection with our Services. For example, if you get a GatheringForGood connection request, we track whether you have acted on it and will send you reminders. We also use automatic scanning technology on messages to support and protect our site. For example, we may use fully-automated, semi-automated and manual technology and means, to manage or block content that violates our", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceMessagesPara1NameReferenceForPrivacyPage();
            Assert.Equal(MessagesPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceMessagesPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string MessagesPara2 = _loc.GetLocalizedString("en", "or", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceMessagesPara2NameReferenceForPrivacyPage();
            Assert.Equal(MessagesPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceMessagesPara3NameReferenceForPrivacyPageIsCorrect()
        {
            string MessagesPara3 = _loc.GetLocalizedString("en", "from our Services.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceMessagesPara3NameReferenceForPrivacyPage();
            Assert.Equal(MessagesPara3, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceTermsConditionsNameReferenceForPrivacyPageIsCorrect()
        {
            string TermsConditions = _loc.GetLocalizedString("en", "Terms and Conditions", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceTermsConditionsNameReferenceForPrivacyPage();
            Assert.Equal(TermsConditions, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceMemberPoliciesNameReferenceForPrivacyPageIsCorrect()
        {
            string MemberPolicies = _loc.GetLocalizedString("en", "Member Policies", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceMemberPoliciesNameReferenceForPrivacyPage();
            Assert.Equal(MemberPolicies, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSchoolAndOthersInfoTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string SchoolAndOthersInfoTitle = _loc.GetLocalizedString("en", "Information Provided By Your School, Organisation or Others", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceSchoolAndOthersInfoTitleNameReferenceForPrivacyPage();
            Assert.Equal(SchoolAndOthersInfoTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSchoolAndOthersInfoShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string SchoolAndOthersInfoShortPara = _loc.GetLocalizedString("en", "When others purchase a premium Service for you to use, they give us data about you.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceSchoolAndOthersInfoShortParaNameReferenceForPrivacyPage();
            Assert.Equal(SchoolAndOthersInfoShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSchoolAndOthersInfoPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string SchoolAndOthersInfoPara1 = _loc.GetLocalizedString("en", "Others buying our Services for your use, such as your employer, your schoo, your organisation or association, provide us with personal data about you and your eligibility to use the Services that they purchase for use by you. For example, we will get contact information for “Community Management” or “Cause Management” administrators and for authorizing users of our premium Services where they have been purchased on your behalf.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceSchoolAndOthersInfoPara1NameReferenceForPrivacyPage();
            Assert.Equal(SchoolAndOthersInfoPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSchoolAndOthersInfoPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string SchoolAndOthersInfoPara2 = _loc.GetLocalizedString("en", "If you do not wish to use services purchased on your behalf please notify us. We will terminate your access to the relevant service, remove any personal data provided on your behalf and notify the original purchaser. If you are a minor and the purchaser (Such as your school) disputes the service termination, we will request confirmation from a parent or authorised legal guardian.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceSchoolAndOthersInfoPara2NameReferenceForPrivacyPage();
            Assert.Equal(SchoolAndOthersInfoPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOtherSitesAndServicesTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string OtherSitesAndServicesTitle = _loc.GetLocalizedString("en", "Sites And Services Of Others", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceOtherSitesAndServicesTitleNameReferenceForPrivacyPage();
            Assert.Equal(OtherSitesAndServicesTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOtherSitesAndServicesShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string OtherSitesAndServicesShortPara = _loc.GetLocalizedString("en", "We get data when you visit sites that include our ads, cookies or some of our plugins or when you log-in to others’ services with your GatheringForGood account.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceOtherSitesAndServicesShortParaNameReferenceForPrivacyPage();
            Assert.Equal(OtherSitesAndServicesShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOtherSitesAndServicesPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string OtherSitesAndServicesPara1 = _loc.GetLocalizedString("en", "We receive information about your visits to sites owned by others and your interaction with services provided by others when you log-in with GatheringForGood, or when you visit others’ services that include some of our plugins or our ads, cookies or similar technologies.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceOtherSitesAndServicesPara1NameReferenceForPrivacyPage();
            Assert.Equal(OtherSitesAndServicesPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOtherDataWeCollectTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string OtherDataWeCollectTitle = _loc.GetLocalizedString("en", "Other Data We Collect", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceOtherDataWeCollectTitleNameReferenceForPrivacyPage();
            Assert.Equal(OtherDataWeCollectTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOtherDataWeCollectShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string OtherDataWeCollectShortPara = _loc.GetLocalizedString("en", "GatheringForGood often identifies new ways to gather, collect and utilise data.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceOtherDataWeCollectShortParaNameReferenceForPrivacyPage();
            Assert.Equal(OtherDataWeCollectShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOtherDataWeCollectPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string OtherDataWeCollectPara1 = _loc.GetLocalizedString("en", "GatheringForGood Services are dynamic, growing and rapidly improving. As such, we often introduce new features to help our users change the world for the better, which may require the collection of new information or changes in the way we use data. If we collect materially different personal data or materially change how we collect, use or share your data, we will notify you through changes to this Privacy Policy.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceOtherDataWeCollectPara1NameReferenceForPrivacyPage();
            Assert.Equal(OtherDataWeCollectPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHowWeUseYourDataShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string HowWeUseYourDataShortPara = _loc.GetLocalizedString("en", "We use your data to provide, support, improve, personalize and develop our Services.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceHowWeUseYourDataShortParaNameReferenceForPrivacyPage();
            Assert.Equal(HowWeUseYourDataShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceHowWeUseYourDataPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string HowWeUseYourDataPara1 = _loc.GetLocalizedString("en", "How we use your personal data will depend on which Services you choose to use, how you use our Services and the choices you make in your settings. We use your data to authorize access to our services. We use the data that we have about you to provide and personalize our Services, including with the help of automated systems and inferences we make, so that all of our free, paid and paid-by-3rd-party Services can be more relevant and useful to you and others.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceHowWeUseYourDataPara1NameReferenceForPrivacyPage();
            Assert.Equal(HowWeUseYourDataPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceConnectAndStayConnectedTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string ConnectAndStayConnectedTitle = _loc.GetLocalizedString("en", "Connect And Stay Connected", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceConnectAndStayConnectedTitleNameReferenceForPrivacyPage();
            Assert.Equal(ConnectAndStayConnectedTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceConnectAndStayConnectedShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string ConnectAndStayConnectedShortPara = _loc.GetLocalizedString("en", "Our Services help you connect with others, while identifying, collaborating on and maturing ideas to change the world.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceConnectAndStayConnectedShortParaNameReferenceForPrivacyPage();
            Assert.Equal(ConnectAndStayConnectedShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceConnectAndStayConnectedPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string ConnectAndStayConnectedPara1 = _loc.GetLocalizedString("en", "Our Services allow you to stay in touch and up to date with your communities, colleagues, friends, partners, clients, and other contacts. To do so, you can “connect” with people who you choose, and who also wish to “connect” with you. You can create, join and participate in communities related to a particular cause or initiative. When you connect with other Members, you will be able to search each others’ connections in order to exchange opportunities.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceConnectAndStayConnectedPara1NameReferenceForPrivacyPage();
            Assert.Equal(ConnectAndStayConnectedPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceConnectAndStayConnectedPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string ConnectAndStayConnectedPara2 = _loc.GetLocalizedString("en", "We use data about you (such as your profile, skills, expertise, profiles you have viewed or data provided through address book uploads or partner integrations) to help others find your profile, suggest connections for you and others (e.g. Members who may have relevant knowledge to contribute positively to a cause or initiative) and enable you to invite others to become a Member and connect with you. You can also opt-in to allow us to use your precise location or proximity to others for certain tasks (e.g. to identify events and causes in your area, to suggest other nearby Members for you to connect with, or notify your connections that you are at an event).", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceConnectAndStayConnectedPara2NameReferenceForPrivacyPage();
            Assert.Equal(ConnectAndStayConnectedPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceConnectAndStayConnectedPara3NameReferenceForPrivacyPageIsCorrect()
        {
            string ConnectAndStayConnectedPara3 = _loc.GetLocalizedString("en", "It is your choice whether to invite someone to our Services, send a connection request, or allow another Member to become your connection. When you invite someone to connect with you, your invitation will include your network and basic profile information (e.g., name, profile photo, interests and skills, region). We will send invitation reminders to the person you invited. You can choose whether or not to share your own list of connections with your connections.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceConnectAndStayConnectedPara3NameReferenceForPrivacyPage();
            Assert.Equal(ConnectAndStayConnectedPara3, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceStayInformedTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string StayInformedTitle = _loc.GetLocalizedString("en", "Stay Informed", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceStayInformedTitleNameReferenceForPrivacyPage();
            Assert.Equal(StayInformedTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceStayInformedShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string StayInformedShortPara = _loc.GetLocalizedString("en", "Our Services help you stay informed about the challenges facing our planet, plus actions and ideas that people are progressing to change the world for the better.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceStayInformedShortParaNameReferenceForPrivacyPage();
            Assert.Equal(StayInformedShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceStayInformedPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string StayInformedPara1 = _loc.GetLocalizedString("en", "Our Services allow you to stay informed about news, events and ideas regarding topics you care about, and from people you respect. We use the data we have about you (e.g., data you provide, data we collect from your engagement with our Services and inferences we make from the data we have about you), to personalize our Services for you, such as by recommending or ranking relevant content, services and conversations on our Services.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceStayInformedPara1NameReferenceForPrivacyPage();
            Assert.Equal(StayInformedPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceStayInformedPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string StayInformedPara2 = _loc.GetLocalizedString("en", "We also use the data we have about you to suggest skills you could add to your profile so you can be invited to contribute knowledge for good through our services. So, if you let us know that you are interested in an idea, challenge or topic (e.g. by watching a video or following a cause), we will use this information to personalize content in your feed, suggest that you follow certain members on our site, or suggest related content to help you learn and contribute more towards a better world. We use your content, activity and other data, including your name and photo, to provide notices to your network and others. For example, subject to your settings, we may notify others that you have updated your profile, posted content, took a social action, used a feature, made new connections or were mentioned in the news.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceStayInformedPara2NameReferenceForPrivacyPage();
            Assert.Equal(StayInformedPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceProductivityTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string ProductivityTitle = _loc.GetLocalizedString("en", "Productivity", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceProductivityTitleNameReferenceForPrivacyPage();
            Assert.Equal(ProductivityTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceProductivityShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string ProductivityShortPara = _loc.GetLocalizedString("en", "Our Services help you to gather the knowledge and expertise together on a single platform, to productively identify and break-down solutions to the worlds problems.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceProductivityShortParaNameReferenceForPrivacyPage();
            Assert.Equal(ProductivityShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceProductivityPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string ProductivityPara1 = _loc.GetLocalizedString("en", "Our Services allow you to collaborate with colleagues, search for potential clients, customers, partners and others to discuss, analyze, break-down and identify solutions to environmental challenges and issues. Our Services allow you to communicate with other Members. If your settings allow, we may scan messages to provide “bots” or similar tools that facilitate tasks such as scheduling, drafting responses, summarizing messages or recommending next steps.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceProductivityPara1NameReferenceForPrivacyPage();
            Assert.Equal(ProductivityPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePaidPremiumServicesTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string PaidPremiumServicesTitle = _loc.GetLocalizedString("en", "Paid And Premium Services", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePaidPremiumServicesTitleNameReferenceForPrivacyPage();
            Assert.Equal(PaidPremiumServicesTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePaidPremiumServicesShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string PaidPremiumServicesShortPara = _loc.GetLocalizedString("en", "Our paid premium Services help paying users to grow their communitiy around their cause, fundraise for their cause, and more productively collaborate to progress their cause.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePaidPremiumServicesShortParaNameReferenceForPrivacyPage();
            Assert.Equal(PaidPremiumServicesShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePaidPremiumServicesPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string PaidPremiumServicesPara1 = _loc.GetLocalizedString("en", "Promo Pads Ltd built the GatheringForGood app as a Freemium app. A limited amount of functionality is provided at no cost and is intended for use as is. We sell premium Services that provide our customers and subscribers with customized and expanded functionality and tools. Customers can export limited information from your profile, such as name, headline, current company, and general location (e.g., Dublin), such as to manage sales leads or talent, unless you opt-out. We do not provide contact information to customers as part of these premium Services without your consent.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePaidPremiumServicesPara1NameReferenceForPrivacyPage();
            Assert.Equal(PaidPremiumServicesPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePaidPremiumServicesPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string PaidPremiumServicesPara2 = _loc.GetLocalizedString("en", "Premium Services customers can store information they have about you in our premium Services, such as a resume or contact information or donation history. The data stored about you by these customers is subject to the policies of those customers. Other features we provide may be provided through 3rd party integrations or white labelling within our Services, these may use your data in order to provide you the relevant functionalities in our app.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePaidPremiumServicesPara2NameReferenceForPrivacyPage();
            Assert.Equal(PaidPremiumServicesPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCommunicationsTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string CommunicationsTitle = _loc.GetLocalizedString("en", "Communications", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceCommunicationsTitleNameReferenceForPrivacyPage();
            Assert.Equal(CommunicationsTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCommunicationsShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string CommunicationsShortPara = _loc.GetLocalizedString("en", "We will contact you and we enable communications between Members. You can control what messages you receive and how often you receive some types of messages from your user settings.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceCommunicationsShortParaNameReferenceForPrivacyPage();
            Assert.Equal(CommunicationsShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCommunicationsPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string CommunicationsPara1 = _loc.GetLocalizedString("en", "We will contact you through email, mobile phone, notices posted on our websites or apps, messages to your GatheringForGood inbox, and other ways through our Services, including text messages and push notifications. We will send you messages about the availability of our Services, security, or other service-related issues. We also send messages about how to use our Services, network updates, reminders, job suggestions and promotional messages from us and our partners.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceCommunicationsPara1NameReferenceForPrivacyPage();
            Assert.Equal(CommunicationsPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCommunicationsPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string CommunicationsPara2 = _loc.GetLocalizedString("en", "We also enable communications between you and others through our Services, including for example invitations, groups and messages between connections. You may change your communication preferences at any time. However, please be aware that you cannot opt out of receiving service messages from us, including security and legal notices.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceCommunicationsPara2NameReferenceForPrivacyPage();
            Assert.Equal(CommunicationsPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAdvertisingTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string AdvertisingTitle = _loc.GetLocalizedString("en", "Advertising", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceAdvertisingTitleNameReferenceForPrivacyPage();
            Assert.Equal(AdvertisingTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAdvertisingShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string AdvertisingShortPara = _loc.GetLocalizedString("en", "We serve you tailored ads both on and off our Services. We offer you choices regarding personalized ads, but you cannot opt-out of seeing other ads.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceAdvertisingShortParaNameReferenceForPrivacyPage();
            Assert.Equal(AdvertisingShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAdvertisingPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string AdvertisingPara1 = _loc.GetLocalizedString("en", "We target (and measure the performance of) ads to Members, Visitors and others both on and off our Services directly or through a variety of partners, using the following data, whether separately or combined:", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceAdvertisingPara1NameReferenceForPrivacyPage();
            Assert.Equal(AdvertisingPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAdvertisingPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string AdvertisingPara2 = _loc.GetLocalizedString("en", "Data from advertising technologies on and off our Services, pixels, ad tags, cookies, and device identifiers;", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceAdvertisingPara2NameReferenceForPrivacyPage();
            Assert.Equal(AdvertisingPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAdvertisingPara3NameReferenceForPrivacyPageIsCorrect()
        {
            string AdvertisingPara3 = _loc.GetLocalizedString("en", "Member-provided information (e.g., profile, contact information, title and skills);", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceAdvertisingPara3NameReferenceForPrivacyPage();
            Assert.Equal(AdvertisingPara3, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAdvertisingPara4NameReferenceForPrivacyPageIsCorrect()
        {
            string AdvertisingPara4 = _loc.GetLocalizedString("en", "Data from your use of our Services (e.g., search history, feed, content you read, who you follow or is following you, connections, groups participation, page visits, videos you watch, clicking on an ad, etc.).", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceAdvertisingPara4NameReferenceForPrivacyPage();
            Assert.Equal(AdvertisingPara4, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAdvertisingPara5NameReferenceForPrivacyPageIsCorrect()
        {
            string AdvertisingPara5 = _loc.GetLocalizedString("en", "Information from advertising partners, vendors and publishers.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceAdvertisingPara5NameReferenceForPrivacyPage();
            Assert.Equal(AdvertisingPara5, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAdvertisingPara6NameReferenceForPrivacyPageIsCorrect()
        {
            string AdvertisingPara6 = _loc.GetLocalizedString("en", "Information inferred from data described above (e.g., using company and skills from a profile to infer industry; using first names or pronoun usage to infer gender; using your feed activity to infer your interests; or using device data to recognize you as a Member).", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceAdvertisingPara6NameReferenceForPrivacyPage();
            Assert.Equal(AdvertisingPara6, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAdvertisingPara7NameReferenceForPrivacyPageIsCorrect()
        {
            string AdvertisingPara7 = _loc.GetLocalizedString("en", "We will show you ads called sponsored content which look similar to non-sponsored content, except that they are labeled as advertising (e.g.“sponsored” or similar). If you take a social action (such as like, comment or share) on these ads, your action is associated with your name and viewable by others, including the advertiser. If you take a social action on the GatheringForGood Services, that action may be mentioned with related ads.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceAdvertisingPara7NameReferenceForPrivacyPage();
            Assert.Equal(AdvertisingPara7, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAdChoicesTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string AdChoicesTitle = _loc.GetLocalizedString("en", "Ad Choices", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceAdChoicesTitleNameReferenceForPrivacyPage();
            Assert.Equal(AdChoicesTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAdChoicesShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string AdChoicesShortPara = _loc.GetLocalizedString("en", "You can opt-out of our use of certain types of data to offer you customized ads.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceAdChoicesShortParaNameReferenceForPrivacyPage();
            Assert.Equal(AdChoicesShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAdChoicesPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string AdChoicesPara1 = _loc.GetLocalizedString("en", "You cannot opt out of receiving advertising; if you choose to opt-out of us using certain types of data to offer you more customized ads, you will continue to get other ads by advertisers which have not been personnally customized for you. We may display ads from 3rd party advertising content providers and from our own platform advertisers.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceAdChoicesPara1NameReferenceForPrivacyPage();
            Assert.Equal(AdChoicesPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceInfoToAdProvidersTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string InfoToAdProvidersTitle = _loc.GetLocalizedString("en", "Info to Ad Providers", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceInfoToAdProvidersTitleNameReferenceForPrivacyPage();
            Assert.Equal(InfoToAdProvidersTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceInfoToAdProvidersShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string InfoToAdProvidersShortPara = _loc.GetLocalizedString("en", "If you view or click on an ad on or off our Services, the ad provider will get a signal that someone visited the page that displayed the ad, and they may, through the use of mechanisms such as cookies, determine it is you.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceInfoToAdProvidersShortParaNameReferenceForPrivacyPage();
            Assert.Equal(InfoToAdProvidersShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceInfoToAdProvidersPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string InfoToAdProvidersPara1 = _loc.GetLocalizedString("en", "We do not share your personal data with any third-party advertisers or ad networks except for: (i) hashed IDs or device identifiers (to the extent they are personal data in some countries); (ii) with your separate permission (e.g., in a lead generation form) or (iii) data already visible to any users of the Services (e.g., profile). Advertising partners may be able to associate personal data collected by the advertiser directly from you, with hashed IDs or device identifiers received from us.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceInfoToAdProvidersPara1NameReferenceForPrivacyPage();
            Assert.Equal(InfoToAdProvidersPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceMarketingTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string MarketingTitle = _loc.GetLocalizedString("en", "GatheringForGood Marketing", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceMarketingTitleNameReferenceForPrivacyPage();
            Assert.Equal(MarketingTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceMarketingShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string MarketingShortPara = _loc.GetLocalizedString("en", "We promote our Services to you and others.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceMarketingShortParaNameReferenceForPrivacyPage();
            Assert.Equal(MarketingShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceMarketingPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string MarketingPara1 = _loc.GetLocalizedString("en", "In addition to advertising our Services, we use Members’ data and content for invitations and communications promoting membership and network growth, engagement and our Services, such as by showing your connections that you have used a feature on our Services.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceMarketingPara1NameReferenceForPrivacyPage();
            Assert.Equal(MarketingPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceServiceDevelopmentTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string ServiceDevelopmentTitle = _loc.GetLocalizedString("en", "GatheringForGood Service Development", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceServiceDevelopmentTitleNameReferenceForPrivacyPage();
            Assert.Equal(ServiceDevelopmentTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceServiceDevelopmentShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string ServiceDevelopmentShortPara = _loc.GetLocalizedString("en", "We develop our services and conduct research for our services.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceServiceDevelopmentShortParaNameReferenceForPrivacyPage();
            Assert.Equal(ServiceDevelopmentShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceServiceDevelopmentPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string ServiceDevelopmentPara1 = _loc.GetLocalizedString("en", "We use data, including public feedback, to conduct research and development for our Services in order to provide you and others with a better, more intuitive and personalized experience, drive membership growth and engagement on our Services, and help connect members to each other and to opportunities to do good in the world.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceServiceDevelopmentPara1NameReferenceForPrivacyPage();
            Assert.Equal(ServiceDevelopmentPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOtherResearchTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string OtherResearchTitle = _loc.GetLocalizedString("en", "Other Research And Development", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceOtherResearchTitleNameReferenceForPrivacyPage();
            Assert.Equal(OtherResearchTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOtherResearchShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string OtherResearchShortPara = _loc.GetLocalizedString("en", "We conduct other research and development.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceOtherResearchShortParaNameReferenceForPrivacyPage();
            Assert.Equal(OtherResearchShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOtherResearchPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string OtherResearchPara1 = _loc.GetLocalizedString("en", "We seek to facilitate, support, generate and actively create positive change in the world. We use the personal and public data available to us on or off our platform to research environmental and social trends, such as policies that help bridge the gap in creating sustainable harmony between humanity and our planet. In some cases, we work with trusted third parties to perform this research. We publish or allow others to publish insights, presented as aggregated data rather than personal data.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceOtherResearchPara1NameReferenceForPrivacyPage();
            Assert.Equal(OtherResearchPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOtherResearchPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string OtherResearchPara2 = _loc.GetLocalizedString("en", "When we identify challenges, ideas or solutions shared through our Services, related to pressing environmental or other problems, PromoPads Ltd reserves the right to use our economic and other resources to pursue such challenges, ideas or solutions in order to help make a positive difference and create a better world; we may exercise such pursuits on any basis including commercial for profit.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceOtherResearchPara2NameReferenceForPrivacyPage();
            Assert.Equal(OtherResearchPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePollsAndSurveysTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string PollsAndSurveysTitle = _loc.GetLocalizedString("en", "Polls And Surveys", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePollsAndSurveysTitleNameReferenceForPrivacyPage();
            Assert.Equal(PollsAndSurveysTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePollsAndSurveysShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string PollsAndSurveysShortPara = _loc.GetLocalizedString("en", "We and others may conduct polls and surveys through our Services.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePollsAndSurveysShortParaNameReferenceForPrivacyPage();
            Assert.Equal(PollsAndSurveysShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePollsAndSurveysPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string PollsAndSurveysPara1 = _loc.GetLocalizedString("en", "Polls and surveys are conducted by us and others through our Services. You are not obligated to respond to polls or surveys. We may share and sell anonymised and/or aggregated poll and survey results with 3rd parties and the general public on or off our apps for research, commercial and/or promotional marketing purposes.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePollsAndSurveysPara1NameReferenceForPrivacyPage();
            Assert.Equal(PollsAndSurveysPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCustomerSupportTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string CustomerSupportTitle = _loc.GetLocalizedString("en", "Customer Support", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceCustomerSupportTitleNameReferenceForPrivacyPage();
            Assert.Equal(CustomerSupportTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCustomerSupportShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string CustomerSupportShortPara = _loc.GetLocalizedString("en", "We use data to help members and fix problems.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceCustomerSupportShortParaNameReferenceForPrivacyPage();
            Assert.Equal(CustomerSupportShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCustomerSupportPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string CustomerSupportPara1 = _loc.GetLocalizedString("en", "We use data (which can include your communications and personally identifying data) to investigate, respond to and resolve complaints and for Service issues (e.g. investigating and resolving software bugs).", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceCustomerSupportPara1NameReferenceForPrivacyPage();
            Assert.Equal(CustomerSupportPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceNonIdentifyingInsightsTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string NonIdentifyingInsightsTitle = _loc.GetLocalizedString("en", "Non-Identifying Insights", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceNonIdentifyingInsightsTitleNameReferenceForPrivacyPage();
            Assert.Equal(NonIdentifyingInsightsTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceNonIdentifyingInsightsShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string NonIdentifyingInsightsShortPara = _loc.GetLocalizedString("en", "We use data to generate and share insights that do not identify you.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceNonIdentifyingInsightsShortParaNameReferenceForPrivacyPage();
            Assert.Equal(NonIdentifyingInsightsShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceNonIdentifyingInsightsPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string NonIdentifyingInsightsPara1 = _loc.GetLocalizedString("en", "We use your data to produce and share insights that do not identify you. For example, we may use your data to generate statistics about our members, to calculate ad impressions served or clicked on, or to publish visitor demographics for a Service or create demographic insights related to significant issues affecting the planet and natural environment. We may share and sell anonymised and/or aggregated data on or off our apps for research, commercial and/or promotional marketing purposes.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceNonIdentifyingInsightsPara1NameReferenceForPrivacyPage();
            Assert.Equal(NonIdentifyingInsightsPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSecurityInvestigationsTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string SecurityInvestigationsTitle = _loc.GetLocalizedString("en", "Security Investigations and Fraud Prevention", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceSecurityInvestigationsTitleNameReferenceForPrivacyPage();
            Assert.Equal(SecurityInvestigationsTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSecurityInvestigationsShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string SecurityInvestigationsShortPara = _loc.GetLocalizedString("en", "We use data for security, fraud prevention and investigations.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceSecurityInvestigationsShortParaNameReferenceForPrivacyPage();
            Assert.Equal(SecurityInvestigationsShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSecurityInvestigationsPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string SecurityInvestigationsPara1 = _loc.GetLocalizedString("en", "We use your data (including your communications) for security purposes, to prevent and investigate possible fraud or other violations of our Terms and Conditions and/or attempts to harm our Members, Visitors or others.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceSecurityInvestigationsPara1NameReferenceForPrivacyPage();
            Assert.Equal(SecurityInvestigationsPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceYourProfileTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string YourProfileTitle = _loc.GetLocalizedString("en", "Your Profile", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceYourProfileTitleNameReferenceForPrivacyPage();
            Assert.Equal(YourProfileTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceYourProfileShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string YourProfileShortPara = _loc.GetLocalizedString("en", "Any data that you include on your profile will be seen by others, consistent with your settings.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceYourProfileShortParaNameReferenceForPrivacyPage();
            Assert.Equal(YourProfileShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceYourProfilePara1NameReferenceForPrivacyPageIsCorrect()
        {
            string YourProfilePara1 = _loc.GetLocalizedString("en", "Your profile is fully visible to all Members and customers of our Services. Subject to your settings, it can also be visible to others on or off of our Services (e.g. Visitors to our Services or users of third- party search engines). Your settings, degree of connection with the viewing Member, the subscriptions they may have, their usage of our Services, access channels and search types (e.g. by name or by keyword) impact the availability of your profile and whether other Members or Visitors can view certain fields in your profile.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceYourProfilePara1NameReferenceForPrivacyPage();
            Assert.Equal(YourProfilePara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePostsLikesTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string PostsLikesTitle = _loc.GetLocalizedString("en", "Posts, Likes, Follows, Comments, Messages", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePostsLikesTitleNameReferenceForPrivacyPage();
            Assert.Equal(PostsLikesTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePostsLikesShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string PostsLikesShortPara = _loc.GetLocalizedString("en", "Any data that you include on your profile and any content you post or social action (e.g., likes, follows, comments, shares) you take on our Services will be seen by others.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePostsLikesShortParaNameReferenceForPrivacyPage();
            Assert.Equal(PostsLikesShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePostsLikesPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string PostsLikesPara1 = _loc.GetLocalizedString("en", "When you share an article or a post (e.g. an update, image, video or article) publicly, it can be viewed by everyone and re-shared anywhere. Members, Visitors and others will be able to find and see your publicly-shared content, including your name (and photo if you have provided one).", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePostsLikesPara1NameReferenceForPrivacyPage();
            Assert.Equal(PostsLikesPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePostsLikesPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string PostsLikesPara2 = _loc.GetLocalizedString("en", "In a group, cause or GatheringForGood community, posts are visible to others in the group, cause or community. Your membership in groups is public and part of your profile.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePostsLikesPara2NameReferenceForPrivacyPage();
            Assert.Equal(PostsLikesPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePostsLikesPara3NameReferenceForPrivacyPageIsCorrect()
        {
            string PostsLikesPara3 = _loc.GetLocalizedString("en", "Any information you share through charities’ or other organizations’ pages on our Services will be viewable by it and others who visit those pages.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePostsLikesPara3NameReferenceForPrivacyPage();
            Assert.Equal(PostsLikesPara3, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePostsLikesPara4NameReferenceForPrivacyPageIsCorrect()
        {
            string PostsLikesPara4 = _loc.GetLocalizedString("en", "When you “participate” in a cause or community, or “follow” a person, you are visible to others and the “community owner” as a participant.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePostsLikesPara4NameReferenceForPrivacyPage();
            Assert.Equal(PostsLikesPara4, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePostsLikesPara5NameReferenceForPrivacyPageIsCorrect()
        {
            string PostsLikesPara5 = _loc.GetLocalizedString("en", "We let senders know when you act on their message.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePostsLikesPara5NameReferenceForPrivacyPage();
            Assert.Equal(PostsLikesPara5, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePostsLikesPara6NameReferenceForPrivacyPageIsCorrect()
        {
            string PostsLikesPara6 = _loc.GetLocalizedString("en", "We let Members know when you view their cause, community or profile.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePostsLikesPara6NameReferenceForPrivacyPage();
            Assert.Equal(PostsLikesPara6, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourcePostsLikesPara7NameReferenceForPrivacyPageIsCorrect()
        {
            string PostsLikesPara7 = _loc.GetLocalizedString("en", "When you like or re-share or comment on another’s content (including ads), others will be able to view these “social actions” and associate it with you (e.g. your name, profile and photo if you provided it).", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourcePostsLikesPara7NameReferenceForPrivacyPage();
            Assert.Equal(PostsLikesPara7, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceEnterpriseAccountsTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string EnterpriseAccountsTitle = _loc.GetLocalizedString("en", "Communication Archival", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceEnterpriseAccountsTitleNameReferenceForPrivacyPage();
            Assert.Equal(EnterpriseAccountsTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceEnterpriseAccountsShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string EnterpriseAccountsShortPara = _loc.GetLocalizedString("en", "Regulated Members may need to store communications outside of our Services.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceEnterpriseAccountsShortParaNameReferenceForPrivacyPage();
            Assert.Equal(EnterpriseAccountsShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceEnterpriseAccountsPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string EnterpriseAccountsPara1 = _loc.GetLocalizedString("en", "Some Members (or their employers) may need, for legal or professional compliance, to archive their communications and social media activity, and will use services of others to provide these archival services. We enable archiving of messages by and to those Members outside of our Services. For example, a financial advisor needs to archive communications with his or her clients through our Services in order to maintain a professional financial advisor license.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceEnterpriseAccountsPara1NameReferenceForPrivacyPage();
            Assert.Equal(EnterpriseAccountsPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOthersServicesTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string OthersServicesTitle = _loc.GetLocalizedString("en", "Others’ Services", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceOthersServicesTitleNameReferenceForPrivacyPage();
            Assert.Equal(OthersServicesTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOthersServicesShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string OthersServicesShortPara = _loc.GetLocalizedString("en", "You may link your account with others’ services so that they can look up your contacts’ profiles, post your shares on such platforms, or enable you to start conversations with your connections on such platforms. Excerpts from your profile will also appear on the services of others.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceOthersServicesShortParaNameReferenceForPrivacyPage();
            Assert.Equal(OthersServicesShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOthersServicesPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string OthersServicesPara1 = _loc.GetLocalizedString("en", "Subject to your settings, other services may look up your profile. When you opt to link your account with other services, personal data will become available to them. The sharing and use of that personal data will be described in, or linked to, a consent screen when you opt to link the accounts. For example, you may link your Twitter account to share content from our Services into these other services, or your email provider may give you the option to upload your GatheringForGood contacts into its own service. Third-party services have their own privacy policies, and you may be giving them permission to use your data in ways we would not. You may revoke the link with such accounts.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceOthersServicesPara1NameReferenceForPrivacyPage();
            Assert.Equal(OthersServicesPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceOthersServicesPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string OthersServicesPara2 = _loc.GetLocalizedString("en", "Subject to your settings, excerpts from your profile will appear on the services of others (e.g. search engine results, mail and calendar applications that show a user limited profile data of the person they are meeting or messaging, social media aggregators etc.). “Old” profile information remains on these services until they update their data cache with changes you made to your profile.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceOthersServicesPara2NameReferenceForPrivacyPage();
            Assert.Equal(OthersServicesPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRelatedServicesTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string RelatedServicesTitle = _loc.GetLocalizedString("en", "Related GatheringForGood Services", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceRelatedServicesTitleNameReferenceForPrivacyPage();
            Assert.Equal(RelatedServicesTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRelatedServicesShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string RelatedServicesShortPara = _loc.GetLocalizedString("en", "We share your data across our different Services and GatheringForGood affiliated entities.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceRelatedServicesShortParaNameReferenceForPrivacyPage();
            Assert.Equal(RelatedServicesShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceRelatedServicesPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string RelatedServicesPara1 = _loc.GetLocalizedString("en", "We will share your personal data with our affiliates to provide and develop our Services. We may combine information internally across the different Services covered by this Privacy Policy to help our Services be more relevant and useful to you and others. For example, we may personalize your feed or community recommendations based on your history of engagement with different causes.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceRelatedServicesPara1NameReferenceForPrivacyPage();
            Assert.Equal(RelatedServicesPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceServiceProvidersTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string ServiceProvidersTitle = _loc.GetLocalizedString("en", "Service Providers", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceServiceProvidersTitleNameReferenceForPrivacyPage();
            Assert.Equal(ServiceProvidersTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceServiceProvidersShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string ServiceProvidersShortPara = _loc.GetLocalizedString("en", "We may use others to help us with our Services.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceServiceProvidersShortParaNameReferenceForPrivacyPage();
            Assert.Equal(ServiceProvidersShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceServiceProvidersPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string ServiceProvidersPara1 = _loc.GetLocalizedString("en", "We use others to help us provide our Services (e.g., maintenance, analysis, audit, payments, fraud detection, marketing etc.). They will have access to your information as reasonably necessary to perform these tasks on our behalf and are obligated not to disclose or use it for other purposes.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceServiceProvidersPara1NameReferenceForPrivacyPage();
            Assert.Equal(ServiceProvidersPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceLegalDisclosuresTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string LegalDisclosuresTitle = _loc.GetLocalizedString("en", "Legal Disclosures", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceLegalDisclosuresTitleNameReferenceForPrivacyPage();
            Assert.Equal(LegalDisclosuresTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceLegalDisclosuresShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string LegalDisclosuresShortPara = _loc.GetLocalizedString("en", "We will share your data when we believe it’s required by law or to help protect the rights and safety of you, us or others.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceLegalDisclosuresShortParaNameReferenceForPrivacyPage();
            Assert.Equal(LegalDisclosuresShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceLegalDisclosuresPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string LegalDisclosuresPara1 = _loc.GetLocalizedString("en", "It is possible that we will need to disclose information about you when required by law, subpoena, or other legal process or if we have a good faith belief that disclosure is reasonably necessary to (1) investigate, prevent or take action regarding suspected or actual illegal activities or to assist government enforcement agencies; (2) enforce our agreements with you; (3) investigate and defend ourselves against any third-party claims or allegations; (4) protect the security or integrity of our Services (such as by sharing with companies facing similar threats); or (5) exercise or protect the rights and safety of GatheringForGood, our Members, personnel or others.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceLegalDisclosuresPara1NameReferenceForPrivacyPage();
            Assert.Equal(LegalDisclosuresPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceLegalDisclosuresPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string LegalDisclosuresPara2 = _loc.GetLocalizedString("en", "We attempt to notify Members about legal demands for their personal data when appropriate in our judgment, unless prohibited by law or court order or when the request is an emergency. We may dispute such demands when we believe, in our discretion, that the requests are excessive, overly broad, vague or lack proper authority, but we do not promise to challenge every demand.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceLegalDisclosuresPara2NameReferenceForPrivacyPage();
            Assert.Equal(LegalDisclosuresPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceChangeInControlTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string ChangeInControlTitle = _loc.GetLocalizedString("en", "Sale, Investment or Change in Control", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceChangeInControlTitleNameReferenceForPrivacyPage();
            Assert.Equal(ChangeInControlTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceChangeInControlShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string ChangeInControlShortPara = _loc.GetLocalizedString("en", "We may share your data when our business receives investment or is sold to others.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceChangeInControlShortParaNameReferenceForPrivacyPage();
            Assert.Equal(ChangeInControlShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceChangeInControlPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string ChangeInControlPara1 = _loc.GetLocalizedString("en", "We can also share your personal data as part of an investment process, a sale, merger or change in control, or in preparation for any of these events. Any other entity which buys us or part of our business will have the right to continue to use your data, but only in the manner set out in this Privacy Policy unless you agree otherwise.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceChangeInControlPara1NameReferenceForPrivacyPage();
            Assert.Equal(ChangeInControlPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDataRetentionTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string DataRetentionTitle = _loc.GetLocalizedString("en", "Data Retention", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDataRetentionTitleNameReferenceForPrivacyPage();
            Assert.Equal(DataRetentionTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDataRetentionShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string DataRetentionShortPara = _loc.GetLocalizedString("en", "We keep your personal data, where applicable in an identifiable form, as long as your account is open, or longer if required by law.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDataRetentionShortParaNameReferenceForPrivacyPage();
            Assert.Equal(DataRetentionShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDataRetentionPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string DataRetentionPara1 = _loc.GetLocalizedString("en", "We generally retain your personal data as long as you keep your account open or as needed to provide you Services. This includes data you or others provided to us and data generated or inferred from your use of our Services. Even if you only use our Services every few years, we will retain your information and keep your profile open, unless you close your account. In some cases we choose to retain certain information (e.g. insights about Services use) after the closure of your account in a depersonalized or aggregated form.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDataRetentionPara1NameReferenceForPrivacyPage();
            Assert.Equal(DataRetentionPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDataAccessControlTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string DataAccessControlTitle = _loc.GetLocalizedString("en", "Personal Data Access and Control", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDataAccessControlTitleNameReferenceForPrivacyPage();
            Assert.Equal(DataAccessControlTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDataAccessControlShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string DataAccessControlShortPara = _loc.GetLocalizedString("en", "You can access, change or delete your personal data.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDataAccessControlShortParaNameReferenceForPrivacyPage();
            Assert.Equal(DataAccessControlShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDataAccessControlPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string DataAccessControlPara1 = _loc.GetLocalizedString("en", "We offer you settings to control and manage the personal data we have about you. For personal data that we have about you, you can: ", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDataAccessControlPara1NameReferenceForPrivacyPage();
            Assert.Equal(DataAccessControlPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDataAccessControlPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string DataAccessControlPara2 = _loc.GetLocalizedString("en", "You can ask us to erase or delete all or some of your personal data (e.g. if it is no longer necessary to provide Services to you).", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDataAccessControlPara2NameReferenceForPrivacyPage();
            Assert.Equal(DataAccessControlPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDataAccessControlPara3NameReferenceForPrivacyPageIsCorrect()
        {
            string DataAccessControlPara3 = _loc.GetLocalizedString("en", "You can edit some of your personal data through your account. You can also ask us to change, update or fix your data in certain cases, particularly if it’s inaccurate.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDataAccessControlPara3NameReferenceForPrivacyPage();
            Assert.Equal(DataAccessControlPara3, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDataAccessControlPara4NameReferenceForPrivacyPageIsCorrect()
        {
            string DataAccessControlPara4 = _loc.GetLocalizedString("en", "You can ask us for a copy of your personal data and can ask for a copy of personal data you provided in machine readable form.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDataAccessControlPara4NameReferenceForPrivacyPage();
            Assert.Equal(DataAccessControlPara4, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDeleteDataNameReferenceForPrivacyPageIsCorrect()
        {
            string DeleteData = _loc.GetLocalizedString("en", "Delete Your Data.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDeleteDataNameReferenceForPrivacyPage();
            Assert.Equal(DeleteData, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceChangeDataNameReferenceForPrivacyPageIsCorrect()
        {
            string ChangeData = _loc.GetLocalizedString("en", "Change Your Data.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceChangeDataNameReferenceForPrivacyPage();
            Assert.Equal(ChangeData, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceAccessDataNameReferenceForPrivacyPageIsCorrect()
        {
            string AccessData = _loc.GetLocalizedString("en", "Access Your Data.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceAccessDataNameReferenceForPrivacyPage();
            Assert.Equal(AccessData, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDeleteAccountTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string DeleteAccountTitle = _loc.GetLocalizedString("en", "Closing Your Account", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDeleteAccountTitleNameReferenceForPrivacyPage();
            Assert.Equal(DeleteAccountTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDeleteAccountShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string DeleteAccountShortPara = _loc.GetLocalizedString("en", "We keep some of your data even after you close your account.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDeleteAccountShortParaNameReferenceForPrivacyPage();
            Assert.Equal(DeleteAccountShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDeleteAccountPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string DeleteAccountPara1 = _loc.GetLocalizedString("en", "If you decide to close your GatheringForGood account, your personal data will generally stop being visible to others on our Services within 72 hours. We delete closed account information as soon as possible following account closure, except as noted below.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDeleteAccountPara1NameReferenceForPrivacyPage();
            Assert.Equal(DeleteAccountPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDeleteAccountPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string DeleteAccountPara2 = _loc.GetLocalizedString("en", "We retain your personal data even after you have closed your account if reasonably necessary to comply with our legal obligations (including law enforcement requests), meet regulatory requirements, resolve disputes, maintain security, prevent fraud and abuse (e.g. if we have restricted your account for breach of our Policies. Terms and Conditions or for behaviour which we otherwise deem to be unsuitable for our Services), enforce our User Agreement, or fulfill your request to unsubscribe from further messages from us. We will retain de-personalized information after your account has been closed.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDeleteAccountPara2NameReferenceForPrivacyPage();
            Assert.Equal(DeleteAccountPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceDeleteAccountPara3NameReferenceForPrivacyPageIsCorrect()
        {
            string DeleteAccountPara3 = _loc.GetLocalizedString("en", "Information you have shared with others (e.g. through messages, updates or group posts) will remain visible after you close your account or delete the information from your own profile or mailbox. We also do not control data that other Members have copied out of our Services. Groups content and ratings or review content associated with closed accounts will show an unknown user as the source. Your profile may continue to be displayed in the services of others (e.g. search engine results) until they refresh their cache.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceDeleteAccountPara3NameReferenceForPrivacyPage();
            Assert.Equal(DeleteAccountPara3, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSecurityTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string SecurityTitle = _loc.GetLocalizedString("en", "Account Security", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceSecurityTitleNameReferenceForPrivacyPage();
            Assert.Equal(SecurityTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSecurityShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string SecurityShortPara = _loc.GetLocalizedString("en", "We implement features to try to prevent security breaches. Please use the security features available through our Services.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceSecurityShortParaNameReferenceForPrivacyPage();
            Assert.Equal(SecurityShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSecurityPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string SecurityPara1 = _loc.GetLocalizedString("en", "We implement security safeguards designed to protect your data, such as HTTPS. However, we cannot warrant the security of any information that you send us.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceSecurityPara1NameReferenceForPrivacyPage();
            Assert.Equal(SecurityPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceSecurityPara2NameReferenceForPrivacyPageIsCorrect()
        {
            string SecurityPara2 = _loc.GetLocalizedString("en", "There is no guarantee that data you send us may not be accessed, disclosed, altered, or destroyed by breach of any of our physical, technical, or managerial safeguards. By using our Services you acknowledge that no technology is completely secure.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceSecurityPara2NameReferenceForPrivacyPage();
            Assert.Equal(SecurityPara2, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCrossBorderDataTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string CrossBorderDataTitle = _loc.GetLocalizedString("en", "Cross-Border Data Transfers", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceCrossBorderDataTitleNameReferenceForPrivacyPage();
            Assert.Equal(CrossBorderDataTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCrossBorderDataShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string CrossBorderDataShortPara = _loc.GetLocalizedString("en", "We may store and use your data outside your country.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceCrossBorderDataShortParaNameReferenceForPrivacyPage();
            Assert.Equal(CrossBorderDataShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceCrossBorderDataPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string CrossBorderDataPara1 = _loc.GetLocalizedString("en", "Our data storage and processing currently takes place inside the European Union. Countries where we process data may have laws which are different from, and potentially not as protective as, the laws of your own country.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceCrossBorderDataPara1NameReferenceForPrivacyPage();
            Assert.Equal(CrossBorderDataPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceProcessingLawfulBasisTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string ProcessingLawfulBasisTitle = _loc.GetLocalizedString("en", "Lawful Basis for Processing", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceProcessingLawfulBasisTitleNameReferenceForPrivacyPage();
            Assert.Equal(ProcessingLawfulBasisTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceProcessingLawfulBasisShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string ProcessingLawfulBasisShortPara = _loc.GetLocalizedString("en", "We have lawful bases to collect, use and share data about you.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceProcessingLawfulBasisShortParaNameReferenceForPrivacyPage();
            Assert.Equal(ProcessingLawfulBasisShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceProcessingLawfulBasisPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string ProcessingLawfulBasisPara1 = _loc.GetLocalizedString("en", "We will only collect and process personal data about you where we have a lawful basis for doing so. Lawful basis includes consent (where you have given consent), contract (where processing is necessary for the performance of a contract with you (e.g. to deliver the GatheringForGood Services you have requested) and “legitimate interests”. Where we rely on your consent to process personal data, you have the right to withdraw or decline your consent at any time and where we rely on legitimate interests, you have the right to object. If you have any questions about the lawful basis upon which we collect and use your personal data, please contact us.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceProcessingLawfulBasisPara1NameReferenceForPrivacyPage();
            Assert.Equal(ProcessingLawfulBasisPara1, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceContactUsTitleNameReferenceForPrivacyPageIsCorrect()
        {
            string ContactUsTitle = _loc.GetLocalizedString("en", "Contact Information", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceContactUsTitleNameReferenceForPrivacyPage();
            Assert.Equal(ContactUsTitle, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceContactUsShortParaNameReferenceForPrivacyPageIsCorrect()
        {
            string ContactUsShortPara = _loc.GetLocalizedString("en", "Please contact us if you have any questions regarding your data.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceContactUsShortParaNameReferenceForPrivacyPage();
            Assert.Equal(ContactUsShortPara, ReturnedNameKeyValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Owner", "DM")]
        [Trait("RunTime", "Short")]
        [Trait("TestEnvironment", "Local")]
        public void LocSourceContactUsPara1NameReferenceForPrivacyPageIsCorrect()
        {
            string ContactUsPara1 = _loc.GetLocalizedString("en", "If you have questions or complaints regarding this Policy, please contact us.", null);
            var PrivacyPageLocSourceNamesLibrary = new PrivacyPageLocSourceNames();
            string ReturnedNameKeyValue = PrivacyPageLocSourceNamesLibrary.GetLocSourceContactUsPara1NameReferenceForPrivacyPage();
            Assert.Equal(ContactUsPara1, ReturnedNameKeyValue);
        }
    }
}
