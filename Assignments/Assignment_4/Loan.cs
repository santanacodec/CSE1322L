using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4
{
    class Loan
    {
        private string customerName;
        private int accountNumber;
        private double loanBalance;
        private double monthlyPayment;
        private double interestRate;
        private int numberOfMonthlyPayments;
        private static int numberOfLoans = 0;

        public Loan(string name, double amount, double rate, int months)
        {
            this.customerName = name;
            this.loanBalance = amount;
            this.interestRate = rate;
            this.numberOfMonthlyPayments = months;
            accountNumber = ++numberOfLoans;
        }

        public static int getNumberOfLoans()
        {
            return numberOfLoans;
        }
    }
}
