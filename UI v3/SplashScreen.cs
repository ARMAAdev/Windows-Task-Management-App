using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_v3
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

        }
        public int r, g, b;
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            startupTimer.Start();
            
            r = 255;
            g = 0;
            b = 0;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public int seconds = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(seconds == 300)
            {
                startupTimer.Stop();
                this.Close();
            }
            this.BackColor = Color.FromArgb(r , g ,b);
            
            if( r > 0 && g < 255 && b < 255) {
                r--;
                g++;
                b++;
            }
           
            seconds++;
        }
    }
}
