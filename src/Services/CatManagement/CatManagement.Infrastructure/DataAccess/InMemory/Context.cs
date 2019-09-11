using CatManagement.Domain.CatObject;
using System.Collections.ObjectModel;

namespace CatManagement.Infrastructure.DataAccess.InMemory
{
    public class Context
    {
        public Collection<Cat> Cats { get; set; }

        public Context()
        {
            Cats = new Collection<Cat>();
        }
    }
}
