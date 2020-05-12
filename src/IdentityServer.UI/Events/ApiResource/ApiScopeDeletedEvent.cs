using Skoruba.AuditLogging.Events;
using IdentityServer.UI.Configuration;
using IdentityServer.UI.ViewModels.Api;

namespace IdentityServer.UI.Events.ApiResource
{
    public class ApiScopeDeletedEvent : AuditEvent
    {
        public ApiScopesDto ApiScope { get; set; }

        public ApiScopeDeletedEvent(ApiScopesDto apiScope)
        {
            ApiScope = apiScope;
        }
    }
}