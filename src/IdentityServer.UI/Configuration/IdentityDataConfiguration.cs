using IdentityServer.UI.Configuration.Identity;
using System.Collections.Generic;

namespace IdentityServer.UI.Configuration
{
    public class IdentityDataConfiguration
    {
       public List<Role> Roles { get; set; }
       public List<User> Users { get; set; }
    }
}
