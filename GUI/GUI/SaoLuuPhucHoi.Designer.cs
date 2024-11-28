namespace GUI
{
    partial class SaoLuuPhucHoi
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TenFile = new System.Windows.Forms.TextBox();
            this.txt_ViTriLuu = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ViTriPH = new System.Windows.Forms.TextBox();
            this.btn_PhucHoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ChonFileRestore = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SaoLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ChonFile = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl2);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 461);
            this.panel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_SaoLuu);
            this.groupControl1.Controls.Add(this.btn_ChonFile);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txt_ViTriLuu);
            this.groupControl1.Controls.Add(this.txt_TenFile);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(509, 456);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Sao Lưu Dữ Liệu";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_PhucHoi);
            this.groupControl2.Controls.Add(this.btn_ChonFileRestore);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.txt_ViTriPH);
            this.groupControl2.Location = new System.Drawing.Point(512, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(474, 456);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Phục Hồi Dữ Liệu";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(61, 110);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(113, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhập tên file:";
            // 
            // txt_TenFile
            // 
            this.txt_TenFile.Location = new System.Drawing.Point(216, 112);
            this.txt_TenFile.Name = "txt_TenFile";
            this.txt_TenFile.Size = new System.Drawing.Size(234, 23);
            this.txt_TenFile.TabIndex = 1;
            // 
            // txt_ViTriLuu
            // 
            this.txt_ViTriLuu.Location = new System.Drawing.Point(216, 177);
            this.txt_ViTriLuu.Name = "txt_ViTriLuu";
            this.txt_ViTriLuu.Size = new System.Drawing.Size(234, 23);
            this.txt_ViTriLuu.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(61, 175);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(123, 25);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Chọn vị trí lưu:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(65, 138);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 25);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Tên file:";
            // 
            // txt_ViTriPH
            // 
            this.txt_ViTriPH.Location = new System.Drawing.Point(150, 140);
            this.txt_ViTriPH.Name = "txt_ViTriPH";
            this.txt_ViTriPH.Size = new System.Drawing.Size(243, 23);
            this.txt_ViTriPH.TabIndex = 6;
            // 
            // btn_PhucHoi
            // 
            this.btn_PhucHoi.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PhucHoi.Appearance.Options.UseFont = true;
            this.btn_PhucHoi.ImageOptions.Image = global::GUI.Properties.Resources.refresh2_32x32;
            this.btn_PhucHoi.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_PhucHoi.Location = new System.Drawing.Point(161, 347);
            this.btn_PhucHoi.Name = "btn_PhucHoi";
            this.btn_PhucHoi.Size = new System.Drawing.Size(184, 75);
            this.btn_PhucHoi.TabIndex = 9;
            this.btn_PhucHoi.Text = "Phục Hồi";
            this.btn_PhucHoi.Click += new System.EventHandler(this.btn_PhucHoi_Click);
            // 
            // btn_ChonFileRestore
            // 
            this.btn_ChonFileRestore.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonFileRestore.Appearance.Options.UseFont = true;
            this.btn_ChonFileRestore.ImageOptions.Image = global::GUI.Properties.Resources.open_32x32;
            this.btn_ChonFileRestore.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_ChonFileRestore.Location = new System.Drawing.Point(177, 239);
            this.btn_ChonFileRestore.Name = "btn_ChonFileRestore";
            this.btn_ChonFileRestore.Size = new System.Drawing.Size(140, 49);
            this.btn_ChonFileRestore.TabIndex = 8;
            this.btn_ChonFileRestore.Text = "Chọn File";
            this.btn_ChonFileRestore.Click += new System.EventHandler(this.btn_ChonFileRestore_Click);
            // 
            // btn_SaoLuu
            // 
            this.btn_SaoLuu.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.btn_SaoLuu.Appearance.Options.UseFont = true;
            this.btn_SaoLuu.ImageOptions.Image = global::GUI.Properties.Resources.saveto_32x32;
            this.btn_SaoLuu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_SaoLuu.Location = new System.Drawing.Point(145, 347);
            this.btn_SaoLuu.Name = "btn_SaoLuu";
            this.btn_SaoLuu.Size = new System.Drawing.Size(184, 75);
            this.btn_SaoLuu.TabIndex = 5;
            this.btn_SaoLuu.Text = "Sao Lưu";
            this.btn_SaoLuu.Click += new System.EventHandler(this.btn_SaoLuu_Click);
            // 
            // btn_ChonFile
            // 
            this.btn_ChonFile.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonFile.Appearance.Options.UseFont = true;
            this.btn_ChonFile.ImageOptions.Image = global::GUI.Properties.Resources.open_32x32;
            this.btn_ChonFile.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_ChonFile.Location = new System.Drawing.Point(166, 239);
            this.btn_ChonFile.Name = "btn_ChonFile";
            this.btn_ChonFile.Size = new System.Drawing.Size(140, 49);
            this.btn_ChonFile.TabIndex = 4;
            this.btn_ChonFile.Text = "Chọn File";
            this.btn_ChonFile.Click += new System.EventHandler(this.btn_ChonFile_Click);
            // 
            // SaoLuuPhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 464);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SaoLuuPhucHoi";
            this.Text = "SaoLuuPhucHoi";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_ChonFile;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txt_ViTriLuu;
        private System.Windows.Forms.TextBox txt_TenFile;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_SaoLuu;
        private DevExpress.XtraEditors.SimpleButton btn_PhucHoi;
        private DevExpress.XtraEditors.SimpleButton btn_ChonFileRestore;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txt_ViTriPH;
    }
}