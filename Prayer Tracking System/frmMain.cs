using System;
using System.Data.SqlClient;
using System.Media;
using System.Windows.Forms;

namespace Prayer_Tracking_System
{
    public partial class frmMain : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public int UserID = 0;
        public DateTime alrmFajr,alrmZuhr,alrmAsar,alrmMaghrib,alrmIsha;
        public SoundPlayer player = new SoundPlayer();


        public frmMain(string UserName, int UserId)
        {
            InitializeComponent();
            lblUsername.Text = UserName;
            this.UserID = UserId;


            cn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\vs code\\Prayer Tracking System\\PTS db.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False";
            AddRow();
            showdata();
        }
        private void AddRow()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("select date from att", cn);
                dr = cm.ExecuteReader();
                DateTime dt = DateTime.Parse(DateTime.Now.ToShortDateString());
                if (dr.HasRows)
                {

                    dr.Close();
                    cm = new SqlCommand("if not exists(select date,user from att where date = @date and Userid = @Userid) insert into att(fajr, zuhr, asar, maghrib, isha, date, Userid)Values(0, 0, 0, 0, 0, @date," +UserID.ToString()+ ") else print N'This date exists'", cn);
                    cm.Parameters.AddWithValue("@date", dt);
                    cm.Parameters.AddWithValue("@Userid", UserID.ToString());
                    cm.ExecuteNonQuery();
                    cn.Close();

                }
                else
                {
                    dr.Close();
                    cm = new SqlCommand("insert into att(fajr, zuhr, asar, maghrib, isha, date, Userid)Values(0, 0, 0, 0, 0, @date, @Userid) ", cn);
                    cm.Parameters.AddWithValue("@date", dt);
                    cm.Parameters.AddWithValue("@Userid", UserID.ToString());
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("New row added");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }
        public void showdata()
        {
            int i = 0;
            DateTime date = DateTime.Now;
            dataGridView1.Rows.Clear();

            cn.Open();
            cm = new SqlCommand("select * from att where Userid like "+UserID+" order by date", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                date = DateTime.Parse(dr[6].ToString());
                dataGridView1.Rows.Add(i, date.ToString("dd/MM/yyyy"), dr[0].ToString(), dr[1], dr[2], dr[3], dr[4], dr[5]);

            }

            cn.Close();




        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmAdd frm = new frmAdd(this);
            frm.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if(colName == "Delete")
            {
                if(MessageBox.Show("Confirm Dlete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cn.Open();
                        cm = new SqlCommand("delete from att where id like '" + dataGridView1[2, e.RowIndex].Value.ToString()+"'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        
                        MessageBox.Show("Dleted");
                        showdata();

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSetAlram  frm = new frmSetAlram(this);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport(UserID);
            report.Show();

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Current = DateTime.Now;
            
            if(Current.Hour == alrmFajr.Hour && Current.Minute == alrmFajr.Minute && Current.Second == alrmFajr.Second)
            {
                timer1.Stop();
                frmAlarm frmAlarm = new frmAlarm(this);
                frmAlarm.label1.Text = "Fajar Time";
                frmAlarm.Show();
                player.SoundLocation = @"D:\vs\y2mate.com - Popular Alarm Clock Sound Effect.wav";
                player.PlayLooping();
            }
            else if (Current.Hour == alrmZuhr.Hour && Current.Minute == alrmZuhr.Minute && Current.Second == alrmZuhr.Second)
            {
                timer1.Stop();
                frmAlarm frmAlarm = new frmAlarm(this);
                frmAlarm.label1.Text = "Zuhr Time";
                frmAlarm.Show();
                player.SoundLocation = @"D:\vs\y2mate.com - Popular Alarm Clock Sound Effect.wav";
                player.PlayLooping();
            }
            if (Current.Hour == alrmAsar.Hour && Current.Minute == alrmAsar.Minute && Current.Second == alrmAsar.Second)
            {
                timer1.Stop();
                frmAlarm frmAlarm = new frmAlarm(this);
                frmAlarm.label1.Text = "Asar Time";
                frmAlarm.Show();
                player.SoundLocation = @"D:\vs\y2mate.com - Popular Alarm Clock Sound Effect.wav";
                player.PlayLooping();
            }
            if (Current.Hour == alrmMaghrib.Hour && Current.Minute == alrmMaghrib.Minute && Current.Second == alrmMaghrib.Second)
            {
                timer1.Stop();
                frmAlarm frmAlarm = new frmAlarm(this);
                frmAlarm.label1.Text = "Maghrib Time";
                frmAlarm.Show();
                player.SoundLocation = @"D:\vs\y2mate.com - Popular Alarm Clock Sound Effect.wav";
                player.PlayLooping();
            }
            if (Current.Hour == alrmIsha.Hour && Current.Minute == alrmIsha.Minute && Current.Second == alrmIsha.Second)
            {
                timer1.Stop();
                frmAlarm frmAlarm = new frmAlarm(this);
                frmAlarm.label1.Text = "Isha Time";
                frmAlarm.Show();
                player.SoundLocation = @"D:\vs\y2mate.com - Popular Alarm Clock Sound Effect.wav";
                player.PlayLooping();
            }
        }
    }
}
