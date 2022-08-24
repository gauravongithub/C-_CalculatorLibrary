using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorLibrary
{
    public class Sin : Unary
    {
        protected override double Calculate(double[] listOfOperands)
        {
            return Math.Sin(listOfOperands[0]);
            throw new System.NotImplementedException();
        }
    }
}