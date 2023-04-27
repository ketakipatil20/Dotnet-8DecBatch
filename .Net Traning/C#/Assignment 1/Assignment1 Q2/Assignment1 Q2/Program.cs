using System;

namespace Assignment1_Q2
{
    public class Number
    {
        public static void Main(string[] args)
        {
            int s1, s2, s3, s4, s5, AverageMarks;
            Console.WriteLine("enter the five marks");
            s1 = Convert.ToInt32(Console.ReadLine());
            s2 = Convert.ToInt32(Console.ReadLine());
            s3 = Convert.ToInt32(Console.ReadLine());
            s4 = Convert.ToInt32(Console.ReadLine());
            s5 = Convert.ToInt32(Console.ReadLine());

            if (s1 > s2 && s1 > s3 && s1 > s4 && s1 > s5)
            {
                Console.WriteLine("s1 is highest marks" + s1);

            }
            else if (s2 > s3 && s2 > s4 && s2 > s5)
            {
                Console.WriteLine("s2 is highest marks" + s2);
            }
            else if (s3 > s4 && s3 > s5)
            {
                Console.WriteLine("s3 is highest marks" + s3);
            }
            else if (s4 > s5)
            {
                Console.WriteLine("s4 is highest marks" + s4);
            }
            else
            {
                Console.WriteLine("s5 is highest marks" + s5);
            }




        }
    }

}
