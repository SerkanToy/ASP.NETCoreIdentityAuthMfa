using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NETCoreIdentityMFA.Ui.Pages.AiChat
{
    [Authorize(AuthenticationSchemes = "CookieAuth")]
    public class AiChatModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
