using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class Token
    {
        public enum Type
        {
            Operator,
            Operand
        };

        public object Value { get; set;}
        public Type TokenType { get; set;}

    }
}