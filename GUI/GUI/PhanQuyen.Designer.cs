namespace GUI
{
    partial class PhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanQuyen));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_MaNV = new DevExpress.XtraEditors.LabelControl();
            this.lb_TenND = new DevExpress.XtraEditors.LabelControl();
            this.lb_TenNV = new DevExpress.XtraEditors.LabelControl();
            this.cb_ChucVu = new System.Windows.Forms.ComboBox();
            this.btn_LuuPQ = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_LuuPQ);
            this.groupControl1.Controls.Add(this.cb_ChucVu);
            this.groupControl1.Controls.Add(this.lb_TenNV);
            this.groupControl1.Controls.Add(this.lb_TenND);
            this.groupControl1.Controls.Add(this.lb_MaNV);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Location = new System.Drawing.Point(1, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(490, 388);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Phân Quyền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Chức vụ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Họ và Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã Nhân Viên:";
            // 
            // lb_MaNV
            // 
            this.lb_MaNV.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lb_MaNV.Appearance.Options.UseFont = true;
            this.lb_MaNV.Location = new System.Drawing.Point(242, 61);
            this.lb_MaNV.Name = "lb_MaNV";
            this.lb_MaNV.Size = new System.Drawing.Size(5, 28);
            this.lb_MaNV.TabIndex = 18;
            this.lb_MaNV.Text = ".";
            // 
            // lb_TenND
            // 
            this.lb_TenND.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lb_TenND.Appearance.Options.UseFont = true;
            this.lb_TenND.Location = new System.Drawing.Point(242, 104);
            this.lb_TenND.Name = "lb_TenND";
            this.lb_TenND.Size = new System.Drawing.Size(5, 28);
            this.lb_TenND.TabIndex = 19;
            this.lb_TenND.Text = ".";
            // 
            // lb_TenNV
            // 
            this.lb_TenNV.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lb_TenNV.Appearance.Options.UseFont = true;
            this.lb_TenNV.Location = new System.Drawing.Point(242, 148);
            this.lb_TenNV.Name = "lb_TenNV";
            this.lb_TenNV.Size = new System.Drawing.Size(5, 28);
            this.lb_TenNV.TabIndex = 20;
            this.lb_TenNV.Text = ".";
            // 
            // cb_ChucVu
            // 
            this.cb_ChucVu.FormattingEnabled = true;
            this.cb_ChucVu.Location = new System.Drawing.Point(242, 200);
            this.cb_ChucVu.Name = "cb_ChucVu";
            this.cb_ChucVu.Size = new System.Drawing.Size(144, 24);
            this.cb_ChucVu.TabIndex = 21;
            // 
            // btn_LuuPQ
            // 
            this.btn_LuuPQ.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuPQ.Appearance.Options.UseFont = true;
            this.btn_LuuPQ.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btn_LuuPQ.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_LuuPQ.Location = new System.Drawing.Point(151, 271);
            this.btn_LuuPQ.Name = "btn_LuuPQ";
            this.btn_LuuPQ.Size = new System.Drawing.Size(170, 69);
            this.btn_LuuPQ.TabIndex = 22;
            this.btn_LuuPQ.Text = "Lưu";
            this.btn_LuuPQ.Click += new System.EventHandler(this.btn_LuuPQ_Click);
            // 
            // PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 386);
            this.Controls.Add(this.groupControl1);
            this.Name = "PhanQuyen";
            this.Text = "PhanQuyen";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_LuuPQ;
        private System.Windows.Forms.ComboBox cb_ChucVu;
        private DevExpress.XtraEditors.LabelControl lb_TenNV;
        private DevExpress.XtraEditors.LabelControl lb_TenND;
        private DevExpress.XtraEditors.LabelControl lb_MaNV;
    }
}