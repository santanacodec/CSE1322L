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
    }
}
