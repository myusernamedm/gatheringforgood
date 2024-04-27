using GatheringForGood.Areas.Identity.Data;
using GatheringForGood.Data;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class ShowHideUserArticle
    {
        public async Task<bool> ShowHideArticleAsync(string uniqueArticleReference, bool showArticleBool)
        {
            using (var _context = new ApplicationDbContext())
            {
                bool success = true;
                try
                {
                    var userArticleForList = _context.ArticlesList.Where(a => a.UniqueReference == uniqueArticleReference).First();
                    userArticleForList.ShowArticle = showArticleBool;
                    await _context.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.GetType().ToString());
                    success = false;
                }
                return success;
            }
        }

    }
}
