using System.Collections.Generic;

namespace IdentityServer.UI.ViewModels.Identity.Interfaces
{
    public interface IUserProvidersDto : IUserProviderDto
    {
        List<IUserProviderDto> Providers { get; }
    }
}
