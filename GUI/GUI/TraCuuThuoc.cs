﻿using BLL;
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

        private void LoadThuocToComboBox()
        {
            try
            {
                // Gọi phương thức từ BLL để lấy dữ liệu
                DataTable thuocData = thuocBLL.GetThuocInfo();

                if (thuocData != null && thuocData.Rows.Count > 0)
                {
                    // Thiết lập dữ liệu cho ComboBox
                    cb_TenThuoc.DataSource = thuocData;
                    cb_TenThuoc.DisplayMember = "TenThuoc"; // Cột hiển thị tên thuốc
                    cb_TenThuoc.ValueMember = "IDThuoc";    // Cột giá trị là IDThuoc

                    // Đặt giá trị mặc định là chưa chọn
                    cb_TenThuoc.SelectedIndex = -1;
                }
                else
                {
                    // Xóa dữ liệu trong ComboBox nếu không có dữ liệu
                    cb_TenThuoc.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu thuốc vào ComboBox: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void TraCuuThuoc_Load(object sender, EventArgs e)
        {
            InitializeDataTable();
            ConfigureGridColumnHeaders();
            DisableCacCot();
            LoadTrangThaiToComboBox();
            LoadThuocToComboBox();
            CheckThuocSapHetHan();
            HienThiThongTinTraCuu();
            gv_TraCuu.RowStyle += gv_TraCuu_RowStyle;

        }

        private void cb_TenThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có dữ liệu nào được chọn trong ComboBox không
            if (cb_TenThuoc.SelectedValue != null)
            {
                string selectedIDThuoc = cb_TenThuoc.SelectedValue.ToString();

                // Gọi phương thức từ LuuTruBLL để lấy thông tin thuốc
                DataTable thuocInfo = luuTruBLL.TraCuuThuocTheoIDThuoc(selectedIDThuoc);

                // Kiểm tra nếu có dữ liệu trả về
                if (thuocInfo != null && thuocInfo.Rows.Count > 0)
                {
                    // Gán DataTable vào DataGridView hoặc GridControl để hiển thị
                    gc_TraCuu.DataSource = thuocInfo;
                }
                else
                {
                    // Xóa dữ liệu hiển thị nếu không có thông tin
                    gc_TraCuu.DataSource = null;
                }
            }
        }

        private void gv_TraCuu_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view == null) return;

            // Lấy giá trị NgayHetHan từ dòng hiện tại
            DateTime ngayHetHan = Convert.ToDateTime(view.GetRowCellValue(e.RowHandle, "NgayHetHan"));
            DateTime currentDate = DateTime.Now;

            // Kiểm tra nếu ngày hết hạn trong vòng 1 tháng
            if (ngayHetHan <= currentDate.AddMonths(1) && ngayHetHan >= currentDate)
            {
                // Tô màu đỏ cho các dòng sắp hết hạn
                e.Appearance.BackColor = Color.LightCoral;
                e.Appearance.ForeColor = Color.White;
            }
        }


        // Phương thức tải trạng thái vào ComboBox
        private void LoadTrangThaiToComboBox()
        {
            cb_TrangThai.Items.Clear();
            cb_TrangThai.Items.Add("Bình thường");
            cb_TrangThai.Items.Add("Hết hạn");
            cb_TrangThai.Items.Add("Sắp hết hạn");
            cb_TrangThai.SelectedIndex = -1;
        }

        private void cb_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem ComboBox có giá trị hợp lệ không
            if (cb_TrangThai.SelectedItem != null)
            {
                string selectedTrangThai = cb_TrangThai.SelectedItem.ToString();

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

        private void btn_TraCuu_Click(object sender, EventArgs e)
        {
            // Lấy ngày hết hạn từ DateTimePicker
            DateTime ngayHetHan = date_NgayHetHan.DateTime;

            // Gọi phương thức từ LuuTruBLL để tra cứu theo ngày hết hạn
            DataTable thuocInfo = luuTruBLL.TraCuuThuocTheoNgayHetHan(ngayHetHan);

            // Kiểm tra nếu có dữ liệu trả về
            if (thuocInfo != null && thuocInfo.Rows.Count > 0)
            {
                // Gán DataTable vào GridControl để hiển thị
                gc_TraCuu.DataSource = thuocInfo;
            }
            else
            {
                // Xóa dữ liệu hiển thị nếu không có thông tin
                gc_TraCuu.DataSource = null;
            }
        }

        private void CheckThuocSapHetHan()
        {
            DataTable dtSapHetHan = luuTruBLL.KiemTraThuocSapHetHan();

            if (dtSapHetHan != null && dtSapHetHan.Rows.Count > 0)
            {
                foreach (DataRow row in dtSapHetHan.Rows)
                {
                    string tenThuoc = row["TenThuoc"].ToString();
                    DateTime ngayHetHan = Convert.ToDateTime(row["NgayHetHan"]);
                    MessageBox.Show($"Thuốc '{tenThuoc}' sẽ hết hạn vào ngày {ngayHetHan:dd/MM/yyyy}.",
                                    "Thông Báo Thuốc Sắp Hết Hạn",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }

    }
}