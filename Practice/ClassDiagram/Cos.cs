using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class Cos : Unary
    {
        public override double Calculate(double[] listOfOperand)
        {
            return Math.Cos(listOfOperand[0]);

            throw new System.NotImplementedException();
        }
    }
}