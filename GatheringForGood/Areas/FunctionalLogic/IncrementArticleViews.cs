using GatheringForGood.Areas.Identity.Data;
using GatheringForGood.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class IncrementArticleViews
    {
        private static readonly ApplicationDbContext _context = new();

        public async Task incrementArticleViews(string uniqueArticleReference)
        {

            var articleTotalViews = _context.ArticlesList.SingleOrDefault(a => a.UniqueReference == uniqueArticleReference);
            articleTotalViews.ArticleViews++;
            await _context.SaveChangesAsync();
        }
    }
}
