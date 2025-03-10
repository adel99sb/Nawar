namespace Nawar.API.Core.Interfaces.Application.UtilityServices
{
    public interface IEmailService
    {
        public Task<bool> SendEmailAsync(string toEmail, string subject, string body);
    }
}
