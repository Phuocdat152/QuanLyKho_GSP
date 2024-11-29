namespace GUI
{
    partial class SuaNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaNCC));
            this.txt_sSDT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_sEmail = new System.Windows.Forms.TextBox();
            this.txt_sDiaChi = new System.Windows.Forms.TextBox();
            this.txt_sTenNCC = new System.Windows.Forms.TextBox();
            this.txt_sMaNCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_sSDT
            // 
            this.txt_sSDT.Location = new System.Drawing.Point(142, 133);
            this.txt_sSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sSDT.Name = "txt_sSDT";
            this.txt_sSDT.Size = new System.Drawing.Size(165, 21);
            this.txt_sSDT.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 393);
            this.panel1.TabIndex = 1;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Appearance.Options.UseFont = true;
            this.btn_Sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.ImageOptions.Image")));
            this.btn_Sua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Sua.Location = new System.Drawing.Point(101, 319);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(125, 50);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Lưu";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_sEmail);
            this.groupControl1.Controls.Add(this.txt_sDiaChi);
            this.groupControl1.Controls.Add(this.txt_sSDT);
            this.groupControl1.Controls.Add(this.txt_sTenNCC);
            this.groupControl1.Controls.Add(this.txt_sMaNCC);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(330, 297);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chỉnh Sửa Thông Tin Nhà Cung Cấp";
            // 
            // txt_sEmail
            // 
            this.txt_sEmail.Location = new System.Drawing.Point(142, 232);
            this.txt_sEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sEmail.Name = "txt_sEmail";
            this.txt_sEmail.Size = new System.Drawing.Size(165, 21);
            this.txt_sEmail.TabIndex = 19;
            // 
            // txt_sDiaChi
            // 
            this.txt_sDiaChi.Location = new System.Drawing.Point(142, 180);
            this.txt_sDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sDiaChi.Name = "txt_sDiaChi";
            this.txt_sDiaChi.Size = new System.Drawing.Size(165, 21);
            this.txt_sDiaChi.TabIndex = 18;
            // 
            // txt_sTenNCC
            // 
            this.txt_sTenNCC.Location = new System.Drawing.Point(142, 86);
            this.txt_sTenNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sTenNCC.Name = "txt_sTenNCC";
            this.txt_sTenNCC.Size = new System.Drawing.Size(165, 21);
            this.txt_sTenNCC.TabIndex = 16;
            // 
            // txt_sMaNCC
            // 
            this.txt_sMaNCC.Enabled = false;
            this.txt_sMaNCC.Location = new System.Drawing.Point(142, 41);
            this.txt_sMaNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sMaNCC.Name = "txt_sMaNCC";
            this.txt_sMaNCC.Size = new System.Drawing.Size(165, 21);
            this.txt_sMaNCC.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số Điện Thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Nhà Cung Cấp:";
            // 
            // SuaNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 395);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SuaNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaNCC";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sSDT;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_Sua;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txt_sEmail;
        private System.Windows.Forms.TextBox txt_sDiaChi;
        private System.Windows.Forms.TextBox txt_sTenNCC;
        private System.Windows.Forms.TextBox txt_sMaNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}