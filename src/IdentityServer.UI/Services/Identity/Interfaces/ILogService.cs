using System;
using System.Threading.Tasks;
using IdentityServer.UI.ViewModels.Log;

namespace IdentityServer.UI.Services.Identity.Interfaces
{
    public interface ILogService
    {
        Task<LogsDto> GetLogsAsync(string search, int page = 1, int pageSize = 10);

        Task DeleteLogsOlderThanAsync(DateTime deleteOlderThan);
    }
}