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

        public override void deposit(double dAmount)
        {
            int tick = 0;
            tick++;

            Console.WriteLine("This is deposit " + tick + "to this account.");

            if(tick > 6)
            {
                Console.WriteLine("Charging a fee of $10");
                setAccountBalance(getAccountBalance() - 10);
            }
        }

        public void interest()
        {
            double annualInterestRate = 1.5;
            double monthlyInterestRate = (annualInterestRate / 100) / 12;
            double monthlyInterest = getAccountBalance() * monthlyInterestRate;

            Console.WriteLine("Customer earned " + monthlyInterest + " in interest.");

            setAccountBalance(getAccountBalance() + monthlyInterest);
        }
    }
}
