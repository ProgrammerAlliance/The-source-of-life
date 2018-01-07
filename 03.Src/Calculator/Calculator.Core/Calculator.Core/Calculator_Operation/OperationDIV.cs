using Calculator.Core.Opt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class OperationDIV:Operation
    {
        public override double GetResult()
        {
            double result = 0;

            if (NumberA==0&&NumberB==0)
            {
                throw new Exception("结果未定义");
            }
            else if (NumberB != 0)
            {
                result = NumberA / NumberB;
            }
            else
            {
                throw new Exception("除数不能为零");
            }
            return result;
        }
    }
}
