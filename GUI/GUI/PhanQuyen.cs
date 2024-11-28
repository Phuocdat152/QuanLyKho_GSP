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
    public partial class PhanQuyen : Form
    {
        private string _maNhanVien;
        private UserBLL userBLL;

        public PhanQuyen(string maNhanVien, string username, string password)
        {
            InitializeComponent();
            _maNhanVien = maNhanVien;
            userBLL = new UserBLL(username, password);
            LoadNhanVienData();
            LoadChucVuData();
        }
        private void LoadNhanVienData()
        {
            UserDTO nhanVien = userBLL.GetNhanVienById(_maNhanVien);
            if (nhanVien != null)
            {
                lb_MaNV.Text = nhanVien.MaNhanVienID;
                lb_TenND.Text = nhanVien.Username;
                lb_TenNV.Text = nhanVien.TenNhanVien;
                cb_ChucVu.Text = nhanVien.ChucVu; // Hiển thị tên chức vụ
            }
        }
        private void LoadChucVuData()
        {
            DataTable chucVuTable = userBLL.GetAllChucVu();
            cb_ChucVu.DataSource = chucVuTable;
            cb_ChucVu.DisplayMember = "TenChucVu";
            cb_ChucVu.ValueMember = "IDChucVu";
        }

        private void btn_LuuPQ_Click(object sender, EventArgs e)
        {
            string selectedChucVuId = cb_ChucVu.SelectedValue.ToString();

            bool isUpdated = userBLL.UpdateNhanVien2(_maNhanVien, selectedChucVuId);
            if (isUpdated)
            {
                MessageBox.Show("Phân quyền thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Phân quyền thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
