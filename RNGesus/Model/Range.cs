namespace Model
{
    public class Range
    {
        public int startRange;
        public int stopRange;

        public Range(int startRange, int stopRange)
        {
            this.startRange = startRange;
            this.stopRange = stopRange;
        }

        public override string ToString()
        {
            return "From: " + startRange + " To: " + stopRange;
        }
    }
}