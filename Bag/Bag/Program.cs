using System;

namespace Bag
{
    class Program
    {
        static void Main(string[] args)
        {
            List list1 = new List();

            while (true)
            {
                string console = Console.ReadLine();
                if (int.TryParse(console, out int value)) list1.Add(value);
                else Console.WriteLine($"{console} is not valid INT input");
            }
        }
    }
}
