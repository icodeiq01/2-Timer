using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopTimerApp
{
    public partial class frmTimer : Form
    {
        private int Counter = 0;

        public frmTimer()
        {
            InitializeComponent();
            timer1.Interval = 1000; 
        }

        // (Start)
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        // (Stop)
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        // (Reset)
        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Counter = 0;
            label1.Text = "00:00:00";
        }

        // timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter++;
            TimeSpan time = TimeSpan.FromSeconds(Counter);

            label1.Text = time.ToString(@"hh\:mm\:ss");
        }

        private void frmTimer_Load(object sender, EventArgs e)
        {

        }

        private void frmTimer_Load_1(object sender, EventArgs e)
        {

        }
    }
}