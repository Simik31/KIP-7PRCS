using System;
using System.Collections.Generic;
using System.Linq;
using CodeBase;

namespace cs_euler
{
    public static class Euler
    {
        #if DEBUG
            public static readonly bool debug = true;
        #else
            public static readonly bool debug = false;
        #endif

        public static string title = "C# Project Euler";
        public static int problems_coded = 76;
        public static List<long> times = new List<long>();

        public static void Main(string[] args)
        {
            Solve solve = new Solve();
            string input;

            Console.Title = title;
            Console.CursorVisible = true;
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.Clear();
            Console.Write("[*] Coded problems: 1 - {0} ({1}%)\n[*] Which problem do you want to solve (0 = all): ", problems_coded, Math.Round(problems_coded * 100.0 / 723, 2));
            input = Console.ReadLine();
            Console.CursorVisible = false;
            
            if (int.TryParse(input, out int problem_id))
            {
                Console.Clear();

                if (problem_id == 0)
                {
                    solve.All();

                    times.Sort();
                    Console.WriteLine("\n[*] DONE IN: {0:#,##0}ms  (min: {1:#,##0}ms  max: {2:#,##0}ms  avg: {3:#,##0}ms)\n\n[*] Press Enter to retry, or any other key to exit...", times.Sum(), times[0], times[^1], times.Average());
                }

                else if (InRange.Inclusive(problem_id, 1, problems_coded))
                {
                    solve.Problem(problem_id);

                    Console.WriteLine("\n[*] DONE IN: {0:#,##0}ms\n\n[*] Press Enter to retry, or any other key to exit...", times[0]);
                }
                else
                {
                    Console.WriteLine("\n[*] Invalid problem ID {0}\n[*] Press any key to retry...", problem_id);
                    Console.ReadKey();
                    Main(null);
                }

                if (Console.ReadKey().Key.Equals(ConsoleKey.Enter))
                {
                    Main(null);
                }
            }
            else
            {
                Console.WriteLine("\n[*] Please input numbers only!\n[*] Press any key to retry...");
                Console.ReadKey();
                Main(null);
            }
        }
    }
}
