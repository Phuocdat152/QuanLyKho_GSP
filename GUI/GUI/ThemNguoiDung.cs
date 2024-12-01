using BLL;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace GUI
{
    public partial class ThemNguoiDung : Form
    {
        private string _username;
        private string _password;
        private UserBLL userBLL;
        public event EventHandler EmployeeAdded; // Sự kiện sẽ kích hoạt khi thêm thành công

        // Phương thức để kích hoạt sự kiện
        protected virtual void OnEmployeeAdded()
        {
            EmployeeAdded?.Invoke(this, EventArgs.Empty);
        }
        public ThemNguoiDung(string username, string password)
        {
            InitializeComponent();
            _username = username;
            _password = password;
            userBLL = new UserBLL(_username, _password);
        }

        private void btn_addNguoiDung_Click(object sender, EventArgs e)
        {
            string tenNhanVien = txt_addTen.Text;
            string chucVu = cb_addchucvu.SelectedValue.ToString();
            string username = txt_addTenTK.Text;
            string password = txt_addMatKhau.Text;
            string confirmPassword = txt_XacNhanMatKhau.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.");
                txt_addMatKhau.Focus();
                return;
            }

            if (userBLL.CheckDuplicateUsernameOrLogin(username))
            {
                MessageBox.Show("Username hoặc Login đã tồn tại. Vui lòng chọn tên khác.");
                txt_addTenTK.Focus();
                return;
            }

            // Chuyển đổi ảnh thành byte array
            byte[] anh = null;
            if (pb_Anh.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pb_Anh.Image.Save(ms, pb_Anh.Image.RawFormat);
                    anh = ms.ToArray();
                }
            }

            // Gọi phương thức AddUser với đầy đủ tham số
            try
            {
                bool success = userBLL.AddUser(
                    tenNhanVien,
                    chucVu,
                    username,
                    password,
                    confirmPassword,
                    dtp_NgaySinh.Value,        // Ngày sinh
                    txt_addDiaChi.Text,         // Địa chỉ
                    txt_addEmail.Text,          // Email
                    txt_addSDT.Text,            // Số điện thoại
                    cb_TrinhDo.Text,        // Trình độ
                    anh                         // Ảnh
                );

                if (success)
                {
                    MessageBox.Show("Thêm người dùng thành công.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm người dùng: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Thêm mã xử lý nếu cần hoặc để trống nếu không có chức năng nào
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Thêm mã xử lý nếu cần hoặc để trống nếu không có chức năng nào
        }

        private void ThemNguoiDung_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtChucVu = userBLL.GetChucVuList();
                cb_addchucvu.DataSource = dtChucVu;
                cb_addchucvu.DisplayMember = "TenChucVu";
                cb_addchucvu.ValueMember = "IDChucVu";

                // Tạo mã nhân viên mới
                string newMaNhanVien = userBLL.GenerateNewMaNhanVien();
                if (!string.IsNullOrEmpty(newMaNhanVien))
                {
                    txt_addTenTK.Text = newMaNhanVien;
                }
                else
                {
                    throw new Exception("Không thể tạo mã nhân viên mới.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu chức vụ hoặc mã nhân viên mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_TaiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pb_Anh.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void btn_addNhanVien_Click(object sender, EventArgs e)
        {
            string tenNhanVien = txt_addTen.Text;
            string chucVuID = cb_addchucvu.SelectedValue.ToString();
            string username = txt_addTenTK.Text;
            string password = txt_addMatKhau.Text;
            string confirmPassword = txt_XacNhanMatKhau.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.");
                return;
            }

            byte[] anh = null;
            if (pb_Anh.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pb_Anh.Image.Save(ms, pb_Anh.Image.RawFormat);
                    anh = ms.ToArray();
                }
            }

            try
            {
                if (userBLL.AddUser(
                        tenNhanVien,
                        chucVuID,
                        username,
                        password,
                        confirmPassword,
                        dtp_NgaySinh.Value,
                        txt_addDiaChi.Text,
                        txt_addEmail.Text,
                        txt_addSDT.Text,
                        cb_TrinhDo.Text,
                        anh))
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    OnEmployeeAdded(); // Kích hoạt sự kiện sau khi thêm thành công
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
