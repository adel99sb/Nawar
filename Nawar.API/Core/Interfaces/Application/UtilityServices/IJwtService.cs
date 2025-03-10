using Microsoft.AspNetCore.Identity;
using Nawar.API.Core.Entities;

namespace Nawar.API.Core.Interfaces.Application.UtilityServices
{
    public interface IJwtService
    {
        Task<string> GenerateToken(AppUser user, UserManager<AppUser> userManager);
    }
}
