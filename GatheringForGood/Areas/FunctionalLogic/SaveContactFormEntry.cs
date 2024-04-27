using GatheringForGood.Data;
using System;
using System.Threading.Tasks;
using GatheringForGood.Areas.Identity.Data;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class SaveContactFormEntry
    {
        public async Task saveUserEntryAsync(DateTime FeedbackDateTime, string name, string email, string subject, string thoughts, bool tandc)
        {
            var contactDetails = new UserContact()
            {
                FeedbackDate = FeedbackDateTime,
                Name = name,
                Email = email,
                Subject = subject,
                Thoughts = thoughts,
                TandC = tandc
            };
            using (var _context = new ApplicationDbContext())
            {
                await _context.AddAsync(contactDetails);
                await _context.SaveChangesAsync();
            }
        }
    }
}
