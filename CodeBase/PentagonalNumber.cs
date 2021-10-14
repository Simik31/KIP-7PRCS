namespace CodeBase
{
    public class PentagonalNumber
    {
        public static long Get(long n)
        {
            return n * (3 * n - 1) / 2;
        }

        public static long Reverse(long n)
        {
            long y = 1;
            while (Get(y) != n) y++;
            return y;
        }
    }
}
