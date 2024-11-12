using BLL;
using DAL;
using DevExpress.XtraEditors.Repository;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class SapXepThuoc : Form
    {
        private LuuTruBLL luuTruBLL;
        private KhoBLL khoBLL;
        private KhuBLL khuBLL;
        private KeBLL keBLL;
        private OBLL oLL;
        private DataTable dataTable;
        public SapXepThuoc(string username, string password)
        {
            InitializeComponent();
            luuTruBLL = new LuuTruBLL(username, password);
            khoBLL = new KhoBLL(username, password);
            khuBLL = new KhuBLL(username, password);
            keBLL = new KeBLL(username, password);
            InitializeDataTable();
            Load += SapXepThuoc_Load;

        }

        private void InitializeDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("TenThuoc", typeof(string));
            dataTable.Columns.Add("IDThuoc", typeof(string));
            dataTable.Columns.Add("IDChiTietPhieuNhap", typeof(string));
            dataTable.Columns.Add("SLTon", typeof(int));
            dataTable.Columns.Add("NgayNhap", typeof(DateTime));
            dataTable.Columns.Add("Khu", typeof(string));
            dataTable.Columns.Add("Ke", typeof(string));
            dataTable.Columns.Add("O", typeof(string));

            gc_ThuocChuaSapXep.DataSource = dataTable;
        }


        private void AddColumnsToGridView()
        {
            var captions = new[] { "Tên thuốc", "Mã thuốc", "Mã CTPN", "SL nhập", "Ngày nhập", "Khu", "Kệ", "Ô" };
            int captionCount = captions.Length;

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                var column = gv_ThuocChuaSapXep.Columns[dataTable.Columns[i].ColumnName];
                if (column != null && i < captionCount)
                {
                    column.Caption = captions[i];
                    column.Visible = true;
                }
            }
        }





        private void LoadComboBoxInTenThuocColumn()
        {
            try
            {
                // Lấy dữ liệu từ bảng ChiTietPhieuNhap qua BLL
                DataTable dtChiTietPhieuNhap = luuTruBLL.HienThiTatCaChiTietNhapKho();

                if (dtChiTietPhieuNhap == null || dtChiTietPhieuNhap.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu chi tiết phiếu nhập để hiển thị.");
                    return;
                }

                // Thêm cột UniqueID để làm khóa duy nhất, kết hợp IDThuoc và IDChiTietPhieuNhap
                dtChiTietPhieuNhap.Columns.Add("UniqueID", typeof(string), "IDThuoc + '-' + IDChiTietPhieuNhap");

                // Tạo RepositoryItemLookUpEdit cho cột "Tên thuốc"
                RepositoryItemLookUpEdit lookUpEditTenThuoc = new RepositoryItemLookUpEdit
                {
                    DataSource = dtChiTietPhieuNhap,
                    DisplayMember = "TenThuoc",  // Hiển thị tên thuốc trong ComboBox
                    ValueMember = "UniqueID",    // Sử dụng UniqueID để phân biệt các dòng
                    NullText = "Chọn tên thuốc"
                };

                // Thiết lập các cột hiển thị trong dropdown của LookUpEdit
                lookUpEditTenThuoc.PopulateColumns();
                lookUpEditTenThuoc.Columns["IDChiTietPhieuNhap"].Caption = "Mã CTPN";
                lookUpEditTenThuoc.Columns["IDThuoc"].Caption = "Mã Thuốc";
                lookUpEditTenThuoc.Columns["NgayHetHan"].Caption = "Ngày Hết Hạn";
                lookUpEditTenThuoc.Columns["QuyCach"].Caption = "Quy Cách";
                lookUpEditTenThuoc.Columns["SoLuong"].Caption = "Số Lượng";
                lookUpEditTenThuoc.Columns["GiaDonVi"].Caption = "Giá Đơn Vị";
                lookUpEditTenThuoc.Columns["NgayNhap"].Caption = "Ngày Nhập";
                lookUpEditTenThuoc.Columns["TenThuoc"].Caption = "Tên Thuốc";
                lookUpEditTenThuoc.Columns["UniqueID"].Visible = false; // Ẩn UniqueID

                // Xử lý sự kiện EditValueChanged để tự động điền dữ liệu khi chọn một dòng
                lookUpEditTenThuoc.EditValueChanged += (s, e) =>
                {
                    var editor = s as DevExpress.XtraEditors.LookUpEdit;
                    if (editor?.EditValue == null) return;

                    // Lấy thông tin từ dòng được chọn dựa trên UniqueID
                    DataRow selectedRow = (editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue) as DataRowView)?.Row;
                    if (selectedRow != null)
                    {
                        // Điền dữ liệu vào các cột tương ứng trong GridView
                        gv_ThuocChuaSapXep.SetFocusedRowCellValue("IDThuoc", selectedRow["IDThuoc"]);
                        gv_ThuocChuaSapXep.SetFocusedRowCellValue("IDChiTietPhieuNhap", selectedRow["IDChiTietPhieuNhap"]);
                        gv_ThuocChuaSapXep.SetFocusedRowCellValue("SLTon", selectedRow["SoLuong"]);
                        gv_ThuocChuaSapXep.SetFocusedRowCellValue("NgayNhap", selectedRow["NgayNhap"]);
                    }
                };

                // Gán LookUpEdit vào cột "Tên thuốc"
                var colTenThuoc = gv_ThuocChuaSapXep.Columns["TenThuoc"];
                if (colTenThuoc != null)
                {
                    colTenThuoc.ColumnEdit = lookUpEditTenThuoc;
                }

                gv_ThuocChuaSapXep.RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu vào ComboBox: " + ex.Message);
            }
        }



        private void LoadKhuComboBoxInGrid()
        {
            // Lấy dữ liệu từ KhuBLL để hiển thị trong ComboBox của cột Khu
            DataTable dtKhu = khuBLL.GetAllKhu();
            if (dtKhu == null || dtKhu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu khu để hiển thị.");
                return;
            }

            // Tạo RepositoryItemLookUpEdit cho cột Khu
            RepositoryItemLookUpEdit lookUpEditKhu = new RepositoryItemLookUpEdit
            {
                DataSource = dtKhu,
                DisplayMember = "TenKhu",   // Tên khu hiển thị
                ValueMember = "IDKhu",      // Giá trị được lưu là IDKhu
                NullText = "Chọn khu"       // Văn bản khi không chọn gì
            };

            // Cấu hình cột hiển thị trong LookUpEdit
            lookUpEditKhu.PopulateColumns();
            lookUpEditKhu.Columns["IDKhu"].Visible = false;
            lookUpEditKhu.Columns["TenKhu"].Caption = "Tên Khu";
            lookUpEditKhu.Columns["GhiChu"].Caption = "Ghi Chú";

            // Sự kiện khi người dùng chọn một khu từ ComboBox
            lookUpEditKhu.EditValueChanged += (s, e) =>
            {
                var editor = s as DevExpress.XtraEditors.LookUpEdit;
                if (editor?.EditValue == null) return;

                // Lấy IDKhu và TenKhu được chọn
                string selectedKhuId = editor.EditValue.ToString();
                string selectedKhuName = editor.GetColumnValue("TenKhu").ToString();

                // Cập nhật giá trị hiển thị của cột Khu trong GridView
                gv_ThuocChuaSapXep.SetFocusedRowCellValue("Khu", selectedKhuName);

                // Lưu giá trị vào GridView ngay lập tức để tránh mất trạng thái
                gv_ThuocChuaSapXep.PostEditor(); // Xác nhận thay đổi ngay lập tức

                // Tải danh sách kệ cho ComboBox ở cột Kệ dựa trên IDKhu
                LoadKeComboBoxForSelectedKhu(selectedKhuId);
            };

            // Gán LookUpEdit vào cột Khu
            gv_ThuocChuaSapXep.Columns["Khu"].ColumnEdit = lookUpEditKhu;
        }

        // Phương thức để tải danh sách kệ dựa trên IDKhu đã chọn
        private void LoadKeComboBoxForSelectedKhu(string idKhu)
        {
            // Lấy danh sách kệ từ BLL dựa trên IDKhu
            DataTable dtKe = keBLL.HienThiThongTinKeTheoIDKhu(idKhu);
            if (dtKe == null || dtKe.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu kệ cho khu đã chọn.");
                return;
            }

            // Tạo RepositoryItemLookUpEdit cho cột Kệ
            RepositoryItemLookUpEdit lookUpEditKe = new RepositoryItemLookUpEdit
            {
                DataSource = dtKe,
                DisplayMember = "TenKe",   // Hiển thị tên kệ
                ValueMember = "IDKe",      // Giá trị lưu là IDKe
                NullText = "Chọn kệ"       // Văn bản khi không chọn gì
            };

            lookUpEditKe.PopulateColumns();
            lookUpEditKe.Columns["IDKe"].Visible = false;
            lookUpEditKe.Columns["TenKe"].Caption = "Tên Kệ";
            lookUpEditKe.Columns["GhiChu"].Caption = "Ghi Chú";

            // Gán LookUpEdit vào cột Kệ trong GridView
            gv_ThuocChuaSapXep.Columns["Ke"].ColumnEdit = lookUpEditKe;
            gv_ThuocChuaSapXep.RefreshData(); // Làm mới để cập nhật
        }


        



        private void SapXepThuoc_Load(object sender, EventArgs e)
        {
            AddColumnsToGridView();
            LoadComboBoxInTenThuocColumn();
            LoadKhuComboBoxInGrid(); // Load dữ liệu cho ComboBox ở cột Khu khi khởi động
        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            DataRow newRow = dataTable.NewRow();
            dataTable.Rows.Add(newRow);

            gv_ThuocChuaSapXep.FocusedRowHandle = gv_ThuocChuaSapXep.RowCount - 1;
            gv_ThuocChuaSapXep.FocusedColumn = gv_ThuocChuaSapXep.VisibleColumns[0];
            gv_ThuocChuaSapXep.ShowEditor();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng nào được chọn
            int selectedRowHandle = gv_ThuocChuaSapXep.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                // Xác nhận việc xóa
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Xóa dòng từ GridView (nó sẽ tự động xóa khỏi DataTable do data binding)
                    gv_ThuocChuaSapXep.DeleteRow(selectedRowHandle);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa.");
            }
        }
    }
}
