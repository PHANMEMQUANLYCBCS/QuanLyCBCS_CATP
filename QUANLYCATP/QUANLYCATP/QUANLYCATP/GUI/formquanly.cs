using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QUANLYCATP
{
    public partial class formquanly : DevExpress.XtraEditors.XtraForm
    {
        public formquanly()
        {
            InitializeComponent();
        }

        private void imageSlider1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            HOMECB f = new HOMECB();
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public int i = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblbaner.Left += i;
            if (lblbaner.Left >= this.Width - lblbaner.Width || lblbaner.Left <= 0) ;
            i = -i;
        }
    }
}