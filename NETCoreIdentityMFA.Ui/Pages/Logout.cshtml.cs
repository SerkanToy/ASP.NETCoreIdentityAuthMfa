using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NETCoreIdentityMFA.Ui.Pages
{
    [Authorize(AuthenticationSchemes = "CookieAuth")]
    public class LogoutModel : PageModel
    {
        public async Task<IActionResult> OnPostLogOutAsync()
        {
            await HttpContext.SignOutAsync("CookieAuth");
            return await Task.Run(() => { return RedirectToPage("/Index"); });
        }
    }
}
