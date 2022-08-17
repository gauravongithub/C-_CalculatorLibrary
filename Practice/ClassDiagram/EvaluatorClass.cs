using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{

    
    public class EvaluatorClass : Binary
    {

        public double Evaluate(string expression)
        {
            throw new System.NotImplementedException();
        }

        public string[] ParseString(string expression)
        {
            throw new System.NotImplementedException();
        }

        public double FindAndInsertOperatorFunctionality(double operand1, double operand2, string parsedOperator)
        {

            Dictionary<string, int> d = new Dictionary<string, int>();
            throw new System.NotImplementedException();
            //Data type of value in map will change from int to the object of binary operations like addition, subtraction.etc;

            //This function will contain a map in which key will be the operator and value will be the functionality of that particular operator;
            //If we find the operator then we will bind the operator with its functionality and if not found then we will simply insert that operator as key and
            // its functionality as the value
        }
    }
}