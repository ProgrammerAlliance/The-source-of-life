namespace Calculator.Core
{/// <summary>
 /// 百分号
 /// </summary>
    public class Percent: Special_Operation
    {
        public override object GetResult()
        {
            double result = 0;
            result =  NumberA/100;
            return result;
        }
    }
}
