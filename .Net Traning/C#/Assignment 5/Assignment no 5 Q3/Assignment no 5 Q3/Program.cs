using System;
using System.Collections.Generic;

namespace Assignment_no_5_Q3
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<GenericEmployee> ll = new List<GenericEmployee>();
            GenericEmployee ge;
            do
            {
                Console.WriteLine("\n1. Add elements to the list.");
                Console.WriteLine("2. Display the employee list");
                Console.WriteLine("3. Count the total no. of employee");
                Console.WriteLine("4. Search an employee");
                Console.WriteLine("5. Exit");



                Console.WriteLine("\npls enter your choice:");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Enter the number of Employee:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("\nEnter Employee id :");
                            int id = Convert.ToInt32(Console.ReadLine());



                            Console.WriteLine("Enter Employee name :");
                            string name = Console.ReadLine();



                            Console.WriteLine("Enter Employee salary :");
                            int sal = Convert.ToInt32(Console.ReadLine());



                            ll.Add(new GenericEmployee(id, name, sal));
                        }
                        break;



                    case 2:
                        Console.WriteLine("\nThe Employee Details are :");
                        foreach (object e in ll)
                        {
                            Console.WriteLine(e);
                        }
                        break;



                    case 3:
                        Console.WriteLine("\nThe total number of employees in the linked list: " + ll.Count);
                        break;



                    case 4:
                        Console.WriteLine("\nEnter the name you want to search :");
                        string input = Console.ReadLine();
                        bool search = false;
                        foreach (GenericEmployee s in ll)
                        {
                            if (s.e_name.Equals(input))
                            {
                                search = true;
                            }
                            else
                            {
                                search = false;
                            }
                        }
                        if (search == true)
                        {
                            Console.WriteLine("Record Found");
                        }
                        else
                        {
                            Console.WriteLine("Record Not Found");
                        }
                        break;
                    case 5: break;



                    default:
                        Console.WriteLine("pls enter the right choice");
                        break;



                }
            } while (true);
        }
    }
}
