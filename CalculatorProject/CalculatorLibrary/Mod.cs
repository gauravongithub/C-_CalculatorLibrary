using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorLibrary
{
    public class Mod : Binary
    {
        override protected double Calculate(double[] listOfOperands)
        {
            double firstOperand = listOfOperands[0];
            double secondOperand = listOfOperands[1];

            return firstOperand%secondOperand;
        }
    }
}

