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
        
        char[] Characters = new char[100];
        private void Run_btn_Click(object sender, EventArgs e)
        {
            Manager M = new Manager();
            originalString = textBox1.Text.Trim() + "E";
            textBox1.Enabled = false;
            label7.Text = "";
            label6.Text = "";
            textBox2.Text = "";

            if (originalString.Trim() != "") {
                if (comboBox1.Text.ToString() != "")
                {
                    comboBox1.Enabled = false;
                    Header MainHeader = new Header();
                    MainHeader.State = 0;
                    int position = 0;
                    Characters = originalString.ToCharArray();

                    rtbTape.ResetText();
                    rtbTape.Text = originalString.Trim();
                    rtbTape.SelectAll();
                    rtbTape.SelectionAlignment = HorizontalAlignment.Center;
                    rtbTape.DeselectAll();
                    HighlightSymbol(0); // Highlight first symbol

                     while (M.IsFinished())
                     {
                        Characters = originalString.ToCharArray();
                        //Thread.Sleep(500);
                        MainHeader = M.GetMachine(comboBox1.Text.ToString(), Characters[position], MainHeader.State);

                        if (MainHeader.WhereMove == 1)
                        {
                            ChangeCharacter(position, MainHeader.Char);
                            HighlightSymbol(position);
                            position++;
                        }
                        else
                        {
                            ChangeCharacter(position, MainHeader.Char);
                            HighlightSymbol(position);
                            position--;
                        }

                        label7.Text = MainHeader.State.ToString();
                        label6.Text = MainHeader.NumberMovs.ToString();
                     }
                }
                else MessageBox.Show("Select the Turing Machine");
            }
            else MessageBox.Show("Insert Text");
            textBox1.Enabled = true;
            comboBox1.Enabled = true;

            if (M.p.ERROR)
                textBox2.Text = "Fail!"; 
            else if (!M.p.ERROR)
                textBox2.Text = "Succed!";
        }

        public void HighlightSymbol (int charnumber)
        {
            
            if (charnumber < 0)
                charnumber = 0;
            rtbTape.Select(charnumber, 1);
            rtbTape.SelectionBackColor = Color.Red;
            rtbTape.SelectionColor = Color.Black;
            rtbTape.DeselectAll();
        }

        public void ChangeCharacter(int CharPosition, char newChar)
        {
            if (CharPosition < 0)
                CharPosition = 0;
            Characters[CharPosition] = newChar;
            //originalString = new string(Characters).Replace("E", "");
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        /*private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen p = new Pen(Color.Green, 5);
            l.DrawRectangle(p, 50, 50, 200, 200);
            l.Dispose();
        }*/
    }
}
