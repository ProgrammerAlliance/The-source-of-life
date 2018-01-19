using System;

namespace Calculator.Core
{
    /// <summary>
    /// 自定义异常
    /// </summary>
    public class CalcException : Exception
    {
        private string message;

        public CalcException(string exceptionMessage) : base(exceptionMessage)
        {
            message = exceptionMessage;
        }

        public override string ToString()
        {
            return message;
        }
    }
}
