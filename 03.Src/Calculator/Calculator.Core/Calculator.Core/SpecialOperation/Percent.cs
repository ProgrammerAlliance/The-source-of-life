namespace Calculator.Core.Opt
{/// <summary>
 /// 百分号
 /// </summary>
    public class Percent: Special_Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result =  NumberA/100;
            return result;
        }
    }
}
