using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9
{
    class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }
}
