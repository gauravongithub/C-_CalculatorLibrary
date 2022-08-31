using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorLibrary
{
    public class Inverse : Unary
    {
        protected override double Calculate(double[] listOfOperand)
        {
            return 1/listOfOperand[0];
        }
    }
}