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
                if (exp.Opt == null)//
                {
                    exp.Opt = _op;
                    exp.EV = exp.DoCalc();
                }
                else
                {
                    if (exp.IsOpt == TypeEnum.Number || exp.IsOpt == TypeEnum.CommonSymbol)
                    {
                        exp.RExp = new Expression
                        {
                            Opt = _op,
                            R = exp.R,
                            IsOpt = TypeEnum.SpecialSymbol,
                        };
                        exp.EV = exp.R = exp.RExp.DoCalc();
                    }
                    else if (exp.IsOpt == TypeEnum.SpecialSymbol)
                    {
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
                        else
                        {
                            var oldRExp = exp.RExp;
                            exp.RExp = new Expression
                            {
                                RExp = oldRExp,
                                Opt = _op,
                                R = oldRExp.DoCalc(),
                                IsOpt=TypeEnum.SpecialSymbol,
                            };
                            exp.EV = exp.R = exp.RExp.DoCalc();
                        }
                    }
                }
                // var sss = exp.RExp == null ? $"sqrt({exp.R}" : $"{exp.RExp.ToString()}sqrt({exp.R}))";
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
