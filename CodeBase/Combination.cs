using System.Numerics;

namespace CodeBase
{
    public class Combination
    {
        public static BigInteger GetBigInteger(long n, long r)
        {
            return BigInteger.Divide(Factorial.GetBiginteger(n), BigInteger.Multiply(Factorial.GetBiginteger(r), Factorial.GetBiginteger(n - r)));
        }
    }
}
