using System;

namespace Lab_9b___Edgar_santana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(repeatNTimes("I must study recursion until it makes sense\n", 100));

            Console.WriteLine("Please enter your first string");
            string firstString = Console.ReadLine();

            Console.WriteLine("Please enter your second string");
            string secondString = Console.ReadLine();

            Console.WriteLine("Is reversed: " + isReverse(firstString, secondString));
            if (isReverse(firstString, secondString) == true)
            {
                Console.WriteLine(firstString + " is the reverse of " + secondString);
            } 
            else if(isReverse(firstString, secondString) == false)
            {
                Console.WriteLine(firstString + " is not the reverse of " + secondString);
            }
        }

        public static string repeatNTimes(string s, int i)
        {
            string answer = " ";
            for(int tick = 0; tick < i; tick++)
            {
                answer += s;
            }
            if (i == 0)
            {
                answer = " ";
            }
            return answer;
        }

        public static bool isReverse(string a, string b)
        {
            bool reverseOrNot = true;
            if (a.Length != b.Length)
            {
                reverseOrNot = false;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a.Substring(i) != b.Substring(a.Length - i - 1) )
                {
                    reverseOrNot = false;
                }
            }
            return reverseOrNot;
        }
    }
}
