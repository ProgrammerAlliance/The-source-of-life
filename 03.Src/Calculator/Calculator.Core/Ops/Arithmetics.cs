using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Core.SDK;
using Calculator.Core.Enum;

namespace Calculator.Core.Ops
{
    public class Arithmetics : IOps
    {
        ArithmeticEnum _op;

        public Arithmetics(ArithmeticEnum op)
        {
            this._op = op;
        }

        public Expression Process(Expression exp)
        {
            exp.R = Convert.ToDouble(exp.R).ToString();
            //1.第一次点 运算，不需要实例化新对象
            if (exp.Opt == null)
            {
                exp.Opt = this._op;
                exp.L = exp.R;
                exp.EV = exp.R;
                return exp;
            }
            if(exp.IsOpt==TypeEnum.Equal)
            {
                exp.Opt = _op;
                exp.R = exp.L;
            }
            if(exp.IsOpt==TypeEnum.CommonSymbol)
            {
                exp.Opt = this._op;
                exp.EV = exp.R;
                return exp;
            }

            //2.连续点 运算，不需要实例化新对象
              
            //3.需要实例化新的
            if (exp.IsCreateNew)
            {
                var oldExp = exp;
                 exp = new Expression
                {
                    IsCreateNew = false,
                     LExp = oldExp,
                     R = oldExp.DoCalc(),
                    RExp = null,
                    Opt = this._op,
                };
                exp.L = exp.R;
            }
            exp.EV = exp.R;
            return exp;
        }


    }
}
