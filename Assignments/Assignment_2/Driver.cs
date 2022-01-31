using System;

namespace Assignment_2
{
    class Driver
    {
        static void Main(string[] args)
        {
            Encryption enc = new Encryption();
            int answer;
            Console.WriteLine("Enter a number for the alphabet");
            answer = Convert.ToInt32(Console.ReadLine());
            enc.return_alphabet(answer);
        }
    }
}
