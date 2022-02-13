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

        public string getCustomerName()
        {
            return customerName;
        }

        public int getAccountNumber()
        {
            return accountNumber;
        }

        public double getLoanBalance()
        {
            return loanBalance;
        }

        public double getMonthlyPayment()
        {
            return monthlyPayment;
        }

        public double getInterestRate()
        {
            return interestRate;
        }

        public int getNumberOfMonthlyPayments()
        {
            return numberOfMonthlyPayments;
        }

        public void setCustomerName(string customerName)
        {
            this.customerName = customerName;
        }

        public void setAccountNumber(int accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public void setLoanBalance(double loanBalance)
        {
            this.loanBalance = loanBalance;
        }

        public void setMonthlyPayment(double monthlyPayment)
        {
            this.monthlyPayment = monthlyPayment;
        }

        public void setInterestRate(double interestRate)
        {
            this.interestRate = interestRate;
        }

        public void setNumberOfMonthlyPayments(int numberOfMonthlyPayments)
        {
            this.numberOfMonthlyPayments = numberOfMonthlyPayments;
        }

        public static int decreaseNumberOfLoans()
        {
            return numberOfLoans--;
        }

        public void calculateMonthlyPayment()
        {
            monthlyPayment = (interestRate * (loanBalance)) / 
                (1 - Math.Pow((1 + interestRate), -numberOfMonthlyPayments));
        }

        public override string ToString()
        {
            return "Customer Name: " + customerName + "\nAccountNumber: " + accountNumber +
                "\nLoan Balance: " + loanBalance + "\nMonthly Payment: " + monthlyPayment +
                "\nInterest Rate: " + interestRate + "\nNumber of Monthly Payments: " + numberOfMonthlyPayments;
        }
    }
}
