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
    public partial class frmSetAlram : Form
    {
        frmMain frmMain;
        public frmSetAlram(frmMain frm)
        {
            InitializeComponent();
            frmMain = frm;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmMain.alrmFajr = dtFajar.Value;
            frmMain.alrmZuhr = dtZuhr.Value;
            frmMain.alrmAsar = dtAsar.Value;
            frmMain.alrmMaghrib = dtMaghrib.Value;
            frmMain.alrmMaghrib = dtMaghrib.Value;
            frmMain.timer1.Start();
            this.Dispose();
        }
    }
}
