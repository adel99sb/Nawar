using Infrastructure.Core.Entities;

namespace Infrastructure.Core.Interfaces.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        //IRepository<Student> Students { get; }
        Task<int> SaveChangesAsync();
    }

}
