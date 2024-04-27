using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using GatheringForGood.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using LocSourceNameReferenceLibrary;
using System.Threading.Tasks;
using LazZiya.ExpressLocalization;
using LazZiya.ExpressLocalization.DataAnnotations;
using LazZiya.TagHelpers.Alerts;
using System.Globalization;
using GatheringForGood.Areas.FunctionalLogic;
using ImageUrlReferenceLibrary;

namespace GatheringForGood.Areas.Identity.Pages.Account.Manage
{
    public partial class EmailModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ISharedCultureLocalizer _loc;
        private readonly string culture;
        readonly EmailManagePageLocSourceNames _locSourceEmailManagePageNameReferenceLibrary = new EmailManagePageLocSourceNames();
        readonly AccountManagePageLocSourceNames _locSourceAccountManagePageNameReferenceLibrary = new AccountManagePageLocSourceNames();
        readonly SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
        SharedCrossPageImageUrls _imageUrlReferenceLibrary = new SharedCrossPageImageUrls();
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        private readonly IEmailSender _emailSender;
        readonly SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();

        public EmailModel(UserManager<ApplicationUser> userManager, IEmailSender emailSender, ISharedCultureLocalizer loc)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            _loc = loc;
            culture = CultureInfo.CurrentCulture.Name;
        }

        public bool IsEmailConfirmed { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PageTabTitle { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Heading { get; set; }
        public string EmailHeading { get; set; }
        public string NewEmailHeading { get; set; }
        public string ChangeEmailButtonText { get; set; }
        public string SendVerificationEmailButtonText { get; set; }
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
        public string ProfileNavButton { get; set; }
        public string EmailNavButton { get; set; }
        public string ExternalLoginsNavButton { get; set; }
        public string PasswordNavButton { get; set; }
        public string TwoFANavButton { get; set; }
        public string PersonalDataNavButton { get; set; }
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
            [ExRequired]
            [EmailAddress]
            [Display(Name = "New email")]
            public string NewEmail { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var email = await _userManager.GetEmailAsync(user);
            Email = email;

            Input = new InputModel
            {
                NewEmail = email,
            };

            IsEmailConfirmed = await _userManager.IsEmailConfirmedAsync(user);
        }


        public async Task<IActionResult> OnGetAsync()
        {
            PageTabTitle = _locSourceEmailManagePageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForEmailManagePage();
            Title = _locSourceEmailManagePageNameReferenceLibrary.GetLocSourceTitleNameReferenceForEmailManagePage();
            SubTitle = _locSourceEmailManagePageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForEmailManagePage();
            Heading = _locSourceEmailManagePageNameReferenceLibrary.GetLocSourceHeadingNameReferenceForEmailManagePage();
            EmailHeading = _locSourceEmailManagePageNameReferenceLibrary.GetLocSourceEmailHeadingNameReferenceForEmailManagePage();
            NewEmailHeading = _locSourceEmailManagePageNameReferenceLibrary.GetLocSourceNewEmailHeadingNameReferenceForEmailManagePage();
            ChangeEmailButtonText = _locSourceEmailManagePageNameReferenceLibrary.GetLocSourceChangeEmailButtonTextNameReferenceForEmailManagePage();
            SendVerificationEmailButtonText = _locSourceEmailManagePageNameReferenceLibrary.GetLocSourceSendVerificationEmailButtonTextNameReferenceForEmailManagePage();
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
            ProfileNavButton = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourceProfileNavButtonNameReferenceForAccountManagePage();
            EmailNavButton = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourceEmailNavButtonNameReferenceForAccountManagePage();
            ExternalLoginsNavButton = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourceExternalLoginsNavButtonNameReferenceForAccountManagePage();
            PasswordNavButton = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourcePasswordNavButtonNameReferenceForAccountManagePage();
            TwoFANavButton = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourceTwoFANavButtonNameReferenceForAccountManagePage();
            PersonalDataNavButton = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourcePersonalDataNavButtonNameReferenceForAccountManagePage();
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

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                var msg = _loc.GetLocalizedString("Unable to load user with ID '{0}'.", _userManager.GetUserId(User));
                return NotFound(msg);
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostChangeEmailAsync()
        {
            PageTabTitle = _locSourceEmailManagePageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForEmailManagePage();
            Title = _locSourceEmailManagePageNameReferenceLibrary.GetLocSourceTitleNameReferenceForEmailManagePage();
            SubTitle = _locSourceEmailManagePageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForEmailManagePage();
            Heading = _locSourceEmailManagePageNameReferenceLibrary.GetLocSourceHeadingNameReferenceForEmailManagePage();
            EmailHeading = _locSourceEmailManagePageNameReferenceLibrary.GetLocSourceEmailHeadingNameReferenceForEmailManagePage();
            NewEmailHeading = _locSourceEmailManagePageNameReferenceLibrary.GetLocSourceNewEmailHeadingNameReferenceForEmailManagePage();
            ChangeEmailButtonText = _locSourceEmailManagePageNameReferenceLibrary.GetLocSourceChangeEmailButtonTextNameReferenceForEmailManagePage();
            SendVerificationEmailButtonText = _locSourceEmailManagePageNameReferenceLibrary.GetLocSourceSendVerificationEmailButtonTextNameReferenceForEmailManagePage();
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
            ProfileNavButton = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourceProfileNavButtonNameReferenceForAccountManagePage();
            EmailNavButton = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourceEmailNavButtonNameReferenceForAccountManagePage();
            ExternalLoginsNavButton = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourceExternalLoginsNavButtonNameReferenceForAccountManagePage();
            PasswordNavButton = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourcePasswordNavButtonNameReferenceForAccountManagePage();
            TwoFANavButton = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourceTwoFANavButtonNameReferenceForAccountManagePage();
            PersonalDataNavButton = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourcePersonalDataNavButtonNameReferenceForAccountManagePage();
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


            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                var msg = _loc.GetLocalizedString("Unable to load user with ID '{0}'.", _userManager.GetUserId(User));
                return NotFound(msg);
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var email = await _userManager.GetEmailAsync(user);
            if (Input.NewEmail != email)
            {
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                var callbackUrl = Url.Page("/Account/ConfirmEmailChange", pageHandler: null, values: new { userId = user.Id, email = Input.NewEmail, code = code, culture }, protocol: Request.Scheme);

                var mailHeader = _loc.GetLocalizedString("Confirm your GatheringForGood email");
                var mailBody = _loc.GetLocalizedString(CultureInfo.CurrentCulture.Name, "Please confirm your GatheringForGood account by <a href='" + callbackUrl + "'>clicking here</a>.");

                await _emailSender.SendEmailAsync(Input.NewEmail, mailHeader, mailBody);

                var emailSent = _loc.GetLocalizedString("Confirmation link sent. Please check your email account.");
                StatusMessage = emailSent;
                //TempData.Info(emailSent);

                return RedirectToPage();
            }

            var emailUnchanged = _loc.GetLocalizedString("Your email is unchanged.");
            TempData.Info(emailUnchanged);

            return RedirectToPage($"~/{culture}");
        }

        public async Task<IActionResult> OnPostSendVerificationEmailAsync()
        {
            PageTabTitle = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForAccountManagePage();
            Title = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourceTitleNameReferenceForAccountManagePage();
            SubTitle = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForAccountManagePage();
            Heading = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourceHeadingNameReferenceForAccountManagePage();
            EmailHeading = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourceUsernameHeadingNameReferenceForAccountManagePage();
            NewEmailHeading = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourcePhoneNumberHeadingNameReferenceForAccountManagePage();
            ChangeEmailButtonText = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourceSaveButtonTextNameReferenceForAccountManagePage();
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
            ProfileNavButton = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourceProfileNavButtonNameReferenceForAccountManagePage();
            EmailNavButton = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourceEmailNavButtonNameReferenceForAccountManagePage();
            ExternalLoginsNavButton = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourceExternalLoginsNavButtonNameReferenceForAccountManagePage();
            PasswordNavButton = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourcePasswordNavButtonNameReferenceForAccountManagePage();
            TwoFANavButton = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourceTwoFANavButtonNameReferenceForAccountManagePage();
            PersonalDataNavButton = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourcePersonalDataNavButtonNameReferenceForAccountManagePage();
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

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                var msg = _loc.GetLocalizedString("Unable to load user with ID '{0}'.", _userManager.GetUserId(User));
                return NotFound(msg);
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                var callbackUrl = Url.Page("/Account/ConfirmEmailChange", pageHandler: null, values: new { userId = user.Id, email = Input.NewEmail, code = code, culture }, protocol: Request.Scheme);

                var mailHeader = _loc.GetLocalizedString("Confirm your GatheringForGood email");
                var mailBody = _loc.GetLocalizedString(CultureInfo.CurrentCulture.Name, "Please confirm your GatheringForGood account by <a href='" + callbackUrl + "'>clicking here</a>.");

                await _emailSender.SendEmailAsync(Input.NewEmail, mailHeader, mailBody);

                var emailSent = _loc.GetLocalizedString("Confirmation link sent. Please check your email account.");
                StatusMessage = emailSent;
                return RedirectToPage();
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
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Manage Email Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Manage Email Page Newsfeed Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Manage Email Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Manage Email Page Newsfeed Modal", FeedbackDateTime);
                }
            }

            return RedirectToPage("Email", new { culture });
        }
    }
}
