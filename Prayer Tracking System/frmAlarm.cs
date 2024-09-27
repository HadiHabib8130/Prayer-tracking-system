using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prayer_Tracking_System
{
    public partial class frmAlarm : Form
    {
        frmMain frmMain;
        public frmAlarm(frmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain.player.Stop();
            frmMain.timer1.Start();
            this.Dispose();
        }
    }
}
