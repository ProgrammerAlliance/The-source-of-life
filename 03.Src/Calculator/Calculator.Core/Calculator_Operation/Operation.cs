using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public interface IOperation
    {

<<<<<<< .mine

        private double _numberA = 0;
        private double _numberB = 0;
        //private double _result = 0;
       // private string _symbol = null;
        
        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        public virtual object GetResult()
        {
            double result = 0;
            return result;
        }
        


=======
        double GetResult(double number1, double number2);

























>>>>>>> .theirs
        double GetResult(double number1, double number2);
     
    }
}
