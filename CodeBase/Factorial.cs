using System;
using System.Numerics;

namespace CodeBase
{
    public class Factorial
    {
        public static BigInteger GetBiginteger(long n)
        {
            BigInteger ret = BigInteger.One;
            while (n > 0) ret = BigInteger.Multiply(ret, n--);
            return ret;
        }

        public static String GetString(long n)
        {
            return GetBiginteger(n).ToString();
        }

        public static int GetInteger(int n)
        {
            int f = 1;
            while (n > 0) f *= n--;
            return f;
        }

        public static long GetLong(long n)
        {
            long f = 1;
            while (n > 0) f *= n--;
            return f;
        }
    }
}
