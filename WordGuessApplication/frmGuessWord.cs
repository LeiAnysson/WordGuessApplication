using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class frmGuessWord : Form
    {
        public frmGuessWord()
        {
            InitializeComponent();
        }

        private void Guess_Click(object sender, EventArgs e)
        {
            StringBuilder sbWord = new StringBuilder("kuromi");
            string input = GuessBox.Text;
            StringBuilder sbInput = new StringBuilder(input);

            if (sbInput.Equals(sbWord))
            {
                WordGuess.Text = sbWord.ToString();
                MessageBox.Show("The answer is correct! The word is " + sbWord + ".");
            }
            else
            {
                listBox1.Items.Add(sbInput + "\n");
                MessageBox.Show("The answer is incorrect! Try Again.");
            }
        }

        private void frmGuessWord_Load(object sender, EventArgs e)
        {
            StringBuilder sbWord = new StringBuilder("kuromi");
            for (int index = 1; index < sbWord.Length - 1; index++)
            {
                sbWord[index] = '?';
            }
            WordGuess.Text = sbWord.ToString();

        }

        private void WordGuess_Click(object sender, EventArgs e)
        {

        }
    }
}
