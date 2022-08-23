using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class Multiplication : Binary
    {
        override public double Calculate(double[] listOfOperands)
        {
                double firstOperand = listOfOperands[0];
                double secondOperand = listOfOperands[1];


            return firstOperand*secondOperand;

        }
    }
}