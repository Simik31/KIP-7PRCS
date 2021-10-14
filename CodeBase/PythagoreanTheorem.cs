﻿namespace CodeBase
{
    public class PythagoreanTheorem
    {
        public static bool IsValid(long a, long b, long c)
        {
            return Pow.Long(a, 2) + Pow.Long(b, 2) == Pow.Long(c, 2);
        }
    }
}
