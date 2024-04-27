using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using GatheringForGood.Models;
using LocSourceNameReferenceLibrary;
using Microsoft.AspNetCore.Authorization;
using GatheringForGood.Areas.FunctionalLogic;
using Microsoft.AspNetCore.Identity.UI.Services;
using ImageUrlReferenceLibrary;
using URLStringsReferenceLibrary;

namespace GatheringForGood.Controllers
{
    [AllowAnonymous]
    public class TermsAndConditionsController : Controller
    {
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        readonly UrlStrings _URLStringsReferenceLibrary = new();

        private readonly IEmailSender _emailSender;

        public TermsAndConditionsController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public IActionResult TermsAndConditions()
        {
            TermsAndConditionsPageLocSourceNames _locSourceTermsAndConditionsPageNameReferenceLibrary = new TermsAndConditionsPageLocSourceNames();
            SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
            SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();

            var viewModel = new TermsAndConditionsViewModel
            {
                PageTabTitle = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForTermsAndConditionsPage(),
                ButtonText = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceButtonTextNameReference(),
                Title = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForTermsAndConditionsPage(),
                Subtitle = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForTermsAndConditionsPage(),
                NavBarHome = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceHomeLabelNameReference(),
                NavBarNewsfeed = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNewsfeedLabelNameReference(),
                NavBarAbout = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceAboutLabelNameReference(),
                NavBarHelpCenter = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceHelpCenterLabelNameReference(),
                NavBarRegister = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceRegisterLabelNameReference(),
                NavBarLogin = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLoginLabelNameReference(),
                NavBarLogout = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLogoutLabelNameReference(),
                AboutUs = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceAboutUsLabelNameReference(),
                TermsAndConditionsHeading = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceHeadingNameReferenceForTermsAndConditionsPage(),
                TandCEffectiveDate = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTandCEffectiveDateNameReferenceForTermsAndConditionsPage(),
                AgreeInFull = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceAgreeInFullNameReferenceForTermsAndConditionsPage(),
                AppropriateUse = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceAppropriateUseNameReferenceForTermsAndConditionsPage(),
                AppropriateUseGuide = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceAppropriateUseGuideNameReferenceForTermsAndConditionsPage(),
                RightofAccountClosure = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceRightofAccountClosureNameReferenceForTermsAndConditionsPage(),
                NaturalWorldClosure = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceNaturalWorldClosureNameReferenceForTermsAndConditionsPage(),
                TandCUpdates = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTandCUpdatesNameReferenceForTermsAndConditionsPage(),
                Articles = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceArticlesLabelNameReference(),
                CookiesNotice = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceCookiesNoticeLabelNameReference(),
                PrivacyNotice = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourcePrivacyNoticeLabelNameReference(),
                ComingSoon = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceComingSoonLabelNameReference(),
                LikeToSee = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLikeToSeeLabelNameReference(),
                Submit = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceSubmitLabelNameReference(),
                ObituariesAndViolence = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTandCObituariesAndViolenceNameReferenceForTermsAndConditionsPage(),
                Discrimination = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTandCDiscriminationNameReferenceForTermsAndConditionsPage(),
                Analytics = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTandCAnalyticsNameReferenceForTermsAndConditionsPage(),
                SavingData = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceSavingDataNameReferenceForTermsAndConditionsPage(),
                OneAccountPerPerson = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceOneAccountPerPersonNameReferenceForTermsAndConditionsPage(),
                Updates = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceUpdatesNameReferenceForPage(),
                HomepageShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20are%20taking%20action%20to%20help%20save%20the%20world!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                IconTwitter = _SharedCrossPageImageUrlLibrary.GetTwitterIconUrlForPage(),
                IconLinkedin = _SharedCrossPageImageUrlLibrary.GetLinkedinIconUrlForPage(),
                IconFacebook = _SharedCrossPageImageUrlLibrary.GetFacebookIconUrlForPage(),
                FontAwesomeLicense = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceFontAwesomeLicenseNameReferenceForTermsAndConditionsPage(),
                NoObituaries = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceObituariesNameReferenceForTermsAndConditionsPage(),
                ArticleRemoval = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceRightofArticleRemovalNameReferenceForTermsAndConditionsPage(),
                ArticleRetention = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceArticleRetentionNameReferenceForTermsAndConditionsPage(),
                TreePlantingPara1 = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTreePlantingPurchasePara1NameReferenceForTermsAndConditionsPage(),
                TreePlantingPara2 = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTreePlantingPurchasePara2NameReferenceForTermsAndConditionsPage(),
                TreePlantingPara3 = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTreePlantingPurchasePara3NameReferenceForTermsAndConditionsPage(),
                TreePlantingPara4 = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTreePlantingPurchasePara4NameReferenceForTermsAndConditionsPage(),
                TreePlantingPara5 = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTreePlantingPurchasePara5NameReferenceForTermsAndConditionsPage(),
                TreePlantingPara6 = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTreePlantingPurchasePara6NameReferenceForTermsAndConditionsPage(),
                TreePlantingPara7 = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTreePlantingPurchasePara7NameReferenceForTermsAndConditionsPage(),
                TreePlantingVision = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTreePlantingPurchaseVisionNameReferenceForTermsAndConditionsPage(),
                TreePlantingOneTreePlanted = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTreePlantingPurchaseOneTreePlantedNameReferenceForTermsAndConditionsPage(),
                TreePlantingContactUs = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTreePlantingPurchaseContactUsNameReferenceForTermsAndConditionsPage(),
                TreePlantingNA = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTreePlantingLocationNorthAmericaNameReferenceForTermsAndConditionsPage(),
                TreePlantingLA = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTreePlantingLocationLatinAmericaNameReferenceForTermsAndConditionsPage(),
                TreePlantingAfrica = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTreePlantingLocationAfricaNameReferenceForTermsAndConditionsPage(),
                TreePlantingAsia = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTreePlantingLocationAsiaNameReferenceForTermsAndConditionsPage(),
                TreePlantingEurope = _locSourceTermsAndConditionsPageNameReferenceLibrary.GetLocSourceTreePlantingLocationEuropeNameReferenceForTermsAndConditionsPage(),
                OneTreePlantedUrl = _URLStringsReferenceLibrary.GetOneTreePlantedUrl(),
                OneTreePlantedLogo = _SharedCrossPageImageUrlLibrary.GetPartnerImageUrlForPage(),
                PieChartLogo = _SharedCrossPageImageUrlLibrary.GetPieChartImageUrlForPage(),
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
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "TandC Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "TandC Page Newsfeed Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "TandC Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "TandC Page Newsfeed Modal", FeedbackDateTime);
                }
            }

            return RedirectToAction("TermsAndConditions");
        }
    }
}
