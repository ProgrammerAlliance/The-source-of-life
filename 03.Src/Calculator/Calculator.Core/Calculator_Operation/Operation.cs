namespace Calculator.Core
{
    public interface IOperation
    {
<<<<<<< HEAD
        public double _numberA = 0;
        public double _numberB = 0;

        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }


=======
        double GetResult(double number1, double number2);
>>>>>>> c91dbec4ac1806d5b5a6795e8a72deb349337b7c
    }
}
