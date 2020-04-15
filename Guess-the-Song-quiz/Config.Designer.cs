namespace Guess_the_Song_quiz
{
    partial class fConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fConfig));
            this.lbSongsList = new System.Windows.Forms.ListBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.chbAllDirectories = new System.Windows.Forms.CheckBox();
            this.linkClear = new System.Windows.Forms.LinkLabel();
            this.linkPath = new System.Windows.Forms.LinkLabel();
            this.linkAdd = new System.Windows.Forms.LinkLabel();
            this.linkOK = new System.Windows.Forms.LinkLabel();
            this.linkCancel = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGameDuration = new System.Windows.Forms.ComboBox();
            this.cbMusicDuration = new System.Windows.Forms.ComboBox();
            this.chbRandomStart = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSongsList
            // 
            this.lbSongsList.BackColor = System.Drawing.Color.Black;
            this.lbSongsList.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbSongsList.FormattingEnabled = true;
            this.lbSongsList.Location = new System.Drawing.Point(11, 148);
            this.lbSongsList.Name = "lbSongsList";
            this.lbSongsList.Size = new System.Drawing.Size(610, 199);
            this.lbSongsList.TabIndex = 0;
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(11, 398);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(438, 20);
            this.tbPath.TabIndex = 3;
            // 
            // chbAllDirectories
            // 
            this.chbAllDirectories.AutoSize = true;
            this.chbAllDirectories.BackColor = System.Drawing.Color.Black;
            this.chbAllDirectories.Checked = true;
            this.chbAllDirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAllDirectories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbAllDirectories.ForeColor = System.Drawing.Color.SteelBlue;
            this.chbAllDirectories.Location = new System.Drawing.Point(11, 420);
            this.chbAllDirectories.Name = "chbAllDirectories";
            this.chbAllDirectories.Size = new System.Drawing.Size(210, 19);
            this.chbAllDirectories.TabIndex = 4;
            this.chbAllDirectories.Text = "Учитывая вложенные каталоги";
            this.chbAllDirectories.UseVisualStyleBackColor = false;
            // 
            // linkClear
            // 
            this.linkClear.ActiveLinkColor = System.Drawing.Color.LawnGreen;
            this.linkClear.AutoSize = true;
            this.linkClear.BackColor = System.Drawing.Color.Black;
            this.linkClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkClear.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkClear.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkClear.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkClear.Location = new System.Drawing.Point(8, 350);
            this.linkClear.Name = "linkClear";
            this.linkClear.Size = new System.Drawing.Size(82, 18);
            this.linkClear.TabIndex = 7;
            this.linkClear.TabStop = true;
            this.linkClear.Text = "Очистить";
            this.linkClear.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkClear.Enter += new System.EventHandler(this.linkClear_Enter);
            this.linkClear.Leave += new System.EventHandler(this.linkClear_Leave);
            this.linkClear.MouseLeave += new System.EventHandler(this.linkClear_MouseLeave);
            this.linkClear.MouseHover += new System.EventHandler(this.linkClear_MouseHover);
            // 
            // linkPath
            // 
            this.linkPath.ActiveLinkColor = System.Drawing.Color.LawnGreen;
            this.linkPath.AutoSize = true;
            this.linkPath.BackColor = System.Drawing.Color.Black;
            this.linkPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkPath.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkPath.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkPath.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkPath.Location = new System.Drawing.Point(8, 377);
            this.linkPath.Name = "linkPath";
            this.linkPath.Size = new System.Drawing.Size(143, 18);
            this.linkPath.TabIndex = 8;
            this.linkPath.TabStop = true;
            this.linkPath.Text = "Выбрать каталог";
            this.linkPath.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPath_LinkClicked);
            this.linkPath.Enter += new System.EventHandler(this.linkPath_Enter);
            this.linkPath.Leave += new System.EventHandler(this.linkPath_Leave);
            this.linkPath.MouseLeave += new System.EventHandler(this.linkPath_MouseLeave);
            this.linkPath.MouseHover += new System.EventHandler(this.linkPath_MouseHover);
            // 
            // linkAdd
            // 
            this.linkAdd.ActiveLinkColor = System.Drawing.Color.LawnGreen;
            this.linkAdd.AutoSize = true;
            this.linkAdd.BackColor = System.Drawing.Color.Black;
            this.linkAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkAdd.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkAdd.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkAdd.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkAdd.Location = new System.Drawing.Point(364, 419);
            this.linkAdd.Name = "linkAdd";
            this.linkAdd.Size = new System.Drawing.Size(85, 18);
            this.linkAdd.TabIndex = 9;
            this.linkAdd.TabStop = true;
            this.linkAdd.Text = "Добавить";
            this.linkAdd.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdd_LinkClicked);
            this.linkAdd.Enter += new System.EventHandler(this.linkAdd_Enter);
            this.linkAdd.Leave += new System.EventHandler(this.linkAdd_Leave);
            this.linkAdd.MouseLeave += new System.EventHandler(this.linkAdd_MouseLeave);
            this.linkAdd.MouseHover += new System.EventHandler(this.linkAdd_MouseHover);
            // 
            // linkOK
            // 
            this.linkOK.ActiveLinkColor = System.Drawing.Color.LawnGreen;
            this.linkOK.AutoSize = true;
            this.linkOK.BackColor = System.Drawing.Color.Black;
            this.linkOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkOK.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkOK.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkOK.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkOK.Location = new System.Drawing.Point(492, 419);
            this.linkOK.Name = "linkOK";
            this.linkOK.Size = new System.Drawing.Size(32, 18);
            this.linkOK.TabIndex = 10;
            this.linkOK.TabStop = true;
            this.linkOK.Text = "ОК";
            this.linkOK.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkOK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOK_LinkClicked);
            this.linkOK.Enter += new System.EventHandler(this.linkOK_Enter);
            this.linkOK.Leave += new System.EventHandler(this.linkOK_Leave);
            this.linkOK.MouseLeave += new System.EventHandler(this.linkOK_MouseLeave);
            this.linkOK.MouseHover += new System.EventHandler(this.linkOK_MouseHover);
            // 
            // linkCancel
            // 
            this.linkCancel.ActiveLinkColor = System.Drawing.Color.LawnGreen;
            this.linkCancel.AutoSize = true;
            this.linkCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkCancel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkCancel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkCancel.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkCancel.Location = new System.Drawing.Point(553, 419);
            this.linkCancel.Name = "linkCancel";
            this.linkCancel.Size = new System.Drawing.Size(68, 18);
            this.linkCancel.TabIndex = 11;
            this.linkCancel.TabStop = true;
            this.linkCancel.Text = "Отмена";
            this.linkCancel.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCancel_LinkClicked);
            this.linkCancel.Enter += new System.EventHandler(this.linkCancel_Enter);
            this.linkCancel.Leave += new System.EventHandler(this.linkCancel_Leave);
            this.linkCancel.MouseLeave += new System.EventHandler(this.linkCancel_MouseLeave);
            this.linkCancel.MouseHover += new System.EventHandler(this.linkCancel_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chbRandomStart);
            this.groupBox1.Controls.Add(this.cbMusicDuration);
            this.groupBox1.Controls.Add(this.cbGameDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 110);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки времени игры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продолжительность игры (мин)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Время на ответ (сек)";
            // 
            // cbGameDuration
            // 
            this.cbGameDuration.FormattingEnabled = true;
            this.cbGameDuration.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "30",
            "45",
            "60",
            "90",
            "120"});
            this.cbGameDuration.Location = new System.Drawing.Point(207, 20);
            this.cbGameDuration.Name = "cbGameDuration";
            this.cbGameDuration.Size = new System.Drawing.Size(56, 24);
            this.cbGameDuration.TabIndex = 2;
            this.cbGameDuration.Text = "5";
            // 
            // cbMusicDuration
            // 
            this.cbMusicDuration.FormattingEnabled = true;
            this.cbMusicDuration.Items.AddRange(new object[] {
            "3",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cbMusicDuration.Location = new System.Drawing.Point(207, 49);
            this.cbMusicDuration.Name = "cbMusicDuration";
            this.cbMusicDuration.Size = new System.Drawing.Size(56, 24);
            this.cbMusicDuration.TabIndex = 3;
            this.cbMusicDuration.Text = "20";
            // 
            // chbRandomStart
            // 
            this.chbRandomStart.AutoSize = true;
            this.chbRandomStart.Checked = true;
            this.chbRandomStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbRandomStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbRandomStart.Location = new System.Drawing.Point(10, 81);
            this.chbRandomStart.Name = "chbRandomStart";
            this.chbRandomStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbRandomStart.Size = new System.Drawing.Size(147, 19);
            this.chbRandomStart.TabIndex = 4;
            this.chbRandomStart.Text = "Со случайного места";
            this.chbRandomStart.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(8, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Список песен";
            // 
            // fConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Guess_the_Song_quiz.Properties.Resources.headphone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(631, 446);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkCancel);
            this.Controls.Add(this.linkOK);
            this.Controls.Add(this.linkAdd);
            this.Controls.Add(this.linkPath);
            this.Controls.Add(this.linkClear);
            this.Controls.Add(this.chbAllDirectories);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.lbSongsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fConfig";
            this.Text = "Настройки";
            this.Shown += new System.EventHandler(this.fConfig_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSongsList;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.CheckBox chbAllDirectories;
        private System.Windows.Forms.LinkLabel linkClear;
        private System.Windows.Forms.LinkLabel linkPath;
        private System.Windows.Forms.LinkLabel linkAdd;
        private System.Windows.Forms.LinkLabel linkOK;
        private System.Windows.Forms.LinkLabel linkCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMusicDuration;
        private System.Windows.Forms.ComboBox cbGameDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbRandomStart;
        private System.Windows.Forms.Label label3;
    }
}