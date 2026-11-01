using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NETCoreIdentityMFA.Ui.Models;
using System.Security.Claims;

namespace NETCoreIdentityMFA.Ui.Pages.Login
{
    
    public class IndexModel : PageModel
    {
        [BindProperty]
        public CredentialViewModel Credential { get; set; } = new CredentialViewModel();
        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostLoginDataAsync(string? ReturnUrl = null)
        {
            if (!ModelState.IsValid) return Page();

            if(Credential.UserName == "admin@admin.com" && Credential.Password == "password")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, Credential.UserName),
                    new Claim(ClaimTypes.NameIdentifier, Credential.Password),
                    new Claim(ClaimTypes.Role, "Admin,User"),
                    new Claim(ClaimTypes.Email, Credential.UserName),
                    new Claim("image", Credential.UserName),
                };

                var identity = new ClaimsIdentity(claims, "CookieAuth");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("CookieAuth", claimsPrincipal);
                return RedirectToPage("/Index");

            }
            return Page();
        }
    }
}
