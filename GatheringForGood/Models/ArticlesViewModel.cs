using GatheringForGood.Areas.FunctionalLogic;
using GatheringForGood.Areas.Identity.Data;
using LazZiya.ExpressLocalization.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Models
{
    public class ArticlesViewModel
    {
        public string PageTabTitle { get; set; }
        public string ButtonText { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
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
        public string ArticlespageShare { get; set; }
        public string IconTwitter { get; set; }
        public string IconLinkedin { get; set; }
        public string IconFacebook { get; set; }
        public string Updates { get; set; }
        public string HomepageShare { get; set; }
        public string Author { get; set; }
        public string CreateArticleButton { get; set; }
        public string FeaturedArticleUrl { get; set; }
        public string TreePlantedUrl { get; set; }
        public string Views { get; set; }
        public string SearchButtonText { get; set; }
        public string LikeIconUrl { get; set; }
        public string DislikeIconUrl { get; set; }
        public string ShockedIconUrl { get; set; }
        public string SupportIconUrl { get; set; }
        public string QuestionableIconUrl { get; set; }
        public string LikeTooltip { get; set; }
        public string DislikeTooltip { get; set; }
        public string ShockedTooltip { get; set; }
        public string SupportTooltip { get; set; }
        public string QuestionableTooltip { get; set; }
        public string StatusMessage { get; set; }
        public ViewDataDictionary ViewData { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
        public int SupportCount { get; set; }
        public int QuestionableCount { get; set; }
        public int ShockedCount { get; set; }
        public List<SelectListItem> ListOfSearchOptions { get; set; }
        public string SearchArticlesHeading { get; set; }
        public string SearchUsing { get; set; }
        public string FeaturedTitle { get; set; }
        public string FeaturedText { get; set; }
        public string TreePurchaseTitle { get; set; }
        public string TreePurchaseText { get; set; }
        public string GetEarthHandsReducedImageUrl { get; set; }
        public string GetEarthHandsReduced400ImageUrl { get; set; }
        public string GetEarthHandsReduced800ImageUrl { get; set; }
        public string GetEarthHandsReduced1200ImageUrl { get; set; }
        public string GetEarthHandsReduced1600ImageUrl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Search Option")]
        public string SearchOption { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "CountCards")]
        public string CountCards { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$")]
        [DataType(DataType.Text)]
        [Display(Name = "Search Text")]
        public string SearchText { get; set; }

        public IEnumerable<ArticlesList> ListOfArticles { get; set; }

        public List<GetArticlesCardDetails> MainArticleList = new List<GetArticlesCardDetails>();
    }
}
