namespace GUI
{
    partial class SuaThongTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaThongTin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_upTaiAnh = new System.Windows.Forms.Button();
            this.pb_Anh = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_upSDT = new System.Windows.Forms.TextBox();
            this.txt_upDiaChi = new System.Windows.Forms.TextBox();
            this.txt_upEmail = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_upTrinhDo = new System.Windows.Forms.TextBox();
            this.dtp_upNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cb_upchucvu = new System.Windows.Forms.ComboBox();
            this.txt_upTen = new System.Windows.Forms.TextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btn_LuuTD = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Anh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_LuuTD);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 667);
            this.panel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Location = new System.Drawing.Point(3, 58);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(886, 491);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông Tin Nhân Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_upTaiAnh);
            this.groupBox2.Controls.Add(this.pb_Anh);
            this.groupBox2.Location = new System.Drawing.Point(564, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 460);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ảnh Nhân Viên";
            // 
            // btn_upTaiAnh
            // 
            this.btn_upTaiAnh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upTaiAnh.Location = new System.Drawing.Point(90, 337);
            this.btn_upTaiAnh.Name = "btn_upTaiAnh";
            this.btn_upTaiAnh.Size = new System.Drawing.Size(124, 61);
            this.btn_upTaiAnh.TabIndex = 1;
            this.btn_upTaiAnh.Text = "Tải Ảnh Lên";
            this.btn_upTaiAnh.UseVisualStyleBackColor = true;
            this.btn_upTaiAnh.Click += new System.EventHandler(this.btn_upTaiAnh_Click);
            // 
            // pb_Anh
            // 
            this.pb_Anh.Image = ((System.Drawing.Image)(resources.GetObject("pb_Anh.Image")));
            this.pb_Anh.Location = new System.Drawing.Point(46, 45);
            this.pb_Anh.Name = "pb_Anh";
            this.pb_Anh.Size = new System.Drawing.Size(223, 238);
            this.pb_Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Anh.TabIndex = 0;
            this.pb_Anh.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_upSDT);
            this.groupBox1.Controls.Add(this.txt_upDiaChi);
            this.groupBox1.Controls.Add(this.txt_upEmail);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txt_upTrinhDo);
            this.groupBox1.Controls.Add(this.dtp_upNgaySinh);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.cb_upchucvu);
            this.groupBox1.Controls.Add(this.txt_upTen);
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Cá Nhân";
            // 
            // txt_upSDT
            // 
            this.txt_upSDT.Location = new System.Drawing.Point(196, 355);
            this.txt_upSDT.Name = "txt_upSDT";
            this.txt_upSDT.Size = new System.Drawing.Size(244, 23);
            this.txt_upSDT.TabIndex = 60;
            // 
            // txt_upDiaChi
            // 
            this.txt_upDiaChi.Location = new System.Drawing.Point(196, 300);
            this.txt_upDiaChi.Name = "txt_upDiaChi";
            this.txt_upDiaChi.Size = new System.Drawing.Size(244, 23);
            this.txt_upDiaChi.TabIndex = 59;
            // 
            // txt_upEmail
            // 
            this.txt_upEmail.Location = new System.Drawing.Point(196, 248);
            this.txt_upEmail.Name = "txt_upEmail";
            this.txt_upEmail.Size = new System.Drawing.Size(244, 23);
            this.txt_upEmail.TabIndex = 58;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(29, 348);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(139, 30);
            this.labelControl5.TabIndex = 57;
            this.labelControl5.Text = "Số Điện Thoại:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(30, 293);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 30);
            this.labelControl2.TabIndex = 56;
            this.labelControl2.Text = "Địa Chỉ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(29, 240);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 30);
            this.labelControl1.TabIndex = 55;
            this.labelControl1.Text = "Email:";
            // 
            // txt_upTrinhDo
            // 
            this.txt_upTrinhDo.Location = new System.Drawing.Point(196, 195);
            this.txt_upTrinhDo.Name = "txt_upTrinhDo";
            this.txt_upTrinhDo.Size = new System.Drawing.Size(244, 23);
            this.txt_upTrinhDo.TabIndex = 53;
            // 
            // dtp_upNgaySinh
            // 
            this.dtp_upNgaySinh.Location = new System.Drawing.Point(196, 139);
            this.dtp_upNgaySinh.Name = "dtp_upNgaySinh";
            this.dtp_upNgaySinh.Size = new System.Drawing.Size(244, 23);
            this.dtp_upNgaySinh.TabIndex = 52;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(30, 188);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(86, 30);
            this.labelControl7.TabIndex = 48;
            this.labelControl7.Text = "Trình Độ:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(29, 133);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(103, 30);
            this.labelControl6.TabIndex = 47;
            this.labelControl6.Text = "Ngày Sinh:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(29, 79);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(86, 30);
            this.labelControl4.TabIndex = 46;
            this.labelControl4.Text = "Chức Vụ:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(29, 25);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(147, 30);
            this.labelControl3.TabIndex = 45;
            this.labelControl3.Text = "Tên Nhân Viên:";
            // 
            // cb_upchucvu
            // 
            this.cb_upchucvu.FormattingEnabled = true;
            this.cb_upchucvu.Location = new System.Drawing.Point(196, 87);
            this.cb_upchucvu.Name = "cb_upchucvu";
            this.cb_upchucvu.Size = new System.Drawing.Size(244, 24);
            this.cb_upchucvu.TabIndex = 44;
            // 
            // txt_upTen
            // 
            this.txt_upTen.Location = new System.Drawing.Point(196, 32);
            this.txt_upTen.Name = "txt_upTen";
            this.txt_upTen.Size = new System.Drawing.Size(244, 23);
            this.txt_upTen.TabIndex = 43;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(305, 11);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(275, 41);
            this.labelControl8.TabIndex = 3;
            this.labelControl8.Text = "Cập Nhật Thông Tin";
            // 
            // btn_LuuTD
            // 
            this.btn_LuuTD.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuTD.Appearance.Options.UseFont = true;
            this.btn_LuuTD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_LuuTD.ImageOptions.Image")));
            this.btn_LuuTD.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_LuuTD.Location = new System.Drawing.Point(350, 581);
            this.btn_LuuTD.Name = "btn_LuuTD";
            this.btn_LuuTD.Size = new System.Drawing.Size(172, 57);
            this.btn_LuuTD.TabIndex = 4;
            this.btn_LuuTD.Text = "Lưu Thay Đổi";
            this.btn_LuuTD.Click += new System.EventHandler(this.btn_LuuTD_Click);
            // 
            // SuaThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 667);
            this.Controls.Add(this.panel1);
            this.Name = "SuaThongTin";
            this.Text = "SuaThongTin";
            this.Load += new System.EventHandler(this.SuaThongTin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Anh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_upTaiAnh;
        private System.Windows.Forms.PictureBox pb_Anh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_upSDT;
        private System.Windows.Forms.TextBox txt_upDiaChi;
        private System.Windows.Forms.TextBox txt_upEmail;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txt_upTrinhDo;
        private System.Windows.Forms.DateTimePicker dtp_upNgaySinh;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cb_upchucvu;
        private System.Windows.Forms.TextBox txt_upTen;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btn_LuuTD;
    }
}