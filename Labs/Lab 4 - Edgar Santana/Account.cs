using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4___Edgar_Santana
{
    class Account
    {
        Random rnd = new Random();
        private static int accountNumber;
        private double accountBalance;

        public Account()
        {
            accountNumber = rnd.Next();
            accountBalance = 0;
        }

        public Account(double accountBalance)
        {
            this.accountBalance = accountBalance;
            accountNumber = rnd.Next();
        }

        public int getAccountNumber()
        {
            accountNumber = rnd.Next();
            return accountNumber;
        }

        public double getAccountBalance()
        {
            return accountBalance;
        }

        public void setAccountBalance(double accountBalance)
        {
            this.accountBalance = accountBalance;
        }

        public virtual void withdraw(double wAmount)
        {
            accountBalance -= wAmount;
        }

        public virtual double deposit(double dAmount)
        {
            return accountBalance + dAmount;
        }
    }
}
