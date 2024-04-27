using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using LazZiya.ExpressLocalization;
using GatheringForGood.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using LocSourceNameReferenceLibrary;
using GatheringForGood.Areas.FunctionalLogic;
using ImageUrlReferenceLibrary;

namespace GatheringForGood.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ResendEmailConfirmationModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ISharedCultureLocalizer _loc;
        private readonly string culture;
        readonly ResendEmailConfirmationPageLocSourceNames _locSourceResendEmailConfirmationPageNameReferenceLibrary = new ResendEmailConfirmationPageLocSourceNames();
        readonly SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
        SharedCrossPageImageUrls _imageUrlReferenceLibrary = new SharedCrossPageImageUrls();
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        private readonly IEmailSender _emailSender;
        readonly SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();

        public ResendEmailConfirmationModel(UserManager<ApplicationUser> userManager, IEmailSender emailSender, ISharedCultureLocalizer loc)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            _loc = loc;
            culture = System.Globalization.CultureInfo.CurrentCulture.Name;
        }

        [BindProperty]
        public InputModel Input { get; set; }
        public string StatusMessage { get; set; }
        public string ReturnUrl { get; set; }
        public string PageTabTitle { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Heading { get; set; }
        public string ServiceHeading { get; set; }
        public string EmailHeading { get; set; }
        public string PasswordHeading { get; set; }
        public string ConfirmPassword { get; set; }
        public string RegisterButtonName { get; set; }
        public string NavBarHome { get; set; }
        public string NavBarNewsfeed { get; set; }
        public string NavBarAbout { get; set; }
        public string NavBarHelpCenter { get; set; }
        public string AboutUs { get; set; }
        public string Articles { get; set; }
        public string CookiesNotice { get; set; }
        public string PrivacyNotice { get; set; }
        public string NavBarRegister { get; set; }
        public string NavBarLogin { get; set; }
        public string NavBarLogout { get; set; }
        public string PasswordRequirementsTitle { get; set; }
        public string PasswordRequirements { get; set; }
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

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            PageTabTitle = _locSourceResendEmailConfirmationPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForResendEmailConfirmationPage();
            Title = _locSourceResendEmailConfirmationPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForResendEmailConfirmationPage();
            SubTitle = _locSourceResendEmailConfirmationPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForResendEmailConfirmationPage();
            Heading = _locSourceResendEmailConfirmationPageNameReferenceLibrary.GetLocSourceHeadingNameReferenceForResendEmailConfirmationPage();
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

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.FindByEmailAsync(Input.Email);
            if (user == null)
            {
                var msg = _loc.GetLocalizedString("Unable to load user with ID '{0}'.", _userManager.GetUserId(User));
                return NotFound(msg);
            }

            var userId = await _userManager.GetUserIdAsync(user);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var callbackUrl = Url.Page("/Account/ConfirmEmail", pageHandler: null, values: new { userId = userId, code = code }, protocol: Request.Scheme);
            await _emailSender.SendEmailAsync(Input.Email, "Confirm your email", $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

            var emailSent = _loc.GetLocalizedString("Confirmation link sent. Please check your email account.");
            StatusMessage = emailSent;

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
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Resend Email Confirmation Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Resend Email Confirmation Page Newsfeed Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Resend Email Confirmation Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Resend Email Confirmation Page Newsfeed Modal", FeedbackDateTime);
                }
            }

            return RedirectToPage("ResendEmailConfirmation", new { culture });
        }
    }
}
