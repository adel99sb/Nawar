using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Nawar.API.Core.Entities;
using Nawar.API.Core.Interfaces.Application.UtilityServices;
using Nawar.API.Infrastructure.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Nawar.API.Application.UtilityServices
{
    public class JwtService : IJwtService
    {
        public async Task<string> GenerateToken(AppUser user, UserManager<AppUser> userManager)
        {
            var jwtSettings = ProjectConfig.Instance.JwtSettings; // Access singleton config instance

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email, user.Email)
            };

            var roles = await userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Secret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: jwtSettings.Issuer,
                audience: jwtSettings.Audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(jwtSettings.ExpiryMinutes),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }

}
