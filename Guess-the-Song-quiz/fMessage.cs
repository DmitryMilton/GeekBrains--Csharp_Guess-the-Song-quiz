﻿using System;
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
    public partial class fMessage : Form
    {
        int timeAnswer = 10;
        public fMessage()
        {
            InitializeComponent();
        }

        private void fMessage_Load(object sender, EventArgs e)
        {
            timeAnswer = 10;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeAnswer--;
            lblTimer.Text = timeAnswer.ToString();
            if (timeAnswer == 0)
            {
                timer1.Stop();
                SoundPlayer sp = new SoundPlayer("Resources\\1.wav");
                sp.Play();
            }
        }

        private void fMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("Resources\\yes.wav");
            sp.Play();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("Resources\\no.wav");
            sp.Play();
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {
            var mp3file = TagLib.File.Create(Victorina.answer);
            lblAnswer.Text = mp3file.Tag.FirstAlbumArtist + " - " + mp3file.Tag.Title;
        }
    }
}
