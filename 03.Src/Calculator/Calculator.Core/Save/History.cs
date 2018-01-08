using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class History
    {
        public string key { get; set; }

        public string Formula { get; set; }

        public string Result { get; set; }

    }

    public class Historys : List<History>
    {
        public History Select(string key)
        {
            if (this.Count <= 0)
            {
                return null;
            }

            var his = this.FirstOrDefault(k => k.key == key);
            return his;
        }
    }

}