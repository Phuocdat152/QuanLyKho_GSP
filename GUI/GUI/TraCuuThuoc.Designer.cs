namespace GUI
{
    partial class TraCuuThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraCuuThuoc));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_TraCuu = new System.Windows.Forms.Button();
            this.date_NgayHetHan = new DevExpress.XtraEditors.DateEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_TrangThai = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_TenThuoc = new System.Windows.Forms.ComboBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gc_TraCuu = new DevExpress.XtraGrid.GridControl();
            this.gv_TraCuu = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayHetHan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayHetHan.Properties.CalendarTimeProperties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_TraCuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerControl1.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainerControl1.Panel2.Appearance.BorderColor = System.Drawing.Color.Black;
            this.splitContainerControl1.Panel2.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.splitContainerControl1.Panel2.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.Panel2.Appearance.Options.UseBorderColor = true;
            this.splitContainerControl1.Panel2.Appearance.Options.UseForeColor = true;
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1053, 543);
            this.splitContainerControl1.SplitterPosition = 164;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupBox3);
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1053, 164);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tra cứu thuốc";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_TraCuu);
            this.groupBox3.Controls.Add(this.date_NgayHetHan);
            this.groupBox3.Location = new System.Drawing.Point(380, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hạn sử dụng";
            // 
            // btn_TraCuu
            // 
            this.btn_TraCuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_TraCuu.Image = ((System.Drawing.Image)(resources.GetObject("btn_TraCuu.Image")));
            this.btn_TraCuu.Location = new System.Drawing.Point(117, 53);
            this.btn_TraCuu.Name = "btn_TraCuu";
            this.btn_TraCuu.Size = new System.Drawing.Size(85, 41);
            this.btn_TraCuu.TabIndex = 5;
            this.btn_TraCuu.UseVisualStyleBackColor = false;
            this.btn_TraCuu.Click += new System.EventHandler(this.btn_TraCuu_Click);
            // 
            // date_NgayHetHan
            // 
            this.date_NgayHetHan.EditValue = null;
            this.date_NgayHetHan.Location = new System.Drawing.Point(51, 28);
            this.date_NgayHetHan.Name = "date_NgayHetHan";
            this.date_NgayHetHan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_NgayHetHan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_NgayHetHan.Size = new System.Drawing.Size(208, 20);
            this.date_NgayHetHan.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_TrangThai);
            this.groupBox2.Location = new System.Drawing.Point(806, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trạng thái thuốc";
            // 
            // cb_TrangThai
            // 
            this.cb_TrangThai.FormattingEnabled = true;
            this.cb_TrangThai.Location = new System.Drawing.Point(6, 31);
            this.cb_TrangThai.Name = "cb_TrangThai";
            this.cb_TrangThai.Size = new System.Drawing.Size(188, 21);
            this.cb_TrangThai.TabIndex = 0;
            this.cb_TrangThai.SelectedIndexChanged += new System.EventHandler(this.cb_TrangThai_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_TenThuoc);
            this.groupBox1.Location = new System.Drawing.Point(53, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tên thuốc";
            // 
            // cb_TenThuoc
            // 
            this.cb_TenThuoc.FormattingEnabled = true;
            this.cb_TenThuoc.Location = new System.Drawing.Point(6, 31);
            this.cb_TenThuoc.Name = "cb_TenThuoc";
            this.cb_TenThuoc.Size = new System.Drawing.Size(188, 21);
            this.cb_TenThuoc.TabIndex = 0;
            this.cb_TenThuoc.SelectedIndexChanged += new System.EventHandler(this.cb_TenThuoc_SelectedIndexChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gc_TraCuu);
            this.groupControl2.Location = new System.Drawing.Point(-2, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1053, 363);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Danh sách thuốc";
            // 
            // gc_TraCuu
            // 
            this.gc_TraCuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_TraCuu.Location = new System.Drawing.Point(2, 23);
            this.gc_TraCuu.MainView = this.gv_TraCuu;
            this.gc_TraCuu.Name = "gc_TraCuu";
            this.gc_TraCuu.Size = new System.Drawing.Size(1049, 338);
            this.gc_TraCuu.TabIndex = 0;
            this.gc_TraCuu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_TraCuu});
            // 
            // gv_TraCuu
            // 
            this.gv_TraCuu.GridControl = this.gc_TraCuu;
            this.gv_TraCuu.Name = "gv_TraCuu";
            // 
            // TraCuuThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 543);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "TraCuuThuoc";
            this.Text = "TraCuuThuoc";
            this.Load += new System.EventHandler(this.TraCuuThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayHetHan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayHetHan.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_TraCuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TraCuu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_TrangThai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_TenThuoc;
        private DevExpress.XtraEditors.DateEdit date_NgayHetHan;
        private System.Windows.Forms.Button btn_TraCuu;
        private DevExpress.XtraGrid.GridControl gc_TraCuu;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_TraCuu;
    }
}