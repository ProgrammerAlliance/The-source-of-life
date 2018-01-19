using Calculator.Core.Enum;
using Calculator.Core.MOps;
using Calculator.Core.Ops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.SDK
{
    public class Calc
    {
        Expression Exp { get; set; }

        public Calc()
        {
            Exp = new Expression
            {
                L = "",
                R = "0",
                EV = "0",
                LExp = null,
                RExp = null,
                Opt = null,
                IsCreateNew = false,
                IsOpt = TypeEnum.Equal,
            };
        }

        Memory me = new Memory();

        /// <summary>
        /// 0-9
        /// </summary>
        /// <param name="op"></param>
        public void InputNumber(int num)
        {
            if (Exp.Locked)
            {
                return;
            }
            IOps opt = new Numbers(num);
            Exp = opt.Process(Exp);
            if (Exp.IsOpt == TypeEnum.CommonSymbol)
            {
                Exp.IsCreateNew = true;
            }
            Exp.IsOpt = TypeEnum.Number;
        }

        /// <summary>
        /// . 和 ±
        /// </summary>
        /// <param name="op"></param>
        public void InputSymbol(SymbolEnum op)
        {
            if (Exp.Locked)
            {
                return;
            }
            IOps opt = new Symbols(op);
            Exp = opt.Process(Exp);
        }

        /// <summary>
        /// 四则运算
        /// </summary>
        /// <param name="op"></param>
        public void InputArithmetic(ArithmeticEnum op)
        {
            if (Exp.Locked)
            {
                return;
            }
            IOps opt = new Arithmetics(op);
            Exp = opt.Process(Exp);
            Exp.IsOpt = TypeEnum.CommonSymbol;
            Exp.IsCreateNew = false;
        }

        /// <summary>
        /// 一目运算
        /// </summary>
        /// <param name="op"></param>
        public void InputOneOperation(SpecialEnum op)
        {
            if (Exp.Locked)
            {
                return;
            }
            IOps opt = new OneOperations(op);
            Exp = opt.Process(Exp);
            Exp.IsOpt = TypeEnum.SpecialSymbol;
            Exp.IsCreateNew = true;
        }

        /// <summary>
        /// 内存运算
        /// </summary>
        /// <param name="op"></param>
        public void InputMemory(MEnum op)
        {
            IMOps iMOps = new Memorys(op);
            Exp = iMOps.Process(Exp, me);
        }

        /// <summary>
        /// 等于
        /// </summary>
        public void InputEqual()
        {
            if (Exp.Locked)
            {
                return;
            }
            IOps opt = new Equals();
            Exp = opt.Process(Exp);
            Exp.IsOpt = TypeEnum.Equal;
        }

        /// <summary>
        /// C CE Del
        /// </summary>
        public void InputClear(ClearEnum op)
        {
            //键盘锁定下只能按C、CE
            //按完一目操作符不能按退格
            //按完二目操作符不能按退格
            if ((Exp.Locked && op == ClearEnum.Del) || ((Exp.IsOpt == TypeEnum.SpecialSymbol) || (Exp.IsOpt == TypeEnum.CommonSymbol) && op == ClearEnum.Del))
            {
                return;
            }
            op = Exp.Locked ? ClearEnum.C : op;
            IOps opt = new Clear(op);
            Exp = opt.Process(Exp);
            Exp.Locked = false;
        }

        /// <summary>
        /// 获取输入框的值
        /// </summary>
        /// <returns></returns>
        public string R()
        {
            return Exp.EV;
        }

        /// <summary>
        /// 获取算式
        /// </summary>
        /// <returns></returns>
        public string GetFormula()
        {
            return Exp.ToString();
        }
    }
}
