﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class DangNhap : Form
    {

        public DangNhap()
        {
            InitializeComponent();
            txtMatKhau.KeyPress += new KeyPressEventHandler(txtMatKhau_KeyPress);
            txtTaiKhoan.KeyPress += new KeyPressEventHandler(txtMatKhau_KeyPress);

            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            



            string username = txtTaiKhoan.Text;
            string password = txtMatKhau.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserBLL userBLL = new UserBLL(username, password);

            if (userBLL.Login())
            {
                // Lấy chức vụ người dùng
                string role = userBLL.GetUserRole(username);

                // Xử lý logic hiển thị form dựa trên chức vụ
                if (role == "Quản lý")
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TrangChu mainForm = new TrangChu(username, password);
                    mainForm.Show();
                    this.Hide();
                }
                else if (role == "Nhân viên")
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NhapKho mainForm = new NhapKho(username, password);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XuatKho mainForm = new XuatKho(username, password);
                    mainForm.Show();
                    this.Hide();
                }
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; //Chặn xuống dòng
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; //Chặn xuống dòng
            }
        }
    }
}
