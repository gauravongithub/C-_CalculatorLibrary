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

        public object values { get; set;}
        public Type tokenType { get; set;}

    }
}