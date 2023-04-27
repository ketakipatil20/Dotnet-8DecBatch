using System;
using System.Reflection;



namespace Assignment_8_A
{
    public class sample
    {
        public int addition(string a, string b)
        {
            int summation = Convert.ToInt32(a) + Convert.ToInt32(b);
            return summation;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Type mytype = typeof(Assignment_8_A.sample);
            object ins = Activator.CreateInstance(mytype);
            //Activator contains methods to create obj of a class.
            MethodInfo met = mytype.GetMethod("addition");
            MethodInfo[] methods = mytype.GetMethods();
            string[] values = new string[2];
            values[0] = "10";
            values[1] = "12";
            Console.WriteLine($"type:{mytype}");
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType + " " + method.Name);
            }
            int result = (int)met.Invoke(ins, values);
            Console.WriteLine($"Method called result is {result}");






        }
    }

}
