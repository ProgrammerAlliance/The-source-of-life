using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class History
    {
        public string Formula { get; set; }
        
        public string Result { get; set; }

    }

    public class Historys : List<History>
    {
        public void Add()
        {

        }

        public void Clear()
        {

        }
    }
    
}
