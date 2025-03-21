using Infrastructure.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Core.Interfaces.Application.UtilityServices
{
    public interface IJwtService
    {
        Task<string> GenerateToken(AppUser user, UserManager<AppUser> userManager);
    }
}
