using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class Subtraction : Binary
    {
        override public double Calculate(double[] listOfOperands)
        {
            double firstOperand = listOfOperands[0];
            double secondOperand = listOfOperands[1];
            if (listOfOperands.Length == 0 || listOfOperands.Length > 2)
            {
                throw new InvalidNumberOfOperands("For every such case I will write only one Error message and that is in the InvalidNumberOfOperands only");
            }

            return firstOperand - secondOperand;
        }

    }
}