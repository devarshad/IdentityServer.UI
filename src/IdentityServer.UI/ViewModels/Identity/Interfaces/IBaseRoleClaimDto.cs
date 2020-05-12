namespace IdentityServer.UI.ViewModels.Identity.Interfaces
{
    public interface IBaseRoleClaimDto
    {
        int ClaimId { get; set; }
        object RoleId { get; }
    }
}
