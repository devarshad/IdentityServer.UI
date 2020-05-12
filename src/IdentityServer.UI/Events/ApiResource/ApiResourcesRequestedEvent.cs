using Skoruba.AuditLogging.Events;
using IdentityServer.UI.Configuration;
using IdentityServer.UI.ViewModels.Api;

namespace IdentityServer.UI.Events.ApiResource
{
    public class ApiResourcesRequestedEvent : AuditEvent
    {
        public ApiResourcesRequestedEvent(ApiResourcesDto apiResources)
        {
            ApiResources = apiResources;
        }

        public ApiResourcesDto ApiResources { get; set; }
    }
}