using CodeBase;
using System.Linq;

/*
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
Find the sum of all the primes below two million.
*/

namespace cs_euler
{
    public class Problem_010 : IProblem
    {
        public long Run()
        {
            return Prime.GetBellow(2000000).Sum();
        }
    }
}
