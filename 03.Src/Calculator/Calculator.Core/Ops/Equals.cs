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
            var oldExp = exp;
            exp = new Expression
            {
                L = oldExp.DoCalc(),
                R = oldExp.R,
                LExp = null,
                RExp = null,
                Opt = oldExp.Opt,
                IsCreateNew = false,
            };
            exp.EV = exp.L;
            return exp;
        }
    }
}
