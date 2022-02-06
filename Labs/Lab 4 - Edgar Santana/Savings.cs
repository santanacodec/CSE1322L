using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4___Edgar_Santana
{
    class Savings : Account
    {
        public Savings(double savingsBalance) : base(savingsBalance) { }

        public override void withdraw(double wAmount)
        {
            if (wAmount < getAccountBalance())
            {
                setAccountBalance(getAccountBalance() - wAmount);
            } 
            if (getAccountBalance() < 500)
            {
                Console.WriteLine("Charging a fee of $10 because you are below" +
                    " $500");
                setAccountBalance(getAccountBalance() - 10);
            }
        }

        public override double deposit(double dAmount)
        {
            int tick = 0;
            if (dAmount > dAmount)
            {
                tick++;
                return "This is " + tick + " deposit to this account";
            } 

            if (tick > 5)
            {
                return ""
            }
        }
    }
}
