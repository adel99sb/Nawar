using Microsoft.AspNetCore.Identity;
using Nawar.API.Core.Consts;
using Nawar.API.Core.Entities;

namespace Nawar.API.Infrastructure.Repositories
{
    public static class Seeder
    {
        public static async Task SeedRolesAndAdminAsync(UserManager<AppUser> userManager, RoleManager<IdentityRole<Guid>> roleManager)
        {
            var roles = new[] { Roles.Admin.ToString(), Roles.User.ToString() };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole<Guid>(role));
                }
            }

            var adminEmail = "admin@domain.com";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);

            if (adminUser == null)
            {
                var admin = new AppUser
                {
                    Email = adminEmail,
                    EmailConfirmed = true,
                    PhoneNumber = "+20 123 123 123",
                    UserName = "Admin",
                    PhoneNumberConfirmed = true,
                };
                await userManager.CreateAsync(admin, "Aa@112233!");
                await userManager.AddToRoleAsync(admin, Roles.Admin.ToString());
            }
        }
    }

}
