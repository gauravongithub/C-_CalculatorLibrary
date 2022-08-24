using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string express = "5+6";
            EvaluatorClass evaluatorClass = new EvaluatorClass();
            evaluatorClass.Evaluate(express);
        }
    }
}
