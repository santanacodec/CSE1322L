using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9
{
    class NegativeDollarAmountException : Exception
    {
        public NegativeDollarAmountException(string message) : base(message) { }
    }
}
