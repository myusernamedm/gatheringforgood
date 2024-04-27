using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using GatheringForGood.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using LazZiya.ExpressLocalization;
using LazZiya.TagHelpers.Alerts;
using LocSourceNameReferenceLibrary;
using System.Diagnostics;
using GatheringForGood.Areas.FunctionalLogic;
using Microsoft.AspNetCore.Identity.UI.Services;
using ImageUrlReferenceLibrary;

namespace GatheringForGood.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ConfirmEmailModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ISharedCultureLocalizer _loc;
        private readonly string culture;
        readonly ConfirmEmailPageLocSourceNames _locSourceConfirmEmailPageNameReferenceLibrary = new ConfirmEmailPageLocSourceNames();
        readonly SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
        SharedCrossPageImageUrls _imageUrlReferenceLibrary = new SharedCrossPageImageUrls();
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        private readonly IEmailSender _emailSender;
        readonly SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();

        public ConfirmEmailModel(UserManager<ApplicationUser> userManager, ISharedCultureLocalizer loc, IEmailSender emailSender)
        {
            _userManager = userManager;
            _loc = loc;
            culture = System.Globalization.CultureInfo.CurrentCulture.Name;
            _emailSender = emailSender;
        }

        [TempData]
        public string StatusMessage { get; set; }
        public string PageTabTitle { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Heading { get; set; }
        public string NavBarHome { get; set; }
        public string NavBarNewsfeed { get; set; }
        public string NavBarAbout { get; set; }
        public string NavBarHelpCenter { get; set; }
        public string NavBarRegister { get; set; }
        public string NavBarLogin { get; set; }
        public string NavBarLogout { get; set; }
        public string AboutUs { get; set; }
        public string Articles { get; set; }
        public string CookiesNotice { get; set; }
        public string PrivacyNotice { get; set; }
        public string ButtonText { get; set; }
        public string Submit { get; set; }
        public string ComingSoon { get; set; }
        public string LikeToSee { get; set; }
        public string Updates { get; set; }
        public string HomepageShare { get; set; }
        public string IconTwitter { get; set; }
        public string IconLinkedin { get; set; }
        public string IconFacebook { get; set; }
        public string GetEarthHandsReducedImageUrl { get; set; }
        public string GetEarthHandsReduced400ImageUrl { get; set; }
        public string GetEarthHandsReduced800ImageUrl { get; set; }
        public string GetEarthHandsReduced1200ImageUrl { get; set; }
        public string GetEarthHandsReduced1600ImageUrl { get; set; }

        public async Task<IActionResult> OnGetAsync(string userId, string code)
        {
            PageTabTitle = _locSourceConfirmEmailPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForConfirmEmailPage();
            Title = _locSourceConfirmEmailPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForConfirmEmailPage();
            SubTitle = _locSourceConfirmEmailPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForConfirmEmailPage();
            Heading = _locSourceConfirmEmailPageNameReferenceLibrary.GetLocSourceHeadingNameReferenceForConfirmEmailPage();
            NavBarHome = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceHomeLabelNameReference();
            NavBarNewsfeed = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNewsfeedLabelNameReference();
            NavBarAbout = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceAboutLabelNameReference();
            NavBarHelpCenter = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceHelpCenterLabelNameReference();
            NavBarRegister = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceRegisterLabelNameReference();
            NavBarLogin = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLoginLabelNameReference();
            NavBarLogout = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLogoutLabelNameReference();
            AboutUs = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceAboutUsLabelNameReference();
            Articles = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceArticlesLabelNameReference();
            CookiesNotice = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceCookiesNoticeLabelNameReference();
            PrivacyNotice = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourcePrivacyNoticeLabelNameReference();
            ButtonText = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLoginLabelNameReference();
            ComingSoon = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceComingSoonLabelNameReference();
            LikeToSee = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLikeToSeeLabelNameReference();
            Submit = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceSubmitLabelNameReference();
            Updates = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceUpdatesNameReferenceForPage();
            HomepageShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20are%20taking%20action%20to%20help%20save%20the%20world!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com";
            IconTwitter = _imageUrlReferenceLibrary.GetTwitterIconUrlForPage();
            IconLinkedin = _imageUrlReferenceLibrary.GetLinkedinIconUrlForPage();
            IconFacebook = _imageUrlReferenceLibrary.GetFacebookIconUrlForPage();
            GetEarthHandsReducedImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReducedImageUrlForPage();
            GetEarthHandsReduced400ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced400ImageUrlForPage();
            GetEarthHandsReduced800ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced800ImageUrlForPage();
            GetEarthHandsReduced1200ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced1200ImageUrlForPage();
            GetEarthHandsReduced1600ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced1600ImageUrlForPage();


            Debug.WriteLine("**************** 6 *** " + code);
            Debug.WriteLine("**************** 7 *** " + userId);
            if (userId == null || code == null)
            {
                return RedirectToPage("/Index", new { culture });
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                var msg = _loc.GetLocalizedString("Unable to load user with ID '{0}'.", userId);
                return NotFound(msg);
            }

            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                var msg = _loc.GetLocalizedString("Thank you for confirming your email.");
                TempData.Success(msg);
            }
            else
            {
                var msg = _loc.GetLocalizedString("Error confirming your email.");
                TempData.Danger(msg);
            }
            return Page();
        }

        public async Task<IActionResult> OnPostSaveUserEntryAsync(string newsfeedUserEntry)
        {
            DateTime FeedbackDateTime = DateTime.UtcNow;

            if (newsfeedUserEntry != null)
            {
                string userId = ClaimsPrincipalExtensions.GetUserId<string>(User);
                if (userId != null)
                {
                    bool loggedInUser = true;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Confirm Email Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Confirm Email Page Newsfeed Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Confirm Email Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Confirm Email Page Newsfeed Modal", FeedbackDateTime);
                }
            }

            return RedirectToPage("ConfirmEmail", new { culture });
        }
    }
}
