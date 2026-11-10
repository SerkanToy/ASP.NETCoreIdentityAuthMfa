using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NETCoreIdentityMFA.Ui.Pages.Inbox
{
    [Authorize(AuthenticationSchemes = "CookieAuth")]
    public class InboxModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
