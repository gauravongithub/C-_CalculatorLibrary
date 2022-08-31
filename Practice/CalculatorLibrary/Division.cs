using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Reflection;


namespace CalculatorLibrary
{
    public class Division : Binary
    {
        //public ResourceManager rm = new ResourceManager("CalculatorLibrary.CalculatorResource", Assembly.GetExecutingAssembly());
        override protected double Calculate(double[] listOfOperands)
        {
            if (listOfOperands == null) throw new ArgumentNullException();
            if (listOfOperands[1] == 0)
            {
                throw new DivideByZeroException("You cannot divide a number by 0");
                //throw new DivideByZero((rm.GetString("DivideByZero")));
                //throw new DivideByZeroException(rm.GetString("DivideByZero"));
            }

            double firstOperand = listOfOperands[0];
            double secondOperand = listOfOperands[1];
            return firstOperand / secondOperand;
        }
    }
}