using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Core.SDK;

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
                L = "",
                LExp = null,
                R = exp.R,
                RExp = null,
                SpOpt = _op,
            };
            
            return exp;
        }
    }
}
