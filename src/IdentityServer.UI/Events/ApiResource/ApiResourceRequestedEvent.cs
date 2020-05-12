using Skoruba.AuditLogging.Events;
using IdentityServer.UI.Configuration;
using IdentityServer.UI.ViewModels.Api;

namespace IdentityServer.UI.Events.ApiResource
{
    public class ApiResourceRequestedEvent : AuditEvent
    {
        public int ApiResourceId { get; set; }
        public ApiResourceDto ApiResource { get; set; }

        public ApiResourceRequestedEvent(int apiResourceId, ApiResourceDto apiResource)
        {
            ApiResourceId = apiResourceId;
            ApiResource = apiResource;
        }
    }
}