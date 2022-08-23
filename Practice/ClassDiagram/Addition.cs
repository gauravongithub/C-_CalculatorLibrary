using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class Addition : Binary
    {
        override public double Calculate(double[] listOfOperands)
        {

            double firstOperand = listOfOperands[0];
            double secondOperand = listOfOperands[1];

            if(Double.IsInfinity(firstOperand + secondOperand))
            {
                throw new MemoryLimitExceeded("Answer exceeds memory limit");
            }
            return firstOperand + secondOperand;
        }

    }
}