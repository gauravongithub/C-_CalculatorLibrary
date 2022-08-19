using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class Percentage : Binary
    {
        override public double Calculate(double[] listOfOperands)
        {

            double firstOperand = listOfOperands[0];
            double secondOperand = listOfOperands[1];

            if (listOfOperands.Length != 2)
            {
                throw new InvalidTypesOfOperands("Invalid Number of Arguments");
            }
            else if (Double.IsInfinity(firstOperand + secondOperand))
            {
                throw new MemoryLimitExceeded("Answer exceeds memory limit");
            }
            return firstOperand%secondOperand;
        }
    }
}