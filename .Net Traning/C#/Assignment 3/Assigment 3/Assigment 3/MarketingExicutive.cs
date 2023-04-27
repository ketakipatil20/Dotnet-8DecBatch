using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_3
{
    class MarketingExicutive:Employee
    {
        int EmpNo;
        string EmpName;
        double salary;
        
        double Tour_A;
        double Telephone_A ;
        double gs;
        double PF;
        double TDS;
        double NetSalary;
        double km;


        public MarketingExicutive(int EmpNo, string EmpName, double salary,double km) : base(EmpNo, EmpName, salary)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.salary = salary;
            this.km = km;

        }

        public new void Calculate()
        {
            Tour_A = 5 * this.km;
            Console.WriteLine("\n The Tour allowance is : " + Tour_A);
            Telephone_A = 1000;
            Console.WriteLine("\n The Telephone allowance is :" + Telephone_A);
            base.CalculateSalary();
            gs = GrossSalary;

            GrossSalary = GrossSalary +Tour_A + Telephone_A;
            Console.WriteLine("\n GrossSalary of MarketingExicutive is:" + GrossSalary);
        }

        public override void CalculateSalary()
        {

            PF = gs / 10;
            TDS = gs / 18;
            NetSalary = gs - (PF + TDS);
            Console.WriteLine("NetSalary is:" + NetSalary);
        }
    }
}
