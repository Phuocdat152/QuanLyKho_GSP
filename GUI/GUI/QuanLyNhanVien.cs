using BLL;
using System.Data;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace GUI
{
    public partial class QuanLyNhanVien : Form
    {
        private string _username;
        private string _password;
        private UserBLL userBLL;
        public QuanLyNhanVien(string username, string password)
        {
            InitializeComponent();
            _username = username;
            _password = password;
            userBLL = new UserBLL(_username, _password);

            btn_ThemNV.Click += new EventHandler(btn_ThemNV_Click);
            btn_SuaNV.Click += new EventHandler(btn_SuaNV_Click);
            btn_XoaNV.Click += new EventHandler(btn_XoaNV_Click);

            dgv_NhanVien.CellClick += new DataGridViewCellEventHandler(dgv_NhanVien_CellContentClick);

            LoadEmployeeData();

        }
        private void LoadEmployeeData()
        {
            ConfigureDataGridView(); // Đảm bảo các cột đã được cấu hình

            DataTable dt = userBLL.GetAllNhanVienWithChucVu();

            dgv_NhanVien.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dgv_NhanVien.Rows.Add(
                    row["IDNhanVien"].ToString(),
                    row["TenNhanVien"].ToString(),
                    row["Username"].ToString(),
                    row["ChucVu"].ToString(), // Tên chức vụ
                    row["TrinhDo"].ToString(),
                    Convert.ToDateTime(row["NgaySinh"]).ToString("dd/MM/yyyy"),
                    row["DiaChi"].ToString(),
                    row["Email"].ToString(),
                    row["SoDienThoai"].ToString()
                );
            }
        }

        private void btn_ThemNV_Click(object sender, System.EventArgs e)
        {
            ThemNguoiDung themNguoiDungForm = new ThemNguoiDung(_username, _password);
            // Khởi tạo form ThemNguoiDung

            // Đăng ký sự kiện để tải lại DataGridView khi thêm nhân viên thành công
            themNguoiDungForm.EmployeeAdded += (s, ev) => LoadEmployeeData();

            // Hiển thị form thêm nhân viên
            themNguoiDungForm.ShowDialog();
            
        }
        private void ConfigureDataGridView()
        {
            dgv_NhanVien.Columns.Clear();

            dgv_NhanVien.Columns.Add("MaNhanVien", "Mã Nhân Viên");
            dgv_NhanVien.Columns.Add("TenNhanVien", "Tên Nhân Viên");
            dgv_NhanVien.Columns.Add("Username", "Tên Người Dùng");
            dgv_NhanVien.Columns.Add("ChucVu", "Chức Vụ");
            dgv_NhanVien.Columns.Add("TrinhDo", "Trình Độ");
            dgv_NhanVien.Columns.Add("NgaySinh", "Ngày Sinh");
            dgv_NhanVien.Columns.Add("DiaChi", "Địa Chỉ");
            dgv_NhanVien.Columns.Add("Email", "Email");
            dgv_NhanVien.Columns.Add("SoDienThoai", "Số Điện Thoại");

            dgv_NhanVien.ReadOnly = true; // Đặt chế độ chỉ đọc
            dgv_NhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Tắt dòng trắng dư ở cuối
            dgv_NhanVien.AllowUserToAddRows = false;
        }


        private void dgv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_NhanVien.CurrentRow != null)
            {
                lb_MaNV.Text = dgv_NhanVien.CurrentRow.Cells["MaNhanVien"].Value.ToString();
                lb_TenNV.Text = dgv_NhanVien.CurrentRow.Cells["TenNhanVien"].Value.ToString();
                lb_TenND.Text = dgv_NhanVien.CurrentRow.Cells["Username"].Value.ToString();
                lb_ChucVu.Text = dgv_NhanVien.CurrentRow.Cells["ChucVu"].Value.ToString();
                lb_TrinhDo.Text = dgv_NhanVien.CurrentRow.Cells["TrinhDo"].Value.ToString();
                lb_NgaySinh.Text = dgv_NhanVien.CurrentRow.Cells["NgaySinh"].Value.ToString();
                lb_DiaChi.Text = dgv_NhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
                lb_Email.Text = dgv_NhanVien.CurrentRow.Cells["Email"].Value.ToString();
                lb_SDT.Text = dgv_NhanVien.CurrentRow.Cells["SoDienThoai"].Value.ToString();

                var selectedEmployeeID = dgv_NhanVien.CurrentRow.Cells["MaNhanVien"].Value.ToString();
                var employee = userBLL.GetUserById(selectedEmployeeID);
                if (employee?.Anh != null)
                {
                    using (MemoryStream ms = new MemoryStream(employee.Anh))
                    {
                        pb_AnhNV.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pb_AnhNV.Image = null;
                }
            }
        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lb_MaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa thông tin.");
                return;
            }

            UserDTO selectedUser = userBLL.GetUserById(lb_MaNV.Text);
            if (selectedUser == null)
            {
                MessageBox.Show("Không thể tìm thấy thông tin nhân viên.");
                return;
            }

            SuaThongTin suaThongTinForm = new SuaThongTin(selectedUser, userBLL);
            if (suaThongTinForm.ShowDialog() == DialogResult.OK)
            {
                LoadEmployeeData(); // Tải lại dữ liệu sau khi cập nhật thành công
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lb_MaNV.Text) || string.IsNullOrEmpty(lb_TenNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa.");
                return;
            }

            string maNhanVien = lb_MaNV.Text;
            string tenNhanVien = lb_TenNV.Text;
            string username = lb_TenND.Text; // Giả sử lb_TenND chứa tên đăng nhập

            // Hiển thị cảnh báo trước khi xóa
            DialogResult dialogResult = MessageBox.Show($"Bạn có muốn xóa nhân viên {maNhanVien} - {tenNhanVien} không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                // Thực hiện xóa nhân viên
                bool isDeleted = userBLL.DeleteUser(maNhanVien, username);

                if (isDeleted)
                {
                    MessageBox.Show("Xóa nhân viên thành công!");
                    LoadEmployeeData(); // Tải lại dữ liệu sau khi xóa thành công
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa nhân viên.");
                }
            }
        }


    }
}
