using Calculator.Core.SDK;

namespace Calculator.Core
{
    /// <summary>
    /// 一目运算和算式
    /// </summary>
    public interface ISpecialOperation
    {
        double GetResult(double right);

        string GetToString(string num);
        
    }
}
