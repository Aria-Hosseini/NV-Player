using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace media_player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            loclable.Text = openFileDialog1.FileName;
            mp1.URL = openFileDialog1.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mp1.uiMode = "none";
            trackBarSeek.MouseDown += trackBarSeek_MouseDown;
            trackBarSeek.MouseUp += trackBarSeek_MouseUp;
            trackBarVolume.Scroll += trackBarVolume_Scroll;
            //this.Resize += Form1_Resize;
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mp1.URL))
            {
                if (mp1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    mp1.Ctlcontrols.pause();
                    btnplay.Text = "Play";
                }
                else if (mp1.playState == WMPLib.WMPPlayState.wmppsPaused ||
                         mp1.playState == WMPLib.WMPPlayState.wmppsStopped)
                {
                    mp1.Ctlcontrols.play();
                    btnplay.Text = "Pause";
                }
            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            mp1.Ctlcontrols.stop();
            btnplay.Text = "Play";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void mp1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mp1.settings.mute)
            {
                mp1.settings.mute = false;
                btnmute.Text = "Mute";
                trackBarVolume.Value = mp1.settings.volume;
            }
            else
            {
                mp1.settings.mute = true;
                btnmute.Text = "Unmute";
                trackBarVolume.Value = 0;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if(mp1.currentMedia != null && mp1.currentMedia.duration > 0)
            {
                double progress = (mp1.Ctlcontrols.currentPosition / mp1.currentMedia.duration) * 100;
                trackBarSeek.Value = (int)progress;
            }
        }

        private void trackBarSeek_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBarSeek_MouseDown(object sender, MouseEventArgs e)
        {
            if (mp1.currentMedia != null && mp1.currentMedia.duration > 0)
            {
                double newPosition = (e.X / (double)trackBarSeek.Width) * mp1.currentMedia.duration;
                mp1.Ctlcontrols.currentPosition = newPosition;
            }
            timer1.Stop();
        }

        private void trackBarSeek_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            mp1.settings.volume = trackBarVolume.Value;
        }

        private void ResizeControls()
        {
            //int controlPanelHeight = 50; // مقدار ارتفاع کنترل‌های پایین (مثل دکمه‌ها و نوار پیشرفت)

            //mp1.Width = this.ClientSize.Width;
            //mp1.Height = this.ClientSize.Height - controlPanelHeight;

            //trackBarSeek.Width = this.ClientSize.Width - 40;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Maximized)
            //{
            //    ResizeControls(); 
            //}
            //else if (this.WindowState == FormWindowState.Normal)
            //{
            //    ResizeControls(); 
            //}
        }
    } 
}
