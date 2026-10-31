using System.ComponentModel.DataAnnotations;

namespace NETCoreIdentityMFA.Ui.Models
{
    public class CredentialViewModel
    {
        [Required(ErrorMessage = "*")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }
}
