using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class Sec : Unary
    {
        protected override double Calculate(double[] listOfOperand)
        {
            return 1/Math.Cos(listOfOperand[0]);
            throw new System.NotImplementedException();
        }
    }
}