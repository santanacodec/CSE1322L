using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4
{
    class AutoLoan : Loan
    {
        private double downPayment { get; set; }

        public AutoLoan(string name, double amount, double rate, int months, double downPayment) : 
            base(name, amount, rate, months)
        {
            this.downPayment = downPayment;
        }

        public override void calculateMonthlyPayment()
        {
            double monthlyPayment = (getInterestRate() * (getLoanBalance() - downPayment)) /
                (1 - Math.Pow((1 + getInterestRate()), -getNumberOfMonthlyPayments()));
            setMonthlyPayment(monthlyPayment);
        }

        public override string ToString()
        {
            return base.ToString() + "\nDown Payment: " + downPayment;
        }
    }
}
