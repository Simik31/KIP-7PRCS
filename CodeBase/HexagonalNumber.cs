namespace CodeBase
{
    public class HexagonalNumber
    {
        public static long Get(long n)
        {
            return n * (2 * n - 1);
        }

        public static long Reverse(long n)
        {
            long y = 1;
            while (Get(y) != n) y++;
            return y;
        }
    }
}
