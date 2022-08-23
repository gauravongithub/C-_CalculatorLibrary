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
            get;
        }

       public Unary()
        {
            NumberOfOperands = 1;
        }

        public double Evaluate(double[] values)
        {
            if (values == null) throw new ArgumentNullException();
            if (NumberOfOperands != values.Length)
                throw new InvalidNumberOfOperands("Invalid Number of Operands");

            return Calculate(values);
        }

        protected abstract double Calculate(double[] listOfOperands);
    }
}