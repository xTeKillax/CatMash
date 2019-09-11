using System;

namespace Cat.Infrastructure
{
    public class InfrastructureException : Exception
    {
        internal InfrastructureException(string businessMessage) : base(businessMessage) { }
    }
}
