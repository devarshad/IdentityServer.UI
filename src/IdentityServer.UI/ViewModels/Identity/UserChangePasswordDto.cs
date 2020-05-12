using System.ComponentModel.DataAnnotations;
using IdentityServer.UI.ViewModels.Identity.Base;
using IdentityServer.UI.ViewModels.Identity.Interfaces;

namespace IdentityServer.UI.ViewModels.Identity
{
    public class UserChangePasswordDto<TUserDtoKey> : BaseUserChangePasswordDto<TUserDtoKey>, IUserChangePasswordDto
    {
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
