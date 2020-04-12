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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
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
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.LawnGreen;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Black;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.ForeColor = System.Drawing.Color.LimeGreen;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.LimeGreen;
            this.linkLabel1.Location = new System.Drawing.Point(334, 390);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.linkLabel1.Size = new System.Drawing.Size(122, 34);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Дальше";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.LimeGreen;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Guess_the_Song_quiz.Properties.Resources.oy7vw3_coverartmanual;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 491);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.WMP);
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
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}