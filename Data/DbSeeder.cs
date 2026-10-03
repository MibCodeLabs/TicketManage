using Microsoft.AspNetCore.Identity;
using ticketManage.Models;
using ticketManage.Utils;

namespace ticketManage.Data
{
    public static class DbSeeder
    {
        public static async Task SeedAsync(IServiceProvider services)
        {
            var userManager = services.GetRequiredService<UserManager<User>>();

            const string adminEmail = "admin@main.com";
            const string adminPassword = "ChangeMe123!";

            var admin = await userManager.FindByEmailAsync(adminEmail);

            if (admin == null)
            {
                admin = new User
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true,

                    FullName = "System Administrator",
                    AccountType = AccountType.Admin,

                    CreatedBy = "System",
                    ModifiedBy = "System",
                    CreatedAt = DateTime.UtcNow,
                    ModifiedAt = DateTime.UtcNow,
                    IsDeleted = false
                };

                var result = await userManager.CreateAsync(admin, adminPassword);

                if (!result.Succeeded)
                {
                    throw new Exception(
                        string.Join(", ", result.Errors.Select(e => e.Description))
                    );
                }
            }
        }
    }
}