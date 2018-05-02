using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTuring
{
    class Copy
    {
        public Header Myheader = new Header();
        public bool ERROR = false;
        public bool finished = false;

        public void Read(int state, char newCharacter)
        {
            switch (state)
            {
               /* case 0: S0(newCharacter); break;
                case 1: S1(newCharacter); break;
                case 2: S2(newCharacter); break;
                case 3: S3(newCharacter); break;
                case 4: S4(newCharacter); break;
                case 5: S5(newCharacter); break;
                case 6: S6(newCharacter); break;
                case 7: S7(newCharacter); break;*/
                case 8: finished = true; break;
            }
        }
    }
}
