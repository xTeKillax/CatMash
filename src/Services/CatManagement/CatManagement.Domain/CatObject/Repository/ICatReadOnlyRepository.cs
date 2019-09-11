using System.Linq;
using System.Threading.Tasks;

namespace CatManagement.Domain.CatObject.Repository
{
    public interface ICatReadOnlyRepository
    {
        Task<Cat> Get(int id);
        Task<IQueryable<Cat>> Get();
    }
}
