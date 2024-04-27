using GatheringForGood.Areas.Identity.Data;
using GatheringForGood.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class SaveArticleDetails
    {
        bool purchaseStatus = false;
        bool featuredStatus = false;

        public async Task saveDetailsAsync(string userId, string title, int validFeaturedCode, List<string> imageUrls, string snippet, List<string> ParaFieldsList, List<string> SubheadingFieldsList, List<string> VideoUrlFieldsList, DateTime postedDateTime, string uniqueArticleReference, bool tandc, ApplicationDbContext _context, bool showArticle, string authorFirstName, string authorLastName, List<string> CaptionFields, string ImageTitleCaption, string TreePurchaseStatus)
        {
            switch (validFeaturedCode)
            {
                case 1:
                    purchaseStatus = true;
                    break;
                case 2:
                    featuredStatus = true;
                    break;
                case 3:
                    purchaseStatus = true;
                    featuredStatus = true;
                    break;
                default:
                    featuredStatus = false;
                    break;
            }

            if (TreePurchaseStatus != null)
            {
                purchaseStatus = true;
            }

            Debug.WriteLine("********* purchaseStatus: " + purchaseStatus);
            Debug.WriteLine("************ featuredStatus: " + featuredStatus);

            var articleDetails = new ArticleDetails()
            {
                UserId = userId,
                Title = title,
                ImageTitleCaption = ImageTitleCaption,
                Featured = featuredStatus,
                TitleImageUrl = imageUrls[0],
                TitleVideoUrl = VideoUrlFieldsList[0],
                Snippet = snippet,
                Para1 = ParaFieldsList[0],
                Para2 = ParaFieldsList[1],
                Para3 = ParaFieldsList[2],
                Para4 = ParaFieldsList[3],
                Para5 = ParaFieldsList[4],
                Para6 = ParaFieldsList[5],
                Para7 = ParaFieldsList[6],
                Para8 = ParaFieldsList[7],
                Para9 = ParaFieldsList[8],
                Para10 = ParaFieldsList[9],
                Para11 = ParaFieldsList[10],
                Para12 = ParaFieldsList[11],
                Para13 = ParaFieldsList[12],
                Para14 = ParaFieldsList[13],
                Para15 = ParaFieldsList[14],
                Para16 = ParaFieldsList[15],
                Para17 = ParaFieldsList[16],
                Para18 = ParaFieldsList[17],
                Para19 = ParaFieldsList[18],
                Para20 = ParaFieldsList[19],
                Para21 = ParaFieldsList[20],
                Para22 = ParaFieldsList[21],
                Para23 = ParaFieldsList[22],
                Para24 = ParaFieldsList[23],
                Para25 = ParaFieldsList[24],
                Para26 = ParaFieldsList[25],
                Para27 = ParaFieldsList[26],
                Para28 = ParaFieldsList[27],
                Para29 = ParaFieldsList[28],
                Para30 = ParaFieldsList[29],
                Para31 = ParaFieldsList[30],
                Para32 = ParaFieldsList[31],
                Para33 = ParaFieldsList[32],
                Para34 = ParaFieldsList[33],
                Para35 = ParaFieldsList[34],
                Para36 = ParaFieldsList[35],
                Para37 = ParaFieldsList[36],
                Para38 = ParaFieldsList[37],
                Para39 = ParaFieldsList[38],
                Para40 = ParaFieldsList[39],
                Para41 = ParaFieldsList[40],
                Para42 = ParaFieldsList[41],
                Para43 = ParaFieldsList[42],
                Para44 = ParaFieldsList[43],
                Para45 = ParaFieldsList[44],
                Para46 = ParaFieldsList[45],
                Para47 = ParaFieldsList[46],
                Para48 = ParaFieldsList[47],
                Para49 = ParaFieldsList[48],
                Para50 = ParaFieldsList[49],
                Para2Subheading = SubheadingFieldsList[0],
                Para3Subheading = SubheadingFieldsList[1],
                Para4Subheading = SubheadingFieldsList[2],
                Para5Subheading = SubheadingFieldsList[3],
                Para6Subheading = SubheadingFieldsList[4],
                Para7Subheading = SubheadingFieldsList[5],
                Para8Subheading = SubheadingFieldsList[6],
                Para9Subheading = SubheadingFieldsList[7],
                Para10Subheading = SubheadingFieldsList[8],
                Para11Subheading = SubheadingFieldsList[9],
                Para12Subheading = SubheadingFieldsList[10],
                Para13Subheading = SubheadingFieldsList[11],
                Para14Subheading = SubheadingFieldsList[12],
                Para15Subheading = SubheadingFieldsList[13],
                Para16Subheading = SubheadingFieldsList[14],
                Para17Subheading = SubheadingFieldsList[15],
                Para18Subheading = SubheadingFieldsList[16],
                Para19Subheading = SubheadingFieldsList[17],
                Para20Subheading = SubheadingFieldsList[18],
                Para21Subheading = SubheadingFieldsList[19],
                Para22Subheading = SubheadingFieldsList[20],
                Para23Subheading = SubheadingFieldsList[21],
                Para24Subheading = SubheadingFieldsList[22],
                Para25Subheading = SubheadingFieldsList[23],
                Para26Subheading = SubheadingFieldsList[24],
                Para27Subheading = SubheadingFieldsList[25],
                Para28Subheading = SubheadingFieldsList[26],
                Para29Subheading = SubheadingFieldsList[27],
                Para30Subheading = SubheadingFieldsList[28],
                Para31Subheading = SubheadingFieldsList[29],
                Para32Subheading = SubheadingFieldsList[30],
                Para33Subheading = SubheadingFieldsList[31],
                Para34Subheading = SubheadingFieldsList[32],
                Para35Subheading = SubheadingFieldsList[33],
                Para36Subheading = SubheadingFieldsList[34],
                Para37Subheading = SubheadingFieldsList[35],
                Para38Subheading = SubheadingFieldsList[36],
                Para39Subheading = SubheadingFieldsList[37],
                Para40Subheading = SubheadingFieldsList[38],
                Para41Subheading = SubheadingFieldsList[39],
                Para42Subheading = SubheadingFieldsList[40],
                Para43Subheading = SubheadingFieldsList[41],
                Para44Subheading = SubheadingFieldsList[42],
                Para45Subheading = SubheadingFieldsList[43],
                Para46Subheading = SubheadingFieldsList[44],
                Para47Subheading = SubheadingFieldsList[45],
                Para48Subheading = SubheadingFieldsList[46],
                Para49Subheading = SubheadingFieldsList[47],
                Para50Subheading = SubheadingFieldsList[48],
                Image2Caption = CaptionFields[0],
                Image3Caption = CaptionFields[1],
                Image4Caption = CaptionFields[2],
                Image5Caption = CaptionFields[3],
                Image6Caption = CaptionFields[4],
                Image7Caption = CaptionFields[5],
                Image8Caption = CaptionFields[6],
                Image9Caption = CaptionFields[7],
                Image10Caption = CaptionFields[8],
                Image11Caption = CaptionFields[9],
                Image12Caption = CaptionFields[10],
                Image13Caption = CaptionFields[11],
                Image14Caption = CaptionFields[12],
                Image15Caption = CaptionFields[13],
                Image16Caption = CaptionFields[14],
                Image17Caption = CaptionFields[15],
                Image18Caption = CaptionFields[16],
                Image19Caption = CaptionFields[17],
                Image20Caption = CaptionFields[18],
                Image21Caption = CaptionFields[19],
                Image22Caption = CaptionFields[20],
                Image23Caption = CaptionFields[21],
                Image24Caption = CaptionFields[22],
                Image25Caption = CaptionFields[23],
                Image26Caption = CaptionFields[24],
                Image27Caption = CaptionFields[25],
                Image28Caption = CaptionFields[26],
                Image29Caption = CaptionFields[27],
                Image30Caption = CaptionFields[28],
                Image31Caption = CaptionFields[29],
                Image32Caption = CaptionFields[30],
                Image33Caption = CaptionFields[31],
                Image34Caption = CaptionFields[32],
                Image35Caption = CaptionFields[33],
                Image36Caption = CaptionFields[34],
                Image37Caption = CaptionFields[35],
                Image38Caption = CaptionFields[36],
                Image39Caption = CaptionFields[37],
                Image40Caption = CaptionFields[38],
                Image41Caption = CaptionFields[39],
                Image42Caption = CaptionFields[40],
                Image43Caption = CaptionFields[41],
                Image44Caption = CaptionFields[42],
                Image45Caption = CaptionFields[43],
                Image46Caption = CaptionFields[44],
                Image47Caption = CaptionFields[45],
                Image48Caption = CaptionFields[46],
                Image49Caption = CaptionFields[47],
                Image50Caption = CaptionFields[48],
                Image1 = null,
                Image2 = imageUrls[1],
                Image3 = imageUrls[2],
                Image4 = imageUrls[3],
                Image5 = imageUrls[4],
                Image6 = imageUrls[5],
                Image7 = imageUrls[6],
                Image8 = imageUrls[7],
                Image9 = imageUrls[8],
                Image10 = imageUrls[9],
                Image11 = imageUrls[10],
                Image12 = imageUrls[11],
                Image13 = imageUrls[12],
                Image14 = imageUrls[13],
                Image15 = imageUrls[14],
                Image16 = imageUrls[15],
                Image17 = imageUrls[16],
                Image18 = imageUrls[17],
                Image19 = imageUrls[18],
                Image20 = imageUrls[19],
                Image21 = imageUrls[20],
                Image22 = imageUrls[21],
                Image23 = imageUrls[22],
                Image24 = imageUrls[23],
                Image25 = imageUrls[24],
                Image26 = imageUrls[25],
                Image27 = imageUrls[26],
                Image28 = imageUrls[27],
                Image29 = imageUrls[28],
                Image30 = imageUrls[29],
                Image31 = imageUrls[30],
                Image32 = imageUrls[31],
                Image33 = imageUrls[32],
                Image34 = imageUrls[33],
                Image35 = imageUrls[34],
                Image36 = imageUrls[35],
                Image37 = imageUrls[36],
                Image38 = imageUrls[37],
                Image39 = imageUrls[38],
                Image40 = imageUrls[39],
                Image41 = imageUrls[40],
                Image42 = imageUrls[41],
                Image43 = imageUrls[42],
                Image44 = imageUrls[43],
                Image45 = imageUrls[44],
                Image46 = imageUrls[45],
                Image47 = imageUrls[46],
                Image48 = imageUrls[47],
                Image49 = imageUrls[48],
                Image50 = imageUrls[49],
                Video1 = null,
                Video2 = VideoUrlFieldsList[1],
                Video3 = VideoUrlFieldsList[2],
                Video4 = VideoUrlFieldsList[3],
                Video5 = VideoUrlFieldsList[4],
                Video6 = VideoUrlFieldsList[5],
                Video7 = VideoUrlFieldsList[6],
                Video8 = VideoUrlFieldsList[7],
                Video9 = VideoUrlFieldsList[8],
                Video10 = VideoUrlFieldsList[9],
                Video11 = VideoUrlFieldsList[10],
                Video12 = VideoUrlFieldsList[11],
                Video13 = VideoUrlFieldsList[12],
                Video14 = VideoUrlFieldsList[13],
                Video15 = VideoUrlFieldsList[14],
                Video16 = VideoUrlFieldsList[15],
                Video17 = VideoUrlFieldsList[16],
                Video18 = VideoUrlFieldsList[17],
                Video19 = VideoUrlFieldsList[18],
                Video20 = VideoUrlFieldsList[19],
                Video21 = VideoUrlFieldsList[20],
                Video22 = VideoUrlFieldsList[21],
                Video23 = VideoUrlFieldsList[22],
                Video24 = VideoUrlFieldsList[23],
                Video25 = VideoUrlFieldsList[24],
                Video26 = VideoUrlFieldsList[25],
                Video27 = VideoUrlFieldsList[26],
                Video28 = VideoUrlFieldsList[27],
                Video29 = VideoUrlFieldsList[28],
                Video30 = VideoUrlFieldsList[29],
                Video31 = VideoUrlFieldsList[30],
                Video32 = VideoUrlFieldsList[31],
                Video33 = VideoUrlFieldsList[32],
                Video34 = VideoUrlFieldsList[33],
                Video35 = VideoUrlFieldsList[34],
                Video36 = VideoUrlFieldsList[35],
                Video37 = VideoUrlFieldsList[36],
                Video38 = VideoUrlFieldsList[37],
                Video39 = VideoUrlFieldsList[38],
                Video40 = VideoUrlFieldsList[39],
                Video41 = VideoUrlFieldsList[40],
                Video42 = VideoUrlFieldsList[41],
                Video43 = VideoUrlFieldsList[42],
                Video44 = VideoUrlFieldsList[43],
                Video45 = VideoUrlFieldsList[44],
                Video46 = VideoUrlFieldsList[45],
                Video47 = VideoUrlFieldsList[46],
                Video48 = VideoUrlFieldsList[47],
                Video49 = VideoUrlFieldsList[48],
                Video50 = VideoUrlFieldsList[49],
                PostedDateTime = postedDateTime,
                UniqueReference = uniqueArticleReference,
                TandC = tandc,
                TreePlanted = purchaseStatus
            };

            var finalTitleImageUrl = "none";
            var finalTitleVideoUrl = "none";
            var finalHREFLink = "none";
            var finalRazorLink = "none";
            var finalAuthorFirstName = "none";
            var finalAuthorLastName = "none";

            if (imageUrls[0] != null)
            {
                finalTitleImageUrl = imageUrls[0];
            }
            if (VideoUrlFieldsList[0] != null)
            {
                finalTitleVideoUrl = VideoUrlFieldsList[0];
            }

            // Enabling this code below will cause an URL to be entered in the database for dbo.ArticleList[HREFLink] for every new article created by users with title video,
            // which will cause the article card on the /Articles/Articles page to open a new tab for youtube when clicked, instead of going to the user article page.
            // Hence we do not want to enable this for external users.

            /*
            if (titleVideoUrl != null)
            {
                finalHREFLink = titleVideoUrl;
            } */

            if (VideoUrlFieldsList[0] == null)
            {
                finalRazorLink = "UserArticle";
            }
            if (authorFirstName != null)
            {
                finalAuthorFirstName = authorFirstName;
            }
            if (authorLastName != null)
            {
                finalAuthorLastName = authorLastName;
            }

            articleDetails.AuthorFirstName = finalAuthorFirstName;
            articleDetails.AuthorLastName = finalAuthorLastName;

            var articleList = new ArticlesList()
            {
                TitleImageUrl = finalTitleImageUrl,
                UserId = userId,
                Title = title,
                Featured = featuredStatus,
                Snippet = snippet,
                PostedDateTime = postedDateTime,
                WeeklyNewsList = false,
                TitleVideoUrl = finalTitleVideoUrl,
                HREFLink = finalHREFLink,
                RazorLink = finalRazorLink,
                UniqueReference = uniqueArticleReference,
                ShowArticle = showArticle,
                AuthorFirstName = finalAuthorFirstName,
                AuthorLastName = finalAuthorLastName,
                TreePlanted = purchaseStatus
            };

            await _context.AddAsync(articleDetails);
            await _context.AddAsync(articleList);
            await _context.SaveChangesAsync();
        }
    }
}
