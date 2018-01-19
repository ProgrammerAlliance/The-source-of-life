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
                //一开始就按一目运算，只有此时当前EXp符号为空
                if (exp.Opt == null)
                {
                    //一开始一目运算符为百分号，结果为0，不保留算式
                    if (_op == SpecialEnum.Percent)
                    {
                        exp.R = "0";
                        exp.EV = exp.R;
                        return exp;
                    }
                    exp.Opt = _op;
                    exp.EV = exp.DoCalc();
                    return exp;
                }
                //在输入数字或普通运算符后  按下特殊运算符  此时向右支延伸
                if (exp.IsOpt == TypeEnum.Number || exp.IsOpt == TypeEnum.CommonSymbol)
                {
                    exp.RExp = new Expression
                    {
                        L = exp.L,
                        Opt = _op,
                        R = exp.R,
                        IsOpt = TypeEnum.SpecialSymbol,
                    };
                    exp.EV = exp.R = exp.RExp.DoCalc();
                    exp.RExp.L = null;
                }
                //连续输入特殊运算
                else if (exp.IsOpt == TypeEnum.SpecialSymbol)
                {
                    //一开始就连续输入特殊符号
                    if (exp.Opt is SpecialEnum)
                    {
                        var old = exp;
                        exp = new Expression
                        {
                            Opt = _op,
                            RExp = old
                        };
                        exp.R = exp.RExp.DoCalc();
                        exp.EV = exp.DoCalc();
                    }
                    //在按过其他普通符号后连续输入特殊符号
                    else
                    {
                        var oldRExp = exp.RExp;
                        exp.RExp = new Expression
                        {
                            L = exp.L,
                            RExp = oldRExp,
                            Opt = _op,
                            R = exp.EV,
                            //R = oldRExp.DoCalc(),
                            IsOpt = TypeEnum.SpecialSymbol,
                        };
                        exp.EV = exp.R = exp.RExp.DoCalc();
                    }
                }
            }
            catch (CalcException e)
            {
                exp.EV = e.Message;
                exp.Locked = true;
            }
            return exp;
        }
    }
}
