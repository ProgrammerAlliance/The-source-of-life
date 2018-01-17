using Calculator.Core.Operation.Enum;
using Calculator.Core.Opt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.SDK
{
    public class Expression
    {
        public bool IsOpt;

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
            if (Opt is ArithmeticEnum)
            {
                var opt = OperationFactory.CreatOperation((ArithmeticEnum)Opt);
                this.R = opt.GetResult(Convert.ToDouble(this.L), Convert.ToDouble(this.R)).ToString();
            }
            else if (Opt is SpecialEnum)
            {
                var opt = SpecalFactory.CreateSpecialOperation((SpecialEnum)Opt);
                switch ((SpecialEnum)Opt)
                {
                    case SpecialEnum.Percent:
                        var Popt = new Percent();
                        this.R = Popt.GetResult(Convert.ToDouble(this.L), Convert.ToDouble(this.R)).ToString();
                        break;
                    default:
                        this.R = opt.GetResult(Convert.ToDouble(this.R)).ToString();
                        break;
                }
            }
            return this.R;
        }

        /// <summary>
        /// 返回表达式字符串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string str = "";
            var opt = OperationFactory.CreatOperation((ArithmeticEnum)Opt);

            if(this.LExp==null)




            return str;




            //string str = "";
            //if (Opt == null) return "";

            //var opt = OperationFactory.CreatOperation((ArithmeticEnum)Opt);

            //str += LExp == null ? opt.GetToString(L):;


            //// str += opt.GetToString(LExp == null ? L : LExp.ToString());

            //return str;

        }
    }
}
