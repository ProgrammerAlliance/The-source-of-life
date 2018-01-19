using Calculator.Core.Operation.Enum;
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

        /// <summary>
        /// 处理C CE Del
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
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
                    exp.R = "0";
                    exp.EV = exp.R;
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
                    if (exp.IsOpt == TypeEnum.Equal)
                    {
                        return exp;
                    }
                    exp.R = exp.R.Length > 1 ? exp.R.Remove(exp.R.Length - 1) : "0";
                    exp.R = "-".Equals(exp.R) ? "0" : exp.R;
                    exp.EV = exp.R;
                    break;
            }
            return exp;
        }
    }
}
