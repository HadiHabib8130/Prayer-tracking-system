using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Prayer_Tracking_System
{
    public partial class frmReport : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public int UserID = 0;
        public int report = 0;
        public frmReport(int userID)
        {
            InitializeComponent();
            cn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\vs code\\Prayer Tracking System\\PTS db.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False";
            UserID = userID;
        }

        private void btnDateWiseReport_Click(object sender, System.EventArgs e)
        {
            frmReportSheet frmReportSheet = new frmReportSheet(this);
            frmReportSheet.label3.Text = "Date Wise Report";
            frmReportSheet.ShowDialog();
            
        }

        private void btnDaysMissed_Click(object sender, System.EventArgs e)
        {
            report = 1;
            frmReportSheet frmReportSheet = new frmReportSheet(this);
            frmReportSheet.label3.Text = "Missed Prayer Days";
            frmReportSheet.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
