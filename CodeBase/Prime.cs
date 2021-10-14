using System;
using System.Collections.Generic;

namespace CodeBase
{
    public class Prime
    {

        public static bool Check(long number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number == 3) return true;
            for (int i = 2; i <= Math.Sqrt(number) + 1; i++) if (number % i == 0) return false;
            return true;
        }

        public static bool Check(String number)
        {
            return Check(long.Parse(number));
        }

        public static bool CheckSet(long[] set)
        {
            foreach (long value in set) if (!Check(value)) return false;
            return true;
        }

        public static bool CheckSet(List<long> set)
        {
            foreach (long value in set) if (!Check(value)) return false;
            return true;
        }

        public static bool CheckSet(String[] set)
        {
            foreach (String value in set) if (!Check(value)) return false;
            return true;
        }

        public static List<long> GetBellow(long n)
        {
            List<long> list = new List<long> { 2 };
            for (long i = 3; i <= n; i += 2) if (Check(i)) list.Add(i);
            return list;
        }

        public static List<long> GetInRange(long start, long end)
        {
            List<long> list = new List<long>();
            for (long i = start; i <= end; i++) if (Check(i)) list.Add(i);
            return list;
        }

        public static long GetNth(long n)
        {
            int counter = 1, i;
            long ret = 2;
            for (i = 3; counter < n; i += 2)
                if (Check(i))
                {
                    counter++;
                    ret = i;
                }
            return ret;
        }

        public static long BiggestPrimeDivisor(long n)
        {
            for (long k = 2; k * k <= n;)
            {
                if (n % k == 0) n /= k;
                else k++;
            }
            return n;
        }

        public static List<long> PrimeDivisors(long n)
        {
            List<long> divs = new List<long>();
            for (long number = 2; number < n; number++)
            {
                if (Check(number))
                {
                    if (n % number == 0)
                    {
                        divs.Add(number);
                        n /= number;
                    }
                }
            }
            if (!divs.Contains(n) && Check(n)) divs.Add(n);
            return divs;
        }

        public static List<int> PrimeDivisors(int n)
        {
            List<int> divs = new List<int>();
            for (int number = 2; number < n; number++)
            {
                if (Check(number))
                {
                    if (n % number == 0)
                    {
                        divs.Add(number);
                        n /= number;
                    }
                }
            }
            if (!divs.Contains(n) && Check(n)) divs.Add(n);
            return divs;
        }

        public static bool RelativePrime(long n, long i)
        {
            List<long> divs_n = PrimeDivisors(n);
            List<long> divs_i = PrimeDivisors(i);
            foreach (long div in divs_n) if (divs_i.Contains(div)) return false;
            return true;
        }

    }
}
