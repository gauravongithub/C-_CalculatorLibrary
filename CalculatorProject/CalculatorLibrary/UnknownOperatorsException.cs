using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorLibrary
{
    public class UnknownOperatorsException : ExceptionHandling
    {
        public UnknownOperatorsException(string message)
        {
            Console.WriteLine(message);
        }
    }
}