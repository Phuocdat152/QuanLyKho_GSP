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
    public partial class SuaDanhMuc : Form
    {
        private string _maDanhMuc;
        private string _tenDanhMucCu;
        private DanhMucThuocBLL _danhMucThuocBLL;
        public SuaDanhMuc(string maDanhMuc, string tenDanhMuc, DanhMucThuocBLL danhMucThuocBLL)
        {
            InitializeComponent();
            _maDanhMuc = maDanhMuc;
            _tenDanhMucCu = tenDanhMuc;
            _danhMucThuocBLL = danhMucThuocBLL; // Gán đối tượng BLL được truyền vào
            txt_suaDanhMuc.Text = tenDanhMuc;
        }

        private void SuaDanhMuc_Load(object sender, EventArgs e)
        {

        }

        private void btn_SuaDanhMuc_Click(object sender, EventArgs e)
        {
            string tenDanhMucMoi = txt_suaDanhMuc.Text.Trim();

            // Kiểm tra nếu tên không thay đổi
            if (string.IsNullOrWhiteSpace(tenDanhMucMoi))
            {
                MessageBox.Show("Tên danh mục không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tenDanhMucMoi.Equals(_tenDanhMucCu, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Tên danh mục không có thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hiển thị xác nhận thay đổi
            DialogResult result = MessageBox.Show(
                $"Bạn có muốn đổi tên danh mục từ '{_tenDanhMucCu}' thành '{tenDanhMucMoi}' không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Gọi phương thức BLL để cập nhật danh mục
                if (_danhMucThuocBLL.UpdateDanhMuc(_maDanhMuc, tenDanhMucMoi))
                {
                    MessageBox.Show("Chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form sau khi cập nhật thành công
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
