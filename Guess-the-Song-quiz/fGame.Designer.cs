namespace Guess_the_Song_quiz
{
    partial class fGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.linkNext = new System.Windows.Forms.LinkLabel();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblCounter1 = new System.Windows.Forms.Label();
            this.lblCounter2 = new System.Windows.Forms.Label();
            this.linkPause = new System.Windows.Forms.LinkLabel();
            this.linkPlay = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(2, 442);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(221, 47);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            // 
            // linkNext
            // 
            this.linkNext.ActiveLinkColor = System.Drawing.Color.LawnGreen;
            this.linkNext.AutoSize = true;
            this.linkNext.BackColor = System.Drawing.Color.Black;
            this.linkNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkNext.ForeColor = System.Drawing.Color.LimeGreen;
            this.linkNext.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkNext.LinkColor = System.Drawing.Color.LimeGreen;
            this.linkNext.Location = new System.Drawing.Point(337, 411);
            this.linkNext.Name = "linkNext";
            this.linkNext.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.linkNext.Size = new System.Drawing.Size(122, 34);
            this.linkNext.TabIndex = 1;
            this.linkNext.TabStop = true;
            this.linkNext.Text = "Дальше";
            this.linkNext.VisitedLinkColor = System.Drawing.Color.LimeGreen;
            this.linkNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.Color.Black;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1.Location = new System.Drawing.Point(74, 40);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(110, 31);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "Игрок 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.Color.Black;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayer2.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2.Location = new System.Drawing.Point(602, 40);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(110, 31);
            this.lblPlayer2.TabIndex = 3;
            this.lblPlayer2.Text = "Игрок 2";
            // 
            // lblCounter1
            // 
            this.lblCounter1.AutoSize = true;
            this.lblCounter1.BackColor = System.Drawing.Color.Black;
            this.lblCounter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCounter1.ForeColor = System.Drawing.Color.White;
            this.lblCounter1.Location = new System.Drawing.Point(110, 115);
            this.lblCounter1.Name = "lblCounter1";
            this.lblCounter1.Size = new System.Drawing.Size(29, 31);
            this.lblCounter1.TabIndex = 4;
            this.lblCounter1.Text = "0";
            // 
            // lblCounter2
            // 
            this.lblCounter2.AutoSize = true;
            this.lblCounter2.BackColor = System.Drawing.Color.Black;
            this.lblCounter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCounter2.ForeColor = System.Drawing.Color.White;
            this.lblCounter2.Location = new System.Drawing.Point(641, 115);
            this.lblCounter2.Name = "lblCounter2";
            this.lblCounter2.Size = new System.Drawing.Size(29, 31);
            this.lblCounter2.TabIndex = 5;
            this.lblCounter2.Text = "0";
            // 
            // linkPause
            // 
            this.linkPause.ActiveLinkColor = System.Drawing.Color.LawnGreen;
            this.linkPause.AutoSize = true;
            this.linkPause.BackColor = System.Drawing.Color.Black;
            this.linkPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkPause.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkPause.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkPause.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkPause.Location = new System.Drawing.Point(308, 454);
            this.linkPause.Name = "linkPause";
            this.linkPause.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.linkPause.Size = new System.Drawing.Size(78, 28);
            this.linkPause.TabIndex = 6;
            this.linkPause.TabStop = true;
            this.linkPause.Text = "Пауза";
            this.linkPause.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkPause.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPause_LinkClicked);
            this.linkPause.Enter += new System.EventHandler(this.linkPause_Enter);
            this.linkPause.Leave += new System.EventHandler(this.linkPause_Leave);
            this.linkPause.MouseLeave += new System.EventHandler(this.linkPause_MouseLeave);
            this.linkPause.MouseHover += new System.EventHandler(this.linkPause_MouseHover);
            // 
            // linkPlay
            // 
            this.linkPlay.ActiveLinkColor = System.Drawing.Color.LawnGreen;
            this.linkPlay.AutoSize = true;
            this.linkPlay.BackColor = System.Drawing.Color.Black;
            this.linkPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkPlay.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkPlay.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkPlay.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkPlay.Location = new System.Drawing.Point(397, 454);
            this.linkPlay.Name = "linkPlay";
            this.linkPlay.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.linkPlay.Size = new System.Drawing.Size(86, 28);
            this.linkPlay.TabIndex = 7;
            this.linkPlay.TabStop = true;
            this.linkPlay.Text = "Играть";
            this.linkPlay.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkPlay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPlay_LinkClicked);
            this.linkPlay.Enter += new System.EventHandler(this.linkPlay_Enter);
            this.linkPlay.Leave += new System.EventHandler(this.linkPlay_Leave);
            this.linkPlay.MouseLeave += new System.EventHandler(this.linkPlay_MouseLeave);
            this.linkPlay.MouseHover += new System.EventHandler(this.linkPlay_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(382, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "/";
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Guess_the_Song_quiz.Properties.Resources.oy7vw3_coverartmanual;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 491);
            this.Controls.Add(this.linkPlay);
            this.Controls.Add(this.linkPause);
            this.Controls.Add(this.lblCounter2);
            this.Controls.Add(this.lblCounter1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.linkNext);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fGame";
            this.Text = "Угадай мелодию";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fGame_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.LinkLabel linkNext;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblCounter1;
        private System.Windows.Forms.Label lblCounter2;
        private System.Windows.Forms.LinkLabel linkPause;
        private System.Windows.Forms.LinkLabel linkPlay;
        private System.Windows.Forms.Label label1;
    }
}