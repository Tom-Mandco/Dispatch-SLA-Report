using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandCo.Applications.DispatchSLAReport
{
    using Interfaces;

    public partial class SplashScreen : Form
    {
        DateTime dtStart;

        public SplashScreen()
        {
            InitializeComponent();
        }

        double msTaken = 0;

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            dtStart = DateTime.Now;
            tmrTimeTaken.Enabled = true;
            
        }

        static SplashScreen ms_frmSplash = null;

        static public void ShowForm()
        {
            ms_frmSplash = new SplashScreen();
            Application.Run(ms_frmSplash);
        }

        private void tmrTimeTaken_Tick(object sender, EventArgs e)
        {
            TimeSpan timeTaken = DateTime.Now - dtStart;
            msTaken = Math.Round(timeTaken.TotalMilliseconds, 0);
            lblMsTaken.Text = string.Format("{0} ms", msTaken);
        }
    }
}
