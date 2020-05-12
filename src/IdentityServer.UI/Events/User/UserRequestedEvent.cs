﻿using Skoruba.AuditLogging.Events;
using IdentityServer.UI.ViewModels.Identity;

namespace IdentityServer.UI.Events.Identity
{
    public class UserRequestedEvent<TUserDto> : AuditEvent
    {
        public TUserDto UserDto { get; set; }

        public UserRequestedEvent(TUserDto userDto)
        {
            UserDto = userDto;
        }
    }
}