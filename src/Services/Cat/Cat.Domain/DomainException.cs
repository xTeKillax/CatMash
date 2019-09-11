using System;

namespace Cat.Domain
{
    public class DomainException : Exception
    {
        internal DomainException(string businessMessage) : base(businessMessage) { }
    }
}
