namespace GUI
{
    partial class HuyThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HuyThuoc));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btn_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.cb_ThuocHuy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gc_ThuocHuy = new DevExpress.XtraGrid.GridControl();
            this.gv_ThuocHuy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gc_DSTH = new DevExpress.XtraGrid.GridControl();
            this.gv_DSHT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pb_BienBan = new System.Windows.Forms.PictureBox();
            this.btn_TaiBienBan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_ThuocHuy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ThuocHuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ThuocHuy)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DSTH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BienBan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1319, 647);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainerControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1311, 621);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin thuốc hủy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(3, 3);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_TaiBienBan);
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_Luu);
            this.splitContainerControl1.Panel1.Controls.Add(this.cb_ThuocHuy);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1305, 615);
            this.splitContainerControl1.SplitterPosition = 216;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_Luu.Appearance.Options.UseForeColor = true;
            this.btn_Luu.Enabled = false;
            this.btn_Luu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btn_Luu.Location = new System.Drawing.Point(709, 40);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(82, 38);
            this.btn_Luu.TabIndex = 2;
            this.btn_Luu.Text = "Lưu";
            // 
            // cb_ThuocHuy
            // 
            this.cb_ThuocHuy.Enabled = false;
            this.cb_ThuocHuy.Location = new System.Drawing.Point(43, 48);
            this.cb_ThuocHuy.Name = "cb_ThuocHuy";
            this.cb_ThuocHuy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_ThuocHuy.Size = new System.Drawing.Size(644, 20);
            this.cb_ThuocHuy.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chọn thuốc cần hủy";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gc_ThuocHuy);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1305, 389);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin thuốc hủy";
            // 
            // gc_ThuocHuy
            // 
            this.gc_ThuocHuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_ThuocHuy.Location = new System.Drawing.Point(2, 23);
            this.gc_ThuocHuy.MainView = this.gv_ThuocHuy;
            this.gc_ThuocHuy.Name = "gc_ThuocHuy";
            this.gc_ThuocHuy.Size = new System.Drawing.Size(1301, 364);
            this.gc_ThuocHuy.TabIndex = 0;
            this.gc_ThuocHuy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ThuocHuy});
            // 
            // gv_ThuocHuy
            // 
            this.gv_ThuocHuy.GridControl = this.gc_ThuocHuy;
            this.gv_ThuocHuy.Name = "gv_ThuocHuy";
            this.gv_ThuocHuy.OptionsView.ShowGroupPanel = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gc_DSTH);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(833, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách thuốc hủy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gc_DSTH
            // 
            this.gc_DSTH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_DSTH.Location = new System.Drawing.Point(3, 3);
            this.gc_DSTH.MainView = this.gv_DSHT;
            this.gc_DSTH.Name = "gc_DSTH";
            this.gc_DSTH.Size = new System.Drawing.Size(827, 445);
            this.gc_DSTH.TabIndex = 0;
            this.gc_DSTH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DSHT});
            // 
            // gv_DSHT
            // 
            this.gv_DSHT.GridControl = this.gc_DSTH;
            this.gv_DSHT.Name = "gv_DSHT";
            this.gv_DSHT.OptionsView.ShowFooter = true;
            // 
            // pb_BienBan
            // 
            this.pb_BienBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_BienBan.Location = new System.Drawing.Point(3, 17);
            this.pb_BienBan.Name = "pb_BienBan";
            this.pb_BienBan.Size = new System.Drawing.Size(481, 140);
            this.pb_BienBan.TabIndex = 3;
            this.pb_BienBan.TabStop = false;
            // 
            // btn_TaiBienBan
            // 
            this.btn_TaiBienBan.Location = new System.Drawing.Point(1021, 182);
            this.btn_TaiBienBan.Name = "btn_TaiBienBan";
            this.btn_TaiBienBan.Size = new System.Drawing.Size(123, 23);
            this.btn_TaiBienBan.TabIndex = 4;
            this.btn_TaiBienBan.Text = "Tải biên bản ";
            this.btn_TaiBienBan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.pb_BienBan);
            this.groupBox1.Location = new System.Drawing.Point(813, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 160);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Biên bản hủy thuốc";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(93, 147);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(346, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Bạn cần phải tải biên bản hủy thuốc lên để sử dụng được chức năng này";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(81, 147);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "*";
            // 
            // HuyThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1319, 647);
            this.Controls.Add(this.tabControl1);
            this.Name = "HuyThuoc";
            this.Text = "HuyThuoc";
            this.Load += new System.EventHandler(this.HuyThuoc_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cb_ThuocHuy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_ThuocHuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ThuocHuy)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_DSTH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BienBan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private DevExpress.XtraEditors.ComboBoxEdit cb_ThuocHuy;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gc_ThuocHuy;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ThuocHuy;
        private DevExpress.XtraGrid.GridControl gc_DSTH;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DSHT;
        private System.Windows.Forms.Button btn_TaiBienBan;
        private System.Windows.Forms.PictureBox pb_BienBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}