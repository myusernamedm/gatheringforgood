using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GatheringForGood.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;
using LocSourceNameReferenceLibrary;
using ImageUrlReferenceLibrary;
using URLStringsReferenceLibrary;
using Microsoft.AspNetCore.Authorization;
using GatheringForGood.Areas.FunctionalLogic;
using Microsoft.AspNetCore.Identity.UI.Services;
using LazZiya.ExpressLocalization;

namespace GatheringForGood.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        private readonly ISharedCultureLocalizer _loc;
        private readonly IEmailSender _emailSender;

        public HomeController(IEmailSender emailSender, ISharedCultureLocalizer loc)
        {
            _emailSender = emailSender;
            _loc = loc;
        }

        public IActionResult Index(string returnUrl = null)
        {
            Debug.WriteLine("************ Index returnUrl: " + returnUrl);
            HomePageLocSourceNames _locSourceHomePageNameReferenceLibrary = new HomePageLocSourceNames();
            SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
            HomePageImageUrls _HomePageImageUrlLibrary = new HomePageImageUrls();
            SharedCrossPageImageUrls _SharedCrossPageImageUrls = new SharedCrossPageImageUrls();
            UrlStrings _URLStringsReferenceLibrary = new UrlStrings();
            SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();
            RegisterConfPageLocSourceNames _RegisterConfPageLocSourceNames = new();

            var viewModel = new HomeViewModel
            {
                PageTabTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForHomePage(),
                ButtonText = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceButtonTextNameReference(),
                Title = _locSourceHomePageNameReferenceLibrary.GetLocSourceTitleNameReferenceForHomePage(),
                Subtitle1 = _locSourceHomePageNameReferenceLibrary.GetLocSourceSubtitle1NameReferenceForHomePage(),
                Subtitle2 = _locSourceHomePageNameReferenceLibrary.GetLocSourceSubtitle2NameReferenceForHomePage(),
                BlockTitleImageUrl = _HomePageImageUrlLibrary.GetBlockTitleImageUrlForHomePage(),
                ChromeLogoImageUrl = _HomePageImageUrlLibrary.GetChromeLogoImageUrlForHomePage(),
                DownloadChromeUrl = _URLStringsReferenceLibrary.GetDownloadChromeUrl(),
                HowCanIHelpLabel = _locSourceHomePageNameReferenceLibrary.GetHowCanIHelpLabelNameReferenceForHomePage(),
                NavBarHome = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceHomeLabelNameReference(),
                NavBarNewsfeed = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNewsfeedLabelNameReference(),
                NavBarAbout = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceAboutLabelNameReference(),
                NavBarHelpCenter = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceHelpCenterLabelNameReference(),
                NavBarRegister = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceRegisterLabelNameReference(),
                NavBarLogin = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLoginLabelNameReference(),
                NavBarLogout = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLogoutLabelNameReference(),
                GreatestChallengeTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceGreatestChallengeTitleLabelNameReference(),
                GreatestChallengePara = _locSourceHomePageNameReferenceLibrary.GetLocSourceGreatestChallengeParaLabelNameReference(),
                CarbonClockTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceCarbonClockTitleLabelNameReference(),
                CarbonClockPara1 = _locSourceHomePageNameReferenceLibrary.GetLocSourceCarbonClockPara1LabelNameReference(),
                CarbonClockPara2 = _locSourceHomePageNameReferenceLibrary.GetLocSourceCarbonClockPara2LabelNameReference(),
                CarbonClockLearnMore = _locSourceHomePageNameReferenceLibrary.GetLocSourceCarbonClockLearnMoreLabelNameReference(),
                ExtinctionClockTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceExtinctionClockTitleLabelNameReference(),
                ExtinctionClockPara1 = _locSourceHomePageNameReferenceLibrary.GetLocSourceExtinctionClockPara1LabelNameReference(),
                ExtinctionClockPara2 = _locSourceHomePageNameReferenceLibrary.GetLocSourceExtinctionClockPara2LabelNameReference(),
                ExtinctionClockLearnMore = _locSourceHomePageNameReferenceLibrary.GetLocSourceExtinctionClockLearnMoreLabelNameReference(),
                ForestClockTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceForestClockTitleLabelNameReference(),
                ForestClockPara1 = _locSourceHomePageNameReferenceLibrary.GetLocSourceForestClockPara1LabelNameReference(),
                ForestClockPara2 = _locSourceHomePageNameReferenceLibrary.GetLocSourceForestClockPara2LabelNameReference(),
                ForestClockLearnMore = _locSourceHomePageNameReferenceLibrary.GetLocSourceForestClockLearnMoreLabelNameReference(),
                AboutUs = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceAboutUsLabelNameReference(),
                Articles = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceArticlesLabelNameReference(),
                CookiesNotice = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceCookiesNoticeLabelNameReference(),
                PrivacyNotice = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourcePrivacyNoticeLabelNameReference(),
                TimeUntilTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceTimeUntilTitleNameReference(),
                ExtinctionsSinceTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceExtinctionsSinceTitleNameReference(),
                MostSpeciesLostTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceMostSpeciesLostTitleNameReference(),
                ForestLostSinceTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceForestLostSinceTitleNameReference(),
                AllForestLostTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceAllForestLostTitleNameReference(),
                GFGLaunchedTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceGFGLaunchedTitleNameReference(),
                OneHalfDegreeDepletedTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceOneHalfDegreeDepletedTitleNameReference(),
                TwoDegreeDepletedTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceTwoDegreeDepletedTitleNameReference(),
                NewsfeedCardTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceNewsfeedCardTitleNameReference(),
                NewsfeedCardContent = _locSourceHomePageNameReferenceLibrary.GetLocSourceNewsfeedCardContentNameReference(),
                YourCauseCardTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceYourCauseCardTitleNameReference(),
                YourCauseCardContent = _locSourceHomePageNameReferenceLibrary.GetLocSourceYourCauseCardContentNameReference(),
                RallyForGoodCardTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceRallyForGoodCardTitleNameReference(),
                RallyForGoodCardContent = _locSourceHomePageNameReferenceLibrary.GetLocSourceRallyForGoodCardContentNameReference(),
                ArticlesCardTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceArticleCardTitleNameReference(),
                ArticlesCardContent = _locSourceHomePageNameReferenceLibrary.GetLocSourceArticleCardContentNameReference(),
                CommunityCardTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceCommunityCardTitleNameReference(),
                CommunityCardContent = _locSourceHomePageNameReferenceLibrary.GetLocSourceCommunityCardContentNameReference(),
                EventsCardTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceEventsCardTitleNameReference(),
                EventsCardContent = _locSourceHomePageNameReferenceLibrary.GetLocSourceEventsCardContentNameReference(),
                FundraiseCardTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceFundraiseCardTitleNameReference(),
                FundraiseCardContent = _locSourceHomePageNameReferenceLibrary.GetLocSourceFundraiseCardContentNameReference(),
                EducationCardTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceEducationCardTitleNameReference(),
                EducationCardContent = _locSourceHomePageNameReferenceLibrary.GetLocSourceEducationCardContentNameReference(),
                BusinessCardTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceBusinessCardTitleNameReference(),
                BusinessCardContent = _locSourceHomePageNameReferenceLibrary.GetLocSourceBusinessCardContentNameReference(),
                AcademyCardTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceAcademyCardTitleNameReference(),
                AcademyCardContent = _locSourceHomePageNameReferenceLibrary.GetLocSourceAcademyCardContentNameReference(),
                AcademyJuniorCardTitle = _locSourceHomePageNameReferenceLibrary.GetLocSourceAcademyJuniorCardTitleNameReference(),
                AcademyJuniorCardContent = _locSourceHomePageNameReferenceLibrary.GetLocSourceAcademyJuniorCardContentNameReference(),
                ComingSoon = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceComingSoonLabelNameReference(),
                LikeToSee = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLikeToSeeLabelNameReference(),
                Submit = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceSubmitLabelNameReference(),
                NewsfeedIconImage = _HomePageImageUrlLibrary.GetNewsfeedIconUrlReferenceForHomePage(),
                OffsetIconImage = _SharedCrossPageImageUrls.GetOffsetIconImageUrlReferenceForHomePage(),
                ImpactIconImage = _HomePageImageUrlLibrary.GetImpactIconImageUrlReferenceForHomePage(),
                AgileIconImage = _HomePageImageUrlLibrary.GetAgileIconImageUrlReferenceForHomePage(),
                NewsfeedIconText = _locSourceHomePageNameReferenceLibrary.GetLocSourceNewsfeedIconNameReferenceForHomePage(),
                OffsetIconText = _locSourceHomePageNameReferenceLibrary.GetLocSourceOffsetIconNameReferenceForHomePage(),
                ImpactIconText = _locSourceHomePageNameReferenceLibrary.GetLocSourceTrackImpactIconNameReferenceForHomePage(),
                AgileIconText = _locSourceHomePageNameReferenceLibrary.GetLocSourceAgileInitiativeIconNameReferenceForHomePage(),
                ArticlesIconImage = _HomePageImageUrlLibrary.GetArticlesIconImageUrlReferenceForHomePage(),
                ArticlesIconText = _locSourceHomePageNameReferenceLibrary.GetLocSourceArticleIconNameReferenceForHomePage(),
                RDFIconImage = _HomePageImageUrlLibrary.GetRDFIconImageUrlReferenceForHomePage(),
                RDFIconText = _locSourceHomePageNameReferenceLibrary.GetRDFIconNameReferenceForHomePage(),
                RAEIconImage = _HomePageImageUrlLibrary.GetRAEIconImageUrlReferenceForHomePage(),
                RAEIconText = _locSourceHomePageNameReferenceLibrary.GetRAEIconNameReferenceForHomePage(),
                RGWIconImage = _HomePageImageUrlLibrary.GetRGWIconImageUrlReferenceForHomePage(),
                RGWIconText = _locSourceHomePageNameReferenceLibrary.GetRGWIconNameReferenceForHomePage(),
                BetaNoticeText = _locSourceHomePageNameReferenceLibrary.GetBetaNoticeNameReferenceForHomePage(),
                BetaNoticeText1 = _locSourceHomePageNameReferenceLibrary.GetBetaNotice1NameReferenceForHomePage(),
                BetaNoticeText2 = _locSourceHomePageNameReferenceLibrary.GetBetaNotice2NameReferenceForHomePage(),
                CannotDependSolelyPara = _locSourceHomePageNameReferenceLibrary.GetCannotDependSolelyParaNameReferenceForHomePage(),
                HomepageShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20are%20taking%20action%20to%20help%20save%20the%20world!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                IconTwitter = _SharedCrossPageImageUrlLibrary.GetTwitterIconUrlForPage(),
                IconLinkedin = _SharedCrossPageImageUrlLibrary.GetLinkedinIconUrlForPage(),
                IconFacebook = _SharedCrossPageImageUrlLibrary.GetFacebookIconUrlForPage(),
                Updates = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceUpdatesNameReferenceForPage(),
                GetEarthHandsImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsImageUrlForPage(),
                GetEarthHands400ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHands400ImageUrlForPage(),
                GetEarthHands800ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHands800ImageUrlForPage(),
                GetEarthHands1200ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHands1200ImageUrlForPage(),
                GetEarthHands1600ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHands1600ImageUrlForPage(),
                StatusMessage = null
            };

            string StatusMessage;

            if (returnUrl != null)
            {
                Debug.WriteLine("************ Home returnurl: " + returnUrl.ToString());
                if(returnUrl == "NewUserRegistration")
                {
                    ViewData["Error"] = "success";
                    viewModel.StatusMessage = _loc.GetLocalizedString(_RegisterConfPageLocSourceNames.GetLocSourceCheckEmail1NameReferenceForRegisterConfPage());
                    return View(viewModel);
                }
            } else
            {
                viewModel.StatusMessage = null;
                Debug.WriteLine("************ Home returnurl IS NULL");
            }

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cookies()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Home Page Newsfeed/Agile/Offset Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Home Page Newsfeed/Agile/Offset Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Home Page Newsfeed/Agile/Offset Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Home Page Newsfeed/Agile/Offset Modal", FeedbackDateTime);
                }
            }

            return RedirectToAction("Index");
        }
    }
}
