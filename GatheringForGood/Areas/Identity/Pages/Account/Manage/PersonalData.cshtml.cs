using System.Threading.Tasks;
using GatheringForGood.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LocSourceNameReferenceLibrary;
using GatheringForGood.Areas.FunctionalLogic;
using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using ImageUrlReferenceLibrary;

namespace GatheringForGood.Areas.Identity.Pages.Account.Manage
{
    public class PersonalDataModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly string culture;
        readonly AccountManagePageLocSourceNames _locSourceAccountManagePageNameReferenceLibrary = new AccountManagePageLocSourceNames();
        readonly DeletePersonalDataPageLocSourceNames _locSourceDeletePersonalDataPageNameReferenceLibrary = new DeletePersonalDataPageLocSourceNames();
        readonly SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
        SharedCrossPageImageUrls _imageUrlReferenceLibrary = new SharedCrossPageImageUrls();
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        private readonly IEmailSender _emailSender;
        readonly SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();

        public PersonalDataModel(UserManager<ApplicationUser> userManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            culture = System.Globalization.CultureInfo.CurrentCulture.Name;
            _emailSender = emailSender;
        }

        [BindProperty]
        public string StatusMessage { get; set; }
        public string PageTabTitle { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Heading { get; set; }
        public string PersonalDataPara1 { get; set; }
        public string PersonalDataPara2 { get; set; }
        public string DeleteDataPara1 { get; set; }
        public string DeleteDataPara2 { get; set; }
        public string DeleteDataPara3 { get; set; }
        public string DeleteButtonText { get; set; }
        public string DownloadButtonText { get; set; }
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

        public async Task<IActionResult> OnGet()
        {
            PageTabTitle = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForAccountManagePage();
            Title = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourceTitleNameReferenceForAccountManagePage();
            SubTitle = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForAccountManagePage();
            Heading = _locSourceAccountManagePageNameReferenceLibrary.GetLocSourceHeadingNameReferenceForAccountManagePage();
            PersonalDataPara1 = _locSourceDeletePersonalDataPageNameReferenceLibrary.GetLocSourcePersonalDataPara1NameReferenceForDeletePersonalDataPage();
            PersonalDataPara2 = _locSourceDeletePersonalDataPageNameReferenceLibrary.GetLocSourcePersonalDataPara2NameReferenceForDeletePersonalDataPage();
            DeleteDataPara1 = _locSourceDeletePersonalDataPageNameReferenceLibrary.GetLocSourceDeleteDataPara1NameReferenceForDeletePersonalDataPage();
            DeleteDataPara2 = _locSourceDeletePersonalDataPageNameReferenceLibrary.GetLocSourceDeleteDataPara2NameReferenceForDeletePersonalDataPage();
            DeleteDataPara3 = _locSourceDeletePersonalDataPageNameReferenceLibrary.GetLocSourceDeleteDataPara3NameReferenceForDeletePersonalDataPage();
            DeleteButtonText = _locSourceDeletePersonalDataPageNameReferenceLibrary.GetLocSourceDeleteButtonTextNameReferenceForDeletePersonalDataPage();
            DownloadButtonText = _locSourceDeletePersonalDataPageNameReferenceLibrary.GetLocSourceDownloadButtonTextNameReferenceForDeletePersonalDataPage();
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
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
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
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Personal Data Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Personal Data Page Newsfeed Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Personal Data Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Personal Data Page Newsfeed Modal", FeedbackDateTime);
                }
            }

            return RedirectToPage("PersonalData", new { culture });
        }
    }
}