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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class QuanLyNCC: Form
    {
        private string username; // Lưu trữ thông tin tài khoản đăng nhập
        private string password; // Lưu trữ thông tin mật khẩu đăng nhập
        private NhaCungCapBLL nhaCungCapBLL;
        public QuanLyNCC(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            nhaCungCapBLL = new NhaCungCapBLL(username, password);

            this.Load += new EventHandler(QuanLyNCC_Load);

            // Sự kiện Click cho DataGridView
            dgv_DanhSach.CellClick += new DataGridViewCellEventHandler(dgv_DanhSach_CellClick);

            // Sự kiện Click cho nút Thêm Nhà Cung Cấp
            btn_ThemNCC.Click += new EventHandler(btn_ThemNCC_Click);

            // Sự kiện Click cho nút Sửa Nhà Cung Cấp
            btn_SuaNCC.Click += new EventHandler(btn_SuaNCC_Click);
        }

        private void QuanLyNCC_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhaCungCap();
        }
        private void LoadDanhSachNhaCungCap()
        {
            try
            {
                DataTable dt = nhaCungCapBLL.GetAllNhaCungCap();
                dgv_DanhSach.DataSource = dt;

                // Đặt tên cột hiển thị
                dgv_DanhSach.Columns["IDNhaCC"].HeaderText = "Mã Nhà Cung Cấp";
                dgv_DanhSach.Columns["TenNhaCC"].HeaderText = "Tên Nhà Cung Cấp";
                dgv_DanhSach.Columns["SDT"].HeaderText = "Số Điện Thoại";
                dgv_DanhSach.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgv_DanhSach.Columns["Email"].HeaderText = "Email";

                // Thiết lập AutoSizeColumnsMode để cột giãn đều
                dgv_DanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Nếu muốn cột "Mã Nhà Cung Cấp" nhỏ hơn, bạn có thể tùy chỉnh độ rộng
                dgv_DanhSach.Columns["IDNhaCC"].Width = 100; // Ví dụ: đặt độ rộng cụ thể cho cột đầu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ThemNCC_Click(object sender, EventArgs e)
        {
            ThemNCC themNCCForm = new ThemNCC(username, password); // Truyền tài khoản SQL Server
            themNCCForm.ShowDialog();
            LoadDanhSachNhaCungCap();
        }

        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo chỉ xử lý khi có dữ liệu được chọn
            {
                DataGridViewRow row = dgv_DanhSach.Rows[e.RowIndex];

                // Hiển thị thông tin trên các Label
                lb_MaNCC.Text = row.Cells["IDNhaCC"].Value.ToString();
                lb_TenNCC.Text = row.Cells["TenNhaCC"].Value.ToString();
                lb_SDT.Text = row.Cells["SDT"].Value.ToString();
                lb_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                lb_Email.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void btn_SuaNCC_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSach.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ dòng được chọn
                DataGridViewRow selectedRow = dgv_DanhSach.SelectedRows[0];
                string idNhaCC = selectedRow.Cells["IDNhaCC"].Value.ToString();
                string tenNhaCC = selectedRow.Cells["TenNhaCC"].Value.ToString();
                string sdt = selectedRow.Cells["SDT"].Value.ToString();
                string diaChi = selectedRow.Cells["DiaChi"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();

                // Mở form sửa thông tin và truyền username, password
                SuaNCC suaNCCForm = new SuaNCC(idNhaCC, tenNhaCC, sdt, diaChi, email, username, password);
                suaNCCForm.ShowDialog();
                LoadDanhSachNhaCungCap();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhà cung cấp để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
