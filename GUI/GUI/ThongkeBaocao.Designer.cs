namespace GUI
{
    partial class ThongkeBaocao
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_InBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.cb_ChonLTK = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.de_DenNgay = new DevExpress.XtraEditors.DateEdit();
            this.de_TuNgay = new DevExpress.XtraEditors.DateEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_TimThuoc = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_MaThuoc = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.lb_SoLuong = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lb_ThanhPhan = new DevExpress.XtraEditors.LabelControl();
            this.lb_TenThuoc = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lb_MaLuuTru = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gc_DanhSach = new DevExpress.XtraGrid.GridControl();
            this.gv_DanhSachTK = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_DenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_DenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_TuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_TuNgay.Properties.CalendarTimeProperties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DanhSachTK)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel2.Controls.Add(this.gc_DanhSach);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1549, 761);
            this.splitContainerControl1.SplitterPosition = 270;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_InBaoCao);
            this.groupControl2.Location = new System.Drawing.Point(1328, 119);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(214, 145);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "In Báo Cáo";
            // 
            // btn_InBaoCao
            // 
            this.btn_InBaoCao.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InBaoCao.Appearance.Options.UseFont = true;
            this.btn_InBaoCao.ImageOptions.Image = global::GUI.Properties.Resources.printtitles_32x323;
            this.btn_InBaoCao.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_InBaoCao.Location = new System.Drawing.Point(34, 51);
            this.btn_InBaoCao.Name = "btn_InBaoCao";
            this.btn_InBaoCao.Size = new System.Drawing.Size(147, 74);
            this.btn_InBaoCao.TabIndex = 0;
            this.btn_InBaoCao.Text = "In Báo Cáo";
            this.btn_InBaoCao.Click += new System.EventHandler(this.btn_InBaoCao_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.cb_ChonLTK);
            this.groupControl3.Location = new System.Drawing.Point(1328, 1);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(214, 112);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Chọn Loại Thống Kê";
            // 
            // cb_ChonLTK
            // 
            this.cb_ChonLTK.FormattingEnabled = true;
            this.cb_ChonLTK.Items.AddRange(new object[] {
            "Theo tên",
            "Theo hạn sử dụng"});
            this.cb_ChonLTK.Location = new System.Drawing.Point(23, 57);
            this.cb_ChonLTK.Name = "cb_ChonLTK";
            this.cb_ChonLTK.Size = new System.Drawing.Size(170, 24);
            this.cb_ChonLTK.TabIndex = 0;
            this.cb_ChonLTK.SelectedIndexChanged += new System.EventHandler(this.cb_ChonLTK_SelectedIndexChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupBox3);
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Location = new System.Drawing.Point(1, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1321, 263);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thống kê";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.de_DenNgay);
            this.groupBox3.Controls.Add(this.de_TuNgay);
            this.groupBox3.Controls.Add(this.labelControl13);
            this.groupBox3.Controls.Add(this.labelControl12);
            this.groupBox3.Location = new System.Drawing.Point(678, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(638, 140);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Theo hạn sử dụng";
            // 
            // de_DenNgay
            // 
            this.de_DenNgay.EditValue = null;
            this.de_DenNgay.Location = new System.Drawing.Point(252, 92);
            this.de_DenNgay.Name = "de_DenNgay";
            this.de_DenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_DenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_DenNgay.Size = new System.Drawing.Size(334, 22);
            this.de_DenNgay.TabIndex = 3;
            this.de_DenNgay.EditValueChanged += new System.EventHandler(this.de_DenNgay_EditValueChanged);
            // 
            // de_TuNgay
            // 
            this.de_TuNgay.EditValue = null;
            this.de_TuNgay.Location = new System.Drawing.Point(252, 43);
            this.de_TuNgay.Name = "de_TuNgay";
            this.de_TuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_TuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_TuNgay.Size = new System.Drawing.Size(334, 22);
            this.de_TuNgay.TabIndex = 2;
            this.de_TuNgay.EditValueChanged += new System.EventHandler(this.de_TuNgay_EditValueChanged);
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(31, 89);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(84, 25);
            this.labelControl13.TabIndex = 1;
            this.labelControl13.Text = "Đến ngày:";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(31, 40);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(71, 25);
            this.labelControl12.TabIndex = 0;
            this.labelControl12.Text = "Từ ngày:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_TimThuoc);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Location = new System.Drawing.Point(678, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Theo tên thuốc";
            // 
            // txt_TimThuoc
            // 
            this.txt_TimThuoc.Location = new System.Drawing.Point(252, 28);
            this.txt_TimThuoc.Name = "txt_TimThuoc";
            this.txt_TimThuoc.Size = new System.Drawing.Size(334, 23);
            this.txt_TimThuoc.TabIndex = 1;
            this.txt_TimThuoc.TextChanged += new System.EventHandler(this.txt_TimThuoc_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(31, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(202, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhập Thông Tin Thuốc: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_MaThuoc);
            this.groupBox1.Controls.Add(this.labelControl11);
            this.groupBox1.Controls.Add(this.lb_SoLuong);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.lb_ThanhPhan);
            this.groupBox1.Controls.Add(this.lb_TenThuoc);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.lb_MaLuuTru);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Location = new System.Drawing.Point(5, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // lb_MaThuoc
            // 
            this.lb_MaThuoc.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaThuoc.Appearance.Options.UseFont = true;
            this.lb_MaThuoc.Location = new System.Drawing.Point(142, 65);
            this.lb_MaThuoc.Name = "lb_MaThuoc";
            this.lb_MaThuoc.Size = new System.Drawing.Size(4, 25);
            this.lb_MaThuoc.TabIndex = 9;
            this.lb_MaThuoc.Text = ".";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(24, 67);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(80, 23);
            this.labelControl11.TabIndex = 8;
            this.labelControl11.Text = "Mã Thuốc:";
            // 
            // lb_SoLuong
            // 
            this.lb_SoLuong.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoLuong.Appearance.Options.UseFont = true;
            this.lb_SoLuong.Location = new System.Drawing.Point(424, 26);
            this.lb_SoLuong.Name = "lb_SoLuong";
            this.lb_SoLuong.Size = new System.Drawing.Size(9, 25);
            this.lb_SoLuong.TabIndex = 7;
            this.lb_SoLuong.Text = " .";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(316, 26);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(72, 23);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Số lượng:";
            // 
            // lb_ThanhPhan
            // 
            this.lb_ThanhPhan.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThanhPhan.Appearance.Options.UseFont = true;
            this.lb_ThanhPhan.Location = new System.Drawing.Point(142, 157);
            this.lb_ThanhPhan.Name = "lb_ThanhPhan";
            this.lb_ThanhPhan.Size = new System.Drawing.Size(4, 25);
            this.lb_ThanhPhan.TabIndex = 5;
            this.lb_ThanhPhan.Text = ".";
            // 
            // lb_TenThuoc
            // 
            this.lb_TenThuoc.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenThuoc.Appearance.Options.UseFont = true;
            this.lb_TenThuoc.Location = new System.Drawing.Point(142, 111);
            this.lb_TenThuoc.Name = "lb_TenThuoc";
            this.lb_TenThuoc.Size = new System.Drawing.Size(4, 25);
            this.lb_TenThuoc.TabIndex = 4;
            this.lb_TenThuoc.Text = ".";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(24, 157);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(96, 23);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Thành Phần:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(24, 111);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 23);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Tên Thuốc:";
            // 
            // lb_MaLuuTru
            // 
            this.lb_MaLuuTru.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaLuuTru.Appearance.Options.UseFont = true;
            this.lb_MaLuuTru.Location = new System.Drawing.Point(142, 20);
            this.lb_MaLuuTru.Name = "lb_MaLuuTru";
            this.lb_MaLuuTru.Size = new System.Drawing.Size(4, 25);
            this.lb_MaLuuTru.TabIndex = 1;
            this.lb_MaLuuTru.Text = ".";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(24, 22);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 23);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã Lưu Trữ:";
            // 
            // gc_DanhSach
            // 
            this.gc_DanhSach.Location = new System.Drawing.Point(1, 2);
            this.gc_DanhSach.MainView = this.gv_DanhSachTK;
            this.gc_DanhSach.Name = "gc_DanhSach";
            this.gc_DanhSach.Size = new System.Drawing.Size(1541, 472);
            this.gc_DanhSach.TabIndex = 0;
            this.gc_DanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DanhSachTK});
            // 
            // gv_DanhSachTK
            // 
            this.gv_DanhSachTK.GridControl = this.gc_DanhSach;
            this.gv_DanhSachTK.Name = "gv_DanhSachTK";
            this.gv_DanhSachTK.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_DanhSachTK_FocusedRowChanged);
            // 
            // ThongkeBaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 761);
            this.Controls.Add(this.splitContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThongkeBaocao";
            this.Text = "Thống Kê Và Báo Cáo";
            this.Load += new System.EventHandler(this.ThongkeBaocao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_DenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_DenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_TuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_TuNgay.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DanhSachTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gc_DanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DanhSachTK;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btn_InBaoCao;
        private System.Windows.Forms.ComboBox cb_ChonLTK;
        private System.Windows.Forms.TextBox txt_TimThuoc;
        private DevExpress.XtraEditors.LabelControl lb_MaLuuTru;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lb_ThanhPhan;
        private DevExpress.XtraEditors.LabelControl lb_TenThuoc;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lb_MaThuoc;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl lb_SoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.DateEdit de_TuNgay;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.DateEdit de_DenNgay;
    }
}