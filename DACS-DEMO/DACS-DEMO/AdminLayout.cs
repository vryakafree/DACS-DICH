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
    public partial class AdminLayout : Form
    {
        public AdminLayout()
        {
            InitializeComponent();
        }

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

        }
    }
}
