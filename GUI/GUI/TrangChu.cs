using BLL;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string username, password;
        private UserBLL userBLL;
        public TrangChu(string username, string password)
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

        private void HienThiTenNhanVien(string username)
        {
            try
            {
                DataRow nhanVienInfo = userBLL.GetNhanVienByUsername1(username);
                if (nhanVienInfo != null)
                {
                    string tenNhanVien = nhanVienInfo["TenNhanVien"].ToString();
                    //string idNhanVien = nhanVienInfo["IDNhanVien"].ToString();

                    bar_TenDangNhap.Caption = tenNhanVien;   // Hiển thị tên nhân viên
                    //txt_IDNhanVien.Text = idNhanVien; // Lưu ID nhân viên vào TextBox ẩn
                }
                else
                {
                    bar_TenDangNhap.Caption = "Không tìm thấy tên nhân viên";
                    //txt_IDNhanVien.Text = ""; // Xóa giá trị nếu không tìm thấy
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị tên nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_CapPhat_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<XuatKho>();
        }

        private void btn_ViTri_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<ViTri>();
        }

        private void btn_LuuTru_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<SapXepThuoc>();
        }

        private void btn_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
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

        private void btn_TraCuuThuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<TraCuuThuoc>();
        }

        private void btn_HuyThuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<HuyThuoc>();
        }

        private void btn_KiemKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<KiemKeDoiChieu>();
        }

        private void btn_NhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<QuanLyNhanVien>();
        }

        private void btn_NhomThuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<QLDanhMucThuoc>();
        }

        private void btn_Thuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<Quanlythuoc>(); 
        }

        private void btn_NhaCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<QuanLyNCC>();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Hiển thị hộp thoại xác nhận đăng xuất
            DialogResult result = MessageBox.Show(
                "Bạn có muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Nếu người dùng chọn "Yes", mở form đăng nhập và đóng form hiện tại
                DangNhap formDangNhap = new DangNhap();
                formDangNhap.Show();
                this.Close(); // Đóng form hiện tại
            }
        }

        private void btn_QuanTriNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<QuanTriNguoiDung>();
        }

        private void btn_ThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<ThongkeBaocao>();

        }

        private void btn_SaoLuuPH_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<SaoLuuPhucHoi>();
        }

        private void btn_NhapKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<NhapKho>();
        }
    }
}