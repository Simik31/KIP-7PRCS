using System.Collections.Generic;

namespace CodeBase
{
    public class HCF
    {
        public static bool Check(long a, long b)
        {
            List<long> primes = Prime.GetBellow(a);
            foreach (long prime in primes) if (prime < a && a % prime == 0 && b % prime == 0) return false;
            return true;
        }

        public static bool Check(long a, long b, List<long> primes)
        {
            foreach (long prime in primes) if (prime < a && a % prime == 0 && b % prime == 0) return false;
            return true;
        }
    }
}
