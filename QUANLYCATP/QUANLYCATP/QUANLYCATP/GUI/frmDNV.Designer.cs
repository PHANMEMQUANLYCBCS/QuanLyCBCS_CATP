namespace QUANLYCATP.GUI
{
    partial class frmDNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(40, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(135, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Đội Nghiệp Vụ";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(181, 40);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(356, 26);
            this.textEdit2.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::QUANLYCATP.Properties.Resources.Folder_Add_icon;
            this.simpleButton2.Location = new System.Drawing.Point(25, 112);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(164, 37);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Lưu Và Thêm";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::QUANLYCATP.Properties.Resources.Save_icon;
            this.simpleButton3.Location = new System.Drawing.Point(232, 112);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(146, 37);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Lưu Và Đóng";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::QUANLYCATP.Properties.Resources.Actions_window_close_icon1;
            this.simpleButton1.Location = new System.Drawing.Point(416, 112);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(146, 37);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Hủy Bỏ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmDNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 181);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDNV";
            this.Text = "ĐỘI NGHIỆP VỤ";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}