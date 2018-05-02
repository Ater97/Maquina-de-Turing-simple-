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

        public Header GetMachine (String machineNumber, char actualChar, int StateNumber)
        {
            switch (machineNumber)
            {
                case "Palindrome":
                    p.Read(StateNumber, actualChar);
                    return p.Myheader;
                case "Copy":
                    C.Read(StateNumber, actualChar);
                    break;
                default:
                    //  MessageBox.Show("Select the Turing Machine");
                    return null;

            }
            return null;
        }

        public bool IsFinished()
        {
            if (p.ERROR == true || p.finished == true)
                return false;
            return true;
        }
    }
}
