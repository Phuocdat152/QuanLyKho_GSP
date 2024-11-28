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
            DataTable danhMucData = _danhMucThuocBLL.GetAllDanhMucThuoc();
            foreach (DataRow row in danhMucData.Rows)
            {
                if (row["IDDanhMuc"].ToString() == _maDanhMuc)
                {
                    cb_LoaiThuoc.SelectedItem = row["LoaiThuoc"].ToString();
                    break;
                }
            }
        }

        private void btn_SuaDanhMuc_Click(object sender, EventArgs e)
        {
            string tenDanhMucMoi = txt_suaDanhMuc.Text.Trim();
            string loaiThuocMoi = cb_LoaiThuoc.SelectedItem?.ToString();

            // Kiểm tra nếu tên danh mục hoặc loại thuốc trống
            if (string.IsNullOrWhiteSpace(tenDanhMucMoi) || string.IsNullOrWhiteSpace(loaiThuocMoi))
            {
                MessageBox.Show("Tên danh mục và loại thuốc không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hiển thị xác nhận thay đổi
            DialogResult result = MessageBox.Show(
                $"Bạn có muốn đổi tên danh mục từ '{_tenDanhMucCu}' thành '{tenDanhMucMoi}' và loại thuốc thành '{loaiThuocMoi}' không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Gọi phương thức BLL để cập nhật danh mục
                if (_danhMucThuocBLL.UpdateDanhMuc(_maDanhMuc, tenDanhMucMoi, loaiThuocMoi))
                {
                    MessageBox.Show("Chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form sau khi cập nhật thành công
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void txt_suaDanhMuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
