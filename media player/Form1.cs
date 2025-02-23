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
            }
            else
            {
                mp1.settings.mute = true;
                btnmute.Text = "Unmute";
            }
        } 
    } 
}
