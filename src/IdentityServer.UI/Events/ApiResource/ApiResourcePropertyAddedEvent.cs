using Skoruba.AuditLogging.Events;
using IdentityServer.UI.Configuration;
using IdentityServer.UI.ViewModels.Api;

namespace IdentityServer.UI.Events.ApiResource
{
    public class ApiResourcePropertyAddedEvent : AuditEvent
    {
        public ApiResourcePropertyAddedEvent(ApiResourcePropertiesDto apiResourceProperty)
        {
            ApiResourceProperty = apiResourceProperty;
        }

        public ApiResourcePropertiesDto ApiResourceProperty { get; set; }
    }
}