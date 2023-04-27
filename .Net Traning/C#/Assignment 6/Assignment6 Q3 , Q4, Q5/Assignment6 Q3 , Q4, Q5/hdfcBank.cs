using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6_Q3___Q4__Q5
{
    class hdfcbank : Account
    {
        public hdfcbank(double an, string cname, double bal) : base(an, cname, bal)
        { }
        public bool ZeroBalance(double amount)
        {
            return false;
        }
        public bool UnderBalance(double amount)
        {
            if (account_balance <= 1000 || account_balance - amount <= 0)
            {
                Console.WriteLine("Transaction cannot be continued below specified limit of Rs.- 1000");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
