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
    public class AboutController : Controller
    {
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        private readonly IEmailSender _emailSender;

        public AboutController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public IActionResult About()
        {

            AboutPageLocSourceNames _locSourceAboutPageNameReferenceLibrary = new AboutPageLocSourceNames();
            SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
            AboutPageImageUrls _AboutPageImageUrlLibrary = new AboutPageImageUrls();
            SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();

            var viewModel = new AboutViewModel
            {
                PageTabTitle = _locSourceAboutPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForAboutPage(),
                ButtonText = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceButtonTextNameReference(),
                Title = _locSourceAboutPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForAboutPage(),
                Subtitle = _locSourceAboutPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForAboutPage(),
                NameImageThumbnailUrl = _AboutPageImageUrlLibrary.GetNameImageThumbnailUrlForAboutPage(),
                WhereDoesNameComeFromTitle = _locSourceAboutPageNameReferenceLibrary.GetLocSourceWhereDoesNameComeFromTitleNameReferenceForAboutPage(),
                WhereDoesNameComeFromPara = _locSourceAboutPageNameReferenceLibrary.GetLocSourceWhereDoesNameComeFromParaNameReferenceForAboutPage(),
                OurMissionTitle = _locSourceAboutPageNameReferenceLibrary.GetLocSourceOurMissionTitleNameReferenceForAboutPage(),
                MissionImageThumbnailUrl = _AboutPageImageUrlLibrary.GetMissionImageThumbnailUrlForAboutPage(),
                OurMissionPara = _locSourceAboutPageNameReferenceLibrary.GetLocSourceOurMissionParaNameReferenceForAboutPage(),
                OurPromiseTitle = _locSourceAboutPageNameReferenceLibrary.GetLocSourceOurPromiseTitleNameReferenceForAboutPage(),
                PromiseImageThumbnailUrl = _AboutPageImageUrlLibrary.GetPromiseImageThumbnailUrlForAboutPage(),
                OurPromisePara = _locSourceAboutPageNameReferenceLibrary.GetLocSourceOurPromiseParaNameReferenceForAboutPage(),
                OurEssenceTitle = _locSourceAboutPageNameReferenceLibrary.GetLocSourceOurEssenceTitleNameReferenceForAboutPage(),
                EssenceImageThumbnailUrl = _AboutPageImageUrlLibrary.GetEssenceImageThumbnailUrlForAboutPage(),
                OurEssencePara = _locSourceAboutPageNameReferenceLibrary.GetLocSourceOurEssenceParaNameReferenceForAboutPage(),
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
                OurVisionTitle = _locSourceAboutPageNameReferenceLibrary.GetLocSourceVisionTitleNameReferenceForAboutPage(),
                VisionImageThumbnailUrl = _AboutPageImageUrlLibrary.GetVisionImageThumbnailUrlForAboutPage(),
                OurVisionPara = _locSourceAboutPageNameReferenceLibrary.GetLocSourceVisionParaNameReferenceForAboutPage(),
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
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "About Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "About Page Newsfeed Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "About Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "About Page Newsfeed Modal", FeedbackDateTime);
                }
            }

            return RedirectToAction("About");
        }
    }
}
