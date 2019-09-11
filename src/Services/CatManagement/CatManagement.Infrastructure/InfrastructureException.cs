using System;

namespace CatManagement.Infrastructure
{
    public class InfrastructureException : Exception
    {
        internal InfrastructureException(string businessMessage) : base(businessMessage) { }
    }
}
