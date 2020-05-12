using System;
using System.Threading.Tasks;
using IdentityServer.UI.ViewModels.Log;

namespace IdentityServer.UI.Services.Identity.Interfaces
{
    public interface IAuditLogService
    {
        Task<AuditLogsDto> GetAsync(AuditLogFilterDto filters);

        Task DeleteLogsOlderThanAsync(DateTime deleteOlderThan);
    }
}
