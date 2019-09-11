namespace CatManagement.Domain.ValueObjects.Score
{
    public class ScoreShouldNotBeNegative : DomainException
    {
        internal ScoreShouldNotBeNegative(string message) : base(message)
        { }
    }
}
