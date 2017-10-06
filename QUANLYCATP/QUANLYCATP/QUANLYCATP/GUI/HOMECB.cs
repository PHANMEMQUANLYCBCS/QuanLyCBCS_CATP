using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QUANLYCATP.GUI;

namespace QUANLYCATP
{
    public partial class HOMECB : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public HOMECB()
        {
            InitializeComponent();
            //LoadTreeview();
        }

        Form CheckForm(Type fl)
        {
            foreach (var f in this.MdiChildren)
            {
                if (f.GetType() == fl)
                    return f;
            }
            return null;
        }

        //void LoadTreeview()
        //{
        //    TreeNode bch = new TreeNode();
        //    bch.Text = "BAN CHỈ HUY";
        //    bch.ImageIndex = 0;

        //    TreeNode ds1 = new TreeNode();
        //    {
        //        ds1.Text = "NGUYỄN QUỐC HÙNG";
        //    }
        //    bch.Nodes.Add(ds1);
        //    ds1.ImageIndex = 1;

        //    TreeNode dnv = new TreeNode();
        //    dnv.Text = "ĐỘI NGHIỆP VỤ";
        //    dnv.ImageIndex = 2;

        //    TreeNode th = new TreeNode();
        //    {
        //        th.Text = "ĐỘI TỔNG HỢP";
        //    }
        //    TreeNode dtth = new TreeNode();
        //    {
        //        dtth.Text = "ĐỘI ĐIỀU TRA TỔNG HỢP ";
        //    }
        //    TreeNode mt = new TreeNode();
        //    {
        //        mt.Text = "ĐỘI MA TÚY";
        //    }
        //    TreeNode hs = new TreeNode();
        //    {
        //        hs.Text = "ĐỘI HÌNH SỰ";
        //    }
        //    TreeNode qlhc = new TreeNode();
        //    {
        //        qlhc.Text = "ĐỘI QUẢN LÝ HÀNH CHÍNH";
        //    }
        //    TreeNode kt = new TreeNode();
        //    {
        //        kt.Text = "ĐỘI KINH TẾ";
        //    }
        //    TreeNode tt = new TreeNode();
        //    {
        //        tt.Text = "ĐỘI TRẬT TỰ";
        //    }
        //    TreeNode gt = new TreeNode();
        //    {
        //        gt.Text = "ĐỘI GIAO THÔNG";
        //    }
        //    TreeNode an = new TreeNode();
        //    {
        //        an.Text = "ĐỘI AN NINH";
        //    }
        //    TreeNode ptx = new TreeNode();
        //    {
        //        ptx.Text = "ĐỘI PHONG TRÀO XÃ";
        //    }
        //    TreeNode http = new TreeNode();
        //    {
        //        http.Text = "ĐỘI THI HÀNH ÁN VÀ HTTP";
        //    }

        //    dnv.Nodes.Add(th);
        //    dnv.Nodes.Add(dtth);
        //    dnv.Nodes.Add(mt);
        //    dnv.Nodes.Add(hs);
        //    dnv.Nodes.Add(qlhc);
        //    dnv.Nodes.Add(kt);
        //    dnv.Nodes.Add(tt);
        //    dnv.Nodes.Add(gt);
        //    dnv.Nodes.Add(an);
        //    dnv.Nodes.Add(ptx);
        //    dnv.Nodes.Add(http);
        //    th.ImageIndex = 3;
        //    dtth.ImageIndex = 3;
        //    mt.ImageIndex = 3;
        //    hs.ImageIndex = 3;
        //    qlhc.ImageIndex = 3;
        //    kt.ImageIndex = 3;
        //    tt.ImageIndex = 3;
        //    gt.ImageIndex = 3;
        //    an.ImageIndex = 3;
        //    ptx.ImageIndex = 3;
        //    http.ImageIndex = 3;

        //    TreeNode cap = new TreeNode();
        //    cap.Text = "CÔNG AN PHƯỜNG";
        //    TreeNode hht = new TreeNode();
        //    {
        //        hht.Text = "PHƯỜNG HÀ HUY TẬP";
        //    }
        //    TreeNode dn = new TreeNode();
        //    {
        //        dn.Text = "PHƯỜNG ĐẠI NÀI";
        //    }
        //    TreeNode vy = new TreeNode();
        //    {
        //        vy.Text = "PHƯỜNG VĂN YÊN";
        //    }
        //    TreeNode tp = new TreeNode();
        //    {
        //        tp.Text = "PHƯỜNG TRẦN PHÚ";
        //    }
        //    TreeNode nd = new TreeNode();
        //    {
        //        nd.Text = "PHƯỜNG NGUYỄN DU";
        //    }
        //    TreeNode tl = new TreeNode();
        //    {
        //        tl.Text = "PHƯỜNG THẠCH LINH";
        //    }
        //    TreeNode tg = new TreeNode();
        //    {
        //        tg.Text = "PHƯỜNG TÂN GIANG";
        //    }
        //    TreeNode tq = new TreeNode();
        //    {
        //        tq.Text = "PHƯỜNG THẠCH QUÝ";
        //    }
        //    TreeNode nh = new TreeNode();
        //    {
        //        nh.Text = "PHƯỜNG NAM HÀ";
        //    }
        //    TreeNode bh = new TreeNode();
        //    {
        //        bh.Text = "PHƯỜNG BẮC HÀ";
        //    }

        //    cap.Nodes.Add(hht);
        //    cap.Nodes.Add(dn);
        //    cap.Nodes.Add(vy);
        //    cap.Nodes.Add(tp);
        //    cap.Nodes.Add(nd);
        //    cap.Nodes.Add(tl);
        //    cap.Nodes.Add(tg);
        //    cap.Nodes.Add(tq);
        //    cap.Nodes.Add(nh);
        //    cap.Nodes.Add(bh);
        //    hht.ImageIndex = 3;
        //    dn.ImageIndex = 3;
        //    vy.ImageIndex = 3;
        //    tp.ImageIndex = 3;
        //    nd.ImageIndex = 3;
        //    tl.ImageIndex = 3;
        //    tg.ImageIndex = 3;
        //    tq.ImageIndex = 3;
        //    nh.ImageIndex = 3;
        //    bh.ImageIndex = 3;

        //    trvdanhsach.Nodes.Add(bch);
        //    trvdanhsach.Nodes.Add(dnv);
        //    trvdanhsach.Nodes.Add(cap);
        //}

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmCBCS();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void ribbonStatusBar_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void HOMECB_Load(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckForm(typeof(frmdanhsach));
            if (frm != null)
                frm.Activate();
            else
            {
                frmdanhsach fa = new frmdanhsach();
                fa.MdiParent = this;
                fa.Show();
            }
        }
    }
}