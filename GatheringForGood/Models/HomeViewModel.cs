using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Models
{
    public class HomeViewModel
    {
        public string PageTabTitle { get; set; }
        [TempData]
        public string StatusMessage { get; set; }
        public ViewDataDictionary ViewData { get; set; }
        public string ButtonText { get; set; }
        public string Title { get; set; }
        public string Subtitle1 { get; set; }
        public string Subtitle2 { get; set; }
        public string BlockTitleImageUrl { get; set; }
        public string ChromeLogoImageUrl { get; set; }
        public string DownloadChromeUrl { get; set; }
        public string HowCanIHelpLabel { get; set; }
        public string NavBarHome { get; set; }
        public string NavBarNewsfeed { get; set; }
        public string NavBarAbout { get; set; }
        public string NavBarHelpCenter { get; set; }
        public string NavBarRegister { get; set; }
        public string NavBarLogin { get; set; }
        public string NavBarLogout { get; set; }
        public string GreatestChallengeTitle { get; set; }
        public string GreatestChallengePara { get; set; }
        public string CarbonClockTitle { get; set; }
        public string CarbonClockPara1 { get; set; }
        public string CarbonClockPara2 { get; set; }
        public string CarbonClockLearnMore { get; set; }
        public string ExtinctionClockTitle { get; set; }
        public string ExtinctionClockPara1 { get; set; }
        public string ExtinctionClockPara2 { get; set; }
        public string ExtinctionClockLearnMore { get; set; }
        public string ForestClockTitle { get; set; }
        public string ForestClockPara1 { get; set; }
        public string ForestClockPara2 { get; set; }
        public string ForestClockLearnMore { get; set; }
        public string AboutUs { get; set; }
        public string Articles { get; set; }
        public string CookiesNotice { get; set; }
        public string PrivacyNotice { get; set; }
        public string TimeUntilTitle { get; set; }
        public string ExtinctionsSinceTitle { get; set; }
        public string MostSpeciesLostTitle { get; set; }
        public string ForestLostSinceTitle { get; set; }
        public string AllForestLostTitle { get; set; }
        public string GFGLaunchedTitle { get; set; }
        public string OneHalfDegreeDepletedTitle { get; set; }
        public string TwoDegreeDepletedTitle { get; set; }
        public string NewsfeedCardTitle { get; set; }
        public string NewsfeedCardContent { get; set; }
        public string YourCauseCardTitle { get; set; }
        public string YourCauseCardContent { get; set; }
        public string RallyForGoodCardTitle { get; set; }
        public string RallyForGoodCardContent { get; set; }
        public string ArticlesCardTitle { get; set; }
        public string ArticlesCardContent { get; set; }
        public string CommunityCardTitle { get; set; }
        public string CommunityCardContent { get; set; }
        public string EventsCardTitle { get; set; }
        public string EventsCardContent { get; set; }
        public string FundraiseCardTitle { get; set; }
        public string FundraiseCardContent { get; set; }
        public string EducationCardTitle { get; set; }
        public string EducationCardContent { get; set; }
        public string BusinessCardTitle { get; set; }
        public string BusinessCardContent { get; set; }
        public string AcademyCardTitle { get; set; }
        public string AcademyCardContent { get; set; }
        public string AcademyJuniorCardTitle { get; set; }
        public string AcademyJuniorCardContent { get; set; }
        public string Submit { get; set; }
        public string ComingSoon { get; set; }
        public string LikeToSee { get; set; }
        public string NewsfeedIconImage { get; set; }
        public string NewsfeedIconText { get; set; }
        public string AgileIconText { get; set; }
        public string OffsetIconImage { get; set; }
        public string OffsetIconText { get; set; }
        public string ImpactIconImage { get; set; }
        public string ImpactIconText { get; set; }
        public string AgileIconImage { get; set; }
        public string ArticlesIconImage { get; set; }
        public string ArticlesIconText { get; set; }
        public string RDFIconImage { get; set; }
        public string RDFIconText { get; set; }
        public string RAEIconImage { get; set; }
        public string RAEIconText { get; set; }
        public string RGWIconImage { get; set; }
        public string RGWIconText { get; set; }
        public string BetaNoticeText { get; set; }
        public string BetaNoticeText1 { get; set; }
        public string BetaNoticeText2 { get; set; }
        public string CannotDependSolelyPara { get; set; }
        public string HomepageShare { get; set; }
        public string IconTwitter { get; set; }
        public string IconLinkedin { get; set; }
        public string IconFacebook { get; set; }
        public string Updates { get; set; }
        public string GetEarthHandsImageUrl { get; set; }
        public string GetEarthHands400ImageUrl { get; set; }
        public string GetEarthHands800ImageUrl { get; set; }
        public string GetEarthHands1200ImageUrl { get; set; }
        public string GetEarthHands1600ImageUrl { get; set; }
    }
}
