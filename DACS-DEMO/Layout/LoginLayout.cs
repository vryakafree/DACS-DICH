using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DACS_DEMO
{
    public partial class LoginLayout : Form
    {
        private readonly Form loading = new Loading();

        public LoginLayout()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-EP2QMTE\SQLEXPRESS;AttachDbFilename=C:\Do Not Delete\LoginApp\DB\LoginDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            string query = "Select * from tbl_Login Where username = '" + txtUsername.Text.Trim() + "' and password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                UserLayout FrmUser = new UserLayout();
                this.Hide();
                FrmUser.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Kiểm tra lại tài khoản hoặc mật khẩu của bạn");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
