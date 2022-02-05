using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4___Edgar_Santana
{
    class Checking : Account
    {
        double overdraftLimit = 0;
        public Checking(double checkingBalance) : base(checkingBalance) { }

        public override void withdraw(double wAmount) {
            if (getAccountBalance() - wAmount > overdraftLimit)
            {
                setAccountBalance(getAccountBalance() - wAmount);
            } else if (getAccountBalance() - wAmount < overdraftLimit)
            {
                Console.WriteLine("Charging an overdraft fee of $20 because" +
                    " account is below $0");
                setAccountBalance(getAccountBalance() - 20);
            }
        }
    }
}
