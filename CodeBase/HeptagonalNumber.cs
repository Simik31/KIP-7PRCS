namespace CodeBase
{
    public class HeptagonalNumber
    {
        public static long Get(long n)
        {
            return n * (5 * n - 3) / 2;
        }

        public static long Reverse(long n)
        {
            long y = 1;
            while (Get(y) != n) y++;
            return y;
        }
    }
}
