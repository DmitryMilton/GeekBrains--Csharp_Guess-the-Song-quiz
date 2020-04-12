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
    public partial class fConfig : Form
    {
        public fConfig()
        {
            InitializeComponent();
        }

        private void linkPath_Enter(object sender, EventArgs e)
        {
            linkPath.LinkColor = System.Drawing.Color.LimeGreen;
        }

        private void linkPath_Leave(object sender, EventArgs e)
        {
            linkPath.LinkColor = System.Drawing.Color.DodgerBlue;
        }

        private void linkPath_MouseHover(object sender, EventArgs e)
        {
            linkPath.Focus();
        }

        private void linkPath_MouseLeave(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void linkAdd_Enter(object sender, EventArgs e)
        {
            linkAdd.LinkColor = System.Drawing.Color.LimeGreen;
        }

        private void linkAdd_Leave(object sender, EventArgs e)
        {
            linkAdd.LinkColor = System.Drawing.Color.DodgerBlue;
        }

        private void linkAdd_MouseHover(object sender, EventArgs e)
        {
            linkAdd.Focus();
        }

        private void linkAdd_MouseLeave(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void linkClear_Enter(object sender, EventArgs e)
        {
            linkClear.LinkColor = System.Drawing.Color.LimeGreen;
        }

        private void linkClear_Leave(object sender, EventArgs e)
        {
            linkClear.LinkColor = System.Drawing.Color.DodgerBlue;
        }

        private void linkClear_MouseHover(object sender, EventArgs e)
        {
            linkClear.Focus();
        }

        private void linkClear_MouseLeave(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void linkOK_Enter(object sender, EventArgs e)
        {
            linkOK.LinkColor = System.Drawing.Color.LimeGreen;
        }

        private void linkOK_Leave(object sender, EventArgs e)
        {
            linkOK.LinkColor = System.Drawing.Color.DodgerBlue;
        }

        private void linkOK_MouseHover(object sender, EventArgs e)
        {
            linkOK.Focus();
        }

        private void linkOK_MouseLeave(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void linkCancel_Enter(object sender, EventArgs e)
        {
            linkCancel.LinkColor = System.Drawing.Color.LimeGreen;
        }

        private void linkCancel_Leave(object sender, EventArgs e)
        {
            linkCancel.LinkColor = System.Drawing.Color.DodgerBlue;
        }

        private void linkCancel_MouseHover(object sender, EventArgs e)
        {
            linkCancel.Focus();
        }

        private void linkCancel_MouseLeave(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void linkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void linkOK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void linkPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = fbd.SelectedPath;
            }
        }

        private void linkAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbSongsList.Items.Clear();
            string[] musicList;
            if (chbInclude.Checked)
            {
                musicList = System.IO.Directory.GetFiles(tbPath.Text, "*.mp3", System.IO.SearchOption.AllDirectories);
            }
            else
            {
                musicList = System.IO.Directory.GetFiles(tbPath.Text, "*.mp3", System.IO.SearchOption.TopDirectoryOnly);
            }
            lbSongsList.Items.AddRange(musicList);
        }
    }
}
