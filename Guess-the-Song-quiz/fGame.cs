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
        Random rnd = new Random();

        public fGame()
        {
            InitializeComponent();
            WMP.settings.volume = 1;
        }

        private void fGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
            e.Cancel = true;
            WMP.Ctlcontrols.stop();
            this.Hide();
        }

        void MakeMusic()
        {
            if (Victorina.list.Count() > 0)
            {
                int n = rnd.Next(0, Victorina.list.Count);
                WMP.URL = Victorina.list[n];
                Victorina.list.RemoveAt(n);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MakeMusic();
        }

        private void linkPause_Enter(object sender, EventArgs e)
        {
            linkPause.LinkColor = System.Drawing.Color.LimeGreen;
        }

        private void linkPause_Leave(object sender, EventArgs e)
        {
            linkPause.LinkColor = System.Drawing.Color.DodgerBlue;
        }

        private void linkPlay_Enter(object sender, EventArgs e)
        {
            linkPlay.LinkColor = System.Drawing.Color.LimeGreen;
        }

        private void linkPlay_Leave(object sender, EventArgs e)
        {
            linkPlay.LinkColor = System.Drawing.Color.DodgerBlue;
        }

        private void linkPause_MouseHover(object sender, EventArgs e)
        {
            linkPause.Focus();
        }

        private void linkPause_MouseLeave(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void linkPlay_MouseHover(object sender, EventArgs e)
        {
            linkPlay.Focus();
        }

        private void linkPlay_MouseLeave(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void linkPause_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WMP.Ctlcontrols.pause();
        }

        private void linkPlay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WMP.Ctlcontrols.play();
        }
    }
}
