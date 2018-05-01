using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTuring
{
    class Manager
    {
        public char[] Characters { get; set; }
        public void GetMachine (String machineNumber)
        {
            switch (machineNumber)
            {
                case "Palindrome":
                    PAL();
                    break;
                case "Copy":
                    break;
                default:
                    //  MessageBox.Show("Select the Turing Machine");
                    break;

            }
        }

        public bool IsFinished()
        {
            bool flag = true;
            
            return flag;
        }

        public void PAL()
        {
            Palindromos p = new Palindromos();
            p.initialize(Characters[0]);
        }
    }
}
