namespace Calculator.Core
{
    public class OperationMul:Operation
    {
        public override double GetResult()
        {  
                double result = 0;
                result = NumberA * NumberB;
                return result;    
        }
    }
}
