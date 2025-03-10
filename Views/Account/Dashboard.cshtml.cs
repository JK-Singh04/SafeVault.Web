using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SafeVault.Web.Pages
{
    [Authorize]
    public class DashboardModel : PageModel, IAsyncPageFilter, IPageFilter, IFilterMetadata
    {
        public string UserEmail { get; set; } = string.Empty; // Initialize with a default value

        public void OnGet()
        {
            var emailClaim = User.FindFirst(ClaimTypes.Email);
            UserEmail = emailClaim?.Value ?? string.Empty;
        }
    }
}
