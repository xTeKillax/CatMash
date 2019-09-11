namespace Cat.Domain.ValueObjects.Url
{
    public class UrlShouldNotBeEmptyException : DomainException
    {
        internal UrlShouldNotBeEmptyException(string message) : base(message)
        { }
    }
}
