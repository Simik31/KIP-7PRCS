using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBase
{
    public class TriangleNumber
    {
        public static long Get(long n)
        {
            return n * (n + 1) / 2;
        }

        public static long Reverse(long n)
        {
            long y = 1;
            while (Get(y) != n) y++;
            return y;
        }
    }
}