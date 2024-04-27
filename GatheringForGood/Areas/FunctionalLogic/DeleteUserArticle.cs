using GatheringForGood.Areas.Identity.Data;
using GatheringForGood.Data;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class DeleteUserArticle
    {
        public async Task<bool> DeleteArticleAsync(string uniqueArticleReference)
        {
            using (var _context = new ApplicationDbContext())
            {
                bool success = true;
                try
                {
                    var userArticleForDetails = _context.ArticleDetails.Where(a => a.UniqueReference == uniqueArticleReference).First();
                    var userArticleForList = _context.ArticlesList.Where(a => a.UniqueReference == uniqueArticleReference).First();
                    _context.ArticleDetails.Remove(userArticleForDetails);
                    _context.ArticlesList.Remove(userArticleForList);
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
