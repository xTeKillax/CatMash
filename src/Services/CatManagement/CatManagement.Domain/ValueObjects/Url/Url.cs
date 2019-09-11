namespace CatManagement.Domain.ValueObjects.Url
{
    public class Url
    {
        public string Text { get; private set; }

        public Url(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new UrlShouldNotBeEmptyException($"The '{nameof(Url)}' field is required");

            this.Text = text;
        }

        public override string ToString()
        {
            return Text.ToString();
        }

        public static implicit operator Url(string text)
        {
            return new Url(text);
        }
    }
}
