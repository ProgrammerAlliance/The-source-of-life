using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Core.SDK;
using Calculator.Core.Operation.Enum;

namespace Calculator.Core.Ops
{
    public class OneOperations : IOps
    {
        SpecialEnum _op;

        public OneOperations(SpecialEnum op)
        {
            this._op = op;
        }
        public Expression Process(Expression exp)
        {
            exp.RExp = new Expression
            {
                L = exp.L,
                R = exp.R,
                Opt = this._op,
            };
            exp.R = exp.RExp.DoCalc();
            exp.RExp.L = null;
            exp.EV = exp.R;
            return exp;
        }
    }
}
