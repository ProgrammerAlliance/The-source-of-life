using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Core.SDK;
using Calculator.Core.Enum;

namespace Calculator.Core.Ops
{
    public class Memorys : IOps
    {
        MEnum _op;

        public Memorys(MEnum op)
        {
            this._op = op;
        }



        public Expression Process(Expression exp)
        {
            return exp;
        }

        public Expression Process(Expression exp, Memory memory)
        {
            switch (_op)
            {
                case MEnum.MClear:
                    memory.Clear();
                    break;
                case MEnum.MRead:
                    memory.Read(exp);
                    break;
                case MEnum.MSave:
                    memory.Save(exp);
                    break;
                case MEnum.MAdd:
                    memory.Add(exp);
                    break;
                case MEnum.MSub:
                    memory.Sub(exp);
                    break;
            }
            return exp;
        }
    }
}
