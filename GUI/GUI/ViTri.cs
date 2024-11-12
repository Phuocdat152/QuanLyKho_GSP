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
            // Lấy giá trị từ các điều khiển nhập số
            int soLuongKhu = (int)num_Khu.Value;
            int soLuongKe = (int)num_Ke.Value;
            int soLuongO = (int)num_O.Value;

            try
            {
                // Gọi hàm TaoKhuKeO trong ViTriBLL
                bool result = viTriBLL.TaoKhuKeO(soLuongKhu, soLuongKe, soLuongO);

                if (result)
                {
                    MessageBox.Show("Thêm vị trí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadViTriData();
                    btn_Them.Enabled = true;
                    btn_Luu.Enabled = false;
                    num_Khu.Enabled = false;
                    num_Ke.Enabled = false;
                    num_O.Enabled = false;
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

        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null)
            {
                // Lấy dữ liệu từ các cột của hàng được chọn
                string tenKhu = view.GetFocusedRowCellValue("TenKhu")?.ToString();
                string tenKe = view.GetFocusedRowCellValue("TenKe")?.ToString();
                string tenO = view.GetFocusedRowCellValue("TenO")?.ToString();

                // Hiển thị thông tin trong các TextBox
                txt_Khu.Text = tenKhu;
                txt_Ke.Text = tenKe;
                txt_O.Text = tenO;
            }
        }

        private void ViTri_Load(object sender, EventArgs e)
        {
            LoadViTriData();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = false;
            btn_Luu.Enabled = true;
            num_Khu.Enabled=true;
            num_Ke.Enabled=true;
            num_O.Enabled=true;
        }
    }
}
