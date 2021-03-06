/*
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.
*/

namespace cs_euler
{
    public class Problem_001 : IProblem
    {
        public long Run()
        {
            int sum = 0;
            for (int number = 3; number < 1000; number++) if (number % 3 == 0 || number % 5 == 0) sum += number;
            return sum;
        }
    }
}
