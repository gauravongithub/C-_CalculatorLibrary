using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class Cosec : Unary
    {
        public override double Calculate(double[] listOfOperand)
        {
            return 1/Math.Sin(listOfOperand[0]);
            throw new System.NotImplementedException();
        }
    }
}