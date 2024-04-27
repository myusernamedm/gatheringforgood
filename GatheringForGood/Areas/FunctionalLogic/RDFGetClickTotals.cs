using GatheringForGood.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class RDFGetClickTotals
    {
        private static readonly ApplicationDbContext _context = new();

        public static List<string> GetTotalClicks(string userId, bool getUserActions)
        {
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            var siteActions = _context.SiteEnvironmentalActionCounts.FirstOrDefault();

            List<string> totalActionsList = new();

            if (getUserActions)
            {
                string siteImpactTotal = siteActions.SiteTotal.ToString();
                totalActionsList.Add(siteImpactTotal);

                string rdfImpactTotal = siteActions.SiteDeforestationTotal.ToString();
                totalActionsList.Add(rdfImpactTotal);

                double AllUserCo2Total = siteActions.AllUserCo2Total;
                double AllUserCo2TotalRounded = Math.Round((Double)AllUserCo2Total, 2);
                string AllUserCo2TotalString = AllUserCo2TotalRounded.ToString();
                totalActionsList.Add(AllUserCo2TotalString);

                var userActions = _context.UserEnvironmentalActionCounts.Find(userId);
                string userTotal = userActions.UserTotal.ToString();
                totalActionsList.Add(userTotal);

                double userCO2Total = userActions.UserCO2Total;
                double userCO2TotalRounded = Math.Round((Double)userCO2Total, 2);
                string userCO2TotalString = userCO2TotalRounded.ToString();
                totalActionsList.Add(userCO2TotalString);
            }
            else
            {
                string siteImpactTotal = siteActions.SiteTotal.ToString();
                totalActionsList.Add(siteImpactTotal);

                string rdfImpactTotal = siteActions.SiteDeforestationTotal.ToString();
                totalActionsList.Add(rdfImpactTotal);

                double AllUserCo2Total = siteActions.AllUserCo2Total;
                double AllUserCo2TotalRounded = Math.Round((Double)AllUserCo2Total, 2);
                string AllUserCo2TotalString = AllUserCo2TotalRounded.ToString();
                totalActionsList.Add(AllUserCo2TotalString);
            }

            return totalActionsList;
        }
    }
}
