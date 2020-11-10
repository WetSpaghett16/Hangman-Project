using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_Project
{
    public partial class frmHangman : Form
    {
        String str = "Dutch Van Der Linde";
        int Guesses = 0;
        public frmHangman()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Guesses = Guesses + 1;
            lblGuesses.Text = Guesses.ToString();
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            lblHint.Visible = true;
        }
    }
}
