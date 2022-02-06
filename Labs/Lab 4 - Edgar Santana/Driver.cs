using System;

namespace Lab_4___Edgar_Santana
{
    class Driver
    {
        static void Main(string[] args)
        {
            Checking checking = new Checking(0);
            Savings savings = new Savings(500);
            int menuChoice;
            while (true)
            {
                Console.WriteLine("What would you like to do?");

                Console.WriteLine("1. Withdraw from Checking");
                Console.WriteLine("2. Withdraw from Savings");
                Console.WriteLine("3. Deposit to Checking");
                Console.WriteLine("4. Deposit to Savings");
                Console.WriteLine("5. Balance of Checking");
                Console.WriteLine("6. Balance of Savings");
                Console.WriteLine("7. Award Interest to Savings now");
                Console.WriteLine("8. Quit");

                menuChoice = Convert.ToInt32(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("How much woud you like to withdraw from" +
                            " your checking account?");
                        double cWAmount = Convert.ToDouble(Console.ReadLine());

                        checking.withdraw(cWAmount);
                        continue;
                    case 2:
                        Console.WriteLine("How much would you like to withdraw from" +
                            " your savings account?");
                        double sWAmount = Convert.ToDouble(Console.ReadLine());

                        savings.withdraw(sWAmount);
                        continue;
                    case 3:
                        Console.WriteLine("How much would you like to deposit to " +
                            "your checking account?");
                        double cDAmount = Convert.ToDouble(Console.ReadLine());

                        checking.deposit(cDAmount);
                        continue;
                    case 4:
                        Console.WriteLine("How much would you like to deposit to " +
                            "your savings account?");
                        double sDAmount = Convert.ToDouble(Console.ReadLine());

                        savings.deposit(sDAmount);
                        continue;
                    case 5:
                        Console.WriteLine("Your Balance for your Checking account is: " +
                            checking.getAccountBalance());
                        continue;
                    case 6:
                        Console.WriteLine("Your Balance for your Savings account is: " +
                            savings.getAccountBalance());
                        continue;
                    case 7:
                        Console.WriteLine("Awarding Interest to Savings account: ");
                        savings.interest();
                        continue;
                    case 8:
                        Environment.Exit(0);
                        break;
                }
            }

        }
    }
}
