using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class Square:ISpecialOperation
    {
<<<<<<< HEAD
        public override void GetResult()
        {
            double result = 0;
            result = NumberA* NumberA;
=======
        string result = "";

        public double GeResult(double number)
        {
            double result = 0;
            result = number * number;
            return result;
>>>>>>> 692bed95dc0dc21f4b7583cb344a275d72502576
        }

        public string GetString(double number)
        {
            result = "sqr(" + number + ")";
            return result;
        }
    }
}
