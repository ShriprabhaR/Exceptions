using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    internal class AgeInvalidException : Exception
    {
        public AgeInvalidException(String message) : base(message) { }

        public override string ToString()
        {
            return "Exception: "+Message;
        }
    }
}
