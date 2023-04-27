using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6_Q1_and_Q2
{
    interface IPrintable
    {
        void info();


    }
    public class employee : IPrintable
    {
        int empId;
        string empName;
        double empSal;
        public double pf, tds, netsal, grossSal;

        public employee(int empId, string empName, double empSal)
        {
            this.empId = empId;
            this.empName = empName;
            this.empSal = empSal;


        }

        public virtual void CalGrossSal()
        {
            if (this.empSal < 5000)
            {
                this.grossSal = this.empSal + (this.empSal * 10 / 100) + (this.empSal * 5 / 100) + (this.empSal * 15 / 100);



            }

            else if (this.empSal < 10000)
            {
                this.grossSal = this.empSal + (this.empSal * 15 / 100) + (this.empSal * 10 / 100) + (this.empSal * 20 / 100);

            }
            else if (this.empSal < 15000)
            {
                this.grossSal = this.empSal + (this.empSal * 20 / 100) + (this.empSal * 15 / 100) + (this.empSal * 25 / 100);


            }
            else if (this.empSal < 20000)
            {
                this.grossSal = this.empSal + (this.empSal * 25 / 100) + (this.empSal * 20 / 100) + (this.empSal * 30 / 100);


            }
            else if (this.empSal <= 20000)
            {
                this.grossSal = this.empSal + (this.empSal * 30 / 100) + (this.empSal * 25 / 100) + (this.empSal * 35 / 100);


            }


        }

        public virtual void CalculateSal()
        {
            pf = grossSal / 10;

            tds = grossSal / 18;

            netsal = grossSal - (pf + tds);


        }
        public void info()
        {
            Console.WriteLine("The Emp Id is " + empId + "\n The Emp Name is " + empName + "\nempSal is: " + empSal);
            Console.WriteLine("---------------------------------");
        }
    }



}
