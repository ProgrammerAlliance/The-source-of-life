namespace Calculator.Core.Opt
{/// <summary>
/// 百分号
/// </summary>
    class Percent: Operation
    {
        public override object GetResult()
        {
            double result = 0;
            result = NumberA +((NumberA* NumberB)/100);
            return result;
        }
    }
}
