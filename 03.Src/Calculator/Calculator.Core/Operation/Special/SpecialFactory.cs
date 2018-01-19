using Calculator.Core.Operation.Enum;
using Calculator.Core.Opt;
using Calculator.Core.Opt.Operation.Special;

namespace Calculator.Core.Operation.Special
{
    /// <summary>
    /// 一目运算工厂
    /// </summary>
    public class SpecialFactory
    {
        public static ISpecialOperation CreateSpecialOperation(SpecialEnum? se)
        {
            ISpecialOperation spo = null;

            switch (se)
            {
                case SpecialEnum.Square:
                    {
                        spo = new Square();
                        break;
                    }
                case SpecialEnum.Sqrt:
                    {
                        spo = new Sqrt();
                        break;
                    }
                case SpecialEnum.Reciprocal:
                    {
                        spo = new Reciprocal();
                        break;
                    }
                case SpecialEnum.Percent:
                    {
                        spo = new Percent();
                        break;
                    }
                case SpecialEnum.Invert:
                    {
                        spo = new Invert();
                        break;
                    }
            }
            return spo;
        }
    }
}
