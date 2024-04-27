using GatheringForGood.Areas.Identity.Data;
using GatheringForGood.Data;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class UserBadgesFunctions
    {
        public async Task AddUserToTable(string userId, ApplicationDbContext _context)
        {
            await _context.UserBadges.AddAsync(new UserBadges { UserId = userId });
            await _context.SaveChangesAsync();
        }

        public async Task AddSocialShareClick(string userId, ApplicationDbContext _context)
        {
            var userBadgeValues = _context.UserBadges.SingleOrDefault(a => a.UserId == userId);
            userBadgeValues.GathererForGood++;
            await _context.SaveChangesAsync();
        }

        public async Task AddPromoteGreenRecoveryClick(string userId, ApplicationDbContext _context)
        {
            var userBadgeValues = _context.UserBadges.SingleOrDefault(a => a.UserId == userId);
            userBadgeValues.BuildingBackBetter++;
            await _context.SaveChangesAsync();
        }

        public async Task AddKeyDriverOfChangeClick(string userId, ApplicationDbContext _context)
        {
            var userBadgeValues = _context.UserBadges.SingleOrDefault(a => a.UserId == userId);
            userBadgeValues.KeyDriverOfChange++;
            await _context.SaveChangesAsync();
        }

        public async Task AddDefeatGlobalWarmingClick(string userId, ApplicationDbContext _context)
        {
            var userBadgeValues = _context.UserBadges.SingleOrDefault(a => a.UserId == userId);
            userBadgeValues.DefeatGlobalWarming++;
            await _context.SaveChangesAsync();
        }

        public async Task AddDefeatAnimalExtinctionClick(string userId, ApplicationDbContext _context)
        {
            var userBadgeValues = _context.UserBadges.SingleOrDefault(a => a.UserId == userId);
            userBadgeValues.DefeatAnimalExtinction++;
            await _context.SaveChangesAsync();
        }

        public async Task AddDefeatDeforestationClick(string userId, ApplicationDbContext _context)
        {
            var userBadgeValues = _context.UserBadges.SingleOrDefault(a => a.UserId == userId);
            userBadgeValues.DefeatDeforestation++;
            await _context.SaveChangesAsync();
        }
    }
}
