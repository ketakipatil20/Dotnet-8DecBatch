using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_3
{
    [Serializable]
    class Manager : Employee
    {
        int EmpNo;
        string EmpName;
        double salary;
        double Petrol_A;
        double Food_A;
        double Other_A;
        double gs;
        double PF;
        double TDS;
        double NetSalary;

        public Manager(int EmpNo, string EmpName, double salary) : base(EmpNo, EmpName, salary)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.salary = salary;

        }


        public new void Calculate()
        {

            Petrol_A = this.salary / 8;
            Console.WriteLine("\n The Petrol allowance is : " + Petrol_A);
            Food_A = this.salary / 13;
            Console.WriteLine("\n The food allowance is : " + Food_A);
            Other_A = this.salary / 3;
            Console.WriteLine("\n The other allowance is :" + Other_A);
            base.CalculateSalary();
            gs = GrossSalary;

            GrossSalary = GrossSalary + Petrol_A + Food_A + Other_A;

            Console.WriteLine("\n GrossSalary of Manager is:" + GrossSalary);
        }

        public override void CalculateSalary()
        {

            PF = gs / 10;
            TDS = gs / 18;
            NetSalary = gs - (PF + TDS);
            Console.WriteLine("\n NetSalary is:" + NetSalary);
        }



    }
}