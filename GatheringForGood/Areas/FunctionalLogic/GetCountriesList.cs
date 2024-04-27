using GatheringForGood.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class GetCountriesList
    {
        private static readonly ApplicationDbContext _context = new();

        public static List<string> GetCountries()
        {
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            var Countries = _context.CountryList.FirstOrDefault();

            List<string> countriesList = new();

            if (Countries != null)
            {
                countriesList = _context.CountryList.Where(c => c.Country != null).Select(c => c.Country).ToList();
            }
            return countriesList;
        }
    }
}
