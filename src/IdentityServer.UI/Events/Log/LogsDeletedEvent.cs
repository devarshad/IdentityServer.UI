using System;
using Skoruba.AuditLogging.Events;

namespace IdentityServer.UI.Events.Log
{
    public class LogsDeletedEvent : AuditEvent
    {
        public DateTime DeleteOlderThan { get; set; }

        public LogsDeletedEvent(DateTime deleteOlderThan)
        {
            DeleteOlderThan = deleteOlderThan;
        }
    }
}