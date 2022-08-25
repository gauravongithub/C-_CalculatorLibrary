using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources; //for using ResourceManager
using System.Reflection; // for using Assembly

namespace CalculatorLibrary
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
        public ResourceManager rm = new ResourceManager("CalculateLibrary.Resource1", Assembly.GetExecutingAssembly());
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