using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6___Edgar_Santana
{
    class FibIteration : IFindFib
    {
        public int calculate_fib(int n)
        {
            int fNum = 1;
            int sNum = 1;
            int result = 0;
            
            if (n == 1 || n == 2)
            {
                return 1;
            }

            for(int i = 3; i <= n; i++)
            {
                result = fNum + sNum;
                fNum = sNum;
                sNum = result;
            }
            return result;
        }
    }
}
