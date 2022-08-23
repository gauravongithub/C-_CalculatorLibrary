using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;


namespace ClassDiagram
{
        public class Parser
    {
        public List<Token> ConvertToTokens(string expression)
        {
            List<Token> listOfTokens = new List<Token>();
            for (int expressionIndex = 0; expressionIndex < expression.Length; expressionIndex++)
            {
                string token = " ";
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
                    while (!Char.IsDigit(expression[expressionIndex + 1]) || !expression[expressionIndex + 1] == '.')
                    {      //checking if operator is present
                        token += expression[expressionIndex];
                        expressionIndex++;
                    }
                    expressionIndex--;
                    listOfTokens.Add(new Token { Value = token, TokenType = Token.Type.Operator });
                    token = "";
                }
            }
            return listOfTokens;
        }

        public static Dictionary<string, OperatorPrecedence> getPrecedenceTable()
        {
            Dictionary<string, OperatorPrecedence> precedenceTable = new Dictionary<string, OperatorPrecedence>();
            using (StreamReader s = new StreamReader("jsconfig1.json")) // To read json file
            {
                precedenceTable = JsonSerializer.Deserialize<Dictionary<string, OperatorPrecedence>>(s.ReadToEnd());
            }
            return precedenceTable;
        }
        public List<Token> Postfix(string expression, Dictionary<string, OperatorPrecedence> precedenceTable)
        {
            List<Token> listOfTokens = ConvertToTokens(expression);
            Dictionary<string, OperatorPrecedence> operatorPrecedence = new Dictionary<string, OperatorPrecedence>();
            List<Token> postfixExpression = new List<Token>();
            Stack<Token> tokenStack = new Stack<Token>();
            foreach (Token token in listOfTokens)
            {
                if (token.TokenType == Token.Type.Operand)
                {
                    postfixExpression.Add(token);
                }
                else if((string)token.Value == "(")
                {
                    tokenStack.Push(token);
                }else if((string)token.Value == ")")
                {
                    while(tokenStack.Count>0 && (string)tokenStack.Peek().Value != "(")
                    {
                        postfixExpression.Add(tokenStack.Pop());
                    }
               
                }
                else
                {
                    //Agar mere waale operator ka precedence jyaada hai stack ke top pe pade operator se then push.
                    if(operatorPrecedence[Convert.ToString(token.Value)].precedence <= operatorPrecedence[Convert.ToString(tokenStack.Peek())].precedence)
                    {
                        tokenStack.Push(token);
                    }
                    else
                    {
                        //else pop till my precedence becomes less than current operator
                        while(operatorPrecedence[Convert.ToString(token.Value)].precedence > operatorPrecedence[Convert.ToString(tokenStack.Peek())].precedence)
                        {
                            postfixExpression.Add(tokenStack.Pop());
                        }
                        tokenStack.Push(token);
                    }
                } 

            }
            while(tokenStack.Count>=0)
            {
                postfixExpression.Add(tokenStack.Pop());
            }
            return postfixExpression;
        }
    }


}