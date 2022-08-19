using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class UnknownOperatorsException : ExceptionHandling
    {
        public UnknownOperatorsException(string message)
        {
            Console.WriteLine(message);
        }
    }
}