using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_3

{
    interface IPrintable
    {
         void  displayDetails();
    }
    
    class Employee : IPrintable
    {
        private int EmpNo;
        private string EmpName;
        private double salary;
        private double PF;
        private double TDS;
        private double NetSalary;
        public double GrossSalary;



        public Employee(int EmpNo, string EmpName, double salary)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.salary = salary;

        }
        public  virtual void  CalculateSalary()
        {

            if (this.salary < 5000)
            {
                this.GrossSalary = (this.salary + (this.salary * 10 / 100) + (this.salary * 5 / 100) + (this.salary * 15 / 100));
                this.PF = this.GrossSalary * 10 / 100;
                this.TDS = this.GrossSalary * 18 / 100;
                this.NetSalary = this.GrossSalary - (this.PF + this.TDS);
            }
            else if (this.salary < 10000)
            {
                this.GrossSalary = (this.salary + (this.salary * 15 / 100) + (this.salary * 10 / 100) + (this.salary * 20 / 100));
                this.PF = this.GrossSalary * 10 / 100;
                this.TDS = this.GrossSalary * 18 / 100;
                this.NetSalary = this.GrossSalary - (this.PF + this.TDS);
            }



            else if (this.salary < 15000)
            {
                this.GrossSalary = (this.salary + (this.salary * 20 / 100) + (this.salary * 15 / 100) + (this.salary * 25 / 100));
                this.PF = this.GrossSalary * 10 / 100;
                this.TDS = this.GrossSalary * 18 / 100;
                this.NetSalary = this.GrossSalary - (this.PF + this.TDS);
            }



            else if (this.salary < 20000)
            {
                this.GrossSalary = (this.salary + (this.salary * 20 / 100) + (this.salary * 25 / 100) + (this.salary * 30 / 100));
                this.PF = this.GrossSalary * 10 / 100;
                this.TDS = this.GrossSalary * 18 / 100;
                this.NetSalary = this.GrossSalary - (this.PF + this.TDS);
            }



            else if (this.salary >= 20000)
            {
                this.GrossSalary = (this.salary + (this.salary * 20 / 100) + (this.salary * 25 / 100) + (this.salary * 35 / 100));
                this.PF = this.GrossSalary * 10 / 100;
                this.TDS = this.GrossSalary * 18 / 100;
                this.NetSalary = this.GrossSalary - (this.PF + this.TDS);
            }
            else
            {
                System.Console.WriteLine("\n You entered wrong details");
            }
        }



        public void displayDetails()
        {
            System.Console.WriteLine("Id : " + this.EmpNo + "\nEmployee Name : " + this.EmpName + "\nSalary : " + this.salary + "\nGross Salary : " + this.GrossSalary + "\nNet Salary : " + this.NetSalary);
        }
    }
}
