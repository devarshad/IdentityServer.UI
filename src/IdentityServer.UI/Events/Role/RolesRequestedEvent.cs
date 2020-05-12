using Skoruba.AuditLogging.Events;
namespace IdentityServer.UI.Events.Identity
{
    public class RolesRequestedEvent<TRolesDto> : AuditEvent
    {
        public TRolesDto Roles { get; set; }

        public RolesRequestedEvent(TRolesDto roles)
        {
            Roles = roles;
        }
    }
}