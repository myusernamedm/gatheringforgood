using System.Threading.Tasks;
using GatheringForGood.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;
using LazZiya.TagHelpers.Alerts;
using ImageUrlReferenceLibrary;

namespace GatheringForGood.Areas.Identity.Pages.Account.Manage
{
    public class TwoFactorAuthenticationModel : PageModel
    {
        private const string AuthenicatorUriFormat = "otpauth://totp/{0}:{1}?secret={2}&issuer={0}";

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<TwoFactorAuthenticationModel> _logger;
        private readonly ISharedCultureLocalizer _loc;
        private readonly string culture;
        readonly AccountManagePageLocSourceNames _locSourceAccountManagePageNameReferenceLibrary = new AccountManagePageLocSourceNames();
        readonly TwoFactorAuthenticationManagePageLocSourceNames _locSourceTwoFactorAuthenticationManagePageNameReferenceLibrary = new TwoFactorAuthenticationManagePageLocSourceNames();
        readonly SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
        SharedCrossPageImageUrls _imageUrlReferenceLibrary = new SharedCrossPageImageUrls();
        readonly SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();

        public TwoFactorAuthenticationModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<TwoFactorAuthenticationModel> logger,
            ISharedCultureLocalizer loc)

        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _loc = loc;
            culture = System.Globalization.CultureInfo.CurrentCulture.Name;
        }

        public bool HasAuthenticator { get; set; }

        public int RecoveryCodesLeft { get; set; }

        [BindProperty]
        public bool Is2faEnabled { get; set; }
        public bool IsMachineRemembered { get; set; }
        public string PageTabTitle { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Heading { get; set; }
        public string AuthAppHeading { get; set; }
        public string SetupAuthAppButtonText { get; set; }
        public string ResetAuthAppButtonText { get; set; }
        public string AddAuthAppButtonText { get; set; }
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

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGet()
        {
            PageTabTitle = _locSourceTwoFactorAuthenticationManagePageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForTwoFactorAuthPage();
            Title = _locSourceTwoFactorAuthenticationManagePageNameReferenceLibrary.GetLocSourceTitleNameReferenceForTwoFactorAuthPage();
            SubTitle = _locSourceTwoFactorAuthenticationManagePageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForTwoFactorAuthPage();
            Heading = _locSourceTwoFactorAuthenticationManagePageNameReferenceLibrary.GetLocSourceHeadingNameReferenceForTwoFactorAuthPage();
            AuthAppHeading = _locSourceTwoFactorAuthenticationManagePageNameReferenceLibrary.GetLocSourceAuthAppHeadingNameReferenceForTwoFactorAuthPage();
            SetupAuthAppButtonText = _locSourceTwoFactorAuthenticationManagePageNameReferenceLibrary.GetLocSourceSetupAuthAppButtonTextNameReferenceForTwoFactorAuthPage();
            ResetAuthAppButtonText = _locSourceTwoFactorAuthenticationManagePageNameReferenceLibrary.GetLocSourceResetAuthAppButtonTextNameReferenceForTwoFactorAuthPage();
            AddAuthAppButtonText = _locSourceTwoFactorAuthenticationManagePageNameReferenceLibrary.GetLocSourceAddAuthAppButtonTextNameReferenceForTwoFactorAuthPage();
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
            Updates = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceUpdatesNameReferenceForPage();
            HomepageShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20are%20taking%20action%20to%20help%20save%20the%20world!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com";
            IconTwitter = _imageUrlReferenceLibrary.GetTwitterIconUrlForPage();
            IconLinkedin = _imageUrlReferenceLibrary.GetLinkedinIconUrlForPage();
            IconFacebook = _imageUrlReferenceLibrary.GetFacebookIconUrlForPage(); GetEarthHandsReducedImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReducedImageUrlForPage();
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

            HasAuthenticator = await _userManager.GetAuthenticatorKeyAsync(user) != null;
            Is2faEnabled = await _userManager.GetTwoFactorEnabledAsync(user);
            IsMachineRemembered = await _signInManager.IsTwoFactorClientRememberedAsync(user);
            RecoveryCodesLeft = await _userManager.CountRecoveryCodesAsync(user);

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            PageTabTitle = _locSourceTwoFactorAuthenticationManagePageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForTwoFactorAuthPage();
            Title = _locSourceTwoFactorAuthenticationManagePageNameReferenceLibrary.GetLocSourceTitleNameReferenceForTwoFactorAuthPage();
            SubTitle = _locSourceTwoFactorAuthenticationManagePageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForTwoFactorAuthPage();
            Heading = _locSourceTwoFactorAuthenticationManagePageNameReferenceLibrary.GetLocSourceHeadingNameReferenceForTwoFactorAuthPage();
            AuthAppHeading = _locSourceTwoFactorAuthenticationManagePageNameReferenceLibrary.GetLocSourceAuthAppHeadingNameReferenceForTwoFactorAuthPage();
            SetupAuthAppButtonText = _locSourceTwoFactorAuthenticationManagePageNameReferenceLibrary.GetLocSourceSetupAuthAppButtonTextNameReferenceForTwoFactorAuthPage();
            ResetAuthAppButtonText = _locSourceTwoFactorAuthenticationManagePageNameReferenceLibrary.GetLocSourceResetAuthAppButtonTextNameReferenceForTwoFactorAuthPage();
            AddAuthAppButtonText = _locSourceTwoFactorAuthenticationManagePageNameReferenceLibrary.GetLocSourceAddAuthAppButtonTextNameReferenceForTwoFactorAuthPage();
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

            string msg;
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                msg = _loc.GetLocalizedString("Unable to load user with ID '{0}'.", _userManager.GetUserId(User));
                return NotFound(msg);
            }

            await _signInManager.ForgetTwoFactorClientAsync();
            msg = _loc.GetLocalizedString("The current browser has been forgotten. When you login again from this browser you will be prompted for your 2fa code.");
            TempData.Info(msg);
            return RedirectToPage();
        }
    }
}