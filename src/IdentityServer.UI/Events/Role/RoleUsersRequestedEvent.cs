using Skoruba.AuditLogging.Events;
using IdentityServer.UI.ViewModels.Identity;

namespace IdentityServer.UI.Events.Identity
{
    public class RoleUsersRequestedEvent<TUsersDto> : AuditEvent
    {
        public TUsersDto Users { get; set; }

        public RoleUsersRequestedEvent(TUsersDto users)
        {
            Users = users;
        }
    }
}