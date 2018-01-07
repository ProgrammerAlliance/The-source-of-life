using System;

namespace Calculator.Core
{
<<<<<<< HEAD
    public class Sqrt : Special_Operation
    {
<<<<<<< HEAD
        public override double GetResult()
=======
        public override void GetResult()
        {
            NumberA = Math.Sqrt(NumberA);
            StrFormula = $"sqrt({StrFormula})";
        }

        public override void GetString()
        {
            return StrFormula;
            //return "√("+NumberA+")";
=======
    public class Sqrt:ISpecialOperation
    {
        public double GeResult(double number)
>>>>>>> c91dbec4ac1806d5b5a6795e8a72deb349337b7c
        {
            double result = 0;
            result = Math.Sqrt(number);
            return result;
        }

        public string GetString(double number)
        {
            return "√(" + number + ")";
>>>>>>> 692bed95dc0dc21f4b7583cb344a275d72502576
        }
    }
}
