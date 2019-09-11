using Cat.Domain.ValueObjects.Score;
using Cat.Domain.ValueObjects.Url;

namespace Cat.Domain.Cat
{
    public class Cat
    {
        public virtual int Id { get; protected set; }
        public virtual Url Url { get; protected set; }
        public virtual Score Score { get; protected set; }

        public Cat(int id, Url url)
        {
            this.Id = id;
            this.Url = url;
        }

        public void Like()
        {
            Score++;
        }
    }
}
