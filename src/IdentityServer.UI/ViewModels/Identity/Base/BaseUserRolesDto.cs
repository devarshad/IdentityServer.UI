using IdentityServer.UI.ViewModels.Identity.Interfaces;

namespace IdentityServer.UI.ViewModels.Identity.Base
{
    public class BaseUserRolesDto<TUserDtoKey, TRoleDtoKey> : IBaseUserRolesDto
    {
        public TUserDtoKey UserId { get; set; }

        public TRoleDtoKey RoleId { get; set; }

        object IBaseUserRolesDto.UserId => UserId;

        object IBaseUserRolesDto.RoleId => RoleId;
    }
}