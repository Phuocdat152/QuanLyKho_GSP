namespace GUI
{
    partial class ViTri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViTri));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gc_ViTri = new DevExpress.XtraGrid.GridControl();
            this.gv_ViTri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_O = new DevExpress.XtraEditors.TextEdit();
            this.txt_Ke = new DevExpress.XtraEditors.TextEdit();
            this.txt_Khu = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_O = new System.Windows.Forms.NumericUpDown();
            this.num_Ke = new System.Windows.Forms.NumericUpDown();
            this.num_Khu = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Them = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Luu = new System.Windows.Forms.ToolStripButton();
            this.btn_Huy = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_LoaiKhu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_LoaiKhu = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ViTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ViTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_O.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ke.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Khu.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_O)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Ke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Khu)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LoaiKhu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(912, 604);
            this.splitContainerControl1.SplitterPosition = 271;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gc_ViTri);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(912, 271);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Danh sách vị trí";
            // 
            // gc_ViTri
            // 
            this.gc_ViTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_ViTri.Location = new System.Drawing.Point(2, 23);
            this.gc_ViTri.MainView = this.gv_ViTri;
            this.gc_ViTri.Name = "gc_ViTri";
            this.gc_ViTri.Size = new System.Drawing.Size(908, 246);
            this.gc_ViTri.TabIndex = 0;
            this.gc_ViTri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ViTri});
            // 
            // gv_ViTri
            // 
            this.gv_ViTri.GridControl = this.gc_ViTri;
            this.gv_ViTri.Name = "gv_ViTri";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.toolStrip1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(912, 323);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Quản lý vị trí";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_LoaiKhu);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_O);
            this.groupBox2.Controls.Add(this.txt_Ke);
            this.groupBox2.Controls.Add(this.txt_Khu);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(519, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 206);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin vị trí";
            // 
            // txt_O
            // 
            this.txt_O.Enabled = false;
            this.txt_O.Location = new System.Drawing.Point(120, 120);
            this.txt_O.Name = "txt_O";
            this.txt_O.Size = new System.Drawing.Size(222, 20);
            this.txt_O.TabIndex = 40;
            // 
            // txt_Ke
            // 
            this.txt_Ke.Enabled = false;
            this.txt_Ke.Location = new System.Drawing.Point(120, 70);
            this.txt_Ke.Name = "txt_Ke";
            this.txt_Ke.Size = new System.Drawing.Size(222, 20);
            this.txt_Ke.TabIndex = 39;
            // 
            // txt_Khu
            // 
            this.txt_Khu.Enabled = false;
            this.txt_Khu.Location = new System.Drawing.Point(120, 28);
            this.txt_Khu.Name = "txt_Khu";
            this.txt_Khu.Size = new System.Drawing.Size(222, 20);
            this.txt_Khu.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Kệ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Ô:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Khu:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_LoaiKhu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.num_O);
            this.groupBox1.Controls.Add(this.num_Ke);
            this.groupBox1.Controls.Add(this.num_Khu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 206);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm vị trí ";
            // 
            // num_O
            // 
            this.num_O.Enabled = false;
            this.num_O.Location = new System.Drawing.Point(242, 123);
            this.num_O.Name = "num_O";
            this.num_O.Size = new System.Drawing.Size(120, 21);
            this.num_O.TabIndex = 39;
            // 
            // num_Ke
            // 
            this.num_Ke.Enabled = false;
            this.num_Ke.Location = new System.Drawing.Point(242, 69);
            this.num_Ke.Name = "num_Ke";
            this.num_Ke.Size = new System.Drawing.Size(120, 21);
            this.num_Ke.TabIndex = 38;
            // 
            // num_Khu
            // 
            this.num_Khu.Enabled = false;
            this.num_Khu.Location = new System.Drawing.Point(242, 23);
            this.num_Khu.Name = "num_Khu";
            this.num_Khu.Size = new System.Drawing.Size(120, 21);
            this.num_Khu.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Số lượng ô trong từng kệ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Số lượng kệ trong từng khu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Số lượng khu:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Them,
            this.toolStripSeparator1,
            this.btn_Luu,
            this.btn_Huy});
            this.toolStrip1.Location = new System.Drawing.Point(2, 23);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(908, 42);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Them
            // 
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(41, 39);
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Enabled = false;
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(31, 39);
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Enabled = false;
            this.btn_Huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_Huy.Image")));
            this.btn_Huy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(33, 39);
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Loại khu:";
            // 
            // cb_LoaiKhu
            // 
            this.cb_LoaiKhu.Enabled = false;
            this.cb_LoaiKhu.FormattingEnabled = true;
            this.cb_LoaiKhu.Location = new System.Drawing.Point(241, 171);
            this.cb_LoaiKhu.Name = "cb_LoaiKhu";
            this.cb_LoaiKhu.Size = new System.Drawing.Size(121, 21);
            this.cb_LoaiKhu.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Loại khu:";
            // 
            // txt_LoaiKhu
            // 
            this.txt_LoaiKhu.Enabled = false;
            this.txt_LoaiKhu.Location = new System.Drawing.Point(120, 168);
            this.txt_LoaiKhu.Name = "txt_LoaiKhu";
            this.txt_LoaiKhu.Size = new System.Drawing.Size(222, 20);
            this.txt_LoaiKhu.TabIndex = 42;
            // 
            // ViTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 604);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "ViTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViTri";
            this.Load += new System.EventHandler(this.ViTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_ViTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ViTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_O.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ke.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Khu.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_O)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Ke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Khu)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LoaiKhu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gc_ViTri;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ViTri;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Them;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Luu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown num_O;
        private System.Windows.Forms.NumericUpDown num_Ke;
        private System.Windows.Forms.NumericUpDown num_Khu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit txt_Khu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_O;
        private DevExpress.XtraEditors.TextEdit txt_Ke;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.ToolStripButton btn_Huy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_LoaiKhu;
        private DevExpress.XtraEditors.TextEdit txt_LoaiKhu;
        private System.Windows.Forms.Label label8;
    }
}