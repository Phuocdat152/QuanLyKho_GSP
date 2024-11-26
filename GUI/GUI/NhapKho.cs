using BLL;
using DAL;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
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
using DTO;

namespace GUI
{
    public partial class NhapKho : Form
    {
        private NhaCungCapBLL nhaCungCapBLL;
        private KhoBLL khoBLL;
        private ThuocBLL thuocBLL;
        private NhapKhoBLL nhapKhoBLL;
        private UserBLL userBLL;
        private Dictionary<string, string> drugIDNameDict = new Dictionary<string, string>();
        private RepositoryItemComboBox comboBoxTenThuoc; 
        string username, password;

        public NhapKho(string username, string password)
        {
            InitializeComponent();
            nhaCungCapBLL = new NhaCungCapBLL(username, password);
            khoBLL = new KhoBLL(username, password);
            thuocBLL = new ThuocBLL(username, password);
            nhapKhoBLL = new NhapKhoBLL(username, password);
            userBLL = new UserBLL(username, password);

            HienThiTenNhanVien(username);

            this.username = username;
            this.password = password;
        }

        private void LoadNhaCungCapToComboBox()
        {
            try
            {
                Dictionary<string, string> nhaCCList = nhaCungCapBLL.GetAllTenNhaCC();

                cb_NhaCC.Items.Clear();

                foreach (var item in nhaCCList)
                {
                    cb_NhaCC.Items.Add(new KeyValuePair<string, string>(item.Key, item.Value));
                }

                cb_NhaCC.DisplayMember = "Value";
                cb_NhaCC.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải tên nhà cung cấp: " + ex.Message);
            }
        }

        private void LoadKhoToComboBox()
        {
            try
            {
                Dictionary<string, string> loaiKhoList = khoBLL.GetAllLoaiKho();

                cb_Kho.Items.Clear();

                foreach (var item in loaiKhoList)
                {
                    cb_Kho.Items.Add(new KeyValuePair<string, string>(item.Key, item.Value));
                }

                cb_Kho.DisplayMember = "Value";
                cb_Kho.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải loại kho: " + ex.Message);
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
                    string idNhanVien = nhanVienInfo["IDNhanVien"].ToString();

                    txt_NhanVien.Text = tenNhanVien;   // Hiển thị tên nhân viên
                    txt_IDNhanVien.Text = idNhanVien; // Lưu ID nhân viên vào TextBox ẩn
                }
                else
                {
                    txt_NhanVien.Text = "Không tìm thấy tên nhân viên";
                    txt_IDNhanVien.Text = ""; // Xóa giá trị nếu không tìm thấy
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị tên nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NhapKho_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhieuNhap();
            LoadNhaCungCapToComboBox();
            LoadKhoToComboBox();
            LoadThuocIntoSearchLookUpEdit();
            AddCot();

            dte_NgayNhap.EditValue = DateTime.Today;

            gv_SanPham.CellValueChanged += gv_SanPham_CellValueChanged;
            CalculateTotalAmount();

            // Đăng ký sự kiện thay đổi ComboBox
            //cb_NhaCC.SelectedIndexChanged += Cb_NhaCC_SelectedIndexChanged;
            //cb_Kho.SelectedIndexChanged += Cb_Kho_SelectedIndexChanged;

            // Đăng ký sự kiện click trong DataGridView
            dgv_PhieuNhap.CellClick += dgv_PhieuNhap_CellClick;

            // Đăng ký sự kiện cho các nút bấm
            btn_XoaSP.Click += btn_XoaSP_Click;
            btn_Them.Click += btn_Them_Click;
            btn_Luu.Click += btn_Luu_Click;
        }






        private void AddCot()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("IDThuoc", typeof(string));       // Mã thuốc
            dataTable.Columns.Add("TenThuoc", typeof(string));      // Tên thuốc
            dataTable.Columns.Add("ThanhPhan", typeof(string));     // Thành phần
            dataTable.Columns.Add("TenDVT", typeof(string));        // Đơn vị tính
            dataTable.Columns.Add("NgaySanXuat", typeof(DateTime)); // Ngày sản xuất
            dataTable.Columns.Add("NgayHetHan", typeof(DateTime));  // Ngày hết hạn
            dataTable.Columns.Add("SoLuong", typeof(int));          // Số lượng
            dataTable.Columns.Add("DonGia", typeof(decimal));       // Đơn giá
            dataTable.Columns.Add("ThanhTien", typeof(decimal));    // Thành tiền

            // Gán DataTable làm nguồn dữ liệu cho GridControl
            gc_SanPham.DataSource = dataTable;

            // Tạo các cột từ DataTable
            gv_SanPham.PopulateColumns();

            // Đặt tên hiển thị cho các cột
            if (gv_SanPham.Columns["IDThuoc"] != null)
                gv_SanPham.Columns["IDThuoc"].Caption = "Mã Thuốc";

            if (gv_SanPham.Columns["TenThuoc"] != null)
                gv_SanPham.Columns["TenThuoc"].Caption = "Tên Thuốc";

            if (gv_SanPham.Columns["ThanhPhan"] != null)
                gv_SanPham.Columns["ThanhPhan"].Caption = "Thành Phần";

            if (gv_SanPham.Columns["TenDVT"] != null)
                gv_SanPham.Columns["TenDVT"].Caption = "ĐVT";

            if (gv_SanPham.Columns["NgaySanXuat"] != null)
                gv_SanPham.Columns["NgaySanXuat"].Caption = "Ngày Sản Xuất";

            if (gv_SanPham.Columns["NgayHetHan"] != null)
                gv_SanPham.Columns["NgayHetHan"].Caption = "Ngày Hết Hạn";

            if (gv_SanPham.Columns["SoLuong"] != null)
                gv_SanPham.Columns["SoLuong"].Caption = "Số Lượng";

            if (gv_SanPham.Columns["DonGia"] != null)
                gv_SanPham.Columns["DonGia"].Caption = "Đơn Giá";

            if (gv_SanPham.Columns["ThanhTien"] != null)
            {
                gv_SanPham.Columns["ThanhTien"].Caption = "Thành Tiền";

                // Định dạng hiển thị tiền tệ
                gv_SanPham.Columns["ThanhTien"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gv_SanPham.Columns["ThanhTien"].DisplayFormat.FormatString = "#,##0 ₫";
            }

            // Định dạng các cột ngày tháng
            RepositoryItemDateEdit dateEdit = new RepositoryItemDateEdit();
            dateEdit.DisplayFormat.FormatString = "dd/MM/yyyy";
            dateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateEdit.EditFormat.FormatString = "dd/MM/yyyy";
            dateEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;

            if (gv_SanPham.Columns["NgaySanXuat"] != null)
                gv_SanPham.Columns["NgaySanXuat"].ColumnEdit = dateEdit;

            if (gv_SanPham.Columns["NgayHetHan"] != null)
                gv_SanPham.Columns["NgayHetHan"].ColumnEdit = dateEdit;
        }








        private void LoadThuocIntoSearchLookUpEdit()
        {
            try
            {
                // Lấy dữ liệu thuốc từ BLL
                DataTable dtThuoc = thuocBLL.GetThuocInfo();

                if (dtThuoc != null && dtThuoc.Rows.Count > 0)
                {
                    cb_ChonThuoc.Properties.DataSource = dtThuoc;
                    cb_ChonThuoc.Properties.DisplayMember = "TenThuoc";
                    cb_ChonThuoc.Properties.ValueMember = "IDThuoc";

                    cb_ChonThuoc.Properties.PopulateViewColumns();
                    var view = cb_ChonThuoc.Properties.View;

                    if (view.Columns["IDThuoc"] != null)
                        view.Columns["IDThuoc"].Caption = "Mã Thuốc";

                    if (view.Columns["TenThuoc"] != null)
                        view.Columns["TenThuoc"].Caption = "Tên Thuốc";

                    if (view.Columns["ThanhPhan"] != null)
                        view.Columns["ThanhPhan"].Caption = "Thành Phần";

                    if (view.Columns["TenDVT"] != null)
                        view.Columns["TenDVT"].Caption = "Đơn Vị Tính";

                    if (view.Columns["DonGia"] != null)
                        view.Columns["DonGia"].Caption = "Đơn Giá";

                    if (view.Columns["IDLoaiThuoc"] != null)
                        view.Columns["IDLoaiThuoc"].Visible = false;

                    view.OptionsBehavior.Editable = false;

                    cb_ChonThuoc.Properties.NullText = "Chọn thuốc...";
                    view.RowClick += View_RowClick;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu thuốc để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu thuốc: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
                DataRow selectedRow = view.GetDataRow(e.RowHandle);

                if (selectedRow != null)
                {
                    string idThuoc = selectedRow["IDThuoc"].ToString();
                    string tenThuoc = selectedRow["TenThuoc"].ToString();
                    string thanhPhan = selectedRow["ThanhPhan"].ToString();
                    string tenDVT = selectedRow["TenDVT"].ToString(); // Sửa từ "DVT" thành "TenDVT"
                    decimal donGia = Convert.ToDecimal(selectedRow["DonGia"]);

                    DataTable dt = gc_SanPham.DataSource as DataTable;

                    if (dt == null)
                    {
                        AddCot(); // Khởi tạo cấu trúc nếu chưa có
                        dt = gc_SanPham.DataSource as DataTable;
                    }

                    bool isExists = dt.AsEnumerable().Any(row => row.Field<string>("IDThuoc") == idThuoc);

                    if (isExists)
                    {
                        MessageBox.Show($"Thuốc '{tenThuoc}' đã có trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DataRow newRow = dt.NewRow();
                    newRow["IDThuoc"] = idThuoc;
                    newRow["TenThuoc"] = tenThuoc;
                    newRow["ThanhPhan"] = thanhPhan;
                    newRow["TenDVT"] = tenDVT; // Sửa từ "DVT" thành "TenDVT"
                    newRow["DonGia"] = donGia;
                    newRow["SoLuong"] = 0; // Người dùng nhập sau
                    newRow["ThanhTien"] = 0;

                    dt.Rows.Add(newRow);
                    gc_SanPham.RefreshDataSource();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm thuốc vào danh sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        private void gv_SanPham_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            // Kiểm tra xem có phải cột "SoLuong" hoặc "DonGia" thay đổi không
            if (e.Column.FieldName == "SoLuong" || e.Column.FieldName == "DonGia")
            {
                // Cập nhật lại Thành tiền cho dòng hiện tại
                UpdateThanhTienForRow(e.RowHandle);
            }

            // Sau khi cập nhật Thành tiền, tính lại tổng tiền
            CalculateTotalAmount();
        }


        private void UpdateThanhTienForRow(int rowHandle)
        {
            // Lấy giá trị Số lượng và Đơn giá từ dòng hiện tại
            object soLuongObj = gv_SanPham.GetRowCellValue(rowHandle, "SoLuong");
            object donGiaObj = gv_SanPham.GetRowCellValue(rowHandle, "DonGia");

            // Kiểm tra nếu cả Số lượng và Đơn giá đều hợp lệ và không rỗng
            if (soLuongObj != DBNull.Value && soLuongObj != null && donGiaObj != DBNull.Value && donGiaObj != null)
            {
                int soLuong;
                decimal donGia;

                // Kiểm tra nếu giá trị chuyển đổi thành công
                if (int.TryParse(soLuongObj.ToString(), out soLuong) && decimal.TryParse(donGiaObj.ToString(), out donGia))
                {
                    // Tính Thành tiền và cập nhật lại cho dòng hiện tại
                    decimal thanhTien = soLuong * donGia;
                    gv_SanPham.SetRowCellValue(rowHandle, "ThanhTien", thanhTien);
                }
                else
                {
                    // Nếu không hợp lệ, đặt Thành tiền là 0
                    gv_SanPham.SetRowCellValue(rowHandle, "ThanhTien", 0);
                }
            }
            else
            {
                // Nếu không hợp lệ, đặt Thành tiền là 0
                gv_SanPham.SetRowCellValue(rowHandle, "ThanhTien", 0);
            }
        }



        private void CalculateTotalAmount()
        {
            // Khai báo biến để lưu tổng tiền
            decimal totalAmount = 0;

            // Duyệt qua tất cả các dòng trong GridView
            for (int i = 0; i < gv_SanPham.RowCount; i++)
            {
                // Lấy giá trị Thành tiền của dòng hiện tại
                object thanhTienObj = gv_SanPham.GetRowCellValue(i, "ThanhTien");

                // Kiểm tra nếu Thành tiền không phải DBNull và không rỗng
                if (thanhTienObj != DBNull.Value && thanhTienObj != null)
                {
                    decimal thanhTien;

                    // Chuyển đổi thành công giá trị Thành tiền
                    if (decimal.TryParse(thanhTienObj.ToString(), out thanhTien))
                    {
                        // Cộng vào tổng tiền
                        totalAmount += thanhTien;
                    }
                }
            }

            // Cập nhật tổng tiền vào TextBox với định dạng tiền tệ
            txt_TongTien.Text = totalAmount.ToString("#,##0 ₫");  // Định dạng tiền tệ
        }








        private void btn_XoaSP_Click(object sender, EventArgs e)
        {
            if (gv_SanPham.FocusedRowHandle < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataTable dataTable = (DataTable)gc_SanPham.DataSource;
                int selectedRowIndex = gv_SanPham.FocusedRowHandle;

                // Xóa dòng khỏi DataTable
                dataTable.Rows[selectedRowIndex].Delete();


                // Cập nhật lại GridControl
                gc_SanPham.RefreshDataSource();
                gv_SanPham.RefreshData();

                CalculateTotalAmount() ;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Tạo một DataTable trống để sử dụng làm nguồn dữ liệu nếu GridControl chưa có
            if (!(gc_SanPham.DataSource is DataTable))
            {
                InitializeSanPhamGridColumns(); // Khởi tạo cột nếu chưa tồn tại
            }

            // Đảm bảo làm sạch dữ liệu GridControl
            DataTable dataTable = (DataTable)gc_SanPham.DataSource;
            dataTable.Clear();

            // Làm mới lại GridView
            gv_SanPham.RefreshData();

            // Xóa dữ liệu trong các TextBox
            txt_GhiChu.Clear();
            txt_TongTien.Clear();
            txt_TrangThai.Clear();
            txt_NhanVien.Clear();

            // Bật lại các TextBox và ComboBox để cho phép nhập liệu
            txt_GhiChu.Enabled = true;
            cb_Kho.Enabled = true;
            cb_NhaCC.Enabled = true;
            cb_ChonThuoc.Enabled = true;

            // Đặt trạng thái ComboBox về không chọn
            cb_Kho.SelectedIndex = -1;
            cb_NhaCC.SelectedIndex = -1;

            // Đặt giá trị mặc định cho Ngày nhập
            dte_NgayNhap.EditValue = DateTime.Today;

            // Bật và tắt các nút phù hợp
            btn_Luu.Enabled = true;
            btn_XoaSP.Enabled = true;
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Them1Thuoc.Enabled = true;

            // Cập nhật lại tổng tiền về 0
            txt_TongTien.Text = "0 ₫";
            InitializeSanPhamGridColumns();
        }

        private void InitializeSanPhamGridColumns()
        {
            // Tạo DataTable với cấu trúc cột cần thiết
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("IDThuoc", typeof(string));       // Mã thuốc
            dataTable.Columns.Add("TenThuoc", typeof(string));      // Tên thuốc
            dataTable.Columns.Add("ThanhPhan", typeof(string));     // Thành phần
            dataTable.Columns.Add("TenDVT", typeof(string));        // Đơn vị tính
            dataTable.Columns.Add("NgaySanXuat", typeof(DateTime)); // Ngày sản xuất
            dataTable.Columns.Add("NgayHetHan", typeof(DateTime));  // Ngày hết hạn
            dataTable.Columns.Add("SoLuong", typeof(int));          // Số lượng
            dataTable.Columns.Add("DonGia", typeof(decimal));       // Đơn giá
            dataTable.Columns.Add("ThanhTien", typeof(decimal));    // Thành tiền

            // Gán DataTable làm nguồn dữ liệu cho GridControl
            gc_SanPham.DataSource = dataTable;

            // Khởi tạo cột trong GridView từ DataTable
            gv_SanPham.PopulateColumns();

            // Đặt tên hiển thị (Caption) cho từng cột
            gv_SanPham.Columns["IDThuoc"].Caption = "Mã Thuốc";
            gv_SanPham.Columns["TenThuoc"].Caption = "Tên Thuốc";
            gv_SanPham.Columns["ThanhPhan"].Caption = "Thành Phần";
            gv_SanPham.Columns["TenDVT"].Caption = "Đơn Vị Tính";
            gv_SanPham.Columns["NgaySanXuat"].Caption = "Ngày Sản Xuất";
            gv_SanPham.Columns["NgayHetHan"].Caption = "Ngày Hết Hạn";
            gv_SanPham.Columns["SoLuong"].Caption = "Số Lượng";
            gv_SanPham.Columns["DonGia"].Caption = "Đơn Giá";
            gv_SanPham.Columns["ThanhTien"].Caption = "Thành Tiền";

            // Định dạng cột "Thành tiền" là tiền tệ
            GridColumn colThanhTien = gv_SanPham.Columns["ThanhTien"];
            if (colThanhTien != null)
            {
                colThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                colThanhTien.DisplayFormat.FormatString = "#,##0 ₫"; // Định dạng với dấu phân cách hàng nghìn và ký hiệu "₫"
            }

            // Định dạng ngày cho các cột Ngày sản xuất và Ngày hết hạn
            RepositoryItemDateEdit dateEdit = new RepositoryItemDateEdit
            {
                DisplayFormat = { FormatString = "dd/MM/yyyy", FormatType = DevExpress.Utils.FormatType.DateTime },
                EditFormat = { FormatString = "dd/MM/yyyy", FormatType = DevExpress.Utils.FormatType.DateTime }
            };

            gv_SanPham.Columns["NgaySanXuat"].ColumnEdit = dateEdit;
            gv_SanPham.Columns["NgayHetHan"].ColumnEdit = dateEdit;

            // Tùy chỉnh độ rộng các cột nếu cần
            gv_SanPham.Columns["IDThuoc"].Width = 100;
            gv_SanPham.Columns["TenThuoc"].Width = 200;
            gv_SanPham.Columns["ThanhPhan"].Width = 200;
            gv_SanPham.Columns["TenDVT"].Width = 100;
            gv_SanPham.Columns["NgaySanXuat"].Width = 120;
            gv_SanPham.Columns["NgayHetHan"].Width = 120;
            gv_SanPham.Columns["SoLuong"].Width = 80;
            gv_SanPham.Columns["DonGia"].Width = 100;
            gv_SanPham.Columns["ThanhTien"].Width = 120;

            // Căn giữa hoặc căn chỉnh cột
            //gv_SanPham.Columns["IDThuoc"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //gv_SanPham.Columns["TenThuoc"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            //gv_SanPham.Columns["ThanhPhan"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            //gv_SanPham.Columns["TenDVT"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //gv_SanPham.Columns["SoLuong"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //gv_SanPham.Columns["DonGia"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            //gv_SanPham.Columns["ThanhTien"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;

            // Căn giữa tiêu đề các cột
            foreach (GridColumn column in gv_SanPham.Columns)
            {
                column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
        }



        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các điều khiển trên form
                string idKho = (cb_Kho.SelectedItem as KeyValuePair<string, string>?)?.Key ?? "";
                string idNhaCC = (cb_NhaCC.SelectedItem as KeyValuePair<string, string>?)?.Key ?? "";
                string idNhanVien = txt_IDNhanVien.Text?.Trim(); // Lấy ID nhân viên từ TextBox ẩn
                string ghiChu = txt_GhiChu.Text?.Trim();
                DateTime ngayNhap = dte_NgayNhap.EditValue == null ? DateTime.Now : (DateTime)dte_NgayNhap.EditValue;

                // Kiểm tra dữ liệu đầu vào cần thiết
                if (string.IsNullOrEmpty(idKho) || string.IsNullOrEmpty(idNhaCC))
                {
                    MessageBox.Show("Vui lòng chọn Kho và Nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!(gc_SanPham.DataSource is DataTable dataTable) || dataTable.Rows.Count == 0)
                {
                    MessageBox.Show(gc_SanPham.DataSource == null
                        ? "Không tìm thấy nguồn dữ liệu. Vui lòng kiểm tra lại."
                        : "Danh sách thuốc nhập trống. Vui lòng thêm thuốc vào danh sách.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Lấy danh sách chi tiết phiếu nhập từ GridView
                List<ChiTietNhapKhoDTO> chiTietPhieuNhapList = new List<ChiTietNhapKhoDTO>();
                foreach (DataRow row in dataTable.Rows)
                {
                    // Kiểm tra các trường bắt buộc
                    if (row["TenThuoc"] == DBNull.Value || row["SoLuong"] == DBNull.Value || row["DonGia"] == DBNull.Value)
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại thông tin các cột Tên Thuốc, Số Lượng, và Đơn Giá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tạo đối tượng chi tiết phiếu nhập
                    ChiTietNhapKhoDTO chiTiet = new ChiTietNhapKhoDTO
                    {
                        IDThuoc = row["IDThuoc"]?.ToString(),
                        NgaySanXuat = row["NgaySanXuat"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(row["NgaySanXuat"]),
                        NgayHetHan = row["NgayHetHan"] == DBNull.Value ? DateTime.Now.AddMonths(6) : Convert.ToDateTime(row["NgayHetHan"]),
                        QuyCach = row["TenDVT"]?.ToString(),
                        SoLuong = Convert.ToInt32(row["SoLuong"]),
                        GiaDonVi = Convert.ToSingle(row["DonGia"]),
                        ThanhTien = Convert.ToInt32(row["SoLuong"]) * Convert.ToSingle(row["DonGia"]) // Tính Thành tiền
                    };
                    chiTietPhieuNhapList.Add(chiTiet);
                }

                if (chiTietPhieuNhapList.Count == 0)
                {
                    MessageBox.Show("Danh sách chi tiết phiếu nhập trống. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận trước khi lưu
                DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn muốn lưu phiếu nhập này?", "Xác nhận lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.No) return;

                // Gọi hàm lưu vào cơ sở dữ liệu
                string newPhieuNhapID = nhapKhoBLL.ThemPhieuNhapVaChiTiet(
                    ngayNhap,
                    idKho,
                    idNhaCC,
                    idNhanVien,
                    ghiChu,
                    chiTietPhieuNhapList
                );

                // Kiểm tra giá trị trả về
                if (!string.IsNullOrEmpty(newPhieuNhapID))
                {
                    MessageBox.Show($"Thêm phiếu nhập thành công với ID: {newPhieuNhapID}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm(); // Reset dữ liệu sau khi lưu thành công
                    LoadDanhSachPhieuNhap();

                    txt_GhiChu.Enabled = false;
                    cb_Kho.Enabled = false;
                    cb_NhaCC.Enabled = false;
                    cb_ChonThuoc.Enabled = false;

                    btn_Luu.Enabled = false;
                    btn_XoaSP.Enabled = false;
                    btn_Them.Enabled = true;
                    btn_Xoa.Enabled = true;
                    btn_Them1Thuoc.Enabled = false;

                    gc_SanPham.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Tạo phiếu thất bại: Không nhận được ID phiếu nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu phiếu nhập: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ResetForm()
        {
            // Xóa dữ liệu trong GridControl và tạo một DataTable trống để làm sạch DataSource
            DataTable emptyDataTable = new DataTable();
            emptyDataTable.Columns.Add("Tên thuốc", typeof(string));
            emptyDataTable.Columns.Add("Mã thuốc", typeof(string));
            emptyDataTable.Columns.Add("Ngày sản xuất", typeof(DateTime));
            emptyDataTable.Columns.Add("Ngày hết hạn", typeof(DateTime));
            emptyDataTable.Columns.Add("Đơn Vị Tính", typeof(string));
            emptyDataTable.Columns.Add("Số lượng", typeof(int));
            emptyDataTable.Columns.Add("Đơn giá", typeof(float));
            emptyDataTable.Columns.Add("Thành tiền", typeof(float));

            gc_SanPham.DataSource = emptyDataTable;
            gv_SanPham.RefreshData(); // Làm mới lại GridView

            // Xóa dữ liệu trong các TextBox
            txt_GhiChu.Clear();
            txt_TongTien.Clear();
            txt_NhanVien.Clear();
            txt_TrangThai.Clear();

            // Đặt lại lựa chọn trong ComboBox
            cb_Kho.SelectedIndex = -1;
            cb_NhaCC.SelectedIndex = -1;

            // Đặt lại DateEdit (xóa giá trị ngày)
            dte_NgayNhap.EditValue = null;

            // Gọi lại AddCot và LoadThuocIntoComboBox để đảm bảo ComboBox vẫn hoạt động như mong muốn
            AddCot();
        }

        private void LoadDanhSachPhieuNhap()
        {
            try
            {
                DataTable dtPhieuNhap = nhapKhoBLL.HienThiPhieuNhap();
                dgv_PhieuNhap.DataSource = dtPhieuNhap;

                // Ẩn tất cả các cột trước
                foreach (DataGridViewColumn column in dgv_PhieuNhap.Columns)
                {
                    column.Visible = false;
                }

                // Chỉ hiển thị các cột cần thiết
                dgv_PhieuNhap.Columns["IDPhieuNhap"].Visible = true;
                dgv_PhieuNhap.Columns["NgayNhap"].Visible = true;
                dgv_PhieuNhap.Columns["TrangThai"].Visible = true;

                // Đặt tiêu đề cho các cột (nếu cần)
                dgv_PhieuNhap.Columns["IDPhieuNhap"].HeaderText = "Mã Phiếu Nhập";
                dgv_PhieuNhap.Columns["NgayNhap"].HeaderText = "Ngày Nhập";
                dgv_PhieuNhap.Columns["TrangThai"].HeaderText = "Trạng Thái";

                // Canh đều các cột trong DataGridView
                foreach (DataGridViewColumn column in dgv_PhieuNhap.Columns)
                {
                    if (column.Visible)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Tự động giãn đều
                        //column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa nội dung
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa tiêu đề
                    }
                }

                // Tùy chỉnh thêm nếu cần
                dgv_PhieuNhap.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách phiếu nhập: " + ex.Message);
            }
        }

        private void btn_Them1Thuoc_Click(object sender, EventArgs e)
        {
            ThemThuoc frm = new ThemThuoc(username, password);
            frm.Show();
        }

        

        private void dgv_PhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy IDPhieuNhap từ dòng được chọn
                string idPhieuNhap = dgv_PhieuNhap.Rows[e.RowIndex].Cells["IDPhieuNhap"].Value.ToString();

                try
                {
                    // Gọi BLL để lấy thông tin phiếu nhập và chi tiết phiếu nhập
                    DataSet dsPhieuNhap = nhapKhoBLL.LayThongTinPhieuNhapTheoID(idPhieuNhap);

                    // Hiển thị thông tin phiếu nhập
                    if (dsPhieuNhap.Tables[0].Rows.Count > 0)
                    {
                        DataRow phieuNhapRow = dsPhieuNhap.Tables[0].Rows[0];

                        // Hiển thị thông tin phiếu nhập lên các điều khiển
                        txt_IDPN.Text = phieuNhapRow["IDPhieuNhap"].ToString();
                        dte_NgayNhap.EditValue = Convert.ToDateTime(phieuNhapRow["NgayNhap"]);

                        // Hiển thị loại kho
                        cb_Kho.SelectedItem = cb_Kho.Items.Cast<KeyValuePair<string, string>>()
                            .FirstOrDefault(item => item.Value == phieuNhapRow["LoaiKho"].ToString());

                        // Hiển thị nhà cung cấp
                        cb_NhaCC.SelectedItem = cb_NhaCC.Items.Cast<KeyValuePair<string, string>>()
                            .FirstOrDefault(item => item.Value == phieuNhapRow["TenNhaCC"].ToString());

                        // Hiển thị tên nhân viên trong TextBox
                        txt_NhanVien.Text = phieuNhapRow["TenNhanVien"].ToString();

                        // Hiển thị ghi chú và tổng tiền
                        txt_GhiChu.Text = phieuNhapRow["GhiChu"].ToString();
                        txt_TongTien.Text = Convert.ToDecimal(phieuNhapRow["TongTien"]).ToString("#,##0 ₫");

                        // Hiển thị trạng thái trong TextBox
                        txt_TrangThai.Text = phieuNhapRow["TrangThai"].ToString();
                    }

                    // Hiển thị chi tiết phiếu nhập
                    if (dsPhieuNhap.Tables[1].Rows.Count > 0)
                    {
                        gc_SanPham.DataSource = dsPhieuNhap.Tables[1];
                        gv_SanPham.PopulateColumns();

                        // Ẩn cột IDChiTietPhieuNhap
                        if (gv_SanPham.Columns["IDChiTietPhieuNhap"] != null)
                        {
                            gv_SanPham.Columns["IDChiTietPhieuNhap"].Visible = false;
                        }

                        // Đặt tên cho các cột trong GridView
                        gv_SanPham.Columns["TenThuoc"].Caption = "Tên thuốc";
                        gv_SanPham.Columns["IDThuoc"].Caption = "Mã thuốc";
                        gv_SanPham.Columns["ThanhPhan"].Caption = "Thành phần";
                        gv_SanPham.Columns["NgaySanXuat"].Caption = "Ngày sản xuất";
                        gv_SanPham.Columns["NgayHetHan"].Caption = "Ngày hết hạn";
                        gv_SanPham.Columns["QuyCach"].Caption = "Quy cách";
                        gv_SanPham.Columns["SoLuong"].Caption = "Số lượng";
                        gv_SanPham.Columns["GiaDonVi"].Caption = "Đơn giá";
                        gv_SanPham.Columns["ThanhTien"].Caption = "Thành tiền";

                        // Định dạng cột Thành tiền trong GridView
                        gv_SanPham.Columns["ThanhTien"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        gv_SanPham.Columns["ThanhTien"].DisplayFormat.FormatString = "#,##0 ₫";
                    }
                    else
                    {
                        gc_SanPham.DataSource = null;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hiển thị chi tiết phiếu nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
