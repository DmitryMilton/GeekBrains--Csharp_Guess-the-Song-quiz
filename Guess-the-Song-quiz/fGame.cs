using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Guess_the_Song_quiz
{
    public partial class fGame : Form
    {
        Random rnd = new Random();
        int musicDuration = Victorina.musicDuration;

        public fGame()
        {
            InitializeComponent();
            WMP.settings.volume = 2;
        }

        private void fGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
            e.Cancel = true;
            timer1.Stop();
            WMP.Ctlcontrols.stop();
            this.Hide();
        }

        void MakeMusic()
        {
            if (Victorina.list.Count() > 0)
            {
                musicDuration = Victorina.musicDuration;
                int n = rnd.Next(0, Victorina.list.Count);
                WMP.URL = Victorina.list[n];
                Victorina.answer = WMP.URL;
                Victorina.list.RemoveAt(n);
                lblSongCnt.Text = Victorina.list.Count.ToString();
            }
            else EndGame();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MakeMusic();
            timer1.Start();
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
            GamePause();
        }

        private void linkPlay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GamePlay();
        }

        private void fGame_Shown(object sender, EventArgs e)
        {
            lblSongCnt.Text = Victorina.list.Count.ToString();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Victorina.gameDuration;
            lblMusicDuration.Text = musicDuration.ToString();
        }

        void EndGame()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            musicDuration--;
            lblMusicDuration.Text = musicDuration.ToString();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                EndGame();
                return;
            }
            progressBar1.Value++;
            if (musicDuration == 0) MakeMusic();
        }

        void GamePause()
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }

        void GamePlay()
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }

        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (!timer1.Enabled) return;
            if (e.KeyData == Keys.A)
            {
                GamePause();
                fMessage fm = new fMessage();
                fm.lblMessage.Text = "Игрок 1";
                SoundPlayer sp = new SoundPlayer("Resources\\pl1.wav");
                sp.Play();
                if (fm.ShowDialog() == DialogResult.Yes)
                {
                    lblCounter1.Text = Convert.ToString(Convert.ToInt32(lblCounter1.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
            if (e.KeyData == Keys.P)
            {
                GamePause();
                fMessage fm = new fMessage();
                fm.lblMessage.Text = "Игрок 2";
                SoundPlayer sp = new SoundPlayer("Resources\\pl2.wav");
                sp.Play();
                if (fm.ShowDialog() == DialogResult.Yes)
                {
                    lblCounter2.Text = Convert.ToString(Convert.ToInt32(lblCounter2.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.randomStart)
                if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    WMP.Ctlcontrols.currentPosition = rnd.Next(0, (int)WMP.currentMedia.duration / 2);
        }

        private void lblCounter1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) + 1);
            if (e.Button == MouseButtons.Right) (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) - 1);
        }
    }
}
