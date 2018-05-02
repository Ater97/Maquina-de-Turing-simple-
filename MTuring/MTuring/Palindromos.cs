using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTuring
{
    class Palindromos
    {
        public Header Myheader = new Header();
        public bool ERROR = false;
        public bool finished = false;

        public void Read(int state, char newCharacter)
        {
            switch(state)
            {
                case 0: S0(newCharacter); break;
                case 1: S1(newCharacter); break;
                case 2: S2(newCharacter); break;
                case 3: S3(newCharacter); break;
                case 4: S4(newCharacter); break;
                case 5: S5(newCharacter); break;
                case 6: S6(newCharacter); break;
                case 7: S7(newCharacter); break;
                case 8: finished = true; break;
            }
        }
        public void S0(char readChar)
        {
            Myheader.NumberMovs++;
            if (readChar == 'a')
            {
                Myheader.Char = 'E';
                Myheader.State = 1;
                Myheader.WhereMove = 1;
            }
            else if (readChar == 'b')
            {
                Myheader.Char = 'E';
                Myheader.State = 2;
                Myheader.WhereMove = 1;
            }
            else if (readChar == 'c')
            {
                Myheader.Char = 'E';
                Myheader.State = 3;
                Myheader.WhereMove = 1;
            }
            else if(readChar == 'E')
            {
                Myheader.Char = 'E';
                Myheader.State = 8;
                Myheader.WhereMove = 1;
            }
            else
                ERROR = true;
        }
        public void S1(char readChar)
        {
            Myheader.NumberMovs++;
            if (readChar == 'a')
            {
                Myheader.Char = 'a';
                Myheader.State = 1;
                Myheader.WhereMove = 1;
            }
            else if (readChar == 'b')
            {
                Myheader.Char = 'b';
                Myheader.State = 1;
                Myheader.WhereMove = 1;
            }
            else if (readChar == 'c')
            {
                Myheader.Char = 'c';
                Myheader.State = 1;
                Myheader.WhereMove = 1;
            }
            else if (readChar == 'E')
            {
                Myheader.Char = 'E';
                Myheader.State = 4;
                Myheader.WhereMove = 0;
            }
            else
                ERROR = true;
        }
        public void S2(char readChar)
        {
            Myheader.NumberMovs++;
            if (readChar == 'a')
            {
                Myheader.Char = 'a';
                Myheader.State = 2;
                Myheader.WhereMove = 1;
            }
            else if (readChar == 'b')
            {
                Myheader.Char = 'b';
                Myheader.State = 2;
                Myheader.WhereMove = 1;
            }
            else if (readChar == 'c')
            {
                Myheader.Char = 'c';
                Myheader.State = 2;
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
        public void S3(char readChar)
        {
            Myheader.NumberMovs++;
            if (readChar == 'a')
            {
                Myheader.Char = 'a';
                Myheader.State = 3;
                Myheader.WhereMove = 1;
            }
            else if (readChar == 'b')
            {
                Myheader.Char = 'b';
                Myheader.State = 3;
                Myheader.WhereMove = 1;
            }
            else if (readChar == 'c')
            {
                Myheader.Char = 'c';
                Myheader.State = 3;
                Myheader.WhereMove = 1;
            }
            else if (readChar == 'E')
            {
                Myheader.Char = 'E';
                Myheader.State = 6;
                Myheader.WhereMove = 0;
            }
            else
                ERROR = true;
        }
        public void S4(char readChar)
        {
            Myheader.NumberMovs++;
            if (readChar == 'a')
            {
                Myheader.Char = 'E';
                Myheader.State = 7;
                Myheader.WhereMove = 0;
            }
            else if (readChar == 'E')
            {
                Myheader.Char = 'E';
                Myheader.State = 8;
                Myheader.WhereMove = 1;
            }
            else ERROR = true;

        }
        public void S5(char readChar)
        {
            Myheader.NumberMovs++;
            if (readChar == 'b')
            {
                Myheader.Char = 'E';
                Myheader.State = 7;
                Myheader.WhereMove = 0;
            }
            else if (readChar == 'E')
            {
                Myheader.Char = 'E';
                Myheader.State = 8;
                Myheader.WhereMove = 1;
            }
            else ERROR = true;

        }
        public void S6(char readChar)
        {
            Myheader.NumberMovs++;
            if (readChar == 'c')
            {
                Myheader.Char = 'E';
                Myheader.State = 7;
                Myheader.WhereMove = 0;
            }
            else if (readChar == 'E')
            {
                Myheader.Char = 'E';
                Myheader.State = 8;
                Myheader.WhereMove = 1;
            }
            else ERROR = true;

        }
        public void S7(char readChar)
        {
            Myheader.NumberMovs++;
            if (readChar == 'a')
            {
                Myheader.Char = 'a';
                Myheader.State = 7;
                Myheader.WhereMove = 0;
            }
            else if (readChar == 'b')
            {
                Myheader.Char = 'b';
                Myheader.State = 7;
                Myheader.WhereMove = 0;
            }
            else if (readChar == 'c')
            {
                Myheader.Char = 'c';
                Myheader.State = 7;
                Myheader.WhereMove = 0;
            }
            else if (readChar == 'E')
            {
                Myheader.Char = 'E';
                Myheader.State = 0;
                Myheader.WhereMove = 1;
            }
            else
                ERROR = true;
        }
    }
}
