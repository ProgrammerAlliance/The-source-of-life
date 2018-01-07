 using Calculator.Core.Opt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class OperationFactory
    {
        public static IOperation CreatOperation(OperateEnum oe)
        {
            IOperation oper = null;

            switch (oe)
            {
                case OperateEnum.Add :
                    {
                        oper = new OperationAdd();
                        break;
                    }
                case OperateEnum.Sub:
                    {
                        oper = new OperationSub();
                        break;
                    }
                case OperateEnum.Mul:
                    {
                        oper = new OperationMul();
                        break;
                    }
                case OperateEnum.Div:
                    {
                        oper = new OperationDiv();
                        break;
                    }

            }
            return oper;
        }
    }
}
