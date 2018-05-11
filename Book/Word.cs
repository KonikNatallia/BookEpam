using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Word: Symbol
    {
        new public string Value { get; set; }
        public int Length { get { return Value.Length; } }

        public Word(string str)
        {
            Value = str;
        }

        public Word()
        {
        }
    }
}
