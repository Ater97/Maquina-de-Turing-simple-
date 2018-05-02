using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTuring
{
    class Mult
    {
        public Header Myheader = new Header();
        public bool ERROR = false;
        public bool finished = false;

        public void Read(int state, char newCharacter)
        {
            switch (state)
            {
                case 0: S0(newCharacter); break;
                case 1: S1(newCharacter); break;
                case 2: S2(newCharacter); break;
                case 4: S4(newCharacter); break;
                case 5: S5(newCharacter); break;
                case 6: S6(newCharacter); break;
                case 7: S7(newCharacter); break;
                case 8: S8(newCharacter); break;
                case 9: S9(newCharacter); break;
                case 3: finished = true; break;
            }
        }

        public void S0(char readChar)
        {
            Myheader.NumberMovs++;
            if (readChar == '1')
            {
                Myheader.Char = 'E';
                Myheader.State = 2;
                Myheader.WhereMove = 1;
            }
            else if(readChar == '*')
            {
                Myheader.Char = '*';
                Myheader.State = 1;
                Myheader.WhereMove = 1;
            }
            else
                ERROR = true;
        }
        public void S1(char readChar)
        {
            Myheader.NumberMovs++;
            if (readChar == '1')
            {
                Myheader.Char = '1';
                Myheader.State = 1;
                Myheader.WhereMove = 1;
            }
            else if (readChar == 'E')
            {
                Myheader.Char = 'E';
                Myheader.State = 3;
                Myheader.WhereMove = 0;
            }
            else
                ERROR = true;
        }
        public void S2(char readChar)
        {
            Myheader.NumberMovs++;
            if (readChar == '1')
            {
                Myheader.Char = '1';
                Myheader.State = 2;
                Myheader.WhereMove = 1;
            }
            else if (readChar == '*')
            {
                Myheader.Char = '*';
                Myheader.State = 4;
                Myheader.WhereMove = 1;
            }
            else
                ERROR = true;
        }
        public void S4(char readChar)
        {
            Myheader.NumberMovs++;
            if (readChar == '1')
            {
                Myheader.Char = 'E';
                Myheader.State = 6;
                Myheader.WhereMove = 1;
            }
            else if (readChar == 'E')
            {
                Myheader.Char = 'E';
                Myheader.State = 5;
                Myheader.WhereMove = 0;
            }
            else
                ERROR = true;
        }
        public void S5(char readChar)
        {
            Myheader.NumberMovs++;
            if (readChar == 'E')
            {
                Myheader.Char = '1';
                Myheader.State = 0;
                Myheader.WhereMove = 1;
            }
            else if (readChar == '1')
            {
                Myheader.Char = '1';
                Myheader.State = 5;
                Myheader.WhereMove = 0;
            }
            else if (readChar == '*')
            {
                Myheader.Char = '*';
                Myheader.State = 5;
                Myheader.WhereMove = 0;
            }
            else
                ERROR = true;
        }
        public void S6(char readChar)
        {
            Myheader.NumberMovs++;
            if (readChar == '1')
            {
                Myheader.Char = '1';
                Myheader.State = 6;
                Myheader.WhereMove = 1;
            }
            else if (readChar == 'E')
            {
                Myheader.Char = 'E';
                Myheader.State = 7;
                Myheader.WhereMove = 1;
            }
            else
                ERROR = true;
        }
        public void S7(char readChar)
        {
            Myheader.NumberMovs++;
            if (readChar == '1')
            {
                Myheader.Char = '1';
                Myheader.State = 7;
                Myheader.WhereMove = 1;
            }
            else if (readChar == 'E')
            {
                Myheader.Char = '1';
                Myheader.State = 8;
                Myheader.WhereMove = 0;
            }
            else
                ERROR = true;
        }
        public void S8(char readChar)
        {
            Myheader.NumberMovs++;
            if (readChar == '1')
            {
                Myheader.Char = '1';
                Myheader.State = 8;
                Myheader.WhereMove = 0;
            }
            else if (readChar == 'E')
            {
                Myheader.Char = 'E';
                Myheader.State = 9;
                Myheader.WhereMove = 0;
            }
            else
                ERROR = true;
        }
        public void S9(char readChar)
        {
            Myheader.NumberMovs++;
            if (readChar == '1')
            {
                Myheader.Char = '1';
                Myheader.State = 9;
                Myheader.WhereMove = 0;
            }
            else if (readChar == 'E')
            {
                Myheader.Char = '1';
                Myheader.State = 4;
                Myheader.WhereMove = 1;
            }
            else
                ERROR = true;
        }
    }
}
