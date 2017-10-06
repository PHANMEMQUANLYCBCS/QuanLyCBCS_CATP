using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYCATP
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            formquanly f = new formquanly();
            f.Show();
            this.Hide();


        }

        private void btnhuy_Click(object sender, EventArgs e)
        {

        }
    }
}
