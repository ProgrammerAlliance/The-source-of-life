using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public  class Operation
    {
        public double _numberA = 0;
        public double _numberB = 0;

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

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }

       
    }
}
