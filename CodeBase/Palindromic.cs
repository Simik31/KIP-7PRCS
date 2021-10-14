using System;
using System.Numerics;

namespace CodeBase
{
    public class Palindromic
    {
        public static bool Check(String num)
        {
            for (int i = 0; i < num.Length; i++) if (!num.Substring(i, 1).Equals(num.Substring(num.Length - i - 1, 1))) return false;
            return true;
        }

        public static bool Check(int num)
        {
            return Check(num.ToString());
        }

        public static bool Check(long num)
        {
            return Check(num.ToString());
        }

        public static bool Check(BigInteger num)
        {
            return Check(num.ToString());
        }
    }
}
