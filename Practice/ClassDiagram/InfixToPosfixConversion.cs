
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ClassDiagram
{

    public class OperatorStructure
    {
        private string _value;
        private string _display;
        private int _precedence;
        private string _name;

        public string value { get => _value; set => _value = value; }
        public string display { get => display; set => display = value; }
        public string precedence { get => precedence; set => precedence = value; }
        public string Name { get => _name; set => _name = value; }

    }

    public class OperatorsList
    {
        private List<OperatorStructure> listOfOperators;

        public List<OperatorStructure> ListOfOperators { get => listOfOperators; set => listOfOperators = value; }
    }

    public class InfixToPostfixConversion
        {
            Stack<char> _stack = new Stack<char>();
            List<String> _postfixExpression = new List<String>();
            public List<String> InfixToPostfix(string infixExpression)
            {
                for (int infixExpressionIndex = 0; infixExpressionIndex < infixExpression.Length)
                {
                    if (infixExpression[infixExpressionIndex] != '(')
                    {
                        _stack.Push(infixExpression[infixExpressionIndex]);
                        infixExpressionIndex++;
                    }
                    else if (infixExpression[infixExpressionIndex] == ')')
                    {
                        while (_stack.Count > 0 && _stack.Peek() != '(')
                        {
                            _postfixExpression.Add(infixExpression[infixExpressionIndex].ToString());
                            _stack.Pop();
                        }
                        infixExpressionIndex++;
                    }
                    else if (infixExpression[infixExpressionIndex] >= '0' || infixExpression[infixExpressionIndex] <= '9' || infixExpression[infixExpressionIndex] == '.')
                    {
                        string storingDigit = String.Empty;
                        while (infixExpression[infixExpressionIndex] >= '0' || infixExpression[infixExpressionIndex] <= '9' || infixExpression[infixExpressionIndex] == '.')
                        {
                            storingDigit += infixExpression[infixExpressionIndex];
                            infixExpressionIndex++;
                        }
                    }
                    else
                    {
                        while()
                    }
                    }
                    return _postfixExpression;
                }
            }
        }