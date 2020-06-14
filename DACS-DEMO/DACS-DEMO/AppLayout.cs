﻿using System;
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
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(4000);
            InitializeComponent();
            t.Abort();
        }

        public void StartForm()
        {
            Application.Run(new Page());
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
    }
}