﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    /// <summary>
    /// todo: wr
    /// </summary>
    public class Sqrt:ISpecialOperation
    {
        public double GetResult(double number)
        {
            double result = 0;
            result = Math.Sqrt(number);
            return result;
        }

        public string GetString(double number)
        {
            return "√(" + number + ")";
        }
    }
}