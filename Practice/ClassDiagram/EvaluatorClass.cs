using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorLibrary
{ 
    public class EvaluatorClass
    {
        Parser parserObject = new Parser();
        Dictionary<string, IOperation> operations = new Dictionary<string, IOperation>();
        List<OperatorPrecedence> operatorDetails = new List<OperatorPrecedence>();

        Stack<Token> operandStack = new Stack<Token>();
        public double Evaluate(string expression)
        {
            List<Token> tokenlist = parserObject.Postfix(expression);
            operatorDetails = parserObject.getOperatorDetails();
            object instance;

            foreach (Token token in tokenlist)
            {
                if(token.TokenType == Token.Type.Operand)
                {
                    operandStack.Push(token);
                }
                else if(token.TokenType == Token.Type.Operator)
                {
                    if (operations.ContainsKey(Convert.ToString(token)))
                    {

                    }
                    else
                    {
                        instance = Activator.CreateInstance(Type.GetType(operations[Convert.ToString(token.Value)].className));
                        operations[Convert.ToString(token.Value)] = (IOperation)instance;
                    }
                }
            }
            
            return 11.6;
        }

    }


}