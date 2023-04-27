using System;



namespace  Assignment5_Q1
{
    class Program
    {
        public static void print_s(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine("");
        }
        public static void print_I(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            string[] str = new string[5];
            int val = 0;
            Console.WriteLine("enter the values of int arrays");
            for (int i = 0; i < 5; i++)
            {
                val = Convert.ToInt32(Console.ReadLine());
                arr[i] = val;
            }
            string value;
            Console.WriteLine("enter the value of string");
            for (int i = 0; i < 5; i++)
            {
                value = Console.ReadLine();
                str[i] = value;
            }
            int[] c_arr = new int[100];
            string[] c_str = new string[100];
            Array.Copy(arr, c_arr, arr.Length);
            Array.Copy(str, c_str, str.Length);
            Console.WriteLine("copy arrays");
            print_I(arr);
            print_s(str);
            Array.Sort(arr);
            Array.Sort(str);
            Console.WriteLine("the sorted arrays are as follows");
            print_I(arr);
            print_s(str);
            Array.Reverse(arr);
            Array.Reverse(str);
            Console.WriteLine("reversed arrays");
            print_I(arr);
            print_s(str);
            Array.Clear(arr, 0, arr.Length);
            Array.Clear(str, 0, str.Length);
            Console.WriteLine("clear arrays");
            print_I(arr);
            print_s(str);
        }
    }
}



