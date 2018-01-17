using Calculator.Core.SDK;

namespace Calculator.Core
{
    public interface ISpecialOperation
    {
        double GetResult(double number);

        string GetToString(string num);
        
    }
}
