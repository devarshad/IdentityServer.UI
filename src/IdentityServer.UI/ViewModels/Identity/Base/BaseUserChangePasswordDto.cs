using IdentityServer.UI.ViewModels.Identity.Interfaces;

namespace IdentityServer.UI.ViewModels.Identity.Base
{
    public class BaseUserChangePasswordDto<TUserId> : IBaseUserChangePasswordDto
    {
        public TUserId UserId { get; set; }

        object IBaseUserChangePasswordDto.UserId => UserId;
    }
}