using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class endScreen : UserControl
    {
        public endScreen()
        {
            InitializeComponent();
        }

        private void endScreen_Load(object sender, EventArgs e)
        {
            Graphics G = this.CreateGraphics();
            Font drawFont = new Font("Courier New", 10);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            G.DrawString("Your Guesses were:", drawFont, blackBrush, 50, 20);
            for (int i = 0; i < Form1.guessUser.Count(); i++)
            {
                label1.Text += "\n" + i + ": " + Form1.guessUser[i];
                Form1.guessUser.Sort();
                label2.Text += "\n" + i + ": " + Form1.guessUser[i];
                if (i == (Form1.guessUser.Count() - 1))
                {
                    label3.Text += "it took you " + Form1.guessUser.Count();
                }
            }
        }
    }
}
