using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NETCoreIdentityMFA.Ui.Pages
{
    [Authorize(AuthenticationSchemes = "CookieAuth")]
    public class AccessDeniedModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
