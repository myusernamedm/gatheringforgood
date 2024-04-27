using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using GatheringForGood.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using LocSourceNameReferenceLibrary;
using LazZiya.ExpressLocalization;
using LazZiya.TagHelpers.Alerts;
using LazZiya.ExpressLocalization.DataAnnotations;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Globalization;
using GatheringForGood.Areas.FunctionalLogic;
using ImageUrlReferenceLibrary;
using System.Diagnostics;
using GatheringForGood.Areas.Identity.Data;

namespace GatheringForGood.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly ISharedCultureLocalizer _loc;
        private readonly string culture;
        readonly LoginPageLocSourceNames _locSourceLoginPageNameReferenceLibrary = new LoginPageLocSourceNames();
        readonly SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
        SharedCrossPageImageUrls _imageUrlReferenceLibrary = new SharedCrossPageImageUrls();
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        private readonly IEmailSender _emailSender;
        readonly SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();

        public LoginModel(SignInManager<ApplicationUser> signInManager,
            ILogger<LoginModel> logger,
            UserManager<ApplicationUser> userManager,
            IEmailSender emailSender,
            ISharedCultureLocalizer loc)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _logger = logger;
            _loc = loc;
            culture = CultureInfo.CurrentCulture.Name;
        }

        [BindProperty]
        public InputModel Input { get; set; }
        public string StatusMessage { get; set; }
        public string ReturnUrl { get; set; }
        public string OGUrl { get; set; }
        public string PageTabTitle { get; set; }
        public string ArticleTitleImageUrl { get; set; }
        public string ArticleTitle { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Heading { get; set; }
        public string ServiceHeading { get; set; }
        public string EmailHeading { get; set; }
        public string PasswordHeading { get; set; }
        public string LoginButtonName { get; set; }
        public string ForgotPassword { get; set; }
        public string RegisterAsNewUser { get; set; }
        public string ResendEmailConfirmation { get; set; }
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

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [ExRequired]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [ExRequired]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            Debug.WriteLine("************ returnUrl: " + returnUrl);

            if(returnUrl != null)
            {
                string data = returnUrl.Substring(returnUrl.LastIndexOf("/") + 1);
                if(data != "ReduceAnimalExtinction" && data != "ReduceGlobalWarming" && data != "ReduceDeforestation")
                {
                    ArticleDetails ArticleDetailsList = GetUserArticleDetails.retrieveArticleDataFromDB(data);
                    if (ArticleDetailsList != null)
                    {
                        ArticleTitleImageUrl = ArticleDetailsList.TitleImageUrl;
                        ArticleTitle = "GatheringForGood - " + ArticleDetailsList.Title;
                        OGUrl = "https://gatheringforgood.com" + returnUrl;
                        Debug.WriteLine("************ ArticleTitleImageUrl: " + ArticleTitleImageUrl);
                        Debug.WriteLine("************ OGUrl: " + OGUrl);
                    }
                }
                else if (data == "ReduceGlobalWarming")
                {
                    ArticleTitleImageUrl = "http://www.gatheringforgood.com/images/shareimagergw.jpg";
                    OGUrl = "https://gatheringforgood.com/en/ReduceGlobalWarming/ReduceGlobalWarming";
                    Debug.WriteLine("************ ArticleTitleImageUrl1: " + ArticleTitleImageUrl);
                    Debug.WriteLine("************ OGUrl1: " + OGUrl);
                }
                else if (data == "ReduceAnimalExtinction")
                {
                    ArticleTitleImageUrl = "http://www.gatheringforgood.com/images/shareimagerae.jpg";
                    OGUrl = "https://gatheringforgood.com/en/ReduceAnimalExtinction/ReduceAnimalExtinction";
                    Debug.WriteLine("************ ArticleTitleImageUrl2: " + ArticleTitleImageUrl);
                    Debug.WriteLine("************ OGUrl2: " + OGUrl);
                }
                else if (data == "ReduceDeforestation")
                {
                    ArticleTitleImageUrl = "http://www.gatheringforgood.com/images/shareimagerdf.jpg";
                    OGUrl = "https://gatheringforgood.com/en/ReduceDeforestation/ReduceDeforestation";
                    Debug.WriteLine("************ ArticleTitleImageUrl3: " + ArticleTitleImageUrl);
                    Debug.WriteLine("************ OGUrl3: " + OGUrl);
                }

                Debug.WriteLine("************ data: " + data);
            }

            PageTabTitle = _locSourceLoginPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForLoginPage();
            Title = _locSourceLoginPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForLoginPage();
            SubTitle = _locSourceLoginPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForLoginPage();
            Heading = _locSourceLoginPageNameReferenceLibrary.GetLocSourceHeadingNameReferenceForLoginPage();
            ServiceHeading = _locSourceLoginPageNameReferenceLibrary.GetLocSourceServiceHeadingNameReferenceForLoginPage();
            EmailHeading = _locSourceLoginPageNameReferenceLibrary.GetLocSourceEmailHeadingNameReferenceForLoginPage();
            PasswordHeading = _locSourceLoginPageNameReferenceLibrary.GetLocSourcePasswordHeadingNameReferenceForLoginPage();
            LoginButtonName = _locSourceLoginPageNameReferenceLibrary.GetLocSourceLoginButtonNameReferenceForLoginPage();
            ForgotPassword = _locSourceLoginPageNameReferenceLibrary.GetLocSourceForgotPasswordNameReferenceForLoginPage();
            RegisterAsNewUser = _locSourceLoginPageNameReferenceLibrary.GetLocSourceRegisterAsNewUserNameReferenceForLoginPage();
            ResendEmailConfirmation = _locSourceLoginPageNameReferenceLibrary.GetLocSourceResendEmailConfirmationNameReferenceForLoginPage();
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
            returnUrl = returnUrl ?? Url.Content($"~/{culture}");
            ReturnUrl = returnUrl;
            Debug.WriteLine("************ ReturnUrl: " + ReturnUrl);
            GetEarthHandsReducedImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReducedImageUrlForPage();
            GetEarthHandsReduced400ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced400ImageUrlForPage();
            GetEarthHandsReduced800ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced800ImageUrlForPage();
            GetEarthHandsReduced1200ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced1200ImageUrlForPage();
            GetEarthHandsReduced1600ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced1600ImageUrlForPage();

            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            Debug.WriteLine("************ returnUrl: " + returnUrl);
            PageTabTitle = _locSourceLoginPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForLoginPage();
            Title = _locSourceLoginPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForLoginPage();
            SubTitle = _locSourceLoginPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForLoginPage();
            Heading = _locSourceLoginPageNameReferenceLibrary.GetLocSourceHeadingNameReferenceForLoginPage();
            ServiceHeading = _locSourceLoginPageNameReferenceLibrary.GetLocSourceServiceHeadingNameReferenceForLoginPage();
            EmailHeading = _locSourceLoginPageNameReferenceLibrary.GetLocSourceEmailHeadingNameReferenceForLoginPage();
            PasswordHeading = _locSourceLoginPageNameReferenceLibrary.GetLocSourcePasswordHeadingNameReferenceForLoginPage();
            LoginButtonName = _locSourceLoginPageNameReferenceLibrary.GetLocSourceLoginButtonNameReferenceForLoginPage();
            ForgotPassword = _locSourceLoginPageNameReferenceLibrary.GetLocSourceForgotPasswordNameReferenceForLoginPage();
            RegisterAsNewUser = _locSourceLoginPageNameReferenceLibrary.GetLocSourceRegisterAsNewUserNameReferenceForLoginPage();
            ResendEmailConfirmation = _locSourceLoginPageNameReferenceLibrary.GetLocSourceResendEmailConfirmationNameReferenceForLoginPage();
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
            returnUrl = returnUrl ?? Url.Content($"~/{culture}");
            Debug.WriteLine("************ returnUrl 1: " + returnUrl);
            GetEarthHandsReducedImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReducedImageUrlForPage();
            GetEarthHandsReduced400ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced400ImageUrlForPage();
            GetEarthHandsReduced800ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced800ImageUrlForPage();
            GetEarthHandsReduced1200ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced1200ImageUrlForPage();
            GetEarthHandsReduced1600ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced1600ImageUrlForPage();

            if (ModelState.IsValid)
            {
                        // This doesn't count login failures towards account lockout
                        // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                        var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: true);


                        if (result.Succeeded)
                        {
                            _logger.LogInformation("User logged in.");
                            return LocalRedirect(returnUrl);
                        }
                        if (result.RequiresTwoFactor)
                        {
                            return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, Input.RememberMe, culture });
                        }
                        if (result.IsLockedOut)
                        {
                            _logger.LogWarning("User account locked out.");
                            return RedirectToPage("./Lockout", new { culture });
                        }
                        else
                        {
                            var msg = _loc.GetLocalizedString("Invalid login attempt.");
                            TempData.Warning(msg);
                            var emailSent = _loc.GetLocalizedString("Oops...there must be too much CO2 in the air! 1) Check your email to confirm your account. 2) Check your spam folder. 3) Try 'Resend Email Confirmation' below. 4) Contact Us.");
                            StatusMessage = emailSent;
                            return Page();
                        }
                }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        public async Task<IActionResult> OnPostSendVerificationEmailAsync()
        {
            PageTabTitle = _locSourceLoginPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForLoginPage();
            Title = _locSourceLoginPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForLoginPage();
            SubTitle = _locSourceLoginPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForLoginPage();
            Heading = _locSourceLoginPageNameReferenceLibrary.GetLocSourceHeadingNameReferenceForLoginPage();
            ServiceHeading = _locSourceLoginPageNameReferenceLibrary.GetLocSourceServiceHeadingNameReferenceForLoginPage();
            EmailHeading = _locSourceLoginPageNameReferenceLibrary.GetLocSourceEmailHeadingNameReferenceForLoginPage();
            PasswordHeading = _locSourceLoginPageNameReferenceLibrary.GetLocSourcePasswordHeadingNameReferenceForLoginPage();
            LoginButtonName = _locSourceLoginPageNameReferenceLibrary.GetLocSourceLoginButtonNameReferenceForLoginPage();
            ForgotPassword = _locSourceLoginPageNameReferenceLibrary.GetLocSourceForgotPasswordNameReferenceForLoginPage();
            RegisterAsNewUser = _locSourceLoginPageNameReferenceLibrary.GetLocSourceRegisterAsNewUserNameReferenceForLoginPage();
            ResendEmailConfirmation = _locSourceLoginPageNameReferenceLibrary.GetLocSourceResendEmailConfirmationNameReferenceForLoginPage();
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

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.FindByEmailAsync(Input.Email);
            if (user == null)
            {
                var UserLoadFailure = _loc.GetLocalizedString("Sorry, we cant let you do that.", user);
                StatusMessage = UserLoadFailure;
                return Page();
            }
            else
            {
                //var userId = await _userManager.GetUserIdAsync(user);
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

                var callbackUrl = Url.Page("/Account/ConfirmEmail", pageHandler: null, values: new { area = "Identity", userId = user.Id, code = code, culture }, protocol: Request.Scheme);

                var mailHeader = _loc.GetLocalizedString("Confirm your email");
                var mailBody = _loc.GetLocalizedString(CultureInfo.CurrentCulture.Name, "Please confirm your GatheringForGood account by <a href='" + callbackUrl + "'>clicking here</a>.");

                await _emailSender.SendEmailAsync(Input.Email, mailHeader, mailBody);

                var emailSent = _loc.GetLocalizedString("Confirmation link sent. Please check your email account.");
                StatusMessage = emailSent;
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
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Login Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Login Page Newsfeed Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Login Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Login Page Newsfeed Modal", FeedbackDateTime);
                }
            }

            return RedirectToPage("Login", new { culture });
        }
    }
}
