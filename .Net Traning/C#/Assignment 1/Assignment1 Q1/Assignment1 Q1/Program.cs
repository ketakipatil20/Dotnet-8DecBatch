using System;

namespace CSharpAssignment1
{

    public class Number
    {
        public static void Main(string[] args)
        {
            int Num1, Num2, Add, Sub, Mul, Div;
            Console.WriteLine("Enter two numbers");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Num2 = Convert.ToInt32(Console.ReadLine());

            Add = Num1 + Num2;
            Console.WriteLine("Addition is"   + Add);

            Sub = Num1 - Num2;
            Console.WriteLine("Substaction is"   + Sub);

            Mul = Num1 * Num2;
            Console.WriteLine("Multiplication is"   + Mul);

            Div = Num1 / Num2;
            Console.WriteLine("Division is"   + Div);


        }
    }
}