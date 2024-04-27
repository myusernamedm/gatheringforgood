using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using GatheringForGood.Models;
using LocSourceNameReferenceLibrary;
using ImageUrlReferenceLibrary;
using GatheringForGood.Areas.FunctionalLogic;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Authorization;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using LazZiya.ExpressLocalization;
using Microsoft.Extensions.Caching.Memory;
using GatheringForGood.Areas.Identity.Data;
using GatheringForGood.Data;

namespace GatheringForGood.Controllers
{
    [AllowAnonymous]
    public class ArticlesController : Controller
    {
        private static readonly ApplicationDbContext _context = new();
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        private readonly IEmailSender _emailSender;
        private readonly string culture;
        private IncrementUserReaction _IncrementUserReaction = new();
        private readonly ISharedCultureLocalizer _loc;
        private readonly IMemoryCache _memoryCache;

        public ArticlesController(IEmailSender emailSender, ISharedCultureLocalizer loc, IMemoryCache memoryCache)
        {
            _emailSender = emailSender;
            culture = System.Globalization.CultureInfo.CurrentCulture.Name;
            _loc = loc;
            _memoryCache = memoryCache;
        }

        public async Task<IActionResult> ArticlesAsync(string returnUrl = null)
        {
            Debug.WriteLine("************ Articles returnUrl 1: " + returnUrl);
            ArticlesPageLocSourceNames _locSourceArticlesPageNameReferenceLibrary = new ArticlesPageLocSourceNames();
            SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
            SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();
            ArticlesPageImageUrls _ArticlesPageImageUrls = new();
            UserArticlePageImageUrls _UserArticlePageImageUrls = new();
            UserArticlePageLocSourceNames _UserArticlePageLocSourceNames = new();
            TreePurchaseOptionsPartialImageUrls _TreePurchaseOptionsPartialImageUrls = new();

            List<SelectListItem> searchList = new();
            if(returnUrl == null)
            {
                searchList.Clear();
            };
            searchList.Add(new SelectListItem(_locSourceArticlesPageNameReferenceLibrary.GetLocSourceSearchByTitleNameReferenceForArticlesPage(), _locSourceArticlesPageNameReferenceLibrary.GetLocSourceSearchByTitleNameReferenceForArticlesPage()));
            searchList.Add(new SelectListItem(_locSourceArticlesPageNameReferenceLibrary.GetLocSourceSearchByAuthorFNNameReferenceForArticlesPage(), _locSourceArticlesPageNameReferenceLibrary.GetLocSourceSearchByAuthorFNNameReferenceForArticlesPage()));
            searchList.Add(new SelectListItem(_locSourceArticlesPageNameReferenceLibrary.GetLocSourceSearchByAuthorLNNameReferenceForArticlesPage(), _locSourceArticlesPageNameReferenceLibrary.GetLocSourceSearchByAuthorLNNameReferenceForArticlesPage()));

            var viewModel = new ArticlesViewModel
            {
                ListOfSearchOptions = searchList.ToList(),
                LikeIconUrl = _UserArticlePageImageUrls.GetlikeiconThumbnailUrlForAboutPage(),
                DislikeIconUrl = _UserArticlePageImageUrls.GetdislikeiconThumbnailUrlForAboutPage(),
                ShockedIconUrl = _UserArticlePageImageUrls.GetshockediconThumbnailUrlForAboutPage(),
                SupportIconUrl = _UserArticlePageImageUrls.GetsupporticonThumbnailUrlForAboutPage(),
                QuestionableIconUrl = _UserArticlePageImageUrls.GetquestionableiconThumbnailUrlForAboutPage(),
                PageTabTitle = _locSourceArticlesPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForArticlesPage(),
                ButtonText = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceButtonTextNameReference(),
                Title = _locSourceArticlesPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForArticlesPage(),
                Subtitle = _locSourceArticlesPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForArticlesPage(),
                NavBarHome = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceHomeLabelNameReference(),
                NavBarNewsfeed = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNewsfeedLabelNameReference(),
                NavBarAbout = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceAboutLabelNameReference(),
                NavBarHelpCenter = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceHelpCenterLabelNameReference(),
                NavBarRegister = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceRegisterLabelNameReference(),
                NavBarLogin = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLoginLabelNameReference(),
                NavBarLogout = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLogoutLabelNameReference(),
                AboutUs = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceAboutUsLabelNameReference(),
                Articles = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceArticlesLabelNameReference(),
                CookiesNotice = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceCookiesNoticeLabelNameReference(),
                PrivacyNotice = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourcePrivacyNoticeLabelNameReference(),
                ComingSoon = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceComingSoonLabelNameReference(),
                LikeToSee = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLikeToSeeLabelNameReference(),
                Submit = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceSubmitLabelNameReference(),
                ArticlespageShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2Fen%2FArticles%2FArticles&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20are%20taking%20action%20to%20help%20save%20the%20world!%20Check%20out%20the%20latest%20user%20articles%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com%2FArticles%2FArticles",
                HomepageShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20are%20taking%20action%20to%20help%20save%20the%20world!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                IconTwitter = _SharedCrossPageImageUrlLibrary.GetTwitterIconUrlForPage(),
                IconLinkedin = _SharedCrossPageImageUrlLibrary.GetLinkedinIconUrlForPage(),
                IconFacebook = _SharedCrossPageImageUrlLibrary.GetFacebookIconUrlForPage(),
                Updates = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceUpdatesNameReferenceForPage(),
                Author = _locSourceArticlesPageNameReferenceLibrary.GetLocSourceNewsfeedCardAuthorNameReferenceForArticlesPage(),
                CreateArticleButton = _locSourceArticlesPageNameReferenceLibrary.GetLocSourceCreateArticleButtonNameReferenceForArticlesPage(),
                FeaturedArticleUrl = _ArticlesPageImageUrls.GetFeaturedNoPaddingArticleImageThumbnailUrlForArticlesPage(),
                TreePlantedUrl = _TreePurchaseOptionsPartialImageUrls.Get1TreeIconImageThumbnailUrlForAboutPage(),
                Views = _locSourceArticlesPageNameReferenceLibrary.GetLocSourceViewsNameReferenceForArticlesPage(),
                SearchButtonText = _locSourceArticlesPageNameReferenceLibrary.GetLocSourceSearchButtonTextNameReferenceForArticlesPage(),
                SearchArticlesHeading = _locSourceArticlesPageNameReferenceLibrary.GetLocSourceSearchArticlesHeadingNameReferenceForArticlesPage(),
                SearchUsing = _locSourceArticlesPageNameReferenceLibrary.GetLocSourceSearchUsingNameReferenceForArticlesPage(),
                LikeTooltip = _UserArticlePageLocSourceNames.GetLocSourceLikeTooltipNameReferenceForArticlesPage(),
                DislikeTooltip = _UserArticlePageLocSourceNames.GetLocSourceDislikeTooltipNameReferenceForArticlesPage(),
                SupportTooltip = _UserArticlePageLocSourceNames.GetLocSourceSupportTooltipNameReferenceForArticlesPage(),
                QuestionableTooltip = _UserArticlePageLocSourceNames.GetLocSourceQuestionableTooltipNameReferenceForArticlesPage(),
                ShockedTooltip = _UserArticlePageLocSourceNames.GetLocSourceShockedTooltipNameReferenceForArticlesPage(),
                FeaturedTitle = _locSourceArticlesPageNameReferenceLibrary.GetLocSourceFeaturedNameTitleReferenceForArticlesPage(),
                FeaturedText = _locSourceArticlesPageNameReferenceLibrary.GetLocSourceFeaturedInfoNameReferenceForArticlesPage(),
                TreePurchaseTitle = _locSourceArticlesPageNameReferenceLibrary.GetLocSourceTreePurchasedTitleNameReferenceForArticlesPage(),
                TreePurchaseText = _locSourceArticlesPageNameReferenceLibrary.GetLocSourceTreePurchasedInfoNameReferenceForArticlesPage(),
                GetEarthHandsReducedImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReducedImageUrlForPage(),
                GetEarthHandsReduced400ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced400ImageUrlForPage(),
                GetEarthHandsReduced800ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced800ImageUrlForPage(),
                GetEarthHandsReduced1200ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced1200ImageUrlForPage(),
                GetEarthHandsReduced1600ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced1600ImageUrlForPage(),
                StatusMessage = null
            };

            var url = (HttpContext.Request.Path).ToString();
            string data = url.Substring(url.LastIndexOf("/") + 1);

            if (data == "TreesPlantedSuccess" || data == "TreesPlantedFailure")
            {
                switch (data)
                {
                    case "TreesPlantedSuccess":
                        ViewData["Error"] = "success";
                        viewModel.StatusMessage = _loc.GetLocalizedString(_locSourceArticlesPageNameReferenceLibrary.GetLocSourcePaymentSuccessNameReferenceForArticlesPage());
                        break;
                    case "TreesPlantedFailure":
                        ViewData["Error"] = "danger";
                        viewModel.StatusMessage = _loc.GetLocalizedString(_locSourceArticlesPageNameReferenceLibrary.GetLocSourcePaymentFailureNameReferenceForArticlesPage());
                        var uniqueArticleRef = _memoryCache.Get<string>("changeTreePlanted");
                        Debug.WriteLine("********** cache changeTreePlanted 1: " + uniqueArticleRef);

                        if(uniqueArticleRef != null)
                        {
                            var articleDetails = await getArticleDetailsByURef(uniqueArticleRef); //await _context.ArticleDetails.Where(a => a.UniqueReference == uniqueArticleRef).First();
                            articleDetails.TreePlanted = false;
                            var articleList = await getArticleListByURef(uniqueArticleRef);
                            articleList.TreePlanted = false;
                            await _context.SaveChangesAsync();
                            _memoryCache.Remove("changeTreePlanted");
                        }

                        break;
                }
            }

            if (returnUrl != null && returnUrl != "nosearch")
            {
                string[] splitValue = returnUrl.Split('-');

                if(returnUrl == "TreesPlantedFailure")
                {
                    ViewData["Error"] = "danger";
                    viewModel.StatusMessage = _loc.GetLocalizedString(_locSourceArticlesPageNameReferenceLibrary.GetLocSourcePaymentFailureNameReferenceForArticlesPage());
                    viewModel.MainArticleList = await GetArticlesCardDetails.GetCardDetailsAsync(_context, 0, 0, null);
                    var uniqueArticleRef = _memoryCache.Get<string>("changeTreePlanted");
                    Debug.WriteLine("********** cache changeTreePlanted 2: " + uniqueArticleRef);

                    if (uniqueArticleRef != null)
                    {
                        var articleDetails = await getArticleDetailsByURef(uniqueArticleRef);
                        articleDetails.TreePlanted = false;
                        var articleList = await getArticleListByURef(uniqueArticleRef);
                        articleList.TreePlanted = false;
                        await _context.SaveChangesAsync();
                        _memoryCache.Remove("changeTreePlanted");
                    }

                    return View(viewModel);
                } 
                else
                {
                    switch (splitValue[1])
                    {
                        case "Title":
                            viewModel.MainArticleList = await GetArticlesCardDetails.GetCardDetailsAsync(_context, 1, 0, splitValue[2]);
                            return View(viewModel);
                        case "First":
                            viewModel.MainArticleList = await GetArticlesCardDetails.GetCardDetailsAsync(_context, 2, 0, splitValue[2]);
                            return View(viewModel);
                        case "Last":
                            viewModel.MainArticleList = await GetArticlesCardDetails.GetCardDetailsAsync(_context, 3, 0, splitValue[2]);
                            return View(viewModel);
                    }
                }
            } 
            else
            {
                viewModel.MainArticleList = await GetArticlesCardDetails.GetCardDetailsAsync(_context, 0, 0, null);
                return View(viewModel);
            }

            viewModel.MainArticleList = await GetArticlesCardDetails.GetCardDetailsAsync(_context, 0, 0, null);
            return View(viewModel);
        }

        public async Task<ArticleDetails> getArticleDetailsByURef(string uniqueArticleRef)
        {
            var articleDetails = _context.ArticleDetails.Where(a => a.UniqueReference == uniqueArticleRef).First();
            return articleDetails;
        }

        public async Task<ArticlesList> getArticleListByURef(string uniqueArticleRef)
        {
            var articleList = _context.ArticlesList.Where(a => a.UniqueReference == uniqueArticleRef).First();
            return articleList;
        }

        public IActionResult OnGetSetCultureCookie(string cltr, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(cltr)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
                );

            return LocalRedirect(returnUrl);
        }
        [HttpPost]
        public IActionResult SearchArticles(ArticlesViewModel model)
        {
            var SearchUsing = model.SearchOption;
            var SearchText = model.SearchText;
            var ReturnUrl = "nosearch";

            switch (SearchUsing)
            {
                case "Article Title":
                    ReturnUrl = "Search-Title-" + SearchText;
                    return RedirectToAction(actionName: "Articles", controllerName: "Articles", new { culture, ReturnUrl });

                case "Author First Name":
                    ReturnUrl = "Search-First-" + SearchText;
                    return RedirectToAction(actionName: "Articles", controllerName: "Articles", new { culture, ReturnUrl });

                case "Author Last Name":
                    ReturnUrl = "Search-Last-" + SearchText;
                    return RedirectToAction(actionName: "Articles", controllerName: "Articles", new { culture, ReturnUrl });

                default:
                    return RedirectToAction(actionName: "Articles", controllerName: "Articles", new { culture, ReturnUrl });
            }
        }

        [HttpPost]
        public async Task<List<int>> UserReactionAsync(int actionNumber, string uniqueRefNumber)
        {
            Debug.WriteLine("***********UserReaction: " + actionNumber + " | " + uniqueRefNumber);

            await _IncrementUserReaction.incrementReaction(actionNumber, uniqueRefNumber);

            ArticleDetails ArticleDetailsList = GetUserArticleDetails.retrieveArticleDataFromDB(uniqueRefNumber);

            List<int> likeValues = new();
            likeValues.Clear();
            likeValues.Add(ArticleDetailsList.Likes);
            likeValues.Add(ArticleDetailsList.Dislikes);
            likeValues.Add(ArticleDetailsList.Support);
            likeValues.Add(ArticleDetailsList.Questionable);
            likeValues.Add(ArticleDetailsList.Shocked);

            Debug.WriteLine("***********likeValues: " + likeValues[0] + " | " + likeValues[1] + " | " + likeValues[2] + " | " + likeValues[3] + " | " + likeValues[4]);

            return likeValues;

            //var formedUrl = "../UserArticle/UserArticle/"
            //return RedirectToAction("Articles");
        }

        [HttpPost]
        public async Task<IActionResult> SaveUserEntryAsync(string newsfeedUserEntry)
        {
            DateTime FeedbackDateTime = DateTime.UtcNow;

            if (newsfeedUserEntry != null)
            {
                string userId = ClaimsPrincipalExtensions.GetUserId<string>(User);
                if (userId != null)
                {
                    bool loggedInUser = true;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Articles Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Articles Page Newsfeed Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Articles Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Articles Page Newsfeed Modal", FeedbackDateTime);
                }
            }

            return RedirectToAction("Articles");
        }
    }
}

