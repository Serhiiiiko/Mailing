using WebApiApp.Models;

namespace WebApiApp.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}
