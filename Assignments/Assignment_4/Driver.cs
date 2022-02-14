using System;
using System.Collections.Generic;

namespace Assignment_4
{
    class Driver
    {
        static void Main(string[] args)
        {
            List<Loan> loanObjects = new List<Loan>();

            while(true)
            {
                Console.WriteLine("What would you like to do?");

                Console.WriteLine("1- Add Loan");
                Console.WriteLine("2- Delete Loan");
                Console.WriteLine("3- Calculate Monthly Payments");
                Console.WriteLine("4- Print Loans");
                Console.WriteLine("5- Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        addLoan(loanObjects);
                        continue;
                    case 2:
                        deleteLoan(loanObjects);
                        continue;
                    case 3:
                        calculateMonthlyLoanPayment(loanObjects);
                        continue;
                    case 4:
                        printLoans(loanObjects);
                        continue;
                    case 5:
                        break;
                }

                if (choice != 1 || choice != 2 || choice != 3 || choice != 4 || choice != 5) 
                {
                    Console.WriteLine("ERROR: Please enter a valid input");
                }
            }
        }

        public static void addLoan(List<Loan> loanObjects)
        {
            Console.WriteLine("Enter Loan Type (1 - Student, 2 - Auto)");
            int loanType = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer Name: ");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter Loan Amount: ");
            double loanAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Loan Interest Rate: ");
            double loanInterestRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Number of Monthly Payments");
            int numberOfMonthlyPayments = Convert.ToInt32(Console.ReadLine());

            if (loanType == 1)
            {
                Console.WriteLine("Is the Loan deferred? (true or false)");
                bool isDeferred = Convert.ToBoolean(Console.ReadLine());

                StudentLoan studentLoan = new StudentLoan(customerName, loanAmount, loanInterestRate, numberOfMonthlyPayments, isDeferred);
                loanObjects.Add(studentLoan);
            }
            else if(loanType == 2)
            {
                Console.WriteLine("Enter Down Payment");
                double downPayment = Convert.ToDouble(Console.ReadLine());

                AutoLoan autoLoan = new AutoLoan(customerName, loanAmount, loanInterestRate, numberOfMonthlyPayments, downPayment);
                loanObjects.Add(autoLoan);
            }
        }

        public static void deleteLoan(List<Loan> loanObjects)
        {
            Console.WriteLine("Enter Customer Name: ");
            string customerName = Console.ReadLine();

            for (int i = 0; i < loanObjects.Count; i++)
            {
                if(customerName == loanObjects[i].getCustomerName())
                {
                    loanObjects.RemoveAt(i);
                    Loan.decreaseNumberOfLoans();
                }
            }
        }

        public static void calculateMonthlyLoanPayment(List<Loan> loanObjects)
        {
            for (int i = 0; i < loanObjects.Count; i++)
            {
                loanObjects[i].calculateMonthlyPayment();
            }
        }

        public static void printLoans(List<Loan> loanObjects)
        {
            for(int i = 0; i < loanObjects.Count; i++)
            {
                loanObjects[i].ToString();
            }
        }
    }
}
