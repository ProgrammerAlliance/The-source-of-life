using Calculator.Core.Operation.Enum;
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
        /// 是否需要创建新的表达式
        /// </summary>
        public bool IsCreateNew { get; set; }

        /// <summary>
        /// 左侧数字
        /// </summary>
        public string L { get; set; }

        /// <summary>
        /// 右侧数字
        /// </summary>
        public string R { get; set; }

        /// <summary>
        /// 运算符
        /// </summary>
        public ArithmeticEnum? O { get; set; }

        /// <summary>
        /// 下级表达式
        /// </summary>
        public Expression Exp { get; set; }

        /// <summary>
        /// 运算
        /// </summary>
        /// <returns></returns>
        public string DoCalc()
        {
            var opt = OperationFactory.CreatOperation(O);
            this.R = opt.GetResult(Exp);
        }

        /// <summary>
        /// 返回表达式字符串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            throw new NotImplementedException();
        }

    }

}
