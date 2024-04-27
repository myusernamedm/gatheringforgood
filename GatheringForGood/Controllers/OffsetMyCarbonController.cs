using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using GatheringForGood.Models;
using LocSourceNameReferenceLibrary;
using ImageUrlReferenceLibrary;
using Microsoft.AspNetCore.Authorization;
using System.Diagnostics;
using GatheringForGood.Areas.FunctionalLogic;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace GatheringForGood.Controllers
{
    [AllowAnonymous]
    public class OffsetMyCarbonController : Controller
    {
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        private readonly IEmailSender _emailSender;

        public OffsetMyCarbonController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public IActionResult OffsetMyCarbon()
        {
            OffsetMyCarbonPageLocSourceNames _locSourceOffsetMyCarbonPageNameReferenceLibrary = new OffsetMyCarbonPageLocSourceNames();
            SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
            SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();

            var viewModel = new OffsetMyCarbonViewModel
            {
                PageTabTitle = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForOffsetMyCarbonPage(),
                ButtonText = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceButtonTextNameReference(),
                Title = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForOffsetMyCarbonPage(),
                Subtitle = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForOffsetMyCarbonPage(),
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
                GoBackButton = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceGoBackNameReferenceForPage(),
                NormalModeOfTransport = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourceNormalModeOfTransportNameReferenceForOffsetMyCarbonPage(),
                CycleWalk = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourceCycleWalkNameReferenceForOffsetMyCarbonPage(),
                CycleWalkPublic = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourceCycleWalkPublicNameReferenceForOffsetMyCarbonPage(),
                Public = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourcePublicNameReferenceForOffsetMyCarbonPage(),
                CycleWalkDrive = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourceCycleWalkDriveNameReferenceForOffsetMyCarbonPage(),
                PublicDrive = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourcePublicDriveNameReferenceForOffsetMyCarbonPage(),
                Drive = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourceDriveNameReferenceForOffsetMyCarbonPage(),
                NextButton = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourceNextButtonNameReferenceForOffsetMyCarbonPage(),
                FlightProfileTitle = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourceFlightProfileTitleNameReferenceForOffsetMyCarbonPage(),
                NeverFly = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourceNeverFlyNameReferenceForOffsetMyCarbonPage(),
                ShortHaulFly = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourceShortHaulFlyNameReferenceForOffsetMyCarbonPage(),
                MediumHaulFly = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourceMediumHaulFlyNameReferenceForOffsetMyCarbonPage(),
                LongHaulFly = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourceLongHaulFlyNameReferenceForOffsetMyCarbonPage(),
                PercentPublic = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourcePercentPublicNameReferenceForOffsetMyCarbonPage(),
                PercentDriving = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourcePercentDrivingNameReferenceForOffsetMyCarbonPage(),
                ShortHaulFlyPerYear = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourceShortHaulPerYearNameReferenceForOffsetMyCarbonPage(),
                MediumHaulFlyPerYear = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourceMediumHaulPerYearNameReferenceForOffsetMyCarbonPage(),
                LongHaulFlyPerYear = _locSourceOffsetMyCarbonPageNameReferenceLibrary.GetLocSourceLongHaulPerYearNameReferenceForOffsetMyCarbonPage(),
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
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Offset My Carbon Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Offset My Carbon Page Newsfeed Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Offset My Carbon Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Offset My Carbon Page Newsfeed Modal", FeedbackDateTime);
                }
            }

            return RedirectToAction("OffsetMyCarbon");
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> UserOffsetMyCarbon(OffsetMyCarbonViewModel model)
        {
            DateTime FeedbackDateTime = DateTime.UtcNow;
            var SelectedPercentValueField = model.SelectedPercentValue;
            var SelectedRadio1Field = model.SelectedRadio1;
            Debug.WriteLine("**************** SelectedPercentValueField 1: " + SelectedPercentValueField);
            Debug.WriteLine("**************** SelectedRadio1Field 1: " + SelectedRadio1Field);
            if (ModelState.IsValid)
            {
                Debug.WriteLine("**************** SelectedPercentValueField 1a: " + SelectedPercentValueField);
                Debug.WriteLine("**************** SelectedRadio1Field 1a: " + SelectedRadio1Field);

                if (SelectedRadio1Field != null)
                {
                    Debug.WriteLine("**************** SelectedPercentValueField 2: " + SelectedPercentValueField);
                    Debug.WriteLine("**************** SelectedRadio1Field 2: " + SelectedRadio1Field);
                    try
                    {
                        Debug.WriteLine("**************** SelectedPercentValueField 3: " + SelectedPercentValueField);
                        Debug.WriteLine("**************** SelectedRadio1Field 3: " + SelectedRadio1Field);
                        //await SaveContactFormEntry.saveUserEntryAsync(FeedbackDateTime, ContactUsNameField, ContactUsEmailField, ContactUsSubjectField, ContactUsMessageField, ContactUsTandCCheckbox);
                        //await SendEmailContactForm.sendEmailAsync(_emailSender, FeedbackDateTime, ContactUsNameField, ContactUsEmailField, ContactUsSubjectField, ContactUsMessageField, ContactUsTandCCheckbox);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("**************** SelectedPercentValueField 4: " + SelectedPercentValueField);
                        Debug.WriteLine("**************** SelectedRadio1Field 4: " + SelectedRadio1Field);

                        return Redirect("/Index");
                    }
                }
            }

            Debug.WriteLine("**************** SelectedPercentValueField 5: " + SelectedPercentValueField);
            Debug.WriteLine("**************** SelectedRadio1Field 5: " + SelectedRadio1Field);

            return Redirect("/Index");
        }
        public IActionResult Error()
        {
            return View();
        }

    }
}
