using Skoruba.AuditLogging.Events;

namespace IdentityServer.UI.Events.Identity
{
    public class UserClaimsDeletedEvent<TUserClaimsDto> : AuditEvent
    {
        public TUserClaimsDto Claim { get; set; }

        public UserClaimsDeletedEvent(TUserClaimsDto claim)
        {
            Claim = claim;
        }
    }
}