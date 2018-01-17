using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Core.SDK;
using Calculator.Core;

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
            //1.第一次点 运算，不需要实例化新对象
            //2.连续点 运算，不需要实例化新对象
            exp.L = exp.R;
            exp.Opt = _op;
            
            //3.需要实例化新的
            if (Calc.IsCreateNew)
            {
                var oldExp = exp;
                var newExp = new Expression
                {
                    L = oldExp.DoCalc(),
                    LExp = oldExp,
                    R = oldExp.DoCalc(),
                    RExp = null,
                    Opt = _op,
                };
            }
            
            exp.IsInputOpt = true;
            return exp;
        }


    }
}
