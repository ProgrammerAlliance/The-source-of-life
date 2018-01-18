using Calculator.Core.Enum;
using Calculator.Core.Opt;
using System;

namespace Calculator.Core.SDK
{
    public class Expression
    {
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
                var opt = SpecalFactory.CreateSpecialOperation((SpecialEnum)Opt);
                switch ((SpecialEnum)Opt)
                {
                    case SpecialEnum.Percent:
                        var Popt = new Percent();
                        string str = this.L;
                        result = Popt.GetResult(Convert.ToDouble(this.L), Convert.ToDouble(this.R)).ToString();
                        break;
                    default:
                        result = opt.GetResult(Convert.ToDouble(this.R)).ToString();
                        break;
                }
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

            if (Opt == null || IsOpt == TypeEnum.Equal)
            {
                return str;
            }

            if (LExp != null)
            {
                var opt = OperationFactory.CreatOperation((ArithmeticEnum)Opt);
                str += LExp.ToString() + opt.GetToString(LExp.R);
            }
            else
            {
                var opt = OperationFactory.CreatOperation((ArithmeticEnum)Opt);
                str  = opt.GetToString(L);
            }


            return str;



            //if (LExp != null || RExp != null)
            //{
            //    if (LExp != null)
            //    {
            //        var opt = OperationFactory.CreatOperation((ArithmeticEnum)Opt);
            //        str += LExp.ToString() + opt.GetToString(LExp.R);
            //    }
            //    if (RExp != null)
            //    {
            //        var opt = SpecalFactory.CreateSpecialOperation((SpecialEnum)RExp.Opt);
            //        str += opt.GetToString(RExp.ToString());
            //    }
            //}
            //else
            //{
            //    if (Opt is ArithmeticEnum)
            //    {
            //        string str2 = R;
            //        var opt = OperationFactory.CreatOperation((ArithmeticEnum)Opt);
            //        str = opt.GetToString(L);
            //    }
            //    else
            //    {
            //        return R;
            //    }
            //}
            //return str;
        }
    }
}
