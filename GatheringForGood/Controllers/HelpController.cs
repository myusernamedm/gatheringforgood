using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using LocSourceNameReferenceLibrary;
using GatheringForGood.Models;
using GatheringForGood.Areas.FunctionalLogic;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Authorization;
using ImageUrlReferenceLibrary;

namespace GatheringForGood.Controllers
{
    [AllowAnonymous]
    public class HelpController : Controller
    {
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        readonly SaveContactFormEntry SaveContactFormEntry = new();
        readonly SendEmailContactForm SendEmailContactForm = new();

        private readonly IEmailSender _emailSender;

        public HelpController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }


        public IActionResult Help()
        {
            HelpPageLocSourceNames _locSourceHelpPageNameReferenceLibrary = new HelpPageLocSourceNames();
            SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
            HelpPageImageUrls _locSourceImageUrlReferenceLibrary = new HelpPageImageUrls();
            SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();
            HomePageImageUrls _HomePageImageUrlLibrary = new HomePageImageUrls();
            HomePageLocSourceNames _locSourceHomePageNameReferenceLibrary = new HomePageLocSourceNames();

            var viewModel = new HelpViewModel
            {
                PageTabTitle = _locSourceHelpPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForHelpPage(),
                Title = _locSourceHelpPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForHelpPage(),
                Subtitle = _locSourceHelpPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForHelpPage(),
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
                NewsfeedIconImage = _locSourceImageUrlReferenceLibrary.GetNewsfeedIconUrlReferenceForHelpPage(),
                OffsetIconImage = _locSourceImageUrlReferenceLibrary.GetOffsetIconImageUrlReferenceForHelpPage(),
                ImpactIconImage = _locSourceImageUrlReferenceLibrary.GetImpactIconImageUrlReferenceForHelpPage(),
                AgileIconImage = _locSourceImageUrlReferenceLibrary.GetAgileIconImageUrlReference(),
                ContactIconImage = _locSourceImageUrlReferenceLibrary.GetContactIconImageUrlReference(),
                NewsfeedIconText = _locSourceHelpPageNameReferenceLibrary.GetLocSourceNewsfeedIconNameReferenceForHelpPage(),
                OffsetIconText = _locSourceHelpPageNameReferenceLibrary.GetLocSourceOffsetIconNameReferenceForHelpPage(),
                ContactIconText = _locSourceHelpPageNameReferenceLibrary.GetLocSourceContactUsIconNameReferenceForHelpPage(),
                ImpactIconText = _locSourceHelpPageNameReferenceLibrary.GetLocSourceTrackImpactIconNameReferenceForHelpPage(),
                AgileIconText = _locSourceHelpPageNameReferenceLibrary.GetLocSourceAgileInitiativeIconNameReferenceForHelpPage(),
                Hello = _locSourceHelpPageNameReferenceLibrary.GetLocSourceHelloNameReferenceForHelpPage(),
                LetUsKnow = _locSourceHelpPageNameReferenceLibrary.GetLocSourceLetUsKnowNameReferenceForHelpPage(),
                IdeasOrSayHi = _locSourceHelpPageNameReferenceLibrary.GetLocSourceIdeasOrSayHiNameReferenceForHelpPage(),
                Required = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceRequiredNameReference(),
                RequiredMinMax1 = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceRequiredMinMax1NameReference(),
                RequiredMinMax2 = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceRequiredMinMax2NameReference(),
                NameHeading = _locSourceHelpPageNameReferenceLibrary.GetLocSourceNameHeadingNameReferenceForHelpPage(),
                EmailHeading = _locSourceHelpPageNameReferenceLibrary.GetLocSourceEmailHeadingNameReferenceForHelpPage(),
                SubjectHeading = _locSourceHelpPageNameReferenceLibrary.GetLocSourceSubjectHeadingNameReferenceForHelpPage(),
                ThoughtsHeading = _locSourceHelpPageNameReferenceLibrary.GetLocSourceThoughtsHeadingNameReferenceForHelpPage(),
                TandCHeading = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceTandCHeadingNameReferenceForPage(),
                ArticlesIconImage = _locSourceImageUrlReferenceLibrary.GetArticlesIconImageUrlReference(),
                ArticlesIconText = _locSourceHelpPageNameReferenceLibrary.GetLocSourceViewArticlesIconNameReferenceForHelpPage(),
                RDFIconImage = _HomePageImageUrlLibrary.GetRDFIconImageUrlReferenceForHomePage(),
                RDFIconText = _locSourceHomePageNameReferenceLibrary.GetRDFIconNameReferenceForHomePage(),
                RAEIconImage = _HomePageImageUrlLibrary.GetRAEIconImageUrlReferenceForHomePage(),
                RAEIconText = _locSourceHomePageNameReferenceLibrary.GetRAEIconNameReferenceForHomePage(),
                RGWIconImage = _HomePageImageUrlLibrary.GetRGWIconImageUrlReferenceForHomePage(),
                RGWIconText = _locSourceHomePageNameReferenceLibrary.GetRGWIconNameReferenceForHomePage(),
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
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Help Page Newsfeed/Agile/Offset Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Help Page Newsfeed/Agile/Offset Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Help Page Newsfeed/Agile/Offset Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Help Page Newsfeed/Agile/Offset Modal", FeedbackDateTime);
                }
            }

            return RedirectToAction("Help");
        }

        [HttpPost]
        public async Task<IActionResult> SendMail(HelpViewModel model)
        {
            DateTime FeedbackDateTime = DateTime.UtcNow;
            var ContactUsNameField = model.Name;
            var ContactUsEmailField = model.Email;
            var ContactUsSubjectField = model.Subject;
            var ContactUsMessageField = model.Thoughts;
            var ContactUsTandCCheckbox = model.TandC;

            if (ModelState.IsValid)
            {
                try
                {
                    await SaveContactFormEntry.saveUserEntryAsync(FeedbackDateTime, ContactUsNameField, ContactUsEmailField, ContactUsSubjectField, ContactUsMessageField, ContactUsTandCCheckbox);
                    await SendEmailContactForm.sendEmailAsync(_emailSender, FeedbackDateTime, ContactUsNameField, ContactUsEmailField, ContactUsSubjectField, ContactUsMessageField, ContactUsTandCCheckbox);
                }
                catch (Exception ex)
                {
                    return Redirect("/Index");
                }
            }
            return Redirect("/Index");
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
