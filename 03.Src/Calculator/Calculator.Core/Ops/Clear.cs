using Calculator.Core.SDK;
using Calculator.Core.Enum;

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
                        IsOpt = TypeEnum.Equal,
                    };
                    break;
                case ClearEnum.CE:
                    //正常情况：
                    exp.R = "0";
                    exp.EV = exp.R;
                    //特殊运算+CE：
                    if (exp.IsOpt == TypeEnum.SpecialSymbol)
                    {
                            exp.RExp = null;
                            exp.R = "0";
                    }
                    if (exp.LExp == null && exp.RExp != null)
                    {
                        exp.RExp = null;
                    }
                    break;
                case ClearEnum.Del:
                    //输入等于号后删除键无效
                    if (exp.IsOpt == TypeEnum.Equal)
                    {
                        return exp;
                    }
                    //数字+Del
                    exp.R = exp.R.Length > 1 ? exp.R.Remove(exp.R.Length - 1) : "0";
                    exp.R = "-".Equals(exp.R) ? "0" : exp.R;
                    exp.EV = exp.R;
                    break;
            }


            return exp;
        }
    }
}
