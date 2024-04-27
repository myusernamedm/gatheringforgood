using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using GatheringForGood.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LocSourceNameReferenceLibrary;
using GatheringForGood.Areas.FunctionalLogic;
using System;
using LazZiya.ExpressLocalization.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using ImageUrlReferenceLibrary;
using System.Diagnostics;

namespace GatheringForGood.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterConfirmationModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly string culture;
        readonly RegisterConfPageLocSourceNames _locSourceRegisterConfPageNameReferenceLibrary = new RegisterConfPageLocSourceNames();
        readonly SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
        SharedCrossPageImageUrls _imageUrlReferenceLibrary = new SharedCrossPageImageUrls();
        private static readonly ApplicationDbContext _context = new();
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        private readonly IEmailSender _emailSender;
        private readonly IMemoryCache _cache;
        readonly SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();

        public RegisterConfirmationModel(UserManager<ApplicationUser> userManager, IEmailSender emailSender, IMemoryCache cache)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            culture = System.Globalization.CultureInfo.CurrentCulture.Name;
            _cache = cache;
        }

        [BindProperty]
        public InputModel Input { get; set; }
        public string Email { get; set; }
        public bool DisplayConfirmAccountLink { get; set; }
        public string EmailConfirmationUrl { get; set; }
        public string ReturnUrl { get; set; }
        public string PageTabTitle { get; set; }
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
        public string Submit { get; set; }
        public string Skip { get; set; }
        public string ComingSoon { get; set; }
        public string LikeToSee { get; set; }
        public string CheckEmailHeading1 { get; set; }
        public string CheckEmailHeading2 { get; set; }
        public string FirstNameHeading { get; set; }
        public string SurNameHeading { get; set; }
        public string CompanyNameHeading { get; set; }
        public string SkillHeading { get; set; }
        public string AreaOfInterestHeading { get; set; }
        public string AgeHeading { get; set; }
        public string CountryHeading { get; set; }
        public string RegionHeading { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string SeparateSkillComma { get; set; }
        public string SeparateAreaComma { get; set; }
        public string Updates { get; set; }
        public string HomepageShare { get; set; }
        public string IconTwitter { get; set; }
        public string IconLinkedin { get; set; }
        public string IconFacebook { get; set; }
        public string SkipInfo { get; set; }
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

            [ExStringLength(100, MinimumLength = 3)]
            [DataType(DataType.Text)]
            [Display(Name = "FirstName")]
            public string FirstName { get; set; }

            [ExStringLength(100, MinimumLength = 3)]
            [DataType(DataType.Text)]
            [Display(Name = "SurName")]
            public string SurName { get; set; }

            [ExStringLength(200, MinimumLength = 3)]
            [DataType(DataType.Text)]
            [Display(Name = "CompanyName")]
            public string CompanyName { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "Skill")]
            public string Skill { get; set; }

            [ExStringLength(100, MinimumLength = 3)]
            [DataType(DataType.Text)]
            [Display(Name = "AreaOfInterest")]
            public string AreaOfInterest { get; set; }

            [Range(0, 120)]
            [RegularExpression(@"([0-9]+)", ErrorMessage = "Must be a Number.")]
            [Display(Name = "Age")]
            public int Age { get; set; }

            [ExStringLength(100, MinimumLength = 1)]
            [DataType(DataType.Text)]
            [Display(Name = "Country")]
            public string Country { get; set; }

            [ExStringLength(100, MinimumLength = 1)]
            [DataType(DataType.Text)]
            [Display(Name = "Region")]
            public string Region { get; set; }

        }

        public async Task<IActionResult> OnGetAsync(string email)
        {

            ListOfCountries = _context.CountryList.Select(a => new SelectListItem { Value = a.Country.ToString(), Text = a.Country.ToString() }).ToList();
            ListOfSkills = _context.SkillsList.Select(a => new SelectListItem { Value = a.Skill.ToString(), Text = a.Skill.ToString() }).ToList();
            AreasOfInterest = _context.InterestsList.Select(a => new SelectListItem { Value = a.Interest.ToString(), Text = a.Interest.ToString() }).ToList();

            PageTabTitle = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForRegisterConfPage();
            Title = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForRegisterConfPage();
            SubTitle = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForRegisterConfPage();
            Heading = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceHeadingNameReferenceForRegisterConfPage();
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
            Skip = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceSkipNameReferenceForRegisterConfPage();
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
            Country = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceCountryMatchLabelNameReferenceForRegisterConfPage();
            Region = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceRegionMatchLabelNameReferenceForRegisterConfPage();
            SeparateSkillComma = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceSeparateSkillCommaHeadingNameReferenceForRegisterConfPage();
            SeparateAreaComma = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceSeparateAreaCommaHeadingNameReferenceForRegisterConfPage();
            Updates = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceUpdatesNameReferenceForPage();
            HomepageShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20are%20taking%20action%20to%20help%20save%20the%20world!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com";
            IconTwitter = _imageUrlReferenceLibrary.GetTwitterIconUrlForPage();
            IconLinkedin = _imageUrlReferenceLibrary.GetLinkedinIconUrlForPage();
            IconFacebook = _imageUrlReferenceLibrary.GetFacebookIconUrlForPage();
            SkipInfo = _locSourceRegisterConfPageNameReferenceLibrary.GetLocSourceSkipInfoNameReferenceForRegisterConfPage();
            ReturnUrl = "NewUserRegistration";
            GetEarthHandsReducedImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReducedImageUrlForPage();
            GetEarthHandsReduced400ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced400ImageUrlForPage();
            GetEarthHandsReduced800ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced800ImageUrlForPage();
            GetEarthHandsReduced1200ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced1200ImageUrlForPage();
            GetEarthHandsReduced1600ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced1600ImageUrlForPage();

            if (email == null)
            {
                Debug.WriteLine("************ email == null: ");
                return RedirectToPage("/Index");
            }

            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                Debug.WriteLine("************ NotFound ");
                return NotFound($"Unable to load user with email '{email}'.");
            }

            Email = email;
            //Once you add a real email sender, you should remove this code that lets you confirm the account
            /*DisplayConfirmAccountLink = false;
            if (DisplayConfirmAccountLink)
            {
                var userId = await _userManager.GetUserIdAsync(user);
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                EmailConfirmationUrl = Url.Page(
                    "/Account/ConfirmEmail",
                    pageHandler: null,
                    values: new { area = "Identity", userId, code },
                    protocol: Request.Scheme);
            }
            */
            Debug.WriteLine("************ return Page() ");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {

                ApplicationUser user = (ApplicationUser)_cache.Get("User");
                if(user != null)
                {
                    Debug.WriteLine("************ user != null ");

                    var userId = user.Id.ToString();
                    var appUser = await dbContext.Users.FindAsync(userId);
                    appUser.FirstName = Input.FirstName;
                    appUser.LastName = Input.SurName;
                    appUser.Age = Input.Age;
                    appUser.Country = Input.Country;
                    appUser.Region = Input.Region;
                    appUser.CompanyName = Input.CompanyName;
                    appUser.Skill = Input.Skill;
                    appUser.AreaOfInterest = Input.AreaOfInterest;

                    await dbContext.SaveChangesAsync();
                }

            }

            ReturnUrl = "NewUserRegistration";
            Debug.WriteLine("************ RedirectToPage: " + ReturnUrl);
            return RedirectToAction(actionName: "Index", controllerName: "Home", new { culture, ReturnUrl });
        }

        public IActionResult OnPostRegisterConfirmationSkip()
        {

                ReturnUrl = "NewUserRegistration";
                Debug.WriteLine("************ RedirectToPage: " + ReturnUrl);
                return RedirectToAction(actionName: "Index", controllerName: "Home", new { culture, ReturnUrl });
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
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Register Confirmation Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Register Confirmation Page Newsfeed Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Register Confirmation Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Register Confirmation Page Newsfeed Modal", FeedbackDateTime);
                }
            }

            return RedirectToPage("RegisterConfirmation", new { culture });
        }

    }
}
