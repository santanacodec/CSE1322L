using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9
{
    class CustomerAccountNotFoundException : Exception
    {
        public CustomerAccountNotFoundException(string message) : base(message) { }
    }
}
