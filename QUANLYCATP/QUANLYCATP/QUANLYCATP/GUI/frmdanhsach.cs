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

namespace QUANLYCATP.GUI
{
    public partial class frmdanhsach : DevExpress.XtraEditors.XtraForm
    {
        public frmdanhsach()
        {
            InitializeComponent();
        }

        private void frmdanhsach_Load(object sender, EventArgs e)
        {

        }

        private void btnThemCH_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnThemCBCS_Click(object sender, EventArgs e)
        {
            frmCBCS_CATP cb = new frmCBCS_CATP();
            cb.Show();
        }
    }
}