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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraCharts;


namespace GUI
{
    public partial class ViTri : Form
    {
        private ViTriBLL viTriBLL;
        public ViTri(string username, string password)
        {
            InitializeComponent();
            viTriBLL = new ViTriBLL(username, password);
            // Đăng ký sự kiện RowClick cho GridView
            GridView gridView = gc_ViTri.MainView as GridView;
            if (gridView != null)
            {
                gridView.RowClick += GridView_RowClick;
            }
        }

        private void LoadViTriData()
        {
            try
            {
                // Gọi phương thức GetThongTinViTri từ ViTriBLL để lấy dữ liệu vị trí
                DataTable dtViTri = viTriBLL.GetThongTinViTri();

                // Gán dữ liệu vào gridControl
                gc_ViTri.DataSource = dtViTri;

                // Đặt tên cột cho gridView
                GridView gridView = gc_ViTri.MainView as GridView;

                if (gridView != null)
                {
                    gridView.Columns["IDViTri"].Caption = "Mã vị Trí";
                    gridView.Columns["TenKhu"].Caption = "Tên Khu";
                    gridView.Columns["TenKe"].Caption = "Tên Kệ";
                    gridView.Columns["TenO"].Caption = "Tên Ô";
                    gridView.Columns["LoaiKhu"].Caption = "Loại Khu";

                    // Không cho phép chỉnh sửa trên gridView
                    gridView.OptionsBehavior.Editable = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu vị trí: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            // Kiểm tra điều kiện: các giá trị phải lớn hơn hoặc bằng 1
            if (num_Khu.Value < 1 || num_Ke.Value < 1 || num_O.Value < 1 || string.IsNullOrEmpty(cb_LoaiKhu.Text))
            {
                MessageBox.Show("Số lượng khu, kệ, ô phải lớn hơn hoặc bằng 1 và loại khu không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy giá trị từ các điều khiển nhập số
            int soLuongKhu = (int)num_Khu.Value;
            int soLuongKe = (int)num_Ke.Value;
            int soLuongO = (int)num_O.Value;
            string loaiKhu = cb_LoaiKhu.SelectedItem?.ToString();

            try
            {
                // Gọi hàm TaoKhuKeO trong ViTriBLL
                bool result = viTriBLL.TaoKhuKeO(soLuongKhu, soLuongKe, soLuongO, loaiKhu);

                if (result)
                {
                    MessageBox.Show("Thêm vị trí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadViTriData();

                    // Đặt lại các giá trị NumberUpDown và ComboBox về mặc định
                    num_Khu.Value = 0;
                    num_Ke.Value = 0;
                    num_O.Value = 0;
                    cb_LoaiKhu.SelectedIndex = -1;

                    // Cập nhật trạng thái các nút
                    btn_Huy.Enabled = false;
                    btn_Them.Enabled = true;
                    btn_Luu.Enabled = false;
                    num_Khu.Enabled = false;
                    num_Ke.Enabled = false;
                    num_O.Enabled = false;
                    cb_LoaiKhu.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thêm vị trí thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện RowClick của gridView
        private void GridView_RowClick(object sender, RowClickEventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null && view.GetFocusedDataRow() != null)
            {
                // Lấy dữ liệu từ các cột của dòng được chọn
                string tenKhu = view.GetFocusedRowCellValue("TenKhu")?.ToString();
                string tenKe = view.GetFocusedRowCellValue("TenKe")?.ToString();
                string tenO = view.GetFocusedRowCellValue("TenO")?.ToString();
                string loaiKhu = view.GetFocusedRowCellValue("LoaiKhu")?.ToString();

                // Hiển thị thông tin trong các TextBox
                txt_Khu.Text = tenKhu;
                txt_Ke.Text = tenKe;
                txt_O.Text = tenO;
                txt_LoaiKhu.Text = loaiKhu;
            }
        }

        private void ViTri_Load(object sender, EventArgs e)
        {
            LoadViTriData();
            // Thêm giá trị cho ComboBox Loại Khu
            cb_LoaiKhu.Items.Add("Khu thuốc nhập");
            cb_LoaiKhu.Items.Add("Khu thuốc hủy");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Huy.Enabled = true;
            btn_Them.Enabled = false;
            btn_Luu.Enabled = true;
            num_Khu.Enabled=true;
            num_Ke.Enabled=true;
            num_O.Enabled=true;
            cb_LoaiKhu.Enabled=true;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            btn_Huy.Enabled = false;
            btn_Them.Enabled = true;
            btn_Luu.Enabled = false;
            num_Khu.Enabled = false;
            num_Ke.Enabled = false;
            num_O.Enabled = false;
            cb_LoaiKhu.Enabled = false;

            // Reset các điều khiển
            num_Khu.Value = 0;
            num_Ke.Value = 0;
            num_O.Value = 0;
            cb_LoaiKhu.SelectedIndex = -1;
        }
    }
}
