using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{

    
    public class EvaluatorClass : Binary
    {

         internal static int Prec(char ch)
            {
                switch (ch)
                {
                    case '+':
                    case '-':
                        return 1;

                    case '*':
                    case '/':
                        return 2;

                    case '^':
                        return 3;
                }
                return -1;
            }

        // The main method that converts given infix expression
        // to postfix expression. 
        static string result = string.Empty; // Result will store the postfix expression after conversion

        public static void infixToPostfix(string exp)
            {

                // initializing empty stack
                Stack<char> stack = new Stack<char>();

                for (int i = 0; i < exp.Length; ++i)
                {
                    char c = exp[i];

                    // If the scanned character is an
                    // operand, add it to output.
                    if (char.IsLetterOrDigit(c))
                    {
                        result += c;
                    }

                    // If the scanned character is an '(',
                    // push it to the stack.
                    else if (c == '(')
                    {
                        stack.Push(c);
                    }

                    //  If the scanned character is an ')',
                    // pop and output from the stack 
                    // until an '(' is encountered.
                    else if (c == ')')
                    {
                        while (stack.Count > 0 &&
                                stack.Peek() != '(')
                        {
                            result += stack.Pop();
                        }

                        if (stack.Count > 0 && stack.Peek() != '(')
                        {
                            return ; // invalid expression
                        }
                        else
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {
                        while (stack.Count > 0 && Prec(c) <=
                                          Prec(stack.Peek()))
                        {
                            result += stack.Pop();
                        }
                        stack.Push(c);
                    }

                }

                // pop all the operators from the stack
                while (stack.Count > 0)
                {
                    result += stack.Pop();
                }
            }

        public string[] ParseString(string result)
        {
            Stack<String> operatorStack = new Stack<String>();
            Stack<char> operandStack = new Stack<char>();
            throw new System.NotImplementedException();
        }

        public double FindAndInsertOperatorFunctionality(double operand1, double operand2, string parsedOperator)
        {

            Dictionary<string, int> d = new Dictionary<string, int>();
            throw new System.NotImplementedException();
        }

        public override double Calculate(double[] listOfOperands)
        {
            throw new NotImplementedException();
        }
    }
}