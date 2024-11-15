using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class ThemDanhMuc : Form
    {
        private DanhMucThuocBLL _danhMucThuocBLL;
        public ThemDanhMuc(DanhMucThuocBLL danhMucThuocBLL)
        {
            InitializeComponent();
            _danhMucThuocBLL = danhMucThuocBLL;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ThemDanhMuc_Click(object sender, EventArgs e)
        {
            string tenDanhMuc = txt_addDanhMuc.Text.Trim();

            // Kiểm tra tên danh mục không để trống
            if (string.IsNullOrWhiteSpace(tenDanhMuc))
            {
                MessageBox.Show("Tên danh mục không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra trùng tên danh mục
            if (_danhMucThuocBLL.IsDuplicateTenDanhMuc(tenDanhMuc))
            {
                MessageBox.Show("Tên danh mục đã tồn tại. Vui lòng chọn tên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận trước khi thêm danh mục
            DialogResult result = MessageBox.Show($"Bạn có muốn thêm danh mục '{tenDanhMuc}' không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Tạo mới đối tượng DanhMucThuocDTO
                DanhMucThuocDTO danhMuc = new DanhMucThuocDTO
                {
                    TenDanhMuc = tenDanhMuc
                };

                // Gọi phương thức thêm danh mục thuốc
                if (_danhMucThuocBLL.AddDanhMucThuoc(danhMuc))
                {
                    MessageBox.Show("Thêm danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form và trở về form trước
                }
                else
                {
                    MessageBox.Show("Thêm danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form và trở về form trước
                }
                
            }
            else
            {
                // Nếu người dùng chọn "Không", để lại form mở để người dùng chỉnh sửa
                txt_addDanhMuc.Focus();
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
