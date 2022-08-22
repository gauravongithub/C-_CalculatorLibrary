using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{ 
    
    public class EvaluatorClass : Binary
    {
        public string[] ParseString(string result)
        {
            
            throw new System.NotImplementedException();
        }

        public double FindAndInsertOperatorFunctionality(double operand1, double operand2, string parsedOperator)
        {

            Dictionary<string, int> d = new Dictionary<string, int>();
            throw new System.NotImplementedException();
        }

        public override double Calculate(double[] listOfOperands)
        {
            throw new NotImplementedException();
        }
    }
}