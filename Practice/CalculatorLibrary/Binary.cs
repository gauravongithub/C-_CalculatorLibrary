using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Reflection;

namespace CalculatorLibrary
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

         public ResourceManager rm = new ResourceManager("CalculatorLibrary.CalculatorResource", Assembly.GetExecutingAssembly());
        public double Evaluate(double[] values)
        {
            if (values == null) throw new ArgumentNullException();
            if (NumberOfOperands != values.Length)
               throw new InvalidNumberOfOperands(string.Format(rm.GetString("InvalidNumberOfOperands")));

            return Calculate(values);
        }
        protected abstract double Calculate(double[] listOfOperands);
    }
}