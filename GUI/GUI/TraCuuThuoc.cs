using BLL;
using DAL;
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
    public partial class TraCuuThuoc : Form
    {
        private LuuTruBLL luuTruBLL;
        private DataTable dataTable;
        private ThuocBLL thuocBLL;
        public TraCuuThuoc(string username, string password)
        {
            InitializeComponent();
            luuTruBLL = new LuuTruBLL(username, password);
            thuocBLL = new ThuocBLL(username,password);
        }

        private void InitializeDataTable()
        {
            // Tạo một DataTable với các cột
            dataTable = new DataTable();
            dataTable.Columns.Add("IDChiTietPhieuNhap", typeof(string));
            dataTable.Columns.Add("IDThuoc", typeof(string));
            dataTable.Columns.Add("TenThuoc", typeof(string));
            dataTable.Columns.Add("SLTon", typeof(int));
            dataTable.Columns.Add("NgayNhap", typeof(DateTime));
            dataTable.Columns.Add("NgayHetHan", typeof(DateTime));
            dataTable.Columns.Add("Khu", typeof(string));
            dataTable.Columns.Add("Ke", typeof(string));
            dataTable.Columns.Add("O", typeof(string));
            dataTable.Columns.Add("TrangThai", typeof(string));

            // Gán DataTable rỗng vào GridControl để đảm bảo các cột xuất hiện
            gc_TraCuu.DataSource = dataTable;
        }

        private void ConfigureGridColumnHeaders()
        {
            var gridView = gc_TraCuu.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (gridView != null)
            {
                gridView.Columns["IDChiTietPhieuNhap"].Caption = "Mã CTPN";
                gridView.Columns["IDThuoc"].Caption = "Mã thuốc";
                gridView.Columns["TenThuoc"].Caption = "Tên thuốc";
                gridView.Columns["SLTon"].Caption = "Số lượng tồn";
                gridView.Columns["NgayNhap"].Caption = "Ngày nhập";
                gridView.Columns["NgayHetHan"].Caption = "Hạn sử dụng";
                gridView.Columns["Khu"].Caption = "Khu";
                gridView.Columns["Ke"].Caption = "Kệ";
                gridView.Columns["O"].Caption = "Ô";
                gridView.Columns["TrangThai"].Caption = "Trạng Thái";

                // Căn giữa tiêu đề của tất cả các cột
                foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                {
                    column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                }

                // Làm mới GridView để áp dụng các cài đặt
                gridView.RefreshData();
            }
        }


        private void DisableCacCot()
        {
            var gridView = gc_TraCuu.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            gridView.Columns["IDChiTietPhieuNhap"].OptionsColumn.AllowEdit = false; 
            gridView.Columns["IDThuoc"].OptionsColumn.AllowEdit = false;
            gridView.Columns["TenThuoc"].OptionsColumn.AllowEdit = false;
            gridView.Columns["SLTon"].OptionsColumn.AllowEdit = false;
            gridView.Columns["NgayNhap"].OptionsColumn.AllowEdit = false;
            gridView.Columns["NgayHetHan"].OptionsColumn.AllowEdit = false;
            gridView.Columns["Khu"].OptionsColumn.AllowEdit = false;
            gridView.Columns["Ke"].OptionsColumn.AllowEdit = false;
            gridView.Columns["O"].OptionsColumn.AllowEdit = false;
            gridView.Columns["TrangThai"].OptionsColumn.AllowEdit = false;
        }


        private void HienThiThongTinTraCuu()
        {
            try
            {
                // Gọi phương thức BLL để lấy dữ liệu
                DataTable dt = luuTruBLL.HienThiThongTinTraCuu();

                // Gán DataTable vào GridControl
                gc_TraCuu.DataSource = dt;

                // Làm mới lại GridView để hiển thị dữ liệu
                gv_TraCuu.RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị thông tin lưu trữ: " + ex.Message);
            }
        }

        



        private void TraCuuThuoc_Load(object sender, EventArgs e)
        {
            InitializeDataTable();
            ConfigureGridColumnHeaders();
            DisableCacCot();
            LoadTrangThaiToComboBox();
            CheckThuocSapHetHan();
            HienThiThongTinTraCuu();
            gv_TraCuu.RowStyle += gv_TraCuu_RowStyle;
            txt_TenThuoc.TextChanged += txt_TenThuoc_TextChanged;


        }



        private void gv_TraCuu_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view == null || e.RowHandle < 0) return;

            // Lấy giá trị cột "TrangThai" và "NgayHetHan" của dòng hiện tại
            string trangThai = view.GetRowCellValue(e.RowHandle, "TrangThai")?.ToString();
            DateTime ngayHetHan = Convert.ToDateTime(view.GetRowCellValue(e.RowHandle, "NgayHetHan"));
            DateTime currentDate = DateTime.Now;

            // Nếu thuốc sắp hết hạn, tô màu dòng
            if (trangThai == "Sắp hết hạn" || (ngayHetHan <= currentDate.AddMonths(1) && ngayHetHan >= currentDate))
            {
                e.Appearance.BackColor = Color.LightCoral;
                e.Appearance.ForeColor = Color.White;
            }
        }




        private void txt_TenThuoc_TextChanged(object sender, EventArgs e)
        {
            string tenThuoc = txt_TenThuoc.Text.Trim(); // Lấy giá trị từ TextBox

            if (!string.IsNullOrEmpty(tenThuoc))
            {
                try
                {
                    // Tìm kiếm thông tin thuốc theo tên
                    DataTable thuocInfo = luuTruBLL.TraCuuThuocTheoTenThuoc(tenThuoc);

                    if (thuocInfo != null && thuocInfo.Rows.Count > 0)
                    {
                        gc_TraCuu.DataSource = thuocInfo;
                    }
                    else
                    {
                        gc_TraCuu.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm thuốc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Nếu TextBox rỗng, hiển thị lại toàn bộ danh sách thuốc
                HienThiThongTinTraCuu();
            }
        }



        // Phương thức tải trạng thái vào ComboBox
        private void LoadTrangThaiToComboBox()
        {
            cb_TrangThai.Items.Clear();
            cb_TrangThai.Items.Add("Tất cả");
            cb_TrangThai.Items.Add("Bình thường");          
            cb_TrangThai.Items.Add("Sắp hết hạn");
            cb_TrangThai.SelectedIndex = -1;
        }

        private void cb_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem ComboBox có giá trị hợp lệ không
            if (cb_TrangThai.SelectedItem != null)
            {
                string selectedTrangThai = cb_TrangThai.SelectedItem.ToString();

                if (selectedTrangThai == "Tất cả")
                {
                    // Hiển thị tất cả trạng thái của thuốc
                    HienThiThongTinTraCuu();
                }
                else
                {
                    // Gọi phương thức từ BLL để tra cứu thuốc theo trạng thái
                    DataTable thuocData = luuTruBLL.TraCuuThuocTheoTrangThai(selectedTrangThai);

                    // Kiểm tra nếu có dữ liệu trả về
                    if (thuocData != null && thuocData.Rows.Count > 0)
                    {
                        // Hiển thị dữ liệu vào GridControl
                        gc_TraCuu.DataSource = thuocData;
                    }
                    else
                    {
                        // Xóa dữ liệu hiển thị nếu không có thông tin
                        gc_TraCuu.DataSource = null;
                    }
                }
            }
        }

        private void btn_TraCuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy khoảng thời gian từ giao diện
                DateTime ngayBatDau = date_NgayBatDau.DateTime;
                DateTime ngayKetThuc = date_NgayKetThuc.DateTime;

                // Gọi phương thức từ BLL
                DataTable thuocData = luuTruBLL.TraCuuThuocTheoKhoangThoiGian(ngayBatDau, ngayKetThuc);

                // Hiển thị dữ liệu trong GridControl
                if (thuocData != null && thuocData.Rows.Count > 0)
                {
                    gc_TraCuu.DataSource = thuocData;
                }
                else
                {
                    gc_TraCuu.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckThuocSapHetHan()
        {
            try
            {
                // Lấy danh sách thuốc sắp hết hạn
                DataTable dtSapHetHan = luuTruBLL.KiemTraThuocSapHetHan();

                if (dtSapHetHan != null && dtSapHetHan.Rows.Count > 0)
                {
                    foreach (DataRow row in dtSapHetHan.Rows)
                    {
                        string idLuuTru = row["IDLuuTru"].ToString();

                        // Cập nhật trạng thái thuốc thành "Sắp hết hạn"
                        luuTruBLL.CapNhatTrangThaiThuoc(idLuuTru, "Sắp hết hạn");
                    }
                }

                // Tải lại thông tin sau khi cập nhật
                HienThiThongTinTraCuu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra thuốc sắp hết hạn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            HienThiThongTinTraCuu();
            txt_TenThuoc.Text = "";
            cb_TrangThai.SelectedIndex = -1;
            date_NgayBatDau.EditValue = null;
            date_NgayKetThuc.EditValue = null;
        }
    }
}
