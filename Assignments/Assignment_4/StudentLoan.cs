using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4
{
    class StudentLoan : Loan
    {
        private bool isDeferred;

        public StudentLoan(string name, double amount, double rate, int months, bool isDef) : 
            base(name, amount, rate, months)
        {
            this.isDeferred = isDef;
        }

        public bool getIsDeferred()
        {
            return isDeferred;
        }

        public void setIsDeferred(bool isDeferred)
        {
            this.isDeferred = isDeferred;
        }
    }
}
