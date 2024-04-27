using System;
using System.Collections.Generic;
using System.Text;

namespace URLStringsReferenceLibrary
{

    public class UrlStrings
    {

        public string getLocalHostPort()
        {
            string portNo = "44305";
            return portNo;
        }

        public string GetForgotPasswordPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/Identity/Account/ForgotPassword";
            return Url;
        }
        public string GetForgotPasswordConfirmationPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/Identity/Account/ForgotPasswordConfirmation";
            return Url;
        }
        public string GetHomePageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en";
            return Url;
        }
        public string GetHomePageProdHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://gatheringforgood.com/";
            return Url;
        }
        public string GetNewsfeedPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/Newsfeed/Newsfeed";
            return Url;
        }
        public string GetNewsfeedPageProdHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://gatheringforgood.com/en/Newsfeed/Newsfeed";
            return Url;
        }
        public string GetReduceGlobalWarmingPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/ReduceGlobalWarming/ReduceGlobalWarming";
            return Url;
        }
        public string GetReduceAnimalExtinctionPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/ReduceAnimalExtinction/ReduceAnimalExtinction";
            return Url;
        }
        public string GetReduceDeforestationPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/ReduceDeforestation/ReduceDeforestation";
            return Url;
        }
        public string GetAboutPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/About/About";
            return Url;
        }
        public string GetAboutPageProdHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://gatheringforgood.com/en/About/About";
            return Url;
        }
        public string GetHelpPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/Help/Help";
            return Url;
        }
        public string GetHelpPageProdHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://gatheringforgood.com/en/Help/Help";
            return Url;
        }
        public string GetRegisterPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/Identity/Account/Register";
            return Url;
        }
        public string GetRegisterPageProdHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://gatheringforgood.com/en/Identity/Account/Register";
            return Url;
        }
        public string GetResetPasswordPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/Identity/Account/ResetPassword?userId=bb534042-36be-4532-aec5-c215b68a67b1&code=Q2ZESjhJdThJc2ZKbTdSR2xxUXowZXFNQ3lZWjdzU0I2UTlKU3llNUQwTG8rck5KTlE2V2g0VHRTS3pVWTZqakl6QVhKenBQclBKejQwWjhuVkQ2Wmd3dGEwUXh3TzNoMk1BcEFGRHRORUs0K014SU1Ld08vNE5pa3YxbXYzditQYitWMVB1NWgzMHkrLy8vSi9VK2pDNVZVWlRjbG8veHdJOUwwc1RMM3dENEhiTVNOZkhtbEk2TDRGT2R6a1FLdDQ2dDNJUHhSTWZIdlQxUjg2Sm4xYnZJMEgrZitnSzNBS29GRWhnZlphdkhxbVRz";
            return Url;
        }
        public string GetResetPasswordConfirmationPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/Identity/Account/ResetPasswordConfirmation";
            return Url;
        }
        public string GetDeutschRegisterPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/de/Identity/Account/Register";
            return Url;
        }
        public string GetRegisterConfPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/Identity/Account/RegisterConfirmation?email=test6@email.com";
            return Url;
        }
        public string GetLoginPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/Identity/Account/Login";
            return Url;
        }
        public string GetLoginPageFailedLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/Identity/Account/Login?returnurl=%2Fen";
            return Url;
        }
        public string GetLoginPageProdHostUrl()
        {
            string Url = "https://gatheringforgood.com/en/Identity/Account/Login";
            return Url;
        }
        public string GetDeutschLoginPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/de/Identity/Account/Login";
            return Url;
        }
        public string GetArticlesPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/Articles/Articles";
            return Url;
        }
        public string GetArticlesPageProdHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://gatheringforgood.com/en/Articles/Articles";
            return Url;
        }
        public string GetPrivacyPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/Privacy/Privacy";
            return Url;
        }
        public string GetPrivacyPageProdHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://gatheringforgood.com/en/Privacy/Privacy";
            return Url;
        }
        public string GetTermsAndConditionsPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/TermsAndConditions/TermsAndConditions";
            return Url;
        }
        public string GetTermsAndConditionsPageProdHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://gatheringforgood.com/en/TermsAndConditions/TermsAndConditions";
            return Url;
        }
        public string GetCookiesPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/Cookies/Cookies";
            return Url;
        }
        public string GetCookiesPageProdHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://gatheringforgood.com/en/Cookies/Cookies";
            return Url;
        }
        public string GetLockoutPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/Identity/Account/Lockout";
            return Url;
        }
        public string GetCanopyProjectUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://www.earthday.org/campaign/the-canopy-project/?gclid=CjwKCAjw8MD7BRArEiwAGZsrBbXCmFjIY7DrwcRgegXdctBGAKa8_r_rG2XJP-oEqVH-GndkA1f6NhoC2wsQAvD_BwE";
            return Url;
        }
        public string GetAccountManagePageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/Identity/Account/Manage/Index";
            return Url;
        }
        public string GetAccountManagePageProdHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://gatheringforgood.com/en/Identity/Account/Manage/Index";
            return Url;
        }
        public string GetEmailPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/Identity/Account/Manage/Email";
            return Url;
        }
        public string GetEmailPageLocalProdHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://gatheringforgood.com/en/Identity/Account/Manage/Email";
            return Url;
        }
        public string GetPasswordPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/Identity/Account/Manage/ChangePassword";
            return Url;
        }
        public string GetPasswordPageLocalProdHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://gatheringforgood.com/en/Identity/Account/Manage/ChangePassword";
            return Url;
        }
        public string GetPersonalDataPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/Identity/Account/Manage/PersonalData";
            return Url;
        }
        public string GetPersonalDataLocalProdHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://gatheringforgood.com/en/Identity/Account/Manage/PersonalData";
            return Url;
        }
        public string GetDownloadChromeUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://www.google.com/chrome/?brand=BNSD&gclid=CjwKCAjwjJmIBhA4EiwAQdCbxuGNWEWU-kGpW6cLFqYQqZGw0oiLgUWv5JW-VNe66rzrwS71u888ARoCWDEQAvD_BwE&gclsrc=aw.ds";
            return Url;
        }
        public string GetInfoPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/Identity/Account/Manage/Info";
            return Url;
        }
        public string GetUserBadgesPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/UserBadges/UserBadges";
            return Url;
        }
        public string GetOneTreePlantedUrl()
        {
            string Url = "https://onetreeplanted.org/pages/about-us";
            return Url;
        }
        public string GetCarbonOffsetsPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/CarbonOffsets/CarbonOffsets";
            return Url;
        }
        public string GetUpdatesPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/Updates/Updates";
            return Url;
        }
        public string GetCreateArticlePageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/CreateArticle/CreateArticle";
            return Url;
        }
        public string GetMyArticlesPageLocalHostUrl()
        {
            string portNo = getLocalHostPort();
            string Url = "https://localhost:" + portNo + "/en/Identity/Account/Manage/MyArticles";
            return Url;
        }
        public string TestCreateArticleYouTubeVideoUrl()
        {
            string value = "https://youtu.be/QQYgCxu988s";
            return value;
        }
        public string TestCreateArticleProcessedYouTubeVideoUrl()
        {
            string value = "https://www.youtube.com/embed/QQYgCxu988s";
            return value;
        }
        public string TestUnverifiedUserHomepageRedirectUrl()
        {
            string portNo = getLocalHostPort();
            string value = "https://localhost:" + portNo + "/?ReturnUrl=NewUserRegistration";
            return value;
        }
        public string TestUserArticlePageUrl()
        {
            string portNo = getLocalHostPort();
            string value = "https://localhost:" + portNo + "/en/UserArticle/UserArticle/6286cb56-165e-4854-bb31-bac494ccbb39";
            return value;
        }
    }
}
