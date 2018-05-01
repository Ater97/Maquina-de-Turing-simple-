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
        public int CurrentState { get; set; }
        public int NextState { get; set; }
        public char CurrentChar { get; set; }
        public int NextMove { get; set; } // 1 right & 0 left
        public char NewChar { get; set; }
    }
}
