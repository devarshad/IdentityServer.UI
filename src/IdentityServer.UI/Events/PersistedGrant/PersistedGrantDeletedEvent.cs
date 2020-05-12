using Skoruba.AuditLogging.Events;

namespace IdentityServer.UI.Events.PersistedGrant
{
    public class PersistedGrantDeletedEvent : AuditEvent
    {
        public string PersistedGrantKey { get; set; }

        public PersistedGrantDeletedEvent(string persistedGrantKey)
        {
            PersistedGrantKey = persistedGrantKey;
        }
    }
}