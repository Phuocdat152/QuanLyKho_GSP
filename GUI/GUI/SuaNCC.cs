using BLL;
using DTO;
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
    public partial class SuaNCC : Form
    {
        private string idNhaCC;
        private NhaCungCapBLL nhaCungCapBLL;

        public SuaNCC(string idNhaCC, string tenNhaCC, string sdt, string diaChi, string email, string username, string password)
        {
            InitializeComponent();
            this.idNhaCC = idNhaCC;
            nhaCungCapBLL = new NhaCungCapBLL(username, password); // Sử dụng username và password từ form gọi

            // Hiển thị thông tin lên các textbox
            txt_sMaNCC.Text = idNhaCC;
            txt_sTenNCC.Text = tenNhaCC;
            txt_sSDT.Text = sdt;
            txt_sDiaChi.Text = diaChi;
            txt_sEmail.Text = email;

            txt_sMaNCC.ReadOnly = true; // Không cho phép sửa mã nhà cung cấp
        }


        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Kiểm tra các textbox không được để trống
            if (string.IsNullOrWhiteSpace(txt_sTenNCC.Text))
            {
                MessageBox.Show("Tên Nhà Cung Cấp không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_sSDT.Text))
            {
                MessageBox.Show("Số Điện Thoại không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_sDiaChi.Text))
            {
                MessageBox.Show("Địa Chỉ không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_sEmail.Text))
            {
                MessageBox.Show("Email không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng NhaCungCapDTO để sửa
            var nhaCungCap = new NhaCungCapDTO
            {
                IDNhaCC = txt_sMaNCC.Text,
                TenNhaCC = txt_sTenNCC.Text,
                SDT = txt_sSDT.Text,
                DiaChi = txt_sDiaChi.Text,
                Email = txt_sEmail.Text
            };

            try
            {
                nhaCungCapBLL.SuaNhaCungCap(nhaCungCap);
                MessageBox.Show("Sửa thông tin nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
