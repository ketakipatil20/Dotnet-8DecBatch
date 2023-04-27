using System;

namespace Assignment1Q5
{
    public class Number
    {
        static void calculate()
        {
            int r;
            double area, circum;
            Console.WriteLine("enter the value of r");
            r = Convert.ToInt32(Console.ReadLine());


            area = 3.14 * r * r;
            Console.WriteLine("area is " + area);

            circum = 2 * 3.14 * r;
            Console.WriteLine("circumference is " + circum);

        }
        public static void Main(string[] args)
        {

            calculate();



        }
    }
}
