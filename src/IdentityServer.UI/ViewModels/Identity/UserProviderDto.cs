using IdentityServer.UI.ViewModels.Identity.Base;
using IdentityServer.UI.ViewModels.Identity.Interfaces;

namespace IdentityServer.UI.ViewModels.Identity
{
    public class UserProviderDto<TUserDtoKey> : BaseUserProviderDto<TUserDtoKey>, IUserProviderDto
    {
        public string UserName { get; set; }

        public string ProviderKey { get; set; }

        public string LoginProvider { get; set; }

        public string ProviderDisplayName { get; set; }
    }
}
