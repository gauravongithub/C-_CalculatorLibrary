using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorLibrary
{
    public class Cos : Unary
    {
        protected override double Calculate(double[] listOfOperand)
        {
            return Math.Cos((Math.PI / 180)*listOfOperand[0]);
        }
    }
}