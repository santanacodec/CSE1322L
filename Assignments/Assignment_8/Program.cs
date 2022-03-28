using System;

namespace Assignment_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            while(true)
            {
                Console.WriteLine("1 - Convert Decimal Number to Binay Number");
                Console.WriteLine("2 - Convert Decimal Number to Hexadecimal Number");
                Console.WriteLine("3 - Convert Decimal IP Address to Binary IP Address");
                Console.WriteLine("4 - Convert Decimal MAC Address to Hexadecimal MAC Address");
                Console.WriteLine("5 - Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter Decimal Integer: ");
                        int decimalInteger = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Decimal Number: " + decimalInteger);
                        Console.WriteLine("Binary Number: " + decimal2Binary(decimalInteger));
                        continue;
                    case 2:
                        Console.WriteLine("Enter Decimal Integer: ");
                        decimalInteger = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Decimal Number: " + decimalInteger);
                        Console.WriteLine("Hexadecimal Number: " + decimal2Hexadecimal(decimalInteger));
                        continue;
                    case 3:
                        Console.WriteLine("Enter Decimal IP Address (i.e. 192.168.25.140): ");
                        string ipAddress = Console.ReadLine();
                        string[] decimalNum = ipAddress.Split("\\.");
                        Console.WriteLine("Decimal IP Address: " + ipAddress);
                        Console.WriteLine("Binary IP Address: " + convertIpAddress(decimalNum, 0));
                        continue;
                    case 4:
                        Console.WriteLine("Enter Decimal MAC Address (i.e. 203:65:157:93:13:7): ");
                        string macAdress = Console.ReadLine();
                        string[] decNum = macAdress.Split(":");
                        Console.WriteLine("Deciam MAC Address: " + macAdress);
                        Console.WriteLine("Hexadecimal MAC Address: " + convertMacAddress(decNum, 0));
                        continue;
                    case 5:
                        break;
                }
            }
        }

        public static string decimal2Binary(int a)
        {
            string output;
            if(a == 0)
            {
               output = "";
            } 
            else
            {
                int remainder = (a % 2);
                output = decimal2Binary(a / 2) + Convert.ToString(remainder);
            }

            return output;
        }

        public static string decimal2Hexadecimal(int a)
        {
            int remainder = a % 16;

            if (a != 0)
            {
                switch(remainder)
                {
                    case 10:
                        return decimal2Hexadecimal(a / 16) + "A";
                    case 11:
                        return decimal2Hexadecimal(a / 16) + "B";
                    case 12:
                        return decimal2Hexadecimal(a / 16) + "C";
                    case 13:
                        return decimal2Hexadecimal(a / 16) + "D";
                    case 14:
                        return decimal2Hexadecimal(a / 16) + "E";
                    case 15:
                        return decimal2Hexadecimal(a / 16) + "F";
                    default:
                        return decimal2Hexadecimal(a / 16) + remainder;
                }
            }
            else
            {
                return "";
            }
        }

        public static string convertIpAddress(string[] s, int i)
        {
            if(i == s.Length - 1)
            {
                return decimal2Binary(Int32.Parse(s[i]));
            }
            return decimal2Binary(Int32.Parse(s[i])) + "." + convertIpAddress(s, ++i);
        }

        public static string convertMacAddress(string[] s, int i)
        {
            if ( i == s.Length - 1)
            {
                return decimal2Hexadecimal(Int32.Parse(s[i]));
            }
            return decimal2Hexadecimal(Int32.Parse(s[i])) + ":" + convertMacAddress(s, ++i);
        }
    }
}
