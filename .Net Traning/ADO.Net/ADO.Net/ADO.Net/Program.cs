using System;
using System.Data.SqlClient;

namespace ADO.Net
{ 
    class Program
    {
          static void Main(string[] args)
          {
            string r;

                   SqlConnection con = null;
                   Console.WriteLine("\n 1.Insert");
                   Console.WriteLine("\n 2.Select");
                   Console.WriteLine("\n 3.Delete");
                   Console.WriteLine("\n 4.Update");
                   Console.WriteLine("\n 5.Search");
                   int ch = Convert.ToInt32(Console.ReadLine());
                   r = "Data Source = LIN24006770\\SQLEXPRESS; Database = Sample; Integrated Security = True";
            try
            {
                con = new SqlConnection(r);
                con.Open();

                Console.WriteLine("Connection Open");
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Insertion:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        string name = Console.ReadLine();
                        int Sal = Convert.ToInt32(Console.ReadLine());

                        SqlCommand cm1 = new SqlCommand($"Insert into Emplyoee values({id}, '{name}',{Sal})", con);
                        cm1.ExecuteNonQuery();
                        Console.WriteLine("Successfully Inserted");
                        break;

                    case 2:
                        Console.WriteLine("Selection:");

                        SqlCommand cm2 = new SqlCommand("Select * from Emplyoee ", con);
                        SqlDataReader r1 = cm2.ExecuteReader();
                        while (r1.Read())
                        {
                            Console.WriteLine(r1["EmpId"] + " " + r1["EmpName"] + " " + r1["EmpSalary"]);
                        }
                        r1.Close();
                        Console.WriteLine("Successfully Executed");
                        break;

                    case 3:
                        Console.WriteLine("deletion:");
                        name = Console.ReadLine();

                        SqlCommand cm3 = new SqlCommand($"Delete from Emplyoee where EmpName = '{name}'", con);
                        cm3.ExecuteNonQuery();
                        Console.WriteLine("Successfully Delete");
                        break;

                    case 4:
                        Console.WriteLine("Updation:");
                        name = Console.ReadLine();
                        Sal = Convert.ToInt32(Console.ReadLine());

                        SqlCommand cm4 = new SqlCommand($"Update Emplyoee set EmpSalary={Sal} where EmpName ='{name}'", con);
                        cm4.ExecuteNonQuery();
                        Console.WriteLine("successfully Updated");
                        break;

                    case 5:
                        Console.WriteLine("Searching:");
                        Console.WriteLine("Enter Name:");
                        name = Console.ReadLine();

                        SqlCommand cm5 = new SqlCommand($"Select * from Emplyoee where EmpName ='{name}'", con);
                        r1 = cm5.ExecuteReader();
                        while (r1.Read())
                        {
                            Console.WriteLine(r1["EmpId"] + " " + r1["EmpName"] + " " + r1["EmpSalary"]);
                        }
                        r1.Close();
                        Console.WriteLine("Successfully Updated");
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            //Closing connection 
            finally
            {
                con.Close();
            }
          }
    }
}
    

