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
        public Expression Process(Expression exp)
        {
            exp.L = exp.DoCalc();
            //if (temp == null)
            //{
            //    temp = exp.R;
            //}
            //else
            //{
            //    exp.L = exp.R;
            //    exp.R = temp;
            //}
            //exp.R = exp.DoCalc();
            exp.EV = exp.L;
            return exp;
        }
    }
}
