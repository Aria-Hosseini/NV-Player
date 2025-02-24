namespace media_player
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.loclable = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnmute = new System.Windows.Forms.Button();
            this.trackBarSeek = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.mp1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mp1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.toolStripTextBox1,
            this.toolStripTextBox3});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.Gray;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripTextBox1.MaxLength = 4000000;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 19);
            this.toolStripTextBox1.Text = " made by Vihan";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.BackColor = System.Drawing.Color.Gray;
            this.toolStripTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox3.Font = new System.Drawing.Font("Modam", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripTextBox3.MaxLength = 4000000;
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 21);
            this.toolStripTextBox3.Text = "  v1.1.2";
            // 
            // loclable
            // 
            this.loclable.AutoSize = true;
            this.loclable.Location = new System.Drawing.Point(55, 9);
            this.loclable.Name = "loclable";
            this.loclable.Size = new System.Drawing.Size(60, 16);
            this.loclable.TabIndex = 2;
            this.loclable.Text = "location: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "mp4|*.mp4|mp3|*.mp3|mkv|*.mkv|avi|*.avi|All files|*.*";
            // 
            // btnplay
            // 
            this.btnplay.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnplay.Location = new System.Drawing.Point(0, 515);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(75, 30);
            this.btnplay.TabIndex = 3;
            this.btnplay.Text = "Play";
            this.btnplay.UseVisualStyleBackColor = false;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.Color.Salmon;
            this.btnstop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstop.Location = new System.Drawing.Point(81, 515);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(75, 30);
            this.btnstop.TabIndex = 4;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnmute
            // 
            this.btnmute.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnmute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmute.Location = new System.Drawing.Point(162, 515);
            this.btnmute.Name = "btnmute";
            this.btnmute.Size = new System.Drawing.Size(59, 30);
            this.btnmute.TabIndex = 5;
            this.btnmute.Text = "Mute";
            this.btnmute.UseVisualStyleBackColor = false;
            this.btnmute.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBarSeek
            // 
            this.trackBarSeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSeek.Location = new System.Drawing.Point(0, 453);
            this.trackBarSeek.Maximum = 100;
            this.trackBarSeek.Name = "trackBarSeek";
            this.trackBarSeek.Size = new System.Drawing.Size(597, 56);
            this.trackBarSeek.TabIndex = 6;
            this.trackBarSeek.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarSeek.Scroll += new System.EventHandler(this.trackBarSeek_Scroll);
            this.trackBarSeek.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBarSeek_MouseDown);
            this.trackBarSeek.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarSeek_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarVolume.Location = new System.Drawing.Point(227, 515);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(138, 56);
            this.trackBarVolume.TabIndex = 7;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // mp1
            // 
            this.mp1.Enabled = true;
            this.mp1.Location = new System.Drawing.Point(0, 31);
            this.mp1.Name = "mp1";
            this.mp1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mp1.OcxState")));
            this.mp1.Size = new System.Drawing.Size(459, 289);
            this.mp1.TabIndex = 0;
            this.mp1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mp1_PlayStateChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 543);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.trackBarSeek);
            this.Controls.Add(this.btnmute);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.loclable);
            this.Controls.Add(this.mp1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mp1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mp1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label loclable;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnmute;
        private System.Windows.Forms.TrackBar trackBarSeek;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
    }
}

