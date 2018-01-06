﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public  class Operation
    {
        private double _numberA = 0;
        private double _numberB = 0;
        //private double _result = 0;
       // private string _symbol = null;
        
        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        public virtual object GetResult()
        {
            double result = 0;
            return result;
        }
        

    }
}
