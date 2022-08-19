using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class Sin : Unary
    {
        override public double Calculate(double[] listOfOperands)
        {
            return Math.Sin(listOfOperands[0]);
            throw new System.NotImplementedException();
        }
    }
}