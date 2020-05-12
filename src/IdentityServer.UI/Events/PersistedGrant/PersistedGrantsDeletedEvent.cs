using Skoruba.AuditLogging.Events;

namespace IdentityServer.UI.Events.PersistedGrant
{
    public class PersistedGrantsDeletedEvent : AuditEvent
    {
        public string UserId { get; set; }

        public PersistedGrantsDeletedEvent(string userId)
        {
            UserId = userId;
        }
    }
}