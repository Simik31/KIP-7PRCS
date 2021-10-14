namespace CodeBase
{
    public class InRange
    {
        public static bool Inclusive(long check, long min, long max)
        {
            return min <= check && check <= max;
        }

        public static bool Exclusive(long check, long min, long max)
        {
            return min < check && check < max;
        }
    }
}
