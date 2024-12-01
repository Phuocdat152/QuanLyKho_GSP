using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DoiMatKhau : Form
    {
        private string _username;
        private string _password;
        private UserBLL userBLL;
        public DoiMatKhau(string username, string password)
        {
            InitializeComponent();
            _username = username;
            _password = password;
            userBLL = new UserBLL(_username, _password); // Khởi tạo UserBLL với username và password
            txt_Username.Text = _username;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_DMKLuu_Click(object sender, EventArgs e)
        {
            string oldPassword = txt_OPass.Text;
            string newPassword = txt_NPass.Text;
            string confirmPassword = txt_CNPass.Text;

            // Kiểm tra nếu mật khẩu mới và mật khẩu xác nhận khớp nhau
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NPass.Focus();
                return;
            }

            // Gọi phương thức ChangePasswordWhenLoggedIn từ UserBLL
            bool isPasswordChanged = userBLL.DoiMatKhau(_username, oldPassword, newPassword);

            if (isPasswordChanged)
            {
                MessageBox.Show("Đổi mật khẩu thành công. Bạn cần đăng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Đặt DialogResult là OK để thông báo thành công
                this.Close(); // Đóng form đổi mật khẩu
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không chính xác. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_OPass.Focus();
            }
        }

        private void txt_Huy_Click(object sender, EventArgs e)
        {
            txt_OPass.Clear();
            txt_NPass.Clear();
            txt_CNPass.Clear();
        }

        private void btn_LuuMKM_Click(object sender, EventArgs e)
        {
            string oldPassword = txt_OPass.Text;
            string newPassword = txt_NPass.Text;
            string confirmPassword = txt_CNPass.Text;

            // Kiểm tra mật khẩu mới và xác nhận mật khẩu có khớp nhau không
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NPass.Focus();
                return;
            }

            // Gọi phương thức đổi mật khẩu từ BLL
            try
            {
                bool isPasswordChanged = userBLL.ChangeLoginPassword(_username, oldPassword, newPassword);

                if (isPasswordChanged)
                {
                    MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form sau khi đổi mật khẩu thành công
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại. Vui lòng kiểm tra lại mật khẩu cũ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_OPass.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đổi mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
