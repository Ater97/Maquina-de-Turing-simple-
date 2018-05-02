using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTuring
{
    class Manager
    {
        public Palindromos p = new Palindromos();
        public Copy C = new Copy();
        public Mult M = new Mult();
        public Add A = new Add();
        public Sub S = new Sub();

        public Header GetMachine(String machineNumber, char actualChar, int StateNumber)
        {
            switch (machineNumber)
            {
                case "Palindrome":
                    p.Read(StateNumber, actualChar);
                    return p.Myheader;
                case "Copy":
                    C.Read(StateNumber, actualChar);
                    return C.Myheader;
                case "Mult":
                    M.Read(StateNumber, actualChar);
                    return M.Myheader;
                case "Add":
                    A.Read(StateNumber, actualChar);
                    return M.Myheader;
                case "Substract":
                    S.Read(StateNumber, actualChar);
                    return M.Myheader;
                default:
                    return null;
            }
        }

        public bool IsFinished()
        {
            if (p.ERROR == true || p.finished == true || C.ERROR == true || C.finished == true
                || M.ERROR == true || M.finished == true)
                return false;
            return true;
        }
    }
}
