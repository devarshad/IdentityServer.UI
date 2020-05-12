using System.ComponentModel.DataAnnotations;
using IdentityServer.UI.ViewModels.Identity.Base;
using IdentityServer.UI.ViewModels.Identity.Interfaces;

namespace IdentityServer.UI.ViewModels.Identity
{
    public class UserClaimDto<TUserDtoKey> : BaseUserClaimDto<TUserDtoKey>, IUserClaimDto
    {
        [Required]
        public string ClaimType { get; set; }

        [Required]
        public string ClaimValue { get; set; }
    }
}