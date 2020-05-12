using IdentityServer.UI.ViewModels.Identity.Interfaces;

namespace IdentityServer.UI.ViewModels.Identity.Base
{
    public class BaseUserProviderDto<TUserId> : IBaseUserProviderDto
    {
        public TUserId UserId { get; set; }

        object IBaseUserProviderDto.UserId => UserId;
    }
}