using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACS_DEMO
{
    public partial class AppLayout : Form
    {
        public AppLayout()
        {
            InitializeComponent();
        }

        private void menubar_Click(object sender, EventArgs e)
        {
            if (menuStrip1.Visible)
                menuStrip1.Visible = false;
            else
                menuStrip1.Visible = true;
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            userform otherForm = new userform();
            otherForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
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

        /*DataTable temp;
        DataTable bank;*/
        private void AppLayout_Load(object sender, EventArgs e)
        {
            /*combotimkiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            combotimkiem.AutoCompleteSource = AutoCompleteSource.ListItems;

            temp = DbRdRw.SqlDbRead("Select * from BankMaster", "BankMaster");

            DataView dtview = new DataView(temp);
            dtview.Sort = "BankName DESC";
            bank = dtview.ToTable();

            combotimkiem.DataSource = bank;
            combotimkiem.ValueMember = "BankName";
            combotimkiem.DisplayMember = "BankName";*/
        }
    }
}
