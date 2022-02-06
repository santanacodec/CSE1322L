using System;

namespace Lab_4___Edgar_Santana
{
    class Driver
    {
        static void Main(string[] args)
        {
            Checking checking = new Checking(0);
            Savings savings = new Savings(500);

            Console.WriteLine("What would you like to do?");

            Console.WriteLine("1. Withdraw from Checking");
            Console.WriteLine("2. Withdraw from Savings");
            Console.WriteLine("3. Deposit to Checking");
            Console.WriteLine("4. Deposit to Savings");
            Console.WriteLine("5. Balance of Checking");
            Console.WriteLine("6. Balance of Savings");
            Console.WriteLine("7. Award Interest to Savings now");
            Console.WriteLine("8. Quit");



        }
    }
}
