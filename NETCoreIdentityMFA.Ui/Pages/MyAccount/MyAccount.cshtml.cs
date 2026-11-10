using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NETCoreIdentityMFA.Ui.Pages.MyAccount
{
    [Authorize(AuthenticationSchemes = "CookieAuth")]
    public class MyAccountModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
