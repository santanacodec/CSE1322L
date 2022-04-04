using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9
{
    class InvalidPasswordFormatException : Exception
    {
        public InvalidPasswordFormatException(string message) : base(message) {}
    }
}
