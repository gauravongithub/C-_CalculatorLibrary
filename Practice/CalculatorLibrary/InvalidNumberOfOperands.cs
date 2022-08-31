﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorLibrary
{
    public class InvalidNumberOfOperands : ExceptionHandling
    {
        public InvalidNumberOfOperands(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}