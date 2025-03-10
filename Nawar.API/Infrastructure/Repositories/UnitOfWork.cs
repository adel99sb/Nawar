using Nawar.API.Core.Interfaces.Infrastructure;
using Nawar.API.Infrastructure.Data;

namespace Nawar.API.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        //private IRepository<??> _??;

        //public IRepository<??> ?? => _?? ??= new Repository<??>(_context);

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
