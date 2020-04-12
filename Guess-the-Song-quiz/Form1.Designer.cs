namespace Guess_the_Song_quiz
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.linkPlay = new System.Windows.Forms.LinkLabel();
            this.linkConfig = new System.Windows.Forms.LinkLabel();
            this.linkExit = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkPlay
            // 
            this.linkPlay.ActiveLinkColor = System.Drawing.Color.LawnGreen;
            this.linkPlay.AutoSize = true;
            this.linkPlay.BackColor = System.Drawing.Color.Transparent;
            this.linkPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkPlay.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkPlay.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkPlay.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkPlay.Location = new System.Drawing.Point(33, 166);
            this.linkPlay.Name = "linkPlay";
            this.linkPlay.Size = new System.Drawing.Size(100, 31);
            this.linkPlay.TabIndex = 3;
            this.linkPlay.TabStop = true;
            this.linkPlay.Text = "Играть";
            this.linkPlay.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkPlay.Enter += new System.EventHandler(this.linkPlay_Enter);
            this.linkPlay.Leave += new System.EventHandler(this.linkPlay_Leave);
            this.linkPlay.MouseLeave += new System.EventHandler(this.linkPlay_MouseLeave);
            this.linkPlay.MouseHover += new System.EventHandler(this.linkPlay_MouseHover);
            // 
            // linkConfig
            // 
            this.linkConfig.ActiveLinkColor = System.Drawing.Color.LawnGreen;
            this.linkConfig.AutoSize = true;
            this.linkConfig.BackColor = System.Drawing.Color.Transparent;
            this.linkConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkConfig.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkConfig.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkConfig.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkConfig.Location = new System.Drawing.Point(33, 209);
            this.linkConfig.Name = "linkConfig";
            this.linkConfig.Size = new System.Drawing.Size(149, 31);
            this.linkConfig.TabIndex = 4;
            this.linkConfig.TabStop = true;
            this.linkConfig.Text = "Настройки";
            this.linkConfig.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkConfig_LinkClicked);
            this.linkConfig.Enter += new System.EventHandler(this.linkConfig_Enter);
            this.linkConfig.Leave += new System.EventHandler(this.linkConfig_Leave);
            this.linkConfig.MouseLeave += new System.EventHandler(this.linkConfig_MouseLeave);
            this.linkConfig.MouseHover += new System.EventHandler(this.linkConfig_MouseHover);
            // 
            // linkExit
            // 
            this.linkExit.ActiveLinkColor = System.Drawing.Color.LawnGreen;
            this.linkExit.AutoSize = true;
            this.linkExit.BackColor = System.Drawing.Color.Transparent;
            this.linkExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkExit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkExit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkExit.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkExit.Location = new System.Drawing.Point(33, 252);
            this.linkExit.Name = "linkExit";
            this.linkExit.Size = new System.Drawing.Size(95, 31);
            this.linkExit.TabIndex = 5;
            this.linkExit.TabStop = true;
            this.linkExit.Text = "Выход";
            this.linkExit.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkExit_LinkClicked);
            this.linkExit.Enter += new System.EventHandler(this.linkExit_Enter);
            this.linkExit.Leave += new System.EventHandler(this.linkExit_Leave);
            this.linkExit.MouseLeave += new System.EventHandler(this.linkExit_MouseLeave);
            this.linkExit.MouseHover += new System.EventHandler(this.linkExit_MouseHover);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Guess_the_Song_quiz.Properties.Resources.oy7vw3_coverartmanual;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 491);
            this.Controls.Add(this.linkExit);
            this.Controls.Add(this.linkConfig);
            this.Controls.Add(this.linkPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.Text = "Угадай мелодию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkPlay;
        private System.Windows.Forms.LinkLabel linkConfig;
        private System.Windows.Forms.LinkLabel linkExit;
    }
}

