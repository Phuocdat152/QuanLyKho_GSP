namespace GUI
{
    partial class PhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanQuyen));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_LuuPQ = new DevExpress.XtraEditors.SimpleButton();
            this.cb_ChucVu = new System.Windows.Forms.ComboBox();
            this.lb_TenNV = new DevExpress.XtraEditors.LabelControl();
            this.lb_TenND = new DevExpress.XtraEditors.LabelControl();
            this.lb_MaNV = new DevExpress.XtraEditors.LabelControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_LuuPQ);
            this.groupControl1.Controls.Add(this.cb_ChucVu);
            this.groupControl1.Controls.Add(this.lb_TenNV);
            this.groupControl1.Controls.Add(this.lb_TenND);
            this.groupControl1.Controls.Add(this.lb_MaNV);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Location = new System.Drawing.Point(1, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(368, 315);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Phân Quyền";
            // 
            // btn_LuuPQ
            // 
            this.btn_LuuPQ.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuPQ.Appearance.Options.UseFont = true;
            this.btn_LuuPQ.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_LuuPQ.ImageOptions.Image")));
            this.btn_LuuPQ.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_LuuPQ.Location = new System.Drawing.Point(113, 220);
            this.btn_LuuPQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_LuuPQ.Name = "btn_LuuPQ";
            this.btn_LuuPQ.Size = new System.Drawing.Size(128, 56);
            this.btn_LuuPQ.TabIndex = 22;
            this.btn_LuuPQ.Text = "Lưu";
            this.btn_LuuPQ.Click += new System.EventHandler(this.btn_LuuPQ_Click);
            // 
            // cb_ChucVu
            // 
            this.cb_ChucVu.FormattingEnabled = true;
            this.cb_ChucVu.Location = new System.Drawing.Point(182, 162);
            this.cb_ChucVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_ChucVu.Name = "cb_ChucVu";
            this.cb_ChucVu.Size = new System.Drawing.Size(109, 21);
            this.cb_ChucVu.TabIndex = 21;
            // 
            // lb_TenNV
            // 
            this.lb_TenNV.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lb_TenNV.Appearance.Options.UseFont = true;
            this.lb_TenNV.Location = new System.Drawing.Point(182, 120);
            this.lb_TenNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_TenNV.Name = "lb_TenNV";
            this.lb_TenNV.Size = new System.Drawing.Size(4, 21);
            this.lb_TenNV.TabIndex = 20;
            this.lb_TenNV.Text = ".";
            // 
            // lb_TenND
            // 
            this.lb_TenND.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lb_TenND.Appearance.Options.UseFont = true;
            this.lb_TenND.Location = new System.Drawing.Point(182, 84);
            this.lb_TenND.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_TenND.Name = "lb_TenND";
            this.lb_TenND.Size = new System.Drawing.Size(4, 21);
            this.lb_TenND.TabIndex = 19;
            this.lb_TenND.Text = ".";
            // 
            // lb_MaNV
            // 
            this.lb_MaNV.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lb_MaNV.Appearance.Options.UseFont = true;
            this.lb_MaNV.Location = new System.Drawing.Point(182, 50);
            this.lb_MaNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_MaNV.Name = "lb_MaNV";
            this.lb_MaNV.Size = new System.Drawing.Size(4, 21);
            this.lb_MaNV.TabIndex = 18;
            this.lb_MaNV.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Chức vụ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Họ và Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã Nhân Viên:";
            // 
            // PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 314);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân quyền";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_LuuPQ;
        private System.Windows.Forms.ComboBox cb_ChucVu;
        private DevExpress.XtraEditors.LabelControl lb_TenNV;
        private DevExpress.XtraEditors.LabelControl lb_TenND;
        private DevExpress.XtraEditors.LabelControl lb_MaNV;
    }
}