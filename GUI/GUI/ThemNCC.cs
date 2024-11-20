using BLL;
using DAL;
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
    public partial class ThemNCC : Form
    {
        private NhaCungCapBLL nhaCungCapBLL; // Khai báo biến BLL
        private string username; // Lưu thông tin username từ QuanLyNCC
        private string password; // Lưu thông tin password từ QuanLyNCC

        public ThemNCC(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            nhaCungCapBLL = new NhaCungCapBLL(username, password); // Khởi tạo BLL
        }


        private void ThemNCC_Load(object sender, EventArgs e)
        {
            txt_MaNCC.Text = GenerateNewID();
            txt_MaNCC.ReadOnly = true; // Không cho phép chỉnh sửa
        }
        private string GenerateNewID()
        {
            var allIDs = nhaCungCapBLL.GetAllTenNhaCC().Keys; // Lấy danh sách ID từ cơ sở dữ liệu
            int maxID = allIDs
                .Where(id => id.StartsWith("NCC"))
                .Select(id => int.Parse(id.Substring(3)))
                .DefaultIfEmpty(0)
                .Max();
            return "NCC" + (maxID + 1).ToString("0000");
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                var nhaCungCap = new NhaCungCapDTO
                {
                    IDNhaCC = txt_MaNCC.Text,
                    TenNhaCC = txt_TenNCC.Text,
                    SDT = txt_SDT.Text,
                    DiaChi = txt_DiaChi.Text,
                    Email = txt_Email.Text
                };

                nhaCungCapBLL.AddNhaCungCap(nhaCungCap);
                MessageBox.Show("Thêm nhà cung cấp thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhà cung cấp: " + ex.Message);
            }
        }
    }
}
