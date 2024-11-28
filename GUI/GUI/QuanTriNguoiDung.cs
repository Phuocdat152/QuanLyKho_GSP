using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class QuanTriNguoiDung : Form
    {
        private UserBLL userBLL;
        private string _username;
        private string _password;

        public QuanTriNguoiDung(string username, string password)
        {
            InitializeComponent();
            _username = username;
            _password = password;
            userBLL = new UserBLL(_username, _password);
            LoadUserData();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemNguoiDung themNguoiDungForm = new ThemNguoiDung(_username, _password);

            if (themNguoiDungForm.ShowDialog() == DialogResult.OK)
            {
                LoadUserData(); // Cập nhật lại danh sách sau khi thêm nhân viên
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QuanTriNguoiDung_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }
        private void LoadUserData()
        {
            try
            {
                // Lấy dữ liệu từ phương thức mới trong BLL
                DataTable dt = userBLL.GetAllNhanVienWithChucVuSimple();

                // Hiển thị dữ liệu lên DataGridView
                dgv_DanhSach.DataSource = dt;

                // Đặt tiêu đề cột
                dgv_DanhSach.Columns["IDNhanVien"].HeaderText = "Mã Nhân Viên";
                dgv_DanhSach.Columns["TenNhanVien"].HeaderText = "Họ và Tên";
                dgv_DanhSach.Columns["Username"].HeaderText = "Tên Người Dùng";
                dgv_DanhSach.Columns["ChucVu"].HeaderText = "Chức Vụ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_DanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSach.Rows[e.RowIndex];

                txt_MaNV.Text = row.Cells["IDNhanVien"].Value.ToString();
                txt_UserName.Text = row.Cells["Username"].Value.ToString();
                txt_HoTen.Text = row.Cells["TenNhanVien"].Value.ToString();
                txt_ChucVu.Text = row.Cells["ChucVu"].Value.ToString(); // Hiển thị tên chức vụ
                txt_MaNV.ReadOnly = true;
                txt_UserName.ReadOnly = true;
                txt_HoTen.ReadOnly = true;
                txt_ChucVu.ReadOnly = true;
            }
        }

        private void btn_XoaND_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa từ danh sách.");
                return;
            }

            string maNhanVien = txt_MaNV.Text;
            string tenNhanVien = txt_HoTen.Text;

            DialogResult result = MessageBox.Show($"Bạn có muốn xoá nhân viên sau không?\nMã nhân viên: {maNhanVien}\nTên nhân viên: {tenNhanVien}",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = userBLL.DeleteUser(maNhanVien, txt_UserName.Text);

                    if (success)
                    {
                        MessageBox.Show("Xóa nhân viên thành công.");
                        LoadUserData(); // Cập nhật lại danh sách nhân viên
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công. Vui lòng kiểm tra lại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message);
                }
            }
        }

        private void btn_CapNhatND_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaNV.Text))
            {
                MessageBox.Show("Hãy chọn một nhân viên để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNV = txt_MaNV.Text;
            string tenTK = txt_UserName.Text;
            string hoTen = txt_HoTen.Text;
            string chucVu = txt_ChucVu.Text;

            CapNhat capNhatForm = new CapNhat(maNV, tenTK, hoTen, chucVu, _username, _password);
            capNhatForm.ShowDialog();

            LoadUserData();
        }

        private void btn_CapLaiMatKhau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaNV.Text) || string.IsNullOrWhiteSpace(txt_UserName.Text))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để đặt lại mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin người dùng
            string username = txt_UserName.Text; // Sử dụng Username làm Login
            string tenNhanVien = txt_HoTen.Text;

            // Hiển thị thông báo xác nhận
            DialogResult result = MessageBox.Show(
                $"Bạn có muốn đặt lại mật khẩu cho người dùng \"{tenNhanVien}\" không?",
                "Xác nhận đặt lại mật khẩu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Đặt lại mật khẩu thành "123"
                    bool success = userBLL.ResetUserPassword(username, "123");

                    if (success)
                    {
                        MessageBox.Show("Đặt lại mật khẩu thành công. Mật khẩu mới là: 123", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đặt lại mật khẩu không thành công. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đặt lại mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_PhanQuyen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để phân quyền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã nhân viên
            string maNhanVien = txt_MaNV.Text;

            // Mở form PhanQuyen
            PhanQuyen phanQuyenForm = new PhanQuyen(maNhanVien, _username, _password);
            phanQuyenForm.ShowDialog();

            // Tải lại dữ liệu sau khi phân quyền
            LoadUserData();
        }
    }
}
