namespace GUI
{
    partial class DoiMatKhau
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
            this.btn_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.btn_LuuMKM = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_CNPass = new System.Windows.Forms.TextBox();
            this.txt_NPass = new System.Windows.Forms.TextBox();
            this.txt_OPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Huy);
            this.panel1.Controls.Add(this.btn_LuuMKM);
            this.panel1.Controls.Add(this.txt_Username);
            this.panel1.Controls.Add(this.txt_CNPass);
            this.panel1.Controls.Add(this.txt_NPass);
            this.panel1.Controls.Add(this.txt_OPass);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 553);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Appearance.Options.UseFont = true;
            this.btn_Huy.ImageOptions.Image = global::GUI.Properties.Resources.cancel_32x32;
            this.btn_Huy.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Huy.Location = new System.Drawing.Point(332, 407);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(119, 58);
            this.btn_Huy.TabIndex = 23;
            this.btn_Huy.Text = "Huỷ";
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_LuuMKM
            // 
            this.btn_LuuMKM.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuMKM.Appearance.Options.UseFont = true;
            this.btn_LuuMKM.ImageOptions.Image = global::GUI.Properties.Resources.save_32x32;
            this.btn_LuuMKM.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_LuuMKM.Location = new System.Drawing.Point(139, 407);
            this.btn_LuuMKM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LuuMKM.Name = "btn_LuuMKM";
            this.btn_LuuMKM.Size = new System.Drawing.Size(119, 58);
            this.btn_LuuMKM.TabIndex = 22;
            this.btn_LuuMKM.Text = "Lưu";
            this.btn_LuuMKM.Click += new System.EventHandler(this.btn_LuuMKM_Click);
            // 
            // txt_Username
            // 
            this.txt_Username.Enabled = false;
            this.txt_Username.Location = new System.Drawing.Point(313, 180);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(243, 22);
            this.txt_Username.TabIndex = 21;
            // 
            // txt_CNPass
            // 
            this.txt_CNPass.Location = new System.Drawing.Point(313, 327);
            this.txt_CNPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CNPass.Name = "txt_CNPass";
            this.txt_CNPass.Size = new System.Drawing.Size(243, 22);
            this.txt_CNPass.TabIndex = 18;
            this.txt_CNPass.UseSystemPasswordChar = true;
            // 
            // txt_NPass
            // 
            this.txt_NPass.Location = new System.Drawing.Point(313, 274);
            this.txt_NPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NPass.Name = "txt_NPass";
            this.txt_NPass.Size = new System.Drawing.Size(243, 22);
            this.txt_NPass.TabIndex = 17;
            this.txt_NPass.UseSystemPasswordChar = true;
            // 
            // txt_OPass
            // 
            this.txt_OPass.Location = new System.Drawing.Point(313, 226);
            this.txt_OPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_OPass.Name = "txt_OPass";
            this.txt_OPass.Size = new System.Drawing.Size(243, 22);
            this.txt_OPass.TabIndex = 16;
            this.txt_OPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Xác nhận mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(75, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 551);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_CNPass;
        private System.Windows.Forms.TextBox txt_NPass;
        private System.Windows.Forms.TextBox txt_OPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Username;
        private DevExpress.XtraEditors.SimpleButton btn_LuuMKM;
        private DevExpress.XtraEditors.SimpleButton btn_Huy;
    }
}