namespace GUI
{
    partial class QLDanhMucThuoc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btn_XoaDM = new System.Windows.Forms.Button();
            this.btn_SuaDM = new System.Windows.Forms.Button();
            this.btn_ThemDM = new System.Windows.Forms.Button();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_DanhMucThuoc = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lb_TenDM = new DevExpress.XtraEditors.LabelControl();
            this.lb_MaDM = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMucThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl3);
            this.panel1.Controls.Add(this.groupControl2);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 720);
            this.panel1.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.Controls.Add(this.btn_XoaDM);
            this.groupControl3.Controls.Add(this.btn_SuaDM);
            this.groupControl3.Controls.Add(this.btn_ThemDM);
            this.groupControl3.Location = new System.Drawing.Point(536, 62);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(339, 251);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Quản Lý Danh Mục";
            // 
            // btn_XoaDM
            // 
            this.btn_XoaDM.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaDM.Location = new System.Drawing.Point(30, 183);
            this.btn_XoaDM.Name = "btn_XoaDM";
            this.btn_XoaDM.Size = new System.Drawing.Size(289, 53);
            this.btn_XoaDM.TabIndex = 2;
            this.btn_XoaDM.Text = "Xoá Danh Mục";
            this.btn_XoaDM.UseVisualStyleBackColor = true;
            this.btn_XoaDM.Click += new System.EventHandler(this.btn_XoaDM_Click);
            // 
            // btn_SuaDM
            // 
            this.btn_SuaDM.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaDM.Location = new System.Drawing.Point(30, 113);
            this.btn_SuaDM.Name = "btn_SuaDM";
            this.btn_SuaDM.Size = new System.Drawing.Size(289, 53);
            this.btn_SuaDM.TabIndex = 1;
            this.btn_SuaDM.Text = "Sửa Danh Mục";
            this.btn_SuaDM.UseVisualStyleBackColor = true;
            this.btn_SuaDM.Click += new System.EventHandler(this.btn_SuaDM_Click);
            // 
            // btn_ThemDM
            // 
            this.btn_ThemDM.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemDM.Location = new System.Drawing.Point(30, 46);
            this.btn_ThemDM.Name = "btn_ThemDM";
            this.btn_ThemDM.Size = new System.Drawing.Size(289, 53);
            this.btn_ThemDM.TabIndex = 0;
            this.btn_ThemDM.Text = "Thêm Danh Mục";
            this.btn_ThemDM.UseVisualStyleBackColor = true;
            this.btn_ThemDM.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgv_DanhMucThuoc);
            this.groupControl2.Location = new System.Drawing.Point(3, 319);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(875, 401);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Danh Sách Danh Mục Thuốc";
            // 
            // dgv_DanhMucThuoc
            // 
            this.dgv_DanhMucThuoc.AllowUserToResizeColumns = false;
            this.dgv_DanhMucThuoc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgv_DanhMucThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhMucThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhMucThuoc.Location = new System.Drawing.Point(5, 31);
            this.dgv_DanhMucThuoc.Name = "dgv_DanhMucThuoc";
            this.dgv_DanhMucThuoc.RowHeadersWidth = 51;
            this.dgv_DanhMucThuoc.RowTemplate.Height = 24;
            this.dgv_DanhMucThuoc.Size = new System.Drawing.Size(865, 367);
            this.dgv_DanhMucThuoc.TabIndex = 0;
            this.dgv_DanhMucThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhMucThuoc_CellClick);
            this.dgv_DanhMucThuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhMucThuoc_CellContentClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.lb_TenDM);
            this.groupControl1.Controls.Add(this.lb_MaDM);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(3, 62);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(527, 251);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông Tin Danh Mục";
            // 
            // lb_TenDM
            // 
            this.lb_TenDM.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenDM.Appearance.Options.UseFont = true;
            this.lb_TenDM.Location = new System.Drawing.Point(194, 119);
            this.lb_TenDM.Name = "lb_TenDM";
            this.lb_TenDM.Size = new System.Drawing.Size(145, 31);
            this.lb_TenDM.TabIndex = 4;
            this.lb_TenDM.Text = "Mã Danh Mục";
            // 
            // lb_MaDM
            // 
            this.lb_MaDM.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaDM.Appearance.Options.UseFont = true;
            this.lb_MaDM.Location = new System.Drawing.Point(194, 56);
            this.lb_MaDM.Name = "lb_MaDM";
            this.lb_MaDM.Size = new System.Drawing.Size(145, 31);
            this.lb_MaDM.TabIndex = 3;
            this.lb_MaDM.Text = "Mã Danh Mục";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(37, 121);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(127, 28);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tên Danh Mục:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(37, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(126, 28);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã Danh Mục:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 62);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(878, 661);
            this.panel3.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(254, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(353, 41);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Quản Lý Danh Mục Thuốc";
            // 
            // QLDanhMucThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 719);
            this.Controls.Add(this.panel1);
            this.Name = "QLDanhMucThuoc";
            this.Text = "QLDanhMucThuoc";
            this.Load += new System.EventHandler(this.QLDanhMucThuoc_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMucThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button btn_ThemDM;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button btn_XoaDM;
        private System.Windows.Forms.Button btn_SuaDM;
        private System.Windows.Forms.DataGridView dgv_DanhMucThuoc;
        private DevExpress.XtraEditors.LabelControl lb_TenDM;
        private DevExpress.XtraEditors.LabelControl lb_MaDM;
    }
}