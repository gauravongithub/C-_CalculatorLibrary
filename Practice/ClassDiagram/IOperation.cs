using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public interface IOperation
    {
         int NumberOfOperands{get;}
        double Evaluate(double[] listOfOperands);
    }
}