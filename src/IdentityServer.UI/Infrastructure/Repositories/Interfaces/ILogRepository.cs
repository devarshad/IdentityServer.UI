using System;
using System.Threading.Tasks;
using IdentityServer.UI.Infrastructure.Entities;
using IdentityServer.UI.ViewModels.Common;

namespace IdentityServer.UI.Infrastructure.Repositories.Interfaces
{
    public interface ILogRepository
    {
        Task<PagedList<Log>> GetLogsAsync(string search, int page = 1, int pageSize = 10);

        Task DeleteLogsOlderThanAsync(DateTime deleteOlderThan);
    }
}