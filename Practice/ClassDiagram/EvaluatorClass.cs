using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{ 
    public class EvaluatorClass
    {
        Parser parserObject =new Parser();
        //Dictionary<string, OperatorPrecedence> operatorAndItsFunctionality = new Dictionary<string, OperatorPrecedence>();
        List<OperatorPrecedence> operatorAndItsFunctionality = new List<OperatorPrecedence>();
        public double Evaluate(string expression)
        {
            List<Token> tokenlist = parserObject.Postfix(expression);

            Console.ReadLine();

            return 5.675;
        }

    }


}