namespace IdentityServer.UI.ViewModels.Identity.Interfaces
{
    public interface IRoleClaimDto : IBaseRoleClaimDto
    {
        string ClaimType { get; set; }
        string ClaimValue { get; set; }
    }
}
