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
    public partial class userform : Form
    {
        private readonly Form loadingForm = new Loading();

        public userform()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserLayout nextForm = new UserLayout();
            this.Hide();
            nextForm.Show();
            /* if (!this.ValidateChildren())
             {
                 return;
             }

             try
             {

                 this.btnLogin.Enabled = false;


                 this.loadingForm.Show();

                 AuthService.User = await this.userService.Login(this.txtUsername.Text, this.txtPassword.Text);

                 this.Hide();

                 this.loadingForm.Close();

                 new AppLayout().ShowDialog();

                 this.Close();

             }
             catch (AuthenticationException exception)
             {
                 this.loadingForm.Hide();
                 MessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             finally
             {
                 this.btnLogin.Enabled = true;
             }*/
        }

        /*kiểm tra email
        private void TxtUsername_Validating(object sender, CancelEventArgs e)
        {
            string email = this.txtEmail.Text;

            if (string.IsNullOrEmpty(email))
            {
                Validation.SetErrorTextBox(this.txtEmail, this.lblUsernameError, "Địa chỉ email không được để trống");
                e.Cancel = true;
                return;
            }

            if (!Validation.IsEmail(email))
            {
                Validation.SetErrorTextBox(this.txtEmail, this.lblUsernameError, "Địa chỉ email không hợp lệ");
                e.Cancel = true;
            }
        }*/
    }
}
