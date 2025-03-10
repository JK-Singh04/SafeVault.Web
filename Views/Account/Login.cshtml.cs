using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SafeVault.Web.Models;
using System.Threading.Tasks;

namespace SafeVault.Web.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;

        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [BindProperty]
        public LoginViewModel Input { get; set; } = new();

        public async Task<IActionResult> OnPostAsync()
        {
            var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, false, false);
            return result.Succeeded ? RedirectToPage("/Dashboard") : Page();
        }
    }
}
