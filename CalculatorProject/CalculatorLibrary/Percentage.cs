using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorLibrary
{
    public class Percentage : Binary
    {
        override protected double Calculate(double[] listOfOperands)
        {
            if (listOfOperands == null) throw new ArgumentNullException();
            double firstOperand = listOfOperands[0];
            double secondOperand = listOfOperands[1];

            if (Double.IsInfinity(firstOperand + secondOperand))
            {
                throw new MemoryLimitExceeded("Answer exceeds memory limit");
            }
            return firstOperand%secondOperand;
        }
    }
}