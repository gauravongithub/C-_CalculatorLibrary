using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{ 
    public class EvaluatorClass
    {
       public Dictionary<string,IOperation> dictionary = new Dictionary<string,IOperation>();
        Parser parser = new Parser();

        public double Evaluate(string expression)
        {
            List<Token> Token = parser.Postfix(expression); 
        }

    }
}