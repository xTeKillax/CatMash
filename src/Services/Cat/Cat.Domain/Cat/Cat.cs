using Cat.Domain.ValueObjects.Url;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cat.Domain.Cat
{
    public class Cat
    {
        public virtual int Id { get; protected set; }
        public virtual Url Url { get; protected set; }

        public Cat(int id, Url url)
        {
            this.Id = id;
            this.Url = url;
        }
    }
}
