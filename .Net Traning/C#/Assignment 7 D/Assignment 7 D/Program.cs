using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment_7_D
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\KETAKPAT\.NET\Assignment 7 D\Assignment 7 D\Text.txt";
            Employee emp = new Employee(123, "Ketaki", 40000);
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();


            bf.Serialize(stream, emp);
            stream.Close();
            Console.WriteLine(" File created successfully -> " + path);


            FileStream stream1 = new FileStream(path, FileMode.Open, FileAccess.Read);
            Employee objnew = (Employee)bf.Deserialize(stream1);

            Console.WriteLine(objnew.id);
            Console.WriteLine(objnew.name);
            Console.WriteLine(objnew.salary);

        }
    }
}
