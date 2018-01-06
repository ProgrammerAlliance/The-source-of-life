namespace Calculator.Core
{
    public  class Operation
    {
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

        public virtual object GetResult()
        {
            double result = 0;
            return result;
        }


    }
}
