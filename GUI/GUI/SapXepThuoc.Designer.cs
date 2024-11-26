namespace GUI
{
    partial class SapXepThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SapXepThuoc));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gc_ThuocDaSapXep = new DevExpress.XtraGrid.GridControl();
            this.gv_ThuocDaSapXep = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gc_ThuocChuaSapXep = new DevExpress.XtraGrid.GridControl();
            this.gv_ThuocChuaSapXep = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Luu = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ThuocDaSapXep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ThuocDaSapXep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ThuocChuaSapXep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ThuocChuaSapXep)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1049, 645);
            this.splitContainerControl1.SplitterPosition = 325;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gc_ThuocDaSapXep);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1049, 325);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách thuốc đã sắp xếp";
            // 
            // gc_ThuocDaSapXep
            // 
            this.gc_ThuocDaSapXep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_ThuocDaSapXep.Location = new System.Drawing.Point(2, 23);
            this.gc_ThuocDaSapXep.MainView = this.gv_ThuocDaSapXep;
            this.gc_ThuocDaSapXep.Name = "gc_ThuocDaSapXep";
            this.gc_ThuocDaSapXep.Size = new System.Drawing.Size(1045, 300);
            this.gc_ThuocDaSapXep.TabIndex = 0;
            this.gc_ThuocDaSapXep.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ThuocDaSapXep});
            // 
            // gv_ThuocDaSapXep
            // 
            this.gv_ThuocDaSapXep.GridControl = this.gc_ThuocDaSapXep;
            this.gv_ThuocDaSapXep.Name = "gv_ThuocDaSapXep";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gc_ThuocChuaSapXep);
            this.groupControl2.Controls.Add(this.toolStrip1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1049, 310);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Thêm thuốc vào vị trí";
            // 
            // gc_ThuocChuaSapXep
            // 
            this.gc_ThuocChuaSapXep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_ThuocChuaSapXep.Location = new System.Drawing.Point(2, 50);
            this.gc_ThuocChuaSapXep.MainView = this.gv_ThuocChuaSapXep;
            this.gc_ThuocChuaSapXep.Name = "gc_ThuocChuaSapXep";
            this.gc_ThuocChuaSapXep.Size = new System.Drawing.Size(1045, 258);
            this.gc_ThuocChuaSapXep.TabIndex = 31;
            this.gc_ThuocChuaSapXep.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ThuocChuaSapXep});
            // 
            // gv_ThuocChuaSapXep
            // 
            this.gv_ThuocChuaSapXep.GridControl = this.gc_ThuocChuaSapXep;
            this.gv_ThuocChuaSapXep.Name = "gv_ThuocChuaSapXep";
            this.gv_ThuocChuaSapXep.OptionsView.ShowGroupPanel = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Luu});
            this.toolStrip1.Location = new System.Drawing.Point(2, 23);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1045, 27);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(51, 24);
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // SapXepThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1049, 645);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "SapXepThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lưu trữ thuốc";
            this.Load += new System.EventHandler(this.SapXepThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_ThuocDaSapXep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ThuocDaSapXep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ThuocChuaSapXep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ThuocChuaSapXep)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gc_ThuocDaSapXep;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ThuocDaSapXep;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gc_ThuocChuaSapXep;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ThuocChuaSapXep;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Luu;
    }
}