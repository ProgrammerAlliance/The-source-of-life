using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Core.SDK;

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
            if (exp.Opt != null)
            {
                Calc.IsCreateNew = true;
            }

            if (exp.IsInputOpt)
            {
                exp.R = _num.ToString();
                exp.IsInputOpt = false;
                return exp;
            }

            //判断是否已经满16个数字
            if (exp.R.Replace(".", "").Replace("-", "").Length == 16)
            {
                return exp;
            }

            //数字追加
            exp.R = string.IsNullOrWhiteSpace(exp.R) ? _num.ToString() : exp.R + _num;
            return exp;
        }
    }
}
