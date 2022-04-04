using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9
{
    class Checking_Account : Bank_Account
    {
        private double Daily_Withdrawal_Limit { get; set; }

        public Checking_Account(string name, string userId, string userPassword) : base(name, userId, userPassword)
        {
            Daily_Withdrawal_Limit = 300.00;
        }

    }
}
