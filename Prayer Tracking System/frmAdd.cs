using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prayer_Tracking_System
{
    public partial class frmAdd : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        frmMain frmMain;
        
        
        public frmAdd(frmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
            cn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\vs code\\Prayer Tracking System\\PTS db.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False";
            dateTimePicker1.Value = DateTime.Now;
            
        }
        private void PrayerSave()
        {
            
            
            
                cn.Open();
                cm = new SqlCommand("update att set  fajr = @fajr, zuhr = @zuhr, asar = @asar, maghrib = @maghrib, isha = @isha  where date = @date and Userid = " + frmMain.UserID + "", cn);
                cm.Parameters.AddWithValue("@date", DateTime.Parse(dateTimePicker1.Value.ToShortDateString()));
                cm.Parameters.AddWithValue("@fajr", chkFajar.Checked);
                cm.Parameters.AddWithValue("@zuhr", chkZuhr.Checked);
                cm.Parameters.AddWithValue("@asar", chkAsar.Checked);
                cm.Parameters.AddWithValue("@maghrib", chkMaghrib.Checked);
                cm.Parameters.AddWithValue("@isha", chkIsha.Checked);
                cm.ExecuteNonQuery();
                cn.Close();
            
            

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = false;
                cn.Open();
                cm = new SqlCommand("select date from att where Userid = " + frmMain.UserID + "", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    
                    if (DateTime.Parse(dr[0].ToString()).ToShortDateString() == dateTimePicker1.Value.ToShortDateString())
                    {
                        check = true;
                    }

                }
                cn.Close();
                if (check == true)
                {
                    PrayerSave();
                    MessageBox.Show("Saved!");
                    this.Close();
                    frmMain.showdata();
                }
                else
                {
                    if(MessageBox.Show("This date doesn't Exist! Do you want to add this date?","Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("insert into att(fajr, zuhr, asar, maghrib, isha, date, Userid)Values(0, 0, 0, 0, 0, @date, @Userid) ", cn);
                        cm.Parameters.AddWithValue("@date", DateTime.Parse(dateTimePicker1.Value.ToShortDateString()));
                        cm.Parameters.AddWithValue("@Userid", frmMain.UserID.ToString());
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("New row added");
                        PrayerSave();
                        MessageBox.Show("Saved!");
                    }
                    this.Close();
                    frmMain.showdata();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmAdd_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("select * from att where date = @date and Userid = @Userid", cn);
            cm.Parameters.AddWithValue("@date", DateTime.Parse(dateTimePicker1.Value.ToShortDateString()));
            cm.Parameters.AddWithValue("@Userid", frmMain.UserID);
            dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    chkFajar.Checked = bool.Parse(dr[1].ToString());
                    chkZuhr.Checked = bool.Parse(dr[2].ToString());
                    chkAsar.Checked = bool.Parse(dr[3].ToString());
                    chkMaghrib.Checked = bool.Parse(dr[4].ToString());
                    chkIsha.Checked = bool.Parse(dr[5].ToString());
                }
            }
            else
            {
                chkFajar.Checked = false;
                chkZuhr.Checked = false;
                chkAsar.Checked = false;
                chkMaghrib.Checked = false;
                chkIsha.Checked = false;
            }
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
