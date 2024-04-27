using System.Linq;
using GatheringForGood.Data;
using GatheringForGood.Areas.Identity;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class RAEIncrementUserActionClicks
    {
        private static readonly IncrementSiteActions _IncrementSiteActions = new();
        private static readonly IncrementUserActions _IncrementUserActions = new();
        readonly UserBadgesFunctions AccessUserBadgesFunctions = new();

        public async Task UserClick(int actionNumber, string userId, ApplicationDbContext _context)
        {
            var userActions = await _context.UserEnvironmentalActionCounts.FindAsync(userId);
            var siteTotalActions = await _context.SiteEnvironmentalActionCounts.FirstOrDefaultAsync();
            var userBadgeValues = _context.UserBadges.SingleOrDefault(a => a.UserId == userId);

            userBadgeValues.FirstStep++;
            await AccessUserBadgesFunctions.AddDefeatAnimalExtinctionClick(userId, _context);

            //Increment total clicks for RGW Page
            siteTotalActions.SiteExtinctionClicks++;

            //Increment specific action clicks for user and site

            switch (actionNumber)
            {
                case 1:

                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.ReduceMeat++; userActions.UserReduceMeatCO2Total = userActions.UserReduceMeatCO2Total + 2.0075; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 2.0075; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteReduceMeat++; }, true, true, true, 2.0075);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteReduceMeat = 1, SiteDeforestationTotal = 1, SiteGlobalWarmingTotal = 1, AllUserCo2Total = 2.0075 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, ReduceMeat = 1, UserTotal = 1, UserReduceMeatCO2Total = 2.0075, UserCO2Total = 2.0075 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteReduceMeat++; }, true, true, true, 2.0075);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteReduceMeat = 1, SiteDeforestationTotal = 1, SiteGlobalWarmingTotal = 1, AllUserCo2Total = 2.0075 });
                        }
                    }
                    await AccessUserBadgesFunctions.AddKeyDriverOfChangeClick(userId, _context);
                    await _context.SaveChangesAsync();
                    break;
                case 2:

                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.FamilySizes++; userActions.UserFamilySizesCO2Total = userActions.UserFamilySizesCO2Total + 3900; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 3900; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteFamilySizes++; }, true, true, false, 3900);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteFamilySizes = 1, SiteGlobalWarmingTotal = 1, AllUserCo2Total = 3900 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, FamilySizes = 1, UserTotal = 1, UserFamilySizesCO2Total = 3900, UserCO2Total = 3900 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteFamilySizes++; }, true, true, false, 3900);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteFamilySizes = 1, SiteGlobalWarmingTotal = 1, AllUserCo2Total = 3900 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 3:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.MinimisePlastic++; userActions.UserMinimisePlasticCO2Total = userActions.UserMinimisePlasticCO2Total + 0.0828; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 0.0828; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteMinimisePlastic++; }, true, true, false, 0.0828);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteMinimisePlastic = 1, SiteGlobalWarmingTotal = 1, AllUserCo2Total = 0.0828 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, MinimisePlastic = 1, UserTotal = 1, UserMinimisePlasticCO2Total = 0.0828, UserCO2Total = 0.0828 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteMinimisePlastic++; }, true, true, false, 0.0828);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteMinimisePlastic = 1, SiteGlobalWarmingTotal = 1, AllUserCo2Total = 0.0828 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 4:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.GoVegetarian++; userActions.UserGoVegetarianCO2Total = userActions.UserGoVegetarianCO2Total + 2.0075; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 2.0075; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteGoVegetarian++; }, true, true, true, 2.0075);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteGoVegetarian = 1, SiteDeforestationTotal = 1, SiteGlobalWarmingTotal = 1, AllUserCo2Total = 2.0075 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, GoVegetarian = 1, UserTotal = 1, UserGoVegetarianCO2Total = 2.0075, UserCO2Total = 2.0075 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteGoVegetarian++; }, true, true, true, 2.0075);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteGoVegetarian = 1, SiteDeforestationTotal = 1, SiteGlobalWarmingTotal = 1, AllUserCo2Total = 2.0075 });
                        }
                    }
                    await AccessUserBadgesFunctions.AddKeyDriverOfChangeClick(userId, _context);
                    await _context.SaveChangesAsync();
                    break;
                case 5:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.GoVegan++; userActions.UserGoVeganCO2Total = userActions.UserGoVeganCO2Total + 2.4275; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 2.4275; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteGoVegan++; }, true, true, true, 2.4275);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteGoVegan = 1, SiteDeforestationTotal = 1, SiteGlobalWarmingTotal = 1, AllUserCo2Total = 2.4275 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, GoVegan = 1, UserTotal = 1, UserGoVeganCO2Total = 2.4275, UserCO2Total = 2.4275 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteGoVegan++; }, true, true, true, 2.4275);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteGoVegan = 1, SiteDeforestationTotal = 1, SiteGlobalWarmingTotal = 1, AllUserCo2Total = 2.4275 });
                        }
                    }
                    await AccessUserBadgesFunctions.AddKeyDriverOfChangeClick(userId, _context);
                    await _context.SaveChangesAsync();
                    break;
                case 6:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.HabitatRestoration++; userActions.UserHabitatRestorationCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteHabitatRestoration++; }, false, true, false, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteHabitatRestoration = 1 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, HabitatRestoration = 1, UserTotal = 1 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteHabitatRestoration++; }, false, true, false, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteHabitatRestoration = 1 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 7:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.WildlifeRefuge++; userActions.UserWildlifeRefugeCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteWildlifeRefuge++; }, false, true, false, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteWildlifeRefuge = 1 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, WildlifeRefuge = 1, UserTotal = 1 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteWildlifeRefuge++; }, false, true, false, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteWildlifeRefuge = 1 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 8:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.StandUp++; userActions.UserStandUpCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteStandUp++; }, true, true, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteStandUp = 1 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, StandUp = 1, UserTotal = 1 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteStandUp++; }, true, true, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteStandUp = 1 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 9:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.HerbsAndPesticides++; userActions.UserHerbsAndPesticidesCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteHerbsAndPesticides++; }, false, true, false, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteHerbsAndPesticides = 1 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, HerbsAndPesticides = 1, UserTotal = 1 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteHerbsAndPesticides++; }, false, true, false, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteHerbsAndPesticides = 1 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 10:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.SlowDown++; userActions.UserSlowDownCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteSlowDown++; }, false, true, false, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteSlowDown = 1 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, SlowDown = 1, UserTotal = 1 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteSlowDown++; }, false, true, false, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteSlowDown = 1 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 11:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.PlantNative++; userActions.UserPlantNativeCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SitePlantNative++; }, false, true, false, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SitePlantNative = 1 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, PlantNative = 1, UserTotal = 1 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SitePlantNative++; }, false, true, false, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SitePlantNative = 1 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 12:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.GreenRecovery++; userActions.UserGreenRecoveryCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteGreenRecovery++; }, true, true, false, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteGreenRecovery = 1, SiteGlobalWarmingTotal = 1 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, GreenRecovery = 1, UserTotal = 1 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteGreenRecovery++; }, true, true, false, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteGreenRecovery = 1, SiteGlobalWarmingTotal = 1 });
                        }
                    }
                    await AccessUserBadgesFunctions.AddPromoteGreenRecoveryClick(userId, _context);
                    await _context.SaveChangesAsync();
                    break;
                case 13:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.BuyRecycled++; userActions.UserBuyRecycledCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteBuyRecycled++; }, false, true, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteBuyRecycled = 1 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, BuyRecycled = 1, UserTotal = 1 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteBuyRecycled++; }, false, true, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteBuyRecycled = 1 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 14:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.RecyclingBin++; userActions.UserRecyclingBinCO2Total = userActions.UserRecyclingBinCO2Total + 2.484; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 2.484; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteRecyclingBin++; }, true, true, false, 2.484);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteRecyclingBin = 1, SiteGlobalWarmingTotal = 1, AllUserCo2Total = 2.484 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, RecyclingBin = 1, UserTotal = 1, UserRecyclingBinCO2Total = 2.484, UserCO2Total = 2.484 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteRecyclingBin++; }, true, true, false, 2.484);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteRecyclingBin = 1, SiteGlobalWarmingTotal = 1, AllUserCo2Total = 2.484 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 15:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.SignPetition++; userActions.UserSignPetitionCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteSignPetition++; }, true, true, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteSignPetition = 1, SiteDeforestationTotal = 1, SiteGlobalWarmingTotal = 1 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, SignPetition = 1, UserTotal = 1 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteSignPetition++; }, true, true, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteExtinctionTotal = 1, SiteSignPetition = 1, SiteDeforestationTotal = 1, SiteGlobalWarmingTotal = 1 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                default:
                    break;
            }
        }
    }
}
