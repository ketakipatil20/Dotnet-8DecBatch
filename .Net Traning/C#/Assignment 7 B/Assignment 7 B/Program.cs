using System;
using System.IO;

namespace Assignment_7_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\KETAKPAT\.NET\Assignment 7 B\Assignment 7 B\Text.txt";
            Console.WriteLine("Enter Customer Details....");
            Console.WriteLine("Enter Account Number:");
            int Acc_Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name:");
            string Customer_Name = Console.ReadLine();
            Console.WriteLine("Enter Balance:");
            int Balance = Convert.ToInt32(Console.ReadLine());




            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write("Customer Name:" + Customer_Name + "\nAccount Number:" + Acc_Number + "\nBalance:" + Balance);
            }
            Console.WriteLine("Saved");



            Console.WriteLine("\n\nReading Text File:::");



            using (StreamReader reader = new StreamReader(path))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
