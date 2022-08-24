using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorLibrary
{
    public class MemoryLimitExceeded : ExceptionHandling
    {
        public MemoryLimitExceeded(string message)
        {
            Console.WriteLine(message);
        }
    }
}