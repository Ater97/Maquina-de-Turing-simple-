using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTuring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        String originalString = "";
        Manager M;
        Header MainHeader;
        char[] Characters = new char[100];
        int position = 0;
        private void Run_btn_Click(object sender, EventArgs e)
        {
            Specs();
            M = new Manager();
            originalString = textBox1.Text.Trim() + "EEE";
            textBox1.Enabled = false;
            label7.Text = "";
            label6.Text = "";
            textBox2.Text = "";

            if (originalString.Trim() != "")
            {
                if (comboBox1.Text.ToString() != "")
                {
                    comboBox1.Enabled = false;
                    MainHeader = new Header();
                    MainHeader.State = 0;
                    position = 0;
                    Characters = originalString.ToCharArray();

                    rtbTape.ResetText();
                    rtbTape.Text = originalString.Trim();
                    rtbTape.SelectAll();
                    rtbTape.SelectionAlignment = HorizontalAlignment.Center;
                    rtbTape.DeselectAll();
                    HighlightSymbol(0); // Highlight first symbol

                    while (M.IsFinished())
                    {
                        if (position >= originalString.Length)
                            originalString = originalString + "E";

                        Characters = originalString.ToCharArray();
                        MainHeader = M.GetMachine(comboBox1.Text.ToString(), Characters[position], MainHeader.State);
                        if (M.IsFinished())
                        {
                            ChangeCharacter(position, MainHeader.Char);
                            HighlightSymbol(position);
                        }
                        if (MainHeader.WhereMove == 1)
                            position++;
                        else
                            position--;

                        label7.Text = MainHeader.State.ToString();
                        label6.Text = MainHeader.NumberMovs.ToString();
                    }
                }
                else MessageBox.Show("Select the Turing Machine");
            }
            else MessageBox.Show("Insert Text");


            textBox1.Enabled = true;
            comboBox1.Enabled = true;

            if (M.ERROR())
                textBox2.Text = "Fail!";
            else if (!M.ERROR())
                textBox2.Text = "Succed!";
        }

        public void HighlightSymbol(int charnumber)
        {
            if (charnumber < 0)
                charnumber = 0;
            rtbTape.Select(charnumber, 1);
            rtbTape.SelectionBackColor = Color.BlanchedAlmond;
            rtbTape.SelectionColor = Color.Black;
            rtbTape.DeselectAll();
        }

        public void ChangeCharacter(int CharPosition, char newChar)
        {
            if (CharPosition < 0)
                CharPosition = 0;
            Characters[CharPosition] = newChar;
            originalString = new string(Characters);
            rtbTape.ResetText();
            rtbTape.Text = originalString;
            rtbTape.SelectAll();
            rtbTape.SelectionAlignment = HorizontalAlignment.Center;
            rtbTape.DeselectAll();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            originalString = textBox1.Text;
            rtbTape.ResetText();
            rtbTape.Text = originalString.Trim();
            rtbTape.SelectAll();
            rtbTape.SelectionAlignment = HorizontalAlignment.Center;
            rtbTape.DeselectAll();
        }

        bool firsttime = true;
        private void button1_Click(object sender, EventArgs e)
        {

            if (firsttime)
            {
                M = new Manager();
                originalString = textBox1.Text.Trim() + "EEE";
                textBox1.Enabled = false;
                label7.Text = "";
                label6.Text = "";
                textBox2.Text = "";
            }


            if (originalString.Trim() != "")
            {
                if (comboBox1.Text.ToString() != "")
                {
                    if (firsttime)
                    {
                        comboBox1.Enabled = false;
                        MainHeader = new Header();
                        MainHeader.State = 0;
                        position = 0;
                        Characters = originalString.ToCharArray();

                        rtbTape.ResetText();
                        rtbTape.Text = originalString.Trim();
                        rtbTape.SelectAll();
                        rtbTape.SelectionAlignment = HorizontalAlignment.Center;
                        rtbTape.DeselectAll();
                        HighlightSymbol(0); // Highlight first symbol
                    }

                    if (M.IsFinished())
                    {
                        if (position >= originalString.Length)
                            originalString = originalString + "E";
                       /* if (position < 0)
                        {
                            originalString = "E" + originalString;
                            position = 0;
                        }*/

                        Characters = originalString.ToCharArray();
                        
                        MainHeader = M.GetMachine(comboBox1.Text.ToString(), Characters[position], MainHeader.State);
                        if (M.IsFinished())
                        {
                            ChangeCharacter(position, MainHeader.Char);
                            HighlightSymbol(position);
                        }
                        if (MainHeader.WhereMove == 1)
                            position++;
                        else
                            position--;

                        label7.Text = MainHeader.State.ToString();
                        label6.Text = MainHeader.NumberMovs.ToString();
                    }
                }
                else MessageBox.Show("Select the Turing Machine");
            }
            else MessageBox.Show("Insert Text");
            if (firsttime)
            {
                textBox1.Enabled = true;
                comboBox1.Enabled = true;
                firsttime = false;
            }

            if (!M.IsFinished())
            {
                firsttime = true;
                btnPause.Text = "Start";
                timer1.Enabled = false;
                if (M.ERROR())
                    textBox2.Text = "Fail!";
                else if (!M.ERROR())
                    textBox2.Text = "Succed!";
            }
        }

        public void Specs()
        {
            if (comboBox1.Text == "Mult")
                if (originalString.Trim()[originalString.Length - 1] != '=')
                    originalString = originalString.Trim() + "=";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Palindrome":
                    txtBInstructions.Text = "Reconocedor de cadenas palíndromas: Reconoce una cadena de a , b o c ’s y verifica que la cadena sea un palíndromo.";
                    break;
                case "Mult":
                    txtBInstructions.Text = "Multiplicación en código unario: Reconoce una cadena y realiza la multiplicación respectiva.";
                    break;
                case "Copy":
                    txtBInstructions.Text = "Copia de patrones: Reconoce un patrón de a, b o c’s y lo copia de manera idéntica. ";
                    break;
                case "Add":
                    txtBInstructions.Text = "Suma en código unario: Reconoce una cadena y realiza la suma respectiva.";
                    break;
                case "Sub":
                    txtBInstructions.Text = "Resta en código unario: Reconoce una cadena y realiza la resta respectiva. ";
                    break;
                default: break;
            }
        }


        private void btnPause_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToString() != "")
            {
                if (btnPause.Text == "Stop")
                {
                    btnPause.Text = "Start";
                    timer1.Enabled = false;
                }
                else
                {
                    btnPause.Text = "Stop";
                    timer1.Enabled = true;
                }
            }
            else
             MessageBox.Show("Select the Turing Machine"); 
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            btnStep.PerformClick();
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            int v = (trackBar1.Maximum - trackBar1.Value) * 5 + 1;

            timer1.Interval = v;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int v = (trackBar1.Maximum - trackBar1.Value) * 5 + 1;

            timer1.Interval = v;
        }
    }
}
    