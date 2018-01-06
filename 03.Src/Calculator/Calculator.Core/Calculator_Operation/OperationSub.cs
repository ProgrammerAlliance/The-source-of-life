namespace Calculator.Core
{
    public class OperationSub:Operation
    {
        public override object GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }
}
