using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorLibrary;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string express = "1+2+3";
            EvaluatorClass evaluatorClass = new EvaluatorClass();
            double tempAns = evaluatorClass.Evaluate(express);
            Console.WriteLine(tempAns);
            Assert.AreEqual(tempAns, tempAns);
        }
    }
}
