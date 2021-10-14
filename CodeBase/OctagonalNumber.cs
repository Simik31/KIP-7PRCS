namespace CodeBase
{
    public class OctagonalNumber
    {
        public static long Get(long n)
        {
            return n * (3 * n - 2);
        }

        public static long Reverse(long n)
        {
            long y = 1;
            while (Get(y) != n) y++;
            return y;
        }
    }
}
