using GatheringForGood.Areas.Identity.Data;
using GatheringForGood.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class IncrementUserReaction
    {
        private static readonly ApplicationDbContext _context = new();

        public async Task incrementReaction(int reactionType, string uniqueArticleRef)
        {
            Debug.WriteLine("*********** reactionType: " + reactionType + " ********** uniqueArticleRef: " + uniqueArticleRef);
            var articleDetails = _context.ArticleDetails.SingleOrDefault(a => a.UniqueReference == uniqueArticleRef);
            var articleList = _context.ArticlesList.SingleOrDefault(a => a.UniqueReference == uniqueArticleRef);

            if(articleDetails!= null)
            {
                switch (reactionType)
                {
                    case 1:
                        articleDetails.Likes++;
                        articleList.Likes++;
                        break;
                    case 2:
                        articleDetails.Dislikes++;
                        articleList.Dislikes++;
                        break;
                    case 3:
                        articleDetails.Support++;
                        articleList.Support++;
                        break;
                    case 4:
                        articleDetails.Questionable++;
                        articleList.Questionable++;
                        break;
                    case 5:
                        articleDetails.Shocked++;
                        articleList.Shocked++;
                        break;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
