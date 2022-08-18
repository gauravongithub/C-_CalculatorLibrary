using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public abstract class Unary : IOperation
    {
        public double NumberOfOperands
        {
            get { return NumberOfOperands; }
            set { NumberOfOperands = 1; }
        }
        abstract public double Calculate(double[] NumberOfOperands);

    }
}