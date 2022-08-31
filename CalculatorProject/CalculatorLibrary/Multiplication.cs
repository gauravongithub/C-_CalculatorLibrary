using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorLibrary
{
    public class Multiplication : Binary
    {
        override protected double Calculate(double[] listOfOperands)
        {
 
            double firstOperand = listOfOperands[0];
            double secondOperand = listOfOperands[1];


            if (Double.IsInfinity(firstOperand * secondOperand)) throw new MemoryLimitExceeded("You have exceeded memory limit");


            return firstOperand*secondOperand;

        }
    }
}