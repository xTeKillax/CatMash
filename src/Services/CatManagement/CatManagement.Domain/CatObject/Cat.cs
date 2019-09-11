using CatManagement.Domain.ValueObjects.Score;
using CatManagement.Domain.ValueObjects.Url;

namespace CatManagement.Domain.CatObject
{
    public class Cat
    {
        public virtual int Id { get; protected set; }
        public virtual Url Url { get; protected set; }
        public virtual Score Score { get; protected set; }

        public Cat(int id, Url url, Score score)
        {
            this.Id = id;
            this.Url = url;
            this.Score = score;
        }

        public void Like()
        {
            Score++;
        }
    }
}
