using Skoruba.AuditLogging.Events;
using IdentityServer.UI.Configuration;
using IdentityServer.UI.ViewModels.Identity;

namespace IdentityServer.UI.Events.IdentityResource
{
    public class IdentityResourcesRequestedEvent : AuditEvent
    {
        public IdentityResourcesDto IdentityResources { get; }

        public IdentityResourcesRequestedEvent(IdentityResourcesDto identityResources)
        {
            IdentityResources = identityResources;
        }
    }
}