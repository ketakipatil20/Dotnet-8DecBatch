using System;

namespace Assignmnet1_Q3
{
    public class HelloWorld
    {
        static int Sum(params int[] vals)
        {
            int total = 0;
            foreach (int val in vals)
            {
                total += val;
            }
            return total;
        }



        static void Main(string[] args)
        {
            int total = Sum(50, 12, 30, 5, 8);
            Console.WriteLine("Sum Values = {0}", total);
            Console.ReadKey();
        }
    }
}
