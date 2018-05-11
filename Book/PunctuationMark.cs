using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class PunctuationMark:Symbol
    {
        private char[] marksendofsentens = new char[] { '.',  ';', '!', '?'  };
        private char[] marksinsentens = new char[] { ',', ':', '-' };
        public PunctuationMark(char ch)
        {
            if (marksendofsentens.Contains(ch))
                this.Value = ch;
        }
    }
}
