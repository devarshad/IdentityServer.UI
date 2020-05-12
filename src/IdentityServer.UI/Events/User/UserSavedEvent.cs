using Skoruba.AuditLogging.Events;

namespace IdentityServer.UI.Events.Identity
{
    public class UserSavedEvent<TUserDto> : AuditEvent
    {
        public TUserDto User { get; set; }

        public UserSavedEvent(TUserDto user)
        {
            User = user;
        }
    }
}