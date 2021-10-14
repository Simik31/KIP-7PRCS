using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;

/*
It is possible to write five as a sum in exactly six different ways:

4 + 1
3 + 2
3 + 1 + 1
2 + 2 + 1
2 + 1 + 1 + 1
1 + 1 + 1 + 1 + 1

How many different ways can one hundred be written as a sum of at least two positive integers?
*/

namespace cs_euler
{
    class Problem_076 : IProblem
    {
        public long Run()
        {
            Console.WriteLine();
            int num = 5;
            Loop(num, 0);
            return 0;
        }

        private long Loop(int num, int depth)
        {
            for (int n = num; n > 0; n--)
            {
                if (num - n > 0 && num - n <= num)
                {
                    for (int d = 0; d < depth; d++) Console.Write("\t");
                    Console.WriteLine(n + " Remaining: " + (num - n));
                    Loop(num - n, depth + 1);
                }
            }
            return 0;
        }
    }
}