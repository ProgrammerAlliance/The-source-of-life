using Calculator.Core.Operation.Enum;
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
        public static IOperation CreatOperation(ArithmeticEnum? oe)
        {
            IOperation oper = null;

            switch (oe)
            {
                case ArithmeticEnum.Add :
                    {
                        oper = new OperationAdd();
                        break;
                    }
                case ArithmeticEnum.Sub:
                    {
                        oper = new OperationSub();
                        break;
                    }
                case ArithmeticEnum.Mul:
                    {
                        oper = new OperationMul();
                        break;
                    }
                case ArithmeticEnum.Div:
                    {
                        oper = new OperationDiv();
                        break;
                    }

            }
            return oper;
        }
    }
}
