using System;

namespace Dedicnost
{
    class Program
    {
        static void Main(string[] args)
        {
            testIntQueue(new SimpleIntQueue());
            testIntQueue(new UniqueIntQueue());
            testIntQueue(new IncreasingIntQueue());
        }

        static void testIntQueue(IntQueue queue)
        {
            string template_push = " " + queue.GetType().Name + " Push #val -> []";
            string template_pull = " " + queue.GetType().Name + " Pull [] -> #val";

            int[] testData = new int[] { 1, 2, 1, 4, 5, 2, 3, 1, 7 };

            foreach (int num in testData)
            {
                Console.WriteLine(AlterTemplate(template_push, num));
                queue.Push(num);
            }

            while(!queue.IsEmpty()) Console.WriteLine(AlterTemplate(template_pull, queue.Pull()));

            Console.WriteLine(AlterTemplate(template_pull, queue.Pull()));
            Console.WriteLine("\n");
        }

        static string AlterTemplate(string template, int value)
        {            
            return template.Replace("#val", value.ToString());
        }
    }
}
