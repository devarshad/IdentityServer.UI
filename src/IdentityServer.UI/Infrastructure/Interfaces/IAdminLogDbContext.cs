using Microsoft.EntityFrameworkCore;
using IdentityServer.UI.Infrastructure.Entities;

namespace IdentityServer.UI.Infrastructure.Interfaces
{
    public interface IAdminLogDbContext
    {
        DbSet<Log> Logs { get; set; }
    }
}
