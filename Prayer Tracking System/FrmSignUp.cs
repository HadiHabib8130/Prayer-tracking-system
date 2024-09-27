using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prayer_Tracking_System
{
    public partial class FrmSignUp : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        FrmSignIn frmS;
        public FrmSignUp(FrmSignIn frms)
        {
            InitializeComponent();
            cn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\vs code\\Prayer Tracking System\\PTS db.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False";
            this.frmS = frms;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtPwd.Text == txtC_Pwd.Text)
            {
                try
                {

                    cn.Open();
                    cm = new SqlCommand("insert into tblUser(Username,Password,Email)Values(@Username,@Password,@Email) ", cn);

                    cm.Parameters.AddWithValue("@Username", txtName.Text);
                    cm.Parameters.AddWithValue("@Password", txtPwd.Text);
                    cm.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cm.ExecuteNonQuery();

                    cn.Close();
                    MessageBox.Show("saved!");
                    this.Dispose();
                    DialogResult dialogResult = frmS.ShowDialog();
                }



                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Password Doesn't Match", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPwd.Text = null;
                txtC_Pwd.Text = null;
                txtPwd.Select();
                
            }

        }

        private void FrmSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
