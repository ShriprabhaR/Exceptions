using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    internal class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(String message) :base(message) { }

        public override string ToString()
        {
            return "Excption occured: "+Message;
        }
    }
}
