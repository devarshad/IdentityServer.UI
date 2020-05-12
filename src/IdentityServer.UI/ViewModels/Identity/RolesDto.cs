﻿using IdentityServer.UI.ViewModels.Identity.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace IdentityServer.UI.ViewModels.Identity
{
    public class RolesDto<TRoleDto, TRoleDtoKey>: IRolesDto where TRoleDto : RoleDto<TRoleDtoKey>
    {
        public RolesDto()
        {
            Roles = new List<TRoleDto>();
        }

        public int PageSize { get; set; }

        public int TotalCount { get; set; }

        public List<TRoleDto> Roles { get; set; }

        List<IRoleDto> IRolesDto.Roles => Roles.Cast<IRoleDto>().ToList();
    }
}