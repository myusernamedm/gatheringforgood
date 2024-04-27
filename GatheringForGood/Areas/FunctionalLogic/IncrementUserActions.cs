using GatheringForGood.Data;
using GatheringForGood.Areas.Identity;
using System;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class IncrementUserActions
    {
        private static readonly ApplicationDbContext _context = new();

        public async Task incrementUserActions(string userId, Action<UserEnvironmentalActionCounts> update, Action<UserEnvironmentalActionCounts> updateUserCO2Total)
        {
            var userActions = await _context.UserEnvironmentalActionCounts.FindAsync(userId);

            update(userActions);
            userActions.UserTotal++;
            if (updateUserCO2Total != null)
            {
                updateUserCO2Total(userActions);
            }
            await _context.SaveChangesAsync();
        }
    }
}
