using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Core.SDK;
using Calculator.Core.Enum;

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
            try
            {
                if (exp.Opt == null)
                {
                    exp.Opt = _op;
                    exp.L = "0";
                    var old = exp;
                    exp = new Expression
                    {
                        LExp = old
                    };
                    exp.R = old.DoCalc();
                    exp.LExp.L = null; 
                }
                else
                {
                    var oldRExp = exp.RExp;
                    exp.RExp = new Expression
                    {
                        L = exp.L.Length == 0 ? "0" : exp.L,
                        R = exp.R,
                        Opt = this._op,
                        RExp = oldRExp
                    };
                    exp.R = exp.RExp.DoCalc();
                    exp.RExp.L = null;
                }
            }
            catch (CalcException e)
            {
                exp.EV = e.Message;
            }
            exp.EV = exp.R;
            return exp;
        }
    }
}
