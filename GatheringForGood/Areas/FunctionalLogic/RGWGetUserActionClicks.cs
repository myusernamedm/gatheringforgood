using GatheringForGood.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class RGWGetUserActionClicks
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
            string PlantTrees = userActions.PlantTrees.ToString();
            actionsList.Add(PlantTrees);
            string EatOrganic = userActions.EatOrganic.ToString();
            actionsList.Add(EatOrganic);
            string GoVegetarian = userActions.GoVegetarian.ToString();
            actionsList.Add(GoVegetarian);
            string GoVegan = userActions.GoVegan.ToString();
            actionsList.Add(GoVegan);
            string LiveCarFree = userActions.LiveCarFree.ToString();
            actionsList.Add(LiveCarFree);
            string GreenRecovery = userActions.GreenRecovery.ToString();
            actionsList.Add(GreenRecovery);
            string MinimisePlastic = userActions.MinimisePlastic.ToString();
            actionsList.Add(MinimisePlastic);
            string BuyLocal = userActions.BuyLocal.ToString();
            actionsList.Add(BuyLocal);
            string Cycle = userActions.Cycle.ToString();
            actionsList.Add(Cycle);
            string DriveElectric = userActions.DriveElectric.ToString();
            actionsList.Add(DriveElectric);
            string GrowVeg = userActions.GrowVeg.ToString();
            actionsList.Add(GrowVeg);
            string RenewableEnergy = userActions.RenewableEnergy.ToString();
            actionsList.Add(RenewableEnergy);
            string PublicTransport = userActions.PublicTransport.ToString();
            actionsList.Add(PublicTransport);
            string Carpool = userActions.Carpool.ToString();
            actionsList.Add(Carpool);
            string FlyLess = userActions.FlyLess.ToString();
            actionsList.Add(FlyLess);
            string StandUp = userActions.StandUp.ToString();
            actionsList.Add(StandUp);
            string RecyclingBin = userActions.RecyclingBin.ToString();
            actionsList.Add(RecyclingBin);
            string CompostBin = userActions.CompostBin.ToString();
            actionsList.Add(CompostBin);
            string HomeInsulation = userActions.HomeInsulation.ToString();
            actionsList.Add(HomeInsulation);
            string ShorterShowers = userActions.ShorterShowers.ToString();
            actionsList.Add(ShorterShowers);
            string FluorescentBulbs = userActions.FluorescentBulbs.ToString();
            actionsList.Add(FluorescentBulbs);
            string TurnOffLights = userActions.TurnOffLights.ToString();
            actionsList.Add(TurnOffLights);
            string SignPetition = userActions.SignPetition.ToString();
            actionsList.Add(SignPetition);
            }
            return actionsList;
        }
    }
}
