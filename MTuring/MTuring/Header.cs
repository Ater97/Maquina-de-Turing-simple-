using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTuring
{
    class Header
    {
        public int NumberMovs { get; set; }
        public int State { get; set; }
        public char CurrentChar { get; set; }
        public char Char { get; set; }     // E => Blank
        public int WhereMove { get; set; } // 1 right & 0 left
    }
}
