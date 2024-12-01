using BLL;
using DevExpress.XtraBars;
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
    public partial class TrangNhanVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string username, password;
        private UserBLL userBLL;
        public TrangNhanVien(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            userBLL = new UserBLL(username, password);
            HienThiTenNhanVien(username);
        }

        void OpenForm<T>() where T : Form
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm is T)
                {
                    frm.Activate();
                    return;
                }
            }

            // Khởi tạo form với constructor có tham số
            Form f = (Form)Activator.CreateInstance(typeof(T), username, password);
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<NhapKho>();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<XuatKho>();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<ViTri>();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<SapXepThuoc>();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<TraCuuThuoc>();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<HuyThuoc>();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<QLDanhMucThuoc>();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<Quanlythuoc>();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoiMatKhau loginForm = new DoiMatKhau(username, password);
            loginForm.ShowDialog();
        }

        private void btn_DangXuat2_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                DangNhap loginForm = new DangNhap();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void HienThiTenNhanVien(string username)
        {
            try
            {
                DataRow nhanVienInfo = userBLL.GetNhanVienByUsername1(username);
                if (nhanVienInfo != null)
                {
                    string tenNhanVien = nhanVienInfo["TenNhanVien"].ToString();
                    //string idNhanVien = nhanVienInfo["IDNhanVien"].ToString();

                    btn_TenDangNhap2.Caption = tenNhanVien;   // Hiển thị tên nhân viên
                    //txt_IDNhanVien.Text = idNhanVien; // Lưu ID nhân viên vào TextBox ẩn
                }
                else
                {
                    btn_TenDangNhap2.Caption = "Không tìm thấy tên nhân viên";
                    //txt_IDNhanVien.Text = ""; // Xóa giá trị nếu không tìm thấy
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị tên nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}