using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace SafeVault.Web.Controllers
{
    [Authorize] // Ensure authentication is required
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var userEmail = User.FindFirst(ClaimTypes.Email)?.Value;

            if (userId == null)
            {
                return Unauthorized("User is not authenticated."); // Debugging response
            }

            ViewData["UserId"] = userId;
            ViewData["UserEmail"] = userEmail;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
