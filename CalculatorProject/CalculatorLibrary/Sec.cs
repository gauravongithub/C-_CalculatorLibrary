using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorLibrary
{
    public class Sec : Unary
    {
        protected override double Calculate(double[] listOfOperand)
        {
            return 1/Math.Cos((Math.PI / 180)*listOfOperand[0]);
        }
    }
}