namespace IdentityServer.UI.ViewModels.Identity.Interfaces
{
    public interface IBaseUserClaimDto
    {
        int ClaimId { get; set; }
        object UserId { get; }
    }
}
