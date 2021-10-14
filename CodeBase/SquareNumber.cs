using System;

namespace CodeBase
{
    public class SquareNumber
    {
        public static long Get(long n)
        {
            return Pow.Long(n, 2);
        }

        public static long Reverse(long n)
        {
            return (long)Math.Sqrt(n);
        }
    }
}
