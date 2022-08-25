using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorLibrary
{
    public class Cosec : Unary
    {
        protected override double Calculate(double[] listOfOperand)
        {
            return 1/Math.Sin((Math.PI / 180)*listOfOperand[0]);
        }
    }
}