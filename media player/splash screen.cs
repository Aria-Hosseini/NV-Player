using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media_player
{
    public partial class splash_screen : Form
    {
        public splash_screen()
        {
            InitializeComponent();
            timer1.Interval = 50; 
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelload.Width += 3;
            if (panelload.Width >= 682)
            {
                timer1.Stop();
                Form1 fm2 = new Form1();
                fm2.Show();
                this.Hide();
            }
        }
    }
}
