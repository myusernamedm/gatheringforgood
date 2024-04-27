using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.FunctionalLogic
{
    public class SendEmailContactForm
    {
        public async Task sendEmailAsync(IEmailSender _emailSender, DateTime FeedbackDateTime, string name, string email, string subject, string thoughts, bool tandc)
        {
            var mailHeader = "Feedback from our - Help Contact Form";
            var mailBody = "SENT AT: " + FeedbackDateTime.ToString() + ". " + "FROM NAME: " + name + ". " + "FROM EMAIL: " + email + ". " + "SUBJECT: " + subject + ". " + "THOUGHTS: " + thoughts + ". " + "T&C TICKED: " + tandc + ". ";
            var emailFrom = "info@gatheringforgood.com";
            await _emailSender.SendEmailAsync(emailFrom, mailHeader, mailBody);
        }
    }
}
