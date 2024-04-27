using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using GatheringForGood.Models;
using LocSourceNameReferenceLibrary;
using ImageUrlReferenceLibrary;
using GatheringForGood.Areas.FunctionalLogic;
using GatheringForGood.Data;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.IO;
using Stripe;
using Stripe.Checkout;
using System.Diagnostics;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using URLStringsReferenceLibrary;

namespace GatheringForGood.Controllers
{

    public class CreateArticleController : Controller
    {
        private ApplicationDbContext _context = new();
        readonly GenerateUniqueReferenceValue _GenerateUniqueReferenceValue = new();
        readonly SaveArticleDetails SaveArticleDetails = new();
        private CheckFeaturedArticleCode CheckFeaturedArticleCode = new();
        private readonly string culture;
        private BlobUpload _uploadBlobs = new();
        private readonly IEmailSender _emailSender;
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        CheckImageTypeAndSize _CheckImageTypeAndSize = new();
        private readonly IMemoryCache _memoryCache;
        readonly IWebHostEnvironment _env;
        UrlStrings _urlStrings = new();
        public AuthStripeOptions Options { get; }

        public CreateArticleController(IEmailSender emailSender, IOptions<AuthStripeOptions> optionsAccessor, IMemoryCache memoryCache, IWebHostEnvironment env)
        {
            _emailSender = emailSender;
            Options = optionsAccessor.Value;
            StripeConfiguration.ApiKey = Options.StripeApiKey.ToString();
            _memoryCache = memoryCache;
            _env = env;
        }

        public IActionResult CreateArticle()
        {
            CreateArticlePageLocSourceNames _locSourceCreateArticlePageNameReferenceLibrary = new CreateArticlePageLocSourceNames();
            TreePurchasePartialOptionsLocSourceNames _locSourceTreePurchasePartialOptionsNameReferenceLibrary = new TreePurchasePartialOptionsLocSourceNames();
            SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
            SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();
            CreateArticleImageUrls _CreateArticleImageUrls = new();
            TreePurchaseOptionsPartialImageUrls _TreePurchaseOptionsPartialImageUrls = new();
            DateTime todaysDate = DateTime.UtcNow;
            ArticlesPageLocSourceNames _locSourceArticlesPageNameReferenceLibrary = new();
            ArticlesPageImageUrls _ArticlesPageImageUrls = new();

            var viewModel = new CreateArticleViewModel
            {
                PageTabTitle = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForCreateArticlePage(),
                Title = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceTitleNameReferenceForCreateArticlePage(),
                Subtitle = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForCreateArticlePage(),
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
                BackButton = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceGoBackNameReferenceForPage(),
                ArticleTitleLabel = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticleTitleNameReferenceForCreateArticlePage(),
                TitleImageLabel = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticleTitleImageLabelNameReferenceForCreateArticlePage(),
                TitleVideoLabel = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticleTitleVideoLabelNameReferenceForCreateArticlePage(),
                ArticleSnippetLabel = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticleSnippetNameReferenceForCreateArticlePage(),
                Para1Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara1NameReferenceForCreateArticlePage(),
                Para2Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara2NameReferenceForCreateArticlePage(),
                Para3Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara3NameReferenceForCreateArticlePage(),
                Para4Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara4NameReferenceForCreateArticlePage(),
                Para5Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara5NameReferenceForCreateArticlePage(),
                Para6Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara6NameReferenceForCreateArticlePage(),
                Para7Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara7NameReferenceForCreateArticlePage(),
                Para8Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara8NameReferenceForCreateArticlePage(),
                Para9Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara9NameReferenceForCreateArticlePage(),
                Para10Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara10NameReferenceForCreateArticlePage(),
                Para11Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara11NameReferenceForCreateArticlePage(),
                Para12Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara12NameReferenceForCreateArticlePage(),
                Para13Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara13NameReferenceForCreateArticlePage(),
                Para14Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara14NameReferenceForCreateArticlePage(),
                Para15Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara15NameReferenceForCreateArticlePage(),
                Para16Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara16NameReferenceForCreateArticlePage(),
                Para17Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara17NameReferenceForCreateArticlePage(),
                Para18Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara18NameReferenceForCreateArticlePage(),
                Para19Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara19NameReferenceForCreateArticlePage(),
                Para20Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara20NameReferenceForCreateArticlePage(),
                Para21Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara21NameReferenceForCreateArticlePage(),
                Para22Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara22NameReferenceForCreateArticlePage(),
                Para23Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara23NameReferenceForCreateArticlePage(),
                Para24Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara24NameReferenceForCreateArticlePage(),
                Para25Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara25NameReferenceForCreateArticlePage(),
                Para26Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara26NameReferenceForCreateArticlePage(),
                Para27Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara27NameReferenceForCreateArticlePage(),
                Para28Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara28NameReferenceForCreateArticlePage(),
                Para29Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara29NameReferenceForCreateArticlePage(),
                Para30Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara30NameReferenceForCreateArticlePage(),
                Para31Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara31NameReferenceForCreateArticlePage(),
                Para32Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara32NameReferenceForCreateArticlePage(),
                Para33Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara33NameReferenceForCreateArticlePage(),
                Para34Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara34NameReferenceForCreateArticlePage(),
                Para35Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara35NameReferenceForCreateArticlePage(),
                Para36Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara36NameReferenceForCreateArticlePage(),
                Para37Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara37NameReferenceForCreateArticlePage(),
                Para38Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara38NameReferenceForCreateArticlePage(),
                Para39Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara39NameReferenceForCreateArticlePage(),
                Para40Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara40NameReferenceForCreateArticlePage(),
                Para41Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara41NameReferenceForCreateArticlePage(),
                Para42Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara42NameReferenceForCreateArticlePage(),
                Para43Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara43NameReferenceForCreateArticlePage(),
                Para44Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara44NameReferenceForCreateArticlePage(),
                Para45Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara45NameReferenceForCreateArticlePage(),
                Para46Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara46NameReferenceForCreateArticlePage(),
                Para47Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara47NameReferenceForCreateArticlePage(),
                Para48Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara48NameReferenceForCreateArticlePage(),
                Para49Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara49NameReferenceForCreateArticlePage(),
                Para50Label = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticlePara50NameReferenceForCreateArticlePage(),
                ImageCaptionLabel = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceImageCaptionNameReferenceForArticlesPage(),
                TandCHeading = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceTandCHeadingNameReferenceForPage(),
                Updates = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceUpdatesNameReferenceForPage(),
                HomepageShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20are%20taking%20action%20to%20help%20save%20the%20world!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                IconTwitter = _SharedCrossPageImageUrlLibrary.GetTwitterIconUrlForPage(),
                IconLinkedin = _SharedCrossPageImageUrlLibrary.GetLinkedinIconUrlForPage(),
                IconFacebook = _SharedCrossPageImageUrlLibrary.GetFacebookIconUrlForPage(),
                CardTitleImage = _CreateArticleImageUrls.GetCardTitleImageUrlReferenceForCreateArticlePage(),
                CardImage = _CreateArticleImageUrls.GetCardImageUrlReferenceForCreateArticlePage(),
                PostedDateTime = todaysDate,
                Author = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticleAuthorNameReferenceForCreateArticlePage(),
                AddName = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticleAddNameReferenceForCreateArticlePage(),
                YourArticleCard = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticleYourCardNameReferenceForCreateArticlePage(),
                AddParaButton = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticleAddParagraphNameReferenceForCreateArticlePage(),
                AddImageButton = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticleAddImageNameReferenceForCreateArticlePage(),
                AddTitleImageButton = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticleAddTitleImageNameReferenceForCreateArticlePage(),
                Add1stParaButton = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticleAddFirstParagraphNameReferenceForCreateArticlePage(),
                Add1stImageButton = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticleAddFirstImageNameReferenceForCreateArticlePage(),
                DeleteButton = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticleDeleteParagraphNameReferenceForCreateArticlePage(),
                RecommendedDimensionsLabel = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceRecommendedDimensionsLabelNameReferenceForCreateArticlePage(),
                MaxFileSizeLabel = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceMaxFileSizeLabelNameReferenceForCreateArticlePage(),
                FileTypesLabel = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceFileTypesLabelNameReferenceForCreateArticlePage(),
                ImageSizeError = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceMaxFileSizeLabelNameReferenceForCreateArticlePage(),
                ImageTypeError = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceFileTypesLabelNameReferenceForCreateArticlePage(),
                VideoLinkError = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceYoutubeUrlLabelNameReferenceForCreateArticlePage(),
                ParaVideoLabel = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceArticleParaVideoUrlNameReferenceForCreateArticlePage(),
                FeaturedHeading = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceFeaturedArticleHeadingNameReferenceForCreateArticlePage(),
                FeaturedInfo = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceFeaturedArticleInfoNameReferenceForCreateArticlePage(),
                SubheadingLabel = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceSubheadingNameReferenceForCreateArticlePage(),
                FirstNameHeading = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceFNNameReferenceForArticlesPage(),
                LastNameHeading = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceLNNameReferenceForArticlesPage(),
                ToolTipInfo = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceTooltipInfoNameReferenceForArticlesPage(),
                PlantATreeTitle = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceTreePurchaseTitleNameReferenceForArticlesPage(),
                PlantATreePara1 = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceTreePurchasePara1NameReferenceForArticlesPage(),
                PlantATreePara2 = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceTreePurchasePara2NameReferenceForArticlesPage(),
                PlantATreeClickHere = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceTreePurchaseClickHereNameReferenceForArticlesPage(),
                Plant1Tree = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant1TreeNameReferenceForArticlesPage(),
                Plant1TreePM = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant1TreePerMonthNameReferenceForArticlesPage(),
                Plant2Tree = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant2TreeNameReferenceForArticlesPage(),
                Plant2TreePM = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant2TreePerMonthNameReferenceForArticlesPage(),
                Plant5Tree = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant5TreeNameReferenceForArticlesPage(),
                Plant5TreePM = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant5TreePerMonthNameReferenceForArticlesPage(),
                Plant10Tree = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant10TreeNameReferenceForArticlesPage(),
                Plant10TreePM = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant10TreePerMonthNameReferenceForArticlesPage(),
                Plant20Tree = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant20TreeNameReferenceForArticlesPage(),
                Plant20TreePM = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant20TreePerMonthNameReferenceForArticlesPage(),
                PlantATreeCheckedImageUrl = _CreateArticleImageUrls.GetCheckedImageUrlReferenceForCreateArticlePage(),
                PlantATreeUncheckedImageUrl = _CreateArticleImageUrls.GetUncheckedImageUrlReferenceForCreateArticlePage(),
                Plant1TreePrice = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant1TreePriceNameReferenceForArticlesPage(),
                Plant1TreePMPrice = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant1TreeRecurringPriceNameReferenceForArticlesPage(),
                Plant2TreePrice = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant2TreePriceNameReferenceForArticlesPage(),
                Plant2TreePMPrice = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant2TreeRecurringPriceNameReferenceForArticlesPage(),
                Plant5TreePrice = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant5TreePriceNameReferenceForArticlesPage(),
                Plant5TreePMPrice = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant5TreeRecurringPriceNameReferenceForArticlesPage(),
                Plant10TreePrice = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant10TreePriceNameReferenceForArticlesPage(),
                Plant10TreePMPrice = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant10TreeRecurringPriceNameReferenceForArticlesPage(),
                Plant20TreePrice = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant20TreePriceNameReferenceForArticlesPage(),
                Plant20TreePMPrice = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant20TreeRecurringPriceNameReferenceForArticlesPage(),
                OneTreeIconImageUrl = _TreePurchaseOptionsPartialImageUrls.Get1TreeIconImageThumbnailUrlForAboutPage(),
                TwoTreeIconImageUrl = _TreePurchaseOptionsPartialImageUrls.Get2TreeIconImageThumbnailUrlForAboutPage(),
                ThreeTreeIconImageUrl = _TreePurchaseOptionsPartialImageUrls.Get3TreeIconImageThumbnailUrlForAboutPage(),
                FiveTreeIconImageUrl = _TreePurchaseOptionsPartialImageUrls.Get5TreeIconImageThumbnailUrlForAboutPage(),
                TreePurchaseTandCs1 = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePurchaseInAccordanceWithNameReferenceForArticlesPage(),
                TreePurchaseTandCs2 = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourceOurTandCsNameReferenceForArticlesPage(),
                FeaturedTitle = _locSourceArticlesPageNameReferenceLibrary.GetLocSourceFeaturedNameTitleReferenceForArticlesPage(),
                FeaturedText = _locSourceArticlesPageNameReferenceLibrary.GetLocSourceFeaturedInfoNameReferenceForArticlesPage(),
                TreePurchaseTitle = _locSourceArticlesPageNameReferenceLibrary.GetLocSourceTreePurchasedTitleNameReferenceForArticlesPage(),
                TreePurchaseText = _locSourceArticlesPageNameReferenceLibrary.GetLocSourceTreePurchasedInfoNameReferenceForArticlesPage(),
                FeaturedArticleUrl = _ArticlesPageImageUrls.GetFeaturedNoPaddingArticleImageThumbnailUrlForArticlesPage(),
                TreePlantedUrl = _TreePurchaseOptionsPartialImageUrls.Get1TreeIconImageThumbnailUrlForAboutPage(),
                TreePlantedTooltipTitle = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlantTreeTooltipTitleNameReferenceForArticlesPage(),
                Plant1TreeTooltipText = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant1TreeTooltipTextNameReferenceForArticlesPage(),
                Plant2TreeTooltipText = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant2TreeTooltipTextNameReferenceForArticlesPage(),
                Plant5TreeTooltipText = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant5TreeTooltipTextNameReferenceForArticlesPage(),
                Plant10TreeTooltipText = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant10TreeTooltipTextNameReferenceForArticlesPage(),
                Plant20TreeTooltipText = _locSourceTreePurchasePartialOptionsNameReferenceLibrary.GetLocSourcePlant20TreeTooltipTextNameReferenceForArticlesPage(),
                GetEarthHandsReducedImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReducedImageUrlForPage(),
                GetEarthHandsReduced400ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced400ImageUrlForPage(),
                GetEarthHandsReduced800ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced800ImageUrlForPage(),
                GetEarthHandsReduced1200ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced1200ImageUrlForPage(),
                GetEarthHandsReduced1600ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced1600ImageUrlForPage(),
                PreviewButton = _locSourceCreateArticlePageNameReferenceLibrary.GetLocSourceImagePreviewButtonNameReferenceForArticlesPage()
            };

            var user = User.GetUserId<string>();
            var userDetails = _context.Users.Find(user);
            if (userDetails.FirstName != null && userDetails.LastName == null)
            {
                viewModel.UserFullName = userDetails.FirstName.ToString();
                viewModel.FirstName = userDetails.FirstName.ToString();
            }
            else if (userDetails.LastName != null && userDetails.FirstName == null)
            {
                viewModel.UserFullName = userDetails.LastName.ToString();
                viewModel.LastName = userDetails.LastName.ToString();
            }
            else if (userDetails.LastName != null && userDetails.FirstName != null)
            {
                viewModel.UserFullName = userDetails.FirstName.ToString() + " " + userDetails.LastName.ToString();
                viewModel.FirstName = userDetails.FirstName.ToString();
                viewModel.LastName = userDetails.LastName.ToString();
            }
            else
            {
                viewModel.UserFullName = null;
                viewModel.FirstName = null;
                viewModel.LastName = null;
            }
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> SaveUserArticleAsync(CreateArticleViewModel model)
        {
            Debug.WriteLine("************** SaveUserArticleAsync");

            var uRef = _GenerateUniqueReferenceValue.GetGUIDValue().ToString();

            var cacheEntryOptions = new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromMinutes(15));
            _memoryCache.Set("changeTreePlanted", uRef, cacheEntryOptions);

            if (ModelState.IsValid)
            {
                Debug.WriteLine("************** ModelState.IsValid");
                DateTime PostedDateTime = DateTime.UtcNow;
                var ShowArticle = true;
                var UserIDValue = ClaimsPrincipalExtensions.GetUserId<string>(User);
                var TitleField = model.ArticleTitle;
                var FeaturedCodeField = model.FeaturedCode;
                var AuthorFirstName = model.FirstName;
                var AuthorLastName = model.LastName;
                var TitleImageUrl = model.TitleImageUrl;
                var ImageTitleCaption = model.ImageTitleCaption;
                var TitleVideoUrl = model.TitleVideoUrl;
                var SnippetField = model.Snippet;
                var Para1Field = model.Para1Text;
                var Para2Field = model.Para2Text;
                var Para3Field = model.Para3Text;
                var Para4Field = model.Para4Text;
                var Para5Field = model.Para5Text;
                var Para6Field = model.Para6Text;
                var Para7Field = model.Para7Text;
                var Para8Field = model.Para8Text;
                var Para9Field = model.Para9Text;
                var Para10Field = model.Para10Text;
                var Para11Field = model.Para11Text;
                var Para12Field = model.Para12Text;
                var Para13Field = model.Para13Text;
                var Para14Field = model.Para14Text;
                var Para15Field = model.Para15Text;
                var Para16Field = model.Para16Text;
                var Para17Field = model.Para17Text;
                var Para18Field = model.Para18Text;
                var Para19Field = model.Para19Text;
                var Para20Field = model.Para20Text;
                var Para21Field = model.Para21Text;
                var Para22Field = model.Para22Text;
                var Para23Field = model.Para23Text;
                var Para24Field = model.Para24Text;
                var Para25Field = model.Para25Text;
                var Para26Field = model.Para26Text;
                var Para27Field = model.Para27Text;
                var Para28Field = model.Para28Text;
                var Para29Field = model.Para29Text;
                var Para30Field = model.Para30Text;
                var Para31Field = model.Para31Text;
                var Para32Field = model.Para32Text;
                var Para33Field = model.Para33Text;
                var Para34Field = model.Para34Text;
                var Para35Field = model.Para35Text;
                var Para36Field = model.Para36Text;
                var Para37Field = model.Para37Text;
                var Para38Field = model.Para38Text;
                var Para39Field = model.Para39Text;
                var Para40Field = model.Para40Text;
                var Para41Field = model.Para41Text;
                var Para42Field = model.Para42Text;
                var Para43Field = model.Para43Text;
                var Para44Field = model.Para44Text;
                var Para45Field = model.Para45Text;
                var Para46Field = model.Para46Text;
                var Para47Field = model.Para47Text;
                var Para48Field = model.Para48Text;
                var Para49Field = model.Para49Text;
                var Para50Field = model.Para50Text;
                var Para2SubheadingField = model.Para2Subheading;
                var Para3SubheadingField = model.Para3Subheading;
                var Para4SubheadingField = model.Para4Subheading;
                var Para5SubheadingField = model.Para5Subheading;
                var Para6SubheadingField = model.Para6Subheading;
                var Para7SubheadingField = model.Para7Subheading;
                var Para8SubheadingField = model.Para8Subheading;
                var Para9SubheadingField = model.Para9Subheading;
                var Para10SubheadingField = model.Para10Subheading;
                var Para11SubheadingField = model.Para11Subheading;
                var Para12SubheadingField = model.Para12Subheading;
                var Para13SubheadingField = model.Para13Subheading;
                var Para14SubheadingField = model.Para14Subheading;
                var Para15SubheadingField = model.Para15Subheading;
                var Para16SubheadingField = model.Para16Subheading;
                var Para17SubheadingField = model.Para17Subheading;
                var Para18SubheadingField = model.Para18Subheading;
                var Para19SubheadingField = model.Para19Subheading;
                var Para20SubheadingField = model.Para20Subheading;
                var Para21SubheadingField = model.Para21Subheading;
                var Para22SubheadingField = model.Para22Subheading;
                var Para23SubheadingField = model.Para23Subheading;
                var Para24SubheadingField = model.Para24Subheading;
                var Para25SubheadingField = model.Para25Subheading;
                var Para26SubheadingField = model.Para26Subheading;
                var Para27SubheadingField = model.Para27Subheading;
                var Para28SubheadingField = model.Para28Subheading;
                var Para29SubheadingField = model.Para29Subheading;
                var Para30SubheadingField = model.Para30Subheading;
                var Para31SubheadingField = model.Para31Subheading;
                var Para32SubheadingField = model.Para32Subheading;
                var Para33SubheadingField = model.Para33Subheading;
                var Para34SubheadingField = model.Para34Subheading;
                var Para35SubheadingField = model.Para35Subheading;
                var Para36SubheadingField = model.Para36Subheading;
                var Para37SubheadingField = model.Para37Subheading;
                var Para38SubheadingField = model.Para38Subheading;
                var Para39SubheadingField = model.Para39Subheading;
                var Para40SubheadingField = model.Para40Subheading;
                var Para41SubheadingField = model.Para41Subheading;
                var Para42SubheadingField = model.Para42Subheading;
                var Para43SubheadingField = model.Para43Subheading;
                var Para44SubheadingField = model.Para44Subheading;
                var Para45SubheadingField = model.Para45Subheading;
                var Para46SubheadingField = model.Para46Subheading;
                var Para47SubheadingField = model.Para47Subheading;
                var Para48SubheadingField = model.Para48Subheading;
                var Para49SubheadingField = model.Para49Subheading;
                var Para50SubheadingField = model.Para50Subheading;
                var Image2CaptionField = model.Image2Caption;
                var Image3CaptionField = model.Image3Caption;
                var Image4CaptionField = model.Image4Caption;
                var Image5CaptionField = model.Image5Caption;
                var Image6CaptionField = model.Image6Caption;
                var Image7CaptionField = model.Image7Caption;
                var Image8CaptionField = model.Image8Caption;
                var Image9CaptionField = model.Image9Caption;
                var Image10CaptionField = model.Image10Caption;
                var Image11CaptionField = model.Image11Caption;
                var Image12CaptionField = model.Image12Caption;
                var Image13CaptionField = model.Image13Caption;
                var Image14CaptionField = model.Image14Caption;
                var Image15CaptionField = model.Image15Caption;
                var Image16CaptionField = model.Image16Caption;
                var Image17CaptionField = model.Image17Caption;
                var Image18CaptionField = model.Image18Caption;
                var Image19CaptionField = model.Image19Caption;
                var Image20CaptionField = model.Image20Caption;
                var Image21CaptionField = model.Image21Caption;
                var Image22CaptionField = model.Image22Caption;
                var Image23CaptionField = model.Image23Caption;
                var Image24CaptionField = model.Image24Caption;
                var Image25CaptionField = model.Image25Caption;
                var Image26CaptionField = model.Image26Caption;
                var Image27CaptionField = model.Image27Caption;
                var Image28CaptionField = model.Image28Caption;
                var Image29CaptionField = model.Image29Caption;
                var Image30CaptionField = model.Image30Caption;
                var Image31CaptionField = model.Image31Caption;
                var Image32CaptionField = model.Image32Caption;
                var Image33CaptionField = model.Image33Caption;
                var Image34CaptionField = model.Image34Caption;
                var Image35CaptionField = model.Image35Caption;
                var Image36CaptionField = model.Image36Caption;
                var Image37CaptionField = model.Image37Caption;
                var Image38CaptionField = model.Image38Caption;
                var Image39CaptionField = model.Image39Caption;
                var Image40CaptionField = model.Image40Caption;
                var Image41CaptionField = model.Image41Caption;
                var Image42CaptionField = model.Image42Caption;
                var Image43CaptionField = model.Image43Caption;
                var Image44CaptionField = model.Image44Caption;
                var Image45CaptionField = model.Image45Caption;
                var Image46CaptionField = model.Image46Caption;
                var Image47CaptionField = model.Image47Caption;
                var Image48CaptionField = model.Image48Caption;
                var Image49CaptionField = model.Image49Caption;
                var Image50CaptionField = model.Image50Caption;
                var Image1Url = model.Image1Url;
                var Image2Url = model.Image2Url;
                var Image3Url = model.Image3Url;
                var Image4Url = model.Image4Url;
                var Image5Url = model.Image5Url;
                var Image6Url = model.Image6Url;
                var Image7Url = model.Image7Url;
                var Image8Url = model.Image8Url;
                var Image9Url = model.Image9Url;
                var Image10Url = model.Image10Url;
                var Image11Url = model.Image11Url;
                var Image12Url = model.Image12Url;
                var Image13Url = model.Image13Url;
                var Image14Url = model.Image14Url;
                var Image15Url = model.Image15Url;
                var Image16Url = model.Image16Url;
                var Image17Url = model.Image17Url;
                var Image18Url = model.Image18Url;
                var Image19Url = model.Image19Url;
                var Image20Url = model.Image20Url;
                var Image21Url = model.Image21Url;
                var Image22Url = model.Image22Url;
                var Image23Url = model.Image23Url;
                var Image24Url = model.Image24Url;
                var Image25Url = model.Image25Url;
                var Image26Url = model.Image26Url;
                var Image27Url = model.Image27Url;
                var Image28Url = model.Image28Url;
                var Image29Url = model.Image29Url;
                var Image30Url = model.Image30Url;
                var Image31Url = model.Image31Url;
                var Image32Url = model.Image32Url;
                var Image33Url = model.Image33Url;
                var Image34Url = model.Image34Url;
                var Image35Url = model.Image35Url;
                var Image36Url = model.Image36Url;
                var Image37Url = model.Image37Url;
                var Image38Url = model.Image38Url;
                var Image39Url = model.Image39Url;
                var Image40Url = model.Image40Url;
                var Image41Url = model.Image41Url;
                var Image42Url = model.Image42Url;
                var Image43Url = model.Image43Url;
                var Image44Url = model.Image44Url;
                var Image45Url = model.Image45Url;
                var Image46Url = model.Image46Url;
                var Image47Url = model.Image47Url;
                var Image48Url = model.Image48Url;
                var Image49Url = model.Image49Url;
                var Image50Url = model.Image50Url;
                var Video1Url = model.Video1Url;
                var Video2Url = model.Video2Url;
                var Video3Url = model.Video3Url;
                var Video4Url = model.Video4Url;
                var Video5Url = model.Video5Url;
                var Video6Url = model.Video6Url;
                var Video7Url = model.Video7Url;
                var Video8Url = model.Video8Url;
                var Video9Url = model.Video9Url;
                var Video10Url = model.Video10Url;
                var Video11Url = model.Video11Url;
                var Video12Url = model.Video12Url;
                var Video13Url = model.Video13Url;
                var Video14Url = model.Video14Url;
                var Video15Url = model.Video15Url;
                var Video16Url = model.Video16Url;
                var Video17Url = model.Video17Url;
                var Video18Url = model.Video18Url;
                var Video19Url = model.Video19Url;
                var Video20Url = model.Video20Url;
                var Video21Url = model.Video21Url;
                var Video22Url = model.Video22Url;
                var Video23Url = model.Video23Url;
                var Video24Url = model.Video24Url;
                var Video25Url = model.Video25Url;
                var Video26Url = model.Video26Url;
                var Video27Url = model.Video27Url;
                var Video28Url = model.Video28Url;
                var Video29Url = model.Video29Url;
                var Video30Url = model.Video30Url;
                var Video31Url = model.Video31Url;
                var Video32Url = model.Video32Url;
                var Video33Url = model.Video33Url;
                var Video34Url = model.Video34Url;
                var Video35Url = model.Video35Url;
                var Video36Url = model.Video36Url;
                var Video37Url = model.Video37Url;
                var Video38Url = model.Video38Url;
                var Video39Url = model.Video39Url;
                var Video40Url = model.Video40Url;
                var Video41Url = model.Video41Url;
                var Video42Url = model.Video42Url;
                var Video43Url = model.Video43Url;
                var Video44Url = model.Video44Url;
                var Video45Url = model.Video45Url;
                var Video46Url = model.Video46Url;
                var Video47Url = model.Video47Url;
                var Video48Url = model.Video48Url;
                var Video49Url = model.Video49Url;
                var Video50Url = model.Video50Url;
                var TandC = model.TandC;
                var TreePurchaseStatus = model.TreePurchaseStatus;
                var TreePurchaseType = model.PurchaseType;
                var uniqueReferenceValue = uRef;
                bool extensionsOk = true;
                bool fileSizeOk = true;
                List<string> ImageExtensions = new();
                List<IFormFile> ImageListForSizeCheck = new();
                ImageExtensions.Clear();
                ImageListForSizeCheck.Clear();

                List<string> paraFields = new List<string>
                {
                    Para1Field,
                    Para2Field,
                    Para3Field,
                    Para4Field,
                    Para5Field,
                    Para6Field,
                    Para7Field,
                    Para8Field,
                    Para9Field,
                    Para10Field,
                    Para11Field,
                    Para12Field,
                    Para13Field,
                    Para14Field,
                    Para15Field,
                    Para16Field,
                    Para17Field,
                    Para18Field,
                    Para19Field,
                    Para20Field,
                    Para21Field,
                    Para22Field,
                    Para23Field,
                    Para24Field,
                    Para25Field,
                    Para26Field,
                    Para27Field,
                    Para28Field,
                    Para29Field,
                    Para30Field,
                    Para31Field,
                    Para32Field,
                    Para33Field,
                    Para34Field,
                    Para35Field,
                    Para36Field,
                    Para37Field,
                    Para38Field,
                    Para39Field,
                    Para40Field,
                    Para41Field,
                    Para42Field,
                    Para43Field,
                    Para44Field,
                    Para45Field,
                    Para46Field,
                    Para47Field,
                    Para48Field,
                    Para49Field,
                    Para50Field
                };

                List<string> paraSubheadingFields = new List<string>
                {
                    Para2SubheadingField,
                    Para3SubheadingField,
                    Para4SubheadingField,
                    Para5SubheadingField,
                    Para6SubheadingField,
                    Para7SubheadingField,
                    Para8SubheadingField,
                    Para9SubheadingField,
                    Para10SubheadingField,
                    Para11SubheadingField,
                    Para12SubheadingField,
                    Para13SubheadingField,
                    Para14SubheadingField,
                    Para15SubheadingField,
                    Para16SubheadingField,
                    Para17SubheadingField,
                    Para18SubheadingField,
                    Para19SubheadingField,
                    Para20SubheadingField,
                    Para21SubheadingField,
                    Para22SubheadingField,
                    Para23SubheadingField,
                    Para24SubheadingField,
                    Para25SubheadingField,
                    Para26SubheadingField,
                    Para27SubheadingField,
                    Para28SubheadingField,
                    Para29SubheadingField,
                    Para30SubheadingField,
                    Para31SubheadingField,
                    Para32SubheadingField,
                    Para33SubheadingField,
                    Para34SubheadingField,
                    Para35SubheadingField,
                    Para36SubheadingField,
                    Para37SubheadingField,
                    Para38SubheadingField,
                    Para39SubheadingField,
                    Para40SubheadingField,
                    Para41SubheadingField,
                    Para42SubheadingField,
                    Para43SubheadingField,
                    Para44SubheadingField,
                    Para45SubheadingField,
                    Para46SubheadingField,
                    Para47SubheadingField,
                    Para48SubheadingField,
                    Para49SubheadingField,
                    Para50SubheadingField
                };

                List<string> captionFields = new List<string>
                {
                    Image2CaptionField,
                    Image3CaptionField,
                    Image4CaptionField,
                    Image5CaptionField,
                    Image6CaptionField,
                    Image7CaptionField,
                    Image8CaptionField,
                    Image9CaptionField,
                    Image10CaptionField,
                    Image11CaptionField,
                    Image12CaptionField,
                    Image13CaptionField,
                    Image14CaptionField,
                    Image15CaptionField,
                    Image16CaptionField,
                    Image17CaptionField,
                    Image18CaptionField,
                    Image19CaptionField,
                    Image20CaptionField,
                    Image21CaptionField,
                    Image22CaptionField,
                    Image23CaptionField,
                    Image24CaptionField,
                    Image25CaptionField,
                    Image26CaptionField,
                    Image27CaptionField,
                    Image28CaptionField,
                    Image29CaptionField,
                    Image30CaptionField,
                    Image31CaptionField,
                    Image32CaptionField,
                    Image33CaptionField,
                    Image34CaptionField,
                    Image35CaptionField,
                    Image36CaptionField,
                    Image37CaptionField,
                    Image38CaptionField,
                    Image39CaptionField,
                    Image40CaptionField,
                    Image41CaptionField,
                    Image42CaptionField,
                    Image43CaptionField,
                    Image44CaptionField,
                    Image45CaptionField,
                    Image46CaptionField,
                    Image47CaptionField,
                    Image48CaptionField,
                    Image49CaptionField,
                    Image50CaptionField
                };

                List<IFormFile> images = new List<IFormFile> {
                            TitleImageUrl,
                            Image2Url,
                            Image3Url,
                            Image4Url,
                            Image5Url,
                            Image6Url,
                            Image7Url,
                            Image8Url,
                            Image9Url,
                            Image10Url,
                            Image11Url,
                            Image12Url,
                            Image13Url,
                            Image14Url,
                            Image15Url,
                            Image16Url,
                            Image17Url,
                            Image18Url,
                            Image19Url,
                            Image20Url,
                            Image21Url,
                            Image22Url,
                            Image23Url,
                            Image24Url,
                            Image25Url,
                            Image26Url,
                            Image27Url,
                            Image28Url,
                            Image29Url,
                            Image30Url,
                            Image31Url,
                            Image32Url,
                            Image33Url,
                            Image34Url,
                            Image35Url,
                            Image36Url,
                            Image37Url,
                            Image38Url,
                            Image39Url,
                            Image40Url,
                            Image41Url,
                            Image42Url,
                            Image43Url,
                            Image44Url,
                            Image45Url,
                            Image46Url,
                            Image47Url,
                            Image48Url,
                            Image49Url,
                            Image50Url };

                List<string> videoUrlFields = new List<string> {
                            TitleVideoUrl,
                            Video2Url,
                            Video3Url,
                            Video4Url,
                            Video5Url,
                            Video6Url,
                            Video7Url,
                            Video8Url,
                            Video9Url,
                            Video10Url,
                            Video11Url,
                            Video12Url,
                            Video13Url,
                            Video14Url,
                            Video15Url,
                            Video16Url,
                            Video17Url,
                            Video18Url,
                            Video19Url,
                            Video20Url,
                            Video21Url,
                            Video22Url,
                            Video23Url,
                            Video24Url,
                            Video25Url,
                            Video26Url,
                            Video27Url,
                            Video28Url,
                            Video29Url,
                            Video30Url,
                            Video31Url,
                            Video32Url,
                            Video33Url,
                            Video34Url,
                            Video35Url,
                            Video36Url,
                            Video37Url,
                            Video38Url,
                            Video39Url,
                            Video40Url,
                            Video41Url,
                            Video42Url,
                            Video43Url,
                            Video44Url,
                            Video45Url,
                            Video46Url,
                            Video47Url,
                            Video48Url,
                            Video49Url,
                            Video50Url
                };

                foreach (var image in images)
                {
                    if (image != null)
                    {
                        var ImageExtension = Path.GetExtension(image.FileName).ToLower();
                        ImageExtensions.Add(ImageExtension);
                        ImageListForSizeCheck.Add(image);
                    }
                }

                extensionsOk = _CheckImageTypeAndSize.checkImageType(ImageExtensions);
                fileSizeOk = _CheckImageTypeAndSize.checkImageSize(ImageListForSizeCheck);

                var ReturnUrlSuccess = "TreesPlantedSuccess";
                var ReturnUrl = "TreesPlantedFailure";

                Debug.WriteLine("************** extensionsOk: " + extensionsOk + " fileSizeOk: " + fileSizeOk);

                if (extensionsOk && fileSizeOk)
                {
                    Debug.WriteLine("************** extensionsOk fileSizeOk");
                    int validCode = await CheckFeaturedArticleCode.checkFeaturedArticleCodeAsync(FeaturedCodeField);

                    try
                    {
                        Debug.WriteLine("************** try block 1");

                        List<string> ImageUrls = await _uploadBlobs.uploadBlobToAzure(UserIDValue, images, uniqueReferenceValue, "Blob");
                        Debug.WriteLine("************** _uploadBlobs Completed");

                        await SaveArticleDetails.saveDetailsAsync(UserIDValue, TitleField, validCode, ImageUrls, SnippetField, paraFields, paraSubheadingFields, videoUrlFields, PostedDateTime, uniqueReferenceValue, TandC, _context, ShowArticle, AuthorFirstName, AuthorLastName, captionFields, ImageTitleCaption, TreePurchaseStatus);
                        Debug.WriteLine("************** SaveArticleDetails Completed");

                        await SendEmailModalEntry.sendEmailAsync(_emailSender, "New Article: " + TitleField, true, "Create Article Controller", PostedDateTime);
                        Debug.WriteLine("************** SendEmailModalEntry Completed");

                        Debug.WriteLine("************** TreePurchaseStatus: " + TreePurchaseStatus);

                        if (TreePurchaseStatus != null)
                        {
                            Debug.WriteLine("************** TreePurchaseStatus != null");
                            try
                            {
                                Debug.WriteLine("************** try block 2");

                                if (TitleField == "Test Article 987654321")
                                {
                                    StripeConfiguration.ApiKey = Options.StripeApiTestKey.ToString();
                                }

                                Debug.WriteLine("TreePurchaseType: " + TreePurchaseType);

                                switch (TreePurchaseType)
                                {
                                    case "1":
                                        var options1 = new SessionCreateOptions
                                        {
                                            AutomaticTax = new SessionAutomaticTaxOptions { Enabled = true },
                                            LineItems = new List<SessionLineItemOptions>
                                            {
                                            new SessionLineItemOptions
                                                {
                                                    Price = "price_1L1XWTKkNqinRPqhUQeMwUtk",
                                                    Quantity = 1,
                                                },
                                            },
                                            Mode = "payment",
                                            SuccessUrl = "https://www.gatheringforgood.com/en/Articles/Articles/" + ReturnUrlSuccess,
                                            CancelUrl = "https://www.gatheringforgood.com/en/Articles/Articles/" + ReturnUrl,
                                        };
                                        var service1 = new SessionService();
                                        Session session1 = service1.Create(options1);

                                        Response.Headers.Add("Location", session1.Url);
                                        return new StatusCodeResult(303);

                                    case "2":
                                        var options2 = new SessionCreateOptions
                                        {
                                            AutomaticTax = new SessionAutomaticTaxOptions { Enabled = true },
                                            LineItems = new List<SessionLineItemOptions>
                                            {
                                              new SessionLineItemOptions
                                              {
                                                PriceData = new SessionLineItemPriceDataOptions
                                                {
                                                    Currency = "eur",
                                                    UnitAmount = 154,
                                                    Product="prod_LiFuRixsDK2ppj",
                                                    Recurring = new SessionLineItemPriceDataRecurringOptions
                                                    {
                                                        Interval = "month",
                                                    },
                                                },
                                                Quantity = 1,
                                              },
                                            },
                                            Mode = "subscription",
                                            SuccessUrl = "https://www.gatheringforgood.com/en/Articles/Articles/" + ReturnUrlSuccess,
                                            CancelUrl = "https://www.gatheringforgood.com/en/Articles/Articles/" + ReturnUrl,
                                        };
                                        var service2 = new SessionService();
                                        Session session2 = service2.Create(options2);

                                        Response.Headers.Add("Location", session2.Url);
                                        return new StatusCodeResult(303);

                                    case "3":
                                        var options3 = new SessionCreateOptions
                                        {
                                            AutomaticTax = new SessionAutomaticTaxOptions { Enabled = true },
                                            LineItems = new List<SessionLineItemOptions>
                                        {
                                          new SessionLineItemOptions
                                          {
                                            Price = "price_1L0pOHKkNqinRPqh9ZNygFbM",
                                            Quantity = 1,
                                          },
                                        },
                                            Mode = "payment",
                                            SuccessUrl = "https://www.gatheringforgood.com/en/Articles/Articles/" + ReturnUrlSuccess,
                                            CancelUrl = "https://www.gatheringforgood.com/en/Articles/Articles/" + ReturnUrl,
                                        };
                                        var service3 = new SessionService();
                                        Session session3 = service3.Create(options3);

                                        Response.Headers.Add("Location", session3.Url);
                                        return new StatusCodeResult(303);

                                    case "4":
                                        var options4 = new SessionCreateOptions
                                        {
                                            AutomaticTax = new SessionAutomaticTaxOptions { Enabled = true },
                                            LineItems = new List<SessionLineItemOptions>
                                            {
                                              new SessionLineItemOptions
                                              {
                                                PriceData = new SessionLineItemPriceDataOptions
                                                {
                                                    Currency = "eur",
                                                    UnitAmount = 308,
                                                    Product="prod_LiFuBbsvhyJpZF",
                                                    Recurring = new SessionLineItemPriceDataRecurringOptions
                                                    {
                                                        Interval = "month",
                                                    },
                                                },
                                                Quantity = 1,
                                              },
                                            },
                                            Mode = "subscription",
                                            SuccessUrl = "https://www.gatheringforgood.com/en/Articles/Articles/" + ReturnUrlSuccess,
                                            CancelUrl = "https://www.gatheringforgood.com/en/Articles/Articles/" + ReturnUrl,
                                        };
                                        var service4 = new SessionService();
                                        Session session4 = service4.Create(options4);

                                        Response.Headers.Add("Location", session4.Url);
                                        return new StatusCodeResult(303);

                                    case "5":
                                        var options5 = new SessionCreateOptions
                                        {
                                            AutomaticTax = new SessionAutomaticTaxOptions { Enabled = true },
                                            LineItems = new List<SessionLineItemOptions>
                                        {
                                          new SessionLineItemOptions
                                          {
                                            Price = "price_1L0pODKkNqinRPqhdlpSMLg6",
                                            Quantity = 1,
                                          },
                                        },
                                            Mode = "payment",
                                            SuccessUrl = "https://www.gatheringforgood.com/en/Articles/Articles/" + ReturnUrlSuccess,
                                            CancelUrl = "https://www.gatheringforgood.com/en/Articles/Articles/" + ReturnUrl,
                                        };
                                        var service5 = new SessionService();
                                        Session session5 = service5.Create(options5);

                                        Response.Headers.Add("Location", session5.Url);
                                        return new StatusCodeResult(303);

                                    case "6":
                                        var options6 = new SessionCreateOptions
                                        {
                                            AutomaticTax = new SessionAutomaticTaxOptions { Enabled = true },
                                            LineItems = new List<SessionLineItemOptions>
                                            {
                                              new SessionLineItemOptions
                                              {
                                                PriceData = new SessionLineItemPriceDataOptions
                                                {
                                                    Currency = "eur",
                                                    UnitAmount = 770,
                                                    Product="prod_LiFufnR6EQuVnn",
                                                    Recurring = new SessionLineItemPriceDataRecurringOptions
                                                    {
                                                        Interval = "month",
                                                    },
                                                },
                                                Quantity = 1,
                                              },
                                            },
                                            Mode = "subscription",
                                            SuccessUrl = "https://www.gatheringforgood.com/en/Articles/Articles/" + ReturnUrlSuccess,
                                            CancelUrl = "https://www.gatheringforgood.com/en/Articles/Articles/" + ReturnUrl,
                                        };
                                        var service6 = new SessionService();
                                        Session session6 = service6.Create(options6);

                                        Response.Headers.Add("Location", session6.Url);
                                        return new StatusCodeResult(303);

                                    case "7":
                                        var options7 = new SessionCreateOptions
                                        {
                                            AutomaticTax = new SessionAutomaticTaxOptions { Enabled = true },
                                            LineItems = new List<SessionLineItemOptions>
                                        {
                                          new SessionLineItemOptions
                                          {
                                            Price = "price_1L0pO8KkNqinRPqhVdAam2Ol",
                                            Quantity = 1,
                                          },
                                        },
                                            Mode = "payment",
                                            SuccessUrl = "https://www.gatheringforgood.com/en/Articles/Articles/" + ReturnUrlSuccess,
                                            CancelUrl = "https://www.gatheringforgood.com/en/Articles/Articles/" + ReturnUrl,
                                        };
                                        var service7 = new SessionService();
                                        Session session7 = service7.Create(options7);

                                        Response.Headers.Add("Location", session7.Url);
                                        return new StatusCodeResult(303);

                                    case "8":
                                        var options8 = new SessionCreateOptions
                                        {
                                            AutomaticTax = new SessionAutomaticTaxOptions { Enabled = true },
                                            LineItems = new List<SessionLineItemOptions>
                                            {
                                              new SessionLineItemOptions
                                              {
                                                PriceData = new SessionLineItemPriceDataOptions
                                                {
                                                    Currency = "eur",
                                                    UnitAmount = 1340,
                                                    Product="prod_LiFt3tWQSsnx94",
                                                    Recurring = new SessionLineItemPriceDataRecurringOptions
                                                    {
                                                        Interval = "month",
                                                    },
                                                },
                                                Quantity = 1,
                                              },
                                            },
                                            Mode = "subscription",
                                            SuccessUrl = "https://www.gatheringforgood.com/en/Articles/Articles/" + ReturnUrlSuccess,
                                            CancelUrl = "https://www.gatheringforgood.com/en/Articles/Articles/" + ReturnUrl,
                                        };
                                        var service8 = new SessionService();
                                        Session session8 = service8.Create(options8);

                                        Response.Headers.Add("Location", session8.Url);
                                        return new StatusCodeResult(303);

                                    case "9":
                                        var options9 = new SessionCreateOptions
                                        {
                                            AutomaticTax = new SessionAutomaticTaxOptions { Enabled = true },
                                            LineItems = new List<SessionLineItemOptions>
                                        {
                                          new SessionLineItemOptions
                                          {
                                            Price = "price_1L0pO0KkNqinRPqhaDFNVR2P",
                                            Quantity = 1,
                                          },
                                        },
                                            Mode = "payment",
                                            SuccessUrl = "https://www.gatheringforgood.com/en/Articles/Articles/" + ReturnUrlSuccess,
                                            CancelUrl = "https://www.gatheringforgood.com/en/Articles/Articles/" + ReturnUrl,
                                        };
                                        var service9 = new SessionService();
                                        Session session9 = service9.Create(options9);

                                        Response.Headers.Add("Location", session9.Url);
                                        return new StatusCodeResult(303);

                                    case "10":
                                        var options10 = new SessionCreateOptions
                                        {
                                            AutomaticTax = new SessionAutomaticTaxOptions { Enabled = true },
                                            LineItems = new List<SessionLineItemOptions>
                                            {
                                              new SessionLineItemOptions
                                              {
                                                PriceData = new SessionLineItemPriceDataOptions
                                                {
                                                    Currency = "eur",
                                                    UnitAmount = 2380,
                                                    Product="prod_LiFttz7sroOD28",
                                                    Recurring = new SessionLineItemPriceDataRecurringOptions
                                                    {
                                                        Interval = "month",
                                                    },
                                                },
                                                Quantity = 1,
                                              },
                                            },
                                            Mode = "subscription",
                                            SuccessUrl = "https://www.gatheringforgood.com/en/Articles/Articles/" + ReturnUrlSuccess,
                                            CancelUrl = "https://www.gatheringforgood.com/en/Articles/Articles/" + ReturnUrl,
                                        };
                                        var service10 = new SessionService();
                                        Session session10 = service10.Create(options10);

                                        Response.Headers.Add("Location", session10.Url);
                                        return new StatusCodeResult(303);
                                }
                            }
                            catch (Exception e)
                            {
                                Debug.WriteLine("************** TreePurchaseType Catch");

                                Debug.WriteLine("************ Catch: " + ReturnUrl);
                                Debug.WriteLine("************ Exception: " + e.ToString());
                                var url = (HttpContext.Request.Path).ToString();
                                string data = url.Substring(url.LastIndexOf("/") + 1);

                                if (data == "TreesPlantedFailure")
                                {
                                    ViewData["Error"] = "danger";
                                }

                                return RedirectToAction(actionName: "Articles", controllerName: "Articles", new { culture, ReturnUrl });
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("************** Catch to Home");
                        return RedirectToAction(actionName: "Index", controllerName: "Home", new { culture });
                    }
                }
                else
                {
                    Debug.WriteLine("************** Redirect to CreateArticle");

                    return RedirectToAction(actionName: "CreateArticle", controllerName: "CreateArticle", new { culture });
                }
            }
            Debug.WriteLine("************** ModelState Is Not Valid");
            return RedirectToAction(actionName: "Articles", controllerName: "Articles", new { culture });
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

        public IActionResult Error()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PreviewArticleAsync(CreateArticleViewModel model)
        {

            var previewArticleCacheOptions = new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromMinutes(2));
            string routeData = "Preview";
            DateTime PostedDateTime = DateTime.UtcNow;
            _memoryCache.Set<string>("PostedDateTime", PostedDateTime.ToString(), previewArticleCacheOptions);
            var UserIDValue = ClaimsPrincipalExtensions.GetUserId<string>(User);
            _memoryCache.Set<string>("UserIDValue", UserIDValue, previewArticleCacheOptions);
            var TitleField = model.ArticleTitle;
            _memoryCache.Set<string>("TitleField", TitleField, previewArticleCacheOptions);
            var FeaturedCodeField = model.FeaturedCode;
            var AuthorFirstName = model.FirstName;
            _memoryCache.Set<string>("AuthorFirstName", AuthorFirstName, previewArticleCacheOptions);
            var AuthorLastName = model.LastName;
            _memoryCache.Set<string>("AuthorLastName", AuthorLastName, previewArticleCacheOptions);
            string fileNameForUpload = await uploadTempImage(model.TitleImageUrl);
            _memoryCache.Set<string>("TitleImageUrl", fileNameForUpload, previewArticleCacheOptions);
            var ImageTitleCaption = model.ImageTitleCaption;
            _memoryCache.Set<string>("ImageTitleCaption", ImageTitleCaption, previewArticleCacheOptions);
            var TitleVideoUrl = model.TitleVideoUrl;
            _memoryCache.Set<string>("TitleVideoUrl", TitleVideoUrl, previewArticleCacheOptions);
            var SnippetField = model.Snippet;
            _memoryCache.Set<string>("SnippetField", SnippetField, previewArticleCacheOptions);
            var Para1Field = model.Para1Text;
            _memoryCache.Set<string>("Para1Field", Para1Field, previewArticleCacheOptions);
            var Para2Field = model.Para2Text;
            _memoryCache.Set<string>("Para2Field", Para2Field, previewArticleCacheOptions);
            var Para3Field = model.Para3Text;
            _memoryCache.Set<string>("Para3Field", Para3Field, previewArticleCacheOptions);
            var Para4Field = model.Para4Text;
            _memoryCache.Set<string>("Para4Field", Para4Field, previewArticleCacheOptions);
            var Para5Field = model.Para5Text;
            _memoryCache.Set<string>("Para5Field", Para5Field, previewArticleCacheOptions);
            var Para6Field = model.Para6Text;
            _memoryCache.Set<string>("Para6Field", Para6Field, previewArticleCacheOptions);
            var Para7Field = model.Para7Text;
            _memoryCache.Set<string>("Para7Field", Para7Field, previewArticleCacheOptions);
            var Para8Field = model.Para8Text;
            _memoryCache.Set<string>("Para8Field", Para8Field, previewArticleCacheOptions);
            var Para9Field = model.Para9Text;
            _memoryCache.Set<string>("Para9Field", Para9Field, previewArticleCacheOptions);
            var Para10Field = model.Para10Text;
            _memoryCache.Set<string>("Para10Field", Para10Field, previewArticleCacheOptions);
            var Para11Field = model.Para11Text;
            _memoryCache.Set<string>("Para11Field", Para11Field, previewArticleCacheOptions);
            var Para12Field = model.Para12Text;
            _memoryCache.Set<string>("Para12Field", Para12Field, previewArticleCacheOptions);
            var Para13Field = model.Para13Text;
            _memoryCache.Set<string>("Para13Field", Para13Field, previewArticleCacheOptions);
            var Para14Field = model.Para14Text;
            _memoryCache.Set<string>("Para14Field", Para14Field, previewArticleCacheOptions);
            var Para15Field = model.Para15Text;
            _memoryCache.Set<string>("Para15Field", Para15Field, previewArticleCacheOptions);
            var Para16Field = model.Para16Text;
            _memoryCache.Set<string>("Para16Field", Para16Field, previewArticleCacheOptions);
            var Para17Field = model.Para17Text;
            _memoryCache.Set<string>("Para17Field", Para17Field, previewArticleCacheOptions);
            var Para18Field = model.Para18Text;
            _memoryCache.Set<string>("Para18Field", Para18Field, previewArticleCacheOptions);
            var Para19Field = model.Para19Text;
            _memoryCache.Set<string>("Para19Field", Para19Field, previewArticleCacheOptions);
            var Para20Field = model.Para20Text;
            _memoryCache.Set<string>("Para20Field", Para20Field, previewArticleCacheOptions);
            var Para21Field = model.Para21Text;
            _memoryCache.Set<string>("Para21Field", Para21Field, previewArticleCacheOptions);
            var Para22Field = model.Para22Text;
            _memoryCache.Set<string>("Para22Field", Para22Field, previewArticleCacheOptions);
            var Para23Field = model.Para23Text;
            _memoryCache.Set<string>("Para23Field", Para23Field, previewArticleCacheOptions);
            var Para24Field = model.Para24Text;
            _memoryCache.Set<string>("Para24Field", Para24Field, previewArticleCacheOptions);
            var Para25Field = model.Para25Text;
            _memoryCache.Set<string>("Para25Field", Para25Field, previewArticleCacheOptions);
            var Para26Field = model.Para26Text;
            _memoryCache.Set<string>("Para26Field", Para26Field, previewArticleCacheOptions);
            var Para27Field = model.Para27Text;
            _memoryCache.Set<string>("Para27Field", Para27Field, previewArticleCacheOptions);
            var Para28Field = model.Para28Text;
            _memoryCache.Set<string>("Para28Field", Para28Field, previewArticleCacheOptions);
            var Para29Field = model.Para29Text;
            _memoryCache.Set<string>("Para29Field", Para29Field, previewArticleCacheOptions);
            var Para30Field = model.Para30Text;
            _memoryCache.Set<string>("Para30Field", Para30Field, previewArticleCacheOptions);
            var Para31Field = model.Para31Text;
            _memoryCache.Set<string>("Para31Field", Para31Field, previewArticleCacheOptions);
            var Para32Field = model.Para32Text;
            _memoryCache.Set<string>("Para32Field", Para32Field, previewArticleCacheOptions);
            var Para33Field = model.Para33Text;
            _memoryCache.Set<string>("Para33Field", Para33Field, previewArticleCacheOptions);
            var Para34Field = model.Para34Text;
            _memoryCache.Set<string>("Para34Field", Para34Field, previewArticleCacheOptions);
            var Para35Field = model.Para35Text;
            _memoryCache.Set<string>("Para35Field", Para35Field, previewArticleCacheOptions);
            var Para36Field = model.Para36Text;
            _memoryCache.Set<string>("Para36Field", Para36Field, previewArticleCacheOptions);
            var Para37Field = model.Para37Text;
            _memoryCache.Set<string>("Para37Field", Para37Field, previewArticleCacheOptions);
            var Para38Field = model.Para38Text;
            _memoryCache.Set<string>("Para38Field", Para38Field, previewArticleCacheOptions);
            var Para39Field = model.Para39Text;
            _memoryCache.Set<string>("Para39Field", Para39Field, previewArticleCacheOptions);
            var Para40Field = model.Para40Text;
            _memoryCache.Set<string>("Para40Field", Para40Field, previewArticleCacheOptions);
            var Para41Field = model.Para41Text;
            _memoryCache.Set<string>("Para41Field", Para41Field, previewArticleCacheOptions);
            var Para42Field = model.Para42Text;
            _memoryCache.Set<string>("Para42Field", Para42Field, previewArticleCacheOptions);
            var Para43Field = model.Para43Text;
            _memoryCache.Set<string>("Para43Field", Para43Field, previewArticleCacheOptions);
            var Para44Field = model.Para44Text;
            _memoryCache.Set<string>("Para44Field", Para44Field, previewArticleCacheOptions);
            var Para45Field = model.Para45Text;
            _memoryCache.Set<string>("Para45Field", Para45Field, previewArticleCacheOptions);
            var Para46Field = model.Para46Text;
            _memoryCache.Set<string>("Para46Field", Para46Field, previewArticleCacheOptions);
            var Para47Field = model.Para47Text;
            _memoryCache.Set<string>("Para47Field", Para47Field, previewArticleCacheOptions);
            var Para48Field = model.Para48Text;
            _memoryCache.Set<string>("Para48Field", Para48Field, previewArticleCacheOptions);
            var Para49Field = model.Para49Text;
            _memoryCache.Set<string>("Para49Field", Para49Field, previewArticleCacheOptions);
            var Para50Field = model.Para50Text;
            _memoryCache.Set<string>("Para50Field", Para50Field, previewArticleCacheOptions);

            var Para2SubheadingField = model.Para2Subheading;
            _memoryCache.Set<string>("Para2SubheadingField", Para2SubheadingField, previewArticleCacheOptions);
            var Para3SubheadingField = model.Para3Subheading;
            _memoryCache.Set<string>("Para3SubheadingField", Para3SubheadingField, previewArticleCacheOptions);
            var Para4SubheadingField = model.Para4Subheading;
            _memoryCache.Set<string>("Para4SubheadingField", Para4SubheadingField, previewArticleCacheOptions);
            var Para5SubheadingField = model.Para5Subheading;
            _memoryCache.Set<string>("Para5SubheadingField", Para5SubheadingField, previewArticleCacheOptions);
            var Para6SubheadingField = model.Para6Subheading;
            _memoryCache.Set<string>("Para6SubheadingField", Para6SubheadingField, previewArticleCacheOptions);
            var Para7SubheadingField = model.Para7Subheading;
            _memoryCache.Set<string>("Para7SubheadingField", Para7SubheadingField, previewArticleCacheOptions);
            var Para8SubheadingField = model.Para8Subheading;
            _memoryCache.Set<string>("Para8SubheadingField", Para8SubheadingField, previewArticleCacheOptions);
            var Para9SubheadingField = model.Para9Subheading;
            _memoryCache.Set<string>("Para9SubheadingField", Para9SubheadingField, previewArticleCacheOptions);
            var Para10SubheadingField = model.Para10Subheading;
            _memoryCache.Set<string>("Para10SubheadingField", Para10SubheadingField, previewArticleCacheOptions);
            var Para11SubheadingField = model.Para11Subheading;
            _memoryCache.Set<string>("Para11SubheadingField", Para11SubheadingField, previewArticleCacheOptions);
            var Para12SubheadingField = model.Para12Subheading;
            _memoryCache.Set<string>("Para12SubheadingField", Para12SubheadingField, previewArticleCacheOptions);
            var Para13SubheadingField = model.Para13Subheading;
            _memoryCache.Set<string>("Para13SubheadingField", Para13SubheadingField, previewArticleCacheOptions);
            var Para14SubheadingField = model.Para14Subheading;
            _memoryCache.Set<string>("Para14SubheadingField", Para14SubheadingField, previewArticleCacheOptions);
            var Para15SubheadingField = model.Para15Subheading;
            _memoryCache.Set<string>("Para15SubheadingField", Para15SubheadingField, previewArticleCacheOptions);
            var Para16SubheadingField = model.Para16Subheading;
            _memoryCache.Set<string>("Para16SubheadingField", Para16SubheadingField, previewArticleCacheOptions);
            var Para17SubheadingField = model.Para17Subheading;
            _memoryCache.Set<string>("Para17SubheadingField", Para17SubheadingField, previewArticleCacheOptions);
            var Para18SubheadingField = model.Para18Subheading;
            _memoryCache.Set<string>("Para18SubheadingField", Para18SubheadingField, previewArticleCacheOptions);
            var Para19SubheadingField = model.Para19Subheading;
            _memoryCache.Set<string>("Para19SubheadingField", Para19SubheadingField, previewArticleCacheOptions);
            var Para20SubheadingField = model.Para20Subheading;
            _memoryCache.Set<string>("Para20SubheadingField", Para20SubheadingField, previewArticleCacheOptions);
            var Para21SubheadingField = model.Para21Subheading;
            _memoryCache.Set<string>("Para21SubheadingField", Para21SubheadingField, previewArticleCacheOptions);
            var Para22SubheadingField = model.Para22Subheading;
            _memoryCache.Set<string>("Para22SubheadingField", Para22SubheadingField, previewArticleCacheOptions);
            var Para23SubheadingField = model.Para23Subheading;
            _memoryCache.Set<string>("Para23SubheadingField", Para23SubheadingField, previewArticleCacheOptions);
            var Para24SubheadingField = model.Para24Subheading;
            _memoryCache.Set<string>("Para24SubheadingField", Para24SubheadingField, previewArticleCacheOptions);
            var Para25SubheadingField = model.Para25Subheading;
            _memoryCache.Set<string>("Para25SubheadingField", Para25SubheadingField, previewArticleCacheOptions);
            var Para26SubheadingField = model.Para26Subheading;
            _memoryCache.Set<string>("Para26SubheadingField", Para26SubheadingField, previewArticleCacheOptions);
            var Para27SubheadingField = model.Para27Subheading;
            _memoryCache.Set<string>("Para27SubheadingField", Para27SubheadingField, previewArticleCacheOptions);
            var Para28SubheadingField = model.Para28Subheading;
            _memoryCache.Set<string>("Para28SubheadingField", Para28SubheadingField, previewArticleCacheOptions);
            var Para29SubheadingField = model.Para29Subheading;
            _memoryCache.Set<string>("Para29SubheadingField", Para29SubheadingField, previewArticleCacheOptions);
            var Para30SubheadingField = model.Para30Subheading;
            _memoryCache.Set<string>("Para30SubheadingField", Para30SubheadingField, previewArticleCacheOptions);
            var Para31SubheadingField = model.Para31Subheading;
            _memoryCache.Set<string>("Para31SubheadingField", Para31SubheadingField, previewArticleCacheOptions);
            var Para32SubheadingField = model.Para32Subheading;
            _memoryCache.Set<string>("Para32SubheadingField", Para32SubheadingField, previewArticleCacheOptions);
            var Para33SubheadingField = model.Para33Subheading;
            _memoryCache.Set<string>("Para33SubheadingField", Para33SubheadingField, previewArticleCacheOptions);
            var Para34SubheadingField = model.Para34Subheading;
            _memoryCache.Set<string>("Para34SubheadingField", Para34SubheadingField, previewArticleCacheOptions);
            var Para35SubheadingField = model.Para35Subheading;
            _memoryCache.Set<string>("Para35SubheadingField", Para35SubheadingField, previewArticleCacheOptions);
            var Para36SubheadingField = model.Para36Subheading;
            _memoryCache.Set<string>("Para36SubheadingField", Para36SubheadingField, previewArticleCacheOptions);
            var Para37SubheadingField = model.Para37Subheading;
            _memoryCache.Set<string>("Para37SubheadingField", Para37SubheadingField, previewArticleCacheOptions);
            var Para38SubheadingField = model.Para38Subheading;
            _memoryCache.Set<string>("Para38SubheadingField", Para38SubheadingField, previewArticleCacheOptions);
            var Para39SubheadingField = model.Para39Subheading;
            _memoryCache.Set<string>("Para39SubheadingField", Para39SubheadingField, previewArticleCacheOptions);
            var Para40SubheadingField = model.Para40Subheading;
            _memoryCache.Set<string>("Para40SubheadingField", Para40SubheadingField, previewArticleCacheOptions);
            var Para41SubheadingField = model.Para41Subheading;
            _memoryCache.Set<string>("Para41SubheadingField", Para41SubheadingField, previewArticleCacheOptions);
            var Para42SubheadingField = model.Para42Subheading;
            _memoryCache.Set<string>("Para42SubheadingField", Para42SubheadingField, previewArticleCacheOptions);
            var Para43SubheadingField = model.Para43Subheading;
            _memoryCache.Set<string>("Para43SubheadingField", Para43SubheadingField, previewArticleCacheOptions);
            var Para44SubheadingField = model.Para44Subheading;
            _memoryCache.Set<string>("Para44SubheadingField", Para44SubheadingField, previewArticleCacheOptions);
            var Para45SubheadingField = model.Para45Subheading;
            _memoryCache.Set<string>("Para45SubheadingField", Para45SubheadingField, previewArticleCacheOptions);
            var Para46SubheadingField = model.Para46Subheading;
            _memoryCache.Set<string>("Para46SubheadingField", Para46SubheadingField, previewArticleCacheOptions);
            var Para47SubheadingField = model.Para47Subheading;
            _memoryCache.Set<string>("Para47SubheadingField", Para47SubheadingField, previewArticleCacheOptions);
            var Para48SubheadingField = model.Para48Subheading;
            _memoryCache.Set<string>("Para48SubheadingField", Para48SubheadingField, previewArticleCacheOptions);
            var Para49SubheadingField = model.Para49Subheading;
            _memoryCache.Set<string>("Para49SubheadingField", Para49SubheadingField, previewArticleCacheOptions);
            var Para50SubheadingField = model.Para50Subheading;
            _memoryCache.Set<string>("Para50SubheadingField", Para50SubheadingField, previewArticleCacheOptions);

            var Image2CaptionField = model.Image2Caption;
            _memoryCache.Set<string>("Image2CaptionField", Image2CaptionField, previewArticleCacheOptions);
            var Image3CaptionField = model.Image3Caption;
            _memoryCache.Set<string>("Image3CaptionField", Image3CaptionField, previewArticleCacheOptions);
            var Image4CaptionField = model.Image4Caption;
            _memoryCache.Set<string>("Image4CaptionField", Image4CaptionField, previewArticleCacheOptions);
            var Image5CaptionField = model.Image5Caption;
            _memoryCache.Set<string>("Image5CaptionField", Image5CaptionField, previewArticleCacheOptions);
            var Image6CaptionField = model.Image6Caption;
            _memoryCache.Set<string>("Image6CaptionField", Image6CaptionField, previewArticleCacheOptions);
            var Image7CaptionField = model.Image7Caption;
            _memoryCache.Set<string>("Image7CaptionField", Image7CaptionField, previewArticleCacheOptions);
            var Image8CaptionField = model.Image8Caption;
            _memoryCache.Set<string>("Image8CaptionField", Image8CaptionField, previewArticleCacheOptions);
            var Image9CaptionField = model.Image9Caption;
            _memoryCache.Set<string>("Image9CaptionField", Image9CaptionField, previewArticleCacheOptions);
            var Image10CaptionField = model.Image10Caption;
            _memoryCache.Set<string>("Image10CaptionField", Image10CaptionField, previewArticleCacheOptions);
            var Image11CaptionField = model.Image11Caption;
            _memoryCache.Set<string>("Image11CaptionField", Image11CaptionField, previewArticleCacheOptions);
            var Image12CaptionField = model.Image12Caption;
            _memoryCache.Set<string>("Image12CaptionField", Image12CaptionField, previewArticleCacheOptions);
            var Image13CaptionField = model.Image13Caption;
            _memoryCache.Set<string>("Image13CaptionField", Image13CaptionField, previewArticleCacheOptions);
            var Image14CaptionField = model.Image14Caption;
            _memoryCache.Set<string>("Image14CaptionField", Image14CaptionField, previewArticleCacheOptions);
            var Image15CaptionField = model.Image15Caption;
            _memoryCache.Set<string>("Image15CaptionField", Image15CaptionField, previewArticleCacheOptions);
            var Image16CaptionField = model.Image16Caption;
            _memoryCache.Set<string>("Image16CaptionField", Image16CaptionField, previewArticleCacheOptions);
            var Image17CaptionField = model.Image17Caption;
            _memoryCache.Set<string>("Image17CaptionField", Image17CaptionField, previewArticleCacheOptions);
            var Image18CaptionField = model.Image18Caption;
            _memoryCache.Set<string>("Image18CaptionField", Image18CaptionField, previewArticleCacheOptions);
            var Image19CaptionField = model.Image19Caption;
            _memoryCache.Set<string>("Image19CaptionField", Image19CaptionField, previewArticleCacheOptions);
            var Image20CaptionField = model.Image20Caption;
            _memoryCache.Set<string>("Image20CaptionField", Image20CaptionField, previewArticleCacheOptions);
            var Image21CaptionField = model.Image21Caption;
            _memoryCache.Set<string>("Image21CaptionField", Image21CaptionField, previewArticleCacheOptions);
            var Image22CaptionField = model.Image22Caption;
            _memoryCache.Set<string>("Image22CaptionField", Image22CaptionField, previewArticleCacheOptions);
            var Image23CaptionField = model.Image23Caption;
            _memoryCache.Set<string>("Image23CaptionField", Image23CaptionField, previewArticleCacheOptions);
            var Image24CaptionField = model.Image24Caption;
            _memoryCache.Set<string>("Image24CaptionField", Image24CaptionField, previewArticleCacheOptions);
            var Image25CaptionField = model.Image25Caption;
            _memoryCache.Set<string>("Image25CaptionField", Image25CaptionField, previewArticleCacheOptions);
            var Image26CaptionField = model.Image26Caption;
            _memoryCache.Set<string>("Image26CaptionField", Image26CaptionField, previewArticleCacheOptions);
            var Image27CaptionField = model.Image27Caption;
            _memoryCache.Set<string>("Image27CaptionField", Image27CaptionField, previewArticleCacheOptions);
            var Image28CaptionField = model.Image28Caption;
            _memoryCache.Set<string>("Image28CaptionField", Image28CaptionField, previewArticleCacheOptions);
            var Image29CaptionField = model.Image29Caption;
            _memoryCache.Set<string>("Image29CaptionField", Image29CaptionField, previewArticleCacheOptions);
            var Image30CaptionField = model.Image30Caption;
            _memoryCache.Set<string>("Image30CaptionField", Image30CaptionField, previewArticleCacheOptions);
            var Image31CaptionField = model.Image31Caption;
            _memoryCache.Set<string>("Image31CaptionField", Image31CaptionField, previewArticleCacheOptions);
            var Image32CaptionField = model.Image32Caption;
            _memoryCache.Set<string>("Image32CaptionField", Image32CaptionField, previewArticleCacheOptions);
            var Image33CaptionField = model.Image33Caption;
            _memoryCache.Set<string>("Image33CaptionField", Image33CaptionField, previewArticleCacheOptions);
            var Image34CaptionField = model.Image34Caption;
            _memoryCache.Set<string>("Image34CaptionField", Image34CaptionField, previewArticleCacheOptions);
            var Image35CaptionField = model.Image35Caption;
            _memoryCache.Set<string>("Image35CaptionField", Image35CaptionField, previewArticleCacheOptions);
            var Image36CaptionField = model.Image36Caption;
            _memoryCache.Set<string>("Image36CaptionField", Image36CaptionField, previewArticleCacheOptions);
            var Image37CaptionField = model.Image37Caption;
            _memoryCache.Set<string>("Image37CaptionField", Image37CaptionField, previewArticleCacheOptions);
            var Image38CaptionField = model.Image38Caption;
            _memoryCache.Set<string>("Image38CaptionField", Image38CaptionField, previewArticleCacheOptions);
            var Image39CaptionField = model.Image39Caption;
            _memoryCache.Set<string>("Image39CaptionField", Image39CaptionField, previewArticleCacheOptions);
            var Image40CaptionField = model.Image40Caption;
            _memoryCache.Set<string>("Image40CaptionField", Image40CaptionField, previewArticleCacheOptions);
            var Image41CaptionField = model.Image41Caption;
            _memoryCache.Set<string>("Image41CaptionField", Image41CaptionField, previewArticleCacheOptions);
            var Image42CaptionField = model.Image42Caption;
            _memoryCache.Set<string>("Image42CaptionField", Image42CaptionField, previewArticleCacheOptions);
            var Image43CaptionField = model.Image43Caption;
            _memoryCache.Set<string>("Image43CaptionField", Image43CaptionField, previewArticleCacheOptions);
            var Image44CaptionField = model.Image44Caption;
            _memoryCache.Set<string>("Image44CaptionField", Image44CaptionField, previewArticleCacheOptions);
            var Image45CaptionField = model.Image45Caption;
            _memoryCache.Set<string>("Image45CaptionField", Image45CaptionField, previewArticleCacheOptions);
            var Image46CaptionField = model.Image46Caption;
            _memoryCache.Set<string>("Image46CaptionField", Image46CaptionField, previewArticleCacheOptions);
            var Image47CaptionField = model.Image47Caption;
            _memoryCache.Set<string>("Image47CaptionField", Image47CaptionField, previewArticleCacheOptions);
            var Image48CaptionField = model.Image48Caption;
            _memoryCache.Set<string>("Image48CaptionField", Image48CaptionField, previewArticleCacheOptions);
            var Image49CaptionField = model.Image49Caption;
            _memoryCache.Set<string>("Image49CaptionField", Image49CaptionField, previewArticleCacheOptions);
            var Image50CaptionField = model.Image50Caption;
            _memoryCache.Set<string>("Image50CaptionField", Image50CaptionField, previewArticleCacheOptions);

            fileNameForUpload = await uploadTempImage(model.Image2Url);
            _memoryCache.Set<string>("Image2Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image3Url);
            _memoryCache.Set<string>("Image3Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image4Url);
            _memoryCache.Set<string>("Image4Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image5Url);
            _memoryCache.Set<string>("Image5Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image6Url);
            _memoryCache.Set<string>("Image6Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image7Url);
            _memoryCache.Set<string>("Image7Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image8Url);
            _memoryCache.Set<string>("Image8Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image9Url);
            _memoryCache.Set<string>("Image9Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image10Url);
            _memoryCache.Set<string>("Image10Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image11Url);
            _memoryCache.Set<string>("Image11Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image12Url);
            _memoryCache.Set<string>("Image12Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image13Url);
            _memoryCache.Set<string>("Image13Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image14Url);
            _memoryCache.Set<string>("Image14Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image15Url);
            _memoryCache.Set<string>("Image15Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image16Url);
            _memoryCache.Set<string>("Image16Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image17Url);
            _memoryCache.Set<string>("Image17Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image18Url);
            _memoryCache.Set<string>("Image18Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image19Url);
            _memoryCache.Set<string>("Image19Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image20Url);
            _memoryCache.Set<string>("Image20Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image21Url);
            _memoryCache.Set<string>("Image21Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image22Url);
            _memoryCache.Set<string>("Image22Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image23Url);
            _memoryCache.Set<string>("Image23Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image24Url);
            _memoryCache.Set<string>("Image24Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image25Url);
            _memoryCache.Set<string>("Image25Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image26Url);
            _memoryCache.Set<string>("Image26Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image27Url);
            _memoryCache.Set<string>("Image27Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image28Url);
            _memoryCache.Set<string>("Image28Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image29Url);
            _memoryCache.Set<string>("Image29Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image30Url);
            _memoryCache.Set<string>("Image30Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image31Url);
            _memoryCache.Set<string>("Image31Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image32Url);
            _memoryCache.Set<string>("Image32Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image33Url);
            _memoryCache.Set<string>("Image33Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image34Url);
            _memoryCache.Set<string>("Image34Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image35Url);
            _memoryCache.Set<string>("Image35Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image36Url);
            _memoryCache.Set<string>("Image36Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image37Url);
            _memoryCache.Set<string>("Image37Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image38Url);
            _memoryCache.Set<string>("Image38Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image39Url);
            _memoryCache.Set<string>("Image39Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image40Url);
            _memoryCache.Set<string>("Image40Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image41Url);
            _memoryCache.Set<string>("Image41Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image42Url);
            _memoryCache.Set<string>("Image42Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image43Url);
            _memoryCache.Set<string>("Image43Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image44Url);
            _memoryCache.Set<string>("Image44Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image45Url);
            _memoryCache.Set<string>("Image45Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image46Url);
            _memoryCache.Set<string>("Image46Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image47Url);
            _memoryCache.Set<string>("Image47Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image48Url);
            _memoryCache.Set<string>("Image48Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image49Url);
            _memoryCache.Set<string>("Image49Url", fileNameForUpload, previewArticleCacheOptions);
            fileNameForUpload = await uploadTempImage(model.Image50Url);
            _memoryCache.Set<string>("Image50Url", fileNameForUpload, previewArticleCacheOptions);

            var Video2Url = model.Video2Url;
            _memoryCache.Set<string>("Video2Url", Video2Url, previewArticleCacheOptions);
            var Video3Url = model.Video3Url;
            _memoryCache.Set<string>("Video3Url", Video3Url, previewArticleCacheOptions);
            var Video4Url = model.Video4Url;
            _memoryCache.Set<string>("Video4Url", Video4Url, previewArticleCacheOptions);
            var Video5Url = model.Video5Url;
            _memoryCache.Set<string>("Video5Url", Video5Url, previewArticleCacheOptions);
            var Video6Url = model.Video6Url;
            _memoryCache.Set<string>("Video6Url", Video6Url, previewArticleCacheOptions);
            var Video7Url = model.Video7Url;
            _memoryCache.Set<string>("Video7Url", Video7Url, previewArticleCacheOptions);
            var Video8Url = model.Video8Url;
            _memoryCache.Set<string>("Video8Url", Video8Url, previewArticleCacheOptions);
            var Video9Url = model.Video9Url;
            _memoryCache.Set<string>("Video9Url", Video9Url, previewArticleCacheOptions);
            var Video10Url = model.Video10Url;
            _memoryCache.Set<string>("Video10Url", Video10Url, previewArticleCacheOptions);
            var Video11Url = model.Video11Url;
            _memoryCache.Set<string>("Video11Url", Video11Url, previewArticleCacheOptions);
            var Video12Url = model.Video12Url;
            _memoryCache.Set<string>("Video12Url", Video12Url, previewArticleCacheOptions);
            var Video13Url = model.Video13Url;
            _memoryCache.Set<string>("Video13Url", Video13Url, previewArticleCacheOptions);
            var Video14Url = model.Video14Url;
            _memoryCache.Set<string>("Video14Url", Video14Url, previewArticleCacheOptions);
            var Video15Url = model.Video15Url;
            _memoryCache.Set<string>("Video15Url", Video15Url, previewArticleCacheOptions);
            var Video16Url = model.Video16Url;
            _memoryCache.Set<string>("Video16Url", Video16Url, previewArticleCacheOptions);
            var Video17Url = model.Video17Url;
            _memoryCache.Set<string>("Video17Url", Video17Url, previewArticleCacheOptions);
            var Video18Url = model.Video18Url;
            _memoryCache.Set<string>("Video18Url", Video18Url, previewArticleCacheOptions);
            var Video19Url = model.Video19Url;
            _memoryCache.Set<string>("Video19Url", Video19Url, previewArticleCacheOptions);
            var Video20Url = model.Video20Url;
            _memoryCache.Set<string>("Video20Url", Video20Url, previewArticleCacheOptions);
            var Video21Url = model.Video21Url;
            _memoryCache.Set<string>("Video21Url", Video21Url, previewArticleCacheOptions);
            var Video22Url = model.Video22Url;
            _memoryCache.Set<string>("Video22Url", Video22Url, previewArticleCacheOptions);
            var Video23Url = model.Video23Url;
            _memoryCache.Set<string>("Video23Url", Video23Url, previewArticleCacheOptions);
            var Video24Url = model.Video24Url;
            _memoryCache.Set<string>("Video24Url", Video24Url, previewArticleCacheOptions);
            var Video25Url = model.Video25Url;
            _memoryCache.Set<string>("Video25Url", Video25Url, previewArticleCacheOptions);
            var Video26Url = model.Video26Url;
            _memoryCache.Set<string>("Video26Url", Video26Url, previewArticleCacheOptions);
            var Video27Url = model.Video27Url;
            _memoryCache.Set<string>("Video27Url", Video27Url, previewArticleCacheOptions);
            var Video28Url = model.Video28Url;
            _memoryCache.Set<string>("Video28Url", Video28Url, previewArticleCacheOptions);
            var Video29Url = model.Video29Url;
            _memoryCache.Set<string>("Video29Url", Video29Url, previewArticleCacheOptions);
            var Video30Url = model.Video30Url;
            _memoryCache.Set<string>("Video30Url", Video30Url, previewArticleCacheOptions);
            var Video31Url = model.Video31Url;
            _memoryCache.Set<string>("Video31Url", Video31Url, previewArticleCacheOptions);
            var Video32Url = model.Video32Url;
            _memoryCache.Set<string>("Video32Url", Video32Url, previewArticleCacheOptions);
            var Video33Url = model.Video33Url;
            _memoryCache.Set<string>("Video33Url", Video33Url, previewArticleCacheOptions);
            var Video34Url = model.Video34Url;
            _memoryCache.Set<string>("Video34Url", Video34Url, previewArticleCacheOptions);
            var Video35Url = model.Video35Url;
            _memoryCache.Set<string>("Video35Url", Video35Url, previewArticleCacheOptions);
            var Video36Url = model.Video36Url;
            _memoryCache.Set<string>("Video36Url", Video36Url, previewArticleCacheOptions);
            var Video37Url = model.Video37Url;
            _memoryCache.Set<string>("Video37Url", Video37Url, previewArticleCacheOptions);
            var Video38Url = model.Video38Url;
            _memoryCache.Set<string>("Video38Url", Video38Url, previewArticleCacheOptions);
            var Video39Url = model.Video39Url;
            _memoryCache.Set<string>("Video39Url", Video39Url, previewArticleCacheOptions);
            var Video40Url = model.Video40Url;
            _memoryCache.Set<string>("Video40Url", Video40Url, previewArticleCacheOptions);
            var Video41Url = model.Video41Url;
            _memoryCache.Set<string>("Video41Url", Video41Url, previewArticleCacheOptions);
            var Video42Url = model.Video42Url;
            _memoryCache.Set<string>("Video42Url", Video42Url, previewArticleCacheOptions);
            var Video43Url = model.Video43Url;
            _memoryCache.Set<string>("Video43Url", Video43Url, previewArticleCacheOptions);
            var Video44Url = model.Video44Url;
            _memoryCache.Set<string>("Video44Url", Video44Url, previewArticleCacheOptions);
            var Video45Url = model.Video45Url;
            _memoryCache.Set<string>("Video45Url", Video45Url, previewArticleCacheOptions);
            var Video46Url = model.Video46Url;
            _memoryCache.Set<string>("Video46Url", Video46Url, previewArticleCacheOptions);
            var Video47Url = model.Video47Url;
            _memoryCache.Set<string>("Video47Url", Video47Url, previewArticleCacheOptions);
            var Video48Url = model.Video48Url;
            _memoryCache.Set<string>("Video48Url", Video48Url, previewArticleCacheOptions);
            var Video49Url = model.Video49Url;
            _memoryCache.Set<string>("Video49Url", Video49Url, previewArticleCacheOptions);
            var Video50Url = model.Video50Url;
            _memoryCache.Set<string>("Video50Url", Video50Url, previewArticleCacheOptions);

            var TreePurchaseStatus = model.TreePurchaseStatus;
            _memoryCache.Set<string>("TreePurchaseStatus", TreePurchaseStatus, previewArticleCacheOptions);

            bool treePurchase = false;
            bool featured = false;
            _memoryCache.Set<bool>("treePurchase", treePurchase, previewArticleCacheOptions);
            _memoryCache.Set<bool>("featured", featured, previewArticleCacheOptions);

            int validCode = await CheckFeaturedArticleCode.checkFeaturedArticleCodeAsync(FeaturedCodeField);

            switch (validCode)
            {
                case 1:
                    treePurchase = true;
                    _memoryCache.Set("treePurchase", treePurchase, previewArticleCacheOptions);

                    Debug.WriteLine("************* case 1");

                    return RedirectToAction(actionName: "UserArticle", controllerName: "UserArticle", new { culture, id = routeData });

                case 2:
                    featured = true;
                    _memoryCache.Set("featured", featured, previewArticleCacheOptions);

                    Debug.WriteLine("************* case 2");

                    return RedirectToAction(actionName: "UserArticle", controllerName: "UserArticle", new { culture, id = routeData });

                case 3:
                    treePurchase = true;
                    featured = true;
                    _memoryCache.Set("treePurchase", treePurchase, previewArticleCacheOptions);
                    _memoryCache.Set("featured", featured, previewArticleCacheOptions);

                    Debug.WriteLine("************* case 3");

                    return RedirectToAction(actionName: "UserArticle", controllerName: "UserArticle", new { culture, id = routeData });

                default:
                    _memoryCache.Set("treePurchase", false, previewArticleCacheOptions);
                    _memoryCache.Set("featured", false, previewArticleCacheOptions);

                    Debug.WriteLine("************* case default");

                    return RedirectToAction(actionName: "UserArticle", controllerName: "UserArticle", new { culture, id = routeData });
            }

        }

        public async Task<string> uploadTempImage(IFormFile passedFile)
        {
            if (passedFile != null)
            {
                string uploadsFolder = Path.Combine(_env.WebRootPath, "previewimages");
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + passedFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    passedFile.CopyTo(fileStream);
                }
                return uniqueFileName;
            }
            return null;
        }
    }
}
