﻿using IdentityServer.UI.ViewModels.Identity.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace IdentityServer.UI.ViewModels.Identity
{
    public class UserClaimsDto<TUserDtoKey> : UserClaimDto<TUserDtoKey>, IUserClaimsDto
    {
        public UserClaimsDto()
        {
            Claims = new List<UserClaimDto<TUserDtoKey>>();
        }

        public string UserName { get; set; }

        public List<UserClaimDto<TUserDtoKey>> Claims { get; set; }

        public int TotalCount { get; set; }

        public int PageSize { get; set; }

        List<IUserClaimDto> IUserClaimsDto.Claims => Claims.Cast<IUserClaimDto>().ToList();
    }
}
