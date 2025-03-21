using Infrastructure.Core.Consts;
using Infrastructure.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Repositories
{
    public static class Seeder
    {
        public static async Task SeedRolesAndAdminAsync(UserManager<AppUser> userManager, RoleManager<IdentityRole<Guid>> roleManager)
        {
            var roles = Enum.GetNames<Roles>();

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole<Guid>(role));
                }
            }

            var adminEmail = "admin@gmail.com";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);

            if (adminUser == null)
            {
                var admin = new Admin
                {
                    Email = adminEmail,
                    EmailConfirmed = true,
                    PhoneNumber = "+963 99 999 999",
                    UserName = "Admin",
                    PhoneNumberConfirmed = true,
                    FullName = "Nawar",
                    Role = Roles.Admin.ToString()
                };
                await userManager.CreateAsync(admin, "Aa@112233!");
                await userManager.AddToRoleAsync(admin, Roles.Admin.ToString());
            }
        }
    }

}
