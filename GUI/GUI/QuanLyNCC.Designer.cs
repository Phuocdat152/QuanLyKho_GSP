namespace GUI
{
    partial class QuanLyNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyNCC));
            this.GroupView1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_SuaNCC = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemNCC = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.lb_TenNCC = new System.Windows.Forms.Label();
            this.lb_MaNCC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_DanhSach = new System.Windows.Forms.DataGridView();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.GroupView1)).BeginInit();
            this.GroupView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupView1
            // 
            this.GroupView1.Controls.Add(this.btn_SuaNCC);
            this.GroupView1.Controls.Add(this.btn_ThemNCC);
            this.GroupView1.Location = new System.Drawing.Point(1414, 349);
            this.GroupView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupView1.Name = "GroupView1";
            this.GroupView1.Size = new System.Drawing.Size(297, 248);
            this.GroupView1.TabIndex = 2;
            this.GroupView1.Text = "Chức Năng";
            // 
            // btn_SuaNCC
            // 
            this.btn_SuaNCC.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaNCC.Appearance.Options.UseFont = true;
            this.btn_SuaNCC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaNCC.ImageOptions.Image")));
            this.btn_SuaNCC.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_SuaNCC.Location = new System.Drawing.Point(67, 126);
            this.btn_SuaNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SuaNCC.Name = "btn_SuaNCC";
            this.btn_SuaNCC.Size = new System.Drawing.Size(186, 67);
            this.btn_SuaNCC.TabIndex = 1;
            this.btn_SuaNCC.Text = "Sửa Thông Tin";
            this.btn_SuaNCC.Click += new System.EventHandler(this.btn_SuaNCC_Click);
            // 
            // btn_ThemNCC
            // 
            this.btn_ThemNCC.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNCC.Appearance.Options.UseFont = true;
            this.btn_ThemNCC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemNCC.ImageOptions.Image")));
            this.btn_ThemNCC.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_ThemNCC.Location = new System.Drawing.Point(67, 47);
            this.btn_ThemNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ThemNCC.Name = "btn_ThemNCC";
            this.btn_ThemNCC.Size = new System.Drawing.Size(186, 67);
            this.btn_ThemNCC.TabIndex = 0;
            this.btn_ThemNCC.Text = "Thêm";
            this.btn_ThemNCC.Click += new System.EventHandler(this.btn_ThemNCC_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lb_Email);
            this.groupControl2.Controls.Add(this.lb_DiaChi);
            this.groupControl2.Controls.Add(this.lb_SDT);
            this.groupControl2.Controls.Add(this.lb_TenNCC);
            this.groupControl2.Controls.Add(this.lb_MaNCC);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Location = new System.Drawing.Point(1414, 11);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(301, 332);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thông Tin";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(126, 237);
            this.lb_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(40, 21);
            this.lb_Email.TabIndex = 9;
            this.lb_Email.Text = "Info";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DiaChi.Location = new System.Drawing.Point(126, 185);
            this.lb_DiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(40, 21);
            this.lb_DiaChi.TabIndex = 8;
            this.lb_DiaChi.Text = "Info";
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SDT.Location = new System.Drawing.Point(126, 137);
            this.lb_SDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(40, 21);
            this.lb_SDT.TabIndex = 7;
            this.lb_SDT.Text = "Info";
            // 
            // lb_TenNCC
            // 
            this.lb_TenNCC.AutoSize = true;
            this.lb_TenNCC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenNCC.Location = new System.Drawing.Point(126, 90);
            this.lb_TenNCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TenNCC.Name = "lb_TenNCC";
            this.lb_TenNCC.Size = new System.Drawing.Size(40, 21);
            this.lb_TenNCC.TabIndex = 6;
            this.lb_TenNCC.Text = "Info";
            // 
            // lb_MaNCC
            // 
            this.lb_MaNCC.AutoSize = true;
            this.lb_MaNCC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaNCC.Location = new System.Drawing.Point(126, 46);
            this.lb_MaNCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MaNCC.Name = "lb_MaNCC";
            this.lb_MaNCC.Size = new System.Drawing.Size(40, 21);
            this.lb_MaNCC.TabIndex = 5;
            this.lb_MaNCC.Text = "Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Điện Thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhà Cung Cấp:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgv_DanhSach);
            this.groupControl1.Location = new System.Drawing.Point(862, 11);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(547, 585);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // dgv_DanhSach
            // 
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSach.Location = new System.Drawing.Point(4, 25);
            this.dgv_DanhSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_DanhSach.Name = "dgv_DanhSach";
            this.dgv_DanhSach.RowHeadersWidth = 51;
            this.dgv_DanhSach.RowTemplate.Height = 24;
            this.dgv_DanhSach.Size = new System.Drawing.Size(539, 556);
            this.dgv_DanhSach.TabIndex = 0;
            this.dgv_DanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSach_CellClick);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(138, 108);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(200, 100);
            this.splitContainerControl1.TabIndex = 3;
            // 
            // QuanLyNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1785, 596);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.GroupView1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QuanLyNCC";
            this.Text = "Quản Lý Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.QuanLyNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupView1)).EndInit();
            this.GroupView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl GroupView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private DevExpress.XtraEditors.SimpleButton btn_SuaNCC;
        private DevExpress.XtraEditors.SimpleButton btn_ThemNCC;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.Label lb_TenNCC;
        private System.Windows.Forms.Label lb_MaNCC;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}