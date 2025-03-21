namespace Infrastructure.Core.Interfaces.Application.UtilityServices
{
    public interface IVerificationService
    {
        Task SendVerificationCodeAsync(Guid userId, string email, string subject);
        Task SendVerificationCodeAsync(Guid userId, string email, string subject, string token);
        Task<bool> VerifyCodeAsync(Guid userId, string code);
    }
}
