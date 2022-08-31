using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Resources;
namespace CalculatorLibrary
{
    public class EvaluatorClass
    {
        Parser parserObject = new Parser();
        Dictionary<string, IOperation> operations = new Dictionary<string, IOperation>();
        Dictionary<string, OperatorPrecedence> operatorDetails = new Dictionary<string, OperatorPrecedence>();
        public ResourceManager rm = new ResourceManager("CalculatorLibrary.CalculatorResource", Assembly.GetExecutingAssembly());

        Stack<double> operandStack = new Stack<double>();
        public double Evaluate(string expression)
        {

            if (String.IsNullOrEmpty(expression)) { throw new InvalidNumberOfOperands((rm.GetString("ArgumentNullException"))); }
            List<Token> tokenlist = parserObject.Postfix(expression);
            operatorDetails = parserObject.getOperatorDetails();
            object instance;

            foreach (Token token in tokenlist)
            {
                if (token.TokenType == Token.Type.Operand)
                {
                    operandStack.Push((double)token.Value);
                }
                else if (token.TokenType == Token.Type.Operator)
                {
                    if (operations.ContainsKey(Convert.ToString(token)))
                    {

                    }
                    else
                    {
                        instance = Activator.CreateInstance(Type.GetType(operatorDetails[(string)token.Value].className));
                        operations[Convert.ToString(token.Value)] = (IOperation)instance;
                    }


                    int operandCount = operations[Convert.ToString(token.Value)].NumberOfOperands;
                    double[] listOfOperands = new double[operandCount];

                    for (int operandIndex = 0; operandIndex < operandCount; operandIndex++)
                    {
                        listOfOperands[operandIndex] = operandStack.Pop();
                    }

                    Array.Reverse(listOfOperands);

                    double temporaryResult = operations[Convert.ToString(token.Value)].Evaluate(listOfOperands);
                    operandStack.Push(temporaryResult);
                }
            }
            return operandStack.Pop();
        }
    }
}