using Microsoft.AspNetCore.Identity.UI.Services;

namespace AccountPage.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // Email logics to be implemented here
            return Task.CompletedTask;
        }
    }
}
