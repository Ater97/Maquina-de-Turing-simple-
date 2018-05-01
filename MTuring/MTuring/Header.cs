using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTuring
{
    class Header
    {
        public int numberMovs { get; set; }
        public int currentState { get; set; }
        public string currentChar { get; set; }
        public int nextMove { get; set; } // 1 right & 0 left
    }
}
