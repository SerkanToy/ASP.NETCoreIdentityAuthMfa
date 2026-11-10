using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NETCoreIdentityMFA.Ui.Pages.MyProfile
{
    [Authorize(AuthenticationSchemes = "CookieAuth")]
    public class MyProfileModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
