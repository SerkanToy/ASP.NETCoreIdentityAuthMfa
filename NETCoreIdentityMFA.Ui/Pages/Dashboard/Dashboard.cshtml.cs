using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NETCoreIdentityMFA.Ui.Pages.Dashboard
{
    [Authorize(AuthenticationSchemes = "CookieAuth", Policy = "ManagerOnly")]
    public class DashboardModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
