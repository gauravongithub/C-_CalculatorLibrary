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
            try
            {
                if (listOfOperands.Length == 0 || listOfOperands.Length > 2)
                {
                    throw e;//new InvalidOperationException("Invalid operation");
                }

                double firstOperand = listOfOperands[0];
                double secondOperand = listOfOperands[1];
                return firstOperand - secondOperand;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return 0;

        }
    }
}