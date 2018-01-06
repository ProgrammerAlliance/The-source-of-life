namespace Calculator.Core
{
    public class OperationMul:Operation
    {
        public override object GetResult()
        {  
                double result = 0;
                result = NumberA * NumberB;
                return result;    
        }
    }
}
