﻿using Calculator.Core.Enum;
using Calculator.Core.Opt;
using System;

namespace Calculator.Core.SDK
{
    public class Expression
    {
        /// <summary>
        /// 记录当前输入的类型：数字，普通符号，特殊符号，等于号
        /// </summary>
        public TypeEnum IsOpt;

        /// <summary>
        /// 是否需要创建新的表达式
        /// </summary>
        public bool IsCreateNew { get; set; }

        /// <summary>
        /// 左值
        /// </summary>
        public string L { get; set; }

        /// <summary>
        /// 右值
        /// </summary>
        public string R { get; set; }

        /// <summary>
        /// 用于显示的结果值
        /// </summary>
        public string EV { get; set; }

        /// <summary>
        /// 左表达式
        /// </summary>
        public Expression LExp { get; set; }

        /// <summary>
        /// 右表达式
        /// </summary>
        public Expression RExp { get; set; }

        /// <summary>
        /// 运算符
        /// </summary>
        public object Opt { get; set; }

        /// <summary>
        /// 判断当前键盘是否锁定
        /// </summary>
        public bool Locked = false;

        /// <summary>
        /// 运算
        /// </summary>
        /// <returns></returns>
        public string DoCalc()
        {
            string result = "";
            if (Opt is ArithmeticEnum)
            {
                var opt = OperationFactory.CreatOperation((ArithmeticEnum)Opt);
                result = opt.GetResult(Convert.ToDouble(this.L), Convert.ToDouble(this.R)).ToString();
            }
            else if (Opt is SpecialEnum)
            {
                var opt = SpecialFactory.CreateSpecialOperation((SpecialEnum)Opt);
                switch ((SpecialEnum)Opt)
                {
                    case SpecialEnum.Percent:
                        var Popt = new Percent();
                        result = Popt.GetResult(Convert.ToDouble(this.L), Convert.ToDouble(this.R)).ToString();
                        break;
                    default:
                        result = opt.GetResult(Convert.ToDouble(this.R)).ToString();
                        break;
                }
            }
            else
            {
                result = Convert.ToDouble(EV).ToString();
            }
            return result;
        }

        /// <summary>
        /// 返回表达式字符串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string str = "";

            if (IsOpt == TypeEnum.Equal || Opt == null)
            {
                return str;
            }
            if (LExp != null)  //左分支不为空
            {
                var opt = OperationFactory.CreatOperation((ArithmeticEnum)Opt);

                if (LExp.L == null || LExp.IsOpt == TypeEnum.SpecialSymbol)
                {
                    str += opt.GetToString(LExp.ToString());
                }
                else
                {
                    str += LExp.ToString() + opt.GetToString(LExp.R);
                }
            }
            if (RExp != null)  //右分支不为空
            {
                if (Opt is ArithmeticEnum)  //当前层符号为普通符号
                {
                    var opt = OperationFactory.CreatOperation((ArithmeticEnum)Opt);

                    if (LExp != null)  //左分支不为空直接追加右分支生成的字符串
                    {
                        str += RExp.ToString();
                    }
                    else  //左分支为空带上当前左值生成字符串
                    {
                        str += opt.GetToString(L) + RExp.ToString();
                    }
                }
                else  //当前层符号为一目运算符
                {
                    var opt = SpecialFactory.CreateSpecialOperation((SpecialEnum)Opt);
                    str += opt.GetToString(RExp.ToString());
                }
            }
            else if (LExp == null && RExp == null)   //到达底层
            {
                if (Opt is ArithmeticEnum)
                {
                    var opt = OperationFactory.CreatOperation((ArithmeticEnum)Opt);
                    str = L + (char)((ArithmeticEnum)Opt);
                }
                else
                {
                    var opt = SpecialFactory.CreateSpecialOperation((SpecialEnum)Opt);
                    str = opt.GetToString(R);
                }
            }
            return str;
        }
    }
}
