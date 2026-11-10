using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NETCoreIdentityMFA.Ui.Pages.VideoCall
{
    [Authorize(AuthenticationSchemes = "CookieAuth")]
    public class VideoCallModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
