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
    public partial class Page : Form
    {
        public Page()
        {
            InitializeComponent();
        }


        private void Page_Load(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            Panel2.Width += 15;
            if (Panel2.Width >= 850)
            {
                timer1.Stop();
                this.Close();
            }
        }


    }
}
