using GatheringForGood.Data;
using GatheringForGood.Areas.Identity;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class IncrementSiteActions
    {
        private static readonly ApplicationDbContext _context = new();

        public async Task incrementSiteActions(Action<SiteEnvironmentalActionCounts> updateSpecificAction, bool updateRGWTotal, bool updateRAETotal, bool updateRDFTotal, double AddToAllUserCO2Total)
        {
            var siteTotalActions = await _context.SiteEnvironmentalActionCounts.FirstOrDefaultAsync();

            updateSpecificAction(siteTotalActions);
            siteTotalActions.SiteTotal++;
            siteTotalActions.AllUserCo2Total = siteTotalActions.AllUserCo2Total + AddToAllUserCO2Total;

            if (updateRGWTotal == true)
            {
                siteTotalActions.SiteGlobalWarmingTotal++;
            }
            if (updateRAETotal == true)
            {
                siteTotalActions.SiteExtinctionTotal++;
            }
            if (updateRDFTotal == true)
            {
                siteTotalActions.SiteDeforestationTotal++;
            }
            await _context.SaveChangesAsync();
        }
    }
}
