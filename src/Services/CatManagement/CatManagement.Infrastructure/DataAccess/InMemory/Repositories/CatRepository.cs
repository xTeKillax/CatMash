using System;
using System.Linq;
using System.Threading.Tasks;
using CatManagement.Domain.CatObject;
using CatManagement.Domain.CatObject.Repository;

namespace CatManagement.Infrastructure.DataAccess.InMemory.Repositories
{
    public class CatRepository : ICatReadOnlyRepository, ICatWriteOnlyRepository
    {
        private readonly Context _context;

        public CatRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Cat> Get(int id)
        {
            Cat cat = _context.Cats.Where(x => x.Id == id).SingleOrDefault();

            return await Task.FromResult<Cat>(cat);
        }

        public async Task Update(Cat cat)
        {
            Cat catToUpdate = _context.Cats.Where(x => x.Id == cat.Id).SingleOrDefault();

            catToUpdate = cat;

            await Task.CompletedTask;
        }
    }
}
