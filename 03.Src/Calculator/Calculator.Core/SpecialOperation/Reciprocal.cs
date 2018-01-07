namespace Calculator.Core
{
    public class Reciprocal : ISpecialOperation
    {
<<<<<<< HEAD
        public override void GetResult()
=======
        public double GeResult(double number)
>>>>>>> 692bed95dc0dc21f4b7583cb344a275d72502576
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
<<<<<<< HEAD
=======
            return result;
>>>>>>> 692bed95dc0dc21f4b7583cb344a275d72502576
        }

        public string GetString(double number)
        {
            return "1/(" + number + ")";
        }
    }
}
