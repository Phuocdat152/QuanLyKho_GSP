namespace GUI
{
    partial class QuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_XoaNV = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SuaNV = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemNV = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_SDT = new DevExpress.XtraEditors.LabelControl();
            this.lb_Email = new DevExpress.XtraEditors.LabelControl();
            this.lb_DiaChi = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_TrinhDo = new DevExpress.XtraEditors.LabelControl();
            this.lb_NgaySinh = new DevExpress.XtraEditors.LabelControl();
            this.lb_ChucVu = new DevExpress.XtraEditors.LabelControl();
            this.lb_TenND = new DevExpress.XtraEditors.LabelControl();
            this.lb_TenNV = new DevExpress.XtraEditors.LabelControl();
            this.lb_MaNV = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pb_AnhNV = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AnhNV)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl3);
            this.panel1.Controls.Add(this.groupControl2);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1406, 956);
            this.panel1.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dgv_NhanVien);
            this.groupControl3.Location = new System.Drawing.Point(3, 479);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1400, 474);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Danh Sách Nhân Viên";
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.AllowUserToResizeColumns = false;
            this.dgv_NhanVien.AllowUserToResizeRows = false;
            this.dgv_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.Username,
            this.ChucVu,
            this.TrinhDo,
            this.NgaySinh,
            this.DiaChi,
            this.Email,
            this.SoDienThoai});
            this.dgv_NhanVien.Location = new System.Drawing.Point(0, 29);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowHeadersWidth = 51;
            this.dgv_NhanVien.RowTemplate.Height = 24;
            this.dgv_NhanVien.Size = new System.Drawing.Size(1395, 445);
            this.dgv_NhanVien.TabIndex = 1;
            this.dgv_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellContentClick);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.HeaderText = "Tên Nhân Viên";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.HeaderText = "Tên Người Dùng";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // ChucVu
            // 
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            // 
            // TrinhDo
            // 
            this.TrinhDo.HeaderText = "Trình Độ";
            this.TrinhDo.MinimumWidth = 6;
            this.TrinhDo.Name = "TrinhDo";
            this.TrinhDo.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.simpleButton4);
            this.groupControl2.Controls.Add(this.btn_XoaNV);
            this.groupControl2.Controls.Add(this.btn_SuaNV);
            this.groupControl2.Controls.Add(this.btn_ThemNV);
            this.groupControl2.Location = new System.Drawing.Point(1072, 69);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(331, 404);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Chức Năng";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton4.Location = new System.Drawing.Point(28, 305);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(277, 66);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "Quản Trị Người Dùng";
            // 
            // btn_XoaNV
            // 
            this.btn_XoaNV.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaNV.Appearance.Options.UseFont = true;
            this.btn_XoaNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaNV.ImageOptions.Image")));
            this.btn_XoaNV.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_XoaNV.Location = new System.Drawing.Point(28, 221);
            this.btn_XoaNV.Name = "btn_XoaNV";
            this.btn_XoaNV.Size = new System.Drawing.Size(277, 66);
            this.btn_XoaNV.TabIndex = 2;
            this.btn_XoaNV.Text = "Xoá Nhân Viên";
            this.btn_XoaNV.Click += new System.EventHandler(this.btn_XoaNV_Click);
            // 
            // btn_SuaNV
            // 
            this.btn_SuaNV.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaNV.Appearance.Options.UseFont = true;
            this.btn_SuaNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaNV.ImageOptions.Image")));
            this.btn_SuaNV.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_SuaNV.Location = new System.Drawing.Point(28, 137);
            this.btn_SuaNV.Name = "btn_SuaNV";
            this.btn_SuaNV.Size = new System.Drawing.Size(277, 66);
            this.btn_SuaNV.TabIndex = 1;
            this.btn_SuaNV.Text = "Sửa Thông Tin";
            this.btn_SuaNV.Click += new System.EventHandler(this.btn_SuaNV_Click);
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNV.Appearance.Options.UseFont = true;
            this.btn_ThemNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemNV.ImageOptions.Image")));
            this.btn_ThemNV.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_ThemNV.Location = new System.Drawing.Point(28, 53);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(277, 66);
            this.btn_ThemNV.TabIndex = 0;
            this.btn_ThemNV.Text = "Thêm Nhân Viên";
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.pb_AnhNV);
            this.groupControl1.Location = new System.Drawing.Point(3, 69);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1063, 404);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông Tin Nhân Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_SDT);
            this.groupBox2.Controls.Add(this.lb_Email);
            this.groupBox2.Controls.Add(this.lb_DiaChi);
            this.groupBox2.Controls.Add(this.labelControl8);
            this.groupBox2.Controls.Add(this.labelControl10);
            this.groupBox2.Controls.Add(this.labelControl9);
            this.groupBox2.Location = new System.Drawing.Point(601, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 370);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Liên Hệ";
            // 
            // lb_SDT
            // 
            this.lb_SDT.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lb_SDT.Appearance.Options.UseFont = true;
            this.lb_SDT.Location = new System.Drawing.Point(159, 134);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(0, 28);
            this.lb_SDT.TabIndex = 17;
            // 
            // lb_Email
            // 
            this.lb_Email.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lb_Email.Appearance.Options.UseFont = true;
            this.lb_Email.Location = new System.Drawing.Point(159, 88);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(0, 28);
            this.lb_Email.TabIndex = 16;
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lb_DiaChi.Appearance.Options.UseFont = true;
            this.lb_DiaChi.Location = new System.Drawing.Point(159, 37);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(0, 28);
            this.lb_DiaChi.TabIndex = 15;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(6, 41);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 25);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Địa Chỉ:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(6, 137);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(114, 25);
            this.labelControl10.TabIndex = 8;
            this.labelControl10.Text = "Số Điện Thoại:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(6, 91);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(46, 25);
            this.labelControl9.TabIndex = 7;
            this.labelControl9.Text = "Email:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_TrinhDo);
            this.groupBox1.Controls.Add(this.lb_NgaySinh);
            this.groupBox1.Controls.Add(this.lb_ChucVu);
            this.groupBox1.Controls.Add(this.lb_TenND);
            this.groupBox1.Controls.Add(this.lb_TenNV);
            this.groupBox1.Controls.Add(this.lb_MaNV);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Location = new System.Drawing.Point(163, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 370);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // lb_TrinhDo
            // 
            this.lb_TrinhDo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lb_TrinhDo.Appearance.Options.UseFont = true;
            this.lb_TrinhDo.Location = new System.Drawing.Point(154, 261);
            this.lb_TrinhDo.Name = "lb_TrinhDo";
            this.lb_TrinhDo.Size = new System.Drawing.Size(0, 30);
            this.lb_TrinhDo.TabIndex = 14;
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lb_NgaySinh.Appearance.Options.UseFont = true;
            this.lb_NgaySinh.Location = new System.Drawing.Point(154, 212);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(0, 30);
            this.lb_NgaySinh.TabIndex = 13;
            // 
            // lb_ChucVu
            // 
            this.lb_ChucVu.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lb_ChucVu.Appearance.Options.UseFont = true;
            this.lb_ChucVu.Location = new System.Drawing.Point(154, 169);
            this.lb_ChucVu.Name = "lb_ChucVu";
            this.lb_ChucVu.Size = new System.Drawing.Size(0, 30);
            this.lb_ChucVu.TabIndex = 12;
            // 
            // lb_TenND
            // 
            this.lb_TenND.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lb_TenND.Appearance.Options.UseFont = true;
            this.lb_TenND.Location = new System.Drawing.Point(154, 125);
            this.lb_TenND.Name = "lb_TenND";
            this.lb_TenND.Size = new System.Drawing.Size(0, 30);
            this.lb_TenND.TabIndex = 11;
            // 
            // lb_TenNV
            // 
            this.lb_TenNV.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lb_TenNV.Appearance.Options.UseFont = true;
            this.lb_TenNV.Location = new System.Drawing.Point(154, 78);
            this.lb_TenNV.Name = "lb_TenNV";
            this.lb_TenNV.Size = new System.Drawing.Size(0, 30);
            this.lb_TenNV.TabIndex = 10;
            // 
            // lb_MaNV
            // 
            this.lb_MaNV.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lb_MaNV.Appearance.Options.UseFont = true;
            this.lb_MaNV.Location = new System.Drawing.Point(154, 37);
            this.lb_MaNV.Name = "lb_MaNV";
            this.lb_MaNV.Size = new System.Drawing.Size(0, 30);
            this.lb_MaNV.TabIndex = 9;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(7, 265);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(66, 25);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Trình Độ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(7, 217);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(85, 25);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Ngày Sinh:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(6, 125);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(134, 25);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Tên Người Dùng:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(7, 173);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 25);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Chức Vụ:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(6, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(118, 25);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Tên Nhân Viên:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(115, 25);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã Nhân Viên:";
            // 
            // pb_AnhNV
            // 
            this.pb_AnhNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_AnhNV.Image = ((System.Drawing.Image)(resources.GetObject("pb_AnhNV.Image")));
            this.pb_AnhNV.Location = new System.Drawing.Point(5, 31);
            this.pb_AnhNV.Name = "pb_AnhNV";
            this.pb_AnhNV.Size = new System.Drawing.Size(152, 168);
            this.pb_AnhNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_AnhNV.TabIndex = 0;
            this.pb_AnhNV.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1403, 63);
            this.panel2.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(584, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(263, 41);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Quản Lý Nhân Viên";
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 958);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuanLyNhanVien";
            this.Text = "QuanLyNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AnhNV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pb_AnhNV;
        private DevExpress.XtraEditors.SimpleButton btn_ThemNV;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton btn_XoaNV;
        private DevExpress.XtraEditors.SimpleButton btn_SuaNV;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl lb_TrinhDo;
        private DevExpress.XtraEditors.LabelControl lb_NgaySinh;
        private DevExpress.XtraEditors.LabelControl lb_ChucVu;
        private DevExpress.XtraEditors.LabelControl lb_TenND;
        private DevExpress.XtraEditors.LabelControl lb_TenNV;
        private DevExpress.XtraEditors.LabelControl lb_MaNV;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lb_SDT;
        private DevExpress.XtraEditors.LabelControl lb_Email;
        private DevExpress.XtraEditors.LabelControl lb_DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrinhDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
    }
}