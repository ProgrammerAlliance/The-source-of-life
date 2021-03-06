﻿using Calculator.Core.Operation.Enum;
using Calculator.Core.Save;
using Calculator.Core.SDK;

namespace Calculator.Core.MOps
{
    public class Memorys : IMOps
    {
        MEnum _op;

        public Memorys(MEnum op)
        {
            this._op = op;
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
