using System;
using System.Collections.Generic;
using System.Text;


namespace Assignment_7_D
{
    [Serializable]
    class Employee
    {
        public int id;
        public string name;
        public double salary;

        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }


    }
}

