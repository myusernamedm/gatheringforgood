using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using GatheringForGood.Models;
using LocSourceNameReferenceLibrary;
using ImageUrlReferenceLibrary;
using URLStringsReferenceLibrary;
using GatheringForGood.Areas.FunctionalLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using GatheringForGood.Data;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace GatheringForGood.Controllers
{
    public class ReduceGlobalWarmingController : Controller
    {
        readonly HomePageLocSourceNames _locSourceHomePageNameReferenceLibrary = new();
        HomePageImageUrls _HomePageImageUrlLibrary = new HomePageImageUrls();
        readonly ReduceGlobalWarmingPageLocSourceNames _locSourceReduceGlobalWarmingPageNameReferenceLibrary = new();
        readonly SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new();
        readonly ReduceGlobalWarmingPageImageUrls _ReduceGlobalWarmingPageImageUrlLibrary = new();
        readonly SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();
        readonly UrlStrings _URLStringsUrlLibrary = new();
        readonly RGWIncrementUserActionClicks RGWIncrementClicks = new();
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _context;

        public ReduceGlobalWarmingController(IEmailSender emailSender, ApplicationDbContext context)
        {
            _emailSender = emailSender;
            _context = context;
        }

        [HttpGet]
        public IActionResult ReduceGlobalWarming()
        {
            string userId = ClaimsPrincipalExtensions.GetUserId<string>(User);
            List<string> totalActionsList;
            List<string> actionsList = RGWGetUserActionClicks.GetClicks(userId);
            int actionsListCount = actionsList.Count();

            if (actionsListCount > 1)
            {
                totalActionsList = RGWGetClickTotals.GetTotalClicks(userId, true);
            }
            else
            {
                totalActionsList = RGWGetClickTotals.GetTotalClicks(userId, false);
            }

            if (actionsListCount > 0)
            {
                var viewModel = new ReduceGlobalWarmingViewModel
                {
                    PageTabTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForReduceGlobalWarmingPage(),
                    ButtonText = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceButtonTextNameReference(),
                    Title = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForReduceGlobalWarmingPage(),
                    Subtitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForReduceGlobalWarmingPage(),
                    DoSomethingTodayTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceDoSomethingTodayTitleNameReferenceForReduceGlobalWarmingPage(),
                    DoSomethingTodayPara = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceDoSomethingTodayParaNameReferenceForReduceGlobalWarmingPage(),
                    DoSomethingTodayPara2 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceDoSomethingTodayPara2NameReferenceForReduceGlobalWarmingPage(),
                    WhatCanIDo = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceWhatCanIDoNameReferenceForReduceGlobalWarmingPage(),
                    Information = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceInformationNameReferenceForReduceGlobalWarmingPage(),
                    Impact = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceImpactNameReferenceForReduceGlobalWarmingPage(),
                    IDidThisToday = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceDidThisTodayNameReferenceForReduceGlobalWarmingPage(),
                    MyImpact = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceMyImpactNameReferenceForReduceGlobalWarmingPage(),
                    ReduceMeatIntakeTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceReduceMeatIntakeTitleNameReferenceForReduceGlobalWarmingPage(),
                    ReduceMeatIntakePara2 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceReduceMeatIntakePara2NameReferenceForReduceGlobalWarmingPage(),
                    SixtyPercent = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceSixtyPercentLabelNameReference(),
                    PlantSomeTreesTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourcePlantSomeTreesTitleNameReferenceForReduceGlobalWarmingPage(),
                    PlantSomeTreesPara2 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourcePlantSomeTreesPara2NameReferenceForReduceGlobalWarmingPage(),
                    PlantSomeTreesPara3 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourcePlantSomeTreesPara3NameReferenceForReduceGlobalWarmingPage(),
                    EatOrganicTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceEatOrganicTitleNameReferenceForReduceGlobalWarmingPage(),
                    EatOrganicPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceEatOrganicPara1NameReferenceForReduceGlobalWarmingPage(),
                    GoVegetarianTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceGoVegetarianTitleNameReferenceForReduceGlobalWarmingPage(),
                    GoVegetarianPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceGoVegetarianPara1NameReferenceForReduceGlobalWarmingPage(),
                    GoVeganTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceGoVeganTitleNameReferenceForReduceGlobalWarmingPage(),
                    GoVeganPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceGoVeganPara1NameReferenceForReduceGlobalWarmingPage(),
                    LiveCarFreeTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceLiveCarFreeTitleNameReferenceForReduceGlobalWarmingPage(),
                    LiveCarFree = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceLiveCarFreePara1NameReferenceForReduceGlobalWarmingPage(),
                    GreenRecoveryTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceGreenRecoveryTitleNameReferenceForReduceGlobalWarmingPage(),
                    GreenRecoveryPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceGreenRecoveryPara1NameReferenceForReduceGlobalWarmingPage(),
                    MinimisePlasticTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceMinimisePlasticTitleNameReferenceForReduceGlobalWarmingPage(),
                    MinimisePlasticPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceMinimisePlasticPara1NameReferenceForReduceGlobalWarmingPage(),
                    BuyLocalTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceBuyLocalTitleNameReferenceForReduceGlobalWarmingPage(),
                    BuyLocal = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceBuyLocalNameReferenceForReduceGlobalWarmingPage(),
                    CycleTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceCycleTitleNameReferenceForReduceGlobalWarmingPage(),
                    IncreaseCycling = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceIncreaseCyclingPara1NameReferenceForReduceGlobalWarmingPage(),
                    DriveElectricTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceDriveElectricTitleNameReferenceForReduceGlobalWarmingPage(),
                    DriveElectricPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceDriveElectricPara1NameReferenceForReduceGlobalWarmingPage(),
                    PlantYourOwnVegTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourcePlantYourOwnVegTitleNameReferenceForReduceGlobalWarmingPage(),
                    PlantYourOwnVegPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourcePlantYourOwnVegPara1NameReferenceForReduceGlobalWarmingPage(),
                    SwitchToRenewableTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceSwitchToRenewableTitleNameReferenceForReduceGlobalWarmingPage(),
                    SwitchToRenewablePara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceSwitchToRenewablePara1NameReferenceForReduceGlobalWarmingPage(),
                    UsePublicTransportTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceUsePublicTransportTitleNameReferenceForReduceGlobalWarmingPage(),
                    IncreasePublicTransport1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceIncreasePublicTransportPara1NameReferenceForReduceGlobalWarmingPage(),
                    IncreasePublicTransport2 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceIncreasePublicTransportPara2NameReferenceForReduceGlobalWarmingPage(),
                    CarPoolTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceCarpoolTitleNameReferenceForReduceGlobalWarmingPage(),
                    IncreaseCarpooling = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceIncreaseCarpoolingPara1NameReferenceForReduceGlobalWarmingPage(),
                    FlyLessOftenTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceFlyLessOftenTitleNameReferenceForReduceGlobalWarmingPage(),
                    FlyLessOftenPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceFlyLessOftenPara1NameReferenceForReduceGlobalWarmingPage(),
                    StandUp = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceStandUpNameReferenceForReduceGlobalWarmingPage(),
                    StandUpPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceStandUpPara1NameReferenceForReduceGlobalWarmingPage(),
                    UseABlueRecyclingBinTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceUseABlueRecyclingBinTitleNameReferenceForReduceGlobalWarmingPage(),
                    UseABlueRecyclingBinPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceUseABlueRecyclingBinPara1NameReferenceForReduceGlobalWarmingPage(),
                    UseABrownCompostBinTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceUseABrownCompostBinTitleNameReferenceForReduceGlobalWarmingPage(),
                    UseABrownCompostBinPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceUseABrownCompostBinPara1NameReferenceForReduceGlobalWarmingPage(),
                    InsulateYourHouseTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceInsulateYourHouseTitleNameReferenceForReduceGlobalWarmingPage(),
                    InsulateYourHousePara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceInsulateYourHousePara1NameReferenceForReduceGlobalWarmingPage(),
                    ShorterShowers = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceShorterShowersNameReferenceForReduceGlobalWarmingPage(),
                    ShorterShowersPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceShorterShowersPara1NameReferenceForReduceGlobalWarmingPage(),
                    FluorescentLightbulbs = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceFluorescentLightbulbsNameReferenceForReduceGlobalWarmingPage(),
                    FluorescentLightbulbsPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceFluorescentLightbulbsPara1NameReferenceForReduceGlobalWarmingPage(),
                    TurnOffLights = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceTurnOffLightsNameReferenceForReduceGlobalWarmingPage(),
                    TurnOffLightsPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceTurnOffLightsPara1NameReferenceForReduceGlobalWarmingPage(),
                    SignAPetitionTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceSignAPetitionTitleNameReferenceForReduceGlobalWarmingPage(),
                    SignAPetitionPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceSignAPetitionPara1NameReferenceForReduceGlobalWarmingPage(),
                    WhatDidYouExpectPara = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage(),
                    LearnMore = _locSourceHomePageNameReferenceLibrary.GetLocSourceCarbonClockLearnMoreLabelNameReference(),
                    Co2icon1 = _ReduceGlobalWarmingPageImageUrlLibrary.GetCo2icon1ThumbnailUrlForReduceGlobalWarmingPage(),
                    Co2icon2 = _ReduceGlobalWarmingPageImageUrlLibrary.GetCo2icon2ThumbnailUrlForReduceGlobalWarmingPage(),
                    Co2icon3 = _ReduceGlobalWarmingPageImageUrlLibrary.GetCo2icon3ThumbnailUrlForReduceGlobalWarmingPage(),
                    Co2icon4 = _ReduceGlobalWarmingPageImageUrlLibrary.GetCo2icon4ThumbnailUrlForReduceGlobalWarmingPage(),
                    Co2icon5 = _ReduceGlobalWarmingPageImageUrlLibrary.GetCo2icon5ThumbnailUrlForReduceGlobalWarmingPage(),
                    MouseClickIconThumbnailUrl = _ReduceGlobalWarmingPageImageUrlLibrary.GetMouseClickIconThumbnailUrlForReduceGlobalWarmingPage(),
                    HandTapIconThumbnailUrl = _ReduceGlobalWarmingPageImageUrlLibrary.GetHandTapIconThumbnailUrlForReduceGlobalWarmingPage(),
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
                    MyImpactPlantTrees = actionsList[1],
                    MyImpactEatOrganic = actionsList[2],
                    MyImpactGoVegetarian = actionsList[3],
                    MyImpactGoVegan = actionsList[4],
                    MyImpactLiveCarFree = actionsList[5],
                    MyImpactGreenRecovery = actionsList[6],
                    MyImpactMinimisePlastic = actionsList[7],
                    MyImpactBuyLocal = actionsList[8],
                    MyImpactCycle = actionsList[9],
                    MyImpactDriveElectric = actionsList[10],
                    MyImpactPlantOwnVeg = actionsList[11],
                    MyImpactSwitchRenewable = actionsList[12],
                    MyImpactPublicTransport = actionsList[13],
                    MyImpactCarPool = actionsList[14],
                    MyImpactFlyLess = actionsList[15],
                    MyImpactStandUp = actionsList[16],
                    MyImpactRecyclingBin = actionsList[17],
                    MyImpactCompostBin = actionsList[18],
                    MyImpactInsulateHouse = actionsList[19],
                    MyImpactShorterShowers = actionsList[20],
                    MyImpactFluorescent = actionsList[21],
                    MyImpactTurnOffLights = actionsList[22],
                    MyImpactSignPetition = actionsList[23],
                    SiteImpactTotal = totalActionsList[0],
                    RGWImpactTotal = totalActionsList[1],
                    AllUsersCO2ImpactTotal = totalActionsList[2] + " kg Co2e",
                    UserImpactTotal = totalActionsList[3],
                    RGWMyCO2ImpactTotal = totalActionsList[4] + " kg Co2e",
                    SiteImpactTitle = _locSourceSharedCrossPageNameReferenceLibrary.GetSiteTotalActionsTitle(),
                    RGWImpactTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetTotalActionsTitleForArea(),
                    UserImpactTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetUserTotalActionsTitleForReduceGlobalWarmingPage(),
                    RGWMyCO2ImpactTitle = _locSourceSharedCrossPageNameReferenceLibrary.GetMyCO2ImpactTitleForPage(),
                    CanopyProjectUrl = _URLStringsUrlLibrary.GetCanopyProjectUrl(),
                    ComingSoon = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceComingSoonLabelNameReference(),
                    LikeToSee = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLikeToSeeLabelNameReference(),
                    AllUserActionsIcon = _SharedCrossPageImageUrlLibrary.GetAllUserActionsIconUrlForPage(),
                    AllUserRGWActionsIcon = _SharedCrossPageImageUrlLibrary.GetRGWImpactIconUrlForPages(),
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
                    MinimisePlasticClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceMinimisePlasticClickDetailsNameReferenceForPage(),
                    GoVegetarianClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceGoVegetarianClickDetailsNameReferenceForPage(),
                    GoVeganClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceGoVeganClickDetailsNameReferenceForPage(),
                    NotQuantifiableClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    PlantSomeTreesClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourcePlantSomeTreesClickDetailsNameReferenceForPage(),
                    EatOrganicClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceEatOrganicClickDetailsNameReferenceForPage(),
                    LiveCarFreeClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLiveCarFreeClickDetailsNameReferenceForPage(),
                    BuyLocalClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceBuyLocalClickDetailsNameReferenceForPage(),
                    CycleClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceCycleClickDetailsNameReferenceForPage(),
                    DriveElectricClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceDriveElectricClickDetailsNameReferenceForPage(),
                    PlantYourOwnVegClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourcePlantYourOwnVegClickDetailsNameReferenceForPage(),
                    UsePublicTransportClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceUsePublicTransportClickDetailsNameReferenceForPage(),
                    CarpoolClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceCarpoolClickDetailsNameReferenceForPage(),
                    InsulateYourHouseClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceInsulateYourHouseClickDetailsNameReferenceForPage(),
                    ShorterShowersClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceShorterShowersClickDetailsNameReferenceForPage(),
                    FluorescentLightbulbsClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceFluorescentLightbulbsClickDetailsNameReferenceForPage(),
                    TurnOffLightsClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceTurnOffLightsClickDetailsNameReferenceForPage(),
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
                    RGWpageShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2Fen%2FReduceGlobalWarming%2FReduceGlobalWarming%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20are%20taking%20action%20to%20help%20reduce%20global%20warming!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com%2Fen%2FReduceGlobalWarming%2FReduceGlobalWarming",
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
                var viewModel = new ReduceGlobalWarmingViewModel
                {
                    PageTabTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForReduceGlobalWarmingPage(),
                    ButtonText = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceButtonTextNameReference(),
                    Title = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForReduceGlobalWarmingPage(),
                    Subtitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForReduceGlobalWarmingPage(),
                    DoSomethingTodayTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceDoSomethingTodayTitleNameReferenceForReduceGlobalWarmingPage(),
                    DoSomethingTodayPara = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceDoSomethingTodayParaNameReferenceForReduceGlobalWarmingPage(),
                    WhatCanIDo = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceWhatCanIDoNameReferenceForReduceGlobalWarmingPage(),
                    Information = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceInformationNameReferenceForReduceGlobalWarmingPage(),
                    Impact = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceImpactNameReferenceForReduceGlobalWarmingPage(),
                    IDidThisToday = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceDidThisTodayNameReferenceForReduceGlobalWarmingPage(),
                    MyImpact = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceMyImpactNameReferenceForReduceGlobalWarmingPage(),
                    ReduceMeatIntakeTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceReduceMeatIntakeTitleNameReferenceForReduceGlobalWarmingPage(),
                    ReduceMeatIntakePara2 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceReduceMeatIntakePara2NameReferenceForReduceGlobalWarmingPage(),
                    SixtyPercent = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceSixtyPercentLabelNameReference(),
                    PlantSomeTreesTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourcePlantSomeTreesTitleNameReferenceForReduceGlobalWarmingPage(),
                    PlantSomeTreesPara2 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourcePlantSomeTreesPara2NameReferenceForReduceGlobalWarmingPage(),
                    PlantSomeTreesPara3 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourcePlantSomeTreesPara3NameReferenceForReduceGlobalWarmingPage(),
                    EatOrganicTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceEatOrganicTitleNameReferenceForReduceGlobalWarmingPage(),
                    EatOrganicPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceEatOrganicPara1NameReferenceForReduceGlobalWarmingPage(),
                    GoVegetarianTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceGoVegetarianTitleNameReferenceForReduceGlobalWarmingPage(),
                    GoVegetarianPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceGoVegetarianPara1NameReferenceForReduceGlobalWarmingPage(),
                    GoVeganTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceGoVeganTitleNameReferenceForReduceGlobalWarmingPage(),
                    GoVeganPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceGoVeganPara1NameReferenceForReduceGlobalWarmingPage(),
                    LiveCarFreeTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceLiveCarFreeTitleNameReferenceForReduceGlobalWarmingPage(),
                    LiveCarFree = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceLiveCarFreePara1NameReferenceForReduceGlobalWarmingPage(),
                    GreenRecoveryTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceGreenRecoveryTitleNameReferenceForReduceGlobalWarmingPage(),
                    GreenRecoveryPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceGreenRecoveryPara1NameReferenceForReduceGlobalWarmingPage(),
                    MinimisePlasticTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceMinimisePlasticTitleNameReferenceForReduceGlobalWarmingPage(),
                    MinimisePlasticPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceMinimisePlasticPara1NameReferenceForReduceGlobalWarmingPage(),
                    BuyLocalTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceBuyLocalTitleNameReferenceForReduceGlobalWarmingPage(),
                    BuyLocal = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceBuyLocalNameReferenceForReduceGlobalWarmingPage(),
                    CycleTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceCycleTitleNameReferenceForReduceGlobalWarmingPage(),
                    IncreaseCycling = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceIncreaseCyclingPara1NameReferenceForReduceGlobalWarmingPage(),
                    DriveElectricTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceDriveElectricTitleNameReferenceForReduceGlobalWarmingPage(),
                    DriveElectricPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceDriveElectricPara1NameReferenceForReduceGlobalWarmingPage(),
                    PlantYourOwnVegTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourcePlantYourOwnVegTitleNameReferenceForReduceGlobalWarmingPage(),
                    PlantYourOwnVegPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourcePlantYourOwnVegPara1NameReferenceForReduceGlobalWarmingPage(),
                    SwitchToRenewableTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceSwitchToRenewableTitleNameReferenceForReduceGlobalWarmingPage(),
                    SwitchToRenewablePara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceSwitchToRenewablePara1NameReferenceForReduceGlobalWarmingPage(),
                    UsePublicTransportTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceUsePublicTransportTitleNameReferenceForReduceGlobalWarmingPage(),
                    IncreasePublicTransport1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceIncreasePublicTransportPara1NameReferenceForReduceGlobalWarmingPage(),
                    IncreasePublicTransport2 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceIncreasePublicTransportPara2NameReferenceForReduceGlobalWarmingPage(),
                    CarPoolTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceCarpoolTitleNameReferenceForReduceGlobalWarmingPage(),
                    IncreaseCarpooling = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceIncreaseCarpoolingPara1NameReferenceForReduceGlobalWarmingPage(),
                    FlyLessOftenTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceFlyLessOftenTitleNameReferenceForReduceGlobalWarmingPage(),
                    FlyLessOftenPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceFlyLessOftenPara1NameReferenceForReduceGlobalWarmingPage(),
                    StandUp = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceStandUpNameReferenceForReduceGlobalWarmingPage(),
                    StandUpPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceStandUpPara1NameReferenceForReduceGlobalWarmingPage(),
                    UseABlueRecyclingBinTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceUseABlueRecyclingBinTitleNameReferenceForReduceGlobalWarmingPage(),
                    UseABlueRecyclingBinPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceUseABlueRecyclingBinPara1NameReferenceForReduceGlobalWarmingPage(),
                    UseABrownCompostBinTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceUseABrownCompostBinTitleNameReferenceForReduceGlobalWarmingPage(),
                    UseABrownCompostBinPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceUseABrownCompostBinPara1NameReferenceForReduceGlobalWarmingPage(),
                    InsulateYourHouseTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceInsulateYourHouseTitleNameReferenceForReduceGlobalWarmingPage(),
                    InsulateYourHousePara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceInsulateYourHousePara1NameReferenceForReduceGlobalWarmingPage(),
                    ShorterShowers = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceShorterShowersNameReferenceForReduceGlobalWarmingPage(),
                    ShorterShowersPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceShorterShowersPara1NameReferenceForReduceGlobalWarmingPage(),
                    FluorescentLightbulbs = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceFluorescentLightbulbsNameReferenceForReduceGlobalWarmingPage(),
                    FluorescentLightbulbsPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceFluorescentLightbulbsPara1NameReferenceForReduceGlobalWarmingPage(),
                    TurnOffLights = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceTurnOffLightsNameReferenceForReduceGlobalWarmingPage(),
                    TurnOffLightsPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceTurnOffLightsPara1NameReferenceForReduceGlobalWarmingPage(),
                    SignAPetitionTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceSignAPetitionTitleNameReferenceForReduceGlobalWarmingPage(),
                    SignAPetitionPara1 = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceSignAPetitionPara1NameReferenceForReduceGlobalWarmingPage(),
                    WhatDidYouExpectPara = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetLocSourceWhatDidYouExpectParaNameReferenceForReduceGlobalWarmingPage(),
                    LearnMore = _locSourceHomePageNameReferenceLibrary.GetLocSourceCarbonClockLearnMoreLabelNameReference(),
                    Co2icon1 = _ReduceGlobalWarmingPageImageUrlLibrary.GetCo2icon1ThumbnailUrlForReduceGlobalWarmingPage(),
                    Co2icon2 = _ReduceGlobalWarmingPageImageUrlLibrary.GetCo2icon2ThumbnailUrlForReduceGlobalWarmingPage(),
                    Co2icon3 = _ReduceGlobalWarmingPageImageUrlLibrary.GetCo2icon3ThumbnailUrlForReduceGlobalWarmingPage(),
                    Co2icon4 = _ReduceGlobalWarmingPageImageUrlLibrary.GetCo2icon4ThumbnailUrlForReduceGlobalWarmingPage(),
                    Co2icon5 = _ReduceGlobalWarmingPageImageUrlLibrary.GetCo2icon5ThumbnailUrlForReduceGlobalWarmingPage(),
                    MouseClickIconThumbnailUrl = _ReduceGlobalWarmingPageImageUrlLibrary.GetMouseClickIconThumbnailUrlForReduceGlobalWarmingPage(),
                    HandTapIconThumbnailUrl = _ReduceGlobalWarmingPageImageUrlLibrary.GetHandTapIconThumbnailUrlForReduceGlobalWarmingPage(),
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
                    MyImpactPlantTrees = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactEatOrganic = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactGoVegetarian = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactGoVegan = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactLiveCarFree = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactGreenRecovery = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactMinimisePlastic = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactBuyLocal = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactCycle = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactDriveElectric = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactPlantOwnVeg = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactSwitchRenewable = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactPublicTransport = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactCarPool = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactFlyLess = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactStandUp = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactRecyclingBin = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactCompostBin = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactInsulateHouse = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactShorterShowers = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactFluorescent = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactTurnOffLights = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    MyImpactSignPetition = _locSourceSharedCrossPageNameReferenceLibrary.GetEmptyString(),
                    SiteImpactTotal = totalActionsList[0],
                    RGWImpactTotal = totalActionsList[1],
                    AllUsersCO2ImpactTotal = totalActionsList[2] + " kg Co2e",
                    UserImpactTotal = "0 kg Co2e",
                    RGWMyCO2ImpactTotal = "0",
                    SiteImpactTitle = _locSourceSharedCrossPageNameReferenceLibrary.GetSiteTotalActionsTitle(),
                    RGWImpactTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetTotalActionsTitleForArea(),
                    UserImpactTitle = _locSourceReduceGlobalWarmingPageNameReferenceLibrary.GetUserTotalActionsTitleForReduceGlobalWarmingPage(),
                    RGWMyCO2ImpactTitle = _locSourceSharedCrossPageNameReferenceLibrary.GetMyCO2ImpactTitleForPage(),
                    CanopyProjectUrl = _URLStringsUrlLibrary.GetCanopyProjectUrl(),
                    ComingSoon = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceComingSoonLabelNameReference(),
                    LikeToSee = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLikeToSeeLabelNameReference(),
                    AllUserActionsIcon = _SharedCrossPageImageUrlLibrary.GetAllUserActionsIconUrlForPage(),
                    AllUserRGWActionsIcon = _SharedCrossPageImageUrlLibrary.GetRGWImpactIconUrlForPages(),
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
                    MinimisePlasticClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceMinimisePlasticClickDetailsNameReferenceForPage(),
                    GoVegetarianClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceGoVegetarianClickDetailsNameReferenceForPage(),
                    GoVeganClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceGoVeganClickDetailsNameReferenceForPage(),
                    NotQuantifiableClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNotQuantifiableClickDetailsNameReferenceForPage(),
                    PlantSomeTreesClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourcePlantSomeTreesClickDetailsNameReferenceForPage(),
                    EatOrganicClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceEatOrganicClickDetailsNameReferenceForPage(),
                    LiveCarFreeClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLiveCarFreeClickDetailsNameReferenceForPage(),
                    BuyLocalClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceBuyLocalClickDetailsNameReferenceForPage(),
                    CycleClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceCycleClickDetailsNameReferenceForPage(),
                    DriveElectricClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceDriveElectricClickDetailsNameReferenceForPage(),
                    PlantYourOwnVegClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourcePlantYourOwnVegClickDetailsNameReferenceForPage(),
                    UsePublicTransportClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceUsePublicTransportClickDetailsNameReferenceForPage(),
                    CarpoolClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceCarpoolClickDetailsNameReferenceForPage(),
                    InsulateYourHouseClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceInsulateYourHouseClickDetailsNameReferenceForPage(),
                    ShorterShowersClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceShorterShowersClickDetailsNameReferenceForPage(),
                    FluorescentLightbulbsClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceFluorescentLightbulbsClickDetailsNameReferenceForPage(),
                    TurnOffLightsClickDetails = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceTurnOffLightsClickDetailsNameReferenceForPage(),
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
                    RGWpageShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2Fen%2FReduceGlobalWarming%2FReduceGlobalWarming%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20are%20taking%20action%20to%20help%20reduce%20global%20warming!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com%2Fen%2FReduceGlobalWarming%2FReduceGlobalWarming",
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

        public async Task<IActionResult> RGWInsertNewActionNumber(int actionNumber)
        {
            string userId = ClaimsPrincipalExtensions.GetUserId<string>(User);
            await RGWIncrementClicks.UserClick(actionNumber, userId, _context);

            return RedirectToAction("ReduceGlobalWarming");
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
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "RGW Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "RGW Page Newsfeed Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "RGW Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "RGW Page Newsfeed Modal", FeedbackDateTime);
                }
            }

            return RedirectToAction("ReduceGlobalWarming");
        }
    }
}