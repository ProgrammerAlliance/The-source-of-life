using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Core.SDK;

namespace Calculator.Core.Ops
{
    public class Clear : IOps
    {
        ClearEnum _op;

        public Clear(ClearEnum op)
        {
            this._op = op;
        }

        public Expression Process(Expression exp)
        {
            switch (_op)
            {
                case ClearEnum.C:
                    exp = new Expression()
                    {
                        L = "",
                        R = "0",
                        EV = "0",
                        LExp = null,
                        RExp = null,
                        Opt = null,
                        IsCreateNew = false,
                    };
                    break;
                case ClearEnum.CE:
                    //正常情况：
                    exp.R = "0";
                    exp.EV = exp.R;
                    //特殊运算+CE：

                    if ("".Equals(exp.L))
                    {
                        exp.Opt = null;
                    }

                    break;

                case ClearEnum.Del:
                    //数字+Del
                    exp.R = exp.R.Length > 1 ? exp.R.Remove(exp.R.Length - 1) : "0";
                    exp.EV = exp.R;
                    //运算+Del
                    //无响应
                    break;
            }


            return exp;
        }
    }
}
