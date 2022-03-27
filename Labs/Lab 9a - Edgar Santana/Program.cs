using System;

namespace Lab_9a___Edgar_Santana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int recursive_multiply(int a, int b)
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

        public int recursive_div(int a, int b)
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

        public int recursive_mod(int a, int b)
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
