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

namespace DACS_DEMO
{
    public partial class AdminLayout : Form
    {
        public AdminLayout()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("data source=DESKTOP-EP2QMTE; database=DACS");

        private void btnmofile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Desktop";
            openFileDialog1.Title = "Chọn 1 file để mở";
            openFileDialog1.Filter = "Chọn file có đuôi hợp lệ(*.pdf)|*.pdf";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        axAcroPDF1.src = openFileDialog1.FileName;
                    }
                }
                else
                {
                    MessageBox.Show("Mở file không thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                if (filename == null)
                {
                    MessageBox.Show("Please select a valid document.");
                }
                else
                {
                    //we already define our connection globaly. We are just calling the object of connection.
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BAIBAODADICH (NOIDUNG)values('\\Document\\" + filename + "')", con);
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    System.IO.File.Copy(openFileDialog1.FileName, path + "\\Document\\" + filename);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Document uploaded.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
