namespace Calculator.Core
{
    public class Square:Special_Operation
    {
        string result = "";
        public override object GetResult()
        {
            double result = 0;
            result = NumberA* NumberA;
            return result;
        }

        public override string GetString()
        {
            result = "sqr(" + NumberA + ")";
            return result ;
        }

        
    }
}
