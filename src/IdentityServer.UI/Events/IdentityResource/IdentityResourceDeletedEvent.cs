using Skoruba.AuditLogging.Events;
using IdentityServer.UI.Configuration;
using IdentityServer.UI.ViewModels.Identity;

namespace IdentityServer.UI.Events.IdentityResource
{
    public class IdentityResourceDeletedEvent : AuditEvent
    {
        public IdentityResourceDto IdentityResource { get; set; }

        public IdentityResourceDeletedEvent(IdentityResourceDto identityResource)
        {
            IdentityResource = identityResource;
        }
    }
}