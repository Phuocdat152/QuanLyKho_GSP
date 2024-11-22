namespace GUI
{
    partial class KiemKeDoiChieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiemKeDoiChieu));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_KiemKe = new System.Windows.Forms.TabPage();
            this.txt_NhanVienKK = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gc_KiemKe = new DevExpress.XtraGrid.GridControl();
            this.gv_KiemKe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.de_NgayKK = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_LoaiKK = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btn_Luu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_XoaSP = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grc_DanhSachKK = new DevExpress.XtraGrid.GridControl();
            this.gv_DanhSachKK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cb_LKK = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_KiemKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NhanVienKK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_KiemKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_KiemKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayKK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayKK.Properties.CalendarTimeProperties)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grc_DanhSachKK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DanhSachKK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(691, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(431, 41);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "KIỂM KÊ ĐỐI CHIẾU KHO";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(1, 2);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1814, 71);
            this.panelControl1.TabIndex = 2;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.tabControl1);
            this.panelControl2.Location = new System.Drawing.Point(1, 82);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1814, 948);
            this.panelControl2.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_KiemKe);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1810, 944);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tab_KiemKe
            // 
            this.tab_KiemKe.Controls.Add(this.txt_NhanVienKK);
            this.tab_KiemKe.Controls.Add(this.groupControl1);
            this.tab_KiemKe.Controls.Add(this.de_NgayKK);
            this.tab_KiemKe.Controls.Add(this.label3);
            this.tab_KiemKe.Controls.Add(this.label2);
            this.tab_KiemKe.Controls.Add(this.cb_LoaiKK);
            this.tab_KiemKe.Controls.Add(this.label1);
            this.tab_KiemKe.Controls.Add(this.toolStrip2);
            this.tab_KiemKe.Location = new System.Drawing.Point(4, 25);
            this.tab_KiemKe.Margin = new System.Windows.Forms.Padding(5);
            this.tab_KiemKe.Name = "tab_KiemKe";
            this.tab_KiemKe.Padding = new System.Windows.Forms.Padding(5);
            this.tab_KiemKe.Size = new System.Drawing.Size(1802, 915);
            this.tab_KiemKe.TabIndex = 0;
            this.tab_KiemKe.Text = "Kiểm kê kho";
            this.tab_KiemKe.UseVisualStyleBackColor = true;
            // 
            // txt_NhanVienKK
            // 
            this.txt_NhanVienKK.Location = new System.Drawing.Point(1420, 120);
            this.txt_NhanVienKK.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NhanVienKK.Name = "txt_NhanVienKK";
            this.txt_NhanVienKK.Size = new System.Drawing.Size(349, 22);
            this.txt_NhanVienKK.TabIndex = 39;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gc_KiemKe);
            this.groupControl1.Location = new System.Drawing.Point(5, 214);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1784, 682);
            this.groupControl1.TabIndex = 38;
            this.groupControl1.Text = "Danh sách thuốc cần kiểm kê";
            // 
            // gc_KiemKe
            // 
            this.gc_KiemKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_KiemKe.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gc_KiemKe.Location = new System.Drawing.Point(2, 28);
            this.gc_KiemKe.MainView = this.gv_KiemKe;
            this.gc_KiemKe.Margin = new System.Windows.Forms.Padding(5);
            this.gc_KiemKe.Name = "gc_KiemKe";
            this.gc_KiemKe.Size = new System.Drawing.Size(1780, 652);
            this.gc_KiemKe.TabIndex = 37;
            this.gc_KiemKe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_KiemKe,
            this.gridView4});
            // 
            // gv_KiemKe
            // 
            this.gv_KiemKe.DetailHeight = 539;
            this.gv_KiemKe.GridControl = this.gc_KiemKe;
            this.gv_KiemKe.Name = "gv_KiemKe";
            this.gv_KiemKe.OptionsEditForm.PopupEditFormWidth = 1334;
            this.gv_KiemKe.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gv_KiemKe_CellValueChanged);
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gc_KiemKe;
            this.gridView4.Name = "gridView4";
            // 
            // de_NgayKK
            // 
            this.de_NgayKK.EditValue = null;
            this.de_NgayKK.Location = new System.Drawing.Point(1420, 51);
            this.de_NgayKK.Margin = new System.Windows.Forms.Padding(5);
            this.de_NgayKK.Name = "de_NgayKK";
            this.de_NgayKK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_NgayKK.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_NgayKK.Size = new System.Drawing.Size(349, 22);
            this.de_NgayKK.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1220, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Người kiểm kê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1220, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ngày kiểm kê";
            // 
            // cb_LoaiKK
            // 
            this.cb_LoaiKK.FormattingEnabled = true;
            this.cb_LoaiKK.Location = new System.Drawing.Point(229, 51);
            this.cb_LoaiKK.Margin = new System.Windows.Forms.Padding(5);
            this.cb_LoaiKK.Name = "cb_LoaiKK";
            this.cb_LoaiKK.Size = new System.Drawing.Size(315, 24);
            this.cb_LoaiKK.TabIndex = 32;
            this.cb_LoaiKK.SelectedIndexChanged += new System.EventHandler(this.cb_LoaiKK_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Chọn loại kiểm kê";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Luu,
            this.toolStripSeparator6,
            this.btn_XoaSP});
            this.toolStrip2.Location = new System.Drawing.Point(5, 5);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(1792, 27);
            this.toolStrip2.TabIndex = 30;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(57, 24);
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.ToolTipText = "Thêm sản phẩm";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_XoaSP
            // 
            this.btn_XoaSP.Enabled = false;
            this.btn_XoaSP.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaSP.Image")));
            this.btn_XoaSP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_XoaSP.Name = "btn_XoaSP";
            this.btn_XoaSP.Size = new System.Drawing.Size(100, 24);
            this.btn_XoaSP.Text = "Xóa thuốc";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1802, 915);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cb_LKK);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.grc_DanhSachKK);
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1803, 705);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Thông Tin Kiểm Kê";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(27, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(98, 23);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Loại Kiểm Kê";
            // 
            // grc_DanhSachKK
            // 
            this.grc_DanhSachKK.Location = new System.Drawing.Point(2, 85);
            this.grc_DanhSachKK.MainView = this.gv_DanhSachKK;
            this.grc_DanhSachKK.Name = "grc_DanhSachKK";
            this.grc_DanhSachKK.Size = new System.Drawing.Size(1797, 620);
            this.grc_DanhSachKK.TabIndex = 0;
            this.grc_DanhSachKK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DanhSachKK});
            // 
            // gv_DanhSachKK
            // 
            this.gv_DanhSachKK.GridControl = this.grc_DanhSachKK;
            this.gv_DanhSachKK.Name = "gv_DanhSachKK";
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miniToolStrip.Location = new System.Drawing.Point(110, 1);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.miniToolStrip.Size = new System.Drawing.Size(1305, 27);
            this.miniToolStrip.TabIndex = 31;
            // 
            // gridView3
            // 
            this.gridView3.Name = "gridView3";
            // 
            // cb_LKK
            // 
            this.cb_LKK.FormattingEnabled = true;
            this.cb_LKK.Location = new System.Drawing.Point(150, 45);
            this.cb_LKK.Margin = new System.Windows.Forms.Padding(5);
            this.cb_LKK.Name = "cb_LKK";
            this.cb_LKK.Size = new System.Drawing.Size(315, 24);
            this.cb_LKK.TabIndex = 33;
            this.cb_LKK.SelectedIndexChanged += new System.EventHandler(this.cb_LKK_SelectedIndexChanged);
            // 
            // KiemKeDoiChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 821);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KiemKeDoiChieu";
            this.Text = "KiemKeDoiChieu";
            this.Load += new System.EventHandler(this.KiemKeDoiChieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_KiemKe.ResumeLayout(false);
            this.tab_KiemKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NhanVienKK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_KiemKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_KiemKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayKK.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayKK.Properties)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grc_DanhSachKK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DanhSachKK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_KiemKe;
        private DevExpress.XtraEditors.TextEdit txt_NhanVienKK;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gc_KiemKe;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_KiemKe;
        private DevExpress.XtraEditors.DateEdit de_NgayKK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_LoaiKK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btn_Luu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btn_XoaSP;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grc_DanhSachKK;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DanhSachKK;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cb_LKK;
    }
}