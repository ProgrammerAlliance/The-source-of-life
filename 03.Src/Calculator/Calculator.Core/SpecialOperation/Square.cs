namespace Calculator.Core
{
    public class Square:ISpecialOperation
    {
<<<<<<< HEAD
        string result = "";
        public override double GetResult()
=======
<<<<<<< HEAD
        public override void GetResult()
>>>>>>> c91dbec4ac1806d5b5a6795e8a72deb349337b7c
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
