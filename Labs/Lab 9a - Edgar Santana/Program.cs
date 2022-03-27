using System;

namespace Lab_9a___Edgar_Santana
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            int a;
            int b;

            while (true)
            {
                Console.WriteLine("1. Multiply");
                Console.WriteLine("2. Divide");
                Console.WriteLine("3. Modulo");
                Console.WriteLine("0. Quit");
                choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter 1st integer: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter 2nd integer: ");
                b = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine(recursive_multiply(a, b));
                        continue;
                    case 2:
                        Console.WriteLine(recursive_div(a, b));
                        continue;
                    case 3:
                        Console.WriteLine(recursive_mod(a, b));
                        continue;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public static int recursive_multiply(int a, int b)
        {
            int answer;

            if (b == 0)
            {
                answer = 0;
            }
            else if (b == 1)
            {
                answer = a;
            }
            else
            {
                answer = a + recursive_multiply(a, b - 1);
            }
            return answer;
        }

        public static int recursive_div(int a, int b)
        {
            int answer;
            
            if(a < b)
            {
                answer = 0;
            }
            else if (a == b)
            {
                answer = 1;
            }
            else
            {
                answer = 1 + recursive_div(a - b, b);
            }
            return answer;
        }

        public static int recursive_mod(int a, int b)
        {
            int answer;

            if (a < b)
            {
                answer = a;
            }
            else if (a == b)
            {
                answer = 0;
            }
            else
            {
                answer = recursive_mod(a - b, b);
            }
            return answer;
        }
    }
}
