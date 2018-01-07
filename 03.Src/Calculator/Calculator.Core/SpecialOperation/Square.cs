using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class Square:Special_Operation
    {
        public override void GetResult()
        {
            double result = 0;
            result = NumberA* NumberA;
        }

        //public override string GetString()
        //{
        //    result = "sqr(" + NumberA + ")";
        //    return result ;
        //}

        
    }
}
