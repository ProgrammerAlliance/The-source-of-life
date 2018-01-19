using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Save
{
    public class History
    {
        public string Key { get; set; }

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

            var his = this.FirstOrDefault(k => k.Key == key);
            return his;
        }
    }

}