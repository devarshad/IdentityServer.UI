using System.Collections.Generic;
using IdentityServer.UI.Configuration.Identity;

namespace IdentityServer.UI.Configuration.IdentityServer
{
    public class Client : global::IdentityServer4.Models.Client
    {
        public List<Claim> ClientClaims { get; set; } = new List<Claim>();
    }
}
