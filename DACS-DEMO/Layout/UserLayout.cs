using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DACS_DEMO
{
    public partial class UserLayout : Form
    {
        public UserLayout()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);
        private void btnedit_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("C:/Users/Hang/Source/Repos/DACS-DICH/DACS-DEMO/DACS-DEMO/3rdApps/texstudio/texstudio.exe"); //thay lai duong dan ben anh de mo LaTeX
            Thread.Sleep(500);
            p.WaitForInputIdle();
            SetParent(p.MainWindowHandle, this.Handle);
        }
    }
}
