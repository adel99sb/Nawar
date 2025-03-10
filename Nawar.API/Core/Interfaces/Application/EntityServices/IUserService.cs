using Nawar.API.Core.DTOs.Requestes;
using Nawar.API.Core.DTOs.Responses;

namespace Nawar.API.Core.Interfaces.Application.EntityServices
{
    public interface IUserService
    {
        Task<GeneralResponse> RegisterAsync(RegisterRequestDto registerRequest);
        Task<GeneralResponse> LoginAsync(LoginRequestDto loginRequest);
        Task<GeneralResponse> VerifyEmailAsync(VerifyEmailRequestDto verifyEmailRequestDto);
        Task<GeneralResponse> SendPasswordResetCodeAsync(string email);
        Task<GeneralResponse> ResetPasswordAsync(ResetPasswordRequestDto resetPasswordRequestDto);
    }
}
