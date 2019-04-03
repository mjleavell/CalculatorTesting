using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    // needs to be public because we are trying to access this class in a separate project
    public class InvalidInputException : Exception
    {
        public InvalidInputException() : base("The input received was invalid.")
        {
        }
    }
}
