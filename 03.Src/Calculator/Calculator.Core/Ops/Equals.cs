using Calculator.Core.SDK;

namespace Calculator.Core.Ops
{
    public class Equals : IOps
    {
        /// <summary>
        /// 处理等于号
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public Expression Process(Expression exp)
        {
            try
            {
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
            }
            catch (CalcException e)
            {

                exp.EV = e.Message;
            }
            return exp;
        }
    }
}
