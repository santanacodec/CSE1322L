using System;

namespace Lab_6___Edgar_Santana
{
    class Driver
    {
        static void Main(string[] args)
        {
            FibIteration fibIt = new FibIteration();
            FibFormula fibForm = new FibFormula();
            Console.WriteLine("Enter the number you want to find the Fibonacci Series for: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fib of " + num + " by iteration is: " + fibIt.calculate_fib(num));
            Console.WriteLine("Fib of " + num + " by formula is: " + fibForm.calculate_fib(num));
        }
    }
}
