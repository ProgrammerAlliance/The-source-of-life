namespace Calculator.Core
{
    public  class OperationAdd:Operation
    {
        public override object GetResult()
        {
            object result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }
}
