using System.ComponentModel.DataAnnotations;

namespace IdentityServer.UI.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
