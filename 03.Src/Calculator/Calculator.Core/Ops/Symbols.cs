using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Core.SDK;
using Calculator.Core.Enum;

namespace Calculator.Core.Ops
{
    public class Symbols : IOps
    {
        SymbolEnum _symbol;

        public Symbols(SymbolEnum symbol)
        {
            this._symbol = symbol;
        }

        public Expression Process(Expression exp)
        {
            
            switch (_symbol)
            {
                case SymbolEnum.Point:
                    if (exp.R == ""||exp.IsOpt!=TypeEnum.Number)
                    {
                        exp.R = "0.";
                    }
                    exp.R = exp.R.Contains(".") ? exp.R : $"{exp.R}.";
                    exp.EV = exp.R;
                    exp.IsOpt = TypeEnum.Number;
                    exp.IsCreateNew = true;
                    break;
                case SymbolEnum.Sign:
                    //1.直接点“±”
                    if ("0".Equals(exp.R))
                    {
                        return exp;
                    }

                    //2.数字->运算->“±”
                    
                    //3.正常点“±”
                    exp.R = exp.R.StartsWith("-") ? exp.R.Remove(0, 1) : $"-{exp.R}";
                    exp.EV = exp.R;
                    break;
            }

            return exp;
        }
    }
}
