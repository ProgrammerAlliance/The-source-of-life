using Calculator.Core.SDK;

namespace Calculator.Core
{
    /// <summary>
    /// 一目运算和算式
    /// </summary>
    public interface ISpecialOperation
    {
        /// <summary>
        /// 运算的抽象方法
        /// </summary>
        /// <param name="right">右值</param>
        /// <returns></returns>
        double GetResult(double right);

        /// <summary>
        /// 获取算式的抽象方法
        /// </summary>
        /// <param name="num">之前的算式</param>
        /// <returns></returns>
        string GetToString(string num);
        
    }
}
