using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6_Q3___Q4__Q5
{
    public delegate bool del(double amount);
    public delegate bool ZeroBalance(double amount);//define delegate
    class Account
    {
        public event del MyEvent;

        public double acoount_number;
        public string customer_number;
        public double account_balance;
        public double amount;

        public Account(double an, string cname, double bal)
        {
            acoount_number = an;
            customer_number = cname;
            account_balance = bal;

            Display();
        }

        public void Deposit(double amount)
        {
            account_balance = account_balance + amount;
            Console.WriteLine("Deoposited money is " + amount);
            Console.WriteLine("After Deposition, money is " + account_balance);
        }

        public void Withdraw(double amount, del uBalance, ZeroBalance zBalance)
        {
            if (!zBalance(amount))
            {
                if (!uBalance(amount))
                {
                    account_balance = account_balance - amount;
                    Console.WriteLine(" Withdraw money is " + amount);
                    Console.WriteLine("After Withdraw money is " + account_balance);
                }
            }

        }

        public void Display()
        {
            Console.WriteLine("Customer Name is " + customer_number + "\n Account Number is " + acoount_number + "\n Balance is " + account_balance);
            Console.WriteLine("--------------------------------------------------------------------------------------");

        }
    }
}
