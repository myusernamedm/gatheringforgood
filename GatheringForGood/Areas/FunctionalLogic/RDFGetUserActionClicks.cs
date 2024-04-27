using GatheringForGood.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class RDFGetUserActionClicks
    {
        private static readonly ApplicationDbContext _context = new();

        public static List<string> GetClicks(string userId)
        {
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            var userActions = _context.UserEnvironmentalActionCounts.Find(userId);

            List<string> actionsList = new();

            if (userActions != null)
            {
                string ReduceMeat = userActions.ReduceMeat.ToString();
                actionsList.Add(ReduceMeat);
                string GoVegetarian = userActions.GoVegetarian.ToString();
                actionsList.Add(GoVegetarian);
                string GoVegan = userActions.GoVegan.ToString();
                actionsList.Add(GoVegan);
                string EatOrganic = userActions.EatOrganic.ToString();
                actionsList.Add(EatOrganic);
                string HabitatRestoration = userActions.HabitatRestoration.ToString();
                actionsList.Add(HabitatRestoration);
                string ZeroDeforestation = userActions.ZeroDeforestation.ToString();
                actionsList.Add(ZeroDeforestation);
                string GoPaperless = userActions.GoPaperless.ToString();
                actionsList.Add(GoPaperless);
                string Donate = userActions.Donate.ToString();
                actionsList.Add(Donate);
                string PlantTrees = userActions.PlantTrees.ToString();
                actionsList.Add(PlantTrees);
                string BuyRecycled = userActions.BuyRecycled.ToString();
                actionsList.Add(BuyRecycled);
                string StandUp = userActions.StandUp.ToString();
                actionsList.Add(StandUp);
                string SignPetition = userActions.SignPetition.ToString();
                actionsList.Add(SignPetition);
                string SocialMedia = userActions.SocialMedia.ToString();
                actionsList.Add(SocialMedia);
            }
            return actionsList;
        }
    }
}
