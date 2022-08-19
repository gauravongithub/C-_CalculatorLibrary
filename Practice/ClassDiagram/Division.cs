using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class Division : Binary
    {
        override public double Calculate(double[] listOfOperands)
        {

            if (listOfOperands.Length == 0 || listOfOperands.Length > 2 || listOfOperands[1] == 0)
            {
                throw new DivideByZeroException("You cannot divide a number by 0");
            }

            double firstOperand = listOfOperands[0];
            double secondOperand = listOfOperands[1];
            return firstOperand / secondOperand;
        }
    }
}