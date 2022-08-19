using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public abstract class Binary : IOperation
    {
        public int NumberOfOperands
        {
            get;set;
        }

       public Binary()
        {
            NumberOfOperands = 2;
        }

        abstract public double Calculate(double[] listOfOperands);
    }
}