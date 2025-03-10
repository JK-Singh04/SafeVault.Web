using Microsoft.AspNetCore.Identity;

namespace SafeVault.Web.Services
{
    public class AuthorizationService(UserManager<IdentityUser> userManager)
    {
        private readonly UserManager<IdentityUser> _userManager = userManager;

        public Task<bool> IsUserInRoleAsync(IdentityUser user, string role)
        {
            return _userManager.IsInRoleAsync(user, role);
        }
    }
}
