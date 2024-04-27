using GatheringForGood.Areas.FunctionalLogic;
using GatheringForGood.Areas.Identity.Data;
using GatheringForGood.Data;
using LazZiya.ExpressLocalization.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Models
{
    public class CreateArticleViewModel
    {
        public string PageTabTitle { get; set; }
        public string ButtonText { get; set; }
        public string Title { get; set; }
        public string ToolTipInfo { get; set; }
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
        public string Author { get; set; }
        public string AddName { get; set; }
        public string YourArticleCard { get; set; }
        public string ArticleTitleLabel { get; set; }
        public string TitleImageLabel { get; set; }
        public string TitleVideoLabel { get; set; }
        public string ParaVideoLabel { get; set; }
        public string ArticleSnippetLabel { get; set; }
        public string TandCHeading { get; set; }
        public string Add1stParaButton { get; set; }
        public string AddParaButton { get; set; }
        public string DeleteButton { get; set; }
        public string AddTitleImageButton { get; set; }
        public string Add1stImageButton { get; set; }
        public string AddImageButton { get; set; }
        public string Submit { get; set; }
        public string PreviewButton { get; set; }
        public string ComingSoon { get; set; }
        public string LikeToSee { get; set; }
        public string UserFullName { get; set; }
        public string GoBack { get; set; }
        public string Updates { get; set; }
        public string HomepageShare { get; set; }
        public string IconTwitter { get; set; }
        public string IconLinkedin { get; set; }
        public string IconFacebook { get; set; }
        public string SubheadingLabel { get; set; }
        public string Para1Label { get; set; }
        public string Para2Label { get; set; }
        public string Para3Label { get; set; }
        public string Para4Label { get; set; }
        public string Para5Label { get; set; }
        public string Para6Label { get; set; }
        public string Para7Label { get; set; }
        public string Para8Label { get; set; }
        public string Para9Label { get; set; }
        public string Para10Label { get; set; }
        public string Para11Label { get; set; }
        public string Para12Label { get; set; }
        public string Para13Label { get; set; }
        public string Para14Label { get; set; }
        public string Para15Label { get; set; }
        public string Para16Label { get; set; }
        public string Para17Label { get; set; }
        public string Para18Label { get; set; }
        public string Para19Label { get; set; }
        public string Para20Label { get; set; }
        public string Para21Label { get; set; }
        public string Para22Label { get; set; }
        public string Para23Label { get; set; }
        public string Para24Label { get; set; }
        public string Para25Label { get; set; }
        public string Para26Label { get; set; }
        public string Para27Label { get; set; }
        public string Para28Label { get; set; }
        public string Para29Label { get; set; }
        public string Para30Label { get; set; }
        public string Para31Label { get; set; }
        public string Para32Label { get; set; }
        public string Para33Label { get; set; }
        public string Para34Label { get; set; }
        public string Para35Label { get; set; }
        public string Para36Label { get; set; }
        public string Para37Label { get; set; }
        public string Para38Label { get; set; }
        public string Para39Label { get; set; }
        public string Para40Label { get; set; }
        public string Para41Label { get; set; }
        public string Para42Label { get; set; }
        public string Para43Label { get; set; }
        public string Para44Label { get; set; }
        public string Para45Label { get; set; }
        public string Para46Label { get; set; }
        public string Para47Label { get; set; }
        public string Para48Label { get; set; }
        public string Para49Label { get; set; }
        public string Para50Label { get; set; }
        public string ImageCaptionLabel { get; set; }
        public string PostedDateTimeLabel { get; set; }
        public string RecommendedDimensionsLabel { get; set; }
        public string MaxFileSizeLabel { get; set; }
        public string FileTypesLabel { get; set; }
        public string BackButton { get; set; }
        public string CardTitleImage { get; set; }
        public string CardImage { get; set; }
        public string ImageSizeError { get; set; }
        public string ImageTypeError { get; set; }
        public string VideoLinkError { get; set; }
        public string FeaturedHeading { get; set; }
        public string FeaturedInfo { get; set; }
        public string FirstNameHeading { get; set; }
        public string LastNameHeading { get; set; }
        public string PlantATreeTitle { get; set; }
        public string PlantATreePara1 { get; set; }
        public string PlantATreePara2 { get; set; }
        public string PlantATreeClickHere { get; set; }
        public string PlantATreeCheckedImageUrl { get; set; }
        public string PlantATreeUncheckedImageUrl { get; set; }
        public string OneTreeIconImageUrl { get; set; }
        public string TwoTreeIconImageUrl { get; set; }
        public string ThreeTreeIconImageUrl { get; set; }
        public string FiveTreeIconImageUrl { get; set; }
        public string Plant1Tree { get; set; }
        public string Plant1TreePM { get; set; }
        public string Plant2Tree { get; set; }
        public string Plant2TreePM { get; set; }
        public string Plant5Tree { get; set; }
        public string Plant5TreePM { get; set; }
        public string Plant10Tree { get; set; }
        public string Plant10TreePM { get; set; }
        public string Plant20Tree { get; set; }
        public string Plant20TreePM { get; set; }
        public string Plant1TreePrice { get; set; }
        public string Plant1TreePMPrice { get; set; }
        public string Plant2TreePrice { get; set; }
        public string Plant2TreePMPrice { get; set; }
        public string Plant5TreePrice { get; set; }
        public string Plant5TreePMPrice { get; set; }
        public string Plant10TreePrice { get; set; }
        public string Plant10TreePMPrice { get; set; }
        public string Plant20TreePrice { get; set; }
        public string Plant20TreePMPrice { get; set; }
        public string TreePurchaseOption { get; set; }
        public string TreePurchaseTandCs1 { get; set; }
        public string TreePurchaseTandCs2 { get; set; }
        public string FeaturedTitle { get; set; }
        public string FeaturedText { get; set; }
        public string TreePurchaseTitle { get; set; }
        public string TreePurchaseText { get; set; }
        public string FeaturedArticleUrl { get; set; }
        public string TreePlantedUrl { get; set; }
        public string TreePlantedTooltipTitle { get; set; }
        public string Plant1TreeTooltipText { get; set; }
        public string Plant2TreeTooltipText { get; set; }
        public string Plant5TreeTooltipText { get; set; }
        public string Plant10TreeTooltipText { get; set; }
        public string Plant20TreeTooltipText { get; set; }
        public string GetEarthHandsReducedImageUrl { get; set; }
        public string GetEarthHandsReduced400ImageUrl { get; set; }
        public string GetEarthHandsReduced800ImageUrl { get; set; }
        public string GetEarthHandsReduced1200ImageUrl { get; set; }
        public string GetEarthHandsReduced1600ImageUrl { get; set; }

        public DateTime PostedDateTime { get; set; }

        public List<GetUserArticleDetails> ArticleDetailsList = new();

        public ApplicationDbContext Context = new();

        [Required]
        [ExStringLength(60, MinimumLength = 7)]
        [DataType(DataType.Text)]
        [Display(Name = "Article Title")]
        public string ArticleTitle { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Tree Purchase Status")]
        public string TreePurchaseStatus { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Tree Purchase Type")]
        public string PurchaseType { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Featured Code")]
        public string FeaturedCode { get; set; }

        [ExStringLength(40, MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [ExStringLength(40, MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Title Image")]
        public string TitleImageValidation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 2 Validation")]
        public string Video2Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 3 Validation")]
        public string Video3Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 4 Validation")]
        public string Video4Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 5 Validation")]
        public string Video5Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 6 Validation")]
        public string Video6Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 7 Validation")]
        public string Video7Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 8 Validation")]
        public string Video8Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 9 Validation")]
        public string Video9Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 10 Validation")]
        public string Video10Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 11 Validation")]
        public string Video11Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 12 Validation")]
        public string Video12Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 13 Validation")]
        public string Video13Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 14 Validation")]
        public string Video14Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 15 Validation")]
        public string Video15Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 16 Validation")]
        public string Video16Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 17 Validation")]
        public string Video17Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 18 Validation")]
        public string Video18Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 19 Validation")]
        public string Video19Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 20 Validation")]
        public string Video20Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 21 Validation")]
        public string Video21Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 22 Validation")]
        public string Video22Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 23 Validation")]
        public string Video23Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 24 Validation")]
        public string Video24Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 25 Validation")]
        public string Video25Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 26 Validation")]
        public string Video26Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 27 Validation")]
        public string Video27Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 28 Validation")]
        public string Video28Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 29 Validation")]
        public string Video29Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 30 Validation")]
        public string Video30Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 31 Validation")]
        public string Video31Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 32 Validation")]
        public string Video32Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 33 Validation")]
        public string Video33Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 34 Validation")]
        public string Video34Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 35 Validation")]
        public string Video35Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 36 Validation")]
        public string Video36Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 37 Validation")]
        public string Video37Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 38 Validation")]
        public string Video38Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 39 Validation")]
        public string Video39Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 40 Validation")]
        public string Video40Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 41 Validation")]
        public string Video41Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 42 Validation")]
        public string Video42Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 43 Validation")]
        public string Video43Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 44 Validation")]
        public string Video44Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 45 Validation")]
        public string Video45Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 46 Validation")]
        public string Video46Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 47 Validation")]
        public string Video47Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 48 Validation")]
        public string Video48Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 49 Validation")]
        public string Video49Validation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Article Video 50 Validation")]
        public string Video50Validation { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Title Image")]
        public IFormFile TitleImageUrl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Title Video")]
        public string TitleVideoUrl { get; set; }

        [Required]
        [ExStringLength(200, MinimumLength = 10)]
        [DataType(DataType.Text)]
        [Display(Name = "Snippet")]
        public string Snippet { get; set; }

        [Required]
        [ExStringLength(3000, MinimumLength = 300)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 1 Text")]
        public string Para1Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 2 Text")]
        public string Para2Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 3 Text")]
        public string Para3Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 4 Text")]
        public string Para4Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 5 Text")]
        public string Para5Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 6 Text")]
        public string Para6Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 7 Text")]
        public string Para7Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 8 Text")]
        public string Para8Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 9 Text")]
        public string Para9Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 10 Text")]
        public string Para10Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 11 Text")]
        public string Para11Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 12 Text")]
        public string Para12Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 13 Text")]
        public string Para13Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 14 Text")]
        public string Para14Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 15 Text")]
        public string Para15Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 16 Text")]
        public string Para16Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 17 Text")]
        public string Para17Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 18 Text")]
        public string Para18Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 19 Text")]
        public string Para19Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 20 Text")]
        public string Para20Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 21 Text")]
        public string Para21Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 22 Text")]
        public string Para22Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 23 Text")]
        public string Para23Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 24 Text")]
        public string Para24Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 25 Text")]
        public string Para25Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 26 Text")]
        public string Para26Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 27 Text")]
        public string Para27Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 28 Text")]
        public string Para28Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 29 Text")]
        public string Para29Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 30 Text")]
        public string Para30Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 31 Text")]
        public string Para31Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 32 Text")]
        public string Para32Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 33 Text")]
        public string Para33Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 34 Text")]
        public string Para34Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 35 Text")]
        public string Para35Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 36 Text")]
        public string Para36Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 37 Text")]
        public string Para37Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 38 Text")]
        public string Para38Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 39 Text")]
        public string Para39Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 40 Text")]
        public string Para40Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 41 Text")]
        public string Para41Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 42 Text")]
        public string Para42Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 43 Text")]
        public string Para43Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 44 Text")]
        public string Para44Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 45 Text")]
        public string Para45Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 46 Text")]
        public string Para46Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 47 Text")]
        public string Para47Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 48 Text")]
        public string Para48Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 49 Text")]
        public string Para49Text { get; set; }

        [ExStringLength(3000, MinimumLength = 50)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 50 Text")]
        public string Para50Text { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 2 Subheading")]
        public string Para2Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 3 Subheading")]
        public string Para3Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 4 Subheading")]
        public string Para4Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 5 Subheading")]
        public string Para5Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 6 Subheading")]
        public string Para6Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 7 Subheading")]
        public string Para7Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 8 Subheading")]
        public string Para8Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 9 Subheading")]
        public string Para9Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 10 Subheading")]
        public string Para10Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 11 Subheading")]
        public string Para11Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 12 Subheading")]
        public string Para12Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 13 Subheading")]
        public string Para13Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 14 Subheading")]
        public string Para14Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 15 Subheading")]
        public string Para15Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 16 Subheading")]
        public string Para16Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 17 Subheading")]
        public string Para17Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 18 Subheading")]
        public string Para18Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 19 Subheading")]
        public string Para19Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 20 Subheading")]
        public string Para20Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 21 Subheading")]
        public string Para21Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 22 Subheading")]
        public string Para22Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 23 Subheading")]
        public string Para23Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 24 Subheading")]
        public string Para24Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 25 Subheading")]
        public string Para25Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 26 Subheading")]
        public string Para26Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 27 Subheading")]
        public string Para27Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 28 Subheading")]
        public string Para28Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 29 Subheading")]
        public string Para29Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 30 Subheading")]
        public string Para30Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 31 Subheading")]
        public string Para31Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 32 Subheading")]
        public string Para32Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 33 Subheading")]
        public string Para33Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 34 Subheading")]
        public string Para34Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 35 Subheading")]
        public string Para35Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 36 Subheading")]
        public string Para36Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 37 Subheading")]
        public string Para37Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 38 Subheading")]
        public string Para38Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 39 Subheading")]
        public string Para39Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 40 Subheading")]
        public string Para40Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 41 Subheading")]
        public string Para41Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 42 Subheading")]
        public string Para42Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 43 Subheading")]
        public string Para43Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 44 Subheading")]
        public string Para44Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 45 Subheading")]
        public string Para45Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 46 Subheading")]
        public string Para46Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 47 Subheading")]
        public string Para47Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 48 Subheading")]
        public string Para48Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 49 Subheading")]
        public string Para49Subheading { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Para 50 Subheading")]
        public string Para50Subheading { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 1")]
        public IFormFile Image1Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 2")]
        public IFormFile Image2Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 3")]
        public IFormFile Image3Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 4")]
        public IFormFile Image4Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 5")]
        public IFormFile Image5Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 6")]
        public IFormFile Image6Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 7")]
        public IFormFile Image7Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 8")]
        public IFormFile Image8Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 9")]
        public IFormFile Image9Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 10")]
        public IFormFile Image10Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 11")]
        public IFormFile Image11Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 12")]
        public IFormFile Image12Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 13")]
        public IFormFile Image13Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 14")]
        public IFormFile Image14Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 15")]
        public IFormFile Image15Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 16")]
        public IFormFile Image16Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 17")]
        public IFormFile Image17Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 18")]
        public IFormFile Image18Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 19")]
        public IFormFile Image19Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 20")]
        public IFormFile Image20Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 21")]
        public IFormFile Image21Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 22")]
        public IFormFile Image22Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 23")]
        public IFormFile Image23Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 24")]
        public IFormFile Image24Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 25")]
        public IFormFile Image25Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 26")]
        public IFormFile Image26Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 27")]
        public IFormFile Image27Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 28")]
        public IFormFile Image28Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 29")]
        public IFormFile Image29Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 30")]
        public IFormFile Image30Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 31")]
        public IFormFile Image31Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 32")]
        public IFormFile Image32Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 33")]
        public IFormFile Image33Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 34")]
        public IFormFile Image34Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 35")]
        public IFormFile Image35Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 36")]
        public IFormFile Image36Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 37")]
        public IFormFile Image37Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 38")]
        public IFormFile Image38Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 39")]
        public IFormFile Image39Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 40")]
        public IFormFile Image40Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 41")]
        public IFormFile Image41Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 42")]
        public IFormFile Image42Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 43")]
        public IFormFile Image43Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 44")]
        public IFormFile Image44Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 45")]
        public IFormFile Image45Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 46")]
        public IFormFile Image46Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 47")]
        public IFormFile Image47Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 48")]
        public IFormFile Image48Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 49")]
        public IFormFile Image49Url { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image 50")]
        public IFormFile Image50Url { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string ImageTitleCaption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image2Caption { get; set; }

        [ExStringLength(300, MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image3Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image4Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image5Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image6Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image7Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image8Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image9Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image10Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image11Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image12Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image13Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image14Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image15Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image16Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image17Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image18Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image19Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image20Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image21Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image22Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image23Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image24Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image25Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image26Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image27Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image28Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image29Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image30Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image31Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image32Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image33Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image34Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image35Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image36Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image37Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image38Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image39Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image40Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image41Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image42Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image43Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image44Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image45Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image46Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image47Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image48Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image49Caption { get; set; }

        [ExStringLength(300, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Caption")]
        public string Image50Caption { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 1")]
        public string Video1Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 2")]
        public string Video2Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 3")]
        public string Video3Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 4")]
        public string Video4Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 5")]
        public string Video5Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 6")]
        public string Video6Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 7")]
        public string Video7Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 8")]
        public string Video8Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 9")]
        public string Video9Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 10")]
        public string Video10Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 11")]
        public string Video11Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 12")]
        public string Video12Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 13")]
        public string Video13Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 14")]
        public string Video14Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 15")]
        public string Video15Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 16")]
        public string Video16Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 17")]
        public string Video17Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 18")]
        public string Video18Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 19")]
        public string Video19Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 20")]
        public string Video20Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 21")]
        public string Video21Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 22")]
        public string Video22Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 23")]
        public string Video23Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 24")]
        public string Video24Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 25")]
        public string Video25Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 26")]
        public string Video26Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 27")]
        public string Video27Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 28")]
        public string Video28Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 29")]
        public string Video29Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 30")]
        public string Video30Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 31")]
        public string Video31Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 32")]
        public string Video32Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 33")]
        public string Video33Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 34")]
        public string Video34Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 35")]
        public string Video35Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 36")]
        public string Video36Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 37")]
        public string Video37Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 38")]
        public string Video38Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 39")]
        public string Video39Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 40")]
        public string Video40Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 41")]
        public string Video41Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 42")]
        public string Video42Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 43")]
        public string Video43Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 44")]
        public string Video44Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 45")]
        public string Video45Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 46")]
        public string Video46Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 47")]
        public string Video47Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 48")]
        public string Video48Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 49")]
        public string Video49Url { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Video 50")]
        public string Video50Url { get; set; }

        [Required]
        [MustBeTrue]
        public bool TandC { get; set; }
    }
}
