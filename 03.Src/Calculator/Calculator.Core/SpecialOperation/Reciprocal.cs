using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class Reciprocal : ISpecialOperation
    {

        public override void GetResult()

        public double GeResult(double number)

        {
            double result = 0;
            if (number == 0)
            {
                throw new Exception("0没有倒数!");
            }
            else
            {
                result = 1 / number;
            }


            return result;

        }

        public string GetString(double number)
        {
            return "1/(" + number + ")";
        }
    }
}
