using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACS_DEMO
{
    public partial class AppLayout : Form
    {
        public AppLayout()
        {
            Page pge = new Page();
            pge.ShowDialog();
            InitializeComponent();
        }

        private void menubar_MouseEnter(object sender, EventArgs e)
        {

                menuStrip1.Visible = true;
        }

       /* private void menubar_MouseLeave(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
        }*/

        private void btnuser_Click(object sender, EventArgs e)
        {
            AdminLayout otherForm = new AdminLayout();
            otherForm.FormClosed += otherForm_FormClosed;
            this.Hide();
            otherForm.Show();
            //gọi thêm hàm check nút bấm để thay vì mở form đăng nhập thì mở qua form người dùng
            
        }

        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (combotimkiem.Visible)
                combotimkiem.Visible = false;
            else
                combotimkiem.Visible = true;
        }

        private void menuStrip1_MouseEnter(object sender, EventArgs e)
        {
            menuStrip1.Visible = true;
        }

        private void menuStrip1_MouseLeave(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Visible == true | toolStripComboBox2.Visible == true | toolStripComboBox3.Visible == true | toolStripComboBox4.Visible == true | toolStripComboBox5.Visible == true)
            {
                menuStrip1.Visible = true;
            }
            else
            {
                menuStrip1.Visible = false;
            }
        }

        private void AppLayout_Load(object sender, EventArgs e)
        {

        }
    }
}
