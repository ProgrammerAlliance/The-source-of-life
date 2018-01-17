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

        /// <summary>
        /// 是否需要创建新的表达式
        /// </summary>
        public static bool IsCreateNew = false;

        public Calc()
        {
            Exp = new Expression
            {
                L = "",
                R = "0",
                LExp = null,
                RExp = null,
                Opt = null,
                IsInputOpt = true,
            };
        }

        /// <summary>
        /// 0-9
        /// </summary>
        /// <param name="op"></param>
        public void InputNumber(int num)
        {
            IOps opt = new Numbers(num);
            Exp = opt.Process(Exp);
        }

        /// <summary>
        /// . 和 ±
        /// </summary>
        /// <param name="op"></param>
        public void InputSymbol(SymbolEnum op)
        {
            IOps opt = new Symbols(op);
            Exp = opt.Process(Exp);
        }

        /// <summary>
        /// 四则运算
        /// </summary>
        /// <param name="op"></param>
        public void InputArithmetic(ArithmeticEnum op)
        {
            IOps opt = new Arithmetics(op);
            Exp = opt.Process(Exp);
        }

        /// <summary>
        /// 一目运算
        /// </summary>
        /// <param name="op"></param>
        public void InputOneOperation(SpecialEnum op)
        {
            IOps opt = new OneOperations(op);
            Exp = opt.Process(Exp);
        }

        /// <summary>
        /// 内存运算
        /// </summary>
        /// <param name="op"></param>
        public void InputMemory(string op)
        {

        }

        /// <summary>
        /// 等于
        /// </summary>
        public void InputEqual()
        {
            //1.直接点


            //2.数字->

            //3.数字->运算->

            //4.正常点

        }

    }
}
