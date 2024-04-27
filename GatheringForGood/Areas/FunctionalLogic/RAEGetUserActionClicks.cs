using GatheringForGood.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class RAEGetUserActionClicks
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
                string FamilySizes = userActions.FamilySizes.ToString();
                actionsList.Add(FamilySizes);
                string MinimisePlastic = userActions.MinimisePlastic.ToString();
                actionsList.Add(MinimisePlastic);
                string GoVegetarian = userActions.GoVegetarian.ToString();
                actionsList.Add(GoVegetarian);
                string GoVegan = userActions.GoVegan.ToString();
                actionsList.Add(GoVegan);
                string HabitatRestoration = userActions.HabitatRestoration.ToString();
                actionsList.Add(HabitatRestoration);
                string WildlifeRefuge = userActions.WildlifeRefuge.ToString();
                actionsList.Add(WildlifeRefuge);
                string StandUp = userActions.StandUp.ToString();
                actionsList.Add(StandUp);
                string HerbsAndPesticides = userActions.HerbsAndPesticides.ToString();
                actionsList.Add(HerbsAndPesticides);
                string SlowDown = userActions.SlowDown.ToString();
                actionsList.Add(SlowDown);
                string PlantNative = userActions.PlantNative.ToString();
                actionsList.Add(PlantNative);
                string GreenRecovery = userActions.GreenRecovery.ToString();
                actionsList.Add(GreenRecovery);
                string BuyRecycled = userActions.BuyRecycled.ToString();
                actionsList.Add(BuyRecycled);
                string RecyclingBin = userActions.RecyclingBin.ToString();
                actionsList.Add(RecyclingBin);
                string SignPetition = userActions.SignPetition.ToString();
                actionsList.Add(SignPetition);
            }
            return actionsList;
        }
    }
}
