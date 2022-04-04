using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9
{
    class Bank_Account
    {
        private string name;
        private int accountID;
        private static int Number_Of_Accounts = 0;
        private string userId;
        private string userPassword;
        private double accountBalance { get; set; }

        public Bank_Account (string name, string userId, string userPassword)
        {
            this.name = name;
            this.userId = userId;
            this.userPassword = userPassword;
            accountID = ++Number_Of_Accounts;
        }

        public int getAccountID()
        {
            return accountID;
        }



        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getUserId()
        {
            return userId;
        }

        public void setUserId(string userId)
        {
            this.userId = userId;
        }

        public string getUserPassword()
        {
            return userPassword;
        }

        public void setUserPassword(string userPassword)
        {
            this.userPassword = userPassword;
        }

        public double getAccountBalance()
        {
            return accountBalance;
        }

        public void setAccountBalance(double accountBalance)
        {
            this.accountBalance = accountBalance;
        } 

        public static int getNumber_Of_Accounts()
        {
            return Number_Of_Accounts;
        }

        public static void decrementNumber_Of_Accounts()
        {
            Number_Of_Accounts--;
        }

    }
}
