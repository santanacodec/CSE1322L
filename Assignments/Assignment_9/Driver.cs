using System;
using System.Collections.Generic;
namespace Assignment_9
{
    class Driver
    {
        
        static void Main(string[] args)
        {
            List<Bank_Account> bankAccount = new List<Bank_Account>();
            int choice;
            while(true)
            {
                Console.WriteLine("Please choose from the following options");
                Console.WriteLine("1 - Create An Account");
                Console.WriteLine("2 - Delete An Account");
                Console.WriteLine("3 - Make An Account Deposit");
                Console.WriteLine("4 - Make An Account Withdrawal");
                Console.WriteLine("5 - Check an Account Balance");
                Console.WriteLine("6 - Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        createAccount(bankAccount);
                        continue;
                    case 2:
                        deleteAccount(bankAccount);
                        continue;
                    case 3:
                        accountDeposit(bankAccount);
                        continue;
                    case 4:
                        accountWithdrawal(bankAccount);
                        continue;
                    case 5:
                        checkAccountBalance(bankAccount);
                        continue;
                    case 6:
                        break;
                }
            }

        }

        public static void createAccount(List<Bank_Account> bankAccount)
        {
            string name;
            string userId;
            string userPassword;
            Console.WriteLine("Enter Customer Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter User ID:");
            userId = Console.ReadLine();
            Console.WriteLine("Enter User Password");
            userPassword = Console.ReadLine();

            if (userPassword.Length < 8 || !userPassword.Contains("*"))
            {
                throw new InvalidPasswordFormatException("Password must be longer than 8 characters and must contain *");
            } else
            {
                Bank_Account account = new Bank_Account(name, userId, userPassword);
                bankAccount.Add(account);
            }
        }

        public static void deleteAccount(List<Bank_Account> bankAccount)
        {
            string userId;
            string userPassword;

            Console.WriteLine("Enter User ID: ");
            userId = Console.ReadLine();
            Console.WriteLine("Enter User Password: ");
            userPassword = Console.ReadLine();

            for (int i = 0; i < bankAccount.Count; i++)
            {
                if (userId == bankAccount[i].getUserId() && userPassword == bankAccount[i].getUserPassword())
                {
                    bankAccount.RemoveAt(i);
                } else
                {
                    throw new CustomerAccountNotFoundException("Customer not Found");
                }
            }
        }

        public static void accountDeposit(List<Bank_Account> bankAccount)
        {
            string userId;
            string userPassword;

            Console.WriteLine("Enter User ID: ");
            userId = Console.ReadLine();
            Console.WriteLine("Enter User Password: ");
            userPassword = Console.ReadLine();

            for (int i = 0; i < bankAccount.Count; i++)
            {
                if (userId == bankAccount[i].getUserId() && userPassword == bankAccount[i].getUserPassword())
                {
                    Console.WriteLine("Please enter a dollar Amount to deposit");
                    double dollarAmount = Convert.ToDouble(Console.ReadLine());

                    if (dollarAmount < 0 )
                    {
                        throw new NegativeDollarAmountException("Amount must be greater than $0");
                        
                    } else
                    {
                        bankAccount[i].setAccountBalance(dollarAmount);
                    }

                }
                else
                {
                    throw new CustomerAccountNotFoundException("Customer not Found");
                }
            }
        }

        public static void accountWithdrawal(List<Bank_Account> bankAccount)
        {
            string userId;
            string userPassword;

            Console.WriteLine("Enter User ID: ");
            userId = Console.ReadLine();
            Console.WriteLine("Enter User Password: ");
            userPassword = Console.ReadLine();

            for (int i = 0; i < bankAccount.Count; i++)
            {
                if (userId == bankAccount[i].getUserId() && userPassword == bankAccount[i].getUserPassword())
                {
                    Console.WriteLine("Please enter a dollar Amount to deposit");
                    double dollarAmount = Convert.ToDouble(Console.ReadLine());

                    if (dollarAmount < 0)
                    {
                        throw new NegativeDollarAmountException("Amount must be greater than $0");

                    }
                    else if (dollarAmount > bankAccount[i].getAccountBalance())
                    {
                        throw new InsufficientFundsException("Not enough funds");
                    }
                    else if(dollarAmount < bankAccount[i].getAccountBalance())
                    {
                        bankAccount[i].setAccountBalance(dollarAmount--);
                    }

                }
                else
                {
                    throw new CustomerAccountNotFoundException("Customer not Found");
                }
            }
        }

        public static void checkAccountBalance(List<Bank_Account> bankAccount)
        {
            string userId;
            string userPassword;

            Console.WriteLine("Enter User ID: ");
            userId = Console.ReadLine();
            Console.WriteLine("Enter User Password: ");
            userPassword = Console.ReadLine();

            for (int i = 0; i < bankAccount.Count; i++)
            {
                if (userId == bankAccount[i].getUserId() && userPassword == bankAccount[i].getUserPassword())
                {
                    Console.WriteLine("Customer name: " + bankAccount[i].getName() +
                        "Account Number: " + bankAccount[i].getAccountID() + "Account Balance: " + bankAccount[i].getAccountBalance());
                }
                else
                {
                    throw new CustomerAccountNotFoundException("Customer not Found");
                }
            }
        }
    }
}
