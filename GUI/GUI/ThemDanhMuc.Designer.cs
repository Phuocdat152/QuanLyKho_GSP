namespace GUI
{
    partial class ThemDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemDanhMuc));
            this.txt_addDanhMuc = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_ThemDanhMuc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.cb_LoaiThuoc = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // txt_addDanhMuc
            // 
            this.txt_addDanhMuc.Location = new System.Drawing.Point(253, 23);
            this.txt_addDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_addDanhMuc.Name = "txt_addDanhMuc";
            this.txt_addDanhMuc.Size = new System.Drawing.Size(209, 22);
            this.txt_addDanhMuc.TabIndex = 0;
            this.txt_addDanhMuc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 24);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(197, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nhập Tên Danh Mục Mới:";
            // 
            // btn_ThemDanhMuc
            // 
            this.btn_ThemDanhMuc.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemDanhMuc.Appearance.Options.UseFont = true;
            this.btn_ThemDanhMuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemDanhMuc.ImageOptions.Image")));
            this.btn_ThemDanhMuc.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_ThemDanhMuc.Location = new System.Drawing.Point(99, 120);
            this.btn_ThemDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThemDanhMuc.Name = "btn_ThemDanhMuc";
            this.btn_ThemDanhMuc.Size = new System.Drawing.Size(105, 48);
            this.btn_ThemDanhMuc.TabIndex = 2;
            this.btn_ThemDanhMuc.Text = "Thêm";
            this.btn_ThemDanhMuc.Click += new System.EventHandler(this.btn_ThemDanhMuc_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Appearance.Options.UseFont = true;
            this.btn_Huy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Huy.ImageOptions.Image")));
            this.btn_Huy.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Huy.Location = new System.Drawing.Point(244, 120);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(101, 48);
            this.btn_Huy.TabIndex = 3;
            this.btn_Huy.Text = "Huỷ";
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // cb_LoaiThuoc
            // 
            this.cb_LoaiThuoc.FormattingEnabled = true;
            this.cb_LoaiThuoc.Location = new System.Drawing.Point(256, 73);
            this.cb_LoaiThuoc.Name = "cb_LoaiThuoc";
            this.cb_LoaiThuoc.Size = new System.Drawing.Size(206, 24);
            this.cb_LoaiThuoc.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(27, 75);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 23);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Loại Thuốc:";
            // 
            // ThemDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 186);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cb_LoaiThuoc);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_ThemDanhMuc);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_addDanhMuc);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThemDanhMuc";
            this.Text = "ThemDanhMuc";
            this.Load += new System.EventHandler(this.ThemDanhMuc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_addDanhMuc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_ThemDanhMuc;
        private DevExpress.XtraEditors.SimpleButton btn_Huy;
        private System.Windows.Forms.ComboBox cb_LoaiThuoc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}