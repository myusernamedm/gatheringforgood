using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using GatheringForGood.Models;
using LocSourceNameReferenceLibrary;
using ImageUrlReferenceLibrary;
using URLStringsReferenceLibrary;
using GatheringForGood.Areas.FunctionalLogic;
using System.Collections.Generic;
using System.Linq;
using GatheringForGood.Data;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace GatheringForGood.Controllers
{
    public class ReduceDeforestationController : Controller
    {
        readonly HomePageLocSourceNames _locSourceHomePageNameReferenceLibrary = new();
        HomePageImageUrls _HomePageImageUrlLibrary = new HomePageImageUrls();
        readonly ReduceDeforestationPageLocSourceNames _locSourceReduceDeforestationPageNameReferenceLibrary = new();
        readonly SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new();
        readonly ReduceDeforestationPageImageUrls _ReduceDeforestationPageImageUrlLibrary = new();
        readonly SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();
        readonly UrlStrings _URLStringsUrlLibrary = new();
        readonly RDFIncrementUserActionClicks RDFIncrementClicks = new();
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        private readonly ApplicationDbContext _context;
        private readonly IEmailSender _emailSender;

        public ReduceDeforestationController(IEmailSender emailSender, ApplicationDbContext context)
        {
            _emailSender = emailSender;
            _context = context;
        }

        [HttpGet]
        public IActionResult ReduceDeforestation()
        {
            string userId = ClaimsPrincipalExtensions.GetUserId<string>(User);
            List<string> totalActionsList;
            List<string> actionsList = RDFGetUserActionClicks.GetClicks(userId);
            int actionsListCount = actionsList.Count();

            if (actionsListCount > 1)
            {
                totalActionsList = RDFGetClickTotals.GetTotalClicks(userId, true);
            }
            else
            {
                totalActionsList = RDFGetClickTotals.GetTotalClicks(userId, false);
            }

            if (actionsListCount > 0)
            {
                var viewModel = new ReduceDeforestationViewModel
                {
                    PageTabTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForReduceDeforestationPage(),
                    ButtonText = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceButtonTextNameReference(),
                    Title = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForReduceDeforestationPage(),
                    Subtitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForReduceDeforestationPage(),
                    DoSomethingTodayTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceDoSomethingTodayTitleNameReferenceForReduceDeforestationPage(),
                    DoSomethingTodayPara = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceDoSomethingTodayParaNameReferenceForReduceDeforestationPage(),
                    DoSomethingTodayPara2 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceDoSomethingTodayPara2NameReferenceForReduceDeforestationPage(),
                    WhatCanIDo = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceWhatCanIDoNameReferenceForReduceDeforestationPage(),
                    Information = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceInformationNameReferenceForReduceDeforestationPage(),
                    Impact = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceImpactNameReferenceForReduceDeforestationPage(),
                    IDidThisToday = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceDidThisTodayNameReferenceForReduceDeforestationPage(),
                    MyImpact = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceMyImpactNameReferenceForReduceDeforestationPage(),
                    ReduceMeatIntakeTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceReduceMeatIntakeTitleNameReferenceForReduceDeforestationPage(),
                    ReduceMeatIntakePara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceReduceMeatIntakePara1NameReferenceForReduceDeforestationPage(),
                    ReduceMeatIntakePara2 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceReduceMeatIntakePara2NameReferenceForReduceDeforestationPage(),
                    DonateTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceDonateTitleNameReferenceForReduceDeforestationPage(),
                    DonatePara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceDonatePara1NameReferenceForReduceDeforestationPage(),
                    SocialMediaTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceSocialMediaTitleNameReferenceForReduceDeforestationPage(),
                    SocialMediaPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceSocialMediaPara1NameReferenceForReduceDeforestationPage(),
                    SupportHabitatRestorationTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceSupportHabitatRestorationTitleNameReferenceForReduceDeforestationPage(),
                    SupportHabitatRestorationPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceSupportHabitatRestorationPara1NameReferenceForReduceDeforestationPage(),
                    SupportHabitatRestorationPara2 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceSupportHabitatRestorationPara2NameReferenceForReduceDeforestationPage(),
                    PlantSomeTreesTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourcePlantSomeTreesTitleNameReferenceForReduceDeforestationPage(),
                    PlantSomeTreesPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourcePlantSomeTreesPara1NameReferenceForReduceDeforestationPage(),
                    PlantSomeTreesPara2 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourcePlantSomeTreesPara2NameReferenceForReduceDeforestationPage(),
                    GoPaperlessTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceGoPaperlessTitleNameReferenceForReduceDeforestationPage(),
                    GoPaperlessPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceGoPaperlessPara1NameReferenceForReduceDeforestationPage(),
                    EatOrganicTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceEatOrganicTitleNameReferenceForReduceGlobalWarmingPage(),
                    EatOrganicPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceEatOrganicPara1NameReferenceForReduceGlobalWarmingPage(),
                    ZeroDeforestationTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceZeroDeforestationTitleNameReferenceForReduceDeforestationPage(),
                    ZeroDeforestationPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceZeroDeforestationPara1NameReferenceForReduceDeforestationPage(),
                    BuyRecycledTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceBuyRecycledTitleNameReferenceForReduceDeforestationPage(),
                    BuyRecycledPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceBuyRecycledPara1NameReferenceForReduceDeforestationPage(),
                    StandUpTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceStandUpTitleNameReferenceForReduceDeforestationPage(),
                    StandUpPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceStandUpPara1NameReferenceForReduceDeforestationPage(),
                    GoVegetarianTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceGoVegetarianTitleNameReferenceForReduceDeforestationPage(),
                    GoVegetarianPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceGoVegetarianPara1NameReferenceForReduceDeforestationPage(),
                    GoVeganTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceGoVeganTitleNameReferenceForReduceDeforestationPage(),
                    GoVeganPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceGoVeganPara1NameReferenceForReduceDeforestationPage(),
                    SignAPetitionTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceSignAPetitionTitleNameReferenceForReduceDeforestationPage(),
                    SignAPetitionPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceSignAPetitionPara1NameReferenceForReduceDeforestationPage(),
                    WhatDidYouExpectPara = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceDeforestationPage(),
                    LearnMore = _locSourceHomePageNameReferenceLibrary.GetLocSourceCarbonClockLearnMoreLabelNameReference(),
                    Treeicon1 = _ReduceDeforestationPageImageUrlLibrary.GetTreeicon1ThumbnailUrlForReduceDeforestationPage(),
                    Treeicon2 = _ReduceDeforestationPageImageUrlLibrary.GetTreeicon2ThumbnailUrlForReduceDeforestationPage(),
                    Treeicon3 = _ReduceDeforestationPageImageUrlLibrary.GetTreeicon3ThumbnailUrlForReduceDeforestationPage(),
                    Treeicon4 = _ReduceDeforestationPageImageUrlLibrary.GetTreeicon4ThumbnailUrlForReduceDeforestationPage(),
                    Treeicon5 = _ReduceDeforestationPageImageUrlLibrary.GetTreeicon5ThumbnailUrlForReduceDeforestationPage(),
                    MouseClickIconThumbnailUrl = _ReduceDeforestationPageImageUrlLibrary.GetMouseClickIconThumbnailUrlForReduceDeforestationPage(),
                    HandTapIconThumbnailUrl = _ReduceDeforestationPageImageUrlLibrary.GetHandTapIconThumbnailUrlForReduceDeforestationPage(),
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
                    Close = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceCloseLabelNameReference(),
                    MyImpactReduceMeat = actionsList[0],
                    MyImpactGoVegetarian = actionsList[1],
                    MyImpactGoVegan = actionsList[2],
                    MyImpactEatOrganic = actionsList[3],
                    MyImpactHabitatRestoration = actionsList[4],
                    MyImpactZeroDeforestation = actionsList[5],
                    MyImpactGoPaperless = actionsList[6],
                    MyImpactDonate = actionsList[7],
                    MyImpactPlantTrees = actionsList[8],
                    MyImpactBuyRecycled = actionsList[9],
                    MyImpactStandUp = actionsList[10],
                    MyImpactSignAPetition = actionsList[11],
                    MyImpactSocialMedia = actionsList[12],
                    SiteImpactTotal = totalActionsList[0],
                    RDFImpactTotal = totalActionsList[1],
                    AllUsersCO2ImpactTotal = totalActionsList[2] + " kg Co2e",
                    UserImpactTotal = totalActionsList[3],
                    RDFMyCO2ImpactTotal = totalActionsList[4] + " kg Co2e",
                    SiteImpactTitle = _locSourceSharedCrossPageNameReferenceLibrary.GetSiteTotalActionsTitle(),
                    RDFImpactTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetTotalActionsTitleForArea(),
                    UserImpactTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetUserTotalActionsTitleForReduceDeforestationPage(),
                    RDFMyCO2ImpactTitle = _locSourceSharedCrossPageNameReferenceLibrary.GetMyCO2ImpactTitleForPage(),
                    CanopyProjectUrl = _URLStringsUrlLibrary.GetCanopyProjectUrl(),
                    ComingSoon = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceComingSoonLabelNameReference(),
                    LikeToSee = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLikeToSeeLabelNameReference(),
                    AllUserActionsIcon = _SharedCrossPageImageUrlLibrary.GetAllUserActionsIconUrlForPage(),
                    AllUserRDFActionsIcon = _SharedCrossPageImageUrlLibrary.GetRGWImpactIconUrlForPages(),
                    MyTotalActionsIcon = _SharedCrossPageImageUrlLibrary.GetMyTotalActionsIconUrlForPage(),
                    MyCO2ImpactIcon = _SharedCrossPageImageUrlLibrary.GetMyCo2ReductionIconUrlForPage(),
                    IconTwitter = _SharedCrossPageImageUrlLibrary.GetTwitterIconUrlForPage(),
                    IconLinkedin = _SharedCrossPageImageUrlLibrary.GetLinkedinIconUrlForPage(),
                    IconFacebook = _SharedCrossPageImageUrlLibrary.GetFacebookIconUrlForPage(),
                    IconReddit = _SharedCrossPageImageUrlLibrary.GetRedditIconUrlForPage(),
                    Submit = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceSubmitLabelNameReference(),
                    ReduceGlobalWarmingButton = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceReduceGlobalWarmingButtonNameReference(),
                    ReduceExtinctionButton = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceReduceExtinctionButtonNameReference(),
                    ReduceDeforestationButton = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceReduceDeforestationButtonNameReference(),
                    EnableSharing = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceEnableSharingNameReferenceForPage(),
                    TotalActionsAllUsersShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20have%20taken%20" + totalActionsList[0] + "%20actions%20to%20help%20save%20the%20world!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                    GlobalWarmingAllUsersShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20have%20taken%20" + totalActionsList[1] + "%20actions%20to%20help%20save%20us%20from%20deforestation!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                    AllUsersCO2MyShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20have%20reduced%20their%20CO2%20output%20to%20date%20by%20" + totalActionsList[2] + "kg%20Co2e%20to%20help%20save%20us%20from%20climate%20change!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                    TotalActionsMyShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=I%20have%20taken%20" + totalActionsList[3] + "%20actions%20to%20help%20save%20the%20world!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                    CO2ReductionMyShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=I%20have%20reduced%20my%20CO2%20output%20to%20date%20by%20" + totalActionsList[4] + "kg%20Co2e%20to%20help%20save%20us%20from%20climate%20change!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                    ClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceClickDetailsNameReferenceForPage(),
                    ReduceMeatClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceReduceMeatClickDetailsNameReferenceForPage(),
                    GoVegetarianClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceGoVegetarianClickDetailsNameReferenceForPage(),
                    GoVeganClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceGoVeganClickDetailsNameReferenceForPage(),
                    NotQuantifiableClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    EatOrganicClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceEatOrganicClickDetailsNameReferenceForPage(),
                    HabitatRestorationClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    ZeroDeforestationClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    GoPaperlessClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    DonateClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    PlantSomeTreesClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourcePlantSomeTreesClickDetailsNameReferenceForPage(),
                    BuyRecycledClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    StandUpClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    SignPetitionDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    SocialMediaClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    RDFIconImage = _HomePageImageUrlLibrary.GetRDFIconImageUrlReferenceForHomePage(),
                    RDFIconText = _locSourceHomePageNameReferenceLibrary.GetRDFIconNameReferenceForHomePage(),
                    RAEIconImage = _HomePageImageUrlLibrary.GetRAEIconImageUrlReferenceForHomePage(),
                    RAEIconText = _locSourceHomePageNameReferenceLibrary.GetRAEIconNameReferenceForHomePage(),
                    RGWIconImage = _HomePageImageUrlLibrary.GetRGWIconImageUrlReferenceForHomePage(),
                    RGWIconText = _locSourceHomePageNameReferenceLibrary.GetRGWIconNameReferenceForHomePage(),
                    AllUsersCO2ImpactTitle = _locSourceSharedCrossPageNameReferenceLibrary.GetAllUsersCO2ImpactTitleForPage(),
                    AllUsersCO2ImpactIcon = _SharedCrossPageImageUrlLibrary.GetAllUserImpactIconUrlForPage(),
                    Updates = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceUpdatesNameReferenceForPage(),
                    HomepageShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20are%20taking%20action%20to%20help%20save%20the%20world!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                    RDFpageShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cdeforestation%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2Fen%2FReduceDeforestation%2FReduceDeforestation%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20are%20taking%20action%20to%20help%20reduce%20deforestation!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com%2Fen%2FReduceDeforestation%2FReduceDeforestation",
                    GetEarthHandsReducedImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReducedImageUrlForPage(),
                    GetEarthHandsReduced400ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced400ImageUrlForPage(),
                    GetEarthHandsReduced800ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced800ImageUrlForPage(),
                    GetEarthHandsReduced1200ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced1200ImageUrlForPage(),
                    GetEarthHandsReduced1600ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced1600ImageUrlForPage()
                };
                actionsList.Clear();
                totalActionsList.Clear();
                return View(viewModel);
            }
            else
            {

                var viewModel = new ReduceDeforestationViewModel
                {
                    PageTabTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForReduceDeforestationPage(),
                    ButtonText = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceButtonTextNameReference(),
                    Title = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForReduceDeforestationPage(),
                    Subtitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForReduceDeforestationPage(),
                    DoSomethingTodayTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceDoSomethingTodayTitleNameReferenceForReduceDeforestationPage(),
                    DoSomethingTodayPara = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceDoSomethingTodayParaNameReferenceForReduceDeforestationPage(),
                    WhatCanIDo = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceWhatCanIDoNameReferenceForReduceDeforestationPage(),
                    Information = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceInformationNameReferenceForReduceDeforestationPage(),
                    Impact = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceImpactNameReferenceForReduceDeforestationPage(),
                    IDidThisToday = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceDidThisTodayNameReferenceForReduceDeforestationPage(),
                    MyImpact = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceMyImpactNameReferenceForReduceDeforestationPage(),
                    ReduceMeatIntakeTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceReduceMeatIntakeTitleNameReferenceForReduceDeforestationPage(),
                    ReduceMeatIntakePara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceReduceMeatIntakePara1NameReferenceForReduceDeforestationPage(),
                    ReduceMeatIntakePara2 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceReduceMeatIntakePara2NameReferenceForReduceDeforestationPage(),
                    DonateTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceDonateTitleNameReferenceForReduceDeforestationPage(),
                    DonatePara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceDonatePara1NameReferenceForReduceDeforestationPage(),
                    SocialMediaTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceSocialMediaTitleNameReferenceForReduceDeforestationPage(),
                    SocialMediaPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceSocialMediaPara1NameReferenceForReduceDeforestationPage(),
                    SupportHabitatRestorationTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceSupportHabitatRestorationTitleNameReferenceForReduceDeforestationPage(),
                    SupportHabitatRestorationPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceSupportHabitatRestorationPara1NameReferenceForReduceDeforestationPage(),
                    SupportHabitatRestorationPara2 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceSupportHabitatRestorationPara2NameReferenceForReduceDeforestationPage(),
                    PlantSomeTreesTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourcePlantSomeTreesTitleNameReferenceForReduceDeforestationPage(),
                    PlantSomeTreesPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourcePlantSomeTreesPara1NameReferenceForReduceDeforestationPage(),
                    PlantSomeTreesPara2 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourcePlantSomeTreesPara2NameReferenceForReduceDeforestationPage(),
                    GoPaperlessTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceGoPaperlessTitleNameReferenceForReduceDeforestationPage(),
                    GoPaperlessPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceGoPaperlessPara1NameReferenceForReduceDeforestationPage(),
                    EatOrganicTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceEatOrganicTitleNameReferenceForReduceGlobalWarmingPage(),
                    EatOrganicPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceEatOrganicPara1NameReferenceForReduceGlobalWarmingPage(),
                    ZeroDeforestationTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceZeroDeforestationTitleNameReferenceForReduceDeforestationPage(),
                    ZeroDeforestationPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceZeroDeforestationPara1NameReferenceForReduceDeforestationPage(),
                    BuyRecycledTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceBuyRecycledTitleNameReferenceForReduceDeforestationPage(),
                    BuyRecycledPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceBuyRecycledPara1NameReferenceForReduceDeforestationPage(),
                    StandUpTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceStandUpTitleNameReferenceForReduceDeforestationPage(),
                    StandUpPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceStandUpPara1NameReferenceForReduceDeforestationPage(),
                    GoVegetarianTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceGoVegetarianTitleNameReferenceForReduceDeforestationPage(),
                    GoVegetarianPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceGoVegetarianPara1NameReferenceForReduceDeforestationPage(),
                    GoVeganTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceGoVeganTitleNameReferenceForReduceDeforestationPage(),
                    GoVeganPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceGoVeganPara1NameReferenceForReduceDeforestationPage(),
                    SignAPetitionTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceSignAPetitionTitleNameReferenceForReduceDeforestationPage(),
                    SignAPetitionPara1 = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceSignAPetitionPara1NameReferenceForReduceDeforestationPage(),
                    WhatDidYouExpectPara = _locSourceReduceDeforestationPageNameReferenceLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceDeforestationPage(),
                    LearnMore = _locSourceHomePageNameReferenceLibrary.GetLocSourceCarbonClockLearnMoreLabelNameReference(),
                    Treeicon1 = _ReduceDeforestationPageImageUrlLibrary.GetTreeicon1ThumbnailUrlForReduceDeforestationPage(),
                    Treeicon2 = _ReduceDeforestationPageImageUrlLibrary.GetTreeicon2ThumbnailUrlForReduceDeforestationPage(),
                    Treeicon3 = _ReduceDeforestationPageImageUrlLibrary.GetTreeicon3ThumbnailUrlForReduceDeforestationPage(),
                    Treeicon4 = _ReduceDeforestationPageImageUrlLibrary.GetTreeicon4ThumbnailUrlForReduceDeforestationPage(),
                    Treeicon5 = _ReduceDeforestationPageImageUrlLibrary.GetTreeicon5ThumbnailUrlForReduceDeforestationPage(),
                    MouseClickIconThumbnailUrl = _ReduceDeforestationPageImageUrlLibrary.GetMouseClickIconThumbnailUrlForReduceDeforestationPage(),
                    HandTapIconThumbnailUrl = _ReduceDeforestationPageImageUrlLibrary.GetHandTapIconThumbnailUrlForReduceDeforestationPage(),
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
                    Close = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceCloseLabelNameReference(),
                    MyImpactReduceMeat = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactGoVegetarian = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactGoVegan = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactEatOrganic = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactHabitatRestoration = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactZeroDeforestation = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactGoPaperless = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactDonate = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactPlantTrees = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactBuyRecycled = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactStandUp = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactSignAPetition = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactSocialMedia = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    SiteImpactTotal = totalActionsList[0],
                    RDFImpactTotal = totalActionsList[1],
                    AllUsersCO2ImpactTotal = totalActionsList[2] + " kg Co2e",
                    RDFMyCO2ImpactTotal = "0",
                    UserImpactTotal = "0 kg Co2e",
                    SiteImpactTitle = _locSourceSharedCrossPageNameReferenceLibrary.GetSiteTotalActionsTitle(),
                    RDFImpactTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetTotalActionsTitleForArea(),
                    UserImpactTitle = _locSourceReduceDeforestationPageNameReferenceLibrary.GetUserTotalActionsTitleForReduceDeforestationPage(),
                    RDFMyCO2ImpactTitle = _locSourceSharedCrossPageNameReferenceLibrary.GetMyCO2ImpactTitleForPage(),
                    CanopyProjectUrl = _URLStringsUrlLibrary.GetCanopyProjectUrl(),
                    ComingSoon = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceComingSoonLabelNameReference(),
                    LikeToSee = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLikeToSeeLabelNameReference(),
                    AllUserActionsIcon = _SharedCrossPageImageUrlLibrary.GetAllUserActionsIconUrlForPage(),
                    AllUserRDFActionsIcon = _SharedCrossPageImageUrlLibrary.GetRGWImpactIconUrlForPages(),
                    MyTotalActionsIcon = _SharedCrossPageImageUrlLibrary.GetMyTotalActionsIconUrlForPage(),
                    MyCO2ImpactIcon = _SharedCrossPageImageUrlLibrary.GetMyCo2ReductionIconUrlForPage(),
                    IconTwitter = _SharedCrossPageImageUrlLibrary.GetTwitterIconUrlForPage(),
                    IconLinkedin = _SharedCrossPageImageUrlLibrary.GetLinkedinIconUrlForPage(),
                    IconFacebook = _SharedCrossPageImageUrlLibrary.GetFacebookIconUrlForPage(),
                    IconReddit = _SharedCrossPageImageUrlLibrary.GetRedditIconUrlForPage(),
                    Submit = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceSubmitLabelNameReference(),
                    ReduceGlobalWarmingButton = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceReduceGlobalWarmingButtonNameReference(),
                    ReduceExtinctionButton = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceReduceExtinctionButtonNameReference(),
                    ReduceDeforestationButton = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceReduceDeforestationButtonNameReference(),
                    EnableSharing = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceEnableSharingNameReferenceForPage(),
                    TotalActionsAllUsersShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20have%20taken%20" + totalActionsList[0] + "%20actions%20to%20help%20save%20the%20world!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                    GlobalWarmingAllUsersShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20have%20taken%20" + totalActionsList[1] + "%20actions%20to%20help%20save%20us%20from%20deforestation!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                    AllUsersCO2MyShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20have%20reduced%20their%20CO2%20output%20to%20date%20by%20" + totalActionsList[2] + "kg%20Co2e%20to%20help%20save%20us%20from%20climate%20change!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                    TotalActionsMyShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=I%20have%20taken%20" + totalActionsList[3] + "%20actions%20to%20help%20save%20the%20world!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                    CO2ReductionMyShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=I%20have%20reduced%20my%20CO2%20output%20to%20date%20by%20" + totalActionsList[4] + "kg%20Co2e%20to%20help%20save%20us%20from%20climate%20change!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                    ClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceClickDetailsNameReferenceForPage(),
                    ReduceMeatClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceReduceMeatClickDetailsNameReferenceForPage(),
                    GoVegetarianClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceGoVegetarianClickDetailsNameReferenceForPage(),
                    GoVeganClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceGoVeganClickDetailsNameReferenceForPage(),
                    NotQuantifiableClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    EatOrganicClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceEatOrganicClickDetailsNameReferenceForPage(),
                    HabitatRestorationClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    ZeroDeforestationClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    GoPaperlessClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    DonateClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    PlantSomeTreesClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourcePlantSomeTreesClickDetailsNameReferenceForPage(),
                    BuyRecycledClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    StandUpClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    SignPetitionDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    SocialMediaClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    RDFIconImage = _HomePageImageUrlLibrary.GetRDFIconImageUrlReferenceForHomePage(),
                    RDFIconText = _locSourceHomePageNameReferenceLibrary.GetRDFIconNameReferenceForHomePage(),
                    RAEIconImage = _HomePageImageUrlLibrary.GetRAEIconImageUrlReferenceForHomePage(),
                    RAEIconText = _locSourceHomePageNameReferenceLibrary.GetRAEIconNameReferenceForHomePage(),
                    RGWIconImage = _HomePageImageUrlLibrary.GetRGWIconImageUrlReferenceForHomePage(),
                    RGWIconText = _locSourceHomePageNameReferenceLibrary.GetRGWIconNameReferenceForHomePage(),
                    AllUsersCO2ImpactTitle = _locSourceSharedCrossPageNameReferenceLibrary.GetAllUsersCO2ImpactTitleForPage(),
                    AllUsersCO2ImpactIcon = _SharedCrossPageImageUrlLibrary.GetAllUserImpactIconUrlForPage(),
                    Updates = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceUpdatesNameReferenceForPage(),
                    HomepageShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20are%20taking%20action%20to%20help%20save%20the%20world!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                    RDFpageShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cdeforestation%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2Fen%2FReduceDeforestation%2FReduceDeforestation%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20are%20taking%20action%20to%20help%20reduce%20deforestation!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com%2Fen%2FReduceDeforestation%2FReduceDeforestation",
                    GetEarthHandsReducedImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReducedImageUrlForPage(),
                    GetEarthHandsReduced400ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced400ImageUrlForPage(),
                    GetEarthHandsReduced800ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced800ImageUrlForPage(),
                    GetEarthHandsReduced1200ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced1200ImageUrlForPage(),
                    GetEarthHandsReduced1600ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced1600ImageUrlForPage()

                };
                actionsList.Clear();
                totalActionsList.Clear();
                return View(viewModel);
            }
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

        public async Task <IActionResult> RDFInsertNewActionNumber(int actionNumber)
        {
            string userId = ClaimsPrincipalExtensions.GetUserId<string>(User);
            await RDFIncrementClicks.UserClick(actionNumber, userId, _context);

            return RedirectToAction("ReduceDeforestation");
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
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "RDF Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "RDF Page Newsfeed Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "RDF Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "RDF Page Newsfeed Modal", FeedbackDateTime);
                }
            }

            return RedirectToAction("ReduceDeforestation");
        }
    }
}