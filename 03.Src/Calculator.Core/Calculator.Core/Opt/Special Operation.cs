using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator.Core.Opt
{
    class Special_Operation
    {
        /// <summary>
        /// 开方
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private double _numberA = 0;

        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

       

        public virtual object GetResult()
        {
            double result = 0;
            return result;
        }

        public virtual string GetString()
        {
            string StringWord=null;
            return StringWord;
        }



    }
}
