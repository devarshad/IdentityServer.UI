using IdentityServer.UI.Configuration;

namespace IdentityServer.UI.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {      
        public AdminConfiguration AdminConfiguration { get; } = new AdminConfiguration();
        public RegisterConfiguration RegisterConfiguration { get; } = new RegisterConfiguration();
        public IdentityDataConfiguration IdentityDataConfiguration { get; set; } = new IdentityDataConfiguration();
        public IdentityServerDataConfiguration IdentityServerDataConfiguration { get; set; } = new IdentityServerDataConfiguration();
    }
}