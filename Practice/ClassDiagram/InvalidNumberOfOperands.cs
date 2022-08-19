using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class InvalidNumberOfOperands : ExceptionHandling
    {
        public InvalidNumberOfOperands(string message)
        {
            Console.WriteLine(message);
        }
    }
}