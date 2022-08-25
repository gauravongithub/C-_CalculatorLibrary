using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorLibrary
{
    public class Cot : Unary
    {
        protected override double Calculate(double[] listOfOperands)
        {
            return 1/Math.Tan((Math.PI / 180)*listOfOperands[0]);
        }
    }
}