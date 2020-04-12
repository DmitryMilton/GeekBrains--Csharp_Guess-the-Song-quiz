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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        fConfig fc = new fConfig();
        fGame fg = new fGame();

        private void linkPlay_Enter(object sender, EventArgs e)
        {
            linkPlay.LinkColor = System.Drawing.Color.LimeGreen;
        }

        private void linkPlay_Leave(object sender, EventArgs e)
        {
            linkPlay.LinkColor = System.Drawing.Color.DodgerBlue;
        }

        private void linkConfig_Enter(object sender, EventArgs e)
        {
            linkConfig.LinkColor = System.Drawing.Color.LimeGreen;
        }

        private void linkConfig_Leave(object sender, EventArgs e)
        {
            linkConfig.LinkColor = System.Drawing.Color.DodgerBlue;
        }

        private void linkExit_Enter(object sender, EventArgs e)
        {
            linkExit.LinkColor = System.Drawing.Color.LimeGreen;
        }

        private void linkExit_Leave(object sender, EventArgs e)
        {
            linkExit.LinkColor = System.Drawing.Color.DodgerBlue;
        }

        private void linkPlay_MouseHover(object sender, EventArgs e)
        {
            linkPlay.Focus();
        }

        private void linkPlay_MouseLeave(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void linkConfig_MouseHover(object sender, EventArgs e)
        {
            linkConfig.Focus();
        }

        private void linkConfig_MouseLeave(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void linkExit_MouseHover(object sender, EventArgs e)
        {
            linkExit.Focus();
        }

        private void linkExit_MouseLeave(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fc.ShowDialog();
        }

        private void linkPlay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fg.Show();
            this.Hide();
        }
    }
}
