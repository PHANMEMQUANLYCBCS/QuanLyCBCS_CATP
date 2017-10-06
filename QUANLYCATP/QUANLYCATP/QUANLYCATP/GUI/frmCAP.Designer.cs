namespace QUANLYCATP.GUI
{
    partial class frmCAP
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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(54, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(154, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Công An Phường";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(229, 35);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(373, 26);
            this.textEdit1.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::QUANLYCATP.Properties.Resources.Folder_Add_icon;
            this.simpleButton2.Location = new System.Drawing.Point(68, 104);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(164, 37);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Lưu Và Thêm";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::QUANLYCATP.Properties.Resources.Save_icon;
            this.simpleButton3.Location = new System.Drawing.Point(275, 104);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(146, 37);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Lưu Và Đóng";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::QUANLYCATP.Properties.Resources.Actions_window_close_icon1;
            this.simpleButton1.Location = new System.Drawing.Point(459, 104);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(146, 37);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Hủy Bỏ";
            // 
            // frmCAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 173);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCAP";
            this.Text = "Công An Phường";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}