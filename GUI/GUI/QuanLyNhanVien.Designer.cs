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
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pb_AnhNV = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lb_MaNV = new DevExpress.XtraEditors.LabelControl();
            this.lb_TenNV = new DevExpress.XtraEditors.LabelControl();
            this.lb_TenND = new DevExpress.XtraEditors.LabelControl();
            this.lb_ChucVu = new DevExpress.XtraEditors.LabelControl();
            this.lb_NgaySinh = new DevExpress.XtraEditors.LabelControl();
            this.lb_TrinhDo = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lb_DiaChi = new DevExpress.XtraEditors.LabelControl();
            this.lb_Email = new DevExpress.XtraEditors.LabelControl();
            this.lb_SDT = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_ThemNV = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_XoaNV = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_SuaNV = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AnhNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).BeginInit();
            this.splitContainerControl2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).BeginInit();
            this.splitContainerControl2.Panel2.SuspendLayout();
            this.splitContainerControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dgv_NhanVien);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1112, 350);
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
            this.dgv_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_NhanVien.Location = new System.Drawing.Point(2, 23);
            this.dgv_NhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowHeadersWidth = 51;
            this.dgv_NhanVien.RowTemplate.Height = 24;
            this.dgv_NhanVien.Size = new System.Drawing.Size(1108, 325);
            this.dgv_NhanVien.TabIndex = 1;
            this.dgv_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellContentClick);
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // TrinhDo
            // 
            this.TrinhDo.HeaderText = "Trình Độ";
            this.TrinhDo.MinimumWidth = 6;
            this.TrinhDo.Name = "TrinhDo";
            this.TrinhDo.ReadOnly = true;
            // 
            // ChucVu
            // 
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.HeaderText = "Tên Người Dùng";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.HeaderText = "Tên Nhân Viên";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            // 
            // pb_AnhNV
            // 
            this.pb_AnhNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_AnhNV.Image = ((System.Drawing.Image)(resources.GetObject("pb_AnhNV.Image")));
            this.pb_AnhNV.Location = new System.Drawing.Point(4, 39);
            this.pb_AnhNV.Margin = new System.Windows.Forms.Padding(2);
            this.pb_AnhNV.Name = "pb_AnhNV";
            this.pb_AnhNV.Size = new System.Drawing.Size(233, 317);
            this.pb_AnhNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_AnhNV.TabIndex = 0;
            this.pb_AnhNV.TabStop = false;
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
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(262, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(381, 317);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(27, 43);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã Nhân Viên:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(27, 92);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 19);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Tên Nhân Viên:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(27, 131);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 20);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Chức Vụ:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(242, 279);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(112, 20);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Tên Người Dùng:";
            this.labelControl5.Visible = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(27, 180);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(65, 19);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Ngày Sinh:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(27, 223);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(56, 20);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Trình Độ";
            // 
            // lb_MaNV
            // 
            this.lb_MaNV.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lb_MaNV.Appearance.Options.UseFont = true;
            this.lb_MaNV.Location = new System.Drawing.Point(139, 41);
            this.lb_MaNV.Margin = new System.Windows.Forms.Padding(2);
            this.lb_MaNV.Name = "lb_MaNV";
            this.lb_MaNV.Size = new System.Drawing.Size(0, 23);
            this.lb_MaNV.TabIndex = 9;
            // 
            // lb_TenNV
            // 
            this.lb_TenNV.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lb_TenNV.Appearance.Options.UseFont = true;
            this.lb_TenNV.Location = new System.Drawing.Point(139, 88);
            this.lb_TenNV.Margin = new System.Windows.Forms.Padding(2);
            this.lb_TenNV.Name = "lb_TenNV";
            this.lb_TenNV.Size = new System.Drawing.Size(0, 23);
            this.lb_TenNV.TabIndex = 10;
            // 
            // lb_TenND
            // 
            this.lb_TenND.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lb_TenND.Appearance.Options.UseFont = true;
            this.lb_TenND.Location = new System.Drawing.Point(354, 279);
            this.lb_TenND.Margin = new System.Windows.Forms.Padding(2);
            this.lb_TenND.Name = "lb_TenND";
            this.lb_TenND.Size = new System.Drawing.Size(0, 23);
            this.lb_TenND.TabIndex = 11;
            this.lb_TenND.Visible = false;
            // 
            // lb_ChucVu
            // 
            this.lb_ChucVu.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lb_ChucVu.Appearance.Options.UseFont = true;
            this.lb_ChucVu.Location = new System.Drawing.Point(138, 127);
            this.lb_ChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.lb_ChucVu.Name = "lb_ChucVu";
            this.lb_ChucVu.Size = new System.Drawing.Size(0, 23);
            this.lb_ChucVu.TabIndex = 12;
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lb_NgaySinh.Appearance.Options.UseFont = true;
            this.lb_NgaySinh.Location = new System.Drawing.Point(138, 176);
            this.lb_NgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(0, 23);
            this.lb_NgaySinh.TabIndex = 13;
            // 
            // lb_TrinhDo
            // 
            this.lb_TrinhDo.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lb_TrinhDo.Appearance.Options.UseFont = true;
            this.lb_TrinhDo.Location = new System.Drawing.Point(138, 220);
            this.lb_TrinhDo.Margin = new System.Windows.Forms.Padding(2);
            this.lb_TrinhDo.Name = "lb_TrinhDo";
            this.lb_TrinhDo.Size = new System.Drawing.Size(0, 23);
            this.lb_TrinhDo.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_SDT);
            this.groupBox2.Controls.Add(this.lb_Email);
            this.groupBox2.Controls.Add(this.lb_DiaChi);
            this.groupBox2.Controls.Add(this.labelControl8);
            this.groupBox2.Controls.Add(this.labelControl10);
            this.groupBox2.Controls.Add(this.labelControl9);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(700, 39);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(345, 317);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Liên Hệ";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(28, 83);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(35, 19);
            this.labelControl9.TabIndex = 7;
            this.labelControl9.Text = "Email:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(28, 120);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(96, 20);
            this.labelControl10.TabIndex = 8;
            this.labelControl10.Text = "Số Điện Thoại:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(28, 42);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(51, 20);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Địa Chỉ:";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lb_DiaChi.Appearance.Options.UseFont = true;
            this.lb_DiaChi.Location = new System.Drawing.Point(143, 39);
            this.lb_DiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(0, 21);
            this.lb_DiaChi.TabIndex = 15;
            // 
            // lb_Email
            // 
            this.lb_Email.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lb_Email.Appearance.Options.UseFont = true;
            this.lb_Email.Location = new System.Drawing.Point(143, 81);
            this.lb_Email.Margin = new System.Windows.Forms.Padding(2);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(0, 21);
            this.lb_Email.TabIndex = 16;
            // 
            // lb_SDT
            // 
            this.lb_SDT.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lb_SDT.Appearance.Options.UseFont = true;
            this.lb_SDT.Location = new System.Drawing.Point(143, 118);
            this.lb_SDT.Margin = new System.Windows.Forms.Padding(2);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(0, 21);
            this.lb_SDT.TabIndex = 17;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.pb_AnhNV);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1112, 376);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông Tin Nhân Viên";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl3);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1112, 778);
            this.splitContainerControl1.SplitterPosition = 418;
            this.splitContainerControl1.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ThemNV,
            this.toolStripSeparator1,
            this.btn_XoaNV,
            this.toolStripSeparator3,
            this.btn_SuaNV});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1112, 32);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemNV.Image")));
            this.btn_ThemNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(61, 29);
            this.btn_ThemNV.Text = "Thêm";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // btn_XoaNV
            // 
            this.btn_XoaNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaNV.Image")));
            this.btn_XoaNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_XoaNV.Name = "btn_XoaNV";
            this.btn_XoaNV.Size = new System.Drawing.Size(51, 29);
            this.btn_XoaNV.Text = "Xóa";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // btn_SuaNV
            // 
            this.btn_SuaNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaNV.Image")));
            this.btn_SuaNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SuaNV.Name = "btn_SuaNV";
            this.btn_SuaNV.Size = new System.Drawing.Size(79, 29);
            this.btn_SuaNV.Text = "Cập nhật";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            // 
            // splitContainerControl2.Panel1
            // 
            this.splitContainerControl2.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // splitContainerControl2.Panel2
            // 
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1112, 418);
            this.splitContainerControl2.SplitterPosition = 32;
            this.splitContainerControl2.TabIndex = 0;
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 778);
            this.Controls.Add(this.splitContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuanLyNhanVien";
            this.Text = "Quản lý nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AnhNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).EndInit();
            this.splitContainerControl2.Panel1.ResumeLayout(false);
            this.splitContainerControl2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).EndInit();
            this.splitContainerControl2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrinhDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl lb_SDT;
        private DevExpress.XtraEditors.LabelControl lb_Email;
        private DevExpress.XtraEditors.LabelControl lb_DiaChi;
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
        private System.Windows.Forms.PictureBox pb_AnhNV;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_ThemNV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_XoaNV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_SuaNV;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
    }
}