﻿using Calculator.Core.Opt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class OperationMul:Operation
    {
        public override object GetResult()
        {  
                double result = 0;
                result = NumberA * NumberB;
                return result;    
        }
    }
}
