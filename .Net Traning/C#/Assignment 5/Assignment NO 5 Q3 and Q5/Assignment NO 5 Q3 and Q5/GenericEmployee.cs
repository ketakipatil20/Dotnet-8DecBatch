using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_NO_5_Q3_and_Q5
{
    class GenericEmployee
    {
        public int e_id;
        public string e_name;
        public double e_sal;



        public GenericEmployee(int e_id, string e_name, double e_sal)
        {
            this.e_id = e_id;
            this.e_name = e_name;
            this.e_sal = e_sal;
        }
        public override string ToString()
        {
            return "\nID :" + e_id + "\nName :" + e_name + "\nSalary :" + e_sal;
        }
    }
}
