using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class PowerFunction : Binary
    {
        override public double Calculate(double[] listOfOperands)
        {
            double firstOperand = listOfOperands[0];
            double secondOperand = listOfOperands[1];
 
            if(firstOperand<0 && Math.Ceiling(secondOperand) != secondOperand)
            {
                throw new InvalidTypesOfOperands("You are providing invalid types of arguments");
            }

            return Math.Pow(firstOperand, secondOperand);

        }
    }
}