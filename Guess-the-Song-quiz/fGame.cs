using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_the_Song_quiz
{
    public partial class fGame : Form
    {
        public fGame()
        {
            InitializeComponent();
        }

        private void fGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
            e.Cancel = true;
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WMP.URL = Victorina.list[0];
        }
    }
}
