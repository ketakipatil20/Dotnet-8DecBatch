using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Emp Id : ");
                int id = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("Enter Emp name : ");
                string name = Console.ReadLine();



                Console.WriteLine("Enter Emp salary : ");
                double sal = Convert.ToDouble(Console.ReadLine());

                if(id==null || id<=0)
                {
                    Console.WriteLine("Invalid ID");
                }
                else if(name==null)
                {
                    Console.WriteLine("Invalid Name");
                }
                else if(sal==0 )
                {
                    Console.WriteLine("Invalid Salary");
                }
                else
                {

                    Employee e = new Employee(id, name, sal);
                    e.CalculateSalary();
                    e.displayDetails();

                }



            }catch(Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }

}

