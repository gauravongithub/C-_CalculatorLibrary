﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagram
{
    public class Tan : Unary
    {
        override public double Calculate(double[] listOfOperands)
        {
            Math.Tan(listOfOperands[0]);
            throw new System.NotImplementedException();
        }
    }
}