using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NETCoreIdentityMFA.Ui.Pages.Todo
{
    [Authorize(AuthenticationSchemes = "CookieAuth")]
    public class TodoModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
