namespace GUI
{
    partial class SuaDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaDanhMuc));
            this.btn_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SuaDanhMuc = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_suaDanhMuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Huy
            // 
            this.btn_Huy.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Appearance.Options.UseFont = true;
            this.btn_Huy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Huy.ImageOptions.Image")));
            this.btn_Huy.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Huy.Location = new System.Drawing.Point(250, 84);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(94, 41);
            this.btn_Huy.TabIndex = 7;
            this.btn_Huy.Text = "Huỷ";
            // 
            // btn_SuaDanhMuc
            // 
            this.btn_SuaDanhMuc.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaDanhMuc.Appearance.Options.UseFont = true;
            this.btn_SuaDanhMuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemDanhMuc.ImageOptions.Image")));
            this.btn_SuaDanhMuc.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_SuaDanhMuc.Location = new System.Drawing.Point(133, 84);
            this.btn_SuaDanhMuc.Name = "btn_SuaDanhMuc";
            this.btn_SuaDanhMuc.Size = new System.Drawing.Size(94, 41);
            this.btn_SuaDanhMuc.TabIndex = 6;
            this.btn_SuaDanhMuc.Text = "Lưu";
            this.btn_SuaDanhMuc.Click += new System.EventHandler(this.btn_SuaDanhMuc_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(30, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(149, 23);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Sửa Tên Danh Mục:";
            // 
            // txt_suaDanhMuc
            // 
            this.txt_suaDanhMuc.Location = new System.Drawing.Point(227, 34);
            this.txt_suaDanhMuc.Name = "txt_suaDanhMuc";
            this.txt_suaDanhMuc.Size = new System.Drawing.Size(210, 22);
            this.txt_suaDanhMuc.TabIndex = 4;
            // 
            // SuaDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 171);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_SuaDanhMuc);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_suaDanhMuc);
            this.Name = "SuaDanhMuc";
            this.Text = "SuaDanhMuc";
            this.Load += new System.EventHandler(this.SuaDanhMuc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Huy;
        private DevExpress.XtraEditors.SimpleButton btn_SuaDanhMuc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txt_suaDanhMuc;
    }
}