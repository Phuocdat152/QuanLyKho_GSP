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
    public partial class QLDanhMucThuoc : Form
    {
        private DanhMucThuocBLL _danhMucThuocBLL;
        public QLDanhMucThuoc(string username, string password)
        {
            InitializeComponent();
            _danhMucThuocBLL = new DanhMucThuocBLL(username, password); // Khởi tạo BLL với thông tin đăng nhập
            dgv_DanhMucThuoc.CellClick += new DataGridViewCellEventHandler(dgv_DanhMucThuoc_CellClick);

        }
        private void LoadDanhMucThuoc()
        {
            DataTable danhMucData = _danhMucThuocBLL.GetAllDanhMucThuoc();
            dgv_DanhMucThuoc.DataSource = danhMucData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemDanhMuc themDanhMucForm = new ThemDanhMuc(_danhMucThuocBLL);
            themDanhMucForm.ShowDialog();
            LoadDanhMucThuoc();
        }

        private void QLDanhMucThuoc_Load(object sender, EventArgs e)
        {
            LoadDanhMucThuoc();
        }

        private void dgv_DanhMucThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_DanhMucThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhMucThuoc.Rows[e.RowIndex];
                lb_MaDM.Text = row.Cells["IDDanhMuc"].Value.ToString();
                lb_TenDM.Text = row.Cells["TenDanhMuc"].Value.ToString();
            }
        }

        private void btn_SuaDM_Click(object sender, EventArgs e)
        {
            // Lấy thông tin mã và tên danh mục từ các label
            string maDanhMuc = lb_MaDM.Text;
            string tenDanhMuc = lb_TenDM.Text;

            // Mở form SuaDanhMuc với thông tin danh mục hiện tại và truyền DanhMucThuocBLL
            SuaDanhMuc suaDanhMucForm = new SuaDanhMuc(maDanhMuc, tenDanhMuc, _danhMucThuocBLL);
            suaDanhMucForm.ShowDialog();

            // Cập nhật lại dữ liệu nếu cần sau khi đóng form SuaDanhMuc
            LoadDanhMucThuoc();
        }

        private void btn_XoaDM_Click(object sender, EventArgs e)
        {
            string maDanhMuc = lb_MaDM.Text;
            string tenDanhMuc = lb_TenDM.Text;

            // Kiểm tra xem thông tin có tồn tại không
            if (string.IsNullOrWhiteSpace(maDanhMuc) || string.IsNullOrWhiteSpace(tenDanhMuc))
            {
                MessageBox.Show("Vui lòng chọn danh mục cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị xác nhận xóa
            DialogResult result = MessageBox.Show(
                $"Bạn có muốn xóa danh mục '{maDanhMuc}' - '{tenDanhMuc}' không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Gọi phương thức BLL để xóa danh mục
                bool isDeleted = _danhMucThuocBLL.DeleteDanhMuc(maDanhMuc);

                if (isDeleted)
                {
                    MessageBox.Show("Xóa danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhMucThuoc(); // Cập nhật lại danh sách danh mục sau khi xóa
                }
                else
                {
                    MessageBox.Show("Xóa danh mục thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LoadDanhMucThuoc();
        }
    }
}
