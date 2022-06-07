namespace VichInterval
{
    public class TimeInterval
    {
        private readonly double sec;
        public double Tick { get { return sec * 18.2; } }
        public double Min { get { return sec / 60; } }

        private TimeInterval(double sec)
        {
            this.sec = sec;
        }
        public static TimeInterval MMin(double m)
        {
            return new TimeInterval(m * 60);
        }

        public static TimeInterval TTick(double tick)
        {
            return new TimeInterval(tick / 18.2);
        }

        public TimeInterval Addiction(TimeInterval other)
        {
            return new TimeInterval(this.sec + other.sec);
        }

        public TimeInterval Substraction(TimeInterval other)
        {
            return new TimeInterval(this.sec - other.sec);
        }

        public override string ToString() { return $"Минут: {Min}\nСекунд: {sec}\nТик: {Tick}"; }
    }
}