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
    public class ReduceAnimalExtinctionController : Controller
    {
        readonly HomePageLocSourceNames _locSourceHomePageNameReferenceLibrary = new();
        HomePageImageUrls _HomePageImageUrlLibrary = new HomePageImageUrls();
        readonly ReduceAnimalExtinctionPageLocSourceNames _locSourceReduceAnimalExtinctionPageNameReferenceLibrary = new();
        readonly SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new();
        readonly ReduceAnimalExtinctionPageImageUrls _ReduceAnimalExtinctionPageImageUrlLibrary = new();
        readonly SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();
        readonly UrlStrings _URLStringsUrlLibrary = new();
        readonly RAEIncrementUserActionClicks RAEIncrementClicks = new();
        private readonly ApplicationDbContext _context;
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        private readonly IEmailSender _emailSender;

        public ReduceAnimalExtinctionController(IEmailSender emailSender, ApplicationDbContext context)
        {
            _emailSender = emailSender;
            _context = context;
        }

        [HttpGet]
        public IActionResult ReduceAnimalExtinction()
        {
            string userId = ClaimsPrincipalExtensions.GetUserId<string>(User);
            List<string> totalActionsList;
            List<string> actionsList = RAEGetUserActionClicks.GetClicks(userId);
            int actionsListCount = actionsList.Count();

            if (actionsListCount > 1)
            {
                totalActionsList = RAEGetClickTotals.GetTotalClicks(userId, true);
            }
            else
            {
                totalActionsList = RAEGetClickTotals.GetTotalClicks(userId, false);
            }

            if (actionsListCount > 0)
            {
                var viewModel = new ReduceAnimalExtinctionViewModel
                {
                    PageTabTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForReduceAnimalExtinctionPage(),
                    ButtonText = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceButtonTextNameReference(),
                    Title = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForReduceAnimalExtinctionPage(),
                    Subtitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForReduceAnimalExtinctionPage(),
                    DoSomethingTodayTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceDoSomethingTodayTitleNameReferenceForReduceAnimalExtinctionPage(),
                    DoSomethingTodayPara = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceDoSomethingTodayParaNameReferenceForReduceAnimalExtinctionPage(),
                    DoSomethingTodayPara2 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceDoSomethingTodayPara2NameReferenceForReduceAnimalExtinctionPage(),
                    WhatCanIDo = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceWhatCanIDoNameReferenceForReduceAnimalExtinctionPage(),
                    Information = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceInformationNameReferenceForReduceAnimalExtinctionPage(),
                    Impact = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceImpactNameReferenceForReduceAnimalExtinctionPage(),
                    IDidThisToday = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceDidThisTodayNameReferenceForReduceAnimalExtinctionPage(),
                    MyImpact = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceMyImpactNameReferenceForReduceAnimalExtinctionPage(),
                    ReduceMeatIntakeTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceReduceMeatIntakeTitleNameReferenceForReduceAnimalExtinctionPage(),
                    ReduceMeatIntakePara2 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceReduceMeatIntakePara2NameReferenceForReduceAnimalExtinctionPage(),
                    SixtyPercent = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceSixtyPercentLabelNameReference(),
                    ReducedFamilySizesTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceReducedFamilySizesTitleNameReferenceForReduceAnimalExtinctionPage(),
                    ReducedFamilySizesPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceReducedFamilySizesPara1NameReferenceForReduceAnimalExtinctionPage(),
                    ReducedFamilySizesPara2 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceReducedFamilySizesPara2NameReferenceForReduceAnimalExtinctionPage(),
                    WildlifeRefugeTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceWildlifeRefugeTitleNameReferenceForReduceAnimalExtinctionPage(),
                    WildlifeRefugePara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceWildlifeRefugePara1NameReferenceForReduceAnimalExtinctionPage(),
                    WildlifeRefugePara2 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceWildlifeRefugePara2NameReferenceForReduceAnimalExtinctionPage(),
                    HerbsAndPesticidesTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceHerbsAndPesticidesTitleNameReferenceForReduceAnimalExtinctionPage(),
                    HerbsAndPesticidesPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceHerbsAndPesticidesPara1NameReferenceForReduceAnimalExtinctionPage(),
                    HerbsAndPesticidesPara2 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceHerbsAndPesticidesPara2NameReferenceForReduceAnimalExtinctionPage(),
                    SupportHabitatRestorationTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceSupportHabitatRestorationTitleNameReferenceForReduceAnimalExtinctionPage(),
                    SupportHabitatRestorationPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceSupportHabitatRestorationPara1NameReferenceForReduceAnimalExtinctionPage(),
                    SupportHabitatRestorationPara2 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceSupportHabitatRestorationPara2NameReferenceForReduceAnimalExtinctionPage(),
                    SlowDownTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceSlowDownTitleNameReferenceForReduceAnimalExtinctionPage(),
                    SlowDownPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceSlowDownPara1NameReferenceForReduceAnimalExtinctionPage(),
                    PlantNativePlantsTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourcePlantNativePlantsTitleNameReferenceForReduceAnimalExtinctionPage(),
                    PlantNativePlants = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourcePlantNativePlantsPara1NameReferenceForReduceAnimalExtinctionPage(),
                    GreenRecoveryTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceGreenRecoveryTitleNameReferenceForReduceAnimalExtinctionPage(),
                    GreenRecoveryPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceGreenRecoveryPara1NameReferenceForReduceAnimalExtinctionPage(),
                    MinimisePlasticTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceMinimisePlasticTitleNameReferenceForReduceAnimalExtinctionPage(),
                    MinimisePlasticPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceMinimisePlasticPara1NameReferenceForReduceAnimalExtinctionPage(),
                    BuyRecycledTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceBuyRecycledTitleNameReferenceForReduceAnimalExtinctionPage(),
                    BuyRecycledPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceBuyRecycledPara1NameReferenceForReduceAnimalExtinctionPage(),
                    StandUp = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceStandUpNameReferenceForReduceAnimalExtinctionPage(),
                    StandUpPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceStandUpPara1NameReferenceForReduceAnimalExtinctionPage(),
                    UseARecyclingBinTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceUseARecyclingBinTitleNameReferenceForReduceAnimalExtinctionPage(),
                    UseARecyclingBinPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceUseARecyclingBinPara1NameReferenceForReduceAnimalExtinctionPage(),
                    GoVegetarianTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceGoVegetarianTitleNameReferenceForReduceAnimalExtinctionPage(),
                    GoVegetarianPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceGoVegetarianPara1NameReferenceForReduceAnimalExtinctionPage(),
                    GoVeganTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceGoVeganTitleNameReferenceForReduceAnimalExtinctionPage(),
                    GoVeganPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceGoVeganPara1NameReferenceForReduceAnimalExtinctionPage(),
                    SignAPetitionTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceSignAPetitionTitleNameReferenceForReduceAnimalExtinctionPage(),
                    SignAPetitionPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceSignAPetitionPara1NameReferenceForReduceAnimalExtinctionPage(),
                    WhatDidYouExpectPara = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceAnimalExtinctionPage(),
                    LearnMore = _locSourceHomePageNameReferenceLibrary.GetLocSourceCarbonClockLearnMoreLabelNameReference(),
                    Rhinoicon1 = _ReduceAnimalExtinctionPageImageUrlLibrary.GetRhinoicon1ThumbnailUrlForReduceAnimalExtinctionPage(),
                    Rhinoicon2 = _ReduceAnimalExtinctionPageImageUrlLibrary.GetRhinoicon2ThumbnailUrlForReduceAnimalExtinctionPage(),
                    Rhinoicon3 = _ReduceAnimalExtinctionPageImageUrlLibrary.GetRhinoicon3ThumbnailUrlForReduceAnimalExtinctionPage(),
                    Rhinoicon4 = _ReduceAnimalExtinctionPageImageUrlLibrary.GetRhinoicon4ThumbnailUrlForReduceAnimalExtinctionPage(),
                    Rhinoicon5 = _ReduceAnimalExtinctionPageImageUrlLibrary.GetRhinoicon5ThumbnailUrlForReduceAnimalExtinctionPage(),
                    MouseClickIconThumbnailUrl = _ReduceAnimalExtinctionPageImageUrlLibrary.GetMouseClickIconThumbnailUrlForReduceAnimalExtinctionPage(),
                    HandTapIconThumbnailUrl = _ReduceAnimalExtinctionPageImageUrlLibrary.GetHandTapIconThumbnailUrlForReduceAnimalExtinctionPage(),
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
                    MyImpactFamilySizes = actionsList[1],
                    MyImpactMinimisePlastic = actionsList[2],
                    MyImpactGoVegetarian = actionsList[3],
                    MyImpactGoVegan = actionsList[4],
                    MyImpactHabitatRestoration = actionsList[5],
                    MyImpactWildlifeRefuge = actionsList[6],
                    MyImpactStandUp = actionsList[7],
                    MyImpactHerbsAndPesticides = actionsList[8],
                    MyImpactSlowDown = actionsList[9],
                    MyImpactPlantNativePlants = actionsList[10],
                    MyImpactGreenRecovery = actionsList[11],
                    MyImpactBuyRecycled = actionsList[12],
                    MyImpactRecyclingBin = actionsList[13],
                    MyImpactSignPetition = actionsList[14],
                    SiteImpactTotal = totalActionsList[0],
                    RAEImpactTotal = totalActionsList[1],
                    AllUsersCO2ImpactTotal = totalActionsList[2] + " kg Co2e",
                    UserImpactTotal = totalActionsList[3],
                    RAEMyCO2ImpactTotal = totalActionsList[4] + " kg Co2e",
                    SiteImpactTitle = _locSourceSharedCrossPageNameReferenceLibrary.GetSiteTotalActionsTitle(),
                    RAEImpactTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetTotalActionsTitleForArea(),
                    UserImpactTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetUserTotalActionsTitleForReduceAnimalExtinctionPage(),
                    RAEMyCO2ImpactTitle = _locSourceSharedCrossPageNameReferenceLibrary.GetMyCO2ImpactTitleForPage(),
                    CanopyProjectUrl = _URLStringsUrlLibrary.GetCanopyProjectUrl(),
                    ComingSoon = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceComingSoonLabelNameReference(),
                    LikeToSee = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLikeToSeeLabelNameReference(),
                    AllUserActionsIcon = _SharedCrossPageImageUrlLibrary.GetAllUserActionsIconUrlForPage(),
                    AllUserRAEActionsIcon = _SharedCrossPageImageUrlLibrary.GetRGWImpactIconUrlForPages(),
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
                    GlobalWarmingAllUsersShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20have%20taken%20" + totalActionsList[1] + "%20actions%20to%20help%20save%20us%20from%20climate%20change!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                    AllUsersCO2MyShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20have%20reduced%20their%20CO2%20output%20to%20date%20by%20" + totalActionsList[2] + "kg%20Co2e%20to%20help%20save%20us%20from%20climate%20change!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                    TotalActionsMyShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=I%20have%20taken%20" + totalActionsList[3] + "%20actions%20to%20help%20save%20the%20world!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                    CO2ReductionMyShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=I%20have%20reduced%20my%20CO2%20output%20to%20date%20by%20" + totalActionsList[4] + "kg%20Co2e%20to%20help%20save%20us%20from%20climate%20change!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                    ClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceClickDetailsNameReferenceForPage(),
                    ReduceMeatClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceReduceMeatClickDetailsNameReferenceForPage(),
                    FamilySizesClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceFamilySizesClickDetailsNameReferenceForPage(),
                    MinimisePlasticClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceMinimisePlasticClickDetailsNameReferenceForPage(),
                    GoVegetarianClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceGoVegetarianClickDetailsNameReferenceForPage(),
                    GoVeganClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceGoVeganClickDetailsNameReferenceForPage(),
                    NotQuantifiableClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    RecyclingBinClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceRecyclingBinClickDetailsNameReferenceForPage(),
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
                    RAEpageShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cextinction%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2Fen%2FReduceAnimalExtinction%2FReduceAnimalExtinction%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20are%20taking%20action%20to%20help%20reduce%20animal%20extinction!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com%2Fen%2FReduceAnimalExtinction%2FReduceAnimalExtinction",
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
                var viewModel = new ReduceAnimalExtinctionViewModel
                {
                    PageTabTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForReduceAnimalExtinctionPage(),
                    ButtonText = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceButtonTextNameReference(),
                    Title = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForReduceAnimalExtinctionPage(),
                    Subtitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForReduceAnimalExtinctionPage(),
                    DoSomethingTodayTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceDoSomethingTodayTitleNameReferenceForReduceAnimalExtinctionPage(),
                    DoSomethingTodayPara = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceDoSomethingTodayParaNameReferenceForReduceAnimalExtinctionPage(),
                    WhatCanIDo = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceWhatCanIDoNameReferenceForReduceAnimalExtinctionPage(),
                    Information = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceInformationNameReferenceForReduceAnimalExtinctionPage(),
                    Impact = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceImpactNameReferenceForReduceAnimalExtinctionPage(),
                    IDidThisToday = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceDidThisTodayNameReferenceForReduceAnimalExtinctionPage(),
                    MyImpact = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceMyImpactNameReferenceForReduceAnimalExtinctionPage(),
                    ReduceMeatIntakeTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceReduceMeatIntakeTitleNameReferenceForReduceAnimalExtinctionPage(),
                    ReduceMeatIntakePara2 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceReduceMeatIntakePara2NameReferenceForReduceAnimalExtinctionPage(),
                    SixtyPercent = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceSixtyPercentLabelNameReference(),
                    ReducedFamilySizesTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceReducedFamilySizesTitleNameReferenceForReduceAnimalExtinctionPage(),
                    ReducedFamilySizesPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceReducedFamilySizesPara1NameReferenceForReduceAnimalExtinctionPage(),
                    ReducedFamilySizesPara2 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceReducedFamilySizesPara2NameReferenceForReduceAnimalExtinctionPage(),
                    WildlifeRefugeTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceWildlifeRefugeTitleNameReferenceForReduceAnimalExtinctionPage(),
                    WildlifeRefugePara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceWildlifeRefugePara1NameReferenceForReduceAnimalExtinctionPage(),
                    WildlifeRefugePara2 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceWildlifeRefugePara2NameReferenceForReduceAnimalExtinctionPage(),
                    HerbsAndPesticidesTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceHerbsAndPesticidesTitleNameReferenceForReduceAnimalExtinctionPage(),
                    HerbsAndPesticidesPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceHerbsAndPesticidesPara1NameReferenceForReduceAnimalExtinctionPage(),
                    HerbsAndPesticidesPara2 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceHerbsAndPesticidesPara2NameReferenceForReduceAnimalExtinctionPage(),
                    SupportHabitatRestorationTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceSupportHabitatRestorationTitleNameReferenceForReduceAnimalExtinctionPage(),
                    SupportHabitatRestorationPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceSupportHabitatRestorationPara1NameReferenceForReduceAnimalExtinctionPage(),
                    SupportHabitatRestorationPara2 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceSupportHabitatRestorationPara2NameReferenceForReduceAnimalExtinctionPage(),
                    SlowDownTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceSlowDownTitleNameReferenceForReduceAnimalExtinctionPage(),
                    SlowDownPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceSlowDownPara1NameReferenceForReduceAnimalExtinctionPage(),
                    PlantNativePlantsTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourcePlantNativePlantsTitleNameReferenceForReduceAnimalExtinctionPage(),
                    PlantNativePlants = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourcePlantNativePlantsPara1NameReferenceForReduceAnimalExtinctionPage(),
                    GreenRecoveryTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceGreenRecoveryTitleNameReferenceForReduceAnimalExtinctionPage(),
                    GreenRecoveryPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceGreenRecoveryPara1NameReferenceForReduceAnimalExtinctionPage(),
                    MinimisePlasticTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceMinimisePlasticTitleNameReferenceForReduceAnimalExtinctionPage(),
                    MinimisePlasticPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceMinimisePlasticPara1NameReferenceForReduceAnimalExtinctionPage(),
                    BuyRecycledTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceBuyRecycledTitleNameReferenceForReduceAnimalExtinctionPage(),
                    BuyRecycledPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceBuyRecycledPara1NameReferenceForReduceAnimalExtinctionPage(),
                    StandUp = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceStandUpNameReferenceForReduceAnimalExtinctionPage(),
                    StandUpPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceStandUpPara1NameReferenceForReduceAnimalExtinctionPage(),
                    UseARecyclingBinTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceUseARecyclingBinTitleNameReferenceForReduceAnimalExtinctionPage(),
                    UseARecyclingBinPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceUseARecyclingBinPara1NameReferenceForReduceAnimalExtinctionPage(),
                    GoVegetarianTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceGoVegetarianTitleNameReferenceForReduceAnimalExtinctionPage(),
                    GoVegetarianPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceGoVegetarianPara1NameReferenceForReduceAnimalExtinctionPage(),
                    GoVeganTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceGoVeganTitleNameReferenceForReduceAnimalExtinctionPage(),
                    GoVeganPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceGoVeganPara1NameReferenceForReduceAnimalExtinctionPage(),
                    SignAPetitionTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceSignAPetitionTitleNameReferenceForReduceAnimalExtinctionPage(),
                    SignAPetitionPara1 = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceSignAPetitionPara1NameReferenceForReduceAnimalExtinctionPage(),
                    WhatDidYouExpectPara = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceAnimalExtinctionPage(),
                    LearnMore = _locSourceHomePageNameReferenceLibrary.GetLocSourceCarbonClockLearnMoreLabelNameReference(),
                    Rhinoicon1 = _ReduceAnimalExtinctionPageImageUrlLibrary.GetRhinoicon1ThumbnailUrlForReduceAnimalExtinctionPage(),
                    Rhinoicon2 = _ReduceAnimalExtinctionPageImageUrlLibrary.GetRhinoicon2ThumbnailUrlForReduceAnimalExtinctionPage(),
                    Rhinoicon3 = _ReduceAnimalExtinctionPageImageUrlLibrary.GetRhinoicon3ThumbnailUrlForReduceAnimalExtinctionPage(),
                    Rhinoicon4 = _ReduceAnimalExtinctionPageImageUrlLibrary.GetRhinoicon4ThumbnailUrlForReduceAnimalExtinctionPage(),
                    Rhinoicon5 = _ReduceAnimalExtinctionPageImageUrlLibrary.GetRhinoicon5ThumbnailUrlForReduceAnimalExtinctionPage(),
                    MouseClickIconThumbnailUrl = _ReduceAnimalExtinctionPageImageUrlLibrary.GetMouseClickIconThumbnailUrlForReduceAnimalExtinctionPage(),
                    HandTapIconThumbnailUrl = _ReduceAnimalExtinctionPageImageUrlLibrary.GetHandTapIconThumbnailUrlForReduceAnimalExtinctionPage(),
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
                    MyImpactFamilySizes = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactMinimisePlastic = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactGoVegetarian = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactGoVegan = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactHabitatRestoration = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactWildlifeRefuge = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactStandUp = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactHerbsAndPesticides = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactSlowDown = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactPlantNativePlants = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactGreenRecovery = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactBuyRecycled = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactRecyclingBin = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactSignPetition = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    SiteImpactTotal = totalActionsList[0],
                    RAEImpactTotal = totalActionsList[1],
                    AllUsersCO2ImpactTotal = totalActionsList[2] + " kg Co2e",
                    RAEMyCO2ImpactTotal = "0",
                    UserImpactTotal = "0 kg Co2e",
                    SiteImpactTitle = _locSourceSharedCrossPageNameReferenceLibrary.GetSiteTotalActionsTitle(),
                    RAEImpactTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetTotalActionsTitleForArea(),
                    UserImpactTitle = _locSourceReduceAnimalExtinctionPageNameReferenceLibrary.GetUserTotalActionsTitleForReduceAnimalExtinctionPage(),
                    RAEMyCO2ImpactTitle = _locSourceSharedCrossPageNameReferenceLibrary.GetMyCO2ImpactTitleForPage(),
                    CanopyProjectUrl = _URLStringsUrlLibrary.GetCanopyProjectUrl(),
                    ComingSoon = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceComingSoonLabelNameReference(),
                    LikeToSee = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLikeToSeeLabelNameReference(),
                    AllUserActionsIcon = _SharedCrossPageImageUrlLibrary.GetAllUserActionsIconUrlForPage(),
                    AllUserRAEActionsIcon = _SharedCrossPageImageUrlLibrary.GetRGWImpactIconUrlForPages(),
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
                    GlobalWarmingAllUsersShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20have%20taken%20" + totalActionsList[1] + "%20actions%20to%20help%20save%20us%20from%20the%20animal%20extinction%20crises!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                    AllUsersCO2MyShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20have%20reduced%20their%20CO2%20output%20to%20date%20by%20" + totalActionsList[2] + "kg%20Co2e%20to%20help%20save%20us%20from%20climate%20change!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                    TotalActionsMyShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=I%20have%20taken%20" + totalActionsList[3] + "%20actions%20to%20help%20save%20the%20world!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                    CO2ReductionMyShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=I%20have%20reduced%20my%20CO2%20output%20to%20date%20by%20" + totalActionsList[4] + "kg%20Co2e%20to%20help%20save%20us%20from%20climate%20change!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                    ClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceClickDetailsNameReferenceForPage(),
                    ReduceMeatClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceReduceMeatClickDetailsNameReferenceForPage(),
                    FamilySizesClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceFamilySizesClickDetailsNameReferenceForPage(),
                    MinimisePlasticClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceMinimisePlasticClickDetailsNameReferenceForPage(),
                    GoVegetarianClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceGoVegetarianClickDetailsNameReferenceForPage(),
                    GoVeganClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceGoVeganClickDetailsNameReferenceForPage(),
                    NotQuantifiableClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    RecyclingBinClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceRecyclingBinClickDetailsNameReferenceForPage(),
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
                    RAEpageShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cextinction%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2Fen%2FReduceAnimalExtinction%2FReduceAnimalExtinction%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20are%20taking%20action%20to%20help%20reduce%20animal%20extinction!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com%2Fen%2FReduceAnimalExtinction%2FReduceAnimalExtinction",
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

        public async Task <IActionResult> RAEInsertNewActionNumber(int actionNumber)
        {
            string userId = ClaimsPrincipalExtensions.GetUserId<string>(User);
            await RAEIncrementClicks.UserClick(actionNumber, userId, _context);

            return RedirectToAction("ReduceAnimalExtinction");
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
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "RAE Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "RAE Page Newsfeed Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "RAE Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "RAE Page Newsfeed Modal", FeedbackDateTime);
                }
            }

            return RedirectToAction("ReduceAnimalExtinction");
        }
    }
}