using Calculator.Core.Enum;
using Calculator.Core.Opt;

namespace Calculator.Core
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
            }
            return spo;
        }
    }
}
