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
        }
    }
}
