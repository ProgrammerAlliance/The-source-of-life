namespace Calculator.Core
{
    public interface ISpecialOperation
    {
        double GetResult(double number);

        string GetString(double number);
    }
}
