namespace Calculator.Core
{
    public class OperationDIV:Operation
    {
        public override object GetResult()
        {
            object result = 0;

            if (NumberA==0&&NumberB==0)
            {
                result = "结果未定义！";
            }
            else if (NumberB != 0)
            {
                result = NumberA / NumberB;
            }
            else
            {
               result= "除数不能为零！";
            }
            return result;
        }
    }
}
