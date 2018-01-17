using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.SDK
{
    public class Expression
    {
        /// <summary>
        /// 是否按过操作符
        /// </summary>
        public bool IsInputOpt { get; set; }

        /// <summary>
        /// 左值
        /// </summary>
        public string L { get; set; }

        /// <summary>
        /// 右值
        /// </summary>
        public string R { get; set; }

        /// <summary>
        /// 左表达式
        /// </summary>
        public Expression LExp { get; set; }

        /// <summary>
        /// 右表达式
        /// </summary>
        public Expression RExp { get; set; }

        /// <summary>
        /// 二目运算符
        /// </summary>
        public ArithmeticEnum? Opt { get; set; }

        /// <summary>
        /// 一目运算符
        /// </summary>
        public SpecialEnum SpOpt { get; set; }

        /// <summary>
        /// 运算
        /// </summary>
        /// <returns></returns>
        public string DoCalc()
        {
            if (Opt is ArithmeticEnum)
            {
                var opt = OperationFactory.CreatOperation((ArithmeticEnum)Opt);
                this.R = opt.GetResult(Convert.ToDouble(this.L), Convert.ToDouble(this.R)).ToString();
            }
            else if (Opt is SpecialEnum)
            {
                var opt = SpecalFactory.CreateSpecialOperation((SpecialEnum)Opt);
                this.R = opt.GetResult(Convert.ToDouble(this.R)).ToString();
            }
            return this.R;
        }

        /// <summary>
        /// 返回表达式字符串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var opt = OperationFactory.CreatOperation(Opt);

            return opt.ToString()
        }

    }

}
