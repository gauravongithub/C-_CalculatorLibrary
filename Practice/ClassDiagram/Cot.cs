using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class Cot : Unary
    {
        protected override double Calculate(double[] listOfOperands)
        {
            return 1/Math.Tan(listOfOperands[0]);
            throw new System.NotImplementedException();
        }
    }
}