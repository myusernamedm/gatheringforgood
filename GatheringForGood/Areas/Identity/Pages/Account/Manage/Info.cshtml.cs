using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using GatheringForGood.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LocSourceNameReferenceLibrary;
using System.Threading.Tasks;
using LazZiya.ExpressLocalization;
using LazZiya.ExpressLocalization.DataAnnotations;
using System.Globalization;
using GatheringForGood.Areas.FunctionalLogic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Caching.Memory;
using ImageUrlReferenceLibrary;

namespace GatheringForGood.Areas.Identity.Pages.Account.Manage
{
    public class InfoModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ISharedCultureLocalizer _loc;
        private readonly string culture;
        readonly RegisterConfPageLocSourceNames _locSourceRegisterConfPageNameReferenceLibrary = new RegisterConfPageLocSourceNames();
        readonly SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
        readonly EmailManagePageLocSourceNames _locSourceEmailManagePageNameReferenceLibrary = new EmailManagePageLocSourceNames();
        readonly InfoPageLocSourceNames _locSourceInfoPageNameReferenceLibrary = new InfoPageLocSourceNames();
        readonly AccountManagePageLocSourceNames _locSourceAccountManagePageNameReferenceLibrary = new AccountManagePageLocSourceNames();
        SharedCrossPageImageUrls _imageUrlReferenceLibrary = new SharedCrossPageImageUrls();
        private static readonly ApplicationDbContext _context = new();
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        private readonly IEmailSender _emailSender;
        private readonly IMemoryCache _cache;
        readonly SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();

        public InfoModel(UserManager<ApplicationUser> userManager, ISharedCultureLocalizer loc, IEmailSender emailSender, IMemoryCache cache)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            _loc = loc;
            culture = CultureInfo.CurrentCulture.Name;
            _cache = cache;
        }

        public bool IsEmailConfirmed { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PageTabTitle { get; set; }
        public string ReturnUrl { get; set; }
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
        public string CheckEmailHeading1 { get; set; }
        public string CheckEmailHeading2 { get; set; }
        public string FirstNameHeading { get; set; }
        public string ExistingFirstName { get; set; }
        public string SurNameHeading { get; set; }
        public string ExistingSurName { get; set; }
        public string CompanyNameHeading { get; set; }
        public string ExistingCompanyName { get; set; }
        public string SkillHeading { get; set; }
        public string ExistingSkill { get; set; }
        public string AreaOfInterestHeading { get; set; }
        public string ExistingAreaOfInterest { get; set; }
        public string AgeHeading { get; set; }
        public string ExistingAge { get; set; }
        public string CountryHeading { get; set; }
        public string ExistingCountry { get; set; }
        public string RegionHeading { get; set; }
        public string ExistingRegion { get; set; }
        public string SelectCountryFirstPara { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string NewValue { get; set; }
        public string SeparateSkillComma { get; set; }
        public string SeparateAreaComma { get; set; }
        public string ExistingSkills { get; set; }
        public string ExistingInterests { get; set; }
        public string MarketingHeading { get; set; }
        public string ExistingMarketing { get; set; }
        public string NewMarketingComms { get; set; }
        public string HelpOthers { get; set; }
        public string ExistingHelpOthers { get; set; }
        public string NewHelpOthers { get; set; }
        public string FeatureUpdates { get; set; }
        public string ExistingFeatureUpdates { get; set; }
        public string NewFeatureUpdates { get; set; }
        public string ArticlesPosts { get; set; }
        public string ExistingArticlesPosts { get; set; }
        public string NewArticlesPosts { get; set; }
        public string ProductNews { get; set; }
        public string ExistingProductNews { get; set; }
        public string NewProductNews { get; set; }
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

        [BindProperty]
        public int Number { get; set; }
        public List<SelectListItem> ListOfCountries { get; set; }
        public List<SelectListItem> ListOfSkills { get; set; }
        public List<SelectListItem> AreasOfInterest { get; set; }
        public class InputModel
        {
            [ExRequired]
            [EmailAddress]
            [Display(Name = "New email")]
            public string NewEmail { get; set; }

            [ExStringLength(100, MinimumLength = 3)]
            [DataType(DataType.Text)]
            [Display(Name = "FirstName")]
            public string NewFirstName { get; set; }

            [ExStringLength(100, MinimumLength = 3)]
            [DataType(DataType.Text)]
            [Display(Name = "SurName")]
            public string NewSurName { get; set; }

            [ExStringLength(200, MinimumLength = 3)]
            [DataType(DataType.Text)]
            [Display(Name = "CompanyName")]
            public string NewCompanyName { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "Skill")]
            public string NewSkill { get; set; }

            [ExStringLength(100, MinimumLength = 3)]
            [DataType(DataType.Text)]
            [Display(Name = "AreaOfInterest")]
            public string NewAreaOfInterest { get; set; }

            [Range(0, 120)]
            [RegularExpression(@"([0-9]+)", ErrorMessage = "Must be a Number.")]
            [Display(Name = "Age")]
            public int NewAge { get; set; }

            [ExStringLength(100, MinimumLength = 1)]
            [DataType(DataType.Text)]
            [Display(Name = "Country")]
            public string NewCountry { get; set; }

            [ExStringLength(100, MinimumLength = 1)]
            [DataType(DataType.Text)]
            [Display(Name = "Region")]
            public string NewRegion { get; set; }
            public bool MarketingCommsI { get; set; }
            public bool HelpOthersCheckbox { get; set; }
            public bool FeatureUpdatesCheckbox { get; set; }
            public bool ArticlesPostsCheckbox { get; set; }
            public bool ProductNewsCheckbox { get; set; }
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var _user = await _userManager.GetUserAsync(User);

            ListOfCountries = _context.CountryList.Select(a => new SelectListItem { Value = a.Country.ToString(), Text = a.Country.ToString() }).ToList();
            ListOfSkills = _context.SkillsList.Select(a => new SelectListItem { Value = a.Skill.ToString(), Text = a.Skill.ToString() }).ToList();
            AreasOfInterest = _context.InterestsList.Select(a => new SelectListItem { Value = a.Interest.ToString(), Text = a.Interest.ToString() }).ToList();

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
            FirstNameHeading = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceFirstnameNameReferenceForRegisterConfPage();
            SurNameHeading = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceSurnameNameReferenceForRegisterConfPage();
            CompanyNameHeading = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceCompanynameNameReferenceForRegisterConfPage();
            SkillHeading = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceSkillNameReferenceForRegisterConfPage();
            AreaOfInterestHeading = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceAreaofInterestNameReferenceForRegisterConfPage();
            AgeHeading = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceAgeNameReferenceForRegisterConfPage();
            CheckEmailHeading1 = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceCheckEmail1NameReferenceForRegisterConfPage();
            CheckEmailHeading2 = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceCheckEmail2NameReferenceForRegisterConfPage();
            CountryHeading = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceCountryNameReferenceForRegisterConfPage();
            RegionHeading = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceRegionNameReferenceForRegisterConfPage();
            SelectCountryFirstPara = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceChooseCountryFirstReferenceForRegisterConfPage();
            Country = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceCountryMatchLabelNameReferenceForRegisterConfPage();
            Region = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceRegionMatchLabelNameReferenceForRegisterConfPage();
            SeparateSkillComma = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceSeparateSkillCommaHeadingNameReferenceForRegisterConfPage();
            SeparateAreaComma = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceSeparateAreaCommaHeadingNameReferenceForRegisterConfPage();
            NewValue = _locSourceInfoPageNameReferenceLibrary.GetLocSourceNewValueNameReferenceForAboutPage();
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

            if (_user.FirstName != null)
            {
                ExistingFirstName = _user.FirstName.ToString();
            }
            else
            {
                ExistingFirstName = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            }
            if (_user.LastName != null)
            {
                ExistingSurName = _user.LastName.ToString();
            }
            else
            {
                ExistingSurName = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            }
            if (_user.Age != 0)
            {
                ExistingAge = _user.Age.ToString();
            }
            else
            {
                ExistingAge = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            }
            if (_user.Country != null)
            {
                ExistingCountry = _user.Country.ToString();
            }
            else
            {
                ExistingCountry = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            }
            if (_user.Region != null)
            {
                ExistingRegion = _user.Region.ToString();
            }
            else
            {
                ExistingRegion = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            }
            if (_user.CompanyName != null)
            {
                ExistingCompanyName = _user.CompanyName.ToString();
            }
            else
            {
                ExistingCompanyName = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            }
            if (_user.Skill != null)
            {
                ExistingSkills = _user.Skill.ToString();
            }
            else
            {
                ExistingSkills = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            }
            if (_user.AreaOfInterest != null)
            {
                ExistingInterests = _user.AreaOfInterest.ToString();
            }
            else
            {
                ExistingInterests = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            }
            if (_user.MarketingComms == true)
            {
                ExistingMarketing = "true";
                NewMarketingComms = "true";
            }
            else if (_user.MarketingComms == false)
            {
                ExistingMarketing = "false";
                NewMarketingComms = "false";
            }
            if (_user.AreasYouCanHelp == true)
            {
                ExistingHelpOthers = "true";
                NewHelpOthers = "true";
            }
            else if (_user.AreasYouCanHelp == false)
            {
                ExistingHelpOthers = "false";
                NewHelpOthers = "false";
            }
            if (_user.FeatureUpdates == true)
            {
                ExistingFeatureUpdates = "true";
                NewFeatureUpdates = "true";
            }
            else if (_user.FeatureUpdates == false)
            {
                ExistingFeatureUpdates = "false";
                NewFeatureUpdates = "false";
            }
            if (_user.NewArticlePosts == true)
            {
                ExistingArticlesPosts = "true";
                NewArticlesPosts = "true";
            }
            else if (_user.NewArticlePosts == false)
            {
                ExistingArticlesPosts = "false";
                NewArticlesPosts = "false";
            }
            if (_user.ProductNews == true)
            {
                ExistingProductNews = "true";
                NewProductNews = "true";
            }
            else if (_user.ProductNews == false)
            {
                ExistingProductNews = "false";
                NewProductNews = "false";
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                var msg = _loc.GetLocalizedString("Unable to load user with ID '{0}'.", _userManager.GetUserId(User));
                return NotFound(msg);
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var _user = await _userManager.GetUserAsync(User);

            if (_user.FirstName != null)
            {
                ExistingFirstName = _user.FirstName.ToString();
            }
            else
            {
                ExistingFirstName = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            }
            if (_user.LastName != null)
            {
                ExistingSurName = _user.LastName.ToString();
            }
            else
            {
                ExistingSurName = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            }
            if (_user.Age != 0)
            {
                ExistingAge = _user.Age.ToString();
            }
            else
            {
                ExistingAge = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            }
            if (_user.Country != null)
            {
                ExistingCountry = _user.Country.ToString();
            }
            else
            {
                ExistingCountry = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            }
            if (_user.Region != null)
            {
                ExistingRegion = _user.Region.ToString();
            }
            else
            {
                ExistingRegion = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            }
            if (_user.CompanyName != null)
            {
                ExistingCompanyName = _user.CompanyName.ToString();
            }
            else
            {
                ExistingCompanyName = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            }
            if (_user.Skill != null)
            {
                ExistingSkills = _user.Skill.ToString();
            }
            else
            {
                ExistingSkills = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            }
            if (_user.AreaOfInterest != null)
            {
                ExistingInterests = _user.AreaOfInterest.ToString();
            }
            else
            {
                ExistingInterests = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString();
            }

            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                if (_user != null)
                {
                    var userId = _user.Id.ToString();

                    //dbContext.Users.SingleOrDefault(n => n.FirstName == Input.FirstName);

                    var appUser = await dbContext.Users.FindAsync(userId);
                    appUser.FirstName = Input.NewFirstName;
                    appUser.LastName = Input.NewSurName;
                    appUser.Age = Input.NewAge;
                    appUser.Country = Input.NewCountry;
                    appUser.Region = Input.NewRegion;
                    appUser.CompanyName = Input.NewCompanyName;
                    appUser.Skill = Input.NewSkill;
                    appUser.AreaOfInterest = Input.NewAreaOfInterest;
                    appUser.MarketingComms = Input.MarketingCommsI;
                    appUser.AreasYouCanHelp = Input.HelpOthersCheckbox;
                    appUser.FeatureUpdates = Input.FeatureUpdatesCheckbox;
                    appUser.NewArticlePosts = Input.ArticlesPostsCheckbox;
                    appUser.ProductNews = Input.ProductNewsCheckbox;

                    await dbContext.SaveChangesAsync();
                }

                return RedirectToPage("Info", new { culture });
            }
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
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Info Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Info Page Newsfeed Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Info Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Info Page Newsfeed Modal", FeedbackDateTime);
                }
            }

            return RedirectToPage("Info", new { culture });
        }
        
    }
}
