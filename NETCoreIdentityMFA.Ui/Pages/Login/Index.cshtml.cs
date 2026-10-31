using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NETCoreIdentityMFA.Ui.Models;

namespace NETCoreIdentityMFA.Ui.Pages.Login
{
    
    public class IndexModel : PageModel
    {
        [BindProperty]
        public CredentialViewModel Credential { get; set; } = new CredentialViewModel();
        public void OnGet()
        {
        }

        public async Task OnPostLoginData(string? ReturnUrl = null)
        {
            var deger = ReturnUrl;
        }
    }
}
