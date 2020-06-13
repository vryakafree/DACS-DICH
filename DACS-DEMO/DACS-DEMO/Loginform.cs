using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using fmath;

namespace DACS_DEMO
{
    public partial class userform : Form
    {
        private readonly Form loading = new Loading();

        public userform()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.; Initital Catalog=DACS_DEMO;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from tb_user Where username='" + txtEmail.Text + "' and Password ='" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter sda1 = new SqlDataAdapter("Select Type from tb_user Where username='" + txtEmail.Text + "' and Password ='" + txtPassword.Text + "'", con);
                DataTable dt1 = new DataTable();
                sda.Fill(dt1);
                if (dt1.Rows[0][0].ToString() == "admin")
                {
                    this.Hide();
                    this.loading.Show();
                    AdminLayout ad = new AdminLayout();
                    this.loading.Close();
                    ad.Show();
                }
                if (dt1.Rows[0][0].ToString() == "user")
                {
                    this.Hide();
                    this.loading.Show();
                    UserLayout us = new UserLayout();
                    this.loading.Close();
                    us.Show();
                }
            }
        }
    }
}
