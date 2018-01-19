using Calculator.Core.Enum;
using Calculator.Core.SDK;

namespace Calculator.Core.Ops
{
    public class Equals : IOps
    {
        public Expression Process(Expression exp)
        {
            exp.IsOpt = TypeEnum.Equal;
            var oldExp = exp; 
            exp = new Expression
            {
                L = oldExp.DoCalc(),
                R = oldExp.R,
                LExp = null,
                RExp = null,
                Opt = oldExp.Opt,
                IsCreateNew = false,
            };
            exp.EV = exp.L;
            return exp;
        }
    }
}
