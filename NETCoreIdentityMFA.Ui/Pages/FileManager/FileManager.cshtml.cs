using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NETCoreIdentityMFA.Ui.Pages.FileManager
{
    [Authorize(AuthenticationSchemes = "CookieAuth", Policy = "ArchiveDepartman")]
    public class FileManagerModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
