using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{

    public class Reciprocal : ISpecialOperation
    {
        public override object GetResult()        {
            double result = 0;
            if (number == 0)
            {
                throw new Exception("0没有倒数!");
            }
            else
            {
                result = 1 / number;
            }
<<<<<<< .mine
<<<<<<< HEAD
=======
=======


>>>>>>> .theirs
            return result;

        }

        public string GetString(double number)
        {
            return "1/(" + number + ")";
        }
    }
}
