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

            Cats.Add(new Cat(1, "photo-1.jpg"));
            Cats.Add(new Cat(2, "photo-2.jpg"));
            Cats.Add(new Cat(3, "photo-3.jpg"));
            Cats.Add(new Cat(4, "photo-4.jpg"));
            Cats.Add(new Cat(5, "photo-5.jpg"));

        }
    }
}
