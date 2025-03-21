using Infrastructure.Core.Entities;
using Infrastructure.Core.Interfaces.Infrastructure;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        //private IRepository<Student> _student;
        //public IRepository<Student> Students => _student ??= new Repository<Student>(_context);


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
