using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using GatheringForGood.Models;
using LocSourceNameReferenceLibrary;
using ImageUrlReferenceLibrary;
using Microsoft.AspNetCore.Authorization;
using GatheringForGood.Areas.FunctionalLogic;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace GatheringForGood.Controllers
{
    [AllowAnonymous]
    public class PrivacyController : Controller
    {
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();

        private readonly IEmailSender _emailSender;

        public PrivacyController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public IActionResult Privacy()
        {
            PrivacyPageLocSourceNames _locSourcePrivacyPageNameReferenceLibrary = new PrivacyPageLocSourceNames();
            SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
            SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();

            var viewModel = new PrivacyViewModel
            {
                PageTabTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForPrivacyPage(),
                ButtonText = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceButtonTextNameReference(),
                Title = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForPrivacyPage(),
                Subtitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForPrivacyPage(),
                YourPrivacyMattersTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceYourPrivacyMattersTitleNameReferenceForPrivacyPage(),
                PrivacyEffectiveDate = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePrivacyEffectiveDateNameReferenceForPrivacyPage(),
                PrivacyTableOfContentsTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePrivacyTableOfContentsTitleNameReferenceForPrivacyPage(),
                PrivacyIntroductionLink = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePrivacyIntroductionLinkNameReferenceForPrivacyPage(),
                PrivacyDataWeCollectLink = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePrivacyDataWeCollectLinkNameReferenceForPrivacyPage(),
                PrivacyHowWeUseYourDataLink = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePrivacyHowWeUseYourDataLinkNameReferenceForPrivacyPage(),
                PrivacyHowWeShareInformationLink = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePrivacyHowWeShareInformationLinkNameReferenceForPrivacyPage(),
                PrivacyChoicesAndObligationsLink = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePrivacyChoicesAndObligationsLinkNameReferenceForPrivacyPage(),
                PrivacyOtherInformationLink = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePrivacyOtherInformationLinkNameReferenceForPrivacyPage(),
                YourPrivacyMattersPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceYourPrivacyMattersPara1NameReferenceForPrivacyPage(),
                YourPrivacyMattersPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceYourPrivacyMattersPara2NameReferenceForPrivacyPage(),
                IntroductionShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceIntroductionShortParaNameReferenceForPrivacyPage(),
                IntroductionPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceIntroductionPara1NameReferenceForPrivacyPage(),
                IntroductionPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceIntroductionPara2NameReferenceForPrivacyPage(),
                IntroductionPara3 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceIntroductionPara3NameReferenceForPrivacyPage(),
                Members = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceMembersNameReferenceForPrivacyPage(),
                Visitors = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceVisitorsNameReferenceForPrivacyPage(),
                ServicesTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceServicesTitleNameReferenceForPrivacyPage(),
                ServicesShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceServicesShortParaNameReferenceForPrivacyPage(),
                ServicesPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceServicesPara1NameReferenceForPrivacyPage(),
                ServicesPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceServicesPara2NameReferenceForPrivacyPage(),
                DataControllersTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDataControllersTitleNameReferenceForPrivacyPage(),
                DataControllersShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDataControllersShortParaNameReferenceForPrivacyPage(),
                DataControllersPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDataControllersPara1NameReferenceForPrivacyPage(),
                DataControllersPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDataControllersPara2NameReferenceForPrivacyPage(),
                PolicyChangesTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePolicyChangesTitleNameReferenceForPrivacyPage(),
                PolicyChangesShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePolicyChangesShortParaNameReferenceForPrivacyPage(),
                PolicyChangesPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePolicyChangesPara1NameReferenceForPrivacyPage(),
                PolicyChangesPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePolicyChangesPara2NameReferenceForPrivacyPage(),
                RegistrationTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceRegistrationTitleNameReferenceForPrivacyPage(),
                RegistrationShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceRegistrationShortParaNameReferenceForPrivacyPage(),
                RegistrationPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceRegistrationPara1NameReferenceForPrivacyPage(),
                ProfileTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceProfileTitleNameReferenceForPrivacyPage(),
                ProfileShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceProfileShortParaNameReferenceForPrivacyPage(),
                ProfilePara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceProfilePara1NameReferenceForPrivacyPage(),
                ProfilePara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceProfilePara2NameReferenceForPrivacyPage(),
                PostingTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePostingTitleNameReferenceForPrivacyPage(),
                PostingShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePostingShortParaNameReferenceForPrivacyPage(),
                PostingPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePostingPara1NameReferenceForPrivacyPage(),
                PostingPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePostingPara2NameReferenceForPrivacyPage(),
                PostingPara3 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePostingPara3NameReferenceForPrivacyPage(),
                ContentTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceContentTitleNameReferenceForPrivacyPage(),
                ContentShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceContentShortParaNameReferenceForPrivacyPage(),
                ContentPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceContentPara1NameReferenceForPrivacyPage(),
                ContactsAndCalendarTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceContactsAndCalendarTitleNameReferenceForPrivacyPage(),
                ContactsAndCalendarShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceContactsAndCalendarShortParaNameReferenceForPrivacyPage(),
                ContactsAndCalendarPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceContactsAndCalendarPara1NameReferenceForPrivacyPage(),
                CustomersAndPartnersTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceCustomersAndPartnersTitleNameReferenceForPrivacyPage(),
                CustomersAndPartnersShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceCustomersAndPartnersShortParaNameReferenceForPrivacyPage(),
                CustomersAndPartnersPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceCustomersAndPartnersPara1NameReferenceForPrivacyPage(),
                ServiceUsageTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceServiceUsageTitleNameReferenceForPrivacyPage(),
                ServiceUsageShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceServiceUsageShortParaNameReferenceForPrivacyPage(),
                ServiceUsagePara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceServiceUsagePara1NameReferenceForPrivacyPage(),
                CookiesTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceCookiesTitleNameReferenceForPrivacyPage(),
                CookiesShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceCookiesShortParaNameReferenceForPrivacyPage(),
                CookiesPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceCookiesPara1NameReferenceForPrivacyPage(),
                CookiesPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceCookiesPara2NameReferenceForPrivacyPage(),
                CookiesPara3 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceCookiesPara3NameReferenceForPrivacyPage(),
                CookiePolicy = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceCookiePolicyNameReferenceForPrivacyPage(),
                DevicesAndLocationTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDevicesAndLocationTitleNameReferenceForPrivacyPage(),
                DevicesAndLocationShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDevicesAndLocationShortParaNameReferenceForPrivacyPage(),
                DevicesAndLocationPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDevicesAndLocationPara1NameReferenceForPrivacyPage(),
                MessagesTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceMessagesTitleNameReferenceForPrivacyPage(),
                MessagesShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceMessagesShortParaNameReferenceForPrivacyPage(),
                MessagesPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceMessagesPara1NameReferenceForPrivacyPage(),
                MessagesPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceMessagesPara2NameReferenceForPrivacyPage(),
                MessagesPara3 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceMessagesPara3NameReferenceForPrivacyPage(),
                TermsConditions = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceTermsConditionsNameReferenceForPrivacyPage(),
                MemberPolicies = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceMemberPoliciesNameReferenceForPrivacyPage(),
                SchoolAndOthersInfoTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceSchoolAndOthersInfoTitleNameReferenceForPrivacyPage(),
                SchoolAndOthersInfoShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceSchoolAndOthersInfoShortParaNameReferenceForPrivacyPage(),
                SchoolAndOthersInfoPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceSchoolAndOthersInfoPara1NameReferenceForPrivacyPage(),
                SchoolAndOthersInfoPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceSchoolAndOthersInfoPara2NameReferenceForPrivacyPage(),
                OtherSitesAndServicesTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceOtherSitesAndServicesTitleNameReferenceForPrivacyPage(),
                OtherSitesAndServicesShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceOtherSitesAndServicesShortParaNameReferenceForPrivacyPage(),
                OtherSitesAndServicesPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceOtherSitesAndServicesPara1NameReferenceForPrivacyPage(),
                OtherDataWeCollectTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceOtherDataWeCollectTitleNameReferenceForPrivacyPage(),
                OtherDataWeCollectShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceOtherDataWeCollectShortParaNameReferenceForPrivacyPage(),
                OtherDataWeCollectPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceOtherDataWeCollectPara1NameReferenceForPrivacyPage(),
                HowWeUseYourDataShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceHowWeUseYourDataShortParaNameReferenceForPrivacyPage(),
                HowWeUseYourDataPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceHowWeUseYourDataPara1NameReferenceForPrivacyPage(),
                ConnectAndStayConnectedTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceConnectAndStayConnectedTitleNameReferenceForPrivacyPage(),
                ConnectAndStayConnectedShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceConnectAndStayConnectedShortParaNameReferenceForPrivacyPage(),
                ConnectAndStayConnectedPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceConnectAndStayConnectedPara1NameReferenceForPrivacyPage(),
                ConnectAndStayConnectedPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceConnectAndStayConnectedPara2NameReferenceForPrivacyPage(),
                ConnectAndStayConnectedPara3 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceConnectAndStayConnectedPara3NameReferenceForPrivacyPage(),
                StayInformedTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceStayInformedTitleNameReferenceForPrivacyPage(),
                StayInformedShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceStayInformedShortParaNameReferenceForPrivacyPage(),
                StayInformedPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceStayInformedPara1NameReferenceForPrivacyPage(),
                StayInformedPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceStayInformedPara2NameReferenceForPrivacyPage(),
                ProductivityTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceProductivityTitleNameReferenceForPrivacyPage(),
                ProductivityShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceProductivityShortParaNameReferenceForPrivacyPage(),
                ProductivityPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceProductivityPara1NameReferenceForPrivacyPage(),
                PaidPremiumServicesTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePaidPremiumServicesTitleNameReferenceForPrivacyPage(),
                PaidPremiumServicesShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePaidPremiumServicesShortParaNameReferenceForPrivacyPage(),
                PaidPremiumServicesPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePaidPremiumServicesPara1NameReferenceForPrivacyPage(),
                PaidPremiumServicesPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePaidPremiumServicesPara2NameReferenceForPrivacyPage(),
                CommunicationsTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceCommunicationsTitleNameReferenceForPrivacyPage(),
                CommunicationsShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceCommunicationsShortParaNameReferenceForPrivacyPage(),
                CommunicationsPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceCommunicationsPara1NameReferenceForPrivacyPage(),
                CommunicationsPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceCommunicationsPara2NameReferenceForPrivacyPage(),
                AdvertisingTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceAdvertisingTitleNameReferenceForPrivacyPage(),
                AdvertisingShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceAdvertisingShortParaNameReferenceForPrivacyPage(),
                AdvertisingPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceAdvertisingPara1NameReferenceForPrivacyPage(),
                AdvertisingPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceAdvertisingPara2NameReferenceForPrivacyPage(),
                AdvertisingPara3 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceAdvertisingPara3NameReferenceForPrivacyPage(),
                AdvertisingPara4 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceAdvertisingPara4NameReferenceForPrivacyPage(),
                AdvertisingPara5 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceAdvertisingPara5NameReferenceForPrivacyPage(),
                AdvertisingPara6 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceAdvertisingPara6NameReferenceForPrivacyPage(),
                AdvertisingPara7 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceAdvertisingPara7NameReferenceForPrivacyPage(),
                AdChoicesTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceAdChoicesTitleNameReferenceForPrivacyPage(),
                AdChoicesShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceAdChoicesShortParaNameReferenceForPrivacyPage(),
                AdChoicesPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceAdChoicesPara1NameReferenceForPrivacyPage(),
                InfoToAdProvidersTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceInfoToAdProvidersTitleNameReferenceForPrivacyPage(),
                InfoToAdProvidersShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceInfoToAdProvidersShortParaNameReferenceForPrivacyPage(),
                InfoToAdProvidersPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceInfoToAdProvidersPara1NameReferenceForPrivacyPage(),
                MarketingTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceMarketingTitleNameReferenceForPrivacyPage(),
                MarketingShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceMarketingShortParaNameReferenceForPrivacyPage(),
                MarketingPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceMarketingPara1NameReferenceForPrivacyPage(),
                ServiceDevelopmentTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceServiceDevelopmentTitleNameReferenceForPrivacyPage(),
                ServiceDevelopmentShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceServiceDevelopmentShortParaNameReferenceForPrivacyPage(),
                ServiceDevelopmentPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceServiceDevelopmentPara1NameReferenceForPrivacyPage(),
                OtherResearchTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceOtherResearchTitleNameReferenceForPrivacyPage(),
                OtherResearchShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceOtherResearchShortParaNameReferenceForPrivacyPage(),
                OtherResearchPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceOtherResearchPara1NameReferenceForPrivacyPage(),
                OtherResearchPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceOtherResearchPara2NameReferenceForPrivacyPage(),
                PollsAndSurveysTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePollsAndSurveysTitleNameReferenceForPrivacyPage(),
                PollsAndSurveysShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePollsAndSurveysShortParaNameReferenceForPrivacyPage(),
                PollsAndSurveysPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePollsAndSurveysPara1NameReferenceForPrivacyPage(),
                CustomerSupportTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceCustomerSupportTitleNameReferenceForPrivacyPage(),
                CustomerSupportShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceCustomerSupportShortParaNameReferenceForPrivacyPage(),
                CustomerSupportPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceCustomerSupportPara1NameReferenceForPrivacyPage(),
                NonIdentifyingInsightsTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceNonIdentifyingInsightsTitleNameReferenceForPrivacyPage(),
                NonIdentifyingInsightsShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceNonIdentifyingInsightsShortParaNameReferenceForPrivacyPage(),
                NonIdentifyingInsightsPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceNonIdentifyingInsightsPara1NameReferenceForPrivacyPage(),
                SecurityInvestigationsTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceSecurityInvestigationsTitleNameReferenceForPrivacyPage(),
                SecurityInvestigationsShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceSecurityInvestigationsShortParaNameReferenceForPrivacyPage(),
                SecurityInvestigationsPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceSecurityInvestigationsPara1NameReferenceForPrivacyPage(),
                YourProfileTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceYourProfileTitleNameReferenceForPrivacyPage(),
                YourProfileShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceYourProfileShortParaNameReferenceForPrivacyPage(),
                YourProfilePara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceYourProfilePara1NameReferenceForPrivacyPage(),
                PostsLikesTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePostsLikesTitleNameReferenceForPrivacyPage(),
                PostsLikesShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePostsLikesShortParaNameReferenceForPrivacyPage(),
                PostsLikesPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePostsLikesPara1NameReferenceForPrivacyPage(),
                PostsLikesPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePostsLikesPara2NameReferenceForPrivacyPage(),
                PostsLikesPara3 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePostsLikesPara3NameReferenceForPrivacyPage(),
                PostsLikesPara4 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePostsLikesPara4NameReferenceForPrivacyPage(),
                PostsLikesPara5 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePostsLikesPara5NameReferenceForPrivacyPage(),
                PostsLikesPara6 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePostsLikesPara6NameReferenceForPrivacyPage(),
                PostsLikesPara7 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourcePostsLikesPara7NameReferenceForPrivacyPage(),
                EnterpriseAccountsTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceEnterpriseAccountsTitleNameReferenceForPrivacyPage(),
                EnterpriseAccountsShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceEnterpriseAccountsShortParaNameReferenceForPrivacyPage(),
                EnterpriseAccountsPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceEnterpriseAccountsPara1NameReferenceForPrivacyPage(),
                OthersServicesTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceOthersServicesTitleNameReferenceForPrivacyPage(),
                OthersServicesShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceOthersServicesShortParaNameReferenceForPrivacyPage(),
                OthersServicesPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceOthersServicesPara1NameReferenceForPrivacyPage(),
                OthersServicesPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceOthersServicesPara2NameReferenceForPrivacyPage(),
                RelatedServicesTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceRelatedServicesTitleNameReferenceForPrivacyPage(),
                RelatedServicesShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceRelatedServicesShortParaNameReferenceForPrivacyPage(),
                RelatedServicesPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceRelatedServicesPara1NameReferenceForPrivacyPage(),
                ServiceProvidersTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceServiceProvidersTitleNameReferenceForPrivacyPage(),
                ServiceProvidersShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceServiceProvidersShortParaNameReferenceForPrivacyPage(),
                ServiceProvidersPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceServiceProvidersPara1NameReferenceForPrivacyPage(),
                LegalDisclosuresTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceLegalDisclosuresTitleNameReferenceForPrivacyPage(),
                LegalDisclosuresShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceLegalDisclosuresShortParaNameReferenceForPrivacyPage(),
                LegalDisclosuresPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceLegalDisclosuresPara1NameReferenceForPrivacyPage(),
                LegalDisclosuresPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceLegalDisclosuresPara2NameReferenceForPrivacyPage(),
                ChangeInControlTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceChangeInControlTitleNameReferenceForPrivacyPage(),
                ChangeInControlShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceChangeInControlShortParaNameReferenceForPrivacyPage(),
                ChangeInControlPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceChangeInControlPara1NameReferenceForPrivacyPage(),
                DataRetentionTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDataRetentionTitleNameReferenceForPrivacyPage(),
                DataRetentionShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDataRetentionShortParaNameReferenceForPrivacyPage(),
                DataRetentionPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDataRetentionPara1NameReferenceForPrivacyPage(),
                DataAccessControlTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDataAccessControlTitleNameReferenceForPrivacyPage(),
                DataAccessControlShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDataAccessControlShortParaNameReferenceForPrivacyPage(),
                DataAccessControlPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDataAccessControlPara1NameReferenceForPrivacyPage(),
                DataAccessControlPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDataAccessControlPara2NameReferenceForPrivacyPage(),
                DataAccessControlPara3 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDataAccessControlPara3NameReferenceForPrivacyPage(),
                DataAccessControlPara4 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDataAccessControlPara4NameReferenceForPrivacyPage(),
                DeleteData = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDeleteDataNameReferenceForPrivacyPage(),
                ChangeData = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceChangeDataNameReferenceForPrivacyPage(),
                AccessData = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceAccessDataNameReferenceForPrivacyPage(),
                DeleteAccountTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDeleteAccountTitleNameReferenceForPrivacyPage(),
                DeleteAccountShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDeleteAccountShortParaNameReferenceForPrivacyPage(),
                DeleteAccountPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDeleteAccountPara1NameReferenceForPrivacyPage(),
                DeleteAccountPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDeleteAccountPara2NameReferenceForPrivacyPage(),
                DeleteAccountPara3 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceDeleteAccountPara3NameReferenceForPrivacyPage(),
                SecurityTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceSecurityTitleNameReferenceForPrivacyPage(),
                SecurityShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceSecurityShortParaNameReferenceForPrivacyPage(),
                SecurityPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceSecurityPara1NameReferenceForPrivacyPage(),
                SecurityPara2 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceSecurityPara2NameReferenceForPrivacyPage(),
                CrossBorderDataTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceCrossBorderDataTitleNameReferenceForPrivacyPage(),
                CrossBorderDataShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceCrossBorderDataShortParaNameReferenceForPrivacyPage(),
                CrossBorderDataPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceCrossBorderDataPara1NameReferenceForPrivacyPage(),
                ProcessingLawfulBasisTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceProcessingLawfulBasisTitleNameReferenceForPrivacyPage(),
                ProcessingLawfulBasisShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceProcessingLawfulBasisShortParaNameReferenceForPrivacyPage(),
                ProcessingLawfulBasisPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceProcessingLawfulBasisPara1NameReferenceForPrivacyPage(),
                ContactUsTitle = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceContactUsTitleNameReferenceForPrivacyPage(),
                ContactUsShortPara = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceContactUsShortParaNameReferenceForPrivacyPage(),
                ContactUsPara1 = _locSourcePrivacyPageNameReferenceLibrary.GetLocSourceContactUsPara1NameReferenceForPrivacyPage(),
                NavBarHome = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceHomeLabelNameReference(),
                NavBarNewsfeed = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNewsfeedLabelNameReference(),
                NavBarAbout = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceAboutLabelNameReference(),
                NavBarHelpCenter = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceHelpCenterLabelNameReference(),
                NavBarRegister = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceRegisterLabelNameReference(),
                NavBarLogin = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLoginLabelNameReference(),
                NavBarLogout = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLogoutLabelNameReference(),
                AboutUs = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceAboutUsLabelNameReference(),
                Articles = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceArticlesLabelNameReference(),
                CookiesNotice = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceCookiesNoticeLabelNameReference(),
                PrivacyNotice = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourcePrivacyNoticeLabelNameReference(),
                ComingSoon = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceComingSoonLabelNameReference(),
                LikeToSee = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLikeToSeeLabelNameReference(),
                Submit = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceSubmitLabelNameReference(),
                Updates = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceUpdatesNameReferenceForPage(),
                HomepageShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20are%20taking%20action%20to%20help%20save%20the%20world!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                IconTwitter = _SharedCrossPageImageUrlLibrary.GetTwitterIconUrlForPage(),
                IconLinkedin = _SharedCrossPageImageUrlLibrary.GetLinkedinIconUrlForPage(),
                IconFacebook = _SharedCrossPageImageUrlLibrary.GetFacebookIconUrlForPage(),
                GetEarthHandsReducedImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReducedImageUrlForPage(),
                GetEarthHandsReduced400ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced400ImageUrlForPage(),
                GetEarthHandsReduced800ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced800ImageUrlForPage(),
                GetEarthHandsReduced1200ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced1200ImageUrlForPage(),
                GetEarthHandsReduced1600ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced1600ImageUrlForPage()
            };
            return View(viewModel);
        }

        public IActionResult OnGetSetCultureCookie(string cltr, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(cltr)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
                );

            return LocalRedirect(returnUrl);
        }

        [HttpPost]
        public async Task<IActionResult> SaveUserEntryAsync(string newsfeedUserEntry)
        {
            DateTime FeedbackDateTime = DateTime.UtcNow;

            if (newsfeedUserEntry != null)
            {
                string userId = ClaimsPrincipalExtensions.GetUserId<string>(User);
                if (userId != null)
                {
                    bool loggedInUser = true;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Privacy Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Privacy Page Newsfeed Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Privacy Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Privacy Page Newsfeed Modal", FeedbackDateTime);
                }
            }

            return RedirectToAction("Privacy");
        }
    }
}
