using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CalculatorLibrary
{
    public class Parser
    {
        List<OperatorPrecedence> operatorsList = new List<OperatorPrecedence>();
        Dictionary<string, OperatorPrecedence> operatorPrecedence = new Dictionary<string, OperatorPrecedence>();
        public List<Token> ConvertToTokens(string expression)
        {
            List<Token> listOfTokens = new List<Token>();
            for (int expressionIndex = 0; expressionIndex < expression.Length; expressionIndex++)
            {
                string token = String.Empty;
                //If the encountered character is a number, then collect it
                if (char.IsDigit(expression[expressionIndex]) || expression[expressionIndex] == '.')
                {
                    while (expressionIndex < expression.Length && (Char.IsDigit(expression[expressionIndex]) || expression[expressionIndex] == '.'))
                    {
                        token += expression[expressionIndex];
                        expressionIndex++;
                    }
                    expressionIndex--;
                    listOfTokens.Add(new Token { Value = Double.Parse(token), TokenType = Token.Type.Operand });
                    token = String.Empty;
                }
                else if (expression[expressionIndex] == '(')
                {
                    listOfTokens.Add(new Token { Value = '(', TokenType = Token.Type.Operator });
                }
                else if (expression[expressionIndex] == ')')
                {
                    listOfTokens.Add(new Token { Value = ')', TokenType = Token.Type.Operator });
                }
                else
                {
                    while (expressionIndex < expression.Length && expression[expressionIndex] != '.' && !char.IsDigit(expression[expressionIndex]))
                    {
                        token += expression[expressionIndex];

                        if (operatorPrecedence.ContainsKey(token.Trim()))
                        {
                            expressionIndex++;
                            break;
                        }
                        expressionIndex++;
                    }
                    expressionIndex--;
                    listOfTokens.Add(new Token { Value = token, TokenType = Token.Type.Operator });
                    token = String.Empty;
                }
            }
            return listOfTokens;
        }

        public List<Token> Postfix(string expression)
        {

            using (StreamReader s = new StreamReader("../../../PrecedenceFile.json"))
            {
                operatorsList = JsonSerializer.Deserialize<List<OperatorPrecedence>>(s.ReadToEnd());
            }

            foreach (OperatorPrecedence detailsOfOperators in operatorsList)
            {
                operatorPrecedence[detailsOfOperators.display] = detailsOfOperators;
            }

            List<Token> listOfTokens = ConvertToTokens(expression); 
            List<Token> postfixExpression = new List<Token>();
            Stack<Token> tokenStack = new Stack<Token>();


            foreach (Token token in listOfTokens)
            {
                if (token.TokenType == Token.Type.Operand)
                {
                    postfixExpression.Add(token);
                }
                else if ((string)token.Value == "(")
                {
                    tokenStack.Push(token);
                }
                else if ((string)token.Value == ")")
                {
                    while (tokenStack.Count > 0 && (string)tokenStack.Peek().Value != "(")
                    {
                        postfixExpression.Add(tokenStack.Pop());
                    }
                    if (tokenStack.Count > 0 && (string)tokenStack.Peek().Value != ")")
                    {
                        throw new Exception("Invalid expression");
                    }
                }
                else
                {

                    while (tokenStack.Count > 0 && operatorPrecedence[Convert.ToString(token.Value)].precedence <= operatorPrecedence[Convert.ToString(tokenStack.Peek().Value)].precedence)
                    {
                        postfixExpression.Add(tokenStack.Pop());
                    }
                    tokenStack.Push(token);
                }
            }
            while (tokenStack.Count > 0)
            {
                postfixExpression.Add(tokenStack.Pop());
            }
            return postfixExpression;
        }

        public Dictionary<string, OperatorPrecedence>  getOperatorDetails()
        {
            return operatorPrecedence;
        }
    }
}
