using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using GatheringForGood.Models;
using LocSourceNameReferenceLibrary;
using ImageUrlReferenceLibrary;
using GatheringForGood.Areas.FunctionalLogic;
using GatheringForGood.Data;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;

namespace GatheringForGood.Controllers
{
    public class UserBadgesController : Controller
    {
        private readonly ApplicationDbContext _context;
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        private readonly IEmailSender _emailSender;

        public UserBadgesController(ApplicationDbContext context, IEmailSender emailSender)
        {
            _context = context;
            _emailSender = emailSender;
        }

        [HttpGet]
        public IActionResult UserBadges()
        {

            UserBadgesPageLocSourceNames _locSourceUserBadgesPageNameReferenceLibrary = new UserBadgesPageLocSourceNames();
            UserBadgesPageImageUrls _UserBadgesPageImageUrlLibrary = new UserBadgesPageImageUrls();
            SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
            SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();

            string userId = ClaimsPrincipalExtensions.GetUserId<string>(User);
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            var userBadgeStatus = _context.UserBadges.SingleOrDefault(a => a.UserId == userId);
            var FirstStepUrl = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            var GathererForGoodUrl = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            var BuildingBackBetterUrl = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            var KeyChangeDriverUrl = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            var DefeatGWUrl = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            var DefeatAEUrl = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            var DefeatDFUrl = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            var DeeplyCareUrl = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            var CommunicatingForDifferenceUrl = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            var LearningForGoodUrl = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            var MakingADifferenceUrl = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            var ContributorUrl = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            var FeedbackHeroUrl = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            var HelpfulUrl = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            var LeaderUrl = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            var VisionaryUrl = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            var ThankyouUrl = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            
            if (userBadgeStatus != null)
            {
                var FirstStepValue = userBadgeStatus.FirstStep;
                var GathererForGoodValue = userBadgeStatus.GathererForGood;
                var BuildingBackBetterValue = userBadgeStatus.BuildingBackBetter;
                var KeyChangeDriverValue = userBadgeStatus.KeyDriverOfChange;
                var DefeatGWValue = userBadgeStatus.DefeatGlobalWarming;
                var DefeatAEValue = userBadgeStatus.DefeatAnimalExtinction;
                var DefeatDFValue = userBadgeStatus.DefeatDeforestation;
                var DeeplyCareValueStartDate = Convert.ToDateTime(userBadgeStatus.PlanetCareStartDate);
                var EndDate = DateTime.Today;
                var CommunicatingForDifferenceValue = userBadgeStatus.CommunicatingForDifference;
                var LearningForGoodValue = userBadgeStatus.LearningForGood;
                var MakingADifferenceValue = userBadgeStatus.MakingADifference;
                var ContributorValue = userBadgeStatus.ContributorForGood;
                var FeedbackHeroValue = userBadgeStatus.FeedbackHero;
                var HelpfulValue = userBadgeStatus.Helpful;
                var LeaderValue = userBadgeStatus.Leader;
                var VisionaryValue = userBadgeStatus.Visionary;
                var ThankyouValue = userBadgeStatus.Thankyou;

                if (FirstStepValue > 0)
                {
                    FirstStepUrl = _UserBadgesPageImageUrlLibrary.GetFirstStepImageThumbnailUrlForUserBadgesPage();
                }
                else
                {
                    FirstStepUrl = _UserBadgesPageImageUrlLibrary.GetFirstStepGreyImageThumbnailUrlForUserBadgesPage();
                }

                if (GathererForGoodValue >= 5)
                {
                    GathererForGoodUrl = _UserBadgesPageImageUrlLibrary.GetGathererForGoodImageThumbnailUrlForUserBadgesPage();
                }
                else
                {
                    GathererForGoodUrl = _UserBadgesPageImageUrlLibrary.GetGathererForGoodGreyImageThumbnailUrlForUserBadgesPage();
                }

                if (BuildingBackBetterValue >= 2)
                {
                    BuildingBackBetterUrl = _UserBadgesPageImageUrlLibrary.GetBuildingBackBetterImageThumbnailUrlForUserBadgesPage();
                }
                else
                {
                    BuildingBackBetterUrl = _UserBadgesPageImageUrlLibrary.GetBuildingBackBetterGreyImageThumbnailUrlForUserBadgesPage();
                }

                if (KeyChangeDriverValue >= 25)
                {
                    KeyChangeDriverUrl = _UserBadgesPageImageUrlLibrary.GetKeyChangeDriverImageThumbnailUrlForUserBadgesPage();
                }
                else
                {
                    KeyChangeDriverUrl = _UserBadgesPageImageUrlLibrary.GetKeyChangeDriverGreyImageThumbnailUrlForUserBadgesPage();
                }

                if (DefeatGWValue >= 100)
                {
                    DefeatGWUrl = _UserBadgesPageImageUrlLibrary.GetDefeatGlobalWarmingImageThumbnailUrlForUserBadgesPage();
                }
                else
                {
                    DefeatGWUrl = _UserBadgesPageImageUrlLibrary.GetDefeatGlobalWarmingGreyImageThumbnailUrlForUserBadgesPage();
                }

                if (DefeatAEValue >= 100)
                {
                    DefeatAEUrl = _UserBadgesPageImageUrlLibrary.GetDefeatAnimalExtinctionImageThumbnailUrlForUserBadgesPage();
                }
                else
                {
                    DefeatAEUrl = _UserBadgesPageImageUrlLibrary.GetDefeatAnimalExtinctionGreyImageThumbnailUrlForUserBadgesPage();
                }

                if (DefeatDFValue >= 100)
                {
                    DefeatDFUrl = _UserBadgesPageImageUrlLibrary.GetDefeatDeforestationImageThumbnailUrlForUserBadgesPage();
                }
                else
                {
                    DefeatDFUrl = _UserBadgesPageImageUrlLibrary.GetDefeatDeforestationGreyImageThumbnailUrlForUserBadgesPage();
                }
                if (DeeplyCareValueStartDate.ToString() != "1/1/0001 12:00:00 AM" && (EndDate.Date - DeeplyCareValueStartDate.Date).Days >= 365)
                {
                    DeeplyCareUrl = _UserBadgesPageImageUrlLibrary.GetDeeplyCareImageThumbnailUrlForUserBadgesPage();
                }
                else
                {
                    DeeplyCareUrl = _UserBadgesPageImageUrlLibrary.GetDeeplyCareGreyImageThumbnailUrlForUserBadgesPage();
                }

                if (CommunicatingForDifferenceValue >= 5)
                {
                    CommunicatingForDifferenceUrl = _UserBadgesPageImageUrlLibrary.GetCommunicatingForDifferenceImageThumbnailUrlForUserBadgesPage();
                }
                else
                {
                    CommunicatingForDifferenceUrl = _UserBadgesPageImageUrlLibrary.GetCommunicatingForDifferenceGreyImageThumbnailUrlForUserBadgesPage();
                }

                if (LearningForGoodValue >= 10)
                {
                    LearningForGoodUrl = _UserBadgesPageImageUrlLibrary.GetLearningForGoodImageThumbnailUrlForUserBadgesPage();
                }
                else
                {
                    LearningForGoodUrl = _UserBadgesPageImageUrlLibrary.GetLearningForGoodGreyImageThumbnailUrlForUserBadgesPage();
                }

                if (MakingADifferenceValue > 0)
                {
                    MakingADifferenceUrl = _UserBadgesPageImageUrlLibrary.GetMakingADifferenceImageThumbnailUrlForUserBadgesPage();
                }
                else
                {
                    MakingADifferenceUrl = _UserBadgesPageImageUrlLibrary.GetMakingADifferenceGreyImageThumbnailUrlForUserBadgesPage();
                }

                if (ContributorValue > 0)
                {
                    ContributorUrl = _UserBadgesPageImageUrlLibrary.GetContributorImageThumbnailUrlForUserBadgesPage();
                }
                else
                {
                    ContributorUrl = _UserBadgesPageImageUrlLibrary.GetContributorGreyImageThumbnailUrlForUserBadgesPage();
                }
                
                if (FeedbackHeroValue >= 5)
                {
                    FeedbackHeroUrl = _UserBadgesPageImageUrlLibrary.GetFeedbackHeroImageThumbnailUrlForUserBadgesPage();
                }
                else
                {
                    FeedbackHeroUrl = _UserBadgesPageImageUrlLibrary.GetFeedbackHeroGreyImageThumbnailUrlForUserBadgesPage();
                }

                if (HelpfulValue)
                {
                    HelpfulUrl = _UserBadgesPageImageUrlLibrary.GetHelpfulImageThumbnailUrlForUserBadgesPage();
                }
                else
                {
                    HelpfulUrl = _UserBadgesPageImageUrlLibrary.GetHelpfulGreyImageThumbnailUrlForUserBadgesPage();
                }

                if (LeaderValue)
                {
                    LeaderUrl = _UserBadgesPageImageUrlLibrary.GetLeaderImageThumbnailUrlForUserBadgesPage();
                }
                else
                {
                    LeaderUrl = _UserBadgesPageImageUrlLibrary.GetLeaderGreyImageThumbnailUrlForUserBadgesPage();
                }


                if (VisionaryValue)
                {
                    VisionaryUrl = _UserBadgesPageImageUrlLibrary.GetVisionaryImageThumbnailUrlForUserBadgesPage();
                }
                else
                {
                    VisionaryUrl = _UserBadgesPageImageUrlLibrary.GetVisionaryGreyImageThumbnailUrlForUserBadgesPage();
                }

                if (ThankyouValue)
                {
                    ThankyouUrl = _UserBadgesPageImageUrlLibrary.GetThankyouImageThumbnailUrlForUserBadgesPage();
                }
                else
                {
                    ThankyouUrl = _UserBadgesPageImageUrlLibrary.GetThankyouGreyImageThumbnailUrlForUserBadgesPage();
                }
            } 

            var viewModel = new UserBadgesViewModel
            {
                PageTabTitle = _locSourceUserBadgesPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForUserBadgesPage(),
                ButtonText = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceButtonTextNameReference(),
                Title = _locSourceUserBadgesPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForUserBadgesPage(),
                Subtitle = _locSourceUserBadgesPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForUserBadgesPage(),
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
                FirstStepBadgeImageThumbnailUrl = FirstStepUrl,
                GathererForGoodBadgeImageThumbnailUrl = GathererForGoodUrl,
                BuildingBackBetterBadgeImageThumbnailUrl = BuildingBackBetterUrl,
                KeyDriverOfChangeBadgeImageThumbnailUrl = KeyChangeDriverUrl,
                DefeatGlobalWarmingBadgeImageThumbnailUrl = DefeatGWUrl,
                DefeatAnimalExtinctionBadgeImageThumbnailUrl = DefeatAEUrl,
                DefeatDeforestationBadgeImageThumbnailUrl = DefeatDFUrl,
                DeeplyCareBadgeImageThumbnailUrl = DeeplyCareUrl,
                CommunicatingForDifferenceBadgeImageThumbnailUrl = CommunicatingForDifferenceUrl,
                LearningForGoodBadgeImageThumbnailUrl = LearningForGoodUrl,
                MakingADifferenceBadgeImageThumbnailUrl = MakingADifferenceUrl,
                ContributorForGoodBadgeImageThumbnailUrl = ContributorUrl,
                FeedbackHeroBadgeImageThumbnailUrl = FeedbackHeroUrl,
                HelpfulBadgeImageThumbnailUrl = HelpfulUrl,
                LeaderBadgeImageThumbnailUrl = LeaderUrl,
                VisionaryBadgeImageThumbnailUrl = VisionaryUrl,
                ThankyouBadgeImageThumbnailUrl = ThankyouUrl,
                FirstStepBadgeTitle = _locSourceUserBadgesPageNameReferenceLibrary.GetFirstStepTitleForUserBadgesPage(),
                GathererForGoodTitle = _locSourceUserBadgesPageNameReferenceLibrary.GetGathererForGoodTitleForUserBadgesPage(),
                BuildingBackBetterTitle = _locSourceUserBadgesPageNameReferenceLibrary.GetBuildingBackBetterTitleForUserBadgesPage(),
                KeyDriverOfChangeTitle = _locSourceUserBadgesPageNameReferenceLibrary.GetKeyDriverOfChangeTitleForUserBadgesPage(),
                DefeatGlobalWarmingTitle = _locSourceUserBadgesPageNameReferenceLibrary.GetDefeatGlobalWarmingTitleForUserBadgesPage(),
                DefeatAnimalExtinctionTitle = _locSourceUserBadgesPageNameReferenceLibrary.GetDefeatAnimalExtinctionTitleForUserBadgesPage(),
                DefeatDeforestationTitle = _locSourceUserBadgesPageNameReferenceLibrary.GetDefeatDeforestationTitleForUserBadgesPage(),
                DeeplyCareTitle = _locSourceUserBadgesPageNameReferenceLibrary.GetDeeplyCareTitleForUserBadgesPage(),
                CommunicatingForDifferenceTitle = _locSourceUserBadgesPageNameReferenceLibrary.GetCommunicatingForDifferenceTitleForUserBadgesPage(),
                LearningForGoodTitle = _locSourceUserBadgesPageNameReferenceLibrary.GetLearningForGoodTitleForUserBadgesPage(),
                MakingADifferenceTitle = _locSourceUserBadgesPageNameReferenceLibrary.GetMakingADifferenceTitleForUserBadgesPage(),
                ContributorForGoodTitle = _locSourceUserBadgesPageNameReferenceLibrary.GetContributorForGoodTitleForUserBadgesPage(),
                FeedbackHeroTitle = _locSourceUserBadgesPageNameReferenceLibrary.GetFeedbackHeroTitleForUserBadgesPage(),
                HelpfulTitle = _locSourceUserBadgesPageNameReferenceLibrary.GetHelpfulTitleForUserBadgesPage(),
                LeaderTitle = _locSourceUserBadgesPageNameReferenceLibrary.GetLeaderTitleForUserBadgesPage(),
                VisionaryTitle = _locSourceUserBadgesPageNameReferenceLibrary.GetVisionaryTitleForUserBadgesPage(),
                ThankyouTitle = _locSourceUserBadgesPageNameReferenceLibrary.GetThankyouTitleForUserBadgesPage(),
                FirstStepBadgeInfo = _locSourceUserBadgesPageNameReferenceLibrary.GetFirstStepInfoForUserBadgesPage(),
                GathererForGoodInfo = _locSourceUserBadgesPageNameReferenceLibrary.GetGathererForGoodInfoForUserBadgesPage(),
                BuildingBackBetterInfo = _locSourceUserBadgesPageNameReferenceLibrary.GetBuildingBackBetterInfoForUserBadgesPage(),
                KeyDriverOfChangeInfo = _locSourceUserBadgesPageNameReferenceLibrary.GetKeyDriverOfChangeInfoForUserBadgesPage(),
                DefeatGlobalWarmingInfo = _locSourceUserBadgesPageNameReferenceLibrary.GetDefeatGlobalWarmingInfoForUserBadgesPage(),
                DefeatAnimalExtinctionInfo = _locSourceUserBadgesPageNameReferenceLibrary.GetDefeatAnimalExtinctionInfoForUserBadgesPage(),
                DefeatDeforestationInfo = _locSourceUserBadgesPageNameReferenceLibrary.GetDefeatDeforestationInfoForUserBadgesPage(),
                DeeplyCareInfo = _locSourceUserBadgesPageNameReferenceLibrary.GetDeeplyCareInfoForUserBadgesPage(),
                CommunicatingForDifferenceInfo = _locSourceUserBadgesPageNameReferenceLibrary.GetCommunicatingForDifferenceInfoForUserBadgesPage(),
                LearningForGoodInfo = _locSourceUserBadgesPageNameReferenceLibrary.GetLearningForGoodInfoForUserBadgesPage(),
                MakingADifferenceInfo = _locSourceUserBadgesPageNameReferenceLibrary.GetMakingADifferenceInfoForUserBadgesPage(),
                ContributorForGoodInfo = _locSourceUserBadgesPageNameReferenceLibrary.GetContributorForGoodInfoForUserBadgesPage(),
                FeedbackHeroInfo = _locSourceUserBadgesPageNameReferenceLibrary.GetFeedbackHeroInfoForUserBadgesPage(),
                HelpfulInfo = _locSourceUserBadgesPageNameReferenceLibrary.GetHelpfulInfoForUserBadgesPage(),
                LeaderInfo = _locSourceUserBadgesPageNameReferenceLibrary.GetLeaderInfoForUserBadgesPage(),
                VisionaryInfo = _locSourceUserBadgesPageNameReferenceLibrary.GetVisionaryInfoForUserBadgesPage(),
                ThankyouInfo = _locSourceUserBadgesPageNameReferenceLibrary.GetThankyouInfoForUserBadgesPage(),
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
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "User Badges Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "User Badges Page Newsfeed Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "User Badges Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "User Badges Page Newsfeed Modal", FeedbackDateTime);
                }
            }

            return RedirectToAction("UserBadges");
        }

    }
}
