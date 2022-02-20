using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6___Edgar_Santana
{
    class FibFormula : IFindFib
    {
        public int calculate_fib(int n)
        {
            return Convert.ToInt32((Math.Pow(((1 + Math.Sqrt(5)) / 2), n) - Math.Pow(((1 - Math.Sqrt(5)) / 2), n)) / Math.Sqrt(5));
        }
    }
}
