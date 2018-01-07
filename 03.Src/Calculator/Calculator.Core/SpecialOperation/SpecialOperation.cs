namespace Calculator.Core
{
    public interface ISpecialOperation
    {
        /// <summary>
        /// 开方
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private double _numberA = 0;
        private string _strFormula = "";

        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }
        public string StrFormula
        {
            get { return _strFormula; }
            set { _strFormula = value; }
        }
       

<<<<<<< HEAD
        public virtual double  GetResult()
=======
        public virtual void GetResult()
>>>>>>> c91dbec4ac1806d5b5a6795e8a72deb349337b7c
        {
        }

        public virtual void GetString()
        {
        }


        double GeResult(double number);

        string GetString(double number);
    }
}
