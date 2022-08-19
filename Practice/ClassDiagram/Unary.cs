using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public abstract class Unary : IOperation
    {
        public int NumberOfOperands
        {
            get;set;
        }
        public Unary()
        {
            NumberOfOperands = 1;
        }

        
        abstract public double Calculate(double[] NumberOfOperands);

    }
}