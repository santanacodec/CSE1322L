using System;
using System.Collections.Generic;

namespace Assignment_5
{
    class Driver
    {
        static void Main(string[] args)
        {
            List<InsurancePolicy> ipObjects = new List<InsurancePolicy>();

            while(true)
            {
                Console.WriteLine("Choose from the following menu");

                Console.WriteLine("1- Create Health Insurance Policy");
                Console.WriteLine("2- Create Term-Life Insurance Policy");
                Console.WriteLine("3- Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Please enter policy holder name:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter deductible amount:");
                        double deductibleAmount = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter co-payment amount:");
                        double coPayment = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter total out-of-pocket amount:");
                        double totalOutOfPocket = Convert.ToDouble(Console.ReadLine());

                        HealthInsurancePolicy IP = new HealthInsurancePolicy(name, deductibleAmount, coPayment, totalOutOfPocket);
                        ipObjects.Add(IP);
                        break;
                    case 2:
                        Console.WriteLine("Please enter policy holder name:");
                        string tlname = Console.ReadLine();

                        Console.WriteLine("Enter name of beneficiary:");
                        string benName = Console.ReadLine();

                        Console.WriteLine("Enter number of years in term:");
                        int years = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter amount of payout");
                        double payout = Convert.ToDouble(Console.ReadLine());

                        TermLifeInsurancePolicy TLIP = new TermLifeInsurancePolicy(tlname, benName, years, payout);
                        ipObjects.Add(TLIP);
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Error: Enter a valid input");
                        break;
                }
                for (int i = 0; i < ipObjects.Count; i++)
                {
                    Console.WriteLine(ipObjects[i].ToString());
                }
                break;

            }
            
        }
    }
}
