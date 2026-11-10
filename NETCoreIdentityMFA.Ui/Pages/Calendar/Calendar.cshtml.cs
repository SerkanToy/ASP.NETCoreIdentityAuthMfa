using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NETCoreIdentityMFA.Ui.Pages.Calendar
{
    [Authorize(AuthenticationSchemes = "CookieAuth")]
    public class CalendarModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
