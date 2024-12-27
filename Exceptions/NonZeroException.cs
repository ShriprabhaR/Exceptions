using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    internal class NonZeroException : Exception
    {
        public NonZeroException(string message) : base(message) { }

        public override string ToString()
        {
            return "Exception: "+ Message;
        }
    }
}
