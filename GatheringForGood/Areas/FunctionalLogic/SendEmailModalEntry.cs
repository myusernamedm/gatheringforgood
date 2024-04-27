using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.FunctionalLogic
{

    public class SendEmailModalEntry
    {

        public async Task sendEmailAsync(IEmailSender _emailSender, string newsfeedUserEntry, bool loggedInUser, string dataSource, DateTime FeedbackDateTime)
        {
            var mailHeader = "Feedback from our - " + dataSource;
            var mailBody = "Logged In User: " + loggedInUser.ToString() + ". " + "Sent at: " + FeedbackDateTime.ToString() + " -> " + newsfeedUserEntry;
            var email = "info@gatheringforgood.com";
            await _emailSender.SendEmailAsync(email, mailHeader, mailBody);

        }

    }
}
