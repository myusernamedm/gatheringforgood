using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using GatheringForGood.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Caching.Memory;
using LocSourceNameReferenceLibrary;
using GatheringForGood.Areas.FunctionalLogic;
using System.Diagnostics;
using ImageUrlReferenceLibrary;

namespace GatheringForGood.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ResetPasswordModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly string culture;
        readonly ResetPasswordPageLocSourceNames _locSourceResetPasswordPageNameReferenceLibrary = new ResetPasswordPageLocSourceNames();
        readonly SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
        SharedCrossPageImageUrls _imageUrlReferenceLibrary = new SharedCrossPageImageUrls();
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        private readonly IEmailSender _emailSender;
        private readonly IMemoryCache _cache;
        readonly SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();

        public ResetPasswordModel(UserManager<ApplicationUser> userManager, IEmailSender emailSender, IMemoryCache cache)
        {
            _emailSender = emailSender;
            culture = System.Globalization.CultureInfo.CurrentCulture.Name;
            _userManager = userManager;
            _cache = cache;
        }

        [BindProperty]
        public InputModel Input { get; set; }
        public bool DisplayConfirmAccountLink { get; set; }
        public string EmailConfirmationUrl { get; set; }
        public string ReturnUrl { get; set; }
        public string PageTabTitle { get; set; }
        public string Title { get; set; }
        public string EmailHeading { get; set; }
        public string SubTitle { get; set; }
        public string Heading { get; set; }
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
        public string Submit { get; set; }
        public string ComingSoon { get; set; }
        public string LikeToSee { get; set; }
        public string PasswordHeading { get; set; }
        public string ConfirmPassword { get; set; }
        public string ResetButton { get; set; }
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

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            public string Code { get; set; }
        }

        public IActionResult OnGet(string code = null)
        {
            PageTabTitle = _locSourceResetPasswordPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForResetPasswordPage();
            Title = _locSourceResetPasswordPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForResetPasswordPage();
            SubTitle = _locSourceResetPasswordPageNameReferenceLibrary.GetLocSourceSubHeadingNameReferenceForResetPasswordPage();
            Heading = _locSourceResetPasswordPageNameReferenceLibrary.GetLocSourceHeadingNameReferenceForResetPasswordPage();
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
            EmailHeading = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceEmailHeadingNameReferenceForPage();
            PasswordHeading = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourcePasswordHeadingNameReferenceForPage();
            ConfirmPassword = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceConfirmPasswordHeadingNameReferenceForPage();
            ResetButton = _locSourceResetPasswordPageNameReferenceLibrary.GetLocSourceResetButtonNameReferenceForResetPasswordPage();
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

            bool newsfeedPost;

            if(_cache.TryGetValue("newsfeedPost", out newsfeedPost))
            {
                Debug.WriteLine("******************* newsfeedPost: " + newsfeedPost);
                return Page();
            } 
            else
            {
                if (code == null)
                {
                    return BadRequest("A code must be supplied for password reset.");
                }
                else
                {
                    Input = new InputModel
                    {
                        Code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code))
                    };
                    return Page();
                }
            }

        }

        public async Task<IActionResult> OnPostAsync()
        {
            PageTabTitle = _locSourceResetPasswordPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForResetPasswordPage();
            Title = _locSourceResetPasswordPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForResetPasswordPage();
            SubTitle = _locSourceResetPasswordPageNameReferenceLibrary.GetLocSourceSubHeadingNameReferenceForResetPasswordPage();
            Heading = _locSourceResetPasswordPageNameReferenceLibrary.GetLocSourceHeadingNameReferenceForResetPasswordPage();
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
            EmailHeading = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceEmailHeadingNameReferenceForPage();
            PasswordHeading = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourcePasswordHeadingNameReferenceForPage();
            ConfirmPassword = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceConfirmPasswordHeadingNameReferenceForPage();
            ResetButton = _locSourceResetPasswordPageNameReferenceLibrary.GetLocSourceResetButtonNameReferenceForResetPasswordPage();
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
                Debug.WriteLine("******************* Model State Not Valid: ");
                return Page();
            }

            var user = await _userManager.FindByEmailAsync(Input.Email);
            Debug.WriteLine("******************* user: " + user.ToString());
            if (user == null)
            {
                Debug.WriteLine("******************* user does not exist ");
                // Don't reveal that the user does not exist
                return RedirectToPage("./ResetPasswordConfirmation");
            }

            var result = await _userManager.ResetPasswordAsync(user, Input.Code, Input.Password);
            if (result.Succeeded)
            {
                Debug.WriteLine("******************* user password reset ");
                return RedirectToPage("./ResetPasswordConfirmation");
            }

            foreach (var error in result.Errors)
            {
                Debug.WriteLine("******************* Error: " + error.Description.ToString());
                ModelState.AddModelError(string.Empty, error.Description);
            }
            Debug.WriteLine("******************* return Page ");
            return Page();
        }

        public async Task<IActionResult> OnPostSaveUserEntryAsync(string newsfeedUserEntry)
        {
            bool newsfeedPost = true;
            MemoryCacheEntryOptions options = new MemoryCacheEntryOptions();
            options.AbsoluteExpiration = DateTime.Now.AddSeconds(5);
            //options.SlidingExpiration = TimeSpan.FromMinutes(1);
            _cache.Set<Boolean>("newsfeedPost", newsfeedPost, options);

            DateTime FeedbackDateTime = DateTime.UtcNow;

            if (newsfeedUserEntry != null)
            {
                string userId = ClaimsPrincipalExtensions.GetUserId<string>(User);
                if (userId != null)
                {
                    bool loggedInUser = true;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Reset Password Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Reset Password Page Newsfeed Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Reset Password Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Reset Password Page Newsfeed Modal", FeedbackDateTime);
                }
            }

            return RedirectToPage("Index", new { culture });
        }
    }
}
