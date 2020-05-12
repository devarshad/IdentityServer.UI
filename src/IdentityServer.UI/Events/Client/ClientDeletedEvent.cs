using Skoruba.AuditLogging.Events;
using IdentityServer.UI.Configuration;
using IdentityServer.UI.ViewModels.Client;

namespace IdentityServer.UI.Events.Client
{
    public class ClientDeletedEvent : AuditEvent
    {
        public ClientDto Client { get; set; }

        public ClientDeletedEvent(ClientDto client)
        {
            Client = client;
        }
    }
}