using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorLibrary
{
    public class Square : Unary
    {
        protected override double Calculate(double[] listOfOperand)
        {
            return listOfOperand[0]*listOfOperand[0];
        }
    }
}