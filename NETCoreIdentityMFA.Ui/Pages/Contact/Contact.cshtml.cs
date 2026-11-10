using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NETCoreIdentityMFA.Ui.Pages.Contact
{
    [Authorize(AuthenticationSchemes = "CookieAuth")]
    public class ContactModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
