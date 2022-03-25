using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception //inherits from the preexisting exception class
    {
        public FraudException()
            : base() { }//inherits from the base(which is Exception) constructor. 
        public FraudException(string message)//take one argument which is string message. Overloads the first constructor
            : base(message) { }
    }
}
