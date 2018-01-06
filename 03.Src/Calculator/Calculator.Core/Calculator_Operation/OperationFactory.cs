namespace Calculator.Core
{
    public class OperationFactory
    {
        public static Operation creatOperation(string operate)
        {
            Operation oper = null;

            switch (operate)
            {
                case "+":
                    {
                        oper = new OperationAdd();
                        break;
                    }
                case "-":
                    {
                        oper = new OperationSub();
                        break;
                    }
                case "×":
                    {
                        oper = new OperationMul();
                        break;
                    }
                case "÷":
                    {
                        oper = new OperationDIV();
                        break;
                    }
            }
            return oper;
        }
    }
}
