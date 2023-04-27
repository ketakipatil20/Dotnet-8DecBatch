using System;

namespace Assignment1_Q4
{
    public class Number
    {
        static void swap()
        {
            int a, b, c;
            Console.WriteLine("enter two numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine("numbers after swapping" + a + " " + b);

        }
        public static void Main(string[] args)
        {

            swap();



        }
    }
}
