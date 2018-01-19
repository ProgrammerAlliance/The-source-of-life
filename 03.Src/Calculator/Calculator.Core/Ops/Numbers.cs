using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Core.SDK;
using Calculator.Core.Enum;

namespace Calculator.Core.Ops
{
    public class Numbers : IOps
    {
        int _num;

        public Numbers(int num)
        {
            this._num = num;
        }

        public Expression Process(Expression exp)
        {
            if (exp.IsOpt == TypeEnum.Equal)
            {
                exp = new Expression
                {
                    R = "0",
                };
            }

            if (exp.IsOpt == TypeEnum.CommonSymbol)
            {
                exp.R = "0";
            }

            if (exp.IsOpt == TypeEnum.SpecialSymbol)
            {
                exp.RExp = null;
                exp.R = "0";
                exp.Opt = null;
            }

            //判断是否已经满16个数字
            if (exp.R.Replace(".", "").Replace("-", "").Length == 16)
            {
                return exp;
            }

            //数字追加
            exp.R = (string.IsNullOrWhiteSpace(exp.R) || "0".Equals(exp.R)) ? (Convert.ToDouble(_num)).ToString() : exp.R + _num;
            exp.EV = exp.R;
            return exp;
        }
    }
}
