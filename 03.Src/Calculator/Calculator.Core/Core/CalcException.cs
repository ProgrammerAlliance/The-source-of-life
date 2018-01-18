using System;

namespace Calculator.Core
{
    public class CalcException : Exception
    {
        private string message;
        public CalcException(string exceptionMessage):base(exceptionMessage)
        {
            message = exceptionMessage;
        }
        public override string ToString() 
        {
            return message;
        }
    }
}
