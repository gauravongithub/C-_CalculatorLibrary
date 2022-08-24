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


        public double Evaluate(double[] values)
        {
            //ResourceManager rm = new ResourceManager("CalculateLibrary.Resource1", Assembly.GetExecutingAssembly());
            if (values == null) throw new ArgumentNullException();
            if (NumberOfOperands != values.Length)
              //  throw new InvalidNumberOfOperands(string.Format(rm.GetString("InvalidNumberOfOperands")));
            throw new InvalidNumberOfOperands("Invalid Number of Operands");

            return Calculate(values);
        }



        protected abstract double Calculate(double[] listOfOperands);
    }
}