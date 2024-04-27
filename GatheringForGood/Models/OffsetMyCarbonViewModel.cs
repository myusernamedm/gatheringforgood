using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Models
{
    public class OffsetMyCarbonViewModel
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
        public string GoBackButton { get; set; }
        public string NormalModeOfTransport { get; set; }
        public string CycleWalk { get; set; }
        public string CycleWalkPublic { get; set; }
        public string Public { get; set; }
        public string CycleWalkDrive { get; set; }
        public string PublicDrive { get; set; }
        public string Drive { get; set; }
        public string NextButton { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 2)]
        public string SelectedPercentValue { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 1)]
        public string SelectedRadio1 { get; set; }

        public string FlightProfileTitle { get; set; }
        public string NeverFly { get; set; }
        public string ShortHaulFly { get; set; }
        public string MediumHaulFly { get; set; }
        public string LongHaulFly { get; set; }
        public string PercentPublic { get; set; }
        public string PercentDriving { get; set; }
        public string ShortHaulFlyPerYear { get; set; }
        public string MediumHaulFlyPerYear { get; set; }
        public string LongHaulFlyPerYear { get; set; }
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
    }
}
