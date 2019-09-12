namespace CatManagement.Domain.ValueObjects.Score
{
    public class Score
    {
        public int Value { get; private set; }

        public Score(int value)
        {
            if (value < 0)
                throw new ScoreShouldNotBeNegative($"The '{nameof(Score)}' field should not be negative.");

            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator Score(int number)
        {
            return new Score(number);
        }

        public static Score operator +(Score score1, Score score2)
        {
            return new Score(score1.Value + score2.Value);
        }

        public static Score operator -(Score score1, Score score2)
        {
            return new Score(score1.Value - score2.Value);
        }

        public static Score operator ++(Score score1)
        {
            score1.Value++;
            return score1;
        }

        public static Score operator --(Score score1)
        {
            score1.Value--;
            return score1;
        }

        public static bool operator <(Score score1, Score score2)
        {
            return score1.Value < score2.Value;
        }

        public static bool operator >(Score score1, Score score2)
        {
            return score1.Value > score2.Value;
        }

        public static bool operator <=(Score score1, Score score2)
        {
            return score1.Value <= score2.Value;
        }

        public static bool operator >=(Score score1, Score score2)
        {
            return score1.Value >= score2.Value;
        }

        public override bool Equals(object score)
        {
            return ((Score)score).Value == Value;
        }
    }
}
