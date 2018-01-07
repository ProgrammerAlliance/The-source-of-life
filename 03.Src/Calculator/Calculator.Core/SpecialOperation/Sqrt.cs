using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class Sqrt : Special_Operation
    {
        public override void GetResult()
        {
            NumberA = Math.Sqrt(NumberA);
            StrFormula = $"sqrt({StrFormula})";
        }

        //public override void GetString()
        //{
        //    return StrFormula;
        //    //return "√("+NumberA+")";
        //}
    }
}
