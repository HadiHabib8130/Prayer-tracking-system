using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prayer_Tracking_System
{
    public partial class frmReportSheet : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        frmReport frmReport;
        public frmReportSheet(frmReport frm)
        {
            InitializeComponent();
            cn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\vs code\\Prayer Tracking System\\PTS db.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False";
            frmReport = frm;
            if(frm.report == 0)
            {
                DateWise();
            }
            if(frm.report == 1)
            {
                MissedDays();
            }
        }

        public void DateWise()
        {
            int i = 0;
            DateTime date = DateTime.Now;
            dataGridView1.Rows.Clear();

            cn.Open();
            cm = new SqlCommand("select * from att where Userid like " + frmReport.UserID + "and date >= '"+frmReport.dateTimePicker1.Value+"' and date <='"+frmReport.dateTimePicker2.Value+"' order by date", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                date = DateTime.Parse(dr[6].ToString());
                dataGridView1.Rows.Add(i, date.ToString("dd/MM/yyyy"), dr[0].ToString(), dr[1], dr[2], dr[3], dr[4], dr[5]);

            }

            cn.Close();
        }
        public void MissedDays()
        {
            int i = 0;
            DateTime date = DateTime.Now;
            dataGridView1.Rows.Clear();

            cn.Open();
            cm = new SqlCommand("select * from att where Userid like " + frmReport.UserID + "and date >= '" + frmReport.dateTimePicker1.Value + "' and date <='" + frmReport.dateTimePicker2.Value + "' order by date", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                if (dr[1].Equals(true) && dr[2].Equals(true) && dr[3].Equals(true) && dr[4].Equals(true) && dr[5].Equals(true))
                {

                }
                else
                {
                    i++;
                    date = DateTime.Parse(dr[6].ToString());
                    dataGridView1.Rows.Add(i, date.ToString("dd/MM/yyyy"), dr[0].ToString(), dr[1], dr[2], dr[3], dr[4], dr[5]);
                }
            }

            cn.Close();
        }
    }
}
