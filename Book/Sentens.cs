using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Sentens:Word
    {
        new public string Value { get; set; }

        public Sentens(string str)
        {
            Value = str;
        }
    }
}
