using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class Parser : EvaluatorClass
    {
        public Dictionary<string, checkPrecedence> checkOperators = new Dictionary<string, checkPrecedence>();

        public List<Token> tokens = new List<Token>();

        public List<Token> ConvertIntoTokens(string expression)
        {
            for (int expressionIndex = 0; expressionIndex < expression.Length; expressionIndex++)
            {
                string token = String.Empty;
                if (Char.IsNumber(expression[expressionIndex]) || expression[expressionIndex] == '.')
                {
                    while (Char.IsNumber(expression[expressionIndex]) || expression[expressionIndex] == '.')
                    {
                        token += expression[expressionIndex];
                        expressionIndex++;
                    }
                    expressionIndex--;
                    tokens.Add(new Token { values = Double.Parse(token), tokenType = Token.Type.Operand })
                    token = String.Empty;

                }
                else if (expression[expressionIndex] == '(')
                 {
                    tokens.Add(new Token { values = "(", tokenType = Token.Type.Operator });
                  }
            else if(expression[expressionIndex] == ')')
            {
                    tokens.Add(new Token { values = "(", tokenType = Token.Type.Operator });
            }
                else
                {

                }
        }
    }
}


}