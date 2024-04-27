using GatheringForGood.Data;
using System;
using GatheringForGood.Areas.Identity.Data;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class SaveUserModalEntry
    {

        public async Task saveUserEntryAsync(string newsfeedUserEntry, string userId, string dataSource, DateTime FeedbackDateTime)
        {
            var feedback = new UserFeedback()
            {
                UserId = userId,
                FeedbackDate = FeedbackDateTime,
                Feedback = newsfeedUserEntry,
                DataSource = dataSource
            };
            using (var _context = new ApplicationDbContext())
            {
                await _context.AddAsync(feedback);
                await _context.SaveChangesAsync();
            }
        }
    }
}
