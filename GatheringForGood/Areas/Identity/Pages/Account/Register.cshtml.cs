using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LazZiya.ExpressLocalization;
using LazZiya.ExpressLocalization.DataAnnotations;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using GatheringForGood.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using LocSourceNameReferenceLibrary;
using System.Globalization;
using System.Diagnostics;
using GatheringForGood.Areas.FunctionalLogic;
using Microsoft.Extensions.Caching.Memory;
using ImageUrlReferenceLibrary;

namespace GatheringForGood.Areas.Identity.Pages.Account
{

    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ISharedCultureLocalizer _loc;
        private readonly string culture;
        readonly RegisterPageLocSourceNames _locSourceRegisterPageNameReferenceLibrary = new RegisterPageLocSourceNames();
        readonly SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
        SharedCrossPageImageUrls _imageUrlReferenceLibrary = new SharedCrossPageImageUrls();
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        private readonly IMemoryCache _cache;
        readonly RGWIncrementUserActionClicks RGWIncrementClicks = new();
        readonly UserBadgesFunctions UserBadgesFunctions = new();
        private readonly ApplicationDbContext _context;
        readonly SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            ISharedCultureLocalizer loc,
            IMemoryCache cache,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _loc = loc;
            culture = CultureInfo.CurrentCulture.Name;
            _cache = cache;
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }
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
        public string TandCHeading { get; set; }
        public string MarketingHeading { get; set; }
        public string HelpOthers { get; set; }
        public string FeatureUpdates { get; set; }
        public string ArticlesPosts { get; set; }
        public string ProductNews { get; set; }
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

        public class InputModel
        {
            [ExRequired]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [ExRequired]
            [ExStringLength(100, MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [ExCompare("Password")]
            public string ConfirmPassword { get; set; }

            [MustBeTrue(ErrorMessage ="You must accept the Terms & Conditions")]
            public bool TOSAgree { get; set; }

            public bool MarketingComms { get; set; }
            public bool HelpOthersCheckbox { get; set; }
            public bool FeatureUpdatesCheckbox { get; set; }
            public bool ArticlesPostsCheckbox { get; set; }
            public bool ProductNewsCheckbox { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            PageTabTitle = _locSourceRegisterPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForRegisterPage();
            Title = _locSourceRegisterPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForRegisterPage();
            SubTitle = _locSourceRegisterPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForRegisterPage();
            Heading = _locSourceRegisterPageNameReferenceLibrary.GetLocSourceHeadingNameReferenceForRegisterPage();
            ServiceHeading = _locSourceRegisterPageNameReferenceLibrary.GetLocSourceServiceHeadingNameReferenceForRegisterPage();
            EmailHeading = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceEmailHeadingNameReferenceForPage();
            PasswordHeading = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourcePasswordHeadingNameReferenceForPage();
            ConfirmPassword = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceConfirmPasswordHeadingNameReferenceForPage();
            RegisterButtonName = _locSourceRegisterPageNameReferenceLibrary.GetLocSourceRegisterButtonNameReferenceForRegisterPage();
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
            PasswordRequirements = _locSourceRegisterPageNameReferenceLibrary.GetLocSourcePasswordRequirementsNameReferenceForRegisterPage();
            ComingSoon = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceComingSoonLabelNameReference();
            LikeToSee = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLikeToSeeLabelNameReference();
            Submit = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceSubmitLabelNameReference();
            TandCHeading = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceTandCHeadingNameReferenceForPage();
            MarketingHeading = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceMarketingHeadingNameReferenceForPage();
            HelpOthers = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceHelpOthersHeadingNameReferenceForPage();
            FeatureUpdates = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceFeatureUpdatesHeadingNameReferenceForPage();
            ArticlesPosts = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceArticlesPostsHeadingNameReferenceForPage();
            ProductNews = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceProductNewsHeadingNameReferenceForPage();
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

            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            PageTabTitle = _locSourceRegisterPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForRegisterPage();
            Title = _locSourceRegisterPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForRegisterPage();
            SubTitle = _locSourceRegisterPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForRegisterPage();
            Heading = _locSourceRegisterPageNameReferenceLibrary.GetLocSourceHeadingNameReferenceForRegisterPage();
            ServiceHeading = _locSourceRegisterPageNameReferenceLibrary.GetLocSourceServiceHeadingNameReferenceForRegisterPage();
            EmailHeading = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceEmailHeadingNameReferenceForPage();
            PasswordHeading = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourcePasswordHeadingNameReferenceForPage();
            ConfirmPassword = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceConfirmPasswordHeadingNameReferenceForPage();
            RegisterButtonName = _locSourceRegisterPageNameReferenceLibrary.GetLocSourceRegisterButtonNameReferenceForRegisterPage();
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
            PasswordRequirements = _locSourceRegisterPageNameReferenceLibrary.GetLocSourcePasswordRequirementsNameReferenceForRegisterPage();
            ComingSoon = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceComingSoonLabelNameReference();
            LikeToSee = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLikeToSeeLabelNameReference();
            Submit = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceSubmitLabelNameReference();
            TandCHeading = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceTandCHeadingNameReferenceForPage();
            MarketingHeading = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceMarketingHeadingNameReferenceForPage();
            HelpOthers = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceHelpOthersHeadingNameReferenceForPage();
            FeatureUpdates = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceFeatureUpdatesHeadingNameReferenceForPage();
            ArticlesPosts = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceArticlesPostsHeadingNameReferenceForPage();
            ProductNews = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceProductNewsHeadingNameReferenceForPage();
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

            returnUrl = returnUrl ?? Url.Content($"~/{culture}");

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
                DateTime SignedUpDateTime = DateTime.UtcNow;
                var user = new ApplicationUser { UserName = Input.Email, Email = Input.Email, SignedUp = SignedUpDateTime, TandC = Input.TOSAgree, MarketingComms = Input.MarketingComms, AreasYouCanHelp = Input.HelpOthersCheckbox, FeatureUpdates = Input.FeatureUpdatesCheckbox, NewArticlePosts = Input.ArticlesPostsCheckbox, ProductNews = Input.ProductNewsCheckbox };
                var result = await _userManager.CreateAsync(user, Input.Password);

                //_cache.Set("User", user);
                MemoryCacheEntryOptions options = new MemoryCacheEntryOptions();
                options.AbsoluteExpiration = DateTime.Now.AddMinutes(20);
                //options.SlidingExpiration = TimeSpan.FromMinutes(1);
                _cache.Set<ApplicationUser>("User", user, options);
                _cache.Set<MemoryCacheEntryOptions>("Options", options, options);


                if (result.Succeeded)
                {
                    //Add user to userbadges db table
                    //Must happen before RGWIncrementClicks Below
                    await UserBadgesFunctions.AddUserToTable(user.Id, _context);

                    //Add value to UserEnvironmentalActionCounts table to prevent null ref error on RGW, RAE, RDF first time page load
                    await RGWIncrementClicks.UserClick(999, user.Id, _context);

                    //Send registration confirmation email
                    _logger.LogInformation("User created a new account with password.");
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page("/Account/ConfirmEmail", pageHandler: null, values: new { area = "Identity", userId = user.Id, code = code, culture }, protocol: Request.Scheme);
                    var mailHeader = _loc.GetLocalizedString("Confirm your gatheringforgood email");
                    var mailBody = _loc.GetLocalizedString(CultureInfo.CurrentCulture.Name, "" +
                        "<div class='container-body'>" +
                            "<div class='row justify-content-center align-items-center'>" +
                                "<div class='col justify-content-center align-items-center'>" +
                                    "<img src='https://gatheringforgood.com/images/circle_logo.webp' width='80' height='80' alt='Logo Image'>" +
                                "</div>" +
                                "<div class='col justify-content-center align-items-center'>" +
                                    "<h1>gatheringforgood</h1>" +
                                "</div>" +
                            "</div>" +
                            "<br />" +
                            "<div class='row justify-content-center align-items-center'>" +
                                "<div class='col justify-content-center align-items-center'>" +
                                    "Please confirm your <strong>gatheringforgood</strong> account by <a href='" + callbackUrl + "'>clicking here</a>." +
                                "</div>" +
                            "</div>" +
                        "</div>"
                            );
                    await _emailSender.SendEmailAsync(Input.Email, mailHeader, mailBody);

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, culture });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    // model binding error already localized by ExpressLocalization
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        public IActionResult Error()
        {
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
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Register Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Register Page Newsfeed Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Register Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Register Page Newsfeed Modal", FeedbackDateTime);
                }
            }

            return RedirectToPage("Register", new { culture });
        }
    }
}
