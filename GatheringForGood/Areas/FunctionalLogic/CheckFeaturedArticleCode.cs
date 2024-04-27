using GatheringForGood.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class CheckFeaturedArticleCode
    {
        public async Task<int> checkFeaturedArticleCodeAsync(string submittedCode)
        {

            List<string> validCodes = await GetFeaturedCodesAsync();

            foreach (string code in validCodes)
            {
                if (code == submittedCode)
                {
                    string codeType = code.Substring(code.LastIndexOf('-') + 1);
                    Debug.WriteLine("************ purchase: " + codeType);

                    await IncrementCodeUsage(submittedCode);

                    if(codeType == "TP")
                    {
                        return 1; //Purchase Code
                    } 
                    else if (codeType == "FA")
                    {
                        return 2; //Featured Code
                    }
                    else if (codeType == "TPFA")
                    {
                        return 3; //Featured & Purchase Code
                    }
                }
            }

            return 4; //Submitted code does not match valid codes
        }

        private async Task<List<string>> GetFeaturedCodesAsync()
        {
            using (var _context = new ApplicationDbContext())
            {
                _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
                List<string> featuredCodes = _context.FeaturedCodesList.Where(c => c.Code != null).Select(c => c.Code).ToList();

                return featuredCodes;
            }
        }

        private async Task IncrementCodeUsage(string submittedCode)
        {
            using (var _context = new ApplicationDbContext())
            {
                var articleTotalViews = _context.FeaturedCodesList.SingleOrDefault(a => a.Code == submittedCode);
                articleTotalViews.UseCount++;
                await _context.SaveChangesAsync();
            }
        }

    }
}
