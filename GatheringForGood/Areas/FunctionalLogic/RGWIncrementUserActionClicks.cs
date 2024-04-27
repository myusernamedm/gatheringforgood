using System.Linq;
using GatheringForGood.Data;
using GatheringForGood.Areas.Identity;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class RGWIncrementUserActionClicks
    {
        private readonly IncrementSiteActions _IncrementSiteActions = new();
        private readonly IncrementUserActions _IncrementUserActions = new();
        readonly UserBadgesFunctions AccessUserBadgesFunctions = new();

        public async Task UserClick(int actionNumber, string userId, ApplicationDbContext _context)
        {
            var userActions = await _context.UserEnvironmentalActionCounts.FindAsync(userId);
            var siteTotalActions = await _context.SiteEnvironmentalActionCounts.FirstOrDefaultAsync();
            var userBadgeValues = _context.UserBadges.SingleOrDefault(a => a.UserId == userId);

            if(actionNumber != 999)
            {
                userBadgeValues.FirstStep++;
                await AccessUserBadgesFunctions.AddDefeatGlobalWarmingClick(userId, _context);
            }

            //Increment total clicks for RGW Page
            siteTotalActions.SiteGlobalWarmingClicks++;

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
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteReduceMeat = 1, SiteDeforestationTotal = 1, SiteExtinctionTotal = 1, AllUserCo2Total = 2.0075 });
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
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteReduceMeat = 1, SiteDeforestationTotal = 1, SiteExtinctionTotal = 1, AllUserCo2Total = 2.0075 });
                        }
                    }
                    await AccessUserBadgesFunctions.AddKeyDriverOfChangeClick(userId, _context);
                    await _context.SaveChangesAsync();
                    break;
                case 2:

                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.PlantTrees++; userActions.UserPlantTreesCO2Total = userActions.UserPlantTreesCO2Total + 21.772; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 21.772; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SitePlantTrees++; }, true, false, true, 21.772);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SitePlantTrees = 1, SiteDeforestationTotal = 1, AllUserCo2Total = 21.772 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, PlantTrees = 1, UserTotal = 1, UserPlantTreesCO2Total = 21.772, UserCO2Total = 21.772 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SitePlantTrees++; }, true, false, true, 21.772);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SitePlantTrees = 1, SiteDeforestationTotal = 1, AllUserCo2Total = 21.772 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 3:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.EatOrganic++; userActions.UserEatOrganicCO2Total = userActions.UserEatOrganicCO2Total + .140525; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + .140525; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteEatOrganic++; }, true, false, true, .140525);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteEatOrganic = 1, SiteDeforestationTotal = 1, AllUserCo2Total = .140525 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, EatOrganic = 1, UserTotal = 1, UserEatOrganicCO2Total = .140525, UserCO2Total = .140525 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteEatOrganic++; }, true, false, true, .140525);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteEatOrganic = 1, SiteDeforestationTotal = 1, AllUserCo2Total = .140525 });
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
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteGoVegetarian = 1, SiteDeforestationTotal = 1, SiteExtinctionTotal = 1, AllUserCo2Total = 2.0075 });
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
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteGoVegetarian = 1, SiteDeforestationTotal = 1, SiteExtinctionTotal = 1, AllUserCo2Total = 2.0075 });
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
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteGoVegan = 1, SiteDeforestationTotal = 1, SiteExtinctionTotal = 1, AllUserCo2Total = 2.4275 });
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
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteGoVegan = 1, SiteDeforestationTotal = 1, SiteExtinctionTotal = 1, AllUserCo2Total = 2.4275 });
                        }
                    }
                    await AccessUserBadgesFunctions.AddKeyDriverOfChangeClick(userId, _context);
                    await _context.SaveChangesAsync();
                    break;
                case 6:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.LiveCarFree++; userActions.UserLiveCarFreeCO2Total = userActions.UserLiveCarFreeCO2Total + 12.6; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 12.6; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteLiveCarFree++; }, true, false, false, 12.6);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteLiveCarFree = 1, AllUserCo2Total = 12.6 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, LiveCarFree = 1, UserTotal = 1, UserLiveCarFreeCO2Total = 12.6, UserCO2Total = 12.6 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteLiveCarFree++; }, true, false, false, 12.6);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteLiveCarFree = 1, AllUserCo2Total = 12.6 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 7:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.GreenRecovery++; userActions.UserGreenRecoveryCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteGreenRecovery++; }, true, true, false, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteGreenRecovery = 1 });
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
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteGreenRecovery = 1 });
                        }
                    }
                    await AccessUserBadgesFunctions.AddPromoteGreenRecoveryClick(userId, _context);
                    await _context.SaveChangesAsync();
                    break;
                case 8:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.MinimisePlastic++; userActions.UserMinimisePlasticCO2Total = userActions.UserMinimisePlasticCO2Total + 0.0828; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 0.0828; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteMinimisePlastic++; }, true, true, false, 0.0828);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteMinimisePlastic = 1, SiteExtinctionTotal = 1, AllUserCo2Total = 0.0828 });
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
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteMinimisePlastic = 1, SiteExtinctionTotal = 1, AllUserCo2Total = 0.0828 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 9:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.BuyLocal++; userActions.UserBuyLocalCO2Total = userActions.UserBuyLocalCO2Total + 0.140525; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 0.140525; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteBuyLocal++; }, true, false, false, 0.140525);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteBuyLocal = 1, AllUserCo2Total = 0.140525 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, BuyLocal = 1, UserTotal = 1, UserBuyLocalCO2Total = 0.140525, UserCO2Total = 0.140525 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteBuyLocal++; }, true, false, false, 0.140525);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteBuyLocal = 1, AllUserCo2Total = 0.140525 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 10:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.Cycle++; userActions.UserCycleCO2Total = userActions.UserCycleCO2Total + 0.178; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 0.178; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteCycle++; }, true, false, false, 0.178);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteCycle = 1, AllUserCo2Total = 0.178 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, Cycle = 1, UserTotal = 1, UserCycleCO2Total = 0.178, UserCO2Total = 0.178 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteCycle++; }, true, false, false, 0.178);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteCycle = 1, AllUserCo2Total = 0.178 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 11:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.DriveElectric++; userActions.UserDriveElectricCO2Total = userActions.UserDriveElectricCO2Total + 3.6986; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 3.6986; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteDriveElectric++; }, true, false, false, 3.6986);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteDriveElectric = 1, AllUserCo2Total = 3.6986 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, DriveElectric = 1, UserTotal = 1, UserDriveElectricCO2Total = 3.6986, UserCO2Total = 3.6986 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteDriveElectric++; }, true, false, false, 3.6986);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteDriveElectric = 1, AllUserCo2Total = 3.6986 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 12:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.GrowVeg++; userActions.UserGrowVegCO2Total = userActions.UserGrowVegCO2Total + 0.0845041096; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 0.0845041096; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteGrowVeg++; }, true, false, false, 0.0845041096);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteGrowVeg = 1, AllUserCo2Total = 0.0845041096 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, GrowVeg = 1, UserTotal = 1, UserGrowVegCO2Total = 0.0845041096, UserCO2Total = 0.0845041096 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteGrowVeg++; }, true, false, false, 0.0845041096);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteGrowVeg = 1, AllUserCo2Total = 0.0845041096 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 13:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.RenewableEnergy++; userActions.UserRenewableEnergyCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteRenewableEnergy++; }, true, false, false, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteRenewableEnergy = 1 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, RenewableEnergy = 1, UserTotal = 1 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteRenewableEnergy++; }, true, false, false, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteRenewableEnergy = 1 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 14:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.PublicTransport++; userActions.UserPublicTransportCO2Total = userActions.UserPublicTransportCO2Total + 12.042; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 12.042; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SitePublicTransport++; }, true, false, false, 12.042);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SitePublicTransport = 1, AllUserCo2Total = 12.042 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, PublicTransport = 1, UserTotal = 1, UserPublicTransportCO2Total = 12.042, UserCO2Total = 12.042 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SitePublicTransport++; }, true, false, false, 12.042);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SitePublicTransport = 1, AllUserCo2Total = 12.042 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 15:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.Carpool++; userActions.UserCarpoolCO2Total = userActions.UserCarpoolCO2Total + 9.345; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 9.345; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteCarpool++; }, true, false, false, 9.345);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteCarpool = 1, AllUserCo2Total = 9.345 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, Carpool = 1, UserTotal = 1, UserCarpoolCO2Total = 9.345, UserCO2Total = 9.345 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteCarpool++; }, true, false, false, 9.345);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteCarpool = 1, AllUserCo2Total = 9.345 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 16:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.FlyLess++; userActions.UserFlyLessCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteFlyLess++; }, true, false, false, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteFlyLess = 1 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, FlyLess = 1, UserTotal = 1 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteFlyLess++; }, true, false, false, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteFlyLess = 1 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 17:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.StandUp++; userActions.UserStandUpCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteStandUp++; }, true, true, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteStandUp = 1, SiteDeforestationTotal = 1, SiteExtinctionTotal = 1 });
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
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteStandUp = 1, SiteDeforestationTotal = 1, SiteExtinctionTotal = 1 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 18:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.RecyclingBin++; userActions.UserRecyclingBinCO2Total = userActions.UserRecyclingBinCO2Total + 2.484; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 2.484; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteRecyclingBin++; }, true, true, false, 2.484);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteRecyclingBin = 1, SiteExtinctionTotal = 1, AllUserCo2Total = 2.484 });
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
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteRecyclingBin = 1, SiteExtinctionTotal = 1, AllUserCo2Total = 2.484 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 19:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.CompostBin++; userActions.UserCompostBinCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteCompostBin++; }, true, false, false, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteCompostBin = 1 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, CompostBin = 1, UserTotal = 1 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteCompostBin++; }, true, false, false, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteCompostBin = 1 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 20:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.HomeInsulation++; userActions.UserHomeInsulationCO2Total = userActions.UserHomeInsulationCO2Total + 1890; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 1890; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteHomeInsulation++; }, true, false, false, 1890);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteHomeInsulation = 1, AllUserCo2Total = 1890 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, HomeInsulation = 1, UserTotal = 1, UserHomeInsulationCO2Total = 1890, UserCO2Total = 1890 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteHomeInsulation++; }, true, false, false, 1890);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteHomeInsulation = 1, AllUserCo2Total = 1890 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 21:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.ShorterShowers++; userActions.UserShorterShowersCO2Total = userActions.UserShorterShowersCO2Total + 1.021; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 1.021; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteShorterShowers++; }, true, false, false, 1.021);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteShorterShowers = 1, AllUserCo2Total = 1.021 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, ShorterShowers = 1, UserTotal = 1, UserShorterShowersCO2Total = 1.021, UserCO2Total = 1.021 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteShorterShowers++; }, true, false, false, 1.021);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteShorterShowers = 1, AllUserCo2Total = 1.021 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 22:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.FluorescentBulbs++; userActions.UserFluorescentBulbsCO2Total = userActions.UserFluorescentBulbsCO2Total + .093; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + .093; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteFluorescentBulbs++; }, true, false, false, .093);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteFluorescentBulbs = 1, AllUserCo2Total = .093 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, FluorescentBulbs = 1, UserTotal = 1, UserFluorescentBulbsCO2Total = .093, UserCO2Total = .093 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteFluorescentBulbs++; }, true, false, false, .093);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteFluorescentBulbs = 1, AllUserCo2Total = .093 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 23:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.TurnOffLights++; userActions.UserTurnOffLightsCO2Total = userActions.UserTurnOffLightsCO2Total + .00775; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + .00775; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteTurnOffLights++; }, true, false, false, .00775);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteTurnOffLights = 1, AllUserCo2Total = .00775 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, TurnOffLights = 1, UserTotal = 1, UserTurnOffLightsCO2Total = .00775, UserCO2Total = .00775 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteTurnOffLights++; }, true, false, false, .00775);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteTurnOffLights = 1, AllUserCo2Total = .00775 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 24:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.SignPetition++; userActions.UserSignPetitionCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteSignPetition++; }, true, true, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteSignPetition = 1, SiteDeforestationTotal = 1, SiteExtinctionTotal = 1 });
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
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteGlobalWarmingTotal = 1, SiteSignPetition = 1, SiteDeforestationTotal = 1, SiteExtinctionTotal = 1 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                default:

                    await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId});
                    await _context.SaveChangesAsync();
                    break;
            }
        }
    }
}

