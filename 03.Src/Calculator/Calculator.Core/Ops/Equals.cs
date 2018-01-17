using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Core.SDK;

namespace Calculator.Core.Ops
{
    public class Equals : IOps
    {
        string temp = null;

        public Expression Process(Expression exp)
        {
            if (temp == null)
            {
                temp = exp.R;
            }
            else
            {
                exp.L = temp;
            }
            exp.R = exp.DoCalc();
            
            return exp;
        }
    }
}
