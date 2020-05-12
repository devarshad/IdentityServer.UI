using Skoruba.AuditLogging.Events;

namespace IdentityServer.UI.Events.Identity
{
    public class UserClaimsSavedEvent<TUserClaimsDto> : AuditEvent
    {
        public TUserClaimsDto Claims { get; set; }

        public UserClaimsSavedEvent(TUserClaimsDto claims)
        {
            Claims = claims;
        }
    }
}