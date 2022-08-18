﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public interface IOperation
    {
         double NumberOfOperands
        {
            get; 
        }
        double Calculate(double[] listOfOperands);
    }
}