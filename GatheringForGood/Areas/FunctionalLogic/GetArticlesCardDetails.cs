using GatheringForGood.Areas.Identity.Data;
using GatheringForGood.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class GetArticlesCardDetails
    {
        public string ArticleRef { get; set; }
        public string TitleImgRef { get; set; }
        public string UserIdRef { get; set; }
        public string TitleRef { get; set; }
        public string SnippetRef { get; set; }
        public string PostedRef { get; set; }
        public string WeeklyRef { get; set; }
        public string TitleVidRef { get; set; }
        public string HREFRef { get; set; }
        public string RazorRef { get; set; }
        public string UniqueRef { get; set; }
        public string ShowArticleRef { get; set; }
        public string FeaturedRef { get; set; }
        public string ArticleViewsRef { get; set; }
        public string AuthorFirstNameRef { get; set; }
        public string AuthorLastNameRef { get; set; }
        public string LikesRef { get; set; }
        public string DislikesRef { get; set; }
        public string SupportRef { get; set; }
        public string QuestionableRef { get; set; }
        public string ShockedRef { get; set; }
        public string TreePlantedRef { get; set; }

        public static async Task<List<GetArticlesCardDetails>> GetCardDetailsAsync(ApplicationDbContext _context, int searchOption, int sortOption, string searchText)
        {
            _context.ArticlesList.OrderByDescending(p => p.PostedDateTime);
            await _context.SaveChangesAsync();

            var articlesEntriesCount = await GetArticlesListCountAsync(_context);
            var Articles = await GetArticlesListAsync(_context);
            string[,] articles = { };

            List<GetArticlesCardDetails> mainList = new List<GetArticlesCardDetails>();
            mainList.Clear();

            List<string> titleImageUrlList = _context.ArticlesList.Select(c => c.TitleImageUrl).ToList();
            List<string> userIdList = _context.ArticlesList.Select(c => c.UserId).ToList();
            List<string> titleList = _context.ArticlesList.Select(c => c.Title).ToList();
            List<string> snippetList = _context.ArticlesList.Select(c => c.Snippet).ToList();
            List<DateTime> postedList = _context.ArticlesList.Select(c => c.PostedDateTime.Value).ToList();
            List<string> titleVideoList = _context.ArticlesList.Select(c => c.TitleVideoUrl).ToList();
            List<string> HREFLinkList = _context.ArticlesList.Select(c => c.HREFLink).ToList();
            List<string> RazorLinkList = _context.ArticlesList.Select(c => c.RazorLink).ToList();
            List<string> UniqueRefList = _context.ArticlesList.Select(c => c.UniqueReference).ToList();
            List<bool> ShowArticleList = _context.ArticlesList.Select(c => c.ShowArticle).ToList();
            List<bool> FeaturedList = _context.ArticlesList.Select(c => c.Featured).ToList();
            List<int> ArticleViewsList = _context.ArticlesList.Select(c => c.ArticleViews).ToList();
            List<string> AuthorFirstNameList = _context.ArticlesList.Select(c => c.AuthorFirstName).ToList();
            List<string> AuthorLastNameList = _context.ArticlesList.Select(c => c.AuthorLastName).ToList();
            List<int> LikesList = _context.ArticlesList.Select(c => c.Likes).ToList();
            List<int> DislikesList = _context.ArticlesList.Select(c => c.Dislikes).ToList();
            List<int> SupportList = _context.ArticlesList.Select(c => c.Support).ToList();
            List<int> QuestionableList = _context.ArticlesList.Select(c => c.Questionable).ToList();
            List<int> ShockedList = _context.ArticlesList.Select(c => c.Shocked).ToList();
            List<bool> TreePlantedList = _context.ArticlesList.Select(c => c.TreePlanted).ToList();

            if (searchText != null && searchText != "nosearch")
            {
                switch (searchOption)
                {
                    case 1:
                        titleImageUrlList = _context.ArticlesList.Where(c => c.Title.Contains(searchText)).Select(c => c.TitleImageUrl).ToList();
                        userIdList = _context.ArticlesList.Where(c => c.Title.Contains(searchText)).Select(c => c.UserId).ToList();
                        titleList = _context.ArticlesList.Where(c => c.Title.Contains(searchText)).Select(c => c.Title).ToList();
                        snippetList = _context.ArticlesList.Where(c => c.Title.Contains(searchText)).Select(c => c.Snippet).ToList();
                        postedList = _context.ArticlesList.Where(c => c.Title.Contains(searchText)).Select(c => c.PostedDateTime.Value).ToList();
                        titleVideoList = _context.ArticlesList.Where(c => c.Title.Contains(searchText)).Select(c => c.TitleVideoUrl).ToList();
                        HREFLinkList = _context.ArticlesList.Where(c => c.Title.Contains(searchText)).Select(c => c.HREFLink).ToList();
                        RazorLinkList = _context.ArticlesList.Where(c => c.Title.Contains(searchText)).Select(c => c.RazorLink).ToList();
                        UniqueRefList = _context.ArticlesList.Where(c => c.Title.Contains(searchText)).Select(c => c.UniqueReference).ToList();
                        ShowArticleList = _context.ArticlesList.Where(c => c.Title.Contains(searchText)).Select(c => c.ShowArticle).ToList();
                        FeaturedList = _context.ArticlesList.Where(c => c.Title.Contains(searchText)).Select(c => c.Featured).ToList();
                        ArticleViewsList = _context.ArticlesList.Where(c => c.Title.Contains(searchText)).Select(c => c.ArticleViews).ToList();
                        AuthorFirstNameList = _context.ArticlesList.Where(c => c.Title.Contains(searchText)).Select(c => c.AuthorFirstName).ToList();
                        AuthorLastNameList = _context.ArticlesList.Where(c => c.Title.Contains(searchText)).Select(c => c.AuthorLastName).ToList();
                        LikesList = _context.ArticlesList.Where(c => c.Title.Contains(searchText)).Select(c => c.Likes).ToList();
                        DislikesList = _context.ArticlesList.Where(c => c.Title.Contains(searchText)).Select(c => c.Dislikes).ToList();
                        SupportList = _context.ArticlesList.Where(c => c.Title.Contains(searchText)).Select(c => c.Support).ToList();
                        QuestionableList = _context.ArticlesList.Where(c => c.Title.Contains(searchText)).Select(c => c.Questionable).ToList();
                        ShockedList = _context.ArticlesList.Where(c => c.Title.Contains(searchText)).Select(c => c.Shocked).ToList();
                        TreePlantedList = _context.ArticlesList.Where(c => c.Title.Contains(searchText)).Select(c => c.TreePlanted).ToList();

                        articlesEntriesCount = titleImageUrlList.Count();
                        break;
                    case 2:
                        titleImageUrlList = _context.ArticlesList.Where(c => c.AuthorFirstName.Contains(searchText)).Select(c => c.TitleImageUrl).ToList();
                        userIdList = _context.ArticlesList.Where(c => c.AuthorFirstName.Contains(searchText)).Select(c => c.UserId).ToList();
                        titleList = _context.ArticlesList.Where(c => c.AuthorFirstName.Contains(searchText)).Select(c => c.Title).ToList();
                        snippetList = _context.ArticlesList.Where(c => c.AuthorFirstName.Contains(searchText)).Select(c => c.Snippet).ToList();
                        postedList = _context.ArticlesList.Where(c => c.AuthorFirstName.Contains(searchText)).Select(c => c.PostedDateTime.Value).ToList();
                        titleVideoList = _context.ArticlesList.Where(c => c.AuthorFirstName.Contains(searchText)).Select(c => c.TitleVideoUrl).ToList();
                        HREFLinkList = _context.ArticlesList.Where(c => c.AuthorFirstName.Contains(searchText)).Select(c => c.HREFLink).ToList();
                        RazorLinkList = _context.ArticlesList.Where(c => c.AuthorFirstName.Contains(searchText)).Select(c => c.RazorLink).ToList();
                        UniqueRefList = _context.ArticlesList.Where(c => c.AuthorFirstName.Contains(searchText)).Select(c => c.UniqueReference).ToList();
                        ShowArticleList = _context.ArticlesList.Where(c => c.AuthorFirstName.Contains(searchText)).Select(c => c.ShowArticle).ToList();
                        FeaturedList = _context.ArticlesList.Where(c => c.AuthorFirstName.Contains(searchText)).Select(c => c.Featured).ToList();
                        ArticleViewsList = _context.ArticlesList.Where(c => c.AuthorFirstName.Contains(searchText)).Select(c => c.ArticleViews).ToList();
                        AuthorFirstNameList = _context.ArticlesList.Where(c => c.AuthorFirstName.Contains(searchText)).Select(c => c.AuthorFirstName).ToList();
                        AuthorLastNameList = _context.ArticlesList.Where(c => c.AuthorFirstName.Contains(searchText)).Select(c => c.AuthorLastName).ToList();
                        LikesList = _context.ArticlesList.Where(c => c.AuthorFirstName.Contains(searchText)).Select(c => c.Likes).ToList();
                        DislikesList = _context.ArticlesList.Where(c => c.AuthorFirstName.Contains(searchText)).Select(c => c.Dislikes).ToList();
                        SupportList = _context.ArticlesList.Where(c => c.AuthorFirstName.Contains(searchText)).Select(c => c.Support).ToList();
                        QuestionableList = _context.ArticlesList.Where(c => c.AuthorFirstName.Contains(searchText)).Select(c => c.Questionable).ToList();
                        ShockedList = _context.ArticlesList.Where(c => c.AuthorFirstName.Contains(searchText)).Select(c => c.Shocked).ToList();
                        TreePlantedList = _context.ArticlesList.Where(c => c.AuthorFirstName.Contains(searchText)).Select(c => c.TreePlanted).ToList();

                        articlesEntriesCount = titleImageUrlList.Count();
                        break;
                    case 3:
                        titleImageUrlList = _context.ArticlesList.Where(c => c.AuthorLastName.Contains(searchText)).Select(c => c.TitleImageUrl).ToList();
                        userIdList = _context.ArticlesList.Where(c => c.AuthorLastName.Contains(searchText)).Select(c => c.UserId).ToList();
                        titleList = _context.ArticlesList.Where(c => c.AuthorLastName.Contains(searchText)).Select(c => c.Title).ToList();
                        snippetList = _context.ArticlesList.Where(c => c.AuthorLastName.Contains(searchText)).Select(c => c.Snippet).ToList();
                        postedList = _context.ArticlesList.Where(c => c.AuthorLastName.Contains(searchText)).Select(c => c.PostedDateTime.Value).ToList();
                        titleVideoList = _context.ArticlesList.Where(c => c.AuthorLastName.Contains(searchText)).Select(c => c.TitleVideoUrl).ToList();
                        HREFLinkList = _context.ArticlesList.Where(c => c.AuthorLastName.Contains(searchText)).Select(c => c.HREFLink).ToList();
                        RazorLinkList = _context.ArticlesList.Where(c => c.AuthorLastName.Contains(searchText)).Select(c => c.RazorLink).ToList();
                        UniqueRefList = _context.ArticlesList.Where(c => c.AuthorLastName.Contains(searchText)).Select(c => c.UniqueReference).ToList();
                        ShowArticleList = _context.ArticlesList.Where(c => c.AuthorLastName.Contains(searchText)).Select(c => c.ShowArticle).ToList();
                        FeaturedList = _context.ArticlesList.Where(c => c.AuthorLastName.Contains(searchText)).Select(c => c.Featured).ToList();
                        ArticleViewsList = _context.ArticlesList.Where(c => c.AuthorLastName.Contains(searchText)).Select(c => c.ArticleViews).ToList();
                        AuthorFirstNameList = _context.ArticlesList.Where(c => c.AuthorLastName.Contains(searchText)).Select(c => c.AuthorFirstName).ToList();
                        AuthorLastNameList = _context.ArticlesList.Where(c => c.AuthorLastName.Contains(searchText)).Select(c => c.AuthorLastName).ToList();
                        LikesList = _context.ArticlesList.Where(c => c.AuthorLastName.Contains(searchText)).Select(c => c.Likes).ToList();
                        DislikesList = _context.ArticlesList.Where(c => c.AuthorLastName.Contains(searchText)).Select(c => c.Dislikes).ToList();
                        SupportList = _context.ArticlesList.Where(c => c.AuthorLastName.Contains(searchText)).Select(c => c.Support).ToList();
                        QuestionableList = _context.ArticlesList.Where(c => c.AuthorLastName.Contains(searchText)).Select(c => c.Questionable).ToList();
                        ShockedList = _context.ArticlesList.Where(c => c.AuthorLastName.Contains(searchText)).Select(c => c.Shocked).ToList();
                        TreePlantedList = _context.ArticlesList.Where(c => c.AuthorLastName.Contains(searchText)).Select(c => c.TreePlanted).ToList();

                        articlesEntriesCount = titleImageUrlList.Count();
                        break;
                }
            }

            for (int i = 0; i < articlesEntriesCount; i++)
            {
                Debug.WriteLine("*********** titleList 3: " + string.Join(",", titleList));

                articles = new string[,] { { titleImageUrlList[i], userIdList[i], titleList[i], snippetList[i], postedList[i].ToString(), titleVideoList[i], HREFLinkList[i], RazorLinkList[i], UniqueRefList[i], ShowArticleList[i].ToString(), FeaturedList[i].ToString(), ArticleViewsList[i].ToString(), AuthorFirstNameList[i].ToString(), AuthorLastNameList[i].ToString(), LikesList[i].ToString(), DislikesList[i].ToString(), SupportList[i].ToString(), QuestionableList[i].ToString(), ShockedList[i].ToString(), TreePlantedList[i].ToString() } };
                mainList.Add(new GetArticlesCardDetails() { TitleImgRef = articles[0, 0], UserIdRef = articles[0, 1], TitleRef = articles[0, 2], SnippetRef = articles[0, 3], PostedRef = articles[0, 4], TitleVidRef = articles[0, 5], HREFRef = articles[0, 6], RazorRef = articles[0, 7], UniqueRef = articles[0, 8], ShowArticleRef = articles[0, 9], FeaturedRef = articles[0, 10], ArticleViewsRef = articles[0, 11], AuthorFirstNameRef = articles[0, 12], AuthorLastNameRef = articles[0, 13], LikesRef = articles[0, 14], DislikesRef = articles[0, 15], SupportRef = articles[0, 16], QuestionableRef = articles[0, 17], ShockedRef = articles[0, 18], TreePlantedRef = articles[0, 19] });
            }

            mainList.ForEach(item => Debug.WriteLine("mainList: " + item.TitleImgRef + " | " + item.UserIdRef + " | " + item.TitleRef + " | " + item.SnippetRef + " | " + item.PostedRef + " | " + item.TitleVidRef + " | " + item.HREFRef + " | " + item.RazorRef + " | " + item.UniqueRef + " | " + item.ShowArticleRef + " | " + item.FeaturedRef + " | " + item.ArticleViewsRef + " | " + item.AuthorFirstNameRef + " | " + item.AuthorLastNameRef + " | " + item.TreePlantedRef));

            return mainList.OrderByDescending(p => p.PostedRef).ToList(); ;

        }

        private static async Task<int> GetArticlesListCountAsync(ApplicationDbContext _context)
        {
            var articlesEntriesCount = _context.ArticlesList.Count();

            return articlesEntriesCount;
        }

        private static async Task<ArticlesList> GetArticlesListAsync(ApplicationDbContext _context)
        {
            var Articles = _context.ArticlesList.FirstOrDefault();

            return Articles;
        }
    }
}
