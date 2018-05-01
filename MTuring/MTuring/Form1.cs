using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        Manager M = new Manager();
        char[] Characters = new char[100];
        private void Run_btn_Click(object sender, EventArgs e)
        {
            originalString = textBox1.Text;
            textBox1.Enabled = false;

            if (originalString.Trim() != "") {
                Characters = originalString.ToCharArray();
                rtbTape.ResetText();
                rtbTape.Text = originalString.Trim();
                rtbTape.SelectAll();
                rtbTape.SelectionAlignment = HorizontalAlignment.Center;
                rtbTape.DeselectAll();
                HighlightSymbol(0); // Highlight first symbol

                M.GetMachine(comboBox1.Text.ToString());
                M.Characters = Characters;
                //while(M.IsFinished())
                {

                }
            }
            else { MessageBox.Show("Insert Text"); }
        }

        public void HighlightSymbol (int charnumber)
        {
            rtbTape.Select(charnumber, 1);
            rtbTape.SelectionBackColor = Color.Red;
            rtbTape.SelectionColor = Color.Black;
            rtbTape.DeselectAll();
        }

        public void ChangeCharacter(int currentChar, char newChar)
        {
            Characters[currentChar] = newChar;
            rtbTape.ResetText();
            rtbTape.Text = new string(Characters);
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
    }
}
