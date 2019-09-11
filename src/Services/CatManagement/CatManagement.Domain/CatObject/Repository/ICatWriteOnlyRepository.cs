using System.Threading.Tasks;

namespace CatManagement.Domain.CatObject.Repository
{
    public interface ICatWriteOnlyRepository
    {
        Task Update(Cat cat);
    }
}
