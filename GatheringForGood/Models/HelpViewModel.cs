using GatheringForGood.Areas.FunctionalLogic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Models
{
    public class HelpViewModel
    {
        public string PageTabTitle { get; set; }
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
        public string NewsfeedIconImage { get; set; }
        public string OffsetIconImage { get; set; }
        public string ImpactIconImage { get; set; }
        public string AgileIconImage { get; set; }
        public string ContactIconImage { get; set; }
        public string NewsfeedIconText { get; set; }
        public string OffsetIconText { get; set; }
        public string ImpactIconText { get; set; }
        public string AgileIconText { get; set; }
        public string ContactIconText { get; set; }
        public string Hello { get; set; }
        public string LetUsKnow { get; set; }
        public string IdeasOrSayHi { get; set; }
        public string Required { get; set; }
        public string RequiredMinMax1 { get; set; }
        public string RequiredMinMax2 { get; set; }
        public string NameHeading { get; set; }
        public string EmailHeading { get; set; }
        public string SubjectHeading { get; set; }
        public string ThoughtsHeading { get; set; }
        public string TandCHeading { get; set; }
        public string ArticlesIconImage { get; set; }
        public string ArticlesIconText { get; set; }
        public string RDFIconImage { get; set; }
        public string RDFIconText { get; set; }
        public string RAEIconImage { get; set; }
        public string RAEIconText { get; set; }
        public string RGWIconImage { get; set; }
        public string RGWIconText { get; set; }
        public string Updates { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Subject { get; set; }
        [Required]
        [StringLength(1000, MinimumLength = 5)]
        public string Thoughts { get; set; }
        [Required]
        [MustBeTrue]
        public bool TandC { get; set; }
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
