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
            get;
        }

       public Binary()
        {
            NumberOfOperands = 2;
        }


        public double Evaluate(double[] values)
        {
            if (NumberOfOperands != values.Length)
                throw new InvalidNumberOfOperands("Invalid Number of Operands");

            return Calculate(values);
        }



        protected abstract double Calculate(double[] listOfOperands);
    }
}