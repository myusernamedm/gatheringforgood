using GatheringForGood.Areas.Identity.Data;
using GatheringForGood.Data;
using System;
using System.Diagnostics;
using System.Linq;

namespace GatheringForGood.Areas.FunctionalLogic
{

    public class GetUserArticleDetails
    {
        public static ArticleDetails retrieveArticleDataFromDB(string uniqueArticleReference)
        {
            ApplicationDbContext _context = new();

            try
            {
                var userArticle = _context.ArticleDetails.Single(a => a.UniqueReference == uniqueArticleReference);
                
                return userArticle;
            } 
            catch (Exception e)
            {
                Debug.WriteLine(e.GetType().ToString());
            }

            return null;
        }

    }
}
