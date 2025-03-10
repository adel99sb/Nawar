using Nawar.API.Infrastructure.Repositories;

namespace Nawar.API.Core.Interfaces.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        //IRepository<??> ?? { get; }
        Task<int> SaveChangesAsync();
    }

}
