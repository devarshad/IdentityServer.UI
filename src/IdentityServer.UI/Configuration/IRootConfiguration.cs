namespace IdentityServer.UI.Configuration
{
    public interface IRootConfiguration
    {
        AdminConfiguration AdminConfiguration { get; }
        RegisterConfiguration RegisterConfiguration { get; }
        IdentityDataConfiguration IdentityDataConfiguration { get; }
        IdentityServerDataConfiguration IdentityServerDataConfiguration { get; }
    }
}