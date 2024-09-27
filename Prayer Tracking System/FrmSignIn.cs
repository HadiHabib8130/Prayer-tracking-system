using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prayer_Tracking_System
{
    public partial class FrmSignIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public FrmSignIn()
        {
            InitializeComponent();
            cn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\vs code\\Prayer Tracking System\\PTS db.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False";
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FrmSignUp frm = new FrmSignUp(this);
            this.Hide();
            frm.ShowDialog();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                string UserName = "", Password = "";
                bool pass = false;
                cn.Open();
                cm = new SqlCommand("Select * from tblUser", cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    UserName = dr["Username"].ToString();
                    Password = dr["Password"].ToString();
                    if (txtName.Text == UserName && txtPwd.Text == Password)
                    {
                        frmMain frm = new frmMain(dr["Username"].ToString(), int.Parse(dr[0].ToString()));
                        frm.Show();
                        pass = true;
                        break;
                    }


                }
                if (pass == false)
                {


                    MessageBox.Show("passwod or username incorrect", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
