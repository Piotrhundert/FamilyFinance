using FamilyFinance.Web.Security;
using Microsoft.AspNetCore.Identity;

namespace FamilyFinance.Web.Data;

public static class IdentityRoleSeeder
{
    public static async Task SeedAsync(IServiceProvider services)
    {
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

        foreach (var roleName in AppRoles.All)
        {
            if (await roleManager.RoleExistsAsync(roleName))
            {
                continue;
            }

            var result = await roleManager.CreateAsync(new IdentityRole(roleName));

            if (!result.Succeeded)
            {
                var errors = string.Join(
                    "; ",
                    result.Errors.Select(error => $"{error.Code}: {error.Description}"));

                throw new InvalidOperationException(
                    $"Nie udało się utworzyć roli '{roleName}'. {errors}");
            }
        }
    }
}
