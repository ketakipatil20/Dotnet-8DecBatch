using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Assignment_7_A
{
    class Program
    {
        static void Main(string[] args)
        {
            // create directory
            String path = @"C:\Users\KETAKPAT\.NET\Assignment 7 A";

            DirectoryInfo fl = new DirectoryInfo(path);
            fl.Create();
            {
                Console.WriteLine("Directory has been created");
            }

            string[] directory = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            //return name of sub directory

            string[] file = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            //return name of sub file
            Console.WriteLine("Directory Details----");
            foreach (string diNext in directory)
            {
                var dirInfo = new DirectoryInfo(diNext);
                Console.WriteLine(dirInfo.FullName);
            }
            Console.WriteLine("File Details----");
            foreach (string fiNext in file)
            {
                var fileInfo = new FileInfo(fiNext);
                Console.WriteLine(fileInfo.FullName);


            }

        }
    }
}
