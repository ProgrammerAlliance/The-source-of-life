﻿using Calculator.Core.Ops;
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
                IsOpt = false,
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
            if (Exp.IsOpt)
            {
                Exp.IsCreateNew = true;
            }
            Exp.IsOpt = false;
        }

        /// <summary>
        /// . 和 ±
        /// </summary>
        /// <param name="op"></param>
        public void InputSymbol(SymbolEnum op)
        {
            IOps opt = new Symbols(op);
            Exp = opt.Process(Exp);
            Exp.IsOpt = false;
        }

        /// <summary>
        /// 四则运算
        /// </summary>
        /// <param name="op"></param>
        public void InputArithmetic(ArithmeticEnum op)
        {
            IOps opt = new Arithmetics(op);
            Exp = opt.Process(Exp);
            Exp.IsOpt = true;
            Exp.IsCreateNew = false;
        }

        /// <summary>
        /// 一目运算
        /// </summary>
        /// <param name="op"></param>
        public void InputOneOperation(SpecialEnum op)
        {
            IOps opt = new OneOperations(op);
            opt.Process(Exp);
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
            IOps opt = new Equals();
            Exp = opt.Process(Exp);
            Exp.IsOpt = true;
        }

        /// <summary>
        /// C CE Del
        /// </summary>
        public void InputClear(ClearEnum op)
        {
            IOps opt = new Clear(op);
            Exp = opt.Process(Exp);
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
