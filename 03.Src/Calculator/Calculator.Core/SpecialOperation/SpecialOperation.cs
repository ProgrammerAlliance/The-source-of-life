using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator.Core
{
    public class Special_Operation
    {
        /// <summary>
        /// 开方
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private double _numberA = 0;
        private string _strFormula = "";

        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }
        public string StrFormula
        {
            get { return _strFormula; }
            set { _strFormula = value; }
        }
       

        public virtual void GetResult()
        {
        }

        //public virtual void GetString()
        //{
        //}



    }
}
