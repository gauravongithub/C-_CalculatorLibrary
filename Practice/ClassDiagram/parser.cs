using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace ClassDiagram
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
                    while ((Char.IsDigit(expression[expressionIndex + 1]) || expression[expressionIndex + 1] == '.'))
                    {
                        token += expression[expressionIndex];
                        expressionIndex++;
                    }
                    expressionIndex--;
                    listOfTokens.Add(new Token { Value = Double.Parse(token), TokenType = Token.Type.Operand });
                    token = "";
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
                    while (!Char.IsDigit(expression[expressionIndex + 1]) || (expression[expressionIndex + 1]) != '.')
                    {
                        token += expression[expressionIndex];
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
            List<Token> listOfTokens = ConvertToTokens(expression); // This will contain the list Of token after conversion into Tokens
            List<Token> postfixExpression = new List<Token>();
            Stack<Token> tokenStack = new Stack<Token>();


            using (StreamReader s = new StreamReader("PrecedenceFileJSON.json"))
            {
                operatorsList = JsonSerializer.Deserialize<List<OperatorPrecedence>>(s.ReadToEnd());
            }

            foreach (OperatorPrecedence operatorDetails in operatorsList)
            {
                operatorPrecedence[operatorDetails.display] = operatorDetails;
            }


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
                }
                else


                   //Agar mere waale operator ka precedence jyaada hai stack ke top pe pade operator se then push.
                   if (operatorPrecedence[Convert.ToString(token.Value)].precedence <= operatorPrecedence[Convert.ToString(tokenStack.Peek())].precedence)
                {
                    tokenStack.Push(token);
                }
                else
                {
                    //else pop till my precedence becomes less than current operator
                    while (operatorPrecedence[Convert.ToString(token.Value)].precedence > operatorPrecedence[Convert.ToString(tokenStack.Peek())].precedence)
                    {
                        postfixExpression.Add(tokenStack.Pop());
                    }
                    tokenStack.Push(token);
                }
            }

            while (tokenStack.Count >= 0)
            {
                postfixExpression.Add(tokenStack.Pop());
            }
            return postfixExpression;
        }

    }
}
