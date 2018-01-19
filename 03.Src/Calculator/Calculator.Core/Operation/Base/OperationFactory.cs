using Calculator.Core.Operation.Enum;

namespace Calculator.Core.Operation.Base
{
    /// <summary>
    /// 二目运算工厂
    /// </summary>
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
