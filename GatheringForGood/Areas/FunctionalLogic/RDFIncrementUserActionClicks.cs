using System.Linq;
using GatheringForGood.Data;
using GatheringForGood.Areas.Identity;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class RDFIncrementUserActionClicks
    {
        private readonly IncrementSiteActions _IncrementSiteActions = new();
        private readonly IncrementUserActions _IncrementUserActions = new();
        readonly UserBadgesFunctions AccessUserBadgesFunctions = new();

        public async Task UserClick(int actionNumber, string userId, ApplicationDbContext _context)
        {
            var userActions = await _context.UserEnvironmentalActionCounts.FindAsync(userId);
            var siteTotalActions = await _context.SiteEnvironmentalActionCounts.FirstOrDefaultAsync();
            var userBadgeValues = _context.UserBadges.SingleOrDefault(a => a.UserId == userId);

            userBadgeValues.FirstStep++;
            await AccessUserBadgesFunctions.AddDefeatDeforestationClick(userId, _context);

            //Increment total clicks for RGW Page
            siteTotalActions.SiteDeforestationClicks++;

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
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteReduceMeat = 1, SiteGlobalWarmingTotal = 1, SiteExtinctionTotal = 1, AllUserCo2Total = 2.0075 });
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
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteReduceMeat = 1, SiteGlobalWarmingTotal = 1, SiteExtinctionTotal = 1, AllUserCo2Total = 2.0075 });
                        }
                    }
                    await AccessUserBadgesFunctions.AddKeyDriverOfChangeClick(userId, _context);
                    await _context.SaveChangesAsync();
                    break;
                case 2:

                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.GoVegetarian++; userActions.UserGoVegetarianCO2Total = userActions.UserGoVegetarianCO2Total + 2.0075; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 2.0075; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteGoVegetarian++; }, true, true, true, 2.0075);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteGoVegetarian = 1, SiteGlobalWarmingTotal = 1, SiteExtinctionTotal = 1, AllUserCo2Total = 2.0075 });
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
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteGoVegetarian = 1, SiteGlobalWarmingTotal = 1, SiteExtinctionTotal = 1, AllUserCo2Total = 2.0075 });
                        }
                    }
                    await AccessUserBadgesFunctions.AddKeyDriverOfChangeClick(userId, _context);
                    await _context.SaveChangesAsync();
                    break;
                case 3:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.GoVegan++; userActions.UserGoVeganCO2Total = userActions.UserGoVeganCO2Total + 2.4275; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 2.4275; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteGoVegan++; }, true, true, true, 2.4275);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteGoVegan = 1, SiteGlobalWarmingTotal = 1, SiteExtinctionTotal = 1, AllUserCo2Total = 2.4275 });
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
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteGoVegan = 1, SiteGlobalWarmingTotal = 1, SiteExtinctionTotal = 1, AllUserCo2Total = 2.4275 });
                        }
                    }
                    await AccessUserBadgesFunctions.AddKeyDriverOfChangeClick(userId, _context);
                    await _context.SaveChangesAsync();
                    break;
                case 4:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.EatOrganic++; userActions.UserEatOrganicCO2Total = userActions.UserEatOrganicCO2Total + .140525; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + .140525; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteEatOrganic++; }, true, false, true, .140525);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteEatOrganic = 1, SiteGlobalWarmingTotal = 1, AllUserCo2Total = .140525 });
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
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteEatOrganic = 1, SiteGlobalWarmingTotal = 1, AllUserCo2Total = .140525 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 5:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.HabitatRestoration++; userActions.UserHabitatRestorationCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteHabitatRestoration++; }, false, false, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteHabitatRestoration = 1 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, HabitatRestoration = 1, UserTotal = 1 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteHabitatRestoration++; }, false, false, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteHabitatRestoration = 1 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 6:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.ZeroDeforestation++; userActions.UserZeroDeforestationCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteZeroDeforestation++; }, false, false, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteZeroDeforestation = 1 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, ZeroDeforestation = 1, UserTotal = 1 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteZeroDeforestation++; }, false, false, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteZeroDeforestation = 1 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 7:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.GoPaperless++; userActions.UserGoPaperlessCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteGoPaperless++; }, false, false, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteGoPaperless = 1 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, GoPaperless = 1, UserTotal = 1 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteGoPaperless++; }, false, false, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteGoPaperless = 1 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 8:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.Donate++; userActions.UserDonateCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteDonate++; }, false, false, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteDonate = 1 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, Donate = 1, UserTotal = 1 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteDonate++; }, false, false, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteDonate = 1 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 9:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.PlantTrees++; userActions.UserPlantTreesCO2Total = userActions.UserPlantTreesCO2Total + 21.772; }, userActions => { userActions.UserCO2Total = userActions.UserCO2Total + 21.772; });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SitePlantTrees++; }, true, false, true, 21.772);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SitePlantTrees = 1, SiteGlobalWarmingTotal = 1, AllUserCo2Total = 21.772 });
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
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SitePlantTrees = 1, SiteGlobalWarmingTotal = 1, AllUserCo2Total = 21.772 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 10:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.BuyRecycled++; userActions.UserBuyRecycledCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteBuyRecycled++; }, false, true, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteBuyRecycled = 1, SiteExtinctionTotal = 1 });
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
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteBuyRecycled = 1, SiteExtinctionTotal = 1 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 11:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.StandUp++; userActions.UserStandUpCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteStandUp++; }, true, true, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteStandUp = 1, SiteGlobalWarmingTotal = 1, SiteExtinctionTotal = 1 });
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
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteStandUp = 1, SiteGlobalWarmingTotal = 1, SiteExtinctionTotal = 1 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 12:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.SignPetition++; userActions.UserSignPetitionCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteSignPetition++; }, true, true, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteSignPetition = 1, SiteGlobalWarmingTotal = 1, SiteExtinctionTotal = 1 });
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
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteSignPetition = 1, SiteGlobalWarmingTotal = 1, SiteExtinctionTotal = 1 });
                        }
                    }
                    await _context.SaveChangesAsync();
                    break;
                case 13:
                    if (userActions != null)
                    {
                        await _IncrementUserActions.incrementUserActions(userId, userActions => { userActions.SocialMedia++; userActions.UserSocialMediaCO2Total = 0; }, null);

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteSignPetition++; }, false, false, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteSocialMedia = 1 });
                        }
                    }
                    else
                    {
                        await _context.UserEnvironmentalActionCounts.AddAsync(new UserEnvironmentalActionCounts { Id = userId, SocialMedia = 1, UserTotal = 1 });

                        if (siteTotalActions != null)
                        {
                            await _IncrementSiteActions.incrementSiteActions(siteTotalActions => { siteTotalActions.SiteSignPetition++; }, false, false, true, 0);
                        }
                        else
                        {
                            await _context.SiteEnvironmentalActionCounts.AddAsync(new SiteEnvironmentalActionCounts { SiteTotal = 1, SiteDeforestationTotal = 1, SiteSocialMedia = 1 });
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
