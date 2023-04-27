using System;

namespace Assigment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\n Enter Emp Id : ");
                int id = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("\n Enter Emp name : ");
                string name = Console.ReadLine();



                Console.WriteLine("\n Enter Emp salary : ");
                double sal = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n How much Km u want to travel: ");
                int km = Convert.ToInt32(Console.ReadLine());

                if (id == null || id <= 0)
                {
                    Console.WriteLine("\n Invalid ID");
                }
                else if (name == null)
                {
                    Console.WriteLine("\n Invalid Name");
                }
                else if (sal == 0)
                {
                    Console.WriteLine("\n Invalid Salary");
                }
                else
                {

                    Employee e = new Employee(id, name, sal);
                    e.CalculateSalary();
                    e.displayDetails();

                    Manager m = new Manager(id, name, sal);
                    m.Calculate();
                    m.CalculateSalary();

                    MarketingExicutive me = new MarketingExicutive(id, name, sal, km);
                    me.Calculate();
                    me.CalculateSalary();



                }



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

    }

}

