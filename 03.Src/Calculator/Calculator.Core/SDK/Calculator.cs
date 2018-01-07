﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.SDK
{
    public class Calculator
    {
        /// <summary>
        /// 调用Operation计算方法
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public double UseOperation(double firstNum,double secondNum,string symbol)
        {
            IOperation oper = OperationFactory.CreatOperation(symbol);
            return oper.GetResult(firstNum,secondNum);
        }

        /// <summary>
        /// 调用Special计算方法
        /// </summary>
        /// <param name="num"></param>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public double UseSpecial(double num,string  symbol) {
            ISpecialOperation spo = SpecalFactory.CreateSpecialOperation(symbol);
            return spo.GetResult(num);
        }

        /// <summary>
        /// 调用特殊工厂的显示方法
        /// </summary>
        /// <param name="num"></param>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public static string UseSpecial_show(double num,string symbol)
        {
            ISpecialOperation spo = SpecalFactory.CreateSpecialOperation(symbol);
            return spo.GetString(num);
        }

        /// <summary>
        /// 调用数字显示方法
        /// </summary>
        /// <param name="flag"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public double UseNumber(ref bool flag,string str)
        {
            Number n = new Number();
            return n.GetNumber(str,ref flag);
        }

        Memory m = new Memory();

        /// <summary>
        /// 调用MS功能
        /// </summary>
        /// <param name="num"></param>
        public void UseMs(double num)
        {
            m.MemorySave(num);
        }

        /// <summary>
        /// 调用MR方法
        /// </summary>
        /// <returns></returns>
        public double UseMR()
        {
            return m.MemoryRead();
        }
        
    }
}
