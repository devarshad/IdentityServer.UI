using Skoruba.AuditLogging.Events;
using IdentityServer.UI.Configuration;
using IdentityServer.UI.ViewModels.Identity;

namespace IdentityServer.UI.Events.IdentityResource
{
    public class IdentityResourceUpdatedEvent : AuditEvent
    {
        public IdentityResourceDto OriginalIdentityResource { get; set; }
        public IdentityResourceDto IdentityResource { get; set; }

        public IdentityResourceUpdatedEvent(IdentityResourceDto originalIdentityResource, IdentityResourceDto identityResource)
        {
            OriginalIdentityResource = originalIdentityResource;
            IdentityResource = identityResource;
        }
    }
}