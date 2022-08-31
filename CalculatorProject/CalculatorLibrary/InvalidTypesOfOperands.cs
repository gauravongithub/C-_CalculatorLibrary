using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorLibrary
{
    public class InvalidTypesOfOperands : ExceptionHandling
    {
        public InvalidTypesOfOperands(string message)
        {
            Console.WriteLine(message);
        }
    }
}