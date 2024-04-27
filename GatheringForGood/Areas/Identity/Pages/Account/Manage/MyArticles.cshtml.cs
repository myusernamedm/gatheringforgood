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
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Extensions.Caching.Memory;

namespace GatheringForGood.Areas.Identity.Pages.Account.Manage
{
    public partial class MyArticlesModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ISharedCultureLocalizer _loc;
        private readonly string culture;
        readonly EmailManagePageLocSourceNames _locSourceEmailManagePageNameReferenceLibrary = new EmailManagePageLocSourceNames();
        readonly AccountManagePageLocSourceNames _locSourceAccountManagePageNameReferenceLibrary = new AccountManagePageLocSourceNames();
        readonly SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
        readonly MyArticlesLocSourceNames _locSourceMyArticlesNameReferenceLibrary = new MyArticlesLocSourceNames();
        SharedCrossPageImageUrls _imageUrlReferenceLibrary = new SharedCrossPageImageUrls();
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        readonly DeleteUserArticle deleteUserArticle = new();
        readonly BlobDelete deleteBlobs = new();
        readonly ShowHideUserArticle showHideUserArticle = new();
        private readonly IEmailSender _emailSender;
        private static readonly ApplicationDbContext _context = new();
        private IMemoryCache _cache;
        readonly SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();

        public MyArticlesModel(UserManager<ApplicationUser> userManager, IEmailSender emailSender, ISharedCultureLocalizer loc, IMemoryCache memoryCache)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            _loc = loc;
            culture = CultureInfo.CurrentCulture.Name;
            _cache = memoryCache;
        }

        public bool IsEmailConfirmed { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }
        public string Username { get; set; }
        public string UserId { get; set; }
        public List<GetArticlesCardDetails> ArticlesList { get; set; }
        public string PageTabTitle { get; set; }
        public string ReturnUrl { get; set; }
        public string Title { get; set; }
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
        public string ProfileNavButton { get; set; }
        public string EmailNavButton { get; set; }
        public string PasswordNavButton { get; set; }
        public string PersonalDataNavButton { get; set; }
        public string Submit { get; set; }
        public string Updates { get; set; }
        public string HomepageShare { get; set; }
        public string IconTwitter { get; set; }
        public string IconLinkedin { get; set; }
        public string IconFacebook { get; set; }
        public string TableColImage { get; set; }
        public string TableColTitle { get; set; }
        public string TableColPosted { get; set; }
        public string TableColDelete { get; set; }
        public string TableColShow { get; set; }
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

            [DataType(DataType.Text)]
            public string uniqueArticleRef { get; set; }

            public bool ShowArticle { get; set; }
        }

        private async Task LoadAsync()
        {
            var MainArticleList = await GetArticlesCardDetails.GetCardDetailsAsync(_context,0,0,null);
            ArticlesList = MainArticleList;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            PageTabTitle = _locSourceMyArticlesNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForMyArticlesPage();
            Title = _locSourceMyArticlesNameReferenceLibrary.GetLocSourceTitleNameReferenceForMyArticlesPage();
            SubTitle = _locSourceMyArticlesNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForMyArticlesPage();
            Heading = _locSourceMyArticlesNameReferenceLibrary.GetLocSourceHeadingNameReferenceForMyArticlesPage();
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
            PasswordNavButton = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourcePasswordNavButtonNameReferenceForAccountManagePage();
            PersonalDataNavButton = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourcePersonalDataNavButtonNameReferenceForAccountManagePage();
            Submit = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceSubmitLabelNameReference();
            Updates = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceUpdatesNameReferenceForPage();
            HomepageShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20are%20taking%20action%20to%20help%20save%20the%20world!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com";
            IconTwitter = _imageUrlReferenceLibrary.GetTwitterIconUrlForPage();
            IconLinkedin = _imageUrlReferenceLibrary.GetLinkedinIconUrlForPage();
            IconFacebook = _imageUrlReferenceLibrary.GetFacebookIconUrlForPage();
            TableColImage = _locSourceMyArticlesNameReferenceLibrary.GetLocSourceTableColImageNameReferenceForMyArticlesPage();
            TableColTitle = _locSourceMyArticlesNameReferenceLibrary.GetLocSourceTableColTitleNameReferenceForMyArticlesPage();
            TableColPosted = _locSourceMyArticlesNameReferenceLibrary.GetLocSourceTableColPostedNameReferenceForMyArticlesPage();
            TableColDelete = _locSourceMyArticlesNameReferenceLibrary.GetLocSourceTableColDeleteNameReferenceForMyArticlesPage();
            TableColShow = _locSourceMyArticlesNameReferenceLibrary.GetLocSourceTableColShowNameReferenceForMyArticlesPage();
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
            } else
            {
                UserId = user.Id.ToString();
            }

            await LoadAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostDeleteArticleAsync(string uniqueArticleRef)
        {
            var UserIDValue = ClaimsPrincipalExtensions.GetUserId<string>(User);
            await deleteBlobs.DeleteAzureBlobAsync(UserIDValue, uniqueArticleRef);
            bool success = await deleteUserArticle.DeleteArticleAsync(uniqueArticleRef);
            if (success)
            {
                return RedirectToPage("MyArticles");
            }
            else
            {
                return RedirectToPage("MyArticles");
            }

        }

        public async Task<IActionResult> OnPostShowArticleAsync()
        {
            string uniqueArticleRef = Input.uniqueArticleRef;
            var showArticleBool = Input.ShowArticle;
            Debug.WriteLine("************** uniqueArticleRef: " + uniqueArticleRef);
            Debug.WriteLine("************** showArticleBool: " + showArticleBool);

            bool success = await showHideUserArticle.ShowHideArticleAsync(uniqueArticleRef, showArticleBool);

            return RedirectToPage("MyArticles");

        }
    }
}
