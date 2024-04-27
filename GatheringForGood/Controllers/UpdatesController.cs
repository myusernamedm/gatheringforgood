using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using GatheringForGood.Models;
using LocSourceNameReferenceLibrary;
using ImageUrlReferenceLibrary;
using Microsoft.AspNetCore.Authorization;
using GatheringForGood.Areas.FunctionalLogic;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace GatheringForGood.Controllers
{
    [AllowAnonymous]
    public class UpdatesController : Controller
    {
        readonly SaveUserModalEntry SaveUserModalEntry = new();
        readonly SendEmailModalEntry SendEmailModalEntry = new();

        private readonly IEmailSender _emailSender;

        public UpdatesController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public IActionResult Updates()
        {
            UpdatesPageLocSourceNames _locSourceUpdatesPageNameReferenceLibrary = new UpdatesPageLocSourceNames();
            SharedCrossPageLocSourceNames _locSourceSharedCrossPageNameReferenceLibrary = new SharedCrossPageLocSourceNames();
            SharedCrossPageImageUrls _SharedCrossPageImageUrlLibrary = new();

            var viewModel = new UpdatesViewModel
            {
                PageTabTitle = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourcePageTabTitleNameReferenceForUpdatesPage(),
                ButtonText = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceButtonTextNameReference(),
                Title = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceTitleNameReferenceForUpdatesPage(),
                Subtitle = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceSubtitleNameReferenceForUpdatesPage(),
                NavBarHome = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceHomeLabelNameReference(),
                NavBarNewsfeed = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceNewsfeedLabelNameReference(),
                NavBarAbout = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceAboutLabelNameReference(),
                NavBarHelpCenter = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceHelpCenterLabelNameReference(),
                NavBarRegister = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceRegisterLabelNameReference(),
                NavBarLogin = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLoginLabelNameReference(),
                NavBarLogout = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLogoutLabelNameReference(),
                AboutUs = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceAboutUsLabelNameReference(),
                UpdatesHeading = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceHeadingNameReferenceForUpdatesPage(),
                UpdatesHeadingPara = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceUpdatesHeadingParaNameReferenceForUpdatesPage(),
                Articles = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceArticlesLabelNameReference(),
                CookiesNotice = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceCookiesNoticeLabelNameReference(),
                PrivacyNotice = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourcePrivacyNoticeLabelNameReference(),
                ComingSoon = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceComingSoonLabelNameReference(),
                LikeToSee = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceLikeToSeeLabelNameReference(),
                Submit = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceSubmitLabelNameReference(),
                Updates = _locSourceSharedCrossPageNameReferenceLibrary.GetLocSourceUpdatesNameReferenceForPage(),
                Date = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceDateNameReferenceForUpdatesPage(),
                Details = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceDetailsNameReferenceForUpdatesPage(),
                UserFeedback = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceUserFeedbackNameReferenceForUpdatesPage(),
                Yes = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceYesNameReferenceForUpdatesPage(),
                No = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceNoNameReferenceForUpdatesPage(),
                CheckGreen = _SharedCrossPageImageUrlLibrary.GetCheckGreenImageUrlReferenceForHomePage(),
                HomepageShare = "https://twitter.com/intent/tweet?hashtags=gatheringforgood%2Cclimatechange%2Cmakeadifference&original_referer=https%3A%2F%2Fgatheringforgood.com%2F&ref_src=twsrc%5Etfw%7Ctwcamp%5Ebuttonembed%7Ctwterm%5Eshare%7Ctwgr%5E&text=GatheringForGood%20users%20are%20taking%20action%20to%20help%20save%20the%20world!%20Gather%20with%20me%20for%20good%20and%20help%20make%20a%20difference!%20%F0%9F%98%8A&url=https%3A%2F%2Fgatheringforgood.com",
                IconTwitter = _SharedCrossPageImageUrlLibrary.GetTwitterIconUrlForPage(),
                IconLinkedin = _SharedCrossPageImageUrlLibrary.GetLinkedinIconUrlForPage(),
                IconFacebook = _SharedCrossPageImageUrlLibrary.GetFacebookIconUrlForPage(),
                GetEarthHandsReducedImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReducedImageUrlForPage(),
                GetEarthHandsReduced400ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced400ImageUrlForPage(),
                GetEarthHandsReduced800ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced800ImageUrlForPage(),
                GetEarthHandsReduced1200ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced1200ImageUrlForPage(),
                GetEarthHandsReduced1600ImageUrl = _SharedCrossPageImageUrlLibrary.GetEarthHandsReduced1600ImageUrlForPage(),
                Row1 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow1NameReferenceForUpdatesPage(),
                Row2 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow2NameReferenceForUpdatesPage(),
                Row3 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow3NameReferenceForUpdatesPage(),
                Row4 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow4NameReferenceForUpdatesPage(),
                Row5 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow5NameReferenceForUpdatesPage(),
                Row6 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow6NameReferenceForUpdatesPage(),
                Row7 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow7NameReferenceForUpdatesPage(),
                Row8 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow8NameReferenceForUpdatesPage(),
                Row9 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow9NameReferenceForUpdatesPage(),
                Row10 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow10NameReferenceForUpdatesPage(),
                Row11 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow11NameReferenceForUpdatesPage(),
                Row12 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow12NameReferenceForUpdatesPage(),
                Row13 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow13NameReferenceForUpdatesPage(),
                Row14 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow14NameReferenceForUpdatesPage(),
                Row15 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow15NameReferenceForUpdatesPage(),
                Row16 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow16NameReferenceForUpdatesPage(),
                Row17 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow17NameReferenceForUpdatesPage(),
                Row18 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow18NameReferenceForUpdatesPage(),
                Row19 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow19NameReferenceForUpdatesPage(),
                Row20 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow20NameReferenceForUpdatesPage(),
                Row21 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow21NameReferenceForUpdatesPage(),
                Row22 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow22NameReferenceForUpdatesPage(),
                Row23 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow23NameReferenceForUpdatesPage(),
                Row24 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow24NameReferenceForUpdatesPage(),
                Row25 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow25NameReferenceForUpdatesPage(),
                Row26 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow26NameReferenceForUpdatesPage(),
                Row27 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow27NameReferenceForUpdatesPage(),
                Row28 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow28NameReferenceForUpdatesPage(),
                Row29 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow5NameReferenceForUpdatesPage(),
                Row30 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow30NameReferenceForUpdatesPage(),
                Row31 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow31NameReferenceForUpdatesPage(),
                Row32 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow32NameReferenceForUpdatesPage(),
                Row33 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow33NameReferenceForUpdatesPage(),
                Row34 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow34NameReferenceForUpdatesPage(),
                Row35 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow35NameReferenceForUpdatesPage(),
                Row36 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow36NameReferenceForUpdatesPage(),
                Row37 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow37NameReferenceForUpdatesPage(),
                Row38 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow38NameReferenceForUpdatesPage(),
                Row39 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow39NameReferenceForUpdatesPage(),
                Row40 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow40NameReferenceForUpdatesPage(),
                Row41 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow41NameReferenceForUpdatesPage(),
                Row42 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow42NameReferenceForUpdatesPage(),
                Row43 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow43NameReferenceForUpdatesPage(),
                Row44 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow44NameReferenceForUpdatesPage(),
                Row45 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow45NameReferenceForUpdatesPage(),
                Row46 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow46NameReferenceForUpdatesPage(),
                Row47 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow47NameReferenceForUpdatesPage(),
                Row48 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow48NameReferenceForUpdatesPage(),
                Row49 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow49NameReferenceForUpdatesPage(),
                Row50 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow50NameReferenceForUpdatesPage(),
                Row51 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow51NameReferenceForUpdatesPage(),
                Row52 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow52NameReferenceForUpdatesPage(),
                Row53 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow53NameReferenceForUpdatesPage(),
                Row54 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow54NameReferenceForUpdatesPage(),
                Row55 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow55NameReferenceForUpdatesPage(),
                Row56 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow56NameReferenceForUpdatesPage(),
                Row57 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow57NameReferenceForUpdatesPage(),
                Row58 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow58NameReferenceForUpdatesPage(),
                Row59 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow59NameReferenceForUpdatesPage(),
                Row60 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow60NameReferenceForUpdatesPage(),
                Row61 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow61NameReferenceForUpdatesPage(),
                Row62 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow62NameReferenceForUpdatesPage(),
                Row63 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow63NameReferenceForUpdatesPage(),
                Row64 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow64NameReferenceForUpdatesPage(),
                Row65 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow65NameReferenceForUpdatesPage(),
                Row66 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow66NameReferenceForUpdatesPage(),
                Row67 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow67NameReferenceForUpdatesPage(),
                Row68 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow68NameReferenceForUpdatesPage(),
                Row69 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow69NameReferenceForUpdatesPage(),
                Row70 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow70NameReferenceForUpdatesPage(),
                Row71 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow71NameReferenceForUpdatesPage(),
                Row72 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow72NameReferenceForUpdatesPage(),
                Row73 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow73NameReferenceForUpdatesPage(),
                Row74 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow74NameReferenceForUpdatesPage(),
                Row75 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow75NameReferenceForUpdatesPage(),
                Row76 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow76NameReferenceForUpdatesPage(),
                Row77 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow77NameReferenceForUpdatesPage(),
                Row78 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow28NameReferenceForUpdatesPage(),
                Row79 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow79NameReferenceForUpdatesPage(),
                Row80 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow80NameReferenceForUpdatesPage(),
                Row81 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow81NameReferenceForUpdatesPage(),
                Row82 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow82NameReferenceForUpdatesPage(),
                Row83 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow83NameReferenceForUpdatesPage(),
                Row84 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow84NameReferenceForUpdatesPage(),
                Row85 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow85NameReferenceForUpdatesPage(),
                Row86 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow86NameReferenceForUpdatesPage(),
                Row87 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow87NameReferenceForUpdatesPage(),
                Row88 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow88NameReferenceForUpdatesPage(),
                Row89 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow89NameReferenceForUpdatesPage(),
                Row90 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow90NameReferenceForUpdatesPage(),
                Row91 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow91NameReferenceForUpdatesPage(),
                Row94 = _locSourceUpdatesPageNameReferenceLibrary.GetLocSourceRow94NameReferenceForUpdatesPage()
            };

            return View(viewModel);
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
        public async Task<IActionResult> SaveUserEntryAsync(string newsfeedUserEntry)
        {
            DateTime FeedbackDateTime = DateTime.UtcNow;

            if (newsfeedUserEntry != null)
            {
                string userId = ClaimsPrincipalExtensions.GetUserId<string>(User);
                if (userId != null)
                {
                    bool loggedInUser = true;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Updates Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Updates Page Newsfeed Modal", FeedbackDateTime);
                }
                else
                {
                    bool loggedInUser = false;
                    await SaveUserModalEntry.saveUserEntryAsync(newsfeedUserEntry, userId, "Updates Page Newsfeed Modal", FeedbackDateTime);
                    await SendEmailModalEntry.sendEmailAsync(_emailSender, newsfeedUserEntry, loggedInUser, "Updates Page Newsfeed Modal", FeedbackDateTime);
                }
            }

            return RedirectToAction("Updates");
        }
    }
}
