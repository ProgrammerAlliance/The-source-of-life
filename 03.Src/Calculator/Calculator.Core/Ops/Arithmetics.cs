using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Core.SDK;
using Calculator.Core.Operation.Enum;

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
            //判断是否需要调用exp.DpCalc，赋值给R
            switch (_op)
            {
                case ArithmeticEnum.Add:
                    //1.直接点“+”

                    //2.数字->符号->“+”

                    //3.正常“+”

                    break;
                case ArithmeticEnum.Div:
                    break;
                case ArithmeticEnum.Mul:
                    break;
                case ArithmeticEnum.Sub:
                    break;
            }

            //1.第一次点 运算，不需要实例化新对象

            //2.连续点 运算，不需要实例化新对象

            //3.需要实例化新的
            var oldExp = exp;
            var newExp = new Expression
            {
                IsCreateNew = true,
                L = oldExp.ToString(),
                R = oldExp.DoCalc(),
                O = _op,
                Exp = oldExp,
            };
            exp = newExp;

            return exp;
        }


    }
}
