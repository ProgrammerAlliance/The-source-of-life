using Calculator.Core.Opt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class SpecalFactory
    {
        public static ISpecialOperation CreateSpecialOperation(SpecialEnum se)
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
